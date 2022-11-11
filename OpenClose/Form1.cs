using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OpenClose
{

    public partial class Form1 : Form
    {
    private SqlConnection conn = new SqlConnection("Server=LAPTOP-D0D6I3G9\\SQLEXPRESS; Database=Northwind; Integrated Security=true;");
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnectDisconnect_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
                buttonConnectDisconnect.Text = "Connect";
                labelStatus.Text = "Disconnected";
            }
            else
            {
                conn.Open();
                buttonConnectDisconnect.Text = "Disconnect";
                labelStatus.Text = "Connected";
            }
        }
    }
}
