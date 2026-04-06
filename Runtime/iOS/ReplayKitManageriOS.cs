using System;
using System.Runtime.InteropServices

namespace Dioeos.UnityAppleReplayKit
{
  internal static class ReplayKitManageriOS
  {
    [DllImport("__Internal")]
    private static extern bool replaykit_is_available(void);

    [DllImport("__Internal")]
    private static extern bool replaykit_start_recording(void);

    [DllImport("__Internal")]
    private static extern bool replaykit_stop_recording(void);

    internal static bool IsAvailable()
    {
      return replaykit_is_available();
    }

    internal static bool StartRecording()
    {
      return replaykit_start_recording();
    }

    internal static bool StopRecording()
    {
      return replaykit_stop_recording();
    }
  }
}