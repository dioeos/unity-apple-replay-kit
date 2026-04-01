using UnityEngine;

namespace HelloBridge
{
    public static class HelloBridgeApi
    {
        private static int _callCount = 0;

        public static HelloMessage SayHello(string target)
        {
            _callCount += 1;
            string safeTarget = string.IsNullOrWhiteSpace(target) ? "World" : target;
            string message = $"Hello, {safeTarget}! Call count: {_callCount}";

            Debug.Log($"[Package API] {message}");
            return new HelloMessage(message, _callCount);
        }

        public static int GetCallCount() { return _callCount; }

        public static void ResetCount()
        {
            _callCount = 0;
            Debug.Log("[Package API] Call count reset.");
        }
    }
}
