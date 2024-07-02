namespace BedTimeStory.Components.PlatformUtils.Wrappers
{
    /// <summary>
    ///  Wrapper class for provides navigation functionality within a Maui Shell application.
    /// </summary>
    public class NavigationShellWrapper :INavigationShellWrapper
    {
        /// <summary>
        /// Navigates to the specified route with optional animation and parameters.
        /// </summary>
        /// <param name="route">The route to navigate to.</param>
        /// <param name="animate">Determines whether the navigation should be animated.</param>
        /// <param name="parameters">Optional parameters to pass to the route.</param>
        /// <returns>A task that represents the asynchronous navigation operation.</returns>
        public Task GoToAsync(string route, bool animate, IDictionary<string, object> parameters = null)
        {
            return Shell.Current.GoToAsync(route, animate, parameters);
        }

        /// <summary>
        /// Navigates to the specified route with optional animation.
        /// </summary>
        /// <param name="route">The route to navigate to.</param>
        /// <param name="animate">Determines whether the navigation should be animated.</param>
        /// <returns>A task that represents the asynchronous navigation operation.</returns>
        public Task GoToAsync(string route, bool animate)
        {
            return Shell.Current.GoToAsync(route, animate);
        }

        /// <summary>
        /// Gets the current state of the Shell navigation.
        /// </summary>
        /// <returns>The current <see cref="ShellNavigationState"/>.</returns>
        public ShellNavigationState GetCurrentState()
        {
            return Shell.Current.CurrentState;
        }

        /// <summary>
        /// A task for asyncronization poping allpages off of the navigation stack.
        /// </summary>
        /// <param name="animate">Determines whether the navigation should be animated.</param>
        /// <returns>The current <see cref="ShellNavigationState"/>.</returns>
        public Task PopToRootAsync(bool animation)
        {
            return Shell.Current.Navigation.PopToRootAsync(animation);
        }

    }
}
