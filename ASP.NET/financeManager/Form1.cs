using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace financeManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Data File check and creation

            string fileName = "sheet.txt"; // The name of the file you want to check
            string directoryPath = Directory.GetCurrentDirectory(); // Get the current directory

            string filePath = Path.Combine(directoryPath, fileName); // Combine directory path and file name

            if (File.Exists(filePath))
            {
                Console.WriteLine($"File {fileName} exists in the directory.");
            }
            else
            {
                Console.WriteLine($"File {fileName} does not exist in the directory.");
                File.Create(filePath);
            }

            string[] righeFile = File.ReadAllLines("sheet.txt");

            foreach (string line in righeFile)
            {
                string[] elementiRiga = line.Split(',');

                elementiRiga.ToArray();
                ListViewItem item = new ListViewItem(elementiRiga[0]);
                
                    item.SubItems.Add(elementiRiga[1]);
                    item.SubItems.Add(elementiRiga[2]);
                    item.SubItems.Add(elementiRiga[3]);

                    dataTable.Items.Add(item); 
            }

        }

        private void addItem_Click(object sender, EventArgs e)
        {
            if (double.TryParse(inputValue.Text, out double val) && !string.IsNullOrEmpty(inputType.Text) && !string.IsNullOrEmpty(inputMonth.Text) && !string.IsNullOrEmpty(inputName.Text) && val>0)
            {
                Console.WriteLine("DATI OK");
                string Name = inputName.Text;
                string Type = inputType.Text; 
                string Month = inputMonth.Text;
                string Value = inputValue.Text;

                string data = ($"{Name},{Value},{Type},{Month}");

                ListViewItem item = new ListViewItem(Name);

                item.SubItems.Add(Value);
                item.SubItems.Add(Type);
                item.SubItems.Add(Month);
                dataTable.Items.Add(item);

                inputName.Clear();
                inputValue.Clear();

                inputName.Focus();

                using (StreamWriter w = File.AppendText("sheet.txt"))
                {
                    w.WriteLine(data);
                }

                Console.WriteLine($"{Name} {Value} {Type} {Month}");
                missingData.Visible = false;
            }
            else
            {
                missingData.Visible = true;
                Console.WriteLine("DATI MANCANTI");

            }
        }
        private void removeItem_Click(object sender, EventArgs e)
        {
            if (dataTable.Items.Count > 0)
            {
                dataTable.Items.Remove(dataTable.SelectedItems[0]);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void missingData_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }
    }

    // Placeholders

    public class PlaceHolderTextBox : TextBox
    {

        bool isPlaceHolder = true;
        string _placeHolderText;
        public string PlaceHolderText
        {
            get { return _placeHolderText; }
            set
            {
                _placeHolderText = value;
                setPlaceholder();
            }
        }

        public new string Text
        {
            get => isPlaceHolder ? string.Empty : base.Text;
            set => base.Text = value;
        }

        //when the control loses focus, the placeholder is shown
        private void setPlaceholder()
        {
            if (string.IsNullOrEmpty(base.Text))
            {
                base.Text = PlaceHolderText;
                this.ForeColor = Color.Gray;
                this.Font = new Font(this.Font, FontStyle.Italic);
                isPlaceHolder = true;
            }
        }

        //when the control is focused, the placeholder is removed
        private void removePlaceHolder()
        {

            if (isPlaceHolder)
            {
                base.Text = "";
                this.ForeColor = System.Drawing.SystemColors.WindowText;
                this.Font = new Font(this.Font, FontStyle.Regular);
                isPlaceHolder = false;
            }
        }
        public PlaceHolderTextBox()
        {
            GotFocus += removePlaceHolder;
            LostFocus += setPlaceholder;
        }

        private void setPlaceholder(object sender, EventArgs e)
        {
            setPlaceholder();
        }

        private void removePlaceHolder(object sender, EventArgs e)
        {
            removePlaceHolder();
        }
    }
}
