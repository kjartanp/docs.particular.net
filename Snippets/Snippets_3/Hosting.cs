﻿namespace Snippets3
{
    using System;
    using NServiceBus;
    using NServiceBus.Unicast;
    using NServiceBus.Unicast.Config;

    class Hosting
    {
        void Simple(Configure configure)
        {
            #region Hosting-SendOnly

            ConfigUnicastBus configUnicastBus = configure.UnicastBus();
            IBus bus = configUnicastBus.SendOnly();

            #endregion
        }

        void Startup(Configure configure)
        {
            #region Hosting-Startup

            ConfigUnicastBus configUnicastBus = configure.UnicastBus();
            IStartableBus startableBus = configUnicastBus.CreateBus();
            IBus bus = startableBus.Start();
            #endregion
        }

        void Shutdown(IBus bus)
        {
            #region Hosting-Shutdown
            UnicastBus busImpl = (UnicastBus) bus;
            busImpl.Dispose();
            #endregion
        }

        #region Hosting-Static
        public static class EndpointInstance
        {
            public static IBus Endpoint { get; private set; }
            public static void SetInstance(IBus endpoint)
            {
                if (Endpoint != null)
                {
                    throw new Exception("Endpoint already set.");
                }
                Endpoint = endpoint;
            }
        }
        #endregion
    }
}