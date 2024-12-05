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
            tblMain.BackColor = Color.LightYellow;
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
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.46842766F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3788748F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.468428F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.468428F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.468428F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.468428F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.468428F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.468428F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.468428F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.468428F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.468428F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.468428F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.468428F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Dock = DockStyle.Fill;
            lblInstructions.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblInstructions.ForeColor = Color.DeepPink;
            lblInstructions.Location = new Point(3, 0);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(794, 33);
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
            pnlScore.Location = new Point(3, 82);
            pnlScore.Name = "pnlScore";
            pnlScore.Size = new Size(794, 27);
            pnlScore.TabIndex = 2;
            // 
            // txtRemainingTries
            // 
            txtRemainingTries.BackColor = Color.LightYellow;
            txtRemainingTries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRemainingTries.ForeColor = Color.LightPink;
            txtRemainingTries.Location = new Point(181, -6);
            txtRemainingTries.Name = "txtRemainingTries";
            txtRemainingTries.ReadOnly = true;
            txtRemainingTries.Size = new Size(125, 34);
            txtRemainingTries.TabIndex = 3;
            // 
            // lblRemainingTries
            // 
            lblRemainingTries.AutoSize = true;
            lblRemainingTries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRemainingTries.ForeColor = Color.LightPink;
            lblRemainingTries.Location = new Point(24, -3);
            lblRemainingTries.Name = "lblRemainingTries";
            lblRemainingTries.Size = new Size(151, 28);
            lblRemainingTries.TabIndex = 2;
            lblRemainingTries.Text = "Remaining Tries:";
            lblRemainingTries.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtScore
            // 
            txtScore.BackColor = Color.LightYellow;
            txtScore.ForeColor = Color.Pink;
            txtScore.Location = new Point(683, 0);
            txtScore.Name = "txtScore";
            txtScore.ReadOnly = true;
            txtScore.Size = new Size(125, 27);
            txtScore.TabIndex = 1;
            // 
            // lblScore
            // 
            lblScore.Anchor = AnchorStyles.None;
            lblScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.ForeColor = Color.LightPink;
            lblScore.Location = new Point(595, -1);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(82, 25);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score:";
            lblScore.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tblPlayAndStatus
            // 
            tblPlayAndStatus.BackColor = Color.LightPink;
            tblPlayAndStatus.ColumnCount = 3;
            tblPlayAndStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblPlayAndStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblPlayAndStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPlayAndStatus.Controls.Add(lblStatus, 2, 0);
            tblPlayAndStatus.Controls.Add(btnHint, 1, 0);
            tblPlayAndStatus.Controls.Add(btnStart, 0, 0);
            tblPlayAndStatus.Dock = DockStyle.Fill;
            tblPlayAndStatus.Location = new Point(3, 36);
            tblPlayAndStatus.Name = "tblPlayAndStatus";
            tblPlayAndStatus.RowCount = 1;
            tblPlayAndStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPlayAndStatus.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPlayAndStatus.Size = new Size(794, 40);
            tblPlayAndStatus.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.DeepPink;
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Dock = DockStyle.Right;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Transparent;
            lblStatus.Location = new Point(575, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(216, 40);
            lblStatus.TabIndex = 2;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHint
            // 
            btnHint.BackColor = Color.DeepPink;
            btnHint.Dock = DockStyle.Fill;
            btnHint.ForeColor = Color.Transparent;
            btnHint.Location = new Point(201, 3);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(192, 34);
            btnHint.TabIndex = 1;
            btnHint.Text = "Hint";
            btnHint.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DeepPink;
            btnStart.Dock = DockStyle.Fill;
            btnStart.ForeColor = Color.Transparent;
            btnStart.Location = new Point(3, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(192, 34);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // pnlFeedback
            // 
            pnlFeedback.Controls.Add(lblFeedback);
            pnlFeedback.Dock = DockStyle.Fill;
            pnlFeedback.Location = new Point(3, 115);
            pnlFeedback.Name = "pnlFeedback";
            pnlFeedback.Size = new Size(794, 27);
            pnlFeedback.TabIndex = 3;
            // 
            // lblFeedback
            // 
            lblFeedback.Dock = DockStyle.Fill;
            lblFeedback.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFeedback.ForeColor = Color.DeepPink;
            lblFeedback.Location = new Point(0, 0);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(794, 27);
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
            tblDisplayWord.Location = new Point(3, 148);
            tblDisplayWord.Name = "tblDisplayWord";
            tblDisplayWord.RowCount = 1;
            tblMain.SetRowSpan(tblDisplayWord, 2);
            tblDisplayWord.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblDisplayWord.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblDisplayWord.Size = new Size(794, 60);
            tblDisplayWord.TabIndex = 9;
            // 
            // lblDisplayWord
            // 
            lblDisplayWord.Dock = DockStyle.Fill;
            lblDisplayWord.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayWord.ForeColor = Color.DeepPink;
            lblDisplayWord.Location = new Point(3, 0);
            lblDisplayWord.Name = "lblDisplayWord";
            lblDisplayWord.Size = new Size(788, 60);
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
            tblLetterChoices.Location = new Point(3, 247);
            tblLetterChoices.Name = "tblLetterChoices";
            tblLetterChoices.RowCount = 5;
            tblMain.SetRowSpan(tblLetterChoices, 5);
            tblLetterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblLetterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblLetterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblLetterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblLetterChoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblLetterChoices.Size = new Size(794, 159);
            tblLetterChoices.TabIndex = 4;
            // 
            // btnA
            // 
            btnA.BackColor = Color.LightPink;
            btnA.Dock = DockStyle.Fill;
            btnA.ForeColor = Color.DeepPink;
            btnA.Location = new Point(73, 3);
            btnA.Name = "btnA";
            btnA.Size = new Size(102, 25);
            btnA.TabIndex = 0;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            btnB.BackColor = Color.LightPink;
            btnB.Dock = DockStyle.Fill;
            btnB.ForeColor = Color.DeepPink;
            btnB.Location = new Point(181, 3);
            btnB.Name = "btnB";
            btnB.Size = new Size(102, 25);
            btnB.TabIndex = 1;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            btnC.BackColor = Color.LightPink;
            btnC.Dock = DockStyle.Fill;
            btnC.ForeColor = Color.DeepPink;
            btnC.Location = new Point(289, 3);
            btnC.Name = "btnC";
            btnC.Size = new Size(102, 25);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            btnD.BackColor = Color.LightPink;
            btnD.Dock = DockStyle.Fill;
            btnD.ForeColor = Color.DeepPink;
            btnD.Location = new Point(397, 3);
            btnD.Name = "btnD";
            btnD.Size = new Size(102, 25);
            btnD.TabIndex = 3;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            btnE.BackColor = Color.LightPink;
            btnE.Dock = DockStyle.Fill;
            btnE.ForeColor = Color.DeepPink;
            btnE.Location = new Point(505, 3);
            btnE.Name = "btnE";
            btnE.Size = new Size(102, 25);
            btnE.TabIndex = 4;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = false;
            // 
            // btnF
            // 
            btnF.BackColor = Color.LightPink;
            btnF.Dock = DockStyle.Fill;
            btnF.ForeColor = Color.DeepPink;
            btnF.Location = new Point(613, 3);
            btnF.Name = "btnF";
            btnF.Size = new Size(102, 25);
            btnF.TabIndex = 5;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = false;
            // 
            // btnG
            // 
            btnG.BackColor = Color.LightPink;
            btnG.Dock = DockStyle.Fill;
            btnG.ForeColor = Color.DeepPink;
            btnG.Location = new Point(73, 34);
            btnG.Name = "btnG";
            btnG.Size = new Size(102, 25);
            btnG.TabIndex = 6;
            btnG.Text = "G";
            btnG.UseVisualStyleBackColor = false;
            // 
            // btnH
            // 
            btnH.BackColor = Color.LightPink;
            btnH.Dock = DockStyle.Fill;
            btnH.ForeColor = Color.DeepPink;
            btnH.Location = new Point(181, 34);
            btnH.Name = "btnH";
            btnH.Size = new Size(102, 25);
            btnH.TabIndex = 7;
            btnH.Text = "H";
            btnH.UseVisualStyleBackColor = false;
            // 
            // btnI
            // 
            btnI.BackColor = Color.LightPink;
            btnI.Dock = DockStyle.Fill;
            btnI.ForeColor = Color.DeepPink;
            btnI.Location = new Point(289, 34);
            btnI.Name = "btnI";
            btnI.Size = new Size(102, 25);
            btnI.TabIndex = 8;
            btnI.Text = "I";
            btnI.UseVisualStyleBackColor = false;
            // 
            // btnJ
            // 
            btnJ.BackColor = Color.LightPink;
            btnJ.Dock = DockStyle.Fill;
            btnJ.ForeColor = Color.DeepPink;
            btnJ.Location = new Point(397, 34);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(102, 25);
            btnJ.TabIndex = 9;
            btnJ.Text = "J";
            btnJ.UseVisualStyleBackColor = false;
            // 
            // btnK
            // 
            btnK.BackColor = Color.LightPink;
            btnK.Dock = DockStyle.Fill;
            btnK.ForeColor = Color.DeepPink;
            btnK.Location = new Point(505, 34);
            btnK.Name = "btnK";
            btnK.Size = new Size(102, 25);
            btnK.TabIndex = 10;
            btnK.Text = "K";
            btnK.UseVisualStyleBackColor = false;
            // 
            // btnL
            // 
            btnL.BackColor = Color.LightPink;
            btnL.Dock = DockStyle.Fill;
            btnL.ForeColor = Color.DeepPink;
            btnL.Location = new Point(613, 34);
            btnL.Name = "btnL";
            btnL.Size = new Size(102, 25);
            btnL.TabIndex = 11;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = false;
            // 
            // btnM
            // 
            btnM.BackColor = Color.LightPink;
            btnM.Dock = DockStyle.Fill;
            btnM.ForeColor = Color.DeepPink;
            btnM.Location = new Point(73, 65);
            btnM.Name = "btnM";
            btnM.Size = new Size(102, 25);
            btnM.TabIndex = 12;
            btnM.Text = "M";
            btnM.UseVisualStyleBackColor = false;
            // 
            // btnN
            // 
            btnN.BackColor = Color.LightPink;
            btnN.Dock = DockStyle.Fill;
            btnN.ForeColor = Color.DeepPink;
            btnN.Location = new Point(181, 65);
            btnN.Name = "btnN";
            btnN.Size = new Size(102, 25);
            btnN.TabIndex = 13;
            btnN.Text = "N";
            btnN.UseVisualStyleBackColor = false;
            // 
            // btnO
            // 
            btnO.BackColor = Color.LightPink;
            btnO.Dock = DockStyle.Fill;
            btnO.ForeColor = Color.DeepPink;
            btnO.Location = new Point(289, 65);
            btnO.Name = "btnO";
            btnO.Size = new Size(102, 25);
            btnO.TabIndex = 14;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = false;
            // 
            // btnP
            // 
            btnP.BackColor = Color.LightPink;
            btnP.Dock = DockStyle.Fill;
            btnP.ForeColor = Color.DeepPink;
            btnP.Location = new Point(397, 65);
            btnP.Name = "btnP";
            btnP.Size = new Size(102, 25);
            btnP.TabIndex = 15;
            btnP.Text = "P";
            btnP.UseVisualStyleBackColor = false;
            // 
            // btnQ
            // 
            btnQ.BackColor = Color.LightPink;
            btnQ.Dock = DockStyle.Fill;
            btnQ.ForeColor = Color.DeepPink;
            btnQ.Location = new Point(505, 65);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(102, 25);
            btnQ.TabIndex = 16;
            btnQ.Text = "Q";
            btnQ.UseVisualStyleBackColor = false;
            // 
            // btnR
            // 
            btnR.BackColor = Color.LightPink;
            btnR.Dock = DockStyle.Fill;
            btnR.ForeColor = Color.DeepPink;
            btnR.Location = new Point(613, 65);
            btnR.Name = "btnR";
            btnR.Size = new Size(102, 25);
            btnR.TabIndex = 17;
            btnR.Text = "R";
            btnR.UseVisualStyleBackColor = false;
            // 
            // btnS
            // 
            btnS.BackColor = Color.LightPink;
            btnS.Dock = DockStyle.Fill;
            btnS.ForeColor = Color.DeepPink;
            btnS.Location = new Point(73, 96);
            btnS.Name = "btnS";
            btnS.Size = new Size(102, 25);
            btnS.TabIndex = 18;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = false;
            // 
            // btnT
            // 
            btnT.BackColor = Color.LightPink;
            btnT.Dock = DockStyle.Fill;
            btnT.ForeColor = Color.DeepPink;
            btnT.Location = new Point(181, 96);
            btnT.Name = "btnT";
            btnT.Size = new Size(102, 25);
            btnT.TabIndex = 19;
            btnT.Text = "T";
            btnT.UseVisualStyleBackColor = false;
            // 
            // btnU
            // 
            btnU.BackColor = Color.LightPink;
            btnU.Dock = DockStyle.Fill;
            btnU.ForeColor = Color.DeepPink;
            btnU.Location = new Point(289, 96);
            btnU.Name = "btnU";
            btnU.Size = new Size(102, 25);
            btnU.TabIndex = 20;
            btnU.Text = "U";
            btnU.UseVisualStyleBackColor = false;
            // 
            // btnV
            // 
            btnV.BackColor = Color.LightPink;
            btnV.Dock = DockStyle.Fill;
            btnV.ForeColor = Color.DeepPink;
            btnV.Location = new Point(397, 96);
            btnV.Name = "btnV";
            btnV.Size = new Size(102, 25);
            btnV.TabIndex = 21;
            btnV.Text = "V";
            btnV.UseVisualStyleBackColor = false;
            // 
            // btnW
            // 
            btnW.BackColor = Color.LightPink;
            btnW.Dock = DockStyle.Fill;
            btnW.ForeColor = Color.DeepPink;
            btnW.Location = new Point(505, 96);
            btnW.Name = "btnW";
            btnW.Size = new Size(102, 25);
            btnW.TabIndex = 22;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = false;
            // 
            // btnX
            // 
            btnX.BackColor = Color.LightPink;
            btnX.Dock = DockStyle.Fill;
            btnX.ForeColor = Color.DeepPink;
            btnX.Location = new Point(613, 96);
            btnX.Name = "btnX";
            btnX.Size = new Size(102, 25);
            btnX.TabIndex = 23;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            // 
            // btnZ
            // 
            btnZ.BackColor = Color.LightPink;
            btnZ.Dock = DockStyle.Fill;
            btnZ.ForeColor = Color.DeepPink;
            btnZ.Location = new Point(397, 127);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(102, 29);
            btnZ.TabIndex = 25;
            btnZ.Text = "Z";
            btnZ.UseVisualStyleBackColor = false;
            // 
            // btnY
            // 
            btnY.BackColor = Color.LightPink;
            btnY.Dock = DockStyle.Fill;
            btnY.ForeColor = Color.DeepPink;
            btnY.Location = new Point(289, 127);
            btnY.Name = "btnY";
            btnY.Size = new Size(102, 29);
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