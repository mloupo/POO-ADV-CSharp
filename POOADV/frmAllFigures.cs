using POOADV.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using POOADV.Modelo;

namespace POOADV
{
    public partial class frmAllFigures : Form
    {
        List<IFiguraGeometrica> ListFiguras = new List<IFiguraGeometrica>();
        Form frmFather;
        
        public frmAllFigures(Form frm, List<IFiguraGeometrica> lista)
        {
            InitializeComponent();
            //this.listViewAllFigures.Items.Clear();
            this.ListFiguras = lista;            
            frmFather = frm;
        }        

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFather.Show();
            this.Close();            
        }

        private void ShowAllFigures()
        {
            foreach (IFiguraGeometrica figura in ListFiguras)
            {
                Console.WriteLine(figura);
                listViewAllFigures.Items.Add(figura.ToString());
            }        
        }

        private void frmAllFigures_Load(object sender, EventArgs e)
        {
            ShowAllFigures();
        }
    }
}
