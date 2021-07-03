using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            int tamanofila, tamanocolumna;
            tamanofila = Convert.ToInt32(FilatextBox.Text);
            tamanocolumna = Convert.ToInt32(ColumnatextBox.Text);
            int[,] Matriz;
              Matriz = new int[tamanofila , tamanocolumna];
            Random aleatorio = new Random();
            for (int i = 0; i < tamanofila; i++)
            {
                for (int j = 0; j <tamanocolumna; j++)
                {
                    Matriz[i, j] = aleatorio.Next(1, 100);
                }
            }
            for (int i = 0; i < tamanofila; i++)
            {
                for (int j = 0; j < tamanocolumna; j++)
                {

                    MessageBox.Show("La posicion es :" + i + "," + j + " = " + Matriz[i, j].ToString());
                }


            }

        }
   }
}
