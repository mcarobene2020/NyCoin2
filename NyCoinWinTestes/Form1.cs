using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;



namespace testeWebApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WebApi.TesteApibit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebApi.Logar("example@example.com", "aOiuawe0231");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebApi.CarregarSaldo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebApi.CarregarOrdensDoPar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // TesteApi.LoadPairs();
        }
    }
}
