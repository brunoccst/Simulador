using Simulator.Generators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Exercises
{
    /*
     * [Tarefa - Geração de números pseudo-aleatórios - Entrega até 12/03 às 11:50]
     * Utilizando o conceito do método Congruente Linear para geração de números pseudo-aleatórios, sua tarefa é programar um método que gere 1.000 (mil) números (entre os valores 0 e 1) a fim de produzir um gráfico de dispersão conforme apresentado no material de apoio.
     * Este método servirá posteriormente de base para o seu simulador na geração de pseudo-aleatórios. Você pode utilizar a linguagem de programação que desejar.
     * A fim de validar a entrega da atividade, envie em um único arquivo ".zip" o arquivo texto com os 1.000 números pseudo-aleatórios produzidos pelo seu método, bem como o gráfico de dispersão destes números.
     */
    public class Exercise1 : IExercise
    {
        public void Run()
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
