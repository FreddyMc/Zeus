using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Zeus
{
    class ColeccionDeTarjetas : IEnumerable<Tarjeta>
    {
        private Control.ControlCollection Tarjetas;
        public Control this[int i]
        {
            get => Tarjetas[i];
        }
        public ColeccionDeTarjetas(Control.ControlCollection colección)
        {
            Tarjetas = colección;
        }
        public IEnumerator<Tarjeta> GetEnumerator()
        {
            return ((IEnumerable)Tarjetas).Cast<Tarjeta>().GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Añadir(Tarjeta tarjeta)
        {

            if (!this.Any(e=>e.Titulo==tarjeta.Titulo)) 
            { 
                Tarjetas.Add(tarjeta);
            }
            else
            {
                MessageBox.Show("Ya se Añadido est asignatura");
            }
        }
        public void EliminarPorTitulo(string titulo)
        {
            Tarjetas.RemoveByKey(titulo);
        }
    }
}
