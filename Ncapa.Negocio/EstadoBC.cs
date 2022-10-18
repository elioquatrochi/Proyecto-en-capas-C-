using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ncapa.Datos;
using Ncapa.Entidad;

namespace Ncapa.Negocio
{
  public  class EstadoBC
    {
        public DataTable GetAllEstado()
        {

            EstadoDAC oEstado = new EstadoDAC();
            return oEstado.combo();
        }

    }
}
