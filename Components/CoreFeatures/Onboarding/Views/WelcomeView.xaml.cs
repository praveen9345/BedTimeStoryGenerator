namespace BedTimeStory.Components.CoreFeatures.Onboarding.Views
{
    using UiFunctionality.Navigation.Views;
    using ViewModels;

    /// <summary>
    /// The code behind of the WelCome View Model.
    /// </summary>
    public partial class WelcomeView : BaseView
    {
        /// <summary>
        ///  Initializes a new instance of the WelComeViewModel class with the specified view model.
        /// </summary>
        /// <param name="viewModel">The WelComeViewModel associated with this view.</param>
        public WelcomeView(WelcomeViewModel viewModel):base(viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private async void OnEmailButtonTapped(object sender, EventArgs e)
        {
            var frame = sender as Frame;
            if (frame != null)
            {
                frame.BackgroundColor = Colors.Black; // Change to a darker color on tap
                await Task.Delay(100); // Delay for the visual effect
                frame.BackgroundColor = Colors.White; // Revert to original color
            }

            // Handle the actual button click event here
           // await DisplayAlert("Tapped", "Email button tapped", "OK");
        }
    }

    
}