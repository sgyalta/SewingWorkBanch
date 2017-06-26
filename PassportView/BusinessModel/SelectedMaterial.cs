﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportView.BusinessModel
{
    public class SelectedMaterial
    {
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Quantity { get; set; }
        public decimal CoastPrice { get; set; }

        public double CalcTotalСost()
        {
            return (double)CoastPrice * Quantity;
        }

        public override string ToString()
        {
            return $"{Name,-10} {Quantity} шт   {CalcTotalСost()} uah";
        }

    }
}
