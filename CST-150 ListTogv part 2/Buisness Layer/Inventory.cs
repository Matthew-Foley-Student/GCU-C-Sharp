/*
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
using CST_150_ListTogv.Models;

namespace CST_150_ListTogv.Buisness_Layer
{
    internal class Inventory
    {
        //The purpose of this class is to read the text file into a List
        //Then pass the list to FromInventory.cs

        /// <summary>
        /// Read text file and return the inventory class
        /// </summary>
        /// <param name="invItem"></param>
        /// <returns></returns>
        public List<InvItem> ReadInventory(List<InvItem> invItems)
        {

            //Enter the loication of the file to open
            string dirLoc = Application.StartupPath + "Data\\topic6.txt";
            //Open the file with the "using" command
            //The main goal to using the "using" command is to manafe resources and realse all the
            //resources automaticlly when done. (a garbage collector)
         
            using (var str = File.OpenText(dirLoc))
            {
                foreach (string line in File.ReadLines(dirLoc, Encoding.UTF8))
                {   
                   
                    string[] rowData = line.Split(",");
                    //Now we can add the line to our <invItem>
                    //which is our class model
                    invItems.Add(new InvItem(rowData[0].ToString().Trim(),
                      rowData[1].ToString().Trim(), Convert.ToInt32(rowData[2])));

                } 


            }
            return invItems;
        }//End of List command

        public List<InvItem> IncQtyValue(List<InvItem> invItems, int selectedRowIndex)
        {
            //increase the quantity value using the property name from the model
            int updatedQty = ++invItems[selectedRowIndex].Qty;

            //Now put value back to the list so we can keep it in the master list

            //now implent it all
            return invItems;

        }//end of increase command

        public List<InvItem> SearchItem(List<InvItem> invItems, List<InvItem> invSearch, string searchCriteria) {
            //Make sure the search is clear before using
            invSearch.Clear();
            //now iterate over the main data to search and find
            //any matches to the search criteria
            foreach (InvItem item in invItems) {
                if (item.Type.ToLower().Contains(searchCriteria.ToLower()))
                {
                    invSearch.Add(item);
                }
                else { }
            }return invItems;


        }
    }
}
