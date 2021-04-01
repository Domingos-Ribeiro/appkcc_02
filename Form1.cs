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


        private string SSQL = "";
    


        public Form1()
        {
            InitializeComponent();

            // Conexão com a base de dados SQL
            DataTable dt = new DataTable();
            Conecta c = new Conecta();
            SSQL = "select * from TClientes;";
            listBox1.ValueMember = "Id"; // O Id fica atribuido ao valueMember
            c.SSQL = SSQL;
            dt = c.BuscarDados();
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
            obj.SSQL = SSQL;
            dataGridView1.DataSource = obj.BuscarDados();

            dataGridView1.Columns.Add("Saldo", "Saldo");
            dataGridView1.Columns.Add("Produção", "Produção");

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
            c.SSQL = SSQL;
            listBox1.DataSource = c.BuscarDados();

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


        void NovaColuna()
        {
            // FEITO PARA A PRODUÇÃO
            int tamanho = dataGridView1.Rows.Count; // Percorre a grid
            int credito = 0; // Variável para armazenar o valor do crédito, visto que é a coluna a procurar
            string dados = "X"; // String para poder colocar o X na coluna

            for (int i = 0; i < tamanho; i++)
            {

                try
                {
                    // Tentei alterar o valor para dar mais resultados
                    if (credito < 99)
                    {
                        credito = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value); 
                    }
                     
                }
                catch (Exception)
                {
   
                }
                // Ver alteração
                dataGridView1.Rows[i].Cells["Produção"].Value = credito;

                if (credito > 99)
                {
                    dataGridView1.Rows[i].Cells["Produção"].Value = dados;
                }

            }

        }

        private void produção1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // FEITO PARA A PRODUÇÃO
            NovaColuna();
        }

        private void comMaiorValorACréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Movimento com maior valor a Crédito
            string descricao = "";
            double valorProcurado = 0;
            double creditoMaior = 0; // Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value);
            double total = creditoMaior;
            descricao = Convert.ToString(dataGridView1.Rows[0].Cells[2].Value);

            for (int i = 1; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    valorProcurado = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);

                    if (valorProcurado > creditoMaior)
                    {
                        creditoMaior = valorProcurado;
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception)
                {

                }

                if (total <= creditoMaior)
                {
                    //devolver a descrição do documento:

                    MessageBox.Show(descricao.ToString() + "\n\n" + total + ".00");
                }
                descricao = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            }
        }

        private void btnEnviarDadosParaBD_Click(object sender, EventArgs e)
        {
            // Alinea a) Recolher e Inserir movimentos
            Conecta obj = new Conecta();

            // Mensagem de confirmação da inserção de dados.
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja inserir estes dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
                obj.SSQL = $"insert into TMovimentos(DataRegisto, Descricao, ValorDebito, ValorCredito, ClienteId) values('{dateTimePicker1.Value.ToString("yyyy/MM/dd")}', '{txtDescricao.Text}', '{txtValorDebito.Text}', '{txtValorCredito.Text}', '{listBox1.SelectedValue}');";
                
                obj.BuscarDados();
            }

            // Alinea b) Atualizar a Grid
            Conecta refresh = new Conecta();
            SSQL = "select * from TMovimentos where ClienteId = " + listBox1.SelectedValue;

            dataGridView1.Columns.Clear();
            obj.SSQL = SSQL;
            dataGridView1.DataSource = obj.BuscarDados();

            dataGridView1.Columns.Add("Saldo", "Saldo");
            dataGridView1.Columns.Add("Produção", "Produção");

            CalcularTotaisDebitoCredito();

            FormatarGrid();

            CalcularSaldo();
        }

        private void btnEliminarMovimento_Click(object sender, EventArgs e)
        {
            // Alinea a) Obter numero da linha corrente.
            int numLinhaNaGrid = dataGridView1.CurrentRow.Index;


            // Alinea b) Dessa linha obter a chave primaria
            int PK = Convert.ToInt32(dataGridView1.Rows[numLinhaNaGrid].Cells[0].Value);


            // Alinea c) Com essa PK eliminar o registo (SQL)
            string s = $"delete from TMovimentos where Id = '{PK}'";

            Conecta obj = new Conecta();
            obj.SSQL = s;
            obj.BuscarDados();

        }
    }
}
