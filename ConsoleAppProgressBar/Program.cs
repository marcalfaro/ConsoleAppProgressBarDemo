using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProgressBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Progress Bar Demo. Please enter to continue...");

            int maxValue = 10;

            Console.WriteLine("\nPlease enter to start Sample #1...");
            Console.ReadLine();
            for (int i = 0; i <= maxValue; i++)
            {
                updateProgress1(i, maxValue);
                Task.Delay(300).Wait();
            }

            Console.WriteLine();

            Console.WriteLine("\nPlease enter to start Sample #2...");
            Console.ReadLine();
            for (int i = 0; i <= maxValue; i++)
            {
                updateProgress2(i, maxValue);
                Task.Delay(300).Wait();
            }

            Console.WriteLine($"\n\nDone.");
            Console.ReadLine();
        }

        static void updateProgress1(int value,int max)
        {
            Console.Write($"\rUpdating... {value}/{max}");
        }

        static void updateProgress2(int value, int max)
        {
            int progressBarLength = 50;

            double progress = (double)value / max;

            // Calculate the number of blocks to display on the progress bar.
            int progressBlocks = (int)(progress * progressBarLength);

            // Build the progress bar string.
            string progressBar = new string('#', progressBlocks).PadRight(progressBarLength);

            // Use carriage return (\r) to return the cursor to the start of the line and print the progress bar and the percentage.
            Console.Write($"\r[{progressBar}] {progress * 100:0.0}% ");
        }

    }
}
