
using Elipses.Datos;
using Elipses.Entidades;

namespace Elipses.Windows
{
    public partial class frmElipseAE : Form
    {
        private Elipse? elipse;
        private RepositorioElipses? _repo;
        private object txtPrecioProducto;

        public frmElipseAE(RepositorioElipses repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        internal Elipse GetElipse()
        {
            throw new NotImplementedException();
        }

        private void frmElipseAE_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (elipse is null)
                {


                    elipse = new Elipse();

                    elipse.SemiejeMayor = txtEjeMayor.Text;
                    elipse.SemiejeMenor = txtLadoMenor.Text;
                    elipse.Color = txtColor;
                    elipse.Borde = txtBorde;


                    DialogResult = DialogResult.OK;
                }


            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtEjeMayor.Text))
            {
                valido = false;
                errorProvider1.SetError(txtLadoMenor, "El lado del elipse es requerida");

            }
            if (string.IsNullOrEmpty(txtColor.Text))
            {
                valido = false;
                errorProvider1.SetError(txtBorde, "El borde del elipse es requerido");
            }

            return valido;
        }
    }
}
