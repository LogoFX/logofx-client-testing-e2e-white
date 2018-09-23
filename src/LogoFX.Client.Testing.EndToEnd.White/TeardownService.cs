﻿using LogoFX.Client.Testing.Contracts;

namespace LogoFX.Client.Testing.EndToEnd.White
{
    /// <inheritdoc />
    public sealed class TeardownService : ITeardownService
    {
        /// <inheritdoc />
        public void Teardown()
        {
            ApplicationContext.Application?.Dispose();
        }
    }
}
