using POOADV.Interfaces;
using POOADV.Modelo;

using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace POOADV
{
    public partial class FFigura : Form
    {
        List<IFiguraGeometrica> ListaFiguras = new List<IFiguraGeometrica>();

        public FFigura()
        {
            InitializeComponent();
        }

        private void FFigura_Load(object sender, EventArgs e)
        {
            cmbFigure.SelectedIndex = 0;
        }

        private void cmbFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFigure.Text)
            {
                case "Circulo":
                    clean_fields();
                    txtRadio.Enabled = true;
                    txtLado2.Visible = false;
                    txtLado3.Visible = false;
                    lblRadio.Text = "Radio";
                    lblLado2.Visible = false;
                    lblLado3.Visible = false;
                    clean_fields();
                    clean_results();

                    break;
                case "Triangulo":
                    clean_fields();
                    txtRadio.Enabled = true;
                    txtLado2.Visible = true;
                    txtLado3.Visible = true;
                    lblRadio.Text = "Lado1";
                    lblLado2.Visible = true;
                    lblLado3.Visible = true;
                    clean_fields();
                    clean_results();
                    break;
                case "Cuadrado":
                    clean_fields();
                    txtRadio.Enabled = true;
                    txtLado2.Visible = false;
                    txtLado3.Visible = false;
                    lblRadio.Text = "Lado";
                    lblLado2.Visible = false;
                    lblLado3.Visible = false;
                    clean_fields();
                    clean_results();
                    break;
            }
        }


        private void clean_results()
        {
            lblPerimetro.Text = "Perimetro: ";
            lblSuperficie.Text = "Superficie: ";
        }
        private void show_perimeter_and_surface(IFiguraGeometrica figure)
        {
            lblPerimetro.Text = $"Perimetro: {figure.Perimetro()}";
            lblSuperficie.Text = $"Superficie: {figure.Superficie()}";
        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            switch (cmbFigure.Text)
            {
                case "Circulo":
                    IFiguraGeometrica circulo = create_circle();
                    Console.WriteLine("Creaste un " + circulo.ToString());
                    show_perimeter_and_surface(circulo);
                    add_figure(circulo);
                    break;

                case "Triangulo":

                    IFiguraGeometrica triangulo = create_triangle();
                    Console.WriteLine("Creaste un " + triangulo.ToString());
                    show_perimeter_and_surface(triangulo);
                    add_figure(triangulo);
                    break;

                case "Cuadrado":

                    IFiguraGeometrica cuadrado = create_square();
                    Console.WriteLine("Creaste un " + cuadrado.ToString());
                    show_perimeter_and_surface(cuadrado);
                    add_figure(cuadrado);
                    break;
            }
            bindingSource1.DataSource = ListaFiguras;
            ShowAllFigures();

        }

        private void IsValid(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtRadio_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValid(e);
        }
        private void txtLado2_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValid(e);
        }
        private void txtLado3_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValid(e);
        }

        private Circulo create_circle()
        {
            return new Circulo(
                double.Parse(txtRadio.Text)
                );
        }

        private Triangulo create_triangle()
        {
            return new Triangulo(
                double.Parse(txtRadio.Text),
                double.Parse(txtLado2.Text),
                Convert.ToDouble(txtLado3.Text)
                );
        }

        private Cuadrado create_square()
        {
            return new Cuadrado(
                Convert.ToDouble(txtRadio.Text)
                );
        }

        void add_figure(IFiguraGeometrica figura)
        {
            ListaFiguras.Add(figura);
        }

        private void clean_fields()
        {
            txtRadio.Text = "0";
            txtLado2.Text = "0";
            txtLado3.Text = "0";
        }
        private void BtnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.Text = "Seguro?";
        }
        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.Text = "Salir";
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowAllFigures()
        {
            
            bindingSource1.ResetBindings(false);
            DgvFigures.DataSource = bindingSource1;

            Console.WriteLine("Estamos en el Formulario de Creacion");
            listView1.Items.Clear();
            foreach (IFiguraGeometrica figura in ListaFiguras)
            {
                Console.WriteLine(figura);
                listView1.Items.Add(figura.ToString());
                //DgvFigures.Rows.Add(figura);
            }
            
            
        }

        public List<IFiguraGeometrica> GetList()
        {
            return ListaFiguras;
        }


        private void MostrarTodos_Click(object sender, EventArgs e)
        {
            frmAllFigures frm = new frmAllFigures(this, ListaFiguras);
            this.Hide(); 
            frm.Show();
        }


    }

}



