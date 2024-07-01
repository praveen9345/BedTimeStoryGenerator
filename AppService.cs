namespace BedTimeStory
{
    using BedTimeStory.Components.UiFunctionality.Navigation;
    using BedTimeStory.Components.PlatformUtils;
    using BedTimeStory.Components.CoreFeatures.Onboarding.Views;

    /// <summary>
    /// Represents a service responsible for initializing and managing various application components.
    /// We use this in favor of the base class to migrate the databases on app start and to initialize
    /// the connection to App Center for error logging.
    /// </summary>
    public class AppService : IAppService
    {

         private readonly INavigationService _navigationService;

        /// <summary>
        ///     Initializes the application.
        /// </summary>
        /// <param name="serviceProvider">The service provider to retrieve registered services.</param>
        public AppService()
        {
            _navigationService = ServiceHelper.GetService<INavigationService>();
        }
       /// <summary>
        ///     The method used for
        ///     - Performing the initial download of the ifu
        ///     - Redirecting to the Login screen.
        ///     - Setting the default culture
        /// </summary>
        public async Task OnStartAsync()
        {
            //await NavigateToFirstViewModelAsync();
            await _navigationService.Navigate<WelcomeView>();
        }


        //TODO: Navigate to first viewModel
        

    }

    /// <summary>
    ///     Interface of the service with method for starting the service asynchronously.
    /// </summary>
    public interface IAppService
    {
        /// <summary>
        ///     Performs necessary actions to start the application service asynchronously.
        /// </summary>
        /// <returns> An awaitable task. </returns>
        Task OnStartAsync();

    }
}
