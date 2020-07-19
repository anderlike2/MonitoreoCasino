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
        public List<JugadoresModel> lstJugadores { get; set; }
    }
}
