namespace BedTimeStory.Components.UiFunctionality.Navigation.Views
{
    using ViewModels;
    using Microsoft.Maui.Graphics;
    using Microsoft.Maui.Controls;
    using Microsoft.Maui.Controls.PlatformConfiguration;
    using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

    /// <summary>
    /// The implementation of a base view that provides general logic and information needed for all views.
    /// </summary>
    public class BaseView : ContentPage
    {
        protected readonly BaseViewModel ViewModel;
        private bool _isInitialized;

        /// <summary>
        /// The default constructor of BaseView.
        /// </summary>
        public BaseView(BaseViewModel viewModel)
        {
            BindingContext = this.ViewModel = viewModel;
            BackgroundColor = Colors.White;
            Shell.SetNavBarIsVisible(this, false);

            On<iOS>().SetUseSafeArea(true);

            ControlTemplate = Microsoft.Maui.Controls.Application.Current?.Resources["ContentPageTemplate"] as ControlTemplate;

            Loaded += OnLoaded;
        }

        /// <summary>
        ///     Trigger the view appearing event as soon as the view is loaded.
        /// </summary>
        private void OnLoaded(object sender, EventArgs e)
        {
            ViewModel.ViewAppearing();
        }

        /// <summary>
        ///     Handles the back button tap.
        ///     Prevents the back navigation, if defined in the corresponding view model.
        /// </summary>
        /// <returns>A value indicating whether back navigation was handled.</returns>
        protected override bool OnBackButtonPressed()
        {
            if (ViewModel.IsBackNavigationEnabled)
            {
                ViewModel.BackNavigationCommand.Execute(null);
            }

            return true;
        }

        /// <summary>
        ///     Despite the naming <see cref="OnAppearing"/> is triggered before the view is loaded,
        ///     thus we use it for the initialization of the view model and trigger the appearing event
        ///     as soon as the view is actually loaded.
        ///
        ///     Using <see cref="Microsoft.Maui.Controls.Page.NavigatedTo"/> would also be an option, but it was
        ///     called that early that in some cases it lead to having the previously view model still active.
        /// </summary>
        protected override void OnAppearing()
        {
            if (!_isInitialized)
            {
                _isInitialized = true;
                _ = ViewModel.InitializeAsync();
            }
            else
            {
                ViewModel.ViewAppearing();
            }

            base.OnAppearing();
        }

        /// <summary>
        ///    Handles the event when the page is being hidden or removed from the display.
        /// </summary>
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ViewModel.ViewDisappearing();
        }
    }
}