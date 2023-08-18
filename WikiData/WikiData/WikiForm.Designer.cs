namespace WikiData
{
    partial class WikiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStructure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataStrName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusStripDataStr = new System.Windows.Forms.StatusStrip();
            this.listViewData = new System.Windows.Forms.ListView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(915, 66);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(156, 35);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "Save";
            this.toolTip1.SetToolTip(this.buttonSave, "Save");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(753, 66);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(156, 35);
            this.buttonLoad.TabIndex = 33;
            this.buttonLoad.Text = "Load";
            this.toolTip1.SetToolTip(this.buttonLoad, "Load");
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(592, 66);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(152, 35);
            this.buttonSearch.TabIndex = 32;
            this.buttonSearch.Text = "Search";
            this.toolTip1.SetToolTip(this.buttonSearch, "Search");
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(147, 66);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(382, 26);
            this.txtSearch.TabIndex = 31;
            this.toolTip1.SetToolTip(this.txtSearch, "Enter a Data Structure Name to search");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Search: ";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(398, 489);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(154, 35);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.buttonDelete, "Delete");
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(234, 489);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(156, 35);
            this.buttonEdit.TabIndex = 28;
            this.buttonEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.buttonEdit, "Edit");
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(72, 489);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(156, 35);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.buttonAdd, "Add");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(250, 355);
            this.txtDefinition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(278, 26);
            this.txtDefinition.TabIndex = 26;
            this.toolTip1.SetToolTip(this.txtDefinition, "Definition");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Definition:";
            // 
            // txtStructure
            // 
            this.txtStructure.Location = new System.Drawing.Point(250, 286);
            this.txtStructure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStructure.Name = "txtStructure";
            this.txtStructure.Size = new System.Drawing.Size(278, 26);
            this.txtStructure.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtStructure, "Structure");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Structure:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(250, 217);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(278, 26);
            this.txtCategory.TabIndex = 22;
            this.toolTip1.SetToolTip(this.txtCategory, "Category");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Category: ";
            // 
            // txtDataStrName
            // 
            this.txtDataStrName.Location = new System.Drawing.Point(250, 148);
            this.txtDataStrName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataStrName.Name = "txtDataStrName";
            this.txtDataStrName.Size = new System.Drawing.Size(278, 26);
            this.txtDataStrName.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txtDataStrName, "Data Structure Name");
            this.txtDataStrName.DoubleClick += new System.EventHandler(this.txtDataStrName_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data Structure Name:";
            // 
            // StatusStripDataStr
            // 
            this.StatusStripDataStr.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStripDataStr.Location = new System.Drawing.Point(0, 563);
            this.StatusStripDataStr.Name = "StatusStripDataStr";
            this.StatusStripDataStr.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.StatusStripDataStr.Size = new System.Drawing.Size(1155, 22);
            this.StatusStripDataStr.TabIndex = 35;
            this.StatusStripDataStr.Text = "statusStrip1";
            // 
            // listViewData
            // 
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(592, 146);
            this.listViewData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(476, 378);
            this.listViewData.TabIndex = 36;
            this.toolTip1.SetToolTip(this.listViewData, "Listview of Data Structure Name and Category");
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // WikiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 585);
            this.Controls.Add(this.listViewData);
            this.Controls.Add(this.StatusStripDataStr);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStructure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataStrName);
            this.Controls.Add(this.label1);
            this.Name = "WikiForm";
            this.Text = "List of Data Structure";
            this.Load += new System.EventHandler(this.WikiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStructure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataStrName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip StatusStripDataStr;
        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

