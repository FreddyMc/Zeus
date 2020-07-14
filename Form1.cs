using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var Tarjetas = new ColeccionDeTarjetas(pnlCentral.Controls);
            Tarjetas.Añadir(new Tarjeta { Titulo = "Ha" });
            Tarjetas.Añadir(new Tarjeta { Titulo = "He" });
            Tarjetas.Añadir(new Tarjeta { Titulo = "Hi" });
            Tarjetas.EliminarPorTitulo("Hiiii");
        }

    }
}
