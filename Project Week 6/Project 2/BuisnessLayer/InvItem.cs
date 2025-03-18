/*
 * Matthew Foley
 * CST-150
 * Final Project
 * 3/10/25
 * Citation Here
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_2.BuisnessLayer
{
    internal class InvItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public string Season { get; set; }
        public string Consumable { get; set; }

        public InvItem(string name, double price, double quantity, string season, string consumable)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Season = season;
            Consumable = consumable;
        }

        }

    }

