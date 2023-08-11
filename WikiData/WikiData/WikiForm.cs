using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiData
{
    public partial class WikiForm : Form
    {
        public WikiForm()
        {
            InitializeComponent();
            InitializeListView();
        }

        static int max = 3;        // Maximum number of data structures
        static int fields = 4;      // Data Structure Name, Category, Structure and Definition
        int ptr = 0;                // Current length of array with data
        private string[,] dataArray = new string[max, fields];
        private string[,] tempDataArray = new string[max, fields];
        private TextBox[] textBoxValues;

       

        private void InitializeListView()
        {
              listViewData.View = View.Details;
            /*   for (int col = 0; col < fields; col++)
               {
                   listViewData.Columns.Add($"Column {col + 1}", "~");
               }
             */
            listViewData.Columns.Add("Data Structure Name");
            listViewData.Columns.Add("Category");
            listViewData.Columns.Add("Structure");
            listViewData.Columns.Add("Definition");
        }

     /*   private void UpdateListView()
        {
            //listViewData.Items.Clear();

            for (int i = 0; i < listViewData.Items.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                listViewData.Items.Add(item);
                for (int j = 0; j < fields; j++)
                {
                    
                   
                        item.SubItems.Add(dataArray[i, j]);
                   
                }
                
            }
         */

            
        
        private void ButtonSearch_Click(object sender, EventArgs e)
        {

        }
        // Button method to add a new data structure and sort data
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //AddData();
            //Clear_TextBoxes();
            //Bubble_Sort();
            //DisplayListDataStr();
           
            if (textBoxValues[0].Text != "" && textBoxValues[1].Text != "" 
                && textBoxValues[2].Text != "" && textBoxValues[3].Text != "")
            {
                if (listViewData.Items.Count < max)
                {
                    string[] row = new string[fields];
                    for (int col = 0; col < fields; col++)
                    {
                        row[col] = textBoxValues[col].Text;
                    }

                    int rowIndex = listViewData.Items.Count;
                    ListViewItem listViewItem = new ListViewItem(row);
                    listViewData.Items.Add(listViewItem);

                    for (int col = 0; col < fields; col++)
                    {
                        dataArray[rowIndex, col] = row[col];
                    }
                    StatusStripDataStr.Items.Clear();
                    StatusStripDataStr.Items.Add("The entered data is added to the array.");
                    
                }
                else
                {
                    StatusStripDataStr.Items.Clear();
                    StatusStripDataStr.Items.Add("Maximum number of rows reached.");
                }
            }
            else
            {
                StatusStripDataStr.Items.Clear();
                StatusStripDataStr.Items.Add("Please fill all text boxes.");
            }
            Clear_TextBoxes();
        }

        // This method add a new item to the 2 dimontional array.
     /*   private void AddData()
        {
            StatusStripDataStr.Items.Clear();
            if (ptr < max)
            {
                try
                {
                    dataArray[ptr, 0] = txtDataStrName.Text;
                    dataArray[ptr, 1] = txtCategory.Text;
                    dataArray[ptr, 2] = txtStructure.Text;
                    dataArray[ptr, 3] = txtDefinition.Text;
                    ptr++;
                }
                catch
                {
                    toolStripStatusLabel1.Text = "Well that didn't work!";
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "The array is full!";
            }
        }
     */
        // Method to clear the input text boxes.
        private void Clear_TextBoxes()
        {
            foreach (TextBox textBox in textBoxValues)
            {
                textBox.Clear();
            }
            
        }
        // Method to sort and display the array in the listbox
    /*    private static void ‌Bubble_Sort()
        {
            for (int x = 1; x < max; x++)
            {
                for (int i = 0; i < max - 1; i++)
                {
                    if (!(string.IsNullOrEmpty(dataArray[i + 1, 0])))
                    {
                        if (string.Compare(dataArray[i, 0], dataArray[i + 1, 0]) == 1)
                        {
                            Swap(i);
                        }
                    }

                }
            }

        }
        // Swap Routine
        private void Swap(int index)
        {
            string temp;
            for (int i = 0; i < fields; i++)
            {
                temp = dataArray[index, i];
                dataArray[index, i] = dataArray[index + 1, i];
                dataArray[index + 1, i] = temp;
            }
        }
    */
        // Display Data Structure Array
   /*     private void DisplayListDataStr()
        {
           // StatusStripDataStr.Items.Clear();
            string rec = "";
            if (ptr > 0)
            {
                listViewData.Items.Clear();
                for (int x = 0; x < ptr; x++)
                {
                    rec = dataArray[x, 0] + "\t" + dataArray[x, 1] + "\t" + dataArray[x, 2] + "\t" + dataArray[x, 3];
                    listViewData.Items.Add(rec);
                }
            }
            else
            {
                StatusStripDataStr.Items.Add("Nothing to display");
            }
                
        }
   */

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewData.SelectedItems.Count > 0)
            {
                int selectedRowIndex = listViewData.SelectedIndices[0];
                for (int j =0; j < fields; j++)
                {
                   // if (int.TryParse(textBoxValues[j].Text, out int value))
                   if (textBoxValues[j].Text != "")
                    {
                        if (selectedRowIndex >=0 && selectedRowIndex < max)
                        {
                            int selectedColIndex = j;
                            string newValue = textBoxValues[j].Text;
                            dataArray[selectedRowIndex, selectedColIndex] = newValue;
                            listViewData.Items[selectedRowIndex].SubItems[selectedColIndex].Text = newValue;
                        }
                    }
                }
                StatusStripDataStr.Items.Add("The selected row is edited!");
                Clear_TextBoxes();
            }
            else
            {
                StatusStripDataStr.Items.Add("Please select a row to edit!");
            }
                       
        }
        

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
           // DisplayListDataStr();
        }

        private void DeleteData()
        {
            /*StatusStripDataStr.Items.Clear();
            try
            {

                string selectedItem = listViewData.SelectedItems.ToString();
                string ss;
               

                //bool found = false;
                for (int i = 0; i <= ptr; i++)
                {
                    ss = dataArray[i, 0] + "\t" + dataArray[i, 1] + "\t" + dataArray[i, 2] + "\t" + dataArray[i, 3];
                    if (selectedItem == ss)
                    {
                        DialogResult dr = MessageBox.Show("Are you sure to delete row?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {

                            // Delete row from array
                          
                            Array.Clear(dataArray, i, 4);
                            StatusStripDataStr.Items.Add("Delete the selected item!");
                            break;
                        }
                        else 
                        {
                            // Nothing to do
                            break;
                        }
                        
                    }
                    else
                    {
                        StatusStripDataStr.Items.Add("No match found!");
                    }

                }
            }
            catch
            {
                StatusStripDataStr.Items.Add("Select an item in the listbox!");
            }*/


            if (listViewData.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this entry?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedIndex = listViewData.SelectedItems[0].Index;
                    for (int j = 0; j < fields; j++)
                    {
                        dataArray[selectedIndex, j] = "~";
                    }
                    UpdateDataArray(selectedIndex);
                    listViewData.Items.RemoveAt(selectedIndex);

                  /*  for (int i = 0; i < listViewData.Items.Count; i++)
                    {
                        for (int j = 0; j < fields; j++)
                        {
                            dataArray[i, j] = listViewData.Items[i].SubItems[j].Text;
                        }
                    } */
                    // UpdateDataArray();
                    // UpdateListView();
                }
            }
            else
            {
                StatusStripDataStr.Items.Add("Please select an entry to delete.");
            }

        }
        private void UpdateDataArray(int selectedRowIndex)
        {
            int numRows = dataArray.GetLength(0);
            int numCols = dataArray.GetLength(1);
            // Create a new array with one less row
            string[,] newArray = new string[numRows - 1, numCols];

            int newArrayRow = 0;
            // Copy data from the original array to the new array, excluding the selected row
            for (int row = 0; row < numRows; row++)
            {
                if (row != selectedRowIndex)
                {
                    for (int col = 0; col < numCols; col++)
                    {
                        newArray[newArrayRow, col] = dataArray[row, col];
                    }
                    newArrayRow++;
                }
            }
            //Copy the data back to the original array
            
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                   
                    dataArray[i, j] = newArray[i, j];
                    

                }
            }

           

        }


        private void ButtonLoad_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }
         
        private void WikiForm_Load(object sender, EventArgs e)
        {
            textBoxValues = new TextBox[] { txtDataStrName, txtCategory, txtStructure, txtDefinition };
        }
    }
}
