﻿/*
 * Matthew Foley
 * CST-150
 * Activity 6 File Editing
 * 3/17/25
 * cictation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_ListTogv.Models
{        
        /// <summary>
        /// Model Class that will structure
        /// all inventory items
        /// </summary>
    public class InvItem
    {

            public string Type { get; set; }
            public string Color { get; set; }
            public int Qty { get; set; }

        /// <summary>
        /// Model Class constructors
        /// </summary>
        /// <param name="type"></param>
        /// <param name="color"></param>
        /// <param name="qty"></param>
        public InvItem(string type, string color, int qty)
        {
            Type = type;
            Color = color;
            Qty = qty;
        }
    }


}
