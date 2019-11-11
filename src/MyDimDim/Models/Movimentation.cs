using System;
using MyDimDim.Enums;

namespace MyDimDim.Models
{
    public class Movimentation
    {
        public EMovimentationType Type { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public string Name { get; set; }
    }
}
