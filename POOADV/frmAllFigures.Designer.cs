namespace POOADV
{
    partial class frmAllFigures
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewAllFigures = new System.Windows.Forms.ListView();
            this.fFiguraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fFiguraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.goBackToolStripMenuItem.Text = "Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // listViewAllFigures
            // 
            this.listViewAllFigures.HideSelection = false;
            this.listViewAllFigures.Location = new System.Drawing.Point(12, 70);
            this.listViewAllFigures.Name = "listViewAllFigures";
            this.listViewAllFigures.Size = new System.Drawing.Size(765, 259);
            this.listViewAllFigures.TabIndex = 3;
            this.listViewAllFigures.UseCompatibleStateImageBehavior = false;
            /* this.listViewAllFigures.View = System.Windows.Forms.View.Details; //No me Muestra los items con esto descomentado */
            // 
            // fFiguraBindingSource
            // 
            this.fFiguraBindingSource.DataSource = typeof(POOADV.FFigura);
            // 
            // frmAllFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 447);
            this.Controls.Add(this.listViewAllFigures);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAllFigures";
            this.Text = "frmAllFigures";
            this.Load += new System.EventHandler(this.frmAllFigures_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fFiguraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fFiguraBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        public System.Windows.Forms.ListView listViewAllFigures;
    }
}