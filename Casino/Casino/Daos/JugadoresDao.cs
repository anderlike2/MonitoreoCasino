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
        /// <param name="pathDB"> Ruta del archivo de Base de datos</param>
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

        // <summary>
        /// Metodo para insertar jugadores en el sistema
        /// Autor: Anderson Benavides
        /// 2020-07-19
        /// </summary>
        /// <param name="registroModel"></param>
        /// <param name="pathDB"> Ruta del archivo de Base de datos</param>
        public bool InsertarJugador(RegistroModel registroModel, string pathDB)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection(pathDB))
            {
                int result = cnn.Execute(
                    @"INSERT INTO JUGADORES (TIPOIDENTIFICACION, IDENTIFICACION, NOMBRE, EDAD, SEXO, ESTADO, DISPONIBLE)
                      VALUES(@TIPOIDENTIFICACIONJUGADOR, @IDENTIFICACIONJUGADOR, @NOMBREJUGADOR, @EDADJUGADOR, @SEXOJUGADOR, @ESTADOJUGADOR, @DISPONIBLEJUGADOR)",
                    registroModel);
                return result > 0;
            }
        }

        // <summary>
        /// Metodo para consultar los jugadores del sistema
        /// Autor: Anderson Benavides
        /// 2020-07-19
        /// </summary>
        /// <param name="registroModel"></param>
        /// <param name="pathDB"> Ruta del archivo de Base de datos</param>
        public JugadoresModel ConsultarJugadoresPorIdentificacion(RegistroModel registroModel, string pathDB)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection(pathDB))
            {
                JugadoresModel result = cnn.Query<JugadoresModel>(
                     @"SELECT TIPOIDENTIFICACION, IDENTIFICACION, NOMBRE, EDAD, SEXO, ESTADO, DISPONIBLE
                    FROM JUGADORES WHERE TIPOIDENTIFICACION = @TIPOIDENTIFICACIONJUGADOR AND IDENTIFICACION = @IDENTIFICACIONJUGADOR",
                    new {registroModel.TipoIdentificacionJugador, registroModel.IdentificacionJugador }).FirstOrDefault();
                return result;
            }
        }

        // <summary>
        /// Metodo para editar jugadores en el sistema
        /// Autor: Anderson Benavides
        /// 2020-07-19
        /// </summary>
        /// <param name="registroModel"></param>
        /// <param name="pathDB"> Ruta del archivo de Base de datos</param>
        public bool ActualizarJugador(RegistroModel registroModel, string pathDB)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection(pathDB))
            {
                int result = cnn.Execute(
                    @"UPDATE JUGADORES SET NOMBRE = @NOMBREJUGADOR, EDAD = @EDADJUGADOR, SEXO = @SEXOJUGADOR, ESTADO = @ESTADOJUGADOR, DISPONIBLE = @DISPONIBLEJUGADOR 
                        WHERE TIPOIDENTIFICACION = @TIPOIDENTIFICACIONJUGADOR AND IDENTIFICACION = @IDENTIFICACIONJUGADOR",
                    new { registroModel.NombreJugador, registroModel.EdadJugador, registroModel.SexoJugador, registroModel.EstadoJugador, registroModel.DisponibleJugador,
                        registroModel.TipoIdentificacionJugador, registroModel.IdentificacionJugador
                    });
                return result > 0;
            }
        }

        /// <summary>
        /// Metodo para eliminar jugadores en el sistema
        /// Autor: Anderson Benavides
        /// 2020-07-19
        /// </summary>
        /// <param name="TipoIdentificacionJugador"></param>
        /// <param name="numeroIdentificacion"></param>
        /// <param name="pathDB"> Ruta del archivo de Base de datos</param>
        public bool EliminarJugador(int TipoIdentificacionJugador, int IdentificacionJugador, string pathDB)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection(pathDB))
            {
                int result = cnn.Execute(
                    @"DELETE FROM JUGADORES WHERE TIPOIDENTIFICACION = @TIPOIDENTIFICACIONJUGADOR AND IDENTIFICACION = @IDENTIFICACIONJUGADOR",
                    new { TipoIdentificacionJugador, IdentificacionJugador });
                return result > 0;
            }
        }
    }
}
