using LogoFX.Client.Testing.Contracts;
using TestStack.White;

namespace LogoFX.Client.Testing.EndToEnd.White
{   
    /// <summary>
    /// Helper class for starting an application using <see cref="TestStack.White"/> framework
    /// </summary>
    public class StartApplicationHelper : IStartApplicationHelper
    {
        /// <summary>
        /// Starts the application.
        /// </summary>
        /// <param name="startupPath">The startup path.</param>
        public void StartApplication(string startupPath)
        {
            ApplicationContext.Application = Application.Launch(startupPath);
            ApplicationContext.Application.WaitWhileBusy();
        }
    }
}