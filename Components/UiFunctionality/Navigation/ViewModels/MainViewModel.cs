namespace BedTimeStory.Components.UiFunctionality.Navigation.ViewModels
{
    /// <summary>
    ///     MainViewModel that inherits from BaseViewModel and is used by Android MainActivity.
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        ///     Initializes a new instance of the class <see cref="MainViewModel"/>.
        /// </summary>
        /// <param name="serviceProvider">The service provider to retrieve registered services.</param>
        public MainViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            ShallCurrentViewModelBeSet = false;
        }
    }
}