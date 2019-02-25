﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendedores v = new Vendedores();
            v.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventario i = new Inventario();
            i.Show();
            this.Hide();
        }

        private void btnbus_Click(object sender, EventArgs e)
        {
            Filtrar f = new Filtrar();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Suscritos s = new Suscritos();
            s.Show();
        }
    }
}