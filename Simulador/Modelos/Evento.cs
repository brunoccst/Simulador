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
        /// Uma chegada de cliente na fila.
        /// </summary>
        CHEGADA,

        /// <summary>
        /// Um atendimento de cliente.
        /// </summary>
        ATENDIMENTO
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
        public int Tempo { get; set; }

    }
}
