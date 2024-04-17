using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pk31Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginInput = textBox1.Text.Trim();
            if (loginInput.Length>2 && loginInput.Length<21)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = DBConn.Connect();
                cmd.CommandText = "SELECT `id`, `password` FROM `users` WHERE `login`=@userInput";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("userInput",loginInput);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("есть такое");
                } else
                {
                    MessageBox.Show("нет такое");
                }
                DBConn.Close();
            }
            else
            {
                MessageBox.Show("Логин должен быть от 3 до 20 символов");
            }
        }
        //pupupu
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }
    }
}
