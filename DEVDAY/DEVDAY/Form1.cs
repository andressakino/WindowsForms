using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVDAY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void button_Cep_Click(object sender, EventArgs e)
        {
            Correios.AtendeClienteClient consulta = new Correios.AtendeClienteClient("AtendeClientePort");

        
                try
                {
                    var resultado = consulta.consultaCEP(txtcep.Text);

                    if (resultado != null)
                    {
                        txtbairro.Text = resultado.bairro;
                        txtcidade.Text = resultado.cidade;
                        txtlogradouro.Text = ($"{resultado.end} {resultado.complemento2}");
                        txtuf.Text = resultado.uf;
                    }
                }
                catch (Exception)
                {
                MessageBox.Show("CEP NÂO ENCONTRADO");    

                    txtbairro.Text = "";
                    txtcidade.Text = "";
                    txtlogradouro.Text = "";
                    txtuf.Text = ""; ;
                }
            
=======
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

>>>>>>> Lucas
        }
    }
}
