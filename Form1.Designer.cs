
namespace appkcc_02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFiltrarCliente = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recolocarListaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recolocarListaDosMovimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaDosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 329);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.movPersona);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 27;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(239, 9);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(763, 381);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTA DE CIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(555, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "M O V I M E N T O S";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(6, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 398);
            this.panel1.TabIndex = 3;
            // 
            // txtFiltrarCliente
            // 
            this.txtFiltrarCliente.Location = new System.Drawing.Point(105, 9);
            this.txtFiltrarCliente.Name = "txtFiltrarCliente";
            this.txtFiltrarCliente.Size = new System.Drawing.Size(95, 20);
            this.txtFiltrarCliente.TabIndex = 4;
            this.txtFiltrarCliente.TextChanged += new System.EventHandler(this.txtFiltrarCliente_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.gravarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // gravarToolStripMenuItem
            // 
            this.gravarToolStripMenuItem.Name = "gravarToolStripMenuItem";
            this.gravarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gravarToolStripMenuItem.Text = "Gravar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.janelaDosClientesToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.verToolStripMenuItem.Text = "Visualizar";
            // 
            // cRUDToolStripMenuItem
            // 
            this.cRUDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarToolStripMenuItem,
            this.lerToolStripMenuItem,
            this.atualizarToolStripMenuItem,
            this.apagarToolStripMenuItem});
            this.cRUDToolStripMenuItem.Name = "cRUDToolStripMenuItem";
            this.cRUDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cRUDToolStripMenuItem.Text = "CRUD";
            // 
            // criarToolStripMenuItem
            // 
            this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            this.criarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarToolStripMenuItem.Text = "Criar";
            // 
            // lerToolStripMenuItem
            // 
            this.lerToolStripMenuItem.Name = "lerToolStripMenuItem";
            this.lerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lerToolStripMenuItem.Text = "Ler";
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apagarToolStripMenuItem.Text = "Apagar";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recolocarListaDeClientesToolStripMenuItem,
            this.recolocarListaDosMovimentosToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // recolocarListaDeClientesToolStripMenuItem
            // 
            this.recolocarListaDeClientesToolStripMenuItem.Name = "recolocarListaDeClientesToolStripMenuItem";
            this.recolocarListaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.recolocarListaDeClientesToolStripMenuItem.Text = "Recolocar Lista de Clientes";
            this.recolocarListaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.recolocarListaDeClientesToolStripMenuItem_Click);
            // 
            // recolocarListaDosMovimentosToolStripMenuItem
            // 
            this.recolocarListaDosMovimentosToolStripMenuItem.Name = "recolocarListaDosMovimentosToolStripMenuItem";
            this.recolocarListaDosMovimentosToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.recolocarListaDosMovimentosToolStripMenuItem.Text = "Recolocar Lista dos Movimentos";
            this.recolocarListaDosMovimentosToolStripMenuItem.Click += new System.EventHandler(this.recolocarListaDosMovimentosToolStripMenuItem_Click);
            // 
            // janelaDosClientesToolStripMenuItem
            // 
            this.janelaDosClientesToolStripMenuItem.Name = "janelaDosClientesToolStripMenuItem";
            this.janelaDosClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.janelaDosClientesToolStripMenuItem.Text = "Janela dos Clientes";
            this.janelaDosClientesToolStripMenuItem.Click += new System.EventHandler(this.janelaDosClientesToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Procurar Cliente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFiltrarCliente);
            this.panel2.Location = new System.Drawing.Point(10, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 37);
            this.panel2.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Movimento com maior valor a crédito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1022, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "appkcc_02 - Domingos Ribeiro";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFiltrarCliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recolocarListaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recolocarListaDosMovimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelaDosClientesToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

