namespace Parcial2022
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDenuncia = new System.Windows.Forms.RadioButton();
            this.rbNuevoCliente = new System.Windows.Forms.RadioButton();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.lbTurnos = new System.Windows.Forms.ListBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnDenuncia = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // rbDenuncia
            // 
            this.rbDenuncia.AutoSize = true;
            this.rbDenuncia.Location = new System.Drawing.Point(6, 19);
            this.rbDenuncia.Name = "rbDenuncia";
            this.rbDenuncia.Size = new System.Drawing.Size(71, 17);
            this.rbDenuncia.TabIndex = 2;
            this.rbDenuncia.TabStop = true;
            this.rbDenuncia.Text = "Denuncia";
            this.rbDenuncia.UseVisualStyleBackColor = true;
            // 
            // rbNuevoCliente
            // 
            this.rbNuevoCliente.AutoSize = true;
            this.rbNuevoCliente.Location = new System.Drawing.Point(6, 43);
            this.rbNuevoCliente.Name = "rbNuevoCliente";
            this.rbNuevoCliente.Size = new System.Drawing.Size(92, 17);
            this.rbNuevoCliente.TabIndex = 3;
            this.rbNuevoCliente.TabStop = true;
            this.rbNuevoCliente.Text = "Nuevo Cliente";
            this.rbNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(116, 19);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(121, 20);
            this.tbPatente.TabIndex = 4;
            this.tbPatente.Text = "Patente";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(116, 43);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 5;
            this.cbTipo.Text = "Tipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDenuncia);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.rbNuevoCliente);
            this.groupBox1.Controls.Add(this.tbPatente);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 79);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Clientes";
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(287, 51);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(75, 70);
            this.btnTicket.TabIndex = 7;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            // 
            // lbTurnos
            // 
            this.lbTurnos.FormattingEnabled = true;
            this.lbTurnos.Location = new System.Drawing.Point(13, 27);
            this.lbTurnos.Name = "lbTurnos";
            this.lbTurnos.Size = new System.Drawing.Size(320, 121);
            this.lbTurnos.TabIndex = 8;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(13, 154);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 54);
            this.btnExportar.TabIndex = 10;
            this.btnExportar.Text = "Exportar Ticket";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(94, 154);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 54);
            this.btnImportar.TabIndex = 11;
            this.btnImportar.Text = "Importar Ticket";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnDenuncia
            // 
            this.btnDenuncia.Location = new System.Drawing.Point(175, 154);
            this.btnDenuncia.Name = "btnDenuncia";
            this.btnDenuncia.Size = new System.Drawing.Size(75, 54);
            this.btnDenuncia.TabIndex = 12;
            this.btnDenuncia.Text = "Atender Denuncias";
            this.btnDenuncia.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(258, 154);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 54);
            this.btnCliente.TabIndex = 13;
            this.btnCliente.Text = "Atender Nuevo Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTurnos);
            this.groupBox2.Controls.Add(this.btnCliente);
            this.groupBox2.Controls.Add(this.btnDenuncia);
            this.groupBox2.Controls.Add(this.btnExportar);
            this.groupBox2.Controls.Add(this.btnImportar);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 214);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turnos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDenuncia;
        private System.Windows.Forms.RadioButton rbNuevoCliente;
        private System.Windows.Forms.TextBox tbPatente;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.ListBox lbTurnos;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnDenuncia;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

