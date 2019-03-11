using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Generators
{
    public class LinearCongruentialGenerator
    {
        /// <summary>
        /// Generates a random number array.
        /// </summary>
        /// <param name="a">The multiplier.</param>
        /// <param name="c">Constant used for a bigger variation of generated numbers.</param>
        /// <param name="M">The maximum value of number to be generated.</param>
        /// <param name="x0">The seed and first value.</param>
        /// <param name="length">The quantity of numbers to be generated.</param>
        /// <returns>An array with the generated random numbers, <paramref name="x0"/> being the first one.</returns>
        public float[] Generate(int a, int c, int M, float x0, int length)
        {
            float[] x = new float[length];

            x[0] = x0;
            for (int i = 1; i < length; i++)
            {
                x[i] = (a * x[i - 1] + c) % M;
            }

            return x;
        }
    }
}
