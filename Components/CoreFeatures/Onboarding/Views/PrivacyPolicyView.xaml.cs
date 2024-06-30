namespace BedTimeStory.Components.CoreFeatures.Onboarding.Views
{
    using UiFunctionality.Navigation.Views;
    using ViewModels;

    /// <summary>
    /// The code behind of the privacy policy view.
    /// </summary>
    public partial class PrivacyPolicyView : BaseView
    {
        /// <summary>
        ///  Initializes a new instance of the PrivacyPolicyView class with the specified view model.
        /// </summary>
        /// <param name="viewModel">The PrivacyPolicyViewModel associated with this view.</param>
        public PrivacyPolicyView(PrivacyPolicyViewModel viewModel):base(viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;       }
    }
}