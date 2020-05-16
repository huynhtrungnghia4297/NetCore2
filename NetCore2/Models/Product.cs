using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore2.Models
{
    public class Product
    {

        public override string ToString()
        {
            return $"{Code}-{ProductName}-{Invoid.ToString("#,###0")}-{Discount}";

        }
        public int Code { get; set; }
        public string ProductName { get; set; }
        public double Invoid { get; set; }
        public double Discount { get; set; }
        public double Price => Invoid * (1 - Discount); }
        //{
        //    get { return Invoid * (1 - Discount); }  
        //}

    }

