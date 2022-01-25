using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GlitchScreen
{
    public partial class Reload : Form
    {
        public Reload()
        {
            InitializeComponent();
        }

        private void Reload_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Reload_Load(object sender, EventArgs e)
        {
            var GoBack = new Form1();
            GoBack.ShowDialog();
        }
    }
}