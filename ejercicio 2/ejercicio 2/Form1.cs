using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Decimal Nota1 = Convert.ToDecimal(txtnota1);
            Decimal Nota2 = Convert.ToDecimal(txtnota2);
            Decimal Nota3 = Convert.ToDecimal(txtnota3);
            Decimal Nota4 = Convert.ToDecimal(txtnota4);

            Decimal Promedio = await SumarAsync(Nota1,Nota2, Nota3, Nota4);

            MessageBox.Show("El promedio Final es:{Promedio}");
        }


        private async Task<decimal> SumarAsync(decimal not1, decimal not2,decimal not3, decimal not4);

        {
            decimal suma = await Task.Run(() =>
            {
                return not1 + not2 +not3 + not4;
            });
             Return suma;
        }  
    }
}


