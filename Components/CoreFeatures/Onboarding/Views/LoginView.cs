namespace BedTimeStory.Components.CoreFeatures.Onboarding.Views
{
    using UiFunctionality.Navigation.Views;
    using ViewModels;

    /// <summary>
    /// The code behind of the RegistrationView view.
    /// </summary>
    public partial class LoginView : BaseView
    {
        /// <summary>
        ///  Initializes a new instance of the LoginView class with the specified view model.
        /// </summary>
        /// <param name="viewModel">The LoginViewModel associated with this view.</param>
        public LoginView(LoginViewModel viewModel):base(viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}