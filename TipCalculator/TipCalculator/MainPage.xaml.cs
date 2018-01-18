using Xamarin.Forms;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
	{
        private TipModel tipModel;
        public MainPage()
		{
			InitializeComponent();
            tipModel = new TipModel
            {
                Total = 100,
                Propina = 5,
                NumPersonas = 2
            };
            this.BindingContext = tipModel;
		}
    }
}
