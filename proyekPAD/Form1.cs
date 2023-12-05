using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyekPAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMaster fm = new FormMaster();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void buttonKasir_Click(object sender, EventArgs e)
        {
            FormKasir fk = new FormKasir();
            this.Hide();
            fk.ShowDialog();
            this.Show();
        }
    }
}
