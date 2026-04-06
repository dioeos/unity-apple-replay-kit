import UIKit
import ReplayKit

@objc public class ReplayKitManager: NSObject
{
    @objc public static func isReplayKitAvailable() -> Bool
    {
        return RPScreenRecorder.shared().isAvailable
    }

    @objc public static func startRecording() -> Bool
    {
        let recorder = RPScreenRecorder.shared()
        recorder.startRecording { (error) in
            if let error = error {
                print("Error starting recording: \(error.localizedDescription)")
            }
        }
        return true
    }

    @objc public static func stopRecording() -> Bool
    {
        let recorder = RPScreenRecorder.shared()
        recorder.stopRecording { (error) in
            if let error = error {
                print("Error stopping recording: \(error.localizedDescription)")
            }
        }
        return true
    }
}