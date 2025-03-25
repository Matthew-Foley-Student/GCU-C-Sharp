/*
 * Matthew Foley
 * CST-150
 * Project 
 * 3/25/25
 * cictation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2.BuisnessLayer
{
    internal class Inventory
    {
        public List<InvItem> ReadInventory(List<InvItem> invItems)
        {
            string dirLoc = Application.StartupPath + "Data\\Inventory.txt";
            using (var str = File.OpenText(dirLoc))
            {
                foreach (string line in File.ReadLines(dirLoc, Encoding.UTF8))
                {
                    string[] rowData = line.Split(",");
                    invItems.Add(new InvItem(rowData[0].ToString().Trim(),
                    Convert.ToDouble(rowData[1]), Convert.ToDouble(rowData[2]), rowData[3].ToString().Trim(), rowData[4].ToString().Trim()));
                }
            }
            return invItems;
        }

        public List<InvItem> IncQtyValue(List<InvItem> invItems, int selectedRowIndex)
        {
            double updatedQty = ++invItems[selectedRowIndex].Quantity;
            return invItems;
        }
        public List<InvItem> DecreQtyValue(List<InvItem> invItems, int selectedRowIndex)
        {
            double updatedQty = --invItems[selectedRowIndex].Quantity;
            return invItems;
        }

        public List<InvItem> SearchItem(List<InvItem> invItems, List<InvItem> invSearch, string searchCriteria)
        {
            //Make sure the search is clear before using
            invSearch.Clear();
            //now iterate over the main data to search and find
            //any matches to the search criteria
            foreach (InvItem item in invItems)
            {
                if (item.Name.ToLower().Contains(searchCriteria.ToLower()))
                {
                    invSearch.Add(item);
                }
                else { }
            }
            return invItems;
        }
    }
}
