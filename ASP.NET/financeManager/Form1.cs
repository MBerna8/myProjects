using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using Microsoft.Data.SqlClient;

namespace financeManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class operation
        {
            public string ID;
            public string name;
            public double value;
            public string type;
            public string month;
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

            //SQL INTEGRATION

            List<operation> listid = new List<operation>();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7PK0304; Initial Catalog=Finance_Manager; Integrated Security=True; TrustServerCertificate=True");
            string sql = "select * from Operations";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                operation oper = new operation();
                oper.ID = dr["ID"].ToString();
                oper.name = dr["Nome_Spesa"].ToString();
                oper.value = Convert.ToDouble(dr["VAlore_Spesa"]);
                oper.type = dr["Tipo_Spesa"].ToString();
                oper.month = dr["Mese_SPesa"].ToString();

                ListViewItem item = new ListViewItem(oper.ID);

                item.SubItems.Add(oper.name);
                item.SubItems.Add(oper.value.ToString());
                item.SubItems.Add(oper.type);
                item.SubItems.Add(oper.month);

                dataTable.Items.Add(item);
                Console.WriteLine($"{oper.ID},{oper.name},{oper.value},{oper.type},{oper.month}");
                listid.Add(oper);
            }


            //if (File.ReadAllLines("sheet.txt").Length > 0)
            //{
            //    string[] righeFile = File.ReadAllLines("sheet.txt");

            //    foreach (string line in righeFile)
            //    {
            //        string[] elementiRiga = line.Split(',');

            //        elementiRiga.ToArray();
            //        ListViewItem item = new ListViewItem(elementiRiga[0]);

            //        item.SubItems.Add(elementiRiga[1]);
            //        item.SubItems.Add(elementiRiga[2]);
            //        item.SubItems.Add(elementiRiga[3]);
            //        item.SubItems.Add(elementiRiga[4]);

            //        dataTable.Items.Add(item);
            //    }

            //}


        }

        private void addItem_Click(object sender, EventArgs e)
        {
            operation obj = new operation();
            if (double.TryParse(inputValue.Text, out double val) && !string.IsNullOrEmpty(inputType.Text) && !string.IsNullOrEmpty(inputMonth.Text) && !string.IsNullOrEmpty(inputName.Text) && val>0)
            {
                Console.WriteLine("DATI OK");
                obj.ID = Guid.NewGuid().ToString();
                obj.name = inputName.Text;
                obj.value = val;
                obj.type = inputType.Text; 
                obj.month = inputMonth.Text;
                

                string data = ($"{obj.ID},{obj.name},{obj.value},{obj.type},{obj.month}");

                ListViewItem item = new ListViewItem(obj.ID);

                item.SubItems.Add(obj.name);
                item.SubItems.Add(obj.value.ToString());
                item.SubItems.Add(obj.type);
                item.SubItems.Add(obj.month);
                dataTable.Items.Add(item);

                inputName.Clear();
                inputValue.Clear();


                inputType.ResetText();
                inputMonth.ResetText();

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7PK0304; Initial Catalog=Finance_Manager; Integrated Security=True; TrustServerCertificate=True");
                SqlCommand cmd;

                //SQL integration
                con.Open();
                cmd = new SqlCommand("insert into Operations values('" + obj.ID + "','" + obj.name + "','" + obj.value + "','" + obj.type + "','" + obj.month + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved in the DATABASE");
                con.Close();


                using (StreamWriter w = File.AppendText("sheet.txt"))
                {
                    w.WriteLine(data);
                }
            }
            else
            {
                MessageBox.Show("MISSING DATA");
            }
        }
        private void removeItem_Click(object sender, EventArgs e)
        {
            if (dataTable.Items.Count > 0)
            {

                List<string> lines = File.ReadAllLines("sheet.txt").ToList();
                string item = dataTable.SelectedItems[0].ToString();
                Console.WriteLine(item);
                item = item.Substring(15, 36).Trim();
                Console.WriteLine(item);


                SqlConnection con = new SqlConnection("Data Source=DESKTOP-7PK0304; Initial Catalog=Finance_Manager; Integrated Security=True; TrustServerCertificate=True");
                SqlCommand cmd;
                //con.Open();
                //SqlCommand cmd = new SqlCommand(sql, con);
                //SqlDataReader dr = cmd.ExecuteReader();
                con.Open();
                cmd = new SqlCommand("DELETE FROM Operations WHERE ID = '" + item + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted from the DATABASE");
                con.Close();
                //Console.WriteLine(dr["ID"].ToString());
                dataTable.Items.Remove(dataTable.SelectedItems[0]);

                //while (dr.Read())
                //{
                //    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7PK0304; Initial Catalog=Finance_Manager; Integrated Security=True; TrustServerCertificate=True");
                //    conn.Open();
                //    using (SqlCommand command = new SqlCommand("DELETE FROM Operations WHERE ID = '" + item + "'", conn))
                //    {
                //        command.ExecuteNonQuery();
                //    }
                //    Console.WriteLine(dr["ID"].ToString());
                //    conn.Close();
                //    dataTable.Items.Remove(dataTable.SelectedItems[0]);
                //}

                

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
