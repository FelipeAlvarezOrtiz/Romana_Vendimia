using Oracle.ManagedDataAccess.Client;
using System;
using System.IO;
using System.IO.Ports;

namespace Romana_Vendimia.Modelo
{
    static class OracleManager
    {
        //532433779
        private readonly static string ConexionString = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 172.16.16.236)(PORT = 1521))) " +
                                "(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = orcl.capel.cl))); User Id = PROD_ADM; " +
                                "Password = PROD1530;";
        //private readonly static string ConexionString = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 172.16.16.240)(PORT = 1521))) " +
        //                        "(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = desa.capel.cl))); User Id = usr_prod; " +
        //                        "Password = usrprod;";
        private readonly static string PathLog = @"C:/ROMANA/LOG/log.txt";
        
        private static void EscribirEnLog(string Texto)
        {
            string[] NuevaLinea = new string[] { DateTime.Now.ToString() + " " + Texto };
            File.AppendAllLines(PathLog, NuevaLinea);
        }

        public static string ObtenerNombrePlanta(int _idPlanta)
        {
            try
            {
                using (var conexion = new OracleConnection(ConexionString))
                {
                    conexion.Open();
                    EscribirEnLog("Conexión a Oracle Exitosa.");
                    using (var command = conexion.CreateCommand())
                    {
                        command.CommandText = "Select Nombre_Planta from COOPER_ADM.planta " +
                                                "where ID_PLANTA = "+_idPlanta;
                        command.CommandType = System.Data.CommandType.Text;
                        var dr = command.ExecuteReader();
                        var temp = string.Empty;
                        while (dr.Read())
                        {
                            temp = dr.GetString(0);
                        }
                        conexion.Close();
                        return temp;
                    }
                }
            }
            catch (Exception)
            {
                EscribirEnLog("Error al obtener el Nombre de la Planta");
                return "Error";
            }
        }

        public static void InsertarDatosEnPasarela(Session _userSession)
        {
            try
            {
                using (var conexion = new OracleConnection(ConexionString))
                {
                    conexion.Open();
                    var comando = "INSERT INTO COOPER_ADM.PESO_ROMANA " +
                                    "(id_peso_romana,Peso,Estado,Fecha,ID_Planta,Tipo_Proceso) " +
                                    "VALUES(cooper_adm.seq_peso_romana.nextval,:peso,0,sysdate,:planta,2)";
                    using (var cmd = new OracleCommand(comando, conexion))
                    {
                        OracleParameter[] parametros = new OracleParameter[]
                        {
                            new OracleParameter("peso",_userSession.Peso),
                            //new OracleParameter("fecha",DateTime.Now.ToString("dd-MM-yyyy")),
                            new OracleParameter("planta",_userSession.ID_Planta)
                        };
                        cmd.Parameters.AddRange(parametros);
                        cmd.ExecuteNonQuery();
                    }
                    conexion.Close();
                    EscribirEnLog("Datos insertados en pasarela correctamente.");
                }
            }
            catch (Exception _error)
            {
                EscribirEnLog("Error al Insertar los datos en Pasarela. Error: "+_error);

            }
        }

        public static void InsertarFoto(Session _userSession)
        {
            try
            {
                using (var conexion = new OracleConnection(ConexionString))
                {
                    conexion.Open();
                    var comando = "insert into cooper_adm.recepcion_uva_foto " +
                                    "(OBSERVACION,IMAGEN,LECTURA,FECHA,COSECHA,ID_PLANTA,NUM_TICKET_ATENCION,TIPO_CONTROL) " +
                                    "VALUES(:observacion,:imagen,0,sysdate,:cosecha,:planta,:ticket,:control)";
                    using (var cmd = new OracleCommand(comando, conexion))
                    {
                        OracleParameter[] parametros = new OracleParameter[]
                        {
                            //new OracleParameter("id_recepcion",_userSession.Ticket),
                            new OracleParameter("observacion","Ningún problema."),
                            new OracleParameter("imagen",_userSession.Imagen),
                            new OracleParameter("cosecha",DateTime.Now.Year),
                            //new OracleParameter("fecha",DateTime.Now.ToString("dd-MM-yyyy")),
                            new OracleParameter("planta",_userSession.ID_Planta),
                            new OracleParameter("ticket",_userSession.Ticket),
                            new OracleParameter("control",_userSession.Tipo_Control)
                        };
                        cmd.Parameters.AddRange(parametros);
                        cmd.ExecuteNonQuery();
                    }
                    conexion.Clone();
                    EscribirEnLog("Imagen Insertada correctamente en BD.");
                }
            }
            catch (Exception)
            {
                EscribirEnLog("Error al insertar Imagen en Base de Datos.");
            }
        }

        public static void SetConfiguracionDePuerto(SerialPort puertoSerial, int ID_Planta, int TipoProceso)
        {
            try
            {
                using (var conexion = new OracleConnection(ConexionString))
                {
                    conexion.Open();
                    EscribirEnLog("Conexión a Oracle Exitosa.");
                    using (var command = conexion.CreateCommand())
                    {
                        command.CommandText = "Select Nombre_Puerto,byte, paridad,databits,observacion " +
                            "from cooper_adm.parametro where ID_Planta = " + ID_Planta + " and ID_Tipo =" + TipoProceso;
                        command.CommandType = System.Data.CommandType.Text;
                        var dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            Properties.Settings.Default.NombrePuerto = dr.GetString(0);
                            puertoSerial.PortName = Properties.Settings.Default.NombrePuerto;
                            Properties.Settings.Default.BaudRate = dr.GetInt32(1);
                            puertoSerial.BaudRate = Properties.Settings.Default.BaudRate;
                            Properties.Settings.Default.Paridad = dr.GetString(2);
                            puertoSerial.Parity = ObtenerParidad(Properties.Settings.Default.Paridad);
                            Properties.Settings.Default.Databits = dr.GetInt32(3);
                            puertoSerial.DataBits = Properties.Settings.Default.Databits;
                            Properties.Settings.Default.Valor_Anexado = dr.GetString(4);

                        }
                        Properties.Settings.Default.Save();
                        conexion.Close();
                    }
                }


            }
            catch (Exception e)
            {
                EscribirEnLog(e.Message);
            }
        }

        private static Parity ObtenerParidad(string _paridadEnArchivo)
        {
            switch (_paridadEnArchivo)
            {
                case "e":
                    return Parity.Even;
                case "None":
                    return Parity.None;
            }
            return Parity.None;
        }

        public static void VerificarIntegridadBaseDeDatos(int _idPlanta)
        {
            try
            {
                using (var Conexion = new OracleConnection(ConexionString))
                {
                    Conexion.Open();
                    using (var Command = Conexion.CreateCommand())
                    {
                        Command.CommandText = "Select ID_PESO_ROMANA from cooper_adm.peso_romana where Estado = 0 and " +
                            "ID_PLANTA = "+_idPlanta+" and TIPO_PROCESO = 2";
                        Command.CommandType = System.Data.CommandType.Text;
                        var dr = Command.ExecuteReader();
                        while (dr.Read())
                        {
                            using (var Comando = Conexion.CreateCommand())
                            {
                                Comando.CommandText = "UPDATE cooper_adm.peso_romana SET ESTADO = 1, CADENA = 'ERROR ERP' " +
                                    "WHERE ID_PESO_ROMANA = " + dr.GetInt32(0);
                                Comando.ExecuteNonQuery();
                            }
                        }
                    }
                    Conexion.Close();
                }
            }
            catch (OracleException e)
            {
                EscribirEnLog("Error en la Consulta Oracle. Error : " + e.Message);
            }
        }

        public static void ActualizarEstado(int _idPesoRomana,Session _userSession)
        {
            try
            {
                using (var Conexion = new OracleConnection(ConexionString))
                {
                    Conexion.Open();
                    using (var Command = Conexion.CreateCommand())
                    {
                        Command.CommandText = "UPDATE cooper_adm.peso_romana SET PESO = "+_userSession.Peso+"" +
                            " WHERE ";
                    }
                }
            }
            catch (OracleException error)
            {
                EscribirEnLog("Error al Actualizar el Estado. Error: "+error.Message);
            }
        }

        public static void InsertarEstadoApp(int _estado, int _idPlanta, int _proceso)
        {
            try
            {
                using (var conexion = new OracleConnection(ConexionString))
                {
                    conexion.Open();
                    var comando = "insert into cooper_adm.peso_romana" +
                                    "(id_peso_romana,Estado,ID_Planta,Tipo_Proceso) " +
                                    "VALUES(cooper_adm.seq_peso_romana.nextval,:estado,:planta,:proceso)";
                    using (var cmd = new OracleCommand(comando, conexion))
                    {
                        OracleParameter[] parametros = new OracleParameter[]
                        {
                            new OracleParameter("estado",_estado),
                            new OracleParameter("planta",_idPlanta),
                            new OracleParameter("proceso",_proceso)
                        };
                        cmd.Parameters.AddRange(parametros);
                        cmd.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (OracleException error)
            {
                EscribirEnLog("Error al Insertar el Estado APP en Pasarela. Error: " + error.Message);
            }
        }

        public static void InsertarFotoCierre()
        {
            //Método que toma foto de la pantallas completas, para validar que la información entregada
            //sea fidedigna

        }

    }
}
