using System;
using System.Windows.Forms;

namespace Ejercicio_Numero_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //arreglo nombres
            string[] nombre = new string[] { "Carlos Andino", "Katherine Marquez", "Valery Marquez", "Rosa Andino", "Angel Espinoza" };
            Array.Sort(nombre);
            foreach (string x  in nombre)
            {
                cb2.Items.Add(x);
            }

            int[] edad = new int[] { 13, 12, 14, 16, 15 };
            Array.Sort(edad);
            foreach(var item in edad)
            {
                cb1.Items.Add(item);
            }
             

            
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            list1.Items.Add(cb2.SelectedItem);       
            list2.Items.Add(cb1.SelectedItem);

        }

        private void btn3_Click(object sender, EventArgs e)
           
        {
            list1.Sorted = true;


        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            list1.Sorted = true;
            
        }
    }
}