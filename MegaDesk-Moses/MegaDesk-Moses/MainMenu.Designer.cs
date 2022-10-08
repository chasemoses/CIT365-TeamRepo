namespace MegaDesk_Moses
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.DeskImagePB = new System.Windows.Forms.PictureBox();
            this.BtnAddQuote = new System.Windows.Forms.Button();
            this.BtnViewQuote = new System.Windows.Forms.Button();
            this.BtnSearchQuotes = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeskImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // DeskImagePB
            // 
            this.DeskImagePB.Image = ((System.Drawing.Image)(resources.GetObject("DeskImagePB.Image")));
            this.DeskImagePB.Location = new System.Drawing.Point(263, 29);
            this.DeskImagePB.Name = "DeskImagePB";
            this.DeskImagePB.Size = new System.Drawing.Size(286, 297);
            this.DeskImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeskImagePB.TabIndex = 0;
            this.DeskImagePB.TabStop = false;
            // 
            // BtnAddQuote
            // 
            this.BtnAddQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.BtnAddQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddQuote.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAddQuote.Location = new System.Drawing.Point(30, 29);
            this.BtnAddQuote.Name = "BtnAddQuote";
            this.BtnAddQuote.Size = new System.Drawing.Size(202, 61);
            this.BtnAddQuote.TabIndex = 1;
            this.BtnAddQuote.Text = "Add New Quote";
            this.BtnAddQuote.UseVisualStyleBackColor = false;
            this.BtnAddQuote.Click += new System.EventHandler(this.BtnAddQuote_Click);
            // 
            // BtnViewQuote
            // 
            this.BtnViewQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.BtnViewQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewQuote.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnViewQuote.Location = new System.Drawing.Point(30, 109);
            this.BtnViewQuote.Name = "BtnViewQuote";
            this.BtnViewQuote.Size = new System.Drawing.Size(202, 61);
            this.BtnViewQuote.TabIndex = 2;
            this.BtnViewQuote.Text = "View Quotes";
            this.BtnViewQuote.UseVisualStyleBackColor = false;
            this.BtnViewQuote.Click += new System.EventHandler(this.BtnViewQuote_Click);
            // 
            // BtnSearchQuotes
            // 
            this.BtnSearchQuotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.BtnSearchQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchQuotes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSearchQuotes.Location = new System.Drawing.Point(30, 186);
            this.BtnSearchQuotes.Name = "BtnSearchQuotes";
            this.BtnSearchQuotes.Size = new System.Drawing.Size(202, 61);
            this.BtnSearchQuotes.TabIndex = 3;
            this.BtnSearchQuotes.Text = "Search Quotes";
            this.BtnSearchQuotes.UseVisualStyleBackColor = false;
            this.BtnSearchQuotes.Click += new System.EventHandler(this.BtnSearchQuotes_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnExit.Location = new System.Drawing.Point(30, 265);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(202, 61);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(581, 353);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSearchQuotes);
            this.Controls.Add(this.BtnViewQuote);
            this.Controls.Add(this.BtnAddQuote);
            this.Controls.Add(this.DeskImagePB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "MegaDesk Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.DeskImagePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DeskImagePB;
        private System.Windows.Forms.Button BtnAddQuote;
        private System.Windows.Forms.Button BtnViewQuote;
        private System.Windows.Forms.Button BtnSearchQuotes;
        private System.Windows.Forms.Button BtnExit;
    }
}

