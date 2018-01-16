using Xamarin.Forms;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnCalcular.Clicked += BtnCalcular_Clicked;
		}

        private void BtnCalcular_Clicked(object sender, System.EventArgs e)
        {
            var total = decimal.Parse(Total.Text);
            var propina = decimal.Parse(Propina.Text);
            var numPersonas = int.Parse(NumPersonas.Text);
            var totalPropina = total * propina / 100;
            lblPropina.Detail = totalPropina.ToString("C");
            var mtoTotal = totalPropina + total;
            lblTotal.Detail = mtoTotal.ToString("C");
            var propinaPorPersona = totalPropina / numPersonas;
            lblPropinaPorPersona.Detail = propinaPorPersona.ToString("C");
            var totalPorPersona = mtoTotal / numPersonas;
            lblTotalPorPersona.Detail = totalPorPersona.ToString("C");
        }
    }
}
