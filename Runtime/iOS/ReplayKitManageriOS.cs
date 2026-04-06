using System;
using System.Runtime.InteropServices;

namespace Dioeos.UnityAppleReplayKit
{
  internal static class ReplayKitManageriOS
  {
    [DllImport("__Internal")]
    private static extern bool replaykit_is_available();

    [DllImport("__Internal")]
    private static extern bool replaykit_start_recording();

    [DllImport("__Internal")]
    private static extern bool replaykit_stop_recording();

    internal static bool IsAvailable()
    {
#if UNITY_IOS && !UNITY_EDITOR
      return replaykit_is_available();
#else
      return false;
#endif
    }

    internal static bool StartRecording()
    {
#if UNITY_IOS && !UNITY_EDITOR
      return replaykit_start_recording();
#else
      return false;
#endif
    }

    internal static bool StopRecording()
    {
#if UNITY_IOS && !UNITY_EDITOR
      return replaykit_stop_recording();
#else
      return false;
#endif
    }
  }
}
