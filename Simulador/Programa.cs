using Simulador.Geradores;
using Simulador.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simulador
{
    public class Programa
    {

        /// <summary>
        /// Executa o programa.
        /// </summary>
        /// <param name="args">Argumentos passados (não utilizados).</param>
        public static void Main(string[] args)
        {
            // Configura o sistema de acordo com as entradas do usuário.
            Fila fila = configuraFila();
            double estadoInicial = leDouble("estado inicial");

            // Gera a lista de números aleatórios.
            GeradorCongruenteLinear gcl = new GeradorCongruenteLinear();
            double[] numerosAleatorios = gcl.Gerar(5, 75, 1, 0.52235, 10);

            // Cria o simulador e executa conforme as configurações.
            SimuladorDeRedeDeFilas simulador = new SimuladorDeRedeDeFilas();
            simulador.Executar(fila, estadoInicial, numerosAleatorios);
        }

        /// <summary>
        /// Apresenta instruções ao usuário e espera os valores serem digitados para configurar a fila.
        /// </summary>
        /// <returns>Fila configurada com valores passado pelo usuário.</returns>
        private static Fila configuraFila()
        {
            int tempoChegadaMin = leInteiro("tempo de chegada mínimo");
            int tempoChegadaMax = leInteiro("tempo de chegada máximo");
            Tempo tChegada = new Tempo(tempoChegadaMin, tempoChegadaMax);

            int tempoAtendimentoMin = leInteiro("tempo de atendimento máximo");
            int tempoAtendimentoMax = leInteiro("tempo de atendimento máximo");
            Tempo tAtendimento = new Tempo(tempoAtendimentoMin, tempoAtendimentoMax);

            int servidores = leInteiro("número de servidores");
            int capacidade = leInteiro("capacidade");

            Fila f = new Fila(tChegada, tAtendimento, servidores, capacidade);
            return f;
        }

        #region Metodos auxiliares de leitura

        /// <summary>
        /// Lê um número inteiro do console.
        /// </summary>
        /// <param name="nome">Nome do parâmetro.</param>
        /// <returns>Número inteiro lido.</returns>
        private static int leInteiro(string nome)
        {
            int aux = -1;

            Console.WriteLine("Digite o(a) {0} (inteiro maior que zero): ", nome);
            string valor = Console.ReadLine();
            if (!int.TryParse(valor, out aux))
            {
                Console.WriteLine("\nO número digitado não é um inteiro válido.");
            }

            return aux;
        }

        /// <summary>
        /// Lê um número double do console.
        /// </summary>
        /// <param name="nome">Nome do parâmetro.</param>
        /// <returns>Número double lido.</returns>
        private static double leDouble(string nome)
        {
            double aux = -1;

            Console.WriteLine("Digite o(a) {0} (double maior que zero): ", nome);
            string valor = Console.ReadLine();
            if (!double.TryParse(valor, out aux))
            {
                Console.WriteLine("\nO número digitado não é um double válido.");
            }

            return aux;
        }

        #endregion

    }
}
