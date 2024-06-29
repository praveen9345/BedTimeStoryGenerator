namespace BedTimeStory
{
    using System.Reflection;

	/// <summary>
	///     AppShell class for describing the visual hierarchy of the application.
	/// </summary>
	public partial class AppShell : Shell
	{
		/// <summary>
		///     AppShell constructor for initializing the component on the target OS.
		/// </summary>
		public AppShell()
		{
			InitializeComponent();
			 var views = Assembly.GetExecutingAssembly().GetExportedTypes()
                .Where(t => t.Name.EndsWith("View"));

            foreach (var view in views)
            {
                Routing.RegisterRoute(view.Name, view);
            }
		}
	}
}
