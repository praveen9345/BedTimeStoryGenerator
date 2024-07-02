namespace BedTimeStory.Components.UiFunctionality.Navigation
{
    /// <summary>
    ///     Interface of the service providing navigation functionality.
    /// </summary>
    public interface INavigationService
    {
        /// <summary>
        ///     Navigates to a page.
        /// </summary>
        /// <typeparam name="T"> The class of the page. </typeparam>
        /// <returns> An awaitable task. </returns>
        Task Navigate<T>() where T : Page;

        /// <summary>
        ///     Navigates to a page while passing a parameter.
        /// </summary>
        /// <typeparam name="T"> The class of the page. </typeparam>
        /// <param name="parameter"> The parameter to pass. </param>
        /// <param name="fromRoot"> Optionally reset the view stack. </param>
        /// <returns> An awaitable task. </returns>
        Task Navigate<T>(object parameter, bool fromRoot) where T : Page;

        /// <summary>
        ///     This method navigates to a specific page of type T asynchronously.
        /// </summary>
        /// <param name="parameter"> The parameter to pass.</param>
        /// <returns> A task representing the asynchronous navigation operation and returning a result of type TReturn. </returns>
        Task<TReturn> OpenDialogAndAwaitResultAsync<T, TParameter, TReturn>(TParameter parameter) where T : ContentPage;

        /// <summary>
        ///     This method navigates to a specific page of type T asynchronously.
        /// </summary>
        /// <returns> A task representing the asynchronous navigation operation and returning a result of type TReturn. </returns>
        Task<TReturn> OpenDialogAndAwaitResultAsync<T, TReturn>() where T : ContentPage;

        /// <summary>
        ///     Closes the current view and navigates back to the previous view.
        /// </summary>
        /// <returns>An awaitable task.</returns>
        Task Close();

        /// <summary>
        ///     Closes the current dialog and navigates back in the application.
        /// </summary>
        /// <param name="result">The dialog result to pass back to the dialog caller.</param>
        void CloseDialog<TReturn>(TReturn result);

        /// <summary>
        ///     Closes the current view, navigates back to the previous screen and passes the
        ///     provided parameters.
        /// </summary>
        /// <param name="parameter">The parameter to pass to the previous view.</param>
        /// <returns>A task awaiting the navigation.</returns>
        Task Close<TParameter>(TParameter parameter);

        /// <summary>
        ///      Get the ViewModel of the previous page.
        /// </summary>
        /// <typeparam name="T">The type of the ViewModel.</typeparam>
        /// <returns>The ViewModel of the specified type, or default if not found.</returns>
        public T GetPageViewModel<T>() where T : class,new();
    }
}