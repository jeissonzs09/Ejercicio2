using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Calcularbutton_Click(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(Nota1textBox.Text);
            decimal n2 = Convert.ToDecimal(Nota2textBox.Text);
            decimal n3 = Convert.ToDecimal(Nota3textBox.Text);
            decimal n4 = Convert.ToDecimal(Nota4textBox.Text);

            decimal Resultado = await PromedioAsync(n1, n2, n3, n4);

            PromediotextBox.Text = Resultado.ToString();
        }

        private async Task<decimal> PromedioAsync(decimal nota1, decimal nota2, decimal nota3, decimal nota4) 
        {
            decimal Promedio = await Task.Run(() => 
            {
                return (nota1 + nota2 + nota3 + nota4) / 4;
            });
            return Promedio;
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            Nota1textBox.Clear();
            Nota2textBox.Clear();
            Nota3textBox.Clear();
            Nota4textBox.Clear();
            PromediotextBox.Clear();
        }
    }
}
