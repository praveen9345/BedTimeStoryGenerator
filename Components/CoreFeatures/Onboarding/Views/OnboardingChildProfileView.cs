namespace BedTimeStory.Components.CoreFeatures.Onboarding.Views
{
    using UiFunctionality.Navigation.Views;
    using ViewModels;

    /// <summary>
    /// The code behind of the OnboardingChildProfileView view.
    /// </summary>
    public partial class OnboardingChildProfileView : BaseView
    {
        /// <summary>
        ///  Initializes a new instance of the LoginView class with the specified view model.
        /// </summary>
        /// <param name="viewModel">The OnboardingChildProfileViewModel associated with this view.</param>
        public OnboardingChildProfileView(OnboardingChildProfileViewModel viewModel):base(viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}