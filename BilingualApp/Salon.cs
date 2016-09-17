using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilingualApp
{
    public partial class Salon : Form
        /*
        aqui el maestro indicara el numero de estudiantes 
        que tiene en esta clase y asi se generara los botones 
        para cada alumno con un numero que indique su posicion en la lista
        */
    {
        public Salon()
        {
            InitializeComponent();
        }

        private void numalu_TextChanged(object sender, EventArgs e)
        {
            String alu;
            alu = numalu.Text;
            /*maestro indica numero de alumnos
            alu contiene ese numero
             hay que ver como s elo pasamos a el creador de bottones
             esta abajo...
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
