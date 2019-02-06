using System;
using Leap;

namespace LeapSample
{
    class SampleListener : Listener
    {
        private Object thisLock = new Object();

        private void SafeWriteLine(String line)
        {
            lock (thisLock)
            {
                Console.WriteLine(line);
            }
        }

        public override void OnConnect(Controller controller)
        {
            SafeWriteLine("Connected");
            controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
        }


        public override void OnFrame(Controller controller)
        {
            Frame frame = controller.Frame();

            SafeWriteLine("Frame id: " + frame.Id
                                       + ", timestamp: " + frame.Timestamp
                                       + ", hands: " + frame.Hands.Count
                                       + ", fingers: " + frame.Fingers.Count
                                       + ", tools: " + frame.Tools.Count
                                       + ", gestures: " + frame.Gestures().Count);
        }
    }
}
