﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Filtros
{
    class Ventas : Ifiltros
    {
        Sqlite s = new Sqlite();
        public void filtro(DataGridView dgv,string fil)
        {
            throw new NotImplementedException();
        }

        public void tabla(DataGridView dgv)
        {
            string query = string.Format("select * from Ventas");
            s.dgrid(dgv, query);
        }
    }
}
