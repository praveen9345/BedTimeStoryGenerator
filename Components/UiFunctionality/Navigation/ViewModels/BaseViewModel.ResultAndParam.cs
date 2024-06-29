namespace BedTimeStory.Components.UiFunctionality.Navigation.ViewModels
{
    /// <summary>
    ///     The implementation of a base view model enabling the transfer of a parameter and result.
    /// </summary>
    public abstract class BaseViewModel<TParameter, TResult> : BaseViewModelResult<TResult>, IQueryAttributable
        where TParameter : notnull
        where TResult : notnull
    {
        protected IDictionary<string, object> NavigationParameters;

        /// <summary>
        ///     Initializes an instance of <see cref="BaseViewModel{TParameter,TResult}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider to retrieve registered services.</param>
        protected BaseViewModel(IServiceProvider serviceProvider) : base(serviceProvider) {}

        /// <summary>
        ///     Enabled to prepare the current view model with the passed parameter.
        /// </summary>
        /// <param name="parameter">The parameter object.</param>
        public abstract void Prepare(TParameter parameter);

        /// <summary>
        ///     Sets the parameters that were passed on navigation.
        /// </summary>
        /// <param name="query">The parameters that were passed as a dictionary.</param>
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            NavigationParameters = query;

            if (query.ContainsKey("parameter") && (query["parameter"] is TParameter param))
            {
                Prepare(param);
                query.Clear();
            }
        }
    }
}
