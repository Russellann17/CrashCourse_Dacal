using System;
using System.Threading;

namespace CrashCourse_Dacal
{
    class Lesson17
    {
        public static void L17_TemperatureAlert()
        {
            Temperature Tmonitor = new Temperature(30);

            Tmonitor.TemperatureExceeded += TempMonitor_TemperatureExceeded;

            while (true)
            {
                Console.Write("\nCurrent temperature (in °C, or type 'exit' to quit): ");
                string temp = Console.ReadLine();

                if (temp == "exit") break;

                if(double.TryParse(temp, out double temperature))
                {
                    Tmonitor.SetTemperature(temperature);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
        public delegate void TemperatureExceededEventHandler(object sender, EventArgs e);
        public class Temperature
        {
            private double currentTemperature;
            private double threshold;

            public event TemperatureExceededEventHandler TemperatureExceeded;

            public Temperature(double threshold)
            {
                this.threshold = threshold;
            }

            public void SetTemperature(double temperature) 
            {
                currentTemperature = temperature;
                Console.WriteLine("Current Temperature: " +  currentTemperature + "°C");

                if (currentTemperature > threshold) 
                {
                    OnTemperatureExceeded();
                }
            }

            protected virtual void OnTemperatureExceeded() 
            {
                TemperatureExceeded?.Invoke(this, EventArgs.Empty);
            }
        }
        private static void TempMonitor_TemperatureExceeded(Object sender, EventArgs e)
        {
            Console.WriteLine("ALERT!! Temperature exceeded the threshold of 30°C.");
        }
    }
}
