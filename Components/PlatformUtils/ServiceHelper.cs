namespace BedTimeStory.Components.PlatformUtils;

/// <summary>
///     This service helper class shall be used if it is not possible to inject the <see cref="IServiceProvider" /> in a
///     class there it is needed to resolve a specific service. Additionally it can be used in the platform specific code
///     to
///     resolve the services of the app.
/// </summary>
public static class ServiceHelper
{
    /// <summary>
    ///     This property contains the <see cref="IServiceProvider" /> of the <see cref="MauiApp" /> which needs to be set in
    ///     <see cref="Initialize" /> initially.
    /// </summary>
    public static IServiceProvider Services { get; private set; }

    /// <summary>
    ///     This method needs to be called in <see cref="MauiProgram.CreateMauiApp" /> after the <see cref="MauiApp" /> has
    ///     been builded with the dedicated <see cref="MauiAppBuilder" />.
    /// </summary>
    public static void Initialize(IServiceProvider serviceProvider)
    {
        Services = serviceProvider;
    }

    /// <summary>
    ///     Use this method to get an arbitrary service which has been added as singleton in
    ///     <see cref="MauiProgram.RegisterServices" /> method.
    /// </summary>
    public static T GetService<T>()
    {
        return Services.GetService<T>();
    }
}