﻿namespace Snippets3.Errors.ErrorQueue.ConfigurationSource
{
    using NServiceBus;

    class Usage
    {
        Usage(Configure configure)
        {
            #region UseCustomConfigurationSourceForErrorQueueConfig

            configure.CustomConfigurationSource(new ConfigurationSource());

            #endregion
        }
    }
}