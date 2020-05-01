using System;
using System.Data.SQLite;
using System.IO;

namespace Romana_Vendimia.Modelo
{
    static class SQLiteManager
    {
        #region BD
        private readonly static string FullPathDB = @"C:/ROMANA/DB/Romana.db";
        private readonly static string PathLog = @"C:/ROMANA/LOG/log.txt";
        private readonly static string LogFolder = @"C:/ROMANA/LOG";

        private readonly static string EstadoDBQuery = "CREATE TABLE \"Estado_App\" ("+
	                                                    "\"Estado\"	INTEGER"+
                                                        ");";


        private readonly static string CreacionDB = "CREATE TABLE \"Romana_Info\" (" +
                                                    "\"NUM_TICKET\"	INTEGER," +
                                                    "\"ID_Planta\"	INTEGER," +
                                                    "\"Nombre_Planta\"	TEXT," +
                                                    "\"Peso\"	INTEGER," +
                                                    "\"Foto\"	BLOB," +
                                                    "\"Fecha\"	TEXT," +
                                                    "\"Hora\"	TEXT," +
                                                    "\"Estado\"	INTEG   ER," +
                                                    "\"Tipo_Control\"  INTEGER,"+
                                                    "PRIMARY KEY(\"NUM_TICKET\",\"ID_Planta\",\"Tipo_Control\"));";

        #endregion

        public static void CheckFolders()
        {
            #region Verificación de DB
            if (!File.Exists(FullPathDB))
            {
                //Aaqui crea la BD
                using (var Conexion = new SQLiteConnection("Data Source=" + FullPathDB + ";Version=3"))
                using (var Command = new SQLiteCommand(CreacionDB, Conexion))
                {
                    try
                    {
                        Conexion.Open();
                        Command.ExecuteNonQuery();
                        if (Conexion.State == System.Data.ConnectionState.Open)
                        {
                            EscribirEnLog("La base de datos local no existia, pero se ha creado correctamente.");
                            using (var Exec = new SQLiteCommand(EstadoDBQuery, Conexion))
                            {
                                Exec.ExecuteNonQuery();
                                EscribirEnLog("Tablas creadas correctamente.");
                            }
                        }
                        else
                        {
                            EscribirEnLog("Error al crear la base de datos local.");
                        }
                        Conexion.Close();
                    }
                    catch (Exception e)
                    {
                        EscribirEnLog(e.Message);
                    }
                }
            }
            #endregion
            
            if (!Directory.Exists(LogFolder))
            {
                Directory.CreateDirectory(LogFolder);
                File.Create(PathLog);
            }
            if (!File.Exists("C:/ROMANA/config.txt"))
            {
                System.Windows.Forms.MessageBox.Show("NO EXISTE ARCHIVO DE CONFIGURACIÓN CONFIG","ALERTA",
                    System.Windows.Forms.MessageBoxButtons.AbortRetryIgnore,System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }

        public static bool DebeEjecutarse()
        {
            using (var conexion = new SQLiteConnection("Data Source=" + FullPathDB + ";Version=3"))
            using (var command = new SQLiteCommand("Select Estado from Estado_App where Estado = 1;", conexion))
            {
                try
                {
                    conexion.Open();
                    command.ExecuteNonQuery();
                    var count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        conexion.Close();
                        return true;
                    }
                    else
                    {
                        conexion.Close();
                        return false;
                    }
                }
                catch (Exception e)
                {
                    EscribirEnLog("Error al intentar consultar en Base de Datos Local." + e.Message);
                    return false;
                }
            }
        }

        private static void EscribirEnLog(string Texto)
        {
            string[] NuevaLinea = new string[] { DateTime.Now.ToString() + " " + Texto };
            File.AppendAllLines(PathLog, NuevaLinea);
        }
        public static bool DebeMinimizarse()
        {
            using (var conexion = new SQLiteConnection("Data Source=" + FullPathDB + ";Version=3"))
            using (var command = new SQLiteCommand("Select Estado from Estado_App where Estado in (0,3,4);", conexion))
            {
                try
                {
                    conexion.Open();
                    command.ExecuteNonQuery();
                    var count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        conexion.Close();
                        return true;
                    }
                    else
                    {
                        conexion.Close();
                        return false;
                    }
                }
                catch (Exception e)
                {
                    EscribirEnLog("Error al intentar consultar en Base de Datos Local." + e.Message);
                    return false;
                }
            }
        }
        
        public static void CambiarEstado_App(int Valor)
        {
            using (var conexion = new SQLiteConnection("Data Source=" + FullPathDB + ";Version=3"))
            using (var command = new SQLiteCommand("Update Estado_App SET Estado = @Status;", conexion))
            {
                try
                {
                    conexion.Open();
                    command.Parameters.Add("@Status", System.Data.DbType.Int32).Value = Valor;
                    command.ExecuteNonQuery();
                    EscribirEnLog("Estado de la aplicación modificado a " + Valor + ".");
                    conexion.Close();
                }
                catch (Exception)
                {
                    EscribirEnLog("Error al cambiar el Estado de la Aplicación en BD Local.");
                }
            }

        }

        public static void CambiarEstado_Data(int Valor, Session _userSession)
        {
            using (var conexion = new SQLiteConnection("Data Source=" + FullPathDB + ";Version=3"))
            using (var command = new SQLiteCommand("Update Romana_Info SET Estado_Data = @Status WHERE " +
                                            "Ticket = @Ticket", conexion))
            {
                try
                {
                    conexion.Open();
                    command.Parameters.Add("@Status", System.Data.DbType.Int32).Value = Valor;
                    command.Parameters.Add("@Ticket", System.Data.DbType.Int32).Value = _userSession.Ticket;
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception)
                {
                    EscribirEnLog("Error al actualizar el estado de la recepción.");
                }
            }
        }
    
        public static void InsertarDatos(Session _session)
        {
            try
            {
                using (var conexion = new SQLiteConnection("Data Source=" + FullPathDB + ";Version=3"))
                using (var command = new SQLiteCommand("INSERT INTO log_Romana_Info(NUM_TICKET,ID_PLANTA,NOMBRE_PLANTA,PESO,FOTO,FECHA,HORA,ESTADO,TIPO_CONTROL)" +
                    " VALUES(@Ticket,@IDPlanta,@NombrePlanta,@Peso,@Imagen,@Fecha, @Hora,2,@Control)"
                    , conexion))
                {
                    conexion.Open();
                    command.Parameters.Add("@IDPlanta", System.Data.DbType.Int32).Value = _session.ID_Planta;
                    command.Parameters.Add("@NombrePlanta",System.Data.DbType.String).Value = _session.Nombre_Planta;
                    command.Parameters.Add("@Imagen", System.Data.DbType.Binary, 20).Value = _session.Imagen;
                    command.Parameters.Add("@Fecha", System.Data.DbType.String).Value = DateTime.Now.ToString("dd-MM-yyyy") ;
                    command.Parameters.Add("@Hora", System.Data.DbType.String).Value = DateTime.Now.ToString("HH:mm:ss");
                    command.Parameters.Add("@Peso",System.Data.DbType.Int32).Value = _session.Peso;
                    command.Parameters.Add("@Ticket", System.Data.DbType.Int32).Value = _session.Ticket;
                    command.Parameters.Add("@Control", System.Data.DbType.Int32).Value = _session.Tipo_Control;
                    //command.Parameters.Add("@NombreCooperado", System.Data.DbType.String).Value = _session.Nombre_Cooperado;
                    //command.Parameters.Add("@NombrePlanta", System.Data.DbType.String).Value = _session.Nombre_Planta;
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception)
            {
                EscribirEnLog("Error al Intentar insertar datos en base de datos Local.");
            }
        }
    
        public static void Configurar_Session(ref Session _userSession)
        {
            using (var conexion = new SQLiteConnection("Data Source=" + FullPathDB + ";Version=3"))
            using (var command = new SQLiteCommand("Select NUM_TICKET, ID_Planta, Nombre_Planta, Tipo_Control " +
                                                    "from Romana_Info where Estado= 1", conexion))
            {
                try
                {
                    conexion.Open();
                    using (var rdr = command.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            _userSession.Ticket = rdr.GetInt32(0);
                            _userSession.ID_Planta = rdr.GetInt32(1);
                            _userSession.Nombre_Planta = rdr.GetString(2);
                            _userSession.Tipo_Control = rdr.GetInt32(3);
                        }
                    }
                    conexion.Close();
                }
                catch (Exception e)
                {
                    EscribirEnLog("Error al leer la Session en base de datos local. " + e.Message);
                }
            }
        }

        public static void EliminarRegistro(int _numTicket, int _idPlanta)
        {
            try
            {
                using (var conexion = new SQLiteConnection("Data Source=" + FullPathDB + ";Version=3"))
                using (var command = new SQLiteCommand("DELETE FROM ROMANA_INFO WHERE NUM_TICKET = "+_numTicket+" AND " +
                    "ID_PLANTA = "+_idPlanta+";", conexion))
                {
                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (SQLiteException error)
            {
                EscribirEnLog("Error al eliminar el registro con Ticket : "+_numTicket+"." +
                    "Error :"+error.Message);
            }
        }

        public static bool AplicacionEnEjecucion()
        {
            try
            {
                using (var conexion = new SQLiteConnection("Data Source=" + FullPathDB + ";Version=3"))
                using (var command = new SQLiteCommand("Select Estado from Estado_App where Estado = 2;", conexion))
                {
                    conexion.Open();
                    command.ExecuteNonQuery();
                    var count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        conexion.Close();
                        return true;
                    }
                    else
                    {
                        conexion.Close();
                        return false;
                    }
                }
            }
            catch (Exception error)
            {
                EscribirEnLog("Error al leer la ejecución. Error: " + error.Message);
                return false;
            }
        }

    }
}
