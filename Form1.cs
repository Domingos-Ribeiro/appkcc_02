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

            // Conexão com a base de dados SQL
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

        // ============== Método para ir à Tabela de Movimentos do SQL buscar os Dados ============== //
        private void movPersona(object sender, EventArgs e)
        {
            // Buscar os dados à tabela movimentos
            Conecta obj = new Conecta();
            SSQL = "select * from TMovimentos where ClienteId = " + listBox1.SelectedValue;

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = obj.BuscarDados(SC, SSQL);

            dataGridView1.Columns.Add("Saldo", "Saldo");

            CalcularTotaisDebitoCredito();

            FormatarGrid();

            CalcularSaldo();

            
        }
        // =========== FIM do Método para ir à Tabela de Movimentos do SQL buscar os Dados ========== //


        // =================== Método para reduzir a lista de Pesquisa dos Clientes ================= //
        private void txtFiltrarCliente_TextChanged(object sender, EventArgs e)
        {
            // Reduz a lista de clientes na listBox ao escrever na textBox
            Conecta c = new Conecta(); // Instanciação, retorna uma dataTable
            string SSQL = "SELECT * from TClientes Where NomeCliente like '%" + txtFiltrarCliente.Text + "%'";
            listBox1.DataSource = c.BuscarDados(SC, SSQL);

        }
        // =============== FIM do Método para reduzir a lista de Pesquisa dos Clientes ============== //


        // ============================== Método para Formatar a Grid =============================== //
        private void FormatarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[0].HeaderText = "PK";
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["id"].Width = 30;

            dataGridView1.Columns[2].HeaderText = "Descrição";
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[2].Width = 345;

            // Retira a coluna do ClientID
            dataGridView1.Columns[5].Visible = false;

            // Altera o nome do cabeçalho das colunas em baixo
            dataGridView1.Columns[3].HeaderText = "Débito";
            dataGridView1.Columns[4].HeaderText = "Crédito";

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            dataGridView1.Columns["Saldo"].ReadOnly = true;//proteger contra alteração pelo utilizador
            dataGridView1.Columns["Saldo"].DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold);

            dataGridView1.Columns[3].DefaultCellStyle.Format = "c2";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "c2";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "c2";
        }
        // =========================== FIM do Método para Formatar a Grid =========================== //


        // ==================  Método para calcular os Totais de DÉBITO e CRÉDITO  ================== // 
        void CalcularTotaisDebitoCredito()
        {
            double debito = 0;
            double credito = 0;
            double totalDebitos = 0;
            double totalCreditos = 0;
            int totalLinhas = dataGridView1.Rows.Count;


            for (int i = 0; i < totalLinhas; i++)
            {
                try
                {
                    debito = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    totalDebitos = totalDebitos + debito;
                }
                catch { }
                try
                {
                    credito = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                    totalCreditos = totalCreditos + credito;
                }
                catch { }
            }

            //txtCreditos.Text = Convert.ToString(totalCreditos);
            //txtDebitos.Text = Convert.ToString(totalDebitos);
        }
        // ==============  FIM do Método para calcular os Totais de DÉBITO e CRÉDITO  =============== // 


        // =====================  Método para calcular o saldo de cada Cliente  ===================== // 
        void CalcularSaldo()
        {
            int tamanho = dataGridView1.Rows.Count;
            int debito = 0;
            int credito = 0;
            int saldoTotal = 0;

            for (int i = 0; i < tamanho; i++)
            {
                // Como alguns dados estarão vazios (credito ou debito) é necessário
                // Colocar o try Catch
                try
                {
                    debito = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                }
                catch (Exception)
                {
                    debito = 0;
                }

                try
                {
                    credito = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                }
                catch (Exception)
                {
                    credito = 0;
                }

                saldoTotal = saldoTotal + credito - debito;
                dataGridView1.Rows[i].Cells[6].Value = saldoTotal;
            }

        }
        // =========================== FIM do Método para calcular saldo  =========================== // 


        // ====================================   Menu Strip   ====================================== //
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mensagem de confirmação da saída do programa com o botão NÃO selecionado.
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja fechar o programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
                Application.Exit();
            }
        }
        private void recolocarListaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colonias obj = new Colonias();
            obj.RecolonizarClientes();
        }
        private void recolocarListaDosMovimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colonias obj = new Colonias();
            obj.RecolonizarMovimentos();
        }
        private void janelaDosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes f2 = new Clientes();
            f2.ShowDialog();
        }
        // ===================================  FIM do Menu Strip   ================================= //


    }
}
