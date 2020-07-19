using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casino.Models
{
    /// <summary>
    /// Clase para el manejo de la tabla Jugadores
    /// Autor: Anderson Benavides
    /// 2020-07-19
    /// </summary>
    public class JugadoresModel
    {
        public int TipoIdentificacion { get; set; }
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Estado { get; set; }
        public float Disponible { get; set; }
    }
}
