namespace SqlExecutor
{
    partial class SQL_Executor
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblDatabase = new Label();
            pnlServer = new Panel();
            rbtLocalDB = new RadioButton();
            rbtAzure = new RadioButton();
            pnlDatabase = new Panel();
            rbtHeartyHearth = new RadioButton();
            rbtRecordKeeper = new RadioButton();
            txtTypeQuery = new TextBox();
            btnRunQuery = new Button();
            tbcQuery = new TabControl();
            tabPage1 = new TabPage();
            DataGridViewMain = new DataGridView();
            tabPage2 = new TabPage();
            tableLayoutPanel1.SuspendLayout();
            pnlServer.SuspendLayout();
            pnlDatabase.SuspendLayout();
            tbcQuery.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.16697F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.83303F));
            tableLayoutPanel1.Controls.Add(lblDatabase, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlServer, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlDatabase, 0, 1);
            tableLayoutPanel1.Controls.Add(txtTypeQuery, 1, 1);
            tableLayoutPanel1.Controls.Add(btnRunQuery, 1, 2);
            tableLayoutPanel1.Controls.Add(tbcQuery, 0, 3);
            tableLayoutPanel1.Location = new Point(3, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7601748F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.6700954F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9295759F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.6401558F));
            tableLayoutPanel1.Size = new Size(615, 361);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDatabase
            // 
            lblDatabase.BackColor = SystemColors.ControlLight;
            lblDatabase.Dock = DockStyle.Fill;
            lblDatabase.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatabase.ForeColor = SystemColors.ControlDark;
            lblDatabase.Location = new Point(3, 0);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(161, 38);
            lblDatabase.TabIndex = 0;
            lblDatabase.Text = "Database";
            lblDatabase.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlServer
            // 
            pnlServer.BackColor = SystemColors.Control;
            pnlServer.Controls.Add(rbtLocalDB);
            pnlServer.Controls.Add(rbtAzure);
            pnlServer.Dock = DockStyle.Fill;
            pnlServer.Location = new Point(170, 3);
            pnlServer.Name = "pnlServer";
            pnlServer.Size = new Size(442, 32);
            pnlServer.TabIndex = 1;
            // 
            // rbtLocalDB
            // 
            rbtLocalDB.AutoSize = true;
            rbtLocalDB.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtLocalDB.Location = new Point(115, 3);
            rbtLocalDB.Name = "rbtLocalDB";
            rbtLocalDB.Size = new Size(96, 29);
            rbtLocalDB.TabIndex = 1;
            rbtLocalDB.Text = "LocalDB";
            rbtLocalDB.UseVisualStyleBackColor = true;
            // 
            // rbtAzure
            // 
            rbtAzure.AutoSize = true;
            rbtAzure.Checked = true;
            rbtAzure.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtAzure.Location = new Point(31, 3);
            rbtAzure.Name = "rbtAzure";
            rbtAzure.Size = new Size(78, 29);
            rbtAzure.TabIndex = 0;
            rbtAzure.TabStop = true;
            rbtAzure.Text = "Azure";
            rbtAzure.UseVisualStyleBackColor = true;
            // 
            // pnlDatabase
            // 
            pnlDatabase.BackColor = SystemColors.Control;
            pnlDatabase.Controls.Add(rbtHeartyHearth);
            pnlDatabase.Controls.Add(rbtRecordKeeper);
            pnlDatabase.Dock = DockStyle.Fill;
            pnlDatabase.Location = new Point(3, 41);
            pnlDatabase.Name = "pnlDatabase";
            tableLayoutPanel1.SetRowSpan(pnlDatabase, 2);
            pnlDatabase.Size = new Size(161, 140);
            pnlDatabase.TabIndex = 2;
            // 
            // rbtHeartyHearth
            // 
            rbtHeartyHearth.AutoSize = true;
            rbtHeartyHearth.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtHeartyHearth.Location = new Point(6, 32);
            rbtHeartyHearth.Name = "rbtHeartyHearth";
            rbtHeartyHearth.Size = new Size(138, 29);
            rbtHeartyHearth.TabIndex = 1;
            rbtHeartyHearth.Text = "HeartyHearth";
            rbtHeartyHearth.UseVisualStyleBackColor = true;
            // 
            // rbtRecordKeeper
            // 
            rbtRecordKeeper.AutoSize = true;
            rbtRecordKeeper.Checked = true;
            rbtRecordKeeper.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtRecordKeeper.Location = new Point(6, 6);
            rbtRecordKeeper.Name = "rbtRecordKeeper";
            rbtRecordKeeper.Size = new Size(147, 29);
            rbtRecordKeeper.TabIndex = 0;
            rbtRecordKeeper.TabStop = true;
            rbtRecordKeeper.Text = "Record Keeper";
            rbtRecordKeeper.UseVisualStyleBackColor = true;
            // 
            // txtTypeQuery
            // 
            txtTypeQuery.BackColor = SystemColors.Control;
            txtTypeQuery.BorderStyle = BorderStyle.FixedSingle;
            txtTypeQuery.Dock = DockStyle.Fill;
            txtTypeQuery.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTypeQuery.ForeColor = SystemColors.ControlDark;
            txtTypeQuery.Location = new Point(170, 41);
            txtTypeQuery.Multiline = true;
            txtTypeQuery.Name = "txtTypeQuery";
            txtTypeQuery.Size = new Size(442, 101);
            txtTypeQuery.TabIndex = 3;
            txtTypeQuery.TabStop = false;
            txtTypeQuery.Text = "Type Query Here";
            txtTypeQuery.UseWaitCursor = true;
            // 
            // btnRunQuery
            // 
            btnRunQuery.BackColor = SystemColors.ScrollBar;
            btnRunQuery.Dock = DockStyle.Right;
            btnRunQuery.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRunQuery.Location = new Point(470, 148);
            btnRunQuery.Name = "btnRunQuery";
            btnRunQuery.Size = new Size(142, 33);
            btnRunQuery.TabIndex = 4;
            btnRunQuery.Text = "Run Query";
            btnRunQuery.UseVisualStyleBackColor = false;
            // 
            // tbcQuery
            // 
            tableLayoutPanel1.SetColumnSpan(tbcQuery, 2);
            tbcQuery.Controls.Add(tabPage1);
            tbcQuery.Controls.Add(tabPage2);
            tbcQuery.Dock = DockStyle.Fill;
            tbcQuery.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbcQuery.Location = new Point(3, 187);
            tbcQuery.Name = "tbcQuery";
            tbcQuery.SelectedIndex = 0;
            tbcQuery.Size = new Size(609, 171);
            tbcQuery.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DataGridViewMain);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(601, 133);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataGridViewMain
            // 
            DataGridViewMain.BackgroundColor = SystemColors.Control;
            DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewMain.Dock = DockStyle.Fill;
            DataGridViewMain.Location = new Point(3, 3);
            DataGridViewMain.Name = "DataGridViewMain";
            DataGridViewMain.ReadOnly = true;
            DataGridViewMain.RowHeadersWidth = 51;
            DataGridViewMain.RowTemplate.Height = 29;
            DataGridViewMain.Size = new Size(595, 127);
            DataGridViewMain.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(601, 133);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // SQL_Executor
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 370);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "SQL_Executor";
            Text = "SQL_Executor";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlServer.ResumeLayout(false);
            pnlServer.PerformLayout();
            pnlDatabase.ResumeLayout(false);
            pnlDatabase.PerformLayout();
            tbcQuery.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDatabase;
        private Panel pnlServer;
        private RadioButton rbtLocalDB;
        private RadioButton rbtAzure;
        private Panel pnlDatabase;
        private RadioButton rbtHeartyHearth;
        private RadioButton rbtRecordKeeper;
        private TextBox txtTypeQuery;
        private Button btnRunQuery;
        private TabControl tbcQuery;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView DataGridViewMain;
    }
}