using System;
using Leap;

namespace LeapSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleListener listener = new SampleListener();
            Controller controller = new Controller();
            controller.AddListener(listener);

            // Keep this process running until Enter is pressed
            Console.WriteLine("Press Enter to quit...");
            Console.ReadLine();

            controller.RemoveListener(listener);
            controller.Dispose();
        }
    }
}
