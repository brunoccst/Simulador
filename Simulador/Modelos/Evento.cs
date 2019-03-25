using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador.Modelos
{
    /// <summary>
    /// Tipos de evento.
    /// </summary>
    public enum TipoDeEvento
    {
        /// <summary>
        /// Uma chegada de cliente.
        /// </summary>
        CHEGADA,

        /// <summary>
        /// Uma saída de cliente.
        /// </summary>
        SAIDA
    }

    /// <summary>
    /// Evento da fila.
    /// </summary>
    public class Evento
    {
        /// <summary>
        /// Tipo de evento.
        /// </summary>
        public TipoDeEvento Tipo { get; set; }

        /// <summary>
        /// Tempo gasto do evento.
        /// </summary>
        public double Tempo { get; set; }

        /// <summary>
        /// Cria uma nova instância.
        /// </summary>
        /// <param name="tipo">Tipo.</param>
        /// <param name="tempo">Tempo</param>
        public Evento(TipoDeEvento tipo, double tempo)
        {
            Tipo = tipo;
            Tempo = tempo;
        }

    }
}
