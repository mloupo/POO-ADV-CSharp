namespace POOADV
{
    partial class FFigura
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
            this.cmbFigure = new System.Windows.Forms.ComboBox();
            this.lblSelectedFigure = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblSuperficie = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblResultSup = new System.Windows.Forms.Label();
            this.lblResultPerim = new System.Windows.Forms.Label();
            this.MostrarTodos = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cmbFigure
            // 
            this.cmbFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigure.FormattingEnabled = true;
            this.cmbFigure.Items.AddRange(new object[] {
            "Circulo",
            "Triangulo",
            "Cuadrado"});
            this.cmbFigure.Location = new System.Drawing.Point(174, 25);
            this.cmbFigure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFigure.Name = "cmbFigure";
            this.cmbFigure.Size = new System.Drawing.Size(172, 24);
            this.cmbFigure.TabIndex = 1;
            this.cmbFigure.SelectedIndexChanged += new System.EventHandler(this.cmbFigure_SelectedIndexChanged);
            // 
            // lblSelectedFigure
            // 
            this.lblSelectedFigure.AutoSize = true;
            this.lblSelectedFigure.Location = new System.Drawing.Point(33, 28);
            this.lblSelectedFigure.Name = "lblSelectedFigure";
            this.lblSelectedFigure.Size = new System.Drawing.Size(116, 16);
            this.lblSelectedFigure.TabIndex = 2;
            this.lblSelectedFigure.Text = "Seleccione Figura";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(105, 114);
            this.txtRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 22);
            this.txtRadio.TabIndex = 3;
            this.txtRadio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRadio_KeyPress);
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(105, 142);
            this.txtLado2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 22);
            this.txtLado2.TabIndex = 4;
            this.txtLado2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLado2_KeyPress);
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(105, 169);
            this.txtLado3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 22);
            this.txtLado3.TabIndex = 5;
            this.txtLado3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLado3_KeyPress);
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(16, 121);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(79, 16);
            this.lblRadio.TabIndex = 6;
            this.lblRadio.Text = "Radio/Lado";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(20, 148);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(45, 16);
            this.lblLado2.TabIndex = 7;
            this.lblLado2.Text = "Lado2";
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(20, 175);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(45, 16);
            this.lblLado3.TabIndex = 8;
            this.lblLado3.Text = "Lado3";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCreate.Location = new System.Drawing.Point(235, 170);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 26);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingrese Longitud";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(16, 219);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(68, 16);
            this.lblPerimetro.TabIndex = 11;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // lblSuperficie
            // 
            this.lblSuperficie.AutoSize = true;
            this.lblSuperficie.Location = new System.Drawing.Point(12, 241);
            this.lblSuperficie.Name = "lblSuperficie";
            this.lblSuperficie.Size = new System.Drawing.Size(70, 16);
            this.lblSuperficie.TabIndex = 12;
            this.lblSuperficie.Text = "Superficie:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSalir.Location = new System.Drawing.Point(296, 281);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 39);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Exit";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.BtnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
            // 
            // lblResultSup
            // 
            this.lblResultSup.AutoSize = true;
            this.lblResultSup.Location = new System.Drawing.Point(105, 266);
            this.lblResultSup.Name = "lblResultSup";
            this.lblResultSup.Size = new System.Drawing.Size(0, 16);
            this.lblResultSup.TabIndex = 16;
            // 
            // lblResultPerim
            // 
            this.lblResultPerim.AutoSize = true;
            this.lblResultPerim.Location = new System.Drawing.Point(105, 241);
            this.lblResultPerim.Name = "lblResultPerim";
            this.lblResultPerim.Size = new System.Drawing.Size(0, 16);
            this.lblResultPerim.TabIndex = 17;
            // 
            // MostrarTodos
            // 
            this.MostrarTodos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MostrarTodos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MostrarTodos.Location = new System.Drawing.Point(190, 281);
            this.MostrarTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MostrarTodos.Name = "MostrarTodos";
            this.MostrarTodos.Size = new System.Drawing.Size(88, 39);
            this.MostrarTodos.TabIndex = 18;
            this.MostrarTodos.Text = "Show All";
            this.MostrarTodos.UseVisualStyleBackColor = false;
            this.MostrarTodos.Click += new System.EventHandler(this.MostrarTodos_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(448, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 257);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FFigura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1034, 334);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.MostrarTodos);
            this.Controls.Add(this.lblResultPerim);
            this.Controls.Add(this.lblResultSup);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblSuperficie);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblSelectedFigure);
            this.Controls.Add(this.cmbFigure);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FFigura";
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.FFigura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFigure;
        private System.Windows.Forms.Label lblSelectedFigure;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblSuperficie;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblResultSup;
        private System.Windows.Forms.Label lblResultPerim;
        private System.Windows.Forms.Button MostrarTodos;
        private System.Windows.Forms.ListView listView1;
    }
}

