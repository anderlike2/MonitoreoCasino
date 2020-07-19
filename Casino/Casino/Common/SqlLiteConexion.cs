using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace Casino.Common
{
    /// <summary>
    /// Clase para el manejo de la conexion a Base de datos mediante SQlite
    /// Autor: Anderson Benavides
    /// 2020-07-19
    /// </summary>
    public class SqlLiteConexion
    {
        /// <summary>
        /// Obtiene el archivo de la base de datos
        /// Autor: Anderson Benavides
        /// 2020-07-19
        /// </summary>
        /// <param></param>
        public static string DbFile
        {
            get { return  "\\casino.sqlite"; }
        }

        /// <summary>
        /// Realiza una conexion a la base de datos SQlite
        /// Autor: Anderson Benavides
        /// 2020-07-19
        /// </summary>
        /// <param></param>
        public static SQLiteConnection SimpleDbConnection(string pathDB)
        {
            return new SQLiteConnection("Data Source=" + pathDB + DbFile);
        }
    }
}
