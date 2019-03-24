using Simulator.Exercises;
using Simulator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simulator
{
    public class Program
    {
        private static TimeInterval clientArrival { get; set; }
        private static TimeInterval clientAttendence { get; set; }
        private static int serverCount { get; set; }
        private static int queueCapacity { get; set; }

        private const int expectedParams = 6;

        private static List<Exception> handleArgs(string[] args)
        {
            List<Exception> exceptions = new List<Exception>();

            // Checks the parameters' length.
            if (args.Length < expectedParams)
            {
                string joinedParams = string.Join(",", args);
                string msg = string.Format("There should be at least {0} parameters but you only provided {1}: {2}", expectedParams, args.Length, joinedParams);
                exceptions.Add(new ArgumentException(msg, nameof(args)));
            }
            else
            {
                // Checks the arrival time interval.
                #region Arrival time interval

                float clientArrivalStart;
                if (!float.TryParse(args[0], out clientArrivalStart))
                {
                    string msg = string.Format("The client arrival start parse to float was not possible: {0}", args[0]);
                    exceptions.Add(new ArgumentException(msg, nameof(args)));
                }

                float clientArrivalEnd;
                if (!float.TryParse(args[1], out clientArrivalEnd))
                {
                    string msg = string.Format("The client arrival end parse to float was not possible: {0}", args[1]);
                    exceptions.Add(new ArgumentException(msg, nameof(args)));
                }

                clientArrival = new TimeInterval(clientArrivalStart, clientArrivalEnd);
                if (!clientArrival.IsValid())
                {
                    string msg = "The client arrival interval is not valid because the start and/or the end are lower than 0 or because the start is bigger than the end.";
                    exceptions.Add(new ArgumentException(msg, nameof(args)));
                }

                #endregion

                // Checks the attendence time interval.
                #region Attendence time interval

                float clientAttendenceStart;
                if (!float.TryParse(args[2], out clientAttendenceStart))
                {
                    string msg = string.Format("The client attendence start parse to float was not possible: {0}", args[2]);
                    exceptions.Add(new ArgumentException(msg, nameof(args)));
                }

                float clientAttendenceEnd;
                if (!float.TryParse(args[3], out clientAttendenceEnd))
                {
                    string msg = string.Format("The client attendence end parse to float was not possible: {0}", args[3]);
                    exceptions.Add(new ArgumentException(msg, nameof(args)));
                }

                clientAttendence = new TimeInterval(clientAttendenceStart, clientAttendenceEnd);

                if (!clientAttendence.IsValid())
                {
                    string msg = "The client attendence interval is not valid because the start and/or the end are lower than 0 or because the start is bigger than the end.";
                    exceptions.Add(new ArgumentException(msg, nameof(args)));
                }

                #endregion

                // Checks the server count.
                int sCount;
                if (int.TryParse(args[4], out sCount))
                {
                    if (sCount >= 0)
                        serverCount = sCount;
                    else
                    {
                        string msg = string.Format("The server count must be bigger than 0: {0}", args[4]);
                        exceptions.Add(new ArgumentException(msg, nameof(args)));
                    }
                }
                else
                {
                    string msg = string.Format("The server count was not able to be parsed into an integer: {0}", args[4]);
                    exceptions.Add(new ArgumentException(msg, nameof(args)));
                }

                // Checks the queue capacity.
                int qCapacity;
                if (int.TryParse(args[5], out qCapacity))
                {
                    if (qCapacity >= 0)
                        queueCapacity = queueCapacity;
                    else
                    {
                        string msg = string.Format("The queue capacity must be bigger than 0: {0}", args[5]);
                        exceptions.Add(new ArgumentException(msg, nameof(args)));
                    }
                }
                else
                {
                    string msg = string.Format("The queue capacity was not able to be parsed into an integer: {0}", args[5]);
                    exceptions.Add(new ArgumentException(msg, nameof(args)));
                }
            }

            return exceptions;
        }

        /// <summary>
        /// Starts the program.
        /// Expects it to receive 6 parameters:
        /// the time interval for the clients arrival on queue (two float parameters);
        /// the time interval for the clients attendence (two float parameters);
        /// the number of servers;
        /// the queue's capacity.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            List<Exception> handledExceptions = handleArgs(args);
            if (handledExceptions.Count > 0)
            {
                Console.WriteLine("The following exceptions were found when trying to run the program:");
                foreach (Exception ex in handledExceptions)
                {
                    Console.WriteLine("   * {0}", ex.Message);
                }
                Console.WriteLine("Please, run the program like: 'Program <clients arrival start> <clients arrival end> <clients attendence start> <clients attendence end> <number of servers> <queue's capacity>'");
                Console.ReadLine();
                return;
            }

        }
    }
}
