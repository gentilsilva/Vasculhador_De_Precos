﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Models
{
    public class PriceIndicator
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Avaliation { get; set; }


        public string ToString() 
        {
            Console.WriteLine($"•Title: {Title} \n•Price: {Price} \n•Avaliation: {Avaliation} \n\n ");
            return $"•Title: {Title} \n•Price: {Price} \n•Avaliation: {Avaliation} \n ";
        }
    }
}
