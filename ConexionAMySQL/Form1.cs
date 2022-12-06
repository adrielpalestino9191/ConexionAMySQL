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

namespace ConexionAMySQL
{
    public partial class Form1 : Form
    {
        MySqlConnection sql = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql.ConnectionString = "server=" + txtHost.Text + ";user id=" + txtUser.Text + ";password=" + txtPwd.Text;
                sql.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ex.Message);
            }
            finally
            {
                sql.Close();
            }

        }
    }
}
