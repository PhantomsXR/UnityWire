using UnityEngine;

namespace Unity.Services.Wire.Internal
{
    interface INetworkUtil
    {
        public bool IsInternetReachable();
    }

    /// <summary>
    /// Facade for testing basic network conditions
    /// </summary>
    class NetworkUtil : INetworkUtil
    {
        public bool IsInternetReachable()
        {
            return UnityEngine.Application.internetReachability != UnityEngine.NetworkReachability.NotReachable;
        }
    }
}
