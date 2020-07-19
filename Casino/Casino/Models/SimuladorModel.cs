using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casino.Models
{
    /// <summary>
    /// Clase para el manejo de la pantalla de Simulacion
    /// Autor: Anderson Benavides
    /// 2020-07-19
    /// </summary>
    public class SimuladorModel : ErrorModel
    {
        //Para el manejo de la lista
        public List<JugadoresModel> lstJugadores { get; set; }
    }
}
