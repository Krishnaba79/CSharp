﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace CRUDForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KRISHNA\\SQLEXPRESS02;Initial Catalog=CRUDForm;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ut values(@id,@name,@age)",con);\
            cmd.Parameters.AddWithValue("@id",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age",double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("successfully saved");


        }
    }
}
