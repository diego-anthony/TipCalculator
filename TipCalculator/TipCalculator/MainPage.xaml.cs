using Xamarin.Forms;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
	{
        private TipModel tipModel;
        public MainPage()
		{
			InitializeComponent();
            tipModel = new TipModel();
            this.BindingContext = tipModel;
            btnCalcular.Clicked += BtnCalcular_Clicked;
		}

        private void BtnCalcular_Clicked(object sender, System.EventArgs e)
        {
            tipModel.TotalPropina = tipModel.Total * tipModel.Propina / 100;
            DisplayAlert("a", tipModel.TotalPropina+"", "s");
            tipModel.MtoTotal = tipModel.TotalPropina + tipModel.Total;
            tipModel.PropinaPorPersona = tipModel.TotalPropina / tipModel.NumPersonas;
            tipModel.TotalPorPersona = tipModel.MtoTotal / tipModel.NumPersonas;
        }
    }
}
