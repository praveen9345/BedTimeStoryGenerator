namespace BedTimeStory
{
    using CommunityToolkit.Maui;
    using Microsoft.Extensions.Logging;
    using Microsoft.Maui.Controls.Compatibility.Hosting;
    using BedTimeStory.Components.PlatformUtils;
    using System.Reflection;
    using UraniumUI;

    /// <summary>
    ///     The core start point of the MAUI Program.
    /// </summary> 
    public static class MauiProgram
    {
        
        /// <summary>
        ///     The main entry point for the MAUI application.
        /// </summary>
        /// <returns>MAUI application.</returns>
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCompatibility()
                .UseUraniumUI()
                .UseUraniumUIMaterial()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("FluentSystemIcons-Filled.ttf", "FluentIcons");
                })
                .RegisterServices()
                .RegisterViewsAndViewModels();

            var app = builder.Build();

            // Needs to be initialized after building the app to link the services to the created singletons.
            ServiceHelper.Initialize(app.Services);

            return app;
        }

        /// <summary>
        ///     Registers all classes of which the name ends with "Service" 
        ///     and that have an interface whose name ends with the name of the service.
        /// </summary>
        /// <param name="builder">The app in which the services are registered.</param>
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {

            string[] singletonTypeEndings =
            {
                "Service", "Manager", "Wrapper", "Logger", "Provider", "Scheduler", "Handler", "Client", "Builder",
                "Validator", "Helper"
            };

            var exportedTypes = Assembly.GetExecutingAssembly().GetExportedTypes();

            foreach (var singletonType in singletonTypeEndings)
            {
                foreach (var service in exportedTypes)
                {
                    if (!service.IsInterface && service.Name.EndsWith(singletonType)
                                             && !service.Name.EndsWith("HttpClientWrapper") && !service.IsAbstract)
                    {
                        var interfaceType = service.GetInterfaces().FirstOrDefault(type =>
                            type.Name.EndsWith(service.Name));

                        if (interfaceType != null)
                        {
                            builder.Services.AddSingleton(interfaceType, service);
                        }
                    }
                }
            }
            return builder;
        }

        /// <summary>
        ///     Registers all classes of which the name ends with "ViewModel" 
        ///     and tries to register a matching view for each view model.
        /// </summary>
        /// <param name="builder">The app builder.</param>
        public static MauiAppBuilder RegisterViewsAndViewModels(this MauiAppBuilder builder)
        {
            var types = Assembly.GetExecutingAssembly().GetExportedTypes();

            foreach (var type in types)
            {
                if (type.Name.EndsWith("ViewModel") && !type.IsAbstract)
                {
                    var viewType = types.FirstOrDefault(t => t.Name == type.Name.Replace("ViewModel", "View"));
                    if (viewType != null)
                    {
                        builder.Services.AddTransient(type);
                        builder.Services.AddTransient(viewType);
                    }
                }
            }
            return builder;
        }

    }
}
