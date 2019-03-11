using Simulator.Generators;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initialize the parameters.
            int a = 27;
            int c = 153;
            int M = 1;
            float x0 = 0.1234567891f;
            int length = 1000;

            // Create the generator.
            LinearCongruentialGenerator generator = new LinearCongruentialGenerator();

            // Generate the values.
            float[] result = generator.Generate(a, c, M, x0, length);

            // Build the values into a string.
            StringBuilder sb = new StringBuilder();
            foreach (float value in result)
            {
                string valueStr = value.ToString("R");
                sb.AppendLine(valueStr);
            }

            // Save the values into a .txt file.
            string filePath = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "\\", "generatedRandomNumbers.txt");
            File.WriteAllText(filePath, sb.ToString());

            // Open the file.
            Process.Start(filePath);
        }
    }
}
