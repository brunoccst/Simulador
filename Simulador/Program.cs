using Simulator.Generators;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    public class Program
    {
        /// <summary>
        /// Holds the value for <see cref="Limit"/>.
        /// </summary>
        private static int limit = -1;

        /// <summary>
        /// The limit of loops for generating a random number.
        /// </summary>
        public static int Limit
        {
            get
            {
                if (limit <= -1)
                {
                    string limitAux = ConfigurationManager.AppSettings["Limit"].ToString();
                    if (!int.TryParse(limitAux, out limit))
                    {
                        limit = 1000;
                    }
                }

                return limit;
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
