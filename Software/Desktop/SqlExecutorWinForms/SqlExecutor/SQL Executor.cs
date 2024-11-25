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

        private enum ServerChoiceEnum { Local, Azure }
        private enum DatabaseChoiceEnum { RecordKeeperDB, HeartyHearthDB }

        string SelectedServer = "";
        string SelectedDatabase = "";

        public SQL_Executor()
        {
            InitializeComponent();
            tbcQuery.TabPages.Clear();
            btnRunQuery.Click += BtnRunQuery_Click;
        }

        private void UpdateFormVariables()
        {
            if (rbtLocalDB.Checked)
            {
                SelectedServer = ServerChoiceEnum.Local.ToString();
            }
            else if (rbtAzure.Checked)
            {
                SelectedServer = ServerChoiceEnum.Azure.ToString();
            }
            if (rbtRecordKeeper.Checked)
            {
                SelectedDatabase = DatabaseChoiceEnum.RecordKeeperDB.ToString();
            }
            else if (rbtHeartyHearth.Checked)
            {
                SelectedDatabase = DatabaseChoiceEnum.HeartyHearthDB.ToString();
            }
        }



        private string GetConnectionString()
        {
            var s = "";
            var DatabaseName = SelectedDatabase;
            UpdateFormVariables();

            ///FB Use the SelectedServer variable and check if it's equal to the enum.
            if (SelectedServer == ServerChoiceEnum.Local.ToString())
            {
                // Local SQL Server connection string
                s = $"Server=.\\SQLExpress;DataBase={DatabaseName};Trusted_Connection=True";
            }
            else if (SelectedServer == ServerChoiceEnum.Azure.ToString())
            {
                // Azure SQL Server connection string
                s = $"Server=tcp:dev-rochelsusholz.database.windows.net,1433; Initial Catalog={DatabaseName};Persist Security Info=False;User ID=rsadmin;Password=Rochel@9225; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            }

            return s;
        }

        private DataTable GetDataTable(string sqlstatement)
        {
            DataTable dt = new();
            SqlConnection conn = new();
            conn.ConnectionString = GetConnectionString();
            conn.Open();
            SqlCommand cmd = new();
            cmd.Connection = conn;
            cmd.CommandText = sqlstatement;
            var dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        private void ShowDataInGrid()
        {
            UpdateFormVariables();
            var p = new TabPage($"{tbcQuery.TabPages.Count + 1} {SelectedServer} {SelectedDatabase}");
            tbcQuery.TabPages.Add(p);
            tbcQuery.SelectedTab = p;

            var s = txtTypeQuery.Text;
            var dt = GetDataTable(s);
            DataGridView dgv = new()
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
        //RS I called UpdateFormVariables() here so that when the user clicks run
        //query it selects server and database based on what radio buttons are selected
        //and then converts those value to string values which are displayed in the thab window titles.
        //Is there a better way to do this? 
        //FB You can call it from SHowDataInGrid() as that is always called and it's better not to keep anything in the button click so that the code should be reusable.
    }
}
