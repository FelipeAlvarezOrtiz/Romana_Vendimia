using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romana_Vendimia.Modelo
{
    public class Session
    {
        public int Ticket { get; set; }
        public int ID_Planta { get; set; }
        public string Nombre_Planta { get; set; }
        public int Peso { get; set; }
        public byte[] Imagen { get; set; }

        public string PalabraBuscada { get; set; }

        public int Tipo_Control { get; set; }

        //Tipo Proceso 2 romana
        public Session()
        {

        }

        public void Clear_Session()
        {
            Ticket = 0;
            Peso = 0;
            Imagen = null;

        }
    }
}
