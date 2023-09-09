using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        List<int> caja = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_1_Click(object sender, EventArgs e)
        {
            if( !string.IsNullOrEmpty(TX_1.Text) && !string.IsNullOrEmpty(TX_2.Text) )
            {
                if( Int32.TryParse(TX_1.Text , out int n ) && Int32.TryParse(TX_2.Text, out int desde))
                {

                    int resultado = numeros_desde(n , desde);

                    LT_1.Items.Add( resultado);





                    /*numeros_desde(n, desde);
                    int resultado = 0;
                    foreach( int num_desde in caja)
                    {
                        resultado += num_desde;
                    }
                    LT_1.Items.Add(resultado);*/
                }
                else
                {
                    MessageBox.Show(" Ingrese solo numeros validos");
                }
            }
            else
            {
                MessageBox.Show(" No ingresamos vacios");
            }
        }
        private int numeros_desde( int n , int desde)
        {
            if ( n > 0)
            {        // 10   +    11
                return  desde + numeros_desde(n-1 , desde+1 );
            }
            return 0;
        }

        /*private int numeros_desde( int n , int desde)
        {
            if ( n > 0)
            {
                caja.Add(desde);
                return desde + numeros_desde(n-1 , desde +1);
            }
            return 0;
        }*/
    }
}
