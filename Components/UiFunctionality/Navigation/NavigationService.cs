namespace BedTimeStory.Components.UiFunctionality.Navigation
{
    using BedTimeStory.Components.PlatformUtils.Wrappers;
    
    /// <summary>
    ///     Implementation of the service providing navigation functionality.
    /// </summary>
    public class NavigationService : INavigationService
    {
        private readonly INavigationShellWrapper _shellWrapper;

        /// <summary>
        ///     Initializes a new instance of the <see cref="NavigationService"/> class
        ///     with the specified <see cref="INavigationShellWrapper"/>.
        /// </summary>
        /// <param name="navigationShellWrapper">The navigation shell wrapper.</param>
        public NavigationService(INavigationShellWrapper navigationShellWrapper)
        {
            _shellWrapper = navigationShellWrapper;
        }

        /// <summary>
        ///     Maintain dialog completion sources to keep track of dialog results.
        ///     A list is used to enable correct handling of dialog results, even if one dialog is shown on top of another dialog.
        /// </summary>
        private static IList<TaskCompletionSource<object>> DialogCloseCompletionSource { get; set; } =
            new List<TaskCompletionSource<object>>();

        /// <summary>
        ///     Navigates to a page.
        /// </summary>
        /// <typeparam name="T"> The class of the page. </typeparam>
        /// <returns> An awaitable task. </returns>
        public Task Navigate<T>() where T : Page
        {
            return _shellWrapper.GoToAsync( GetShellPath<T>(), false);
        }

        /// <summary>
        ///     Navigates to a page while passing a parameter.
        /// </summary>
        /// <typeparam name="T"> The class of the page. </typeparam>
        /// <param name="parameter"> The parameter to pass. </param>
        /// <returns> An awaitable task. </returns>
        public async Task Navigate<T>(object parameter, bool fromRoot = false) where T : Page
        {
            var dictionary = new Dictionary<string, object>()
            {
                {"parameter", parameter}
            };

            if(fromRoot)
            {
                await _shellWrapper.PopToRootAsync(true);
            }
            await _shellWrapper.GoToAsync( GetShellPath<T>(), false, dictionary);
        }

        private string GetShellPath<T>()
        {
            var name = typeof(T).Name;
            var location = _shellWrapper.GetCurrentState().Location.ToString();

            if (location.Contains(name))
            {
                return location.Substring(0, location.IndexOf(name) + name.Length);
              
            }
            return name;
        }


        /// <summary>
        ///     This method navigates to a specific dialog of type T and awaits its result.
        /// </summary>
        /// <remarks>
        ///     Please make sure to call the corresponding <see cref="INavigationService.CloseDialog{TReturn}"/>
        ///     within the opened dialog, to ensure a correct closure of dialogs.
        /// </remarks>
        /// <param name="parameter"> The parameter to pass.</param>
        /// <returns> A task representing the asynchronous navigation operation and returning a result. </returns>
        public async Task<TReturn> OpenDialogAndAwaitResultAsync<T, TParameter, TReturn>(TParameter parameter) where T : ContentPage
            where TReturn : notnull
        {
            var dictionary = new Dictionary<string, object>()
            {
                {"parameter", parameter},
            };

            var taskCompletionSource = new TaskCompletionSource<object>();
            DialogCloseCompletionSource.Add(taskCompletionSource);
            await _shellWrapper.GoToAsync(typeof(T).Name, false, dictionary);

            var value = (TReturn) await taskCompletionSource.Task;

            await _shellWrapper.GoToAsync("..", false);

            return value;
        }

        /// <summary>
        ///     This method navigates to a specific page of type T asynchronously.
        /// </summary>
        /// <returns> A task representing the asynchronous navigation operation and returning a result of type TReturn. </returns>
        public async Task<TReturn> OpenDialogAndAwaitResultAsync<T, TReturn>() where T : ContentPage
            where TReturn : notnull
        {
            var taskCompletionSource = new TaskCompletionSource<object>();
            DialogCloseCompletionSource.Add(taskCompletionSource);
            await _shellWrapper.GoToAsync(typeof(T).Name, false);

            var value = (TReturn)await taskCompletionSource.Task;

            await _shellWrapper.GoToAsync("..", false);

            return value;
        }

      
        /// <summary>
        ///     Closes the current view and navigates back to the previous view.
        /// </summary>
        /// <returns>An awaitable task.</returns>
        public async Task Close()
        {
            await _shellWrapper.GoToAsync("..", false);
        }

        /// <summary>
        ///     Closes the current dialog and navigates back in the application.
        /// </summary>
        /// <param name="result">The dialog result to pass back to the dialog caller.</param>
        public void CloseDialog<TReturn>(TReturn result)
        {
            var taskCompletionSource = DialogCloseCompletionSource.LastOrDefault();
            if (taskCompletionSource!= null && taskCompletionSource.TrySetResult(result))
            {
                DialogCloseCompletionSource.Remove(taskCompletionSource);
            }
        }

        /// <summary>
        ///     Closes the current view, navigates back to the previous screen and passes the
        ///     provided parameters.
        /// </summary>
        /// <param name="parameter">The parameter to pass to the previous view.</param>
        /// <returns>A task awaiting the navigation.</returns>
        public async Task Close<TParameter>(TParameter parameter)
        {
            var parameterDictionary = new Dictionary<string, object>
            {
                {"parameter", parameter}
            };

            await _shellWrapper.GoToAsync("..", false, parameterDictionary);
        }

        /// <summary>
        ///     Changes the presentation to a new page.
        /// </summary>
        /// <param name="typeOfPriorViewModel"> The type of the prior view model.</param>
        /// <returns> A task representing the asynchronous operation. </returns>
        public async Task ChangePresentation(Type typeOfPriorViewModel)
        {
            await _shellWrapper.GoToAsync(typeOfPriorViewModel.Name.Replace("ViewModel", "View"), false);
        }

        /// <summary>
        ///      Get the ViewModel of the previous page.
        /// </summary>
        /// <typeparam name="T">The type of the ViewModel.</typeparam>
        /// <returns>The ViewModel of the specified type, or default if not found.</returns>
        public T GetPageViewModel<T>() where T : class,new()
        {

            var page = GetPageOfType<T>();
            return page?.BindingContext as T;
        
        }

        private Page GetPageOfType<T>() where T : class
        {
        return Shell.Current.Navigation.NavigationStack
            .FirstOrDefault(page => page != null && page.BindingContext is T);
        }

    }

}