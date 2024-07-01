namespace BedTimeStory.Components.PlatformUtils.Wrappers
{
    /// <summary>
    ///     Wrapper interface for navigation functionality within a Maui Shell application.
    /// </summary>
    public interface INavigationShellWrapper
    {
        /// <summary>
        /// Navigates to the specified route with optional animation and parameters.
        /// </summary>
        /// <param name="route">The route to navigate to.</param>
        /// <param name="animate">Determines whether the navigation should be animated.</param>
        /// <param name="parameters">Optional parameters to pass to the route.</param>
        /// <returns>A task that represents the asynchronous navigation operation.</returns>
        public Task GoToAsync(string route, bool animate, IDictionary<string, object> parameters = null);


        /// <summary>
        /// Navigates to the specified route with optional animation.
        /// </summary>
        /// <param name="route">The route to navigate to.</param>
        /// <param name="animate">Determines whether the navigation should be animated.</param>
        /// <returns>A task that represents the asynchronous navigation operation.</returns>
        public Task GoToAsync(string route, bool animate);

        /// <summary>
        /// Gets the current state of the Shell navigation.
        /// </summary>
        /// <returns>The current <see cref="ShellNavigationState"/>.</returns>
        public ShellNavigationState GetCurrentState();

    }
}
