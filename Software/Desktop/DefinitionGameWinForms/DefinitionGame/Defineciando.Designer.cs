namespace DefinitionGame
{
    partial class Defineciando
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
            tblMain = new TableLayoutPanel();
            lblInstructions = new Label();
            pnlFilter = new Panel();
            txtSpecificLetters = new TextBox();
            txtNumberOfLetters = new TextBox();
            lblSpecificLetters = new Label();
            lblNumOfLetters = new Label();
            lblFilter = new Label();
            tblButtons = new TableLayoutPanel();
            btnPickWord = new Button();
            btnGiveUp = new Button();
            btnEnter = new Button();
            rbDefinition1 = new RadioButton();
            rbDefinition2 = new RadioButton();
            rbDefinition3 = new RadioButton();
            tblScore = new TableLayoutPanel();
            lblFeedback = new Label();
            lblWordsTried = new Label();
            lblScore = new Label();
            txtScore = new TextBox();
            txtWordsTried = new TextBox();
            pnlWord = new Panel();
            lblWord = new Label();
            lblLitWord = new Label();
            tblDefinitions = new TableLayoutPanel();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lblDef1 = new Label();
            lblDef2 = new Label();
            lblDef3 = new Label();
            lblAnswer1 = new Label();
            lblAnswer2 = new Label();
            lblAnswer3 = new Label();
            tblMain.SuspendLayout();
            pnlFilter.SuspendLayout();
            tblButtons.SuspendLayout();
            tblScore.SuspendLayout();
            pnlWord.SuspendLayout();
            tblDefinitions.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblInstructions, 0, 0);
            tblMain.Controls.Add(pnlFilter, 0, 1);
            tblMain.Controls.Add(tblButtons, 0, 2);
            tblMain.Controls.Add(tblScore, 0, 3);
            tblMain.Controls.Add(pnlWord, 0, 4);
            tblMain.Controls.Add(tblDefinitions, 0, 5);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.738568F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.772965F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.625293F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.621297F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.932676F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 47.578968F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.730235F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Dock = DockStyle.Fill;
            lblInstructions.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructions.ForeColor = Color.LightSkyBlue;
            lblInstructions.Location = new Point(3, 0);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(794, 43);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = "I give you the word and 3 definitions. You pick the correct definition.";
            lblInstructions.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(txtSpecificLetters);
            pnlFilter.Controls.Add(txtNumberOfLetters);
            pnlFilter.Controls.Add(lblSpecificLetters);
            pnlFilter.Controls.Add(lblNumOfLetters);
            pnlFilter.Controls.Add(lblFilter);
            pnlFilter.Dock = DockStyle.Fill;
            pnlFilter.Location = new Point(3, 46);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(794, 37);
            pnlFilter.TabIndex = 1;
            // 
            // txtSpecificLetters
            // 
            txtSpecificLetters.Location = new Point(489, 1);
            txtSpecificLetters.Name = "txtSpecificLetters";
            txtSpecificLetters.Size = new Size(71, 31);
            txtSpecificLetters.TabIndex = 4;
            // 
            // txtNumberOfLetters
            // 
            txtNumberOfLetters.Location = new Point(252, 1);
            txtNumberOfLetters.Name = "txtNumberOfLetters";
            txtNumberOfLetters.Size = new Size(69, 31);
            txtNumberOfLetters.TabIndex = 3;
            // 
            // lblSpecificLetters
            // 
            lblSpecificLetters.AutoSize = true;
            lblSpecificLetters.Location = new Point(349, 4);
            lblSpecificLetters.Name = "lblSpecificLetters";
            lblSpecificLetters.Size = new Size(143, 25);
            lblSpecificLetters.TabIndex = 2;
            lblSpecificLetters.Text = "Specific Letter(s):";
            // 
            // lblNumOfLetters
            // 
            lblNumOfLetters.AutoSize = true;
            lblNumOfLetters.Location = new Point(86, 4);
            lblNumOfLetters.Name = "lblNumOfLetters";
            lblNumOfLetters.Size = new Size(160, 25);
            lblNumOfLetters.TabIndex = 1;
            lblNumOfLetters.Text = "Number of Letters:";
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(26, 4);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(54, 25);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "Filter:";
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 6;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblButtons.Controls.Add(btnPickWord, 0, 0);
            tblButtons.Controls.Add(btnGiveUp, 1, 0);
            tblButtons.Controls.Add(btnEnter, 5, 0);
            tblButtons.Controls.Add(rbDefinition1, 2, 0);
            tblButtons.Controls.Add(rbDefinition2, 3, 0);
            tblButtons.Controls.Add(rbDefinition3, 4, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 89);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(794, 37);
            tblButtons.TabIndex = 2;
            // 
            // btnPickWord
            // 
            btnPickWord.BackColor = Color.CornflowerBlue;
            btnPickWord.Dock = DockStyle.Fill;
            btnPickWord.ForeColor = Color.Transparent;
            btnPickWord.Location = new Point(3, 3);
            btnPickWord.Name = "btnPickWord";
            btnPickWord.Size = new Size(126, 31);
            btnPickWord.TabIndex = 0;
            btnPickWord.Text = "Pick a Word";
            btnPickWord.UseVisualStyleBackColor = false;
            
            // 
            // btnGiveUp
            // 
            btnGiveUp.BackColor = Color.DarkOrange;
            btnGiveUp.Dock = DockStyle.Fill;
            btnGiveUp.ForeColor = Color.Transparent;
            btnGiveUp.Location = new Point(135, 3);
            btnGiveUp.Name = "btnGiveUp";
            btnGiveUp.Size = new Size(126, 31);
            btnGiveUp.TabIndex = 1;
            btnGiveUp.Text = "I Give Up";
            btnGiveUp.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.LimeGreen;
            btnEnter.Dock = DockStyle.Fill;
            btnEnter.ForeColor = Color.Transparent;
            btnEnter.Location = new Point(663, 3);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(128, 31);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            // 
            // rbDefinition1
            // 
            rbDefinition1.Anchor = AnchorStyles.Right;
            rbDefinition1.AutoSize = true;
            rbDefinition1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbDefinition1.ForeColor = Color.DeepPink;
            rbDefinition1.Location = new Point(268, 4);
            rbDefinition1.Name = "rbDefinition1";
            rbDefinition1.Size = new Size(125, 29);
            rbDefinition1.TabIndex = 6;
            rbDefinition1.TabStop = true;
            rbDefinition1.Text = "Definition 1";
            rbDefinition1.TextAlign = ContentAlignment.MiddleCenter;
            rbDefinition1.UseVisualStyleBackColor = true;
            // 
            // rbDefinition2
            // 
            rbDefinition2.Anchor = AnchorStyles.Right;
            rbDefinition2.AutoSize = true;
            rbDefinition2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbDefinition2.ForeColor = Color.MediumOrchid;
            rbDefinition2.Location = new Point(400, 4);
            rbDefinition2.Name = "rbDefinition2";
            rbDefinition2.Size = new Size(125, 29);
            rbDefinition2.TabIndex = 7;
            rbDefinition2.TabStop = true;
            rbDefinition2.Text = "Definition 2";
            rbDefinition2.TextAlign = ContentAlignment.MiddleCenter;
            rbDefinition2.UseVisualStyleBackColor = true;
            // 
            // rbDefinition3
            // 
            rbDefinition3.Anchor = AnchorStyles.Right;
            rbDefinition3.AutoSize = true;
            rbDefinition3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbDefinition3.ForeColor = Color.DarkOrange;
            rbDefinition3.Location = new Point(532, 4);
            rbDefinition3.Name = "rbDefinition3";
            rbDefinition3.Size = new Size(125, 29);
            rbDefinition3.TabIndex = 8;
            rbDefinition3.TabStop = true;
            rbDefinition3.Text = "Definition 3";
            rbDefinition3.TextAlign = ContentAlignment.MiddleCenter;
            rbDefinition3.UseVisualStyleBackColor = true;
            // 
            // tblScore
            // 
            tblScore.ColumnCount = 5;
            tblScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.44286F));
            tblScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.86556F));
            tblScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.8971939F));
            tblScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.8971939F));
            tblScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.8971939F));
            tblScore.Controls.Add(lblFeedback, 0, 0);
            tblScore.Controls.Add(lblWordsTried, 1, 0);
            tblScore.Controls.Add(lblScore, 3, 0);
            tblScore.Controls.Add(txtScore, 4, 0);
            tblScore.Controls.Add(txtWordsTried, 2, 0);
            tblScore.Dock = DockStyle.Fill;
            tblScore.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tblScore.Location = new Point(3, 132);
            tblScore.Name = "tblScore";
            tblScore.RowCount = 1;
            tblScore.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblScore.Size = new Size(794, 37);
            tblScore.TabIndex = 3;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Dock = DockStyle.Fill;
            lblFeedback.Location = new Point(3, 0);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(291, 37);
            lblFeedback.TabIndex = 0;
            lblFeedback.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWordsTried
            // 
            lblWordsTried.AutoSize = true;
            lblWordsTried.Dock = DockStyle.Fill;
            lblWordsTried.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblWordsTried.Location = new Point(300, 0);
            lblWordsTried.Name = "lblWordsTried";
            lblWordsTried.Size = new Size(207, 37);
            lblWordsTried.TabIndex = 1;
            lblWordsTried.Text = "Number of Words Tried:";
            lblWordsTried.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Dock = DockStyle.Fill;
            lblScore.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.Location = new Point(607, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(88, 37);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score:";
            lblScore.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtScore
            // 
            txtScore.Anchor = AnchorStyles.Left;
            txtScore.Location = new Point(701, 3);
            txtScore.Name = "txtScore";
            txtScore.ReadOnly = true;
            txtScore.Size = new Size(90, 34);
            txtScore.TabIndex = 4;
            // 
            // txtWordsTried
            // 
            txtWordsTried.Anchor = AnchorStyles.Left;
            txtWordsTried.Location = new Point(513, 3);
            txtWordsTried.Name = "txtWordsTried";
            txtWordsTried.ReadOnly = true;
            txtWordsTried.Size = new Size(88, 34);
            txtWordsTried.TabIndex = 3;
            // 
            // pnlWord
            // 
            pnlWord.Controls.Add(lblWord);
            pnlWord.Controls.Add(lblLitWord);
            pnlWord.Dock = DockStyle.Fill;
            pnlWord.Location = new Point(3, 175);
            pnlWord.Name = "pnlWord";
            pnlWord.Size = new Size(794, 34);
            pnlWord.TabIndex = 5;
            // 
            // lblWord
            // 
            lblWord.Anchor = AnchorStyles.Left;
            lblWord.AutoSize = true;
            lblWord.BorderStyle = BorderStyle.FixedSingle;
            lblWord.Location = new Point(92, 11);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(2, 27);
            lblWord.TabIndex = 5;
            lblWord.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLitWord
            // 
            lblLitWord.Anchor = AnchorStyles.Left;
            lblLitWord.AutoSize = true;
            lblLitWord.Location = new Point(26, 13);
            lblLitWord.Name = "lblLitWord";
            lblLitWord.Size = new Size(60, 25);
            lblLitWord.TabIndex = 4;
            lblLitWord.Text = "Word:";
            lblLitWord.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tblDefinitions
            // 
            tblDefinitions.ColumnCount = 4;
            tblDefinitions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.63866F));
            tblDefinitions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.2717056F));
            tblDefinitions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.5448151F));
            tblDefinitions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.5448151F));
            tblDefinitions.Controls.Add(lbl1, 0, 0);
            tblDefinitions.Controls.Add(lbl2, 0, 1);
            tblDefinitions.Controls.Add(lbl3, 0, 2);
            tblDefinitions.Controls.Add(lblDef1, 1, 0);
            tblDefinitions.Controls.Add(lblDef2, 1, 1);
            tblDefinitions.Controls.Add(lblDef3, 1, 2);
            tblDefinitions.Controls.Add(lblAnswer1, 2, 0);
            tblDefinitions.Controls.Add(lblAnswer2, 2, 1);
            tblDefinitions.Controls.Add(lblAnswer3, 2, 2);
            tblDefinitions.Dock = DockStyle.Fill;
            tblDefinitions.Location = new Point(3, 215);
            tblDefinitions.Name = "tblDefinitions";
            tblDefinitions.RowCount = 3;
            tblDefinitions.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblDefinitions.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblDefinitions.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblDefinitions.Size = new Size(794, 208);
            tblDefinitions.TabIndex = 6;
            // 
            // lbl1
            // 
            lbl1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl1.AutoSize = true;
            lbl1.ForeColor = Color.DeepPink;
            lbl1.Location = new Point(19, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(70, 25);
            lbl1.TabIndex = 0;
            lbl1.Text = "Def #1:";
            // 
            // lbl2
            // 
            lbl2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl2.AutoSize = true;
            lbl2.ForeColor = Color.DarkOrchid;
            lbl2.Location = new Point(19, 69);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(70, 25);
            lbl2.TabIndex = 1;
            lbl2.Text = "Def #2:";
            // 
            // lbl3
            // 
            lbl3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl3.AutoSize = true;
            lbl3.ForeColor = Color.DarkOrange;
            lbl3.Location = new Point(19, 138);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(70, 25);
            lbl3.TabIndex = 2;
            lbl3.Text = "Def #3:";
            // 
            // lblDef1
            // 
            lblDef1.AutoSize = true;
            lblDef1.BorderStyle = BorderStyle.FixedSingle;
            lblDef1.Dock = DockStyle.Fill;
            lblDef1.Location = new Point(95, 0);
            lblDef1.Name = "lblDef1";
            lblDef1.Size = new Size(305, 69);
            lblDef1.TabIndex = 3;
            // 
            // lblDef2
            // 
            lblDef2.AutoSize = true;
            lblDef2.BorderStyle = BorderStyle.FixedSingle;
            lblDef2.Dock = DockStyle.Fill;
            lblDef2.Location = new Point(95, 69);
            lblDef2.Name = "lblDef2";
            lblDef2.Size = new Size(305, 69);
            lblDef2.TabIndex = 4;
            // 
            // lblDef3
            // 
            lblDef3.AutoSize = true;
            lblDef3.BorderStyle = BorderStyle.FixedSingle;
            lblDef3.Dock = DockStyle.Fill;
            lblDef3.Location = new Point(95, 138);
            lblDef3.Name = "lblDef3";
            lblDef3.Size = new Size(305, 70);
            lblDef3.TabIndex = 5;
            // 
            // lblAnswer1
            // 
            lblAnswer1.AutoSize = true;
            lblAnswer1.BorderStyle = BorderStyle.FixedSingle;
            lblAnswer1.Dock = DockStyle.Fill;
            lblAnswer1.Location = new Point(406, 0);
            lblAnswer1.Name = "lblAnswer1";
            lblAnswer1.Size = new Size(188, 69);
            lblAnswer1.TabIndex = 6;
            lblAnswer1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAnswer2
            // 
            lblAnswer2.AutoSize = true;
            lblAnswer2.BorderStyle = BorderStyle.FixedSingle;
            lblAnswer2.Dock = DockStyle.Fill;
            lblAnswer2.Location = new Point(406, 69);
            lblAnswer2.Name = "lblAnswer2";
            lblAnswer2.Size = new Size(188, 69);
            lblAnswer2.TabIndex = 7;
            lblAnswer2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAnswer3
            // 
            lblAnswer3.AutoSize = true;
            lblAnswer3.BorderStyle = BorderStyle.FixedSingle;
            lblAnswer3.Dock = DockStyle.Fill;
            lblAnswer3.Location = new Point(406, 138);
            lblAnswer3.Name = "lblAnswer3";
            lblAnswer3.Size = new Size(188, 70);
            lblAnswer3.TabIndex = 8;
            lblAnswer3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Defineciando
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "Defineciando";
            Text = "Defineciando";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tblScore.ResumeLayout(false);
            tblScore.PerformLayout();
            pnlWord.ResumeLayout(false);
            pnlWord.PerformLayout();
            tblDefinitions.ResumeLayout(false);
            tblDefinitions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblInstructions;
        private Panel pnlFilter;
        private Label lblSpecificLetters;
        private Label lblNumOfLetters;
        private Label lblFilter;
        private TextBox txtSpecificLetters;
        private TextBox txtNumberOfLetters;
        private TableLayoutPanel tblButtons;
        private Button btnPickWord;
        private Button btnGiveUp;
        private Button btnEnter;
        private RadioButton rbDefinition1;
        private RadioButton rbDefinition2;
        private RadioButton rbDefinition3;
        private TableLayoutPanel tblScore;
        private Label lblWordsTried;
        private Label lblScore;
        private TextBox txtWordsTried;
        private TextBox txtScore;
        private Label lblLitWord;
        private Label lblFeedback;
        private Panel pnlWord;
        private Label lblWord;
        private TableLayoutPanel tblDefinitions;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lblDef1;
        private Label lblDef2;
        private Label lblDef3;
        private Label lblAnswer1;
        private Label lblAnswer2;
        private Label lblAnswer3;
    }
}