namespace BedTimeStory.Components.CoreFeatures.Onboarding.ViewModels
{
    using UiFunctionality.Navigation.ViewModels;

    /// <summary>
    ///     The view model of the log in screen.
    /// </summary>
    public partial class LoginViewModel : BaseViewModel
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LoginViewModel" />.
        /// </summary>
             public LoginViewModel()
        {
            IsBackNavigationEnabled = false;
        }

        /// <summary>
        /// Initializes the component asynchronously, ensuring proper initialization of general information
        /// and notification permissions.
        /// </summary>
        /// <returns>An awaitable task.</returns>
        public override async Task InitializeAsync()
        {
            await base.InitializeAsync();

        }
    }
}