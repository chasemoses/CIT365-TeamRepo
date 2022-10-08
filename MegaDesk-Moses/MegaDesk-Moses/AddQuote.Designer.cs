namespace MegaDesk_Moses
{
    partial class AddQuote
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
            this.LabelWidth = new System.Windows.Forms.Label();
            this.LabelDepth = new System.Windows.Forms.Label();
            this.LabelCustomerName = new System.Windows.Forms.Label();
            this.LabelDrawerCount = new System.Windows.Forms.Label();
            this.LabelMaterial = new System.Windows.Forms.Label();
            this.LabelRushDay = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TBWidth = new System.Windows.Forms.TextBox();
            this.TBDepth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBNumDrawers = new System.Windows.Forms.ComboBox();
            this.CBMaterials = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBRushDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelMatCost = new System.Windows.Forms.Label();
            this.ErrLabelWidth = new System.Windows.Forms.Label();
            this.ErrLabelDepth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelWidth
            // 
            this.LabelWidth.AutoSize = true;
            this.LabelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWidth.Location = new System.Drawing.Point(43, 100);
            this.LabelWidth.Name = "LabelWidth";
            this.LabelWidth.Size = new System.Drawing.Size(155, 20);
            this.LabelWidth.TabIndex = 0;
            this.LabelWidth.Text = "Desk Width (inches):";
            // 
            // LabelDepth
            // 
            this.LabelDepth.AutoSize = true;
            this.LabelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDepth.Location = new System.Drawing.Point(43, 165);
            this.LabelDepth.Name = "LabelDepth";
            this.LabelDepth.Size = new System.Drawing.Size(158, 20);
            this.LabelDepth.TabIndex = 1;
            this.LabelDepth.Text = "Desk Depth (inches):";
            // 
            // LabelCustomerName
            // 
            this.LabelCustomerName.AutoSize = true;
            this.LabelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomerName.Location = new System.Drawing.Point(43, 50);
            this.LabelCustomerName.Name = "LabelCustomerName";
            this.LabelCustomerName.Size = new System.Drawing.Size(128, 20);
            this.LabelCustomerName.TabIndex = 2;
            this.LabelCustomerName.Text = "Customer Name:";
            // 
            // LabelDrawerCount
            // 
            this.LabelDrawerCount.AutoSize = true;
            this.LabelDrawerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDrawerCount.Location = new System.Drawing.Point(43, 230);
            this.LabelDrawerCount.Name = "LabelDrawerCount";
            this.LabelDrawerCount.Size = new System.Drawing.Size(150, 20);
            this.LabelDrawerCount.TabIndex = 3;
            this.LabelDrawerCount.Text = "Number of Drawers:";
            // 
            // LabelMaterial
            // 
            this.LabelMaterial.AutoSize = true;
            this.LabelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaterial.Location = new System.Drawing.Point(43, 295);
            this.LabelMaterial.Name = "LabelMaterial";
            this.LabelMaterial.Size = new System.Drawing.Size(110, 20);
            this.LabelMaterial.TabIndex = 4;
            this.LabelMaterial.Text = "Desk Material:";
            // 
            // LabelRushDay
            // 
            this.LabelRushDay.AutoSize = true;
            this.LabelRushDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRushDay.Location = new System.Drawing.Point(43, 345);
            this.LabelRushDay.Name = "LabelRushDay";
            this.LabelRushDay.Size = new System.Drawing.Size(134, 20);
            this.LabelRushDay.TabIndex = 5;
            this.LabelRushDay.Text = "Expedite Options:";
            // 
            // TBName
            // 
            this.TBName.BackColor = System.Drawing.Color.White;
            this.TBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBName.Location = new System.Drawing.Point(221, 47);
            this.TBName.Multiline = true;
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(282, 25);
            this.TBName.TabIndex = 6;
            this.TBName.TextChanged += new System.EventHandler(this.TBName_TextChanged);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(308, 407);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(92, 33);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(417, 407);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(92, 33);
            this.BtnSubmit.TabIndex = 8;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TBWidth
            // 
            this.TBWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBWidth.Location = new System.Drawing.Point(221, 99);
            this.TBWidth.Multiline = true;
            this.TBWidth.Name = "TBWidth";
            this.TBWidth.Size = new System.Drawing.Size(68, 25);
            this.TBWidth.TabIndex = 9;
            this.TBWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBWidth_KeyPress);
            this.TBWidth.Validating += new System.ComponentModel.CancelEventHandler(this.TBWidth_Validating);
            // 
            // TBDepth
            // 
            this.TBDepth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDepth.Location = new System.Drawing.Point(221, 164);
            this.TBDepth.Multiline = true;
            this.TBDepth.Name = "TBDepth";
            this.TBDepth.Size = new System.Drawing.Size(68, 25);
            this.TBDepth.TabIndex = 10;
            this.TBDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDepth_KeyPress);
            this.TBDepth.Validating += new System.ComponentModel.CancelEventHandler(this.TBDepth_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Range: 24in - 96in";
            // 
            // CBNumDrawers
            // 
            this.CBNumDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBNumDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNumDrawers.FormattingEnabled = true;
            this.CBNumDrawers.Location = new System.Drawing.Point(221, 229);
            this.CBNumDrawers.Name = "CBNumDrawers";
            this.CBNumDrawers.Size = new System.Drawing.Size(91, 24);
            this.CBNumDrawers.TabIndex = 13;
            this.CBNumDrawers.SelectedValueChanged += new System.EventHandler(this.CBNumDrawers_SelectedValueChanged);
            // 
            // CBMaterials
            // 
            this.CBMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMaterials.FormattingEnabled = true;
            this.CBMaterials.Location = new System.Drawing.Point(221, 294);
            this.CBMaterials.Name = "CBMaterials";
            this.CBMaterials.Size = new System.Drawing.Size(179, 24);
            this.CBMaterials.TabIndex = 14;
            this.CBMaterials.SelectedValueChanged += new System.EventHandler(this.CBMaterials_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Range: 12in - 48in";
            // 
            // CBRushDay
            // 
            this.CBRushDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRushDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRushDay.FormattingEnabled = true;
            this.CBRushDay.Location = new System.Drawing.Point(221, 344);
            this.CBRushDay.Name = "CBRushDay";
            this.CBRushDay.Size = new System.Drawing.Size(179, 24);
            this.CBRushDay.TabIndex = 17;
            this.CBRushDay.SelectedValueChanged += new System.EventHandler(this.CBRushDay_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "$50 per drawer";
            // 
            // LabelMatCost
            // 
            this.LabelMatCost.AutoSize = true;
            this.LabelMatCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMatCost.Location = new System.Drawing.Point(413, 294);
            this.LabelMatCost.Name = "LabelMatCost";
            this.LabelMatCost.Size = new System.Drawing.Size(0, 20);
            this.LabelMatCost.TabIndex = 19;
            // 
            // ErrLabelWidth
            // 
            this.ErrLabelWidth.AutoSize = true;
            this.ErrLabelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrLabelWidth.ForeColor = System.Drawing.Color.Red;
            this.ErrLabelWidth.Location = new System.Drawing.Point(295, 103);
            this.ErrLabelWidth.Name = "ErrLabelWidth";
            this.ErrLabelWidth.Size = new System.Drawing.Size(208, 17);
            this.ErrLabelWidth.TabIndex = 20;
            this.ErrLabelWidth.Text = "Value must be within range!";
            this.ErrLabelWidth.Visible = false;
            // 
            // ErrLabelDepth
            // 
            this.ErrLabelDepth.AutoSize = true;
            this.ErrLabelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrLabelDepth.ForeColor = System.Drawing.Color.Red;
            this.ErrLabelDepth.Location = new System.Drawing.Point(295, 168);
            this.ErrLabelDepth.Name = "ErrLabelDepth";
            this.ErrLabelDepth.Size = new System.Drawing.Size(208, 17);
            this.ErrLabelDepth.TabIndex = 21;
            this.ErrLabelDepth.Text = "Value must be within range!";
            this.ErrLabelDepth.Visible = false;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(521, 452);
            this.Controls.Add(this.ErrLabelDepth);
            this.Controls.Add(this.ErrLabelWidth);
            this.Controls.Add(this.LabelMatCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBRushDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBMaterials);
            this.Controls.Add(this.CBNumDrawers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBDepth);
            this.Controls.Add(this.TBWidth);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LabelRushDay);
            this.Controls.Add(this.LabelMaterial);
            this.Controls.Add(this.LabelDrawerCount);
            this.Controls.Add(this.LabelCustomerName);
            this.Controls.Add(this.LabelDepth);
            this.Controls.Add(this.LabelWidth);
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelWidth;
        private System.Windows.Forms.Label LabelDepth;
        private System.Windows.Forms.Label LabelCustomerName;
        private System.Windows.Forms.Label LabelDrawerCount;
        private System.Windows.Forms.Label LabelMaterial;
        private System.Windows.Forms.Label LabelRushDay;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.TextBox TBWidth;
        private System.Windows.Forms.TextBox TBDepth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBNumDrawers;
        private System.Windows.Forms.ComboBox CBMaterials;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBRushDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelMatCost;
        private System.Windows.Forms.Label ErrLabelWidth;
        private System.Windows.Forms.Label ErrLabelDepth;
    }
}