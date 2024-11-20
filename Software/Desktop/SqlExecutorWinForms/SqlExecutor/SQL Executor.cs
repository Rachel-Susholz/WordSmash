using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlExecutor
{
    public partial class SQL_Executor : Form
    {
        public SQL_Executor()
        {
            InitializeComponent();
            tbcQuery.TabPages.Clear();
            btnRunQuery.Click += BtnRunQuery_Click;
        }



        private string GetDatabaseName()
        {
            string s = "";

            if (rbtRecordKeeper.Checked)
            {
                s = "RecordKeeperDB";
            }
            else if (rbtRecipe.Checked)
            {
                s = "HeartyHearthDB";
            }

            return s;
        }


        private string GetConnectionString()
        {
            string s = "";
            string DatabaseName = GetDatabaseName();

            if (rbtLocal.Checked)
            {
                // Local SQL Server connection string
                s = $"Server=.\\SQLExpress;DataBase={DatabaseName};Trusted_Connection=True";
            }
            else if (rbtAzure.Checked)
            {
                // Azure SQL Server connection string
                s = $"Server=tcp:dev-rochelsusholz.database.windows.net,1433; Initial Catalog={DatabaseName};Persist Security Info=False;User ID=rsadmin;Password=Rochel@9225; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            }
            
            return s;
        }

        private DataTable GetDataTable(string sqlstatement)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = GetConnectionString();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sqlstatement;
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        private void ShowDataInGrid()
        {
            TabPage p = new TabPage("Query" + (tbcQuery.TabPages.Count + 1).ToString());
            tbcQuery.TabPages.Add(p);
            tbcQuery.SelectedTab = p;

            string s = txtTypeQuery.Text;
            DataTable dt = GetDataTable(s);
            DataGridView dgv = new DataGridView()
            {
                Dock = DockStyle.Fill,
                DataSource = dt,
            };
            p.Controls.Add(dgv);
        }
        private void BtnRunQuery_Click(object? sender, EventArgs e)
        {

            ShowDataInGrid();
            
        }
    }
}
