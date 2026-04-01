using UnityEditor;
using UnityEngine;

namespace HelloBridge.Editor
{
    public static class HelloBridgeMenu
    {
        [MenuItem("Tools/Hello Bridge/Say Hello")]
        public static void SayHelloFromMenu()
        {
            var result = HelloBridgeApi.SayHello("Editor Menu");
            Debug.Log($"[HelloBridgeMenu] Returned message: {result.text}");
        }

        [MenuItem("Tools/Hello Bridge/Reset Count")]
        public static void ResetCount() { HelloBridgeApi.ResetCount(); }
    }
}
