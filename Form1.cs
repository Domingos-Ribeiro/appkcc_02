using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EfaUtils;

namespace appkcc_02
{
    public partial class Form1 : Form
    {
        private string SC =
                    "data source = DOMINGOS\\SQLEXPRESS;" +
                    "Initial Catalog = ApkccDB;" +
                    "User Id=sa;" +
                    "Password=123.Abc.@;";

        private string SSQL = "";

        public Form1()
        {
            InitializeComponent();


            // Conexão com a base de dados
            DataTable dt = new DataTable();
            Conecta c = new Conecta();
            SSQL = "select * from TClientes;";
            listBox1.ValueMember = "Id"; // O Id fica atribuido ao valueMember
            dt = c.BuscarDados(SC, SSQL);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "NomeCliente";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void movPersona(object sender, EventArgs e)
        {
            //avasi buscar od dados à tabela movimentos
            Conecta obj = new Conecta();
            SSQL = "select * from TMovimentos where ClienteId = " + listBox1.SelectedValue;
            dataGridView1.DataSource = obj.BuscarDados(SC, SSQL);
        }
    }
}
