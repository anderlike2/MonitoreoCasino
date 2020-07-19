using Casino.Common;
using Casino.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casino.Daos
{
    public class JugadoresDao
    {
        // <summary>
        /// Metodo para consultar los jugadores del sistema
        /// Autor: Anderson Benavides
        /// 2020-07-19
        /// </summary>
        /// <param name="pathDB"> Ruta del archivo de Base de datos
        public List<JugadoresModel> ConsultarJugadores(string pathDB)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection(pathDB))
            {
                List<JugadoresModel> result = cnn.Query<JugadoresModel>(
                     @"SELECT TIPOIDENTIFICACION, IDENTIFICACION, NOMBRE, EDAD, SEXO, ESTADO, DISPONIBLE
                    FROM JUGADORES ").ToList();
                return result;
            }
        }
    }
}
