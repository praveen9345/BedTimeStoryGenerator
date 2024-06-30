namespace BedTimeStory.Components.UiFunctionality.Navigation.ViewModels
{
    /// <summary>
    ///     The implementation of a base view model enabling the transfer of a result.
    /// </summary>
    public abstract class BaseViewModelResult<TResult> : BaseViewModel
        where TResult : notnull
    {
        /// <summary>
        ///     Initializes an instance of <see cref="BaseViewModelResult{TResult}"/> class.
        /// </summary>
        protected BaseViewModelResult(){ }
    }
}
