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

        private async void GuardarRecarga_Clicked(object sender, EventArgs e)
        {
            SalmeidaRecarga recarga = new SalmeidaRecarga()
            {
                Numero = EditorNumero.Text,
                Nombre = EditorNombre.Text
            };
            bool guardar_Recarga = _recargaRepository.CreateRecarga(recarga);
            if (guardar_Recarga)
            {
                await DisplayAlert("Alerta", "Recarga realizada exitosamente", "OK");
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Alerta", "Recarga no realizada corectamente", "OK");
            }
        }

        
    }

}
