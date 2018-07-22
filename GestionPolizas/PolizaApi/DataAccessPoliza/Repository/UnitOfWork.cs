using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessPoliza.Repository
{
    public class UnitOfWork
    {
        private GestionPolizaEntities _context = new GestionPolizaEntities();

        public GestionPolizaEntities Context
        {
            get
            {

                if (this._context == null)
                {
                    this._context = new GestionPolizaEntities();
                }
                return Context;
            }
        }


    }
}
