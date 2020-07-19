using Casino.Daos;
using Casino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casino.Services
{
    /// <summary>
    /// Clase realizar la conexion entre la interfaz y los recursos de conexion para Jugadores
    /// Autor: Anderson Benavides
    /// 2020-07-19
    /// </summary>
    public class JugadoresService
    {
        // <summary>
        /// Metodo para consultar los jugadores del sistema
        /// Autor: Anderson Benavides
        /// 2020-07-19
        /// </summary>
        public List<JugadoresModel> ConsultarJugadores(string pathDB)
        {
            JugadoresDao jugadoresDao = new JugadoresDao();
            return jugadoresDao.ConsultarJugadores(pathDB);
        }
    }
}
