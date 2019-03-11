using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Generators
{
    public class CongruentialGenerator
    {
        public float Generate()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates a random number array.
        /// </summary>
        /// <param name="a">The multiplier.</param>
        /// <param name="M">The quantity of numbers to be generated.</param>
        /// <param name="x0">The seed and first value.</param>
        /// <returns>An array with the generated random numbers, <paramref name="x0"/> being the first one.</returns>
        public float[] Generate(int a, int M, float x0)
        {
            float[] x = new float[M + 1];

            x[0] = x0;
            for (int i = 1; i < M + 1; i++)
            {
                x[i] = a * x[i - 1] % M;
            }

            return x;
        }
    }
}
