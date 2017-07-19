using LogoFX.Client.Testing.Contracts;
using TestStack.White;

namespace LogoFX.Client.Testing.EndToEnd.White
{   
    /// <summary>
    /// Implementation of application facade <see cref="TestStack.White"/> framework
    /// </summary>
    public class ApplicationFacade : IApplicationFacade
    {
        /// <summary>
        /// Starts the application.
        /// </summary>
        /// <param name="startupPath">The startup path.</param>
        public void Start(string startupPath)
        {
            ApplicationContext.Application = Application.Launch(startupPath);
            ApplicationContext.Application.WaitWhileBusy();
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public void Stop()
        {
            ApplicationContext.Application?.Dispose();
        }
    }
}