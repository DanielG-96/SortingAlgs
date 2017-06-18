namespace SortingAlgs
{
    partial class FrmMain
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
            this.TxtConsole = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TxtNumbers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnQuickSort = new System.Windows.Forms.Button();
            this.BtnBubbleSort = new System.Windows.Forms.Button();
            this.BtnInsertSort = new System.Windows.Forms.Button();
            this.BtnSelectSort = new System.Windows.Forms.Button();
            this.ChkAscending = new System.Windows.Forms.CheckBox();
            this.ChkSaveNumbers = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtConsole
            // 
            this.TxtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtConsole.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConsole.Location = new System.Drawing.Point(0, 0);
            this.TxtConsole.Multiline = true;
            this.TxtConsole.Name = "TxtConsole";
            this.TxtConsole.ReadOnly = true;
            this.TxtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtConsole.Size = new System.Drawing.Size(609, 332);
            this.TxtConsole.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ChkSaveNumbers);
            this.splitContainer1.Panel1.Controls.Add(this.ChkAscending);
            this.splitContainer1.Panel1.Controls.Add(this.BtnSelectSort);
            this.splitContainer1.Panel1.Controls.Add(this.BtnInsertSort);
            this.splitContainer1.Panel1.Controls.Add(this.BtnBubbleSort);
            this.splitContainer1.Panel1.Controls.Add(this.BtnQuickSort);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.TxtNumbers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TxtConsole);
            this.splitContainer1.Size = new System.Drawing.Size(609, 469);
            this.splitContainer1.SplitterDistance = 133;
            this.splitContainer1.TabIndex = 1;
            // 
            // TxtNumbers
            // 
            this.TxtNumbers.Location = new System.Drawing.Point(120, 15);
            this.TxtNumbers.Name = "TxtNumbers";
            this.TxtNumbers.Size = new System.Drawing.Size(387, 20);
            this.TxtNumbers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter numbers here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(Maximum of 10)";
            // 
            // BtnQuickSort
            // 
            this.BtnQuickSort.Location = new System.Drawing.Point(141, 54);
            this.BtnQuickSort.Name = "BtnQuickSort";
            this.BtnQuickSort.Size = new System.Drawing.Size(75, 23);
            this.BtnQuickSort.TabIndex = 1;
            this.BtnQuickSort.Text = "&Quick Sort";
            this.BtnQuickSort.UseVisualStyleBackColor = true;
            this.BtnQuickSort.Click += new System.EventHandler(this.BtnQuickSort_Click);
            // 
            // BtnBubbleSort
            // 
            this.BtnBubbleSort.Location = new System.Drawing.Point(222, 54);
            this.BtnBubbleSort.Name = "BtnBubbleSort";
            this.BtnBubbleSort.Size = new System.Drawing.Size(75, 23);
            this.BtnBubbleSort.TabIndex = 2;
            this.BtnBubbleSort.Text = "&Bubble Sort";
            this.BtnBubbleSort.UseVisualStyleBackColor = true;
            this.BtnBubbleSort.Click += new System.EventHandler(this.BtnBubbleSort_Click);
            // 
            // BtnInsertSort
            // 
            this.BtnInsertSort.Location = new System.Drawing.Point(303, 54);
            this.BtnInsertSort.Name = "BtnInsertSort";
            this.BtnInsertSort.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertSort.TabIndex = 3;
            this.BtnInsertSort.Text = "&Insert Sort";
            this.BtnInsertSort.UseVisualStyleBackColor = true;
            this.BtnInsertSort.Click += new System.EventHandler(this.BtnInsertSort_Click);
            // 
            // BtnSelectSort
            // 
            this.BtnSelectSort.Location = new System.Drawing.Point(384, 54);
            this.BtnSelectSort.Name = "BtnSelectSort";
            this.BtnSelectSort.Size = new System.Drawing.Size(90, 23);
            this.BtnSelectSort.TabIndex = 4;
            this.BtnSelectSort.Text = "&Selection Sort";
            this.BtnSelectSort.UseVisualStyleBackColor = true;
            this.BtnSelectSort.Click += new System.EventHandler(this.BtnSelectSort_Click);
            // 
            // ChkAscending
            // 
            this.ChkAscending.AutoSize = true;
            this.ChkAscending.Checked = true;
            this.ChkAscending.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAscending.Location = new System.Drawing.Point(15, 104);
            this.ChkAscending.Name = "ChkAscending";
            this.ChkAscending.Size = new System.Drawing.Size(76, 17);
            this.ChkAscending.TabIndex = 5;
            this.ChkAscending.Text = "&Ascending";
            this.ChkAscending.UseVisualStyleBackColor = true;
            // 
            // ChkSaveNumbers
            // 
            this.ChkSaveNumbers.AutoSize = true;
            this.ChkSaveNumbers.Location = new System.Drawing.Point(120, 104);
            this.ChkSaveNumbers.Name = "ChkSaveNumbers";
            this.ChkSaveNumbers.Size = new System.Drawing.Size(154, 17);
            this.ChkSaveNumbers.TabIndex = 6;
            this.ChkSaveNumbers.Text = "&Remember numbers on exit";
            this.ChkSaveNumbers.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 469);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting Algorithms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtConsole;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumbers;
        private System.Windows.Forms.Button BtnSelectSort;
        private System.Windows.Forms.Button BtnInsertSort;
        private System.Windows.Forms.Button BtnBubbleSort;
        private System.Windows.Forms.Button BtnQuickSort;
        private System.Windows.Forms.CheckBox ChkAscending;
        private System.Windows.Forms.CheckBox ChkSaveNumbers;
    }
}

