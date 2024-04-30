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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.inputType = new System.Windows.Forms.ComboBox();
            this.inputMonth = new System.Windows.Forms.ComboBox();
            this.addItem = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTable = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inputValue = new financeManager.PlaceHolderTextBox();
            this.inputName = new financeManager.PlaceHolderTextBox();
            this.removeItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputType
            // 
            this.inputType.FormattingEnabled = true;
            this.inputType.Items.AddRange(new object[] {
            "Entrance",
            "Expence",
            "Subscription"});
            this.inputType.Location = new System.Drawing.Point(237, 67);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(134, 21);
            this.inputType.TabIndex = 3;
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
            this.inputMonth.Location = new System.Drawing.Point(401, 67);
            this.inputMonth.Name = "inputMonth";
            this.inputMonth.Size = new System.Drawing.Size(134, 21);
            this.inputMonth.TabIndex = 4;
            this.inputMonth.SelectedIndexChanged += new System.EventHandler(this.inputMonth_SelectedIndexChanged);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(574, 32);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(90, 20);
            this.addItem.TabIndex = 3;
            this.addItem.Text = "Add";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 130);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(639, 417);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataTable
            // 
            this.dataTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.tableName,
            this.tableValue,
            this.tableType,
            this.tableMonth});
            this.dataTable.FullRowSelect = true;
            this.dataTable.GridLines = true;
            this.dataTable.HideSelection = false;
            this.dataTable.Location = new System.Drawing.Point(703, 130);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(322, 417);
            this.dataTable.TabIndex = 8;
            this.dataTable.UseCompatibleStateImageBehavior = false;
            this.dataTable.View = System.Windows.Forms.View.Details;
            this.dataTable.SelectedIndexChanged += new System.EventHandler(this.dataTable_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // tableName
            // 
            this.tableName.Text = "Name";
            this.tableName.Width = 100;
            // 
            // tableValue
            // 
            this.tableValue.Text = "Value";
            // 
            // tableType
            // 
            this.tableType.Text = "Type";
            this.tableType.Width = 75;
            // 
            // tableMonth
            // 
            this.tableMonth.Text = "Month";
            this.tableMonth.Width = 115;
            // 
            // inputValue
            // 
            this.inputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.inputValue.ForeColor = System.Drawing.Color.Gray;
            this.inputValue.Location = new System.Drawing.Point(401, 32);
            this.inputValue.Name = "inputValue";
            this.inputValue.PlaceHolderText = null;
            this.inputValue.Size = new System.Drawing.Size(134, 20);
            this.inputValue.TabIndex = 2;
            this.inputValue.Text = "Value";
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.inputName.ForeColor = System.Drawing.Color.Gray;
            this.inputName.Location = new System.Drawing.Point(237, 32);
            this.inputName.Name = "inputName";
            this.inputName.PlaceHolderText = null;
            this.inputName.Size = new System.Drawing.Size(134, 20);
            this.inputName.TabIndex = 1;
            this.inputName.Text = "Name";
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(942, 574);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(83, 20);
            this.removeItem.TabIndex = 9;
            this.removeItem.Text = "Remove";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 650);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.inputValue);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.inputMonth);
            this.Controls.Add(this.inputType);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox inputType;
        private System.Windows.Forms.ComboBox inputMonth;
        private System.Windows.Forms.Button addItem;
        private PlaceHolderTextBox inputName;
        private PlaceHolderTextBox inputValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView dataTable;
        private System.Windows.Forms.ColumnHeader tableName;
        private System.Windows.Forms.ColumnHeader tableValue;
        private System.Windows.Forms.ColumnHeader tableType;
        private System.Windows.Forms.ColumnHeader tableMonth;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.ColumnHeader ID;
    }
}

