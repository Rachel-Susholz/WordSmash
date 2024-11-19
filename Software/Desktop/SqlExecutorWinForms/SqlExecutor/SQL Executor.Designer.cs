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
            panel1 = new Panel();
            rbtRecipe = new RadioButton();
            rbtRecordKeeper = new RadioButton();
            panel2 = new Panel();
            rbtLocal = new RadioButton();
            rbtAzure = new RadioButton();
            txtTypeQuery = new TextBox();
            btnRunQuery = new Button();
            lblDatabase = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(rbtRecipe);
            panel1.Controls.Add(rbtRecordKeeper);
            panel1.Location = new Point(6, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 158);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // rbtRecipe
            // 
            rbtRecipe.AutoSize = true;
            rbtRecipe.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtRecipe.Location = new Point(12, 41);
            rbtRecipe.Name = "rbtRecipe";
            rbtRecipe.Size = new Size(75, 22);
            rbtRecipe.TabIndex = 1;
            rbtRecipe.TabStop = true;
            rbtRecipe.Text = "Recipe";
            rbtRecipe.UseVisualStyleBackColor = true;
            // 
            // rbtRecordKeeper
            // 
            rbtRecordKeeper.AutoSize = true;
            rbtRecordKeeper.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtRecordKeeper.Location = new Point(12, 13);
            rbtRecordKeeper.Name = "rbtRecordKeeper";
            rbtRecordKeeper.Size = new Size(125, 22);
            rbtRecordKeeper.TabIndex = 0;
            rbtRecordKeeper.TabStop = true;
            rbtRecordKeeper.Text = "RecordKeeper";
            rbtRecordKeeper.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Menu;
            panel2.Controls.Add(rbtLocal);
            panel2.Controls.Add(rbtAzure);
            panel2.Location = new Point(162, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 56);
            panel2.TabIndex = 2;
            // 
            // rbtLocal
            // 
            rbtLocal.AutoSize = true;
            rbtLocal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtLocal.Location = new Point(98, 14);
            rbtLocal.Name = "rbtLocal";
            rbtLocal.Size = new Size(65, 22);
            rbtLocal.TabIndex = 1;
            rbtLocal.TabStop = true;
            rbtLocal.Text = "Local";
            rbtLocal.UseVisualStyleBackColor = true;
            // 
            // rbtAzure
            // 
            rbtAzure.AutoSize = true;
            rbtAzure.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtAzure.Location = new Point(25, 14);
            rbtAzure.Name = "rbtAzure";
            rbtAzure.Size = new Size(67, 22);
            rbtAzure.TabIndex = 0;
            rbtAzure.TabStop = true;
            rbtAzure.Text = "Azure";
            rbtAzure.UseVisualStyleBackColor = true;
            // 
            // txtTypeQuery
            // 
            txtTypeQuery.BackColor = SystemColors.Menu;
            txtTypeQuery.BorderStyle = BorderStyle.FixedSingle;
            txtTypeQuery.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTypeQuery.ForeColor = SystemColors.ControlDark;
            txtTypeQuery.Location = new Point(168, 62);
            txtTypeQuery.Multiline = true;
            txtTypeQuery.Name = "txtTypeQuery";
            txtTypeQuery.Size = new Size(441, 86);
            txtTypeQuery.TabIndex = 3;
            txtTypeQuery.Text = "Type Query Here";
            // 
            // btnRunQuery
            // 
            btnRunQuery.BackColor = SystemColors.ControlLight;
            btnRunQuery.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRunQuery.ForeColor = SystemColors.ControlDark;
            btnRunQuery.Location = new Point(478, 154);
            btnRunQuery.Name = "btnRunQuery";
            btnRunQuery.Size = new Size(131, 34);
            btnRunQuery.TabIndex = 4;
            btnRunQuery.Text = "Run Query";
            btnRunQuery.UseVisualStyleBackColor = false;
            // 
            // lblDatabase
            // 
            lblDatabase.BackColor = SystemColors.ControlLight;
            lblDatabase.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatabase.ForeColor = SystemColors.ActiveBorder;
            lblDatabase.Location = new Point(6, 3);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(150, 36);
            lblDatabase.TabIndex = 5;
            lblDatabase.Text = "Database";
            lblDatabase.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SQL_Executor
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 370);
            Controls.Add(lblDatabase);
            Controls.Add(btnRunQuery);
            Controls.Add(txtTypeQuery);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "SQL_Executor";
            Text = "SQL_Executor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private RadioButton rbtRecipe;
        private RadioButton rbtRecordKeeper;
        private Panel panel2;
        private RadioButton rbtLocal;
        private RadioButton rbtAzure;
        private TextBox txtTypeQuery;
        private Button btnRunQuery;
        private Label lblDatabase;
    }
}