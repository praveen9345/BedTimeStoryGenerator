namespace BedTimeStory.Components.CoreFeatures.Onboarding.Views
{
    using UiFunctionality.Navigation.Views;
    using ViewModels;

    /// <summary>
    /// The code behind of the RegistrationView view.
    /// </summary>
    public partial class RegistrationView : BaseView
    {
        /// <summary>
        ///  Initializes a new instance of the RegistrationView class with the specified view model.
        /// </summary>
        /// <param name="viewModel">The RegistrationView associated with this view.</param>
        public RegistrationView(RegistrationViewModel viewModel):base(viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}