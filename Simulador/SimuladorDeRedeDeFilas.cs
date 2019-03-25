using Simulador.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador
{
    /// <summary>
    /// Simulador de rede de filas.
    /// </summary>
    public class SimuladorDeRedeDeFilas
    {
        /// <summary>
        /// Executa a simulação da fila.
        /// </summary>
        /// <param name="fila">Fila.</param>
        /// <param name="estadoInicial">Estado inicial.</param>
        /// <param name="numerosAleatorios">Lista de números aleatórios para a execução.</param>
        public void Executar(Fila fila, double estadoInicial, double[] numerosAleatorios)
        {
            Console.WriteLine(fila.ToString());
            Console.WriteLine("Estado inicial: " + estadoInicial);
            Console.WriteLine(string.Join(",", numerosAleatorios));
            Console.WriteLine("Aperte em qualquer tecla para sair.");
            Console.ReadKey();
            // TODO: Finalizar este método.
        }
    }
}
