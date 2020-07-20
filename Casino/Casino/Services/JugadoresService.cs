using Casino.Common;
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

        // <summary>
        /// Metodo para insertar jugadores en el sistema
        /// Autor: Anderson Benavides
        /// 2020-07-19
        /// </summary>
        /// <param name="registroModel"></param>
        /// <param name="pathDB"> Ruta del archivo de Base de datos</param>
        public bool InsertarJugador(RegistroModel registroModel, string pathDB)
        {
            JugadoresDao jugadoresDao = new JugadoresDao();
            //Se valida que el jugador no exista en BD para su CC e Identificacion
            JugadoresModel existe = ConsultarJugadoresPorIdentificacion(registroModel, pathDB);
            if(existe != null && existe.Identificacion > 0)
            {
                throw new BusinessException(Constantes.MsjUsuarioExiste);
            }
            registroModel.EstadoJugador = "A";
            return jugadoresDao.InsertarJugador(registroModel, pathDB);
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
            JugadoresDao jugadoresDao = new JugadoresDao();
            return jugadoresDao.ConsultarJugadoresPorIdentificacion(registroModel, pathDB);
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
            JugadoresDao jugadoresDao = new JugadoresDao();            
            if(registroModel.DisponibleJugador <= 0)
            {
                registroModel.EstadoJugador = "I";
            }
            else
            {
                registroModel.EstadoJugador = "A";
            }
            return jugadoresDao.ActualizarJugador(registroModel, pathDB);
        }

        /// <summary>
        /// Metodo para eliminar jugadores en el sistema
        /// Autor: Anderson Benavides
        /// 2020-07-19
        /// </summary>
        /// <param name="tipoIdentificacion"></param>
        /// <param name="numeroIdentificacion"></param>
        /// <param name="pathDB"> Ruta del archivo de Base de datos</param>
        public bool EliminarJugador(int tipoIdentificacion, int numeroIdentificacion, string pathDB)
        {
            JugadoresDao jugadoresDao = new JugadoresDao();
            return jugadoresDao.EliminarJugador(tipoIdentificacion, numeroIdentificacion, pathDB);
        }

        // <summary>
        /// Metodo para actualizar los nuevos disponibles
        /// Autor: Anderson Benavides
        /// 2020-07-19
        /// </summary>
        /// <param name="datosActualizar"></param>
        /// <param name="pathDB"> Ruta del archivo de Base de datos</param>
        public bool ActualizarDisponible(String datosActualizar, string pathDB)
        {
            JugadoresDao jugadoresDao = new JugadoresDao();

            string[] jugadores = datosActualizar.Split(";");
            foreach(string dato in jugadores)
            {
                string[] datosJugador = dato.Split("||");

                RegistroModel registroModel = new RegistroModel();
                registroModel.IdentificacionJugador = int.Parse(datosJugador[0]);
                registroModel.DisponibleJugador = float.Parse(datosJugador[1]);
                if (registroModel.DisponibleJugador <= 0)
                {
                    registroModel.EstadoJugador = "I";
                }
                else
                {
                    registroModel.EstadoJugador = "A";
                }

                jugadoresDao.ActualizarDisponible(registroModel, pathDB);
            }
            return true;
        }
    }
}
