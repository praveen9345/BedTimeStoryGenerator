namespace BedTimeStory.Components.CoreFeatures.Onboarding.ViewModels
{
    using UiFunctionality.Navigation.ViewModels;

    /// <summary>
    ///     The view model of the privacy policy screen.
    /// </summary>
    public partial class RegistrationViewModel : BaseViewModel
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RegistrationViewModel" />.
        /// </summary>
             public RegistrationViewModel()
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