using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            listViewData.SelectedIndexChanged += listView_SelectedIndexChanged;
        }

        static int max = 3;        // Maximum number of data structures
        static int fields = 4;      // Data Structure Name, Category, Structure and Definition
        int ptr = 0;                // Current length of array with data
        private string[,] dataArray = new string[max, fields];
        private TextBox[] textBoxValues;

       

        private void InitializeListView()
        {
            
            listViewData.View = View.Details;
            
            listViewData.Columns.Add("Data Structure Name");
            listViewData.Columns.Add("Category");
            listViewData.Columns.Add("Structure");
            listViewData.Columns.Add("Definition");
        }

        

        private void Swap(string[,] array, int row1, int row2)
        {
            int numCols = array.GetLength(1);
            for (int col = 0; col < numCols; col++)
            {
                string temp = array[row1, col];
                array[row1, col] = array[row2, col];
                array[row2, col] = temp;
            }
        }

        private void BubbleSortByNameAscending(string[,] array)
        {
            int numRows = array.GetLength(0);

            for (int i = 0; i < numRows - 1; i++)
            {
                for (int j = 0; j < numRows - i - 1; j++)
                {
                    if (!string.IsNullOrEmpty(array[j, 0]) && !string.IsNullOrEmpty(array[j+1, 0]))
                    {
                        if (string.Compare(array[j, 0], array[j + 1, 0]) > 0)
                        {
                            Swap(array, j, j + 1);
                        }
                    }
                    
                }
            }
        }


        private void BinarySearch(string searchName)
        {
            // Deselect previous selected item
            if (listViewData.SelectedItems.Count > 0)
            {
                listViewData.SelectedItems[0].Selected = false;
            }
            StatusStripDataStr.Items.Clear();
            int left = 0;
            int right = max - 1;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (dataArray[mid, 0] == searchName)
                {
                    result = mid;
                    break;
                }
                else if (string.Compare(dataArray[mid, 0], searchName) < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            if (result != -1)
            {
                listViewData.Items[result].Selected = true;
                listViewData.Focus();

                txtDataStrName.Text = dataArray[result, 0];
                txtCategory.Text = dataArray[result, 1];
                txtStructure.Text = dataArray[result, 2];
                txtDefinition.Text = dataArray[result, 3];
               
                StatusStripDataStr.Items.Add("Entry found.");
            }
            else
            {
                StatusStripDataStr.Items.Add("Entry not found!");
                txtSearch.Clear();
                // Deselect previous selected item
                listViewData.SelectedItems[0].Selected = false;
                
            }
        }


        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;
            StatusStripDataStr.Items.Clear();
            Clear_TextBoxes();

            if (!string.IsNullOrEmpty(searchName))
            {
                BinarySearch(searchName);
            }
            else
            {
                StatusStripDataStr.Items.Add("Please enter a search term.");
            }
        }
        // Button method to add a new data structure and sort data
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddData();
            Clear_TextBoxes();
            BubbleSortByNameAscending(dataArray);
            DisplayListViewData();
        }

        private void AddData()
        {
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
                    ++ptr;
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
            
        }

        private void DisplayListViewData()
        {
            listViewData.Items.Clear();
            for (int row = 0; row < dataArray.GetLength(0); row++)
            {
                if (!string.IsNullOrEmpty(dataArray[row, 0]))
                {
                    ListViewItem item = new ListViewItem(dataArray[row, 0]);
                    for (int col = 1; col < dataArray.GetLength(1); col++)
                    {
                        item.SubItems.Add(dataArray[row, col]);
                    }
                    listViewData.Items.Add(item);
                }
                
            }

        }
   
        // Method to clear the input text boxes.
        private void Clear_TextBoxes()
        {
            foreach (TextBox textBox in textBoxValues)
            {
                textBox.Clear();
            }
            
        }
     
 

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
                    --ptr;
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
            StatusStripDataStr.Items.Clear();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary Files|*.dat|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                try
                {
                    using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                    using (BinaryReader binaryReader = new BinaryReader(fileStream))
                    {
                        // Read the number of entries
                        int loadedRowCount = binaryReader.ReadInt32();

                        // Resize the array to match the loaded data
                        ResizeDataArray(loadedRowCount);

                        // Read the data
                        for (int i = 0; i < loadedRowCount; i++)
                        {
                            for (int j = 0; j < fields; j++)
                            {
                                dataArray[i, j] = binaryReader.ReadString();
                            }
                        }

                        // Update ListView and show feedback
                        DisplayListViewData();
                        StatusStripDataStr.Items.Add("Data loaded successfully.");
                    }
                }
                catch (Exception ex)
                {
                    StatusStripDataStr.Items.Add("Error loading data: " + ex.Message);
                }
            }
        }
        private void ResizeDataArray(int newSize)
        {
            string[,] newDataArray = new string[newSize, fields];
            for (int i = 0; i < ptr; i++)
            {
                for (int j = 0; j < fields; j++)
                {
                    newDataArray[i, j] = dataArray[i, j];
                }
            }
            dataArray = newDataArray;
            ptr = newSize;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            BubbleSortByNameAscending(dataArray);
            StatusStripDataStr.Items.Clear();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary Files|*.dat|All Files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
                    using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                    {
                        // Write the number of entries
                        binaryWriter.Write(ptr);

                        // Write the data
                        for (int i = 0; i < ptr; i++)
                        {
                            for (int j =0; j < fields; j++)
                            {
                                binaryWriter.Write(dataArray[i, j]);
                            }
                        }
                        StatusStripDataStr.Items.Add("Data saved successfully.");
                    }
                }
                catch (Exception ex)
                {
                    StatusStripDataStr.Items.Add("Error saving data: " + ex.Message);
                }
            }
        }
         
        private void WikiForm_Load(object sender, EventArgs e)
        {
            textBoxValues = new TextBox[] { txtDataStrName, txtCategory, txtStructure, txtDefinition };
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusStripDataStr.Items.Clear();
            if (listViewData.SelectedItems.Count > 0)
            {
                int selectedIndex = listViewData.SelectedIndices[0];
                txtDataStrName.Text = dataArray[selectedIndex, 0];
                txtCategory.Text = dataArray[selectedIndex, 1];
                txtStructure.Text = dataArray[selectedIndex, 2];
                txtDefinition.Text = dataArray[selectedIndex, 3];
              //  StatusStripDataStr.Items.Add("The selected Name is displyed.");
            }
        }
    }
}
