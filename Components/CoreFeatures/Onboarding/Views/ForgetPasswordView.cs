namespace BedTimeStory.Components.CoreFeatures.Onboarding.Views
{
    using UiFunctionality.Navigation.Views;
    using ViewModels;

    /// <summary>
    /// The code behind of the ForgetPasswordView view.
    /// </summary>
    public partial class ForgetPasswordView : BaseView
    {
        /// <summary>
        ///  Initializes a new instance of the LoginView class with the specified view model.
        /// </summary>
        /// <param name="viewModel">The ForgetPasswordViewModel associated with this view.</param>
        public ForgetPasswordView(ForgetPasswordViewModel viewModel):base(viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}