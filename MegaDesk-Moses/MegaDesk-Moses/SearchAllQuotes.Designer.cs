namespace MegaDesk_Moses
{
    partial class SearchAllQuotes
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.button1 = new System.Windows.Forms.Button();
            this.LVSearch = new System.Windows.Forms.ListView();
            this.ColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeskWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeskDepth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumDrawers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeskMaterial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RushDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.CBMaterialSearch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(717, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LVSearch
            // 
            this.LVSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.Date,
            this.DeskWidth,
            this.DeskDepth,
            this.NumDrawers,
            this.DeskMaterial,
            this.RushDay,
            this.TotalPrice});
            this.LVSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVSearch.FullRowSelect = true;
            this.LVSearch.HideSelection = false;
            this.LVSearch.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.LVSearch.Location = new System.Drawing.Point(22, 103);
            this.LVSearch.MultiSelect = false;
            this.LVSearch.Name = "LVSearch";
            this.LVSearch.Size = new System.Drawing.Size(757, 376);
            this.LVSearch.TabIndex = 2;
            this.LVSearch.UseCompatibleStateImageBehavior = false;
            this.LVSearch.View = System.Windows.Forms.View.Details;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 123;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 81;
            // 
            // DeskWidth
            // 
            this.DeskWidth.Text = "Desk Width";
            this.DeskWidth.Width = 83;
            // 
            // DeskDepth
            // 
            this.DeskDepth.Text = "Desk Depth";
            this.DeskDepth.Width = 83;
            // 
            // NumDrawers
            // 
            this.NumDrawers.Text = "# Drawers";
            this.NumDrawers.Width = 85;
            // 
            // DeskMaterial
            // 
            this.DeskMaterial.Text = "Material";
            this.DeskMaterial.Width = 83;
            // 
            // RushDay
            // 
            this.RushDay.Text = "Shipping Type";
            this.RushDay.Width = 103;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "Total Price";
            this.TotalPrice.Width = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Material Type:";
            // 
            // CBMaterialSearch
            // 
            this.CBMaterialSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMaterialSearch.FormattingEnabled = true;
            this.CBMaterialSearch.Location = new System.Drawing.Point(408, 43);
            this.CBMaterialSearch.Name = "CBMaterialSearch";
            this.CBMaterialSearch.Size = new System.Drawing.Size(121, 21);
            this.CBMaterialSearch.TabIndex = 5;
            this.CBMaterialSearch.SelectedValueChanged += new System.EventHandler(this.CBMaterialSearch_SelectedValueChanged);
            // 
            // SearchAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.CBMaterialSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LVSearch);
            this.Name = "SearchAllQuotes";
            this.Text = "SearchAllQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader ColumnName;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader DeskWidth;
        private System.Windows.Forms.ColumnHeader DeskDepth;
        private System.Windows.Forms.ColumnHeader NumDrawers;
        private System.Windows.Forms.ColumnHeader DeskMaterial;
        private System.Windows.Forms.ColumnHeader RushDay;
        private System.Windows.Forms.ColumnHeader TotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBMaterialSearch;
        private System.Windows.Forms.ListView LVSearch;
    }
}