using Unity.Services.Authentication.Internal;

namespace Unity.Services.Wire.Internal
{
    class Configuration
    {
        public IAccessToken token;

        public string address;

        public double CommandTimeoutInSeconds = 5.0;    // centrifuge specific

        public double RetrieveTokenTimeoutInSeconds = 5.0;

        // TODO: Determine if this is still used?
        public IWebSocket WebSocket = null;  // for unit tests

        public INetworkUtil NetworkUtil; // for unit tests

        public double MaxServerPingDelay = 10.0; // centrifuge specific
    }
}
