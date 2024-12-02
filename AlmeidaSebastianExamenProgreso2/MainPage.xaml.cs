using AlmeidaSebastianExamenProgreso2.Interfaces;
using AlmeidaSebastianExamenProgreso2.Models;
using AlmeidaSebastianExamenProgreso2.Repositories;

namespace AlmeidaSebastianExamenProgreso2
{
    public partial class MainPage : ContentPage
    {
        ISalmeidaRecarga _recargaRepository;
        SalmeidaRecarga recarga = new SalmeidaRecarga();
        public MainPage()
        {
            InitializeComponent();
            _recargaRepository = new Salmeida_RepositoryRecarga();
            recarga = _recargaRepository.GetRecarga("1");
            BindingContext = recarga;
        }

        private void GuardarRecarga_Clicked(object sender, EventArgs e)
        {
            SalmeidaRecarga recarga = new SalmeidaRecarga()
            {
                Numero = EditorNumero.Text,
                Nombre = EditorNombre.Text
            };
        }
    }

}
