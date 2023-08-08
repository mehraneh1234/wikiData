using System;
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
        }

        static int max = 12;        // Maximum number of data structures
        static int fields = 4;      // Data Structure Name, Category, Structure and Definition
        int ptr = 0;                // Current length of array with data
        private string[,] dataStructuresArray = new string[max, fields];

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

        }
        // Button method to add a new data structure and sort data
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddData();
            Clear_TextBoxes();
            //Bubble_Sort();
            DisplayListDataStr();
        }

        // This method add a new item to the 2 dimontional array.
        private void AddData()
        {
            StatusStripDataStr.Items.Clear();
            if (ptr < max)
            {
                try
                {
                    dataStructuresArray[ptr, 0] = txtDataStrName.Text;
                    dataStructuresArray[ptr, 1] = txtCategory.Text;
                    dataStructuresArray[ptr, 2] = txtStructure.Text;
                    dataStructuresArray[ptr, 3] = txtDefinition.Text;
                    ptr++;
                }
                catch
                {
                    StatusStripDataStr.Text = "Well that didn't work!";
                }
            }
            else
            {
                StatusStripDataStr.Text = "The array is full!";
            }
        }
        // Method to clear the input text boxes.
        private void Clear_TextBoxes()
        {
            txtDataStrName.Clear();
            txtCategory.Clear();
            txtDefinition.Clear();
            txtStructure.Clear();
        }
        // Method to sort and display the array in the listbox
    /*    private static void ‌Bubble_Sort()
        {
            for (int x = 1; x < max; x++)
            {
                for (int i = 0; i < max - 1; i++)
                {
                    if (!(string.IsNullOrEmpty(dataStructuresArray[i + 1, 0])))
                    {
                        if (string.Compare(dataStructuresArray[i, 0], dataStructuresArray[i + 1, 0]) == 1)
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
                temp = dataStructuresArray[index, i];
                dataStructuresArray[index, i] = dataStructuresArray[index + 1, i];
                dataStructuresArray[index + 1, i] = temp;
            }
        }
    */
        // Display Data Structure Array
        private void DisplayListDataStr()
        {
           // StatusStripDataStr.Items.Clear();
            string rec = "";
            if (ptr > 0)
            {
                lstDataStructure.Items.Clear();
                for (int x = 0; x < ptr; x++)
                {
                    rec = dataStructuresArray[x, 0] + "\t" + dataStructuresArray[x, 1] + "\t" + dataStructuresArray[x, 2] + "\t" + dataStructuresArray[x, 3];
                    lstDataStructure.Items.Add(rec);
                }
            }
            else
            {
                StatusStripDataStr.Text = "Nothing to display";
            }
                
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            EditData();
            Clear_TextBoxes();
            DisplayListDataStr();
                       
        }
        private void EditData()
        {
            StatusStripDataStr.Items.Clear();
            try
            {
                
                string selectedItem = lstDataStructure.SelectedItem.ToString();
                string ss;
                //bool found = false;
                for (int i = 0; i <= ptr; i++)
                {
                   
                    ss = dataStructuresArray[i, 0] + "\t" + dataStructuresArray[i, 1] + "\t" + dataStructuresArray[i, 2] + "\t" + dataStructuresArray[i, 3];
                    

                    if (selectedItem == ss && txtDataStrName.Text != "" && txtCategory.Text != "" && txtStructure.Text != "" && txtDefinition.Text != "")
                    {
                        dataStructuresArray[i, 0] = txtDataStrName.Text;
                        dataStructuresArray[i, 1] = txtCategory.Text;
                        dataStructuresArray[i, 2] = txtStructure.Text;
                        dataStructuresArray[i, 3] = txtDefinition.Text;
                        StatusStripDataStr.Text = "Data Structure Name, Category, Structure and Definition are edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtDataStrName.Text != "" && txtCategory.Text != "" && txtStructure.Text != "")
                    {
                        dataStructuresArray[i, 0] = txtDataStrName.Text;
                        dataStructuresArray[i, 1] = txtCategory.Text;
                        dataStructuresArray[i, 2] = txtStructure.Text;
                        StatusStripDataStr.Text = "Data Structure Name, Category and Structure are edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtDataStrName.Text != "" && txtCategory.Text != "" && txtDefinition.Text != "")
                    {
                        dataStructuresArray[i, 0] = txtDataStrName.Text;
                        dataStructuresArray[i, 1] = txtCategory.Text;
                        dataStructuresArray[i, 3] = txtDefinition.Text;
                        StatusStripDataStr.Text = "Data Structure Name, Category and Definition are edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtDataStrName.Text != "" && txtStructure.Text != "" && txtDefinition.Text != "")
                    {
                        dataStructuresArray[i, 0] = txtDataStrName.Text;
                        dataStructuresArray[i, 3] = txtDefinition.Text;
                        dataStructuresArray[i, 2] = txtStructure.Text;
                        StatusStripDataStr.Text = "Data Structure Name, Definition and Structure are edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtDefinition.Text != "" && txtCategory.Text != "" && txtStructure.Text != "")
                    {
                        dataStructuresArray[i, 3] = txtDefinition.Text;
                        dataStructuresArray[i, 1] = txtCategory.Text;
                        dataStructuresArray[i, 2] = txtStructure.Text;
                        StatusStripDataStr.Text = "Definition, Category and Structure are edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtDataStrName.Text != "" && txtCategory.Text != "")
                    {
                        dataStructuresArray[i, 0] = txtDataStrName.Text;
                        dataStructuresArray[i, 1] = txtCategory.Text;
                        StatusStripDataStr.Text = "Data Structure Name and Category are edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtStructure.Text != "" && txtCategory.Text != "")
                    {
                        dataStructuresArray[i, 2] = txtStructure.Text;
                        dataStructuresArray[i, 1] = txtCategory.Text;
                        StatusStripDataStr.Text = "Structure and Category are edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtDefinition.Text != "" && txtCategory.Text != "")
                    {
                        dataStructuresArray[i, 3] = txtDefinition.Text;
                        dataStructuresArray[i, 1] = txtCategory.Text;
                        StatusStripDataStr.Text = "Definition and Category are edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtDataStrName.Text != "" && txtStructure.Text != "")
                    {
                        dataStructuresArray[i, 0] = txtDataStrName.Text;
                        dataStructuresArray[i, 2] = txtStructure.Text;
                        StatusStripDataStr.Text = "Data Structure Name and Structure are edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtDataStrName.Text != "" && txtDefinition.Text != "")
                    {
                        dataStructuresArray[i, 0] = txtDataStrName.Text;
                        dataStructuresArray[i, 3] = txtDefinition.Text;
                        StatusStripDataStr.Text = "Data Structure Name and Definition are edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtStructure.Text != "" && txtDefinition.Text != "")
                    {
                        dataStructuresArray[i, 2] = txtStructure.Text;
                        dataStructuresArray[i, 3] = txtDefinition.Text;
                        StatusStripDataStr.Text = "Structure and Definition are edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtDataStrName.Text != "")
                    {
                        dataStructuresArray[i, 0] = txtDataStrName.Text;
                        StatusStripDataStr.Text = "Data Structure Name is edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtCategory.Text != "")
                    {
                        dataStructuresArray[i, 1] = txtCategory.Text;
                        StatusStripDataStr.Text = "Category is edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtStructure.Text != "")
                    {
                        dataStructuresArray[i, 2] = txtStructure.Text;
                        StatusStripDataStr.Text = "Structure is edited!";
                        break;
                    }
                    else if (selectedItem == ss && txtDefinition.Text != "")
                    {
                        dataStructuresArray[i, 3] = txtDefinition.Text;
                        StatusStripDataStr.Text = "Definition is edited!";
                        break;
                    }
                    else
                    {
                        StatusStripDataStr.Text = "No match found!";
                    }

                }
            }
            catch
            {
                StatusStripDataStr.Text = "Well that didn't work!";
            }
            
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
