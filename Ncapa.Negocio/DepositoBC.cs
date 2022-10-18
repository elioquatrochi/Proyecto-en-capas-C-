using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ncapa.Datos;
using Ncapa.Entidad;
using System.Data;

namespace Ncapa.Negocio
{
  public  class DepositoBC
    {
        public DataTable GetAll ()
        {

            DepositoDAC oDeposito = new DepositoDAC();
            return oDeposito.GetAll();
        }

        public int Insert (DepositoBE obe)
        {
            DepositoDAC oDeposito = new DepositoDAC();
            return oDeposito.Deposito(obe);


        }
        public int Update(DepositoBE obe)
        {
            DepositoDAC oDeposito = new DepositoDAC();
            return oDeposito.DepositoUpdate(obe);


        }

        public int Delete(DepositoBE obe)
        {
            DepositoDAC odeposito = new DepositoDAC();
            
            return odeposito.DepositoDelete(obe);
        }
        
    }
}
