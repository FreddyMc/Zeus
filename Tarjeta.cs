
using System.Drawing;
using System.Windows.Forms;

namespace Zeus
{
    class Tarjeta : Panel
    {
        private Label lblTitulo { get; set; }
        private PictureBox ImgFondo;
        public string Titulo
        {
            get => lblTitulo.Text;
            set { lblTitulo.Text = lblTitulo != null ? value : "Titulo";
                this.Name = Titulo; 
            }
        }
        public string ImagePath { get => ImgFondo.ImageLocation;
             set =>ImgFondo.Image = ImgFondo != null ? Image.FromFile(value) : null; }

        public Tarjeta()
        {
            this.Size = new Size(100, 100);
            lblTitulo = new Label
            {
                Text = "Titulo",
                Size = new Size(20, 50),
                Dock = DockStyle.Top,
            };
            ImgFondo = new PictureBox
            {
                Dock = DockStyle.Fill,
            };
            this.Controls.Add(ImgFondo);
            this.Controls.Add(lblTitulo);
        }
        public void SetImagePath()
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                FileName = "Select a img file",
                Filter = "Img files (*.jpeg)|*.png",
                Title = "Open img file"
            };
            ImagePath = dialog.FileName;
        }

    }
}

