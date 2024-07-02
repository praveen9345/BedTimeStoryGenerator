namespace BedTimeStory;

/// <summary>
///     Class representing the cross-platform application.
/// </summary>
public partial class App : Application
{
	private readonly IAppService _appService;

	/// <summary>
	///     Initializes the application.
	/// </summary>
	/// <param name="appService">The service used by the application.</param>
	public App(IAppService appService)
	{
		InitializeComponent();

		_appService = appService;

		MainPage = new AppShell();
	}

	/// <summary>
	/// Invoked when the application starts.
	/// </summary>
	/// <remarks>
	/// This method is called when the application is launched. It overrides the base class's <see cref="OnStart"/> method
	/// to perform necessary initialization tasks for the application. It calls the <c>OnStartAsync</c> method of the
	/// associated <see cref="AppService"/> instance asynchronously.
	/// </remarks>
	protected override async void OnStart()
	{
		base.OnStart();
		Current.UserAppTheme = AppTheme.Dark;
		await _appService.OnStartAsync();
	}

}
