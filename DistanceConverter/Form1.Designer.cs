namespace DistanceConverter
{
    partial class Form1
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
            this.Lbl_Distance = new System.Windows.Forms.Label();
            this.txt_Enterdistance = new System.Windows.Forms.TextBox();
            this.lst_From = new System.Windows.Forms.ListBox();
            this.Lst_To = new System.Windows.Forms.ListBox();
            this.Lbl_converted = new System.Windows.Forms.Label();
            this.txt_condistance = new System.Windows.Forms.TextBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.group_From = new System.Windows.Forms.GroupBox();
            this.group_to = new System.Windows.Forms.GroupBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.group_From.SuspendLayout();
            this.group_to.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Distance
            // 
            this.Lbl_Distance.AutoSize = true;
            this.Lbl_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Distance.Location = new System.Drawing.Point(92, 41);
            this.Lbl_Distance.Name = "Lbl_Distance";
            this.Lbl_Distance.Size = new System.Drawing.Size(109, 18);
            this.Lbl_Distance.TabIndex = 0;
            this.Lbl_Distance.Text = "Enter Distance:";
            // 
            // txt_Enterdistance
            // 
            this.txt_Enterdistance.Location = new System.Drawing.Point(227, 37);
            this.txt_Enterdistance.Multiline = true;
            this.txt_Enterdistance.Name = "txt_Enterdistance";
            this.txt_Enterdistance.Size = new System.Drawing.Size(218, 27);
            this.txt_Enterdistance.TabIndex = 1;
            // 
            // lst_From
            // 
            this.lst_From.FormattingEnabled = true;
            this.lst_From.ItemHeight = 18;
            this.lst_From.Items.AddRange(new object[] {
            "Inches",
            "Feet ",
            "Yards"});
            this.lst_From.Location = new System.Drawing.Point(33, 41);
            this.lst_From.Name = "lst_From";
            this.lst_From.Size = new System.Drawing.Size(120, 94);
            this.lst_From.TabIndex = 4;
            // 
            // Lst_To
            // 
            this.Lst_To.FormattingEnabled = true;
            this.Lst_To.ItemHeight = 18;
            this.Lst_To.Items.AddRange(new object[] {
            "Inches",
            "Feet ",
            "Yards"});
            this.Lst_To.Location = new System.Drawing.Point(31, 41);
            this.Lst_To.Name = "Lst_To";
            this.Lst_To.Size = new System.Drawing.Size(120, 94);
            this.Lst_To.TabIndex = 5;
            // 
            // Lbl_converted
            // 
            this.Lbl_converted.AutoSize = true;
            this.Lbl_converted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_converted.Location = new System.Drawing.Point(68, 270);
            this.Lbl_converted.Name = "Lbl_converted";
            this.Lbl_converted.Size = new System.Drawing.Size(142, 18);
            this.Lbl_converted.TabIndex = 6;
            this.Lbl_converted.Text = "Converted Distance:";
            // 
            // txt_condistance
            // 
            this.txt_condistance.Location = new System.Drawing.Point(216, 266);
            this.txt_condistance.Multiline = true;
            this.txt_condistance.Name = "txt_condistance";
            this.txt_condistance.Size = new System.Drawing.Size(218, 32);
            this.txt_condistance.TabIndex = 7;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(116, 331);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(117, 30);
            this.btn_Convert.TabIndex = 8;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // group_From
            // 
            this.group_From.Controls.Add(this.lst_From);
            this.group_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_From.Location = new System.Drawing.Point(38, 88);
            this.group_From.Name = "group_From";
            this.group_From.Size = new System.Drawing.Size(206, 157);
            this.group_From.TabIndex = 9;
            this.group_From.TabStop = false;
            this.group_From.Text = "From";
            // 
            // group_to
            // 
            this.group_to.Controls.Add(this.Lst_To);
            this.group_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_to.Location = new System.Drawing.Point(251, 88);
            this.group_to.Name = "group_to";
            this.group_to.Size = new System.Drawing.Size(200, 157);
            this.group_to.TabIndex = 10;
            this.group_to.TabStop = false;
            this.group_to.Text = "To:";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(251, 331);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(117, 30);
            this.Btn_Exit.TabIndex = 11;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 420);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.group_to);
            this.Controls.Add(this.group_From);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.txt_condistance);
            this.Controls.Add(this.Lbl_converted);
            this.Controls.Add(this.txt_Enterdistance);
            this.Controls.Add(this.Lbl_Distance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.group_From.ResumeLayout(false);
            this.group_to.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Distance;
        private System.Windows.Forms.TextBox txt_Enterdistance;
        private System.Windows.Forms.ListBox lst_From;
        private System.Windows.Forms.ListBox Lst_To;
        private System.Windows.Forms.Label Lbl_converted;
        private System.Windows.Forms.TextBox txt_condistance;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.GroupBox group_From;
        private System.Windows.Forms.GroupBox group_to;
        private System.Windows.Forms.Button Btn_Exit;
    }
}

