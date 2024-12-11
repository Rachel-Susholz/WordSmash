namespace WordSmashApp
{
    partial class WordSmash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordSmash));
            tblMain = new TableLayoutPanel();
            lblInstructions = new Label();
            pnlScore = new Panel();
            txtRemainingTries = new TextBox();
            lblRemainingTries = new Label();
            txtScore = new TextBox();
            lblScore = new Label();
            tblPlayAndStatus = new TableLayoutPanel();
            lblStatus = new Label();
            btnHint = new Button();
            btnStart = new Button();
            pnlFeedback = new Panel();
            lblFeedback = new Label();
            tblDisplayWord = new TableLayoutPanel();
            lblDisplayWord = new Label();
            tblLetterChoices = new TableLayoutPanel();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnE = new Button();
            btnF = new Button();
            btnG = new Button();
            btnH = new Button();
            btnI = new Button();
            btnJ = new Button();
            btnK = new Button();
            btnL = new Button();
            btnM = new Button();
            btnN = new Button();
            btnO = new Button();
            btnP = new Button();
            btnQ = new Button();
            btnR = new Button();
            btnS = new Button();
            btnT = new Button();
            btnU = new Button();
            btnV = new Button();
            btnW = new Button();
            btnX = new Button();
            btnZ = new Button();
            btnY = new Button();
            tblMain.SuspendLayout();
            pnlScore.SuspendLayout();
            tblPlayAndStatus.SuspendLayout();
            pnlFeedback.SuspendLayout();
            tblDisplayWord.SuspendLayout();
            tblLetterChoices.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblMain.BackColor = Color.LightPink;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblInstructions, 0, 0);
            tblMain.Controls.Add(pnlScore, 0, 2);
            tblMain.Controls.Add(tblPlayAndStatus, 0, 1);
            tblMain.Controls.Add(pnlFeedback, 0, 3);
            tblMain.Controls.Add(tblDisplayWord, 0, 4);
            tblMain.Controls.Add(tblLetterChoices, 0, 7);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 13;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.270827F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5431871F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.296165F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.296165F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 3.93630171F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 3.93630171F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 3.7086277F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.660758F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.660758F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.660758F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.660758F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.660758F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 3.7086277F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.BackColor = Color.LightPink;
            lblInstructions.Dock = DockStyle.Fill;
            lblInstructions.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblInstructions.ForeColor = Color.DarkBlue;
            lblInstructions.Location = new Point(3, 0);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(794, 28);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = "Smash the Buttons to Find the Hidden Word!";
            lblInstructions.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlScore
            // 
            pnlScore.Controls.Add(txtRemainingTries);
            pnlScore.Controls.Add(lblRemainingTries);
            pnlScore.Controls.Add(txtScore);
            pnlScore.Controls.Add(lblScore);
            pnlScore.Dock = DockStyle.Fill;
            pnlScore.Location = new Point(3, 78);
            pnlScore.Name = "pnlScore";
            pnlScore.Size = new Size(794, 26);
            pnlScore.TabIndex = 2;
            // 
            // txtRemainingTries
            // 
            txtRemainingTries.Anchor = AnchorStyles.Left;
            txtRemainingTries.BackColor = Color.LightPink;
            txtRemainingTries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRemainingTries.ForeColor = Color.DarkBlue;
            txtRemainingTries.Location = new Point(181, -5);
            txtRemainingTries.Name = "txtRemainingTries";
            txtRemainingTries.ReadOnly = true;
            txtRemainingTries.Size = new Size(125, 34);
            txtRemainingTries.TabIndex = 3;
            // 
            // lblRemainingTries
            // 
            lblRemainingTries.Anchor = AnchorStyles.Left;
            lblRemainingTries.AutoSize = true;
            lblRemainingTries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRemainingTries.ForeColor = Color.DarkBlue;
            lblRemainingTries.Location = new Point(24, -2);
            lblRemainingTries.Name = "lblRemainingTries";
            lblRemainingTries.Size = new Size(151, 28);
            lblRemainingTries.TabIndex = 2;
            lblRemainingTries.Text = "Remaining Tries:";
            lblRemainingTries.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtScore
            // 
            txtScore.Anchor = AnchorStyles.Right;
            txtScore.BackColor = Color.LightPink;
            txtScore.Enabled = false;
            txtScore.ForeColor = Color.DarkBlue;
            txtScore.Location = new Point(669, 1);
            txtScore.Name = "txtScore";
            txtScore.ReadOnly = true;
            txtScore.Size = new Size(125, 27);
            txtScore.TabIndex = 1;
            // 
            // lblScore
            // 
            lblScore.Anchor = AnchorStyles.Right;
            lblScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.ForeColor = Color.DarkBlue;
            lblScore.Location = new Point(595, -1);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(68, 25);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score:";
            lblScore.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tblPlayAndStatus
            // 
            tblPlayAndStatus.BackColor = Color.Red;
            tblPlayAndStatus.ColumnCount = 3;
            tblPlayAndStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblPlayAndStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblPlayAndStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPlayAndStatus.Controls.Add(lblStatus, 2, 0);
            tblPlayAndStatus.Controls.Add(btnHint, 1, 0);
            tblPlayAndStatus.Controls.Add(btnStart, 0, 0);
            tblPlayAndStatus.Dock = DockStyle.Fill;
            tblPlayAndStatus.Location = new Point(3, 31);
            tblPlayAndStatus.Name = "tblPlayAndStatus";
            tblPlayAndStatus.RowCount = 1;
            tblPlayAndStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPlayAndStatus.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPlayAndStatus.Size = new Size(794, 41);
            tblPlayAndStatus.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Red;
            lblStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.DarkBlue;
            lblStatus.Location = new Point(791, 6);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 28);
            lblStatus.TabIndex = 2;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHint
            // 
            btnHint.BackColor = Color.Lime;
            btnHint.Dock = DockStyle.Fill;
            btnHint.ForeColor = Color.DarkBlue;
            btnHint.Location = new Point(201, 3);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(192, 35);
            btnHint.TabIndex = 1;
            btnHint.Text = "Hint";
            btnHint.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Lime;
            btnStart.Dock = DockStyle.Fill;
            btnStart.ForeColor = Color.DarkBlue;
            btnStart.Location = new Point(3, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(192, 35);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // pnlFeedback
            // 
            pnlFeedback.Controls.Add(lblFeedback);
            pnlFeedback.Dock = DockStyle.Fill;
            pnlFeedback.Location = new Point(3, 110);
            pnlFeedback.Name = "pnlFeedback";
            pnlFeedback.Size = new Size(794, 26);
            pnlFeedback.TabIndex = 3;
            // 
            // lblFeedback
            // 
            lblFeedback.Dock = DockStyle.Fill;
            lblFeedback.Font = new Font("Tempus Sans ITC", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFeedback.ForeColor = Color.DarkBlue;
            lblFeedback.Location = new Point(0, 0);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(794, 26);
            lblFeedback.TabIndex = 0;
            lblFeedback.Text = "Click Start To Begin";
            lblFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblDisplayWord
            // 
            tblDisplayWord.ColumnCount = 1;
            tblDisplayWord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDisplayWord.Controls.Add(lblDisplayWord, 0, 0);
            tblDisplayWord.Dock = DockStyle.Fill;
            tblDisplayWord.Location = new Point(3, 142);
            tblDisplayWord.Name = "tblDisplayWord";
            tblDisplayWord.RowCount = 1;
            tblMain.SetRowSpan(tblDisplayWord, 2);
            tblDisplayWord.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblDisplayWord.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblDisplayWord.Size = new Size(794, 28);
            tblDisplayWord.TabIndex = 9;
            // 
            // lblDisplayWord
            // 
            lblDisplayWord.Dock = DockStyle.Fill;
            lblDisplayWord.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayWord.ForeColor = Color.Red;
            lblDisplayWord.Location = new Point(3, 0);
            lblDisplayWord.Name = "lblDisplayWord";
            lblDisplayWord.Size = new Size(788, 28);
            lblDisplayWord.TabIndex = 0;
            lblDisplayWord.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tblLetterChoices
            // 
            tblLetterChoices.ColumnCount = 8;
            tblLetterChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.885185F));
            tblLetterChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.7049379F));
            tblLetterChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.7049379F));
            tblLetterChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.7049379F));
            tblLetterChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.7049379F));
            tblLetterChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.7049379F));
            tblLetterChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.7049379F));
            tblLetterChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.885185F));
            tblLetterChoices.Controls.Add(btnA, 1, 0);
            tblLetterChoices.Controls.Add(btnB, 2, 0);
            tblLetterChoices.Controls.Add(btnC, 3, 0);
            tblLetterChoices.Controls.Add(btnD, 4, 0);
            tblLetterChoices.Controls.Add(btnE, 5, 0);
            tblLetterChoices.Controls.Add(btnF, 6, 0);
            tblLetterChoices.Controls.Add(btnG, 1, 1);
            tblLetterChoices.Controls.Add(btnH, 2, 1);
            tblLetterChoices.Controls.Add(btnI, 3, 1);
            tblLetterChoices.Controls.Add(btnJ, 4, 1);
            tblLetterChoices.Controls.Add(btnK, 5, 1);
            tblLetterChoices.Controls.Add(btnL, 6, 1);
            tblLetterChoices.Controls.Add(btnM, 1, 2);
            tblLetterChoices.Controls.Add(btnN, 2, 2);
            tblLetterChoices.Controls.Add(btnO, 3, 2);
            tblLetterChoices.Controls.Add(btnP, 4, 2);
            tblLetterChoices.Controls.Add(btnQ, 5, 2);
            tblLetterChoices.Controls.Add(btnR, 6, 2);
            tblLetterChoices.Controls.Add(btnS, 1, 3);
            tblLetterChoices.Controls.Add(btnT, 2, 3);
            tblLetterChoices.Controls.Add(btnU, 3, 3);
            tblLetterChoices.Controls.Add(btnV, 4, 3);
            tblLetterChoices.Controls.Add(btnW, 5, 3);
            tblLetterChoices.Controls.Add(btnX, 6, 3);
            tblLetterChoices.Controls.Add(btnZ, 4, 4);
            tblLetterChoices.Controls.Add(btnY, 3, 4);
            tblLetterChoices.Dock = DockStyle.Fill;
            tblLetterChoices.Location = new Point(3, 192);
            tblLetterChoices.Name = "tblLetterChoices";
            tblLetterChoices.RowCount = 5;
            tblMain.SetRowSpan(tblLetterChoices, 5);
            tblLetterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblLetterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblLetterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblLetterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblLetterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblLetterChoices.Size = new Size(794, 229);
            tblLetterChoices.TabIndex = 4;
            // 
            // btnA
            // 
            btnA.BackColor = Color.Lime;
            btnA.Dock = DockStyle.Fill;
            btnA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnA.ForeColor = Color.DarkBlue;
            btnA.Location = new Point(73, 3);
            btnA.Name = "btnA";
            btnA.Size = new Size(102, 39);
            btnA.TabIndex = 0;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            btnB.BackColor = Color.Lime;
            btnB.Dock = DockStyle.Fill;
            btnB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnB.ForeColor = Color.DarkBlue;
            btnB.Location = new Point(181, 3);
            btnB.Name = "btnB";
            btnB.Size = new Size(102, 39);
            btnB.TabIndex = 1;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Lime;
            btnC.Dock = DockStyle.Fill;
            btnC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnC.ForeColor = Color.DarkBlue;
            btnC.Location = new Point(289, 3);
            btnC.Name = "btnC";
            btnC.Size = new Size(102, 39);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            btnD.BackColor = Color.Lime;
            btnD.Dock = DockStyle.Fill;
            btnD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnD.ForeColor = Color.DarkBlue;
            btnD.Location = new Point(397, 3);
            btnD.Name = "btnD";
            btnD.Size = new Size(102, 39);
            btnD.TabIndex = 3;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            btnE.BackColor = Color.Lime;
            btnE.Dock = DockStyle.Fill;
            btnE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnE.ForeColor = Color.DarkBlue;
            btnE.Location = new Point(505, 3);
            btnE.Name = "btnE";
            btnE.Size = new Size(102, 39);
            btnE.TabIndex = 4;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = false;
            // 
            // btnF
            // 
            btnF.BackColor = Color.Lime;
            btnF.Dock = DockStyle.Fill;
            btnF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnF.ForeColor = Color.DarkBlue;
            btnF.Location = new Point(613, 3);
            btnF.Name = "btnF";
            btnF.Size = new Size(102, 39);
            btnF.TabIndex = 5;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = false;
            // 
            // btnG
            // 
            btnG.BackColor = Color.Lime;
            btnG.Dock = DockStyle.Fill;
            btnG.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnG.ForeColor = Color.DarkBlue;
            btnG.Location = new Point(73, 48);
            btnG.Name = "btnG";
            btnG.Size = new Size(102, 39);
            btnG.TabIndex = 6;
            btnG.Text = "G";
            btnG.UseVisualStyleBackColor = false;
            // 
            // btnH
            // 
            btnH.BackColor = Color.Lime;
            btnH.Dock = DockStyle.Fill;
            btnH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnH.ForeColor = Color.DarkBlue;
            btnH.Location = new Point(181, 48);
            btnH.Name = "btnH";
            btnH.Size = new Size(102, 39);
            btnH.TabIndex = 7;
            btnH.Text = "H";
            btnH.UseVisualStyleBackColor = false;
            // 
            // btnI
            // 
            btnI.BackColor = Color.Lime;
            btnI.Dock = DockStyle.Fill;
            btnI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnI.ForeColor = Color.DarkBlue;
            btnI.Location = new Point(289, 48);
            btnI.Name = "btnI";
            btnI.Size = new Size(102, 39);
            btnI.TabIndex = 8;
            btnI.Text = "I";
            btnI.UseVisualStyleBackColor = false;
            // 
            // btnJ
            // 
            btnJ.BackColor = Color.Lime;
            btnJ.Dock = DockStyle.Fill;
            btnJ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnJ.ForeColor = Color.DarkBlue;
            btnJ.Location = new Point(397, 48);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(102, 39);
            btnJ.TabIndex = 9;
            btnJ.Text = "J";
            btnJ.UseVisualStyleBackColor = false;
            // 
            // btnK
            // 
            btnK.BackColor = Color.Lime;
            btnK.Dock = DockStyle.Fill;
            btnK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnK.ForeColor = Color.DarkBlue;
            btnK.Location = new Point(505, 48);
            btnK.Name = "btnK";
            btnK.Size = new Size(102, 39);
            btnK.TabIndex = 10;
            btnK.Text = "K";
            btnK.UseVisualStyleBackColor = false;
            // 
            // btnL
            // 
            btnL.BackColor = Color.Lime;
            btnL.Dock = DockStyle.Fill;
            btnL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnL.ForeColor = Color.DarkBlue;
            btnL.Location = new Point(613, 48);
            btnL.Name = "btnL";
            btnL.Size = new Size(102, 39);
            btnL.TabIndex = 11;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = false;
            // 
            // btnM
            // 
            btnM.BackColor = Color.Lime;
            btnM.Dock = DockStyle.Fill;
            btnM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnM.ForeColor = Color.DarkBlue;
            btnM.Location = new Point(73, 93);
            btnM.Name = "btnM";
            btnM.Size = new Size(102, 39);
            btnM.TabIndex = 12;
            btnM.Text = "M";
            btnM.UseVisualStyleBackColor = false;
            // 
            // btnN
            // 
            btnN.BackColor = Color.Lime;
            btnN.Dock = DockStyle.Fill;
            btnN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnN.ForeColor = Color.DarkBlue;
            btnN.Location = new Point(181, 93);
            btnN.Name = "btnN";
            btnN.Size = new Size(102, 39);
            btnN.TabIndex = 13;
            btnN.Text = "N";
            btnN.UseVisualStyleBackColor = false;
            // 
            // btnO
            // 
            btnO.BackColor = Color.Lime;
            btnO.Dock = DockStyle.Fill;
            btnO.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnO.ForeColor = Color.DarkBlue;
            btnO.Location = new Point(289, 93);
            btnO.Name = "btnO";
            btnO.Size = new Size(102, 39);
            btnO.TabIndex = 14;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = false;
            // 
            // btnP
            // 
            btnP.BackColor = Color.Lime;
            btnP.Dock = DockStyle.Fill;
            btnP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnP.ForeColor = Color.DarkBlue;
            btnP.Location = new Point(397, 93);
            btnP.Name = "btnP";
            btnP.Size = new Size(102, 39);
            btnP.TabIndex = 15;
            btnP.Text = "P";
            btnP.UseVisualStyleBackColor = false;
            // 
            // btnQ
            // 
            btnQ.BackColor = Color.Lime;
            btnQ.Dock = DockStyle.Fill;
            btnQ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ.ForeColor = Color.DarkBlue;
            btnQ.Location = new Point(505, 93);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(102, 39);
            btnQ.TabIndex = 16;
            btnQ.Text = "Q";
            btnQ.UseVisualStyleBackColor = false;
            // 
            // btnR
            // 
            btnR.BackColor = Color.Lime;
            btnR.Dock = DockStyle.Fill;
            btnR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnR.ForeColor = Color.DarkBlue;
            btnR.Location = new Point(613, 93);
            btnR.Name = "btnR";
            btnR.Size = new Size(102, 39);
            btnR.TabIndex = 17;
            btnR.Text = "R";
            btnR.UseVisualStyleBackColor = false;
            // 
            // btnS
            // 
            btnS.BackColor = Color.Lime;
            btnS.Dock = DockStyle.Fill;
            btnS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnS.ForeColor = Color.DarkBlue;
            btnS.Location = new Point(73, 138);
            btnS.Name = "btnS";
            btnS.Size = new Size(102, 39);
            btnS.TabIndex = 18;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = false;
            // 
            // btnT
            // 
            btnT.BackColor = Color.Lime;
            btnT.Dock = DockStyle.Fill;
            btnT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnT.ForeColor = Color.DarkBlue;
            btnT.Location = new Point(181, 138);
            btnT.Name = "btnT";
            btnT.Size = new Size(102, 39);
            btnT.TabIndex = 19;
            btnT.Text = "T";
            btnT.UseVisualStyleBackColor = false;
            // 
            // btnU
            // 
            btnU.BackColor = Color.Lime;
            btnU.Dock = DockStyle.Fill;
            btnU.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnU.ForeColor = Color.DarkBlue;
            btnU.Location = new Point(289, 138);
            btnU.Name = "btnU";
            btnU.Size = new Size(102, 39);
            btnU.TabIndex = 20;
            btnU.Text = "U";
            btnU.UseVisualStyleBackColor = false;
            // 
            // btnV
            // 
            btnV.BackColor = Color.Lime;
            btnV.Dock = DockStyle.Fill;
            btnV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnV.ForeColor = Color.DarkBlue;
            btnV.Location = new Point(397, 138);
            btnV.Name = "btnV";
            btnV.Size = new Size(102, 39);
            btnV.TabIndex = 21;
            btnV.Text = "V";
            btnV.UseVisualStyleBackColor = false;
            // 
            // btnW
            // 
            btnW.BackColor = Color.Lime;
            btnW.Dock = DockStyle.Fill;
            btnW.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnW.ForeColor = Color.DarkBlue;
            btnW.Location = new Point(505, 138);
            btnW.Name = "btnW";
            btnW.Size = new Size(102, 39);
            btnW.TabIndex = 22;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = false;
            // 
            // btnX
            // 
            btnX.BackColor = Color.Lime;
            btnX.Dock = DockStyle.Fill;
            btnX.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnX.ForeColor = Color.DarkBlue;
            btnX.Location = new Point(613, 138);
            btnX.Name = "btnX";
            btnX.Size = new Size(102, 39);
            btnX.TabIndex = 23;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            // 
            // btnZ
            // 
            btnZ.BackColor = Color.Lime;
            btnZ.Dock = DockStyle.Fill;
            btnZ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnZ.ForeColor = Color.DarkBlue;
            btnZ.Location = new Point(397, 183);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(102, 43);
            btnZ.TabIndex = 25;
            btnZ.Text = "Z";
            btnZ.UseVisualStyleBackColor = false;
            // 
            // btnY
            // 
            btnY.BackColor = Color.Lime;
            btnY.Dock = DockStyle.Fill;
            btnY.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnY.ForeColor = Color.DarkBlue;
            btnY.Location = new Point(289, 183);
            btnY.Name = "btnY";
            btnY.Size = new Size(102, 43);
            btnY.TabIndex = 24;
            btnY.Text = "Y";
            btnY.UseVisualStyleBackColor = false;
            // 
            // WordSmash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WordSmash";
            Text = "Word Smash";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            pnlScore.ResumeLayout(false);
            pnlScore.PerformLayout();
            tblPlayAndStatus.ResumeLayout(false);
            tblPlayAndStatus.PerformLayout();
            pnlFeedback.ResumeLayout(false);
            tblDisplayWord.ResumeLayout(false);
            tblLetterChoices.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblInstructions;
        private Label lblStatus;
        private Button btnHint;
        private Button btnStart;
        private Panel pnlScore;
        private Label lblScore;
        private TextBox txtScore;
        private TableLayoutPanel tblPlayAndStatus;
        private Panel pnlFeedback;
        private Label lblFeedback;
        private TableLayoutPanel tblDisplayWord;
        private Label lblDisplayWord;
        private TableLayoutPanel tblLetterChoices;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnE;
        private Button btnF;
        private Button btnG;
        private Button btnH;
        private Button btnI;
        private Button btnJ;
        private Button btnK;
        private Button btnL;
        private Button btnM;
        private Button btnN;
        private Button btnO;
        private Button btnP;
        private Button btnQ;
        private Button btnR;
        private Button btnS;
        private Button btnT;
        private Button btnU;
        private Button btnV;
        private Button btnW;
        private Button btnX;
        private Button btnZ;
        private Button btnY;
        private TextBox txtRemainingTries;
        private Label lblRemainingTries;
        
    }
}