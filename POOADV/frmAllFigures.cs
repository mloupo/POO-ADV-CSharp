using POOADV.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace POOADV
{
    public partial class frmAllFigures : Form
    {
        List<IFiguraGeometrica> ListFiguras = new List<IFiguraGeometrica>();
        Form frmFather;

        public frmAllFigures(Form frm, List<IFiguraGeometrica> lista)
        {
            frmFather = frm;
            ListFiguras = lista;
            InitializeComponent();

        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFather.Show();
            this.Hide();
        }

        private void ShowAllFigures()
        {
            listViewAllFigures.Items.Clear();
            Console.WriteLine("Estamos en el Formulario de Presentacion");
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
