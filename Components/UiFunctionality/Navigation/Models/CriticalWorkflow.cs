namespace BedTimeStory.Components.UiFunctionality.Navigation.Models
{
    /// <summary>
    ///     Describes the different critical workflows contained in the app.
    /// </summary>
    public enum CriticalWorkflow
    {
        /// <summary>
        ///     The workflow needed for the user to give a BreathSample.
        /// </summary>
        BreathSample,

        /// <summary>
        ///     The workflow needed to pair a device.
        /// </summary>
        Pairing,

        /// <summary>
        ///     The workflow needed to unpair a device.
        /// </summary>
        Unpairing,

        /// <summary>
        ///     The workflow needed to onboard the user.
        /// </summary>
        Onboarding,

        /// <summary>
        ///     The workflow needed to offboard the user.
        /// </summary>
        Offboarding
    }
}
