﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condominios
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login(); 
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void disponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDisponibles = new FormApartamentos_Disponibles();
            formDisponibles.MdiParent = this;   
            formDisponibles.Show();   
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();    
        }
    }
}
