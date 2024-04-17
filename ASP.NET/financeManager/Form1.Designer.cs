namespace financeManager
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
            this.inputType = new System.Windows.Forms.ComboBox();
            this.inputMonth = new System.Windows.Forms.ComboBox();
            this.addItem = new System.Windows.Forms.Button();
            this.missingData = new System.Windows.Forms.Label();
            this.inputName = new financeManager.PlaceHolderTextBox();
            this.inputValue = new financeManager.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // inputType
            // 
            this.inputType.FormattingEnabled = true;
            this.inputType.Items.AddRange(new object[] {
            "Entrance",
            "Expence",
            "Subscription"});
            this.inputType.Location = new System.Drawing.Point(329, 47);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(134, 21);
            this.inputType.TabIndex = 1;
            this.inputType.SelectedIndexChanged += new System.EventHandler(this.inputType_SelectedIndexChanged);
            // 
            // inputMonth
            // 
            this.inputMonth.FormattingEnabled = true;
            this.inputMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.inputMonth.Location = new System.Drawing.Point(493, 47);
            this.inputMonth.Name = "inputMonth";
            this.inputMonth.Size = new System.Drawing.Size(134, 21);
            this.inputMonth.TabIndex = 2;
            this.inputMonth.SelectedIndexChanged += new System.EventHandler(this.inputMonth_SelectedIndexChanged);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(666, 12);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(90, 20);
            this.addItem.TabIndex = 3;
            this.addItem.Text = "Add";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // missingData
            // 
            this.missingData.AutoSize = true;
            this.missingData.BackColor = System.Drawing.Color.Crimson;
            this.missingData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.missingData.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.missingData.Location = new System.Drawing.Point(648, 49);
            this.missingData.Name = "missingData";
            this.missingData.Size = new System.Drawing.Size(108, 19);
            this.missingData.TabIndex = 4;
            this.missingData.Text = "Missing Data";
            this.missingData.Visible = false;
            this.missingData.Click += new System.EventHandler(this.missingData_Click);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(329, 12);
            this.inputName.Name = "inputName";
            this.inputName.PlaceHolderText = null;
            this.inputName.Size = new System.Drawing.Size(134, 20);
            this.inputName.TabIndex = 5;
            this.inputName.Text = "Name";
            // 
            // inputValue
            // 
            this.inputValue.Location = new System.Drawing.Point(493, 12);
            this.inputValue.Name = "inputValue";
            this.inputValue.PlaceHolderText = null;
            this.inputValue.Size = new System.Drawing.Size(134, 20);
            this.inputValue.TabIndex = 6;
            this.inputValue.Text = "Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 650);
            this.Controls.Add(this.inputValue);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.missingData);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.inputMonth);
            this.Controls.Add(this.inputType);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox inputType;
        private System.Windows.Forms.ComboBox inputMonth;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Label missingData;
        private PlaceHolderTextBox inputName;
        private PlaceHolderTextBox inputValue;
    }
}

