using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace TipCalculator
{
    public class TipModel : INotifyPropertyChanged
    {
        private decimal _totalPropina;
        private decimal _mtoTotal;
        private decimal _propinaPorPersona;
        private decimal _totalPorPersona;

        public Command OperacionesCommand { get; set; }
        public TipModel()
        {
            OperacionesCommand = new Command(Operaciones);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void Operaciones()
        {
            TotalPropina = Total * Propina / 100;
            MtoTotal = TotalPropina + Total;
            PropinaPorPersona = TotalPropina / NumPersonas;
            TotalPorPersona = MtoTotal / NumPersonas;
        }
        public decimal Total { get; set; }
        public decimal Propina { get; set; }
        public int NumPersonas { get; set; }
        public decimal TotalPropina { get => _totalPropina; set { _totalPropina = value; OnPropertyChanged(); } }
        public decimal MtoTotal { get => _mtoTotal; set { _mtoTotal = value; OnPropertyChanged(); } }
        public decimal PropinaPorPersona { get => _propinaPorPersona; set { _propinaPorPersona = value; OnPropertyChanged(); } }
        public decimal TotalPorPersona { get => _totalPorPersona; set { _totalPorPersona = value; OnPropertyChanged(); }}
    }
}
