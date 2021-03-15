
namespace appkcc_02
{
    partial class Clientes
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
            this.btnInserirCliente = new System.Windows.Forms.Button();
            this.txtInserirCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserirCliente
            // 
            this.btnInserirCliente.Location = new System.Drawing.Point(21, 59);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(126, 23);
            this.btnInserirCliente.TabIndex = 0;
            this.btnInserirCliente.Text = "Inserir Cliente";
            this.btnInserirCliente.UseVisualStyleBackColor = true;
            this.btnInserirCliente.Click += new System.EventHandler(this.btnInserirCliente_Click);
            // 
            // txtInserirCliente
            // 
            this.txtInserirCliente.Location = new System.Drawing.Point(21, 33);
            this.txtInserirCliente.Name = "txtInserirCliente";
            this.txtInserirCliente.Size = new System.Drawing.Size(126, 20);
            this.txtInserirCliente.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInserirCliente);
            this.groupBox1.Controls.Add(this.txtInserirCliente);
            this.groupBox1.Location = new System.Drawing.Point(27, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inserir Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remover Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(295, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alterar Nome de Clientes";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserirCliente;
        private System.Windows.Forms.TextBox txtInserirCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}