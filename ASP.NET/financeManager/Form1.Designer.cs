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
            this.inputValue = new System.Windows.Forms.TextBox();
            this.inputType = new System.Windows.Forms.ComboBox();
            this.inputMonth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // inputValue
            // 
            this.inputValue.Location = new System.Drawing.Point(400, 12);
            this.inputValue.Name = "inputValue";
            this.inputValue.Size = new System.Drawing.Size(298, 20);
            this.inputValue.TabIndex = 0;
            this.inputValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputType
            // 
            this.inputType.FormattingEnabled = true;
            this.inputType.Items.AddRange(new object[] {
            "Entrata",
            "Uscita",
            "Abbonamento"});
            this.inputType.Location = new System.Drawing.Point(400, 47);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(134, 21);
            this.inputType.TabIndex = 1;
            this.inputType.SelectedIndexChanged += new System.EventHandler(this.inputType_SelectedIndexChanged);
            // 
            // inputMonth
            // 
            this.inputMonth.FormattingEnabled = true;
            this.inputMonth.Items.AddRange(new object[] {
            "Gennaio",
            "Febbraio",
            "Marzo",
            "Aprile",
            "Maggio",
            "Giugno",
            "Luglio",
            "Agosto",
            "Settembre",
            "Ottobre",
            "Novembre",
            "Dicembre"});
            this.inputMonth.Location = new System.Drawing.Point(564, 47);
            this.inputMonth.Name = "inputMonth";
            this.inputMonth.Size = new System.Drawing.Size(134, 21);
            this.inputMonth.TabIndex = 2;
            this.inputMonth.SelectedIndexChanged += new System.EventHandler(this.inputMonth_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 650);
            this.Controls.Add(this.inputMonth);
            this.Controls.Add(this.inputType);
            this.Controls.Add(this.inputValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputValue;
        private System.Windows.Forms.ComboBox inputType;
        private System.Windows.Forms.ComboBox inputMonth;
    }
}

