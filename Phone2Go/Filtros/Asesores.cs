﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Filtros
{
    class Asesores : Ifiltros
    {
        Sqlite s = new Sqlite();
        public void filtro(DataGridView dgv,string Filtros)
        {
            throw new NotImplementedException();
        }

        public void tabla(DataGridView dgv)
        {
            string query = string.Format("Select * from Asesores");
            s.dgrid(dgv, query);
        }
    }
}
