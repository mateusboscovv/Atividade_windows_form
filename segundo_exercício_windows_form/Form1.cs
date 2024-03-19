using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundo_exercício_windows_form
{
    public partial class Form1 : Form
    {
        private const string constLogin = "adm";
        private const string constPass = "ds@etefmc";
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //captura de texto de login
            string login = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //captura de texto de password
            string password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Captura dos textos inseridos
            string login = textBox1.Text;
            string password = textBox2.Text;

            //verifica condições
            if (login == constLogin && password == constPass) 
            {
                //private void button1_Click(object sender, EventArgs e) forma errada de se colocar um viod dentro de um if --> private já foi declarado dentro do viod anterior(void = cabeçalho)
                 
                
                    MessageBox.Show("Logged in!");
                
            }

            else
            {
                MessageBox.Show("Error: login or password invalid try again");
            }
        }
    }
}
