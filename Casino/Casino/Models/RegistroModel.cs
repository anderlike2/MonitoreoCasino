using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casino.Models
{
    /// <summary>
    /// Clase para el manejo de la pantalla de Jugadores
    /// Autor: Anderson Benavides
    /// 2020-07-19
    /// </summary>
    public class RegistroModel : ErrorModel
    {
        //Para el manejo de la lista
        public List<JugadoresModel> lstJugadores { get; set; }

        //Para agregar jugadores
        public int TipoIdentificacionJugador { get; set; }
        public int IdentificacionJugador { get; set; }
        public string NombreJugador { get; set; }
        public int EdadJugador { get; set; }
        public string SexoJugador { get; set; }
        public string EstadoJugador { get; set; }
        public float DisponibleJugador { get; set; }
    }
}
