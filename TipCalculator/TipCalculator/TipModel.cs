using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator
{
    public class TipModel
    {
        public decimal Total { get; set; }
        public decimal Propina { get; set; }
        public int NumPersonas { get; set; }
        public decimal TotalPropina { get; set; }
        public decimal MtoTotal { get; set; }
        public decimal PropinaPorPersona { get; set; }
        public decimal TotalPorPersona { get; set; }
    }
}
