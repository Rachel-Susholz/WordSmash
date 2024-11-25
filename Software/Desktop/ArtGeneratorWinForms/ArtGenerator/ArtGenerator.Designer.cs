namespace ArtGenerator
{
    partial class ArtGenerator
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
            tblControls = new TableLayoutPanel();
            pnlShapes = new Panel();
            rbtShapeDisplayTime = new RadioButton();
            rbtShapeFrequency = new RadioButton();
            rbtShapeCount = new RadioButton();
            txtShapeCount = new TextBox();
            txtShapeFrequency = new TextBox();
            txtShapeDisplayTime = new TextBox();
            lblSettings = new Label();
            lblShapes = new Label();
            lblColorRange = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblRed = new Label();
            lblGreen = new Label();
            lblBlue = new Label();
            lblMinRed = new Label();
            lblMinGreen = new Label();
            lblMinBlue = new Label();
            txtMinRed = new TextBox();
            txtMinGreen = new TextBox();
            txtMinBlue = new TextBox();
            lblMaxRed = new Label();
            lblMaxGreen = new Label();
            lblMaxBlue = new Label();
            txtMaxRed = new TextBox();
            txtMaxGreen = new TextBox();
            txtMaxBlue = new TextBox();
            lblSize = new Label();
            tblSize = new TableLayoutPanel();
            lblHeight = new Label();
            lblWidth = new Label();
            lblMinHeight = new Label();
            lblMinWidth = new Label();
            lblMaxHeight = new Label();
            lblMaxWidth = new Label();
            txtMinHeight = new TextBox();
            txtMinWidth = new TextBox();
            txtMaxHeight = new TextBox();
            txtMaxWidth = new TextBox();
            btnStart = new Button();
            btnClearShapes = new Button();
            btnRefreshColor = new Button();
            pnlShape = new Panel();
            tblMain.SuspendLayout();
            tblControls.SuspendLayout();
            pnlShapes.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tblSize.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.8917351F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.10827F));
            tblMain.Controls.Add(tblControls, 0, 0);
            tblMain.Controls.Add(pnlShape, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // tblControls
            // 
            tblControls.ColumnCount = 3;
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblControls.Controls.Add(pnlShapes, 0, 2);
            tblControls.Controls.Add(txtShapeCount, 2, 2);
            tblControls.Controls.Add(txtShapeFrequency, 2, 3);
            tblControls.Controls.Add(txtShapeDisplayTime, 2, 4);
            tblControls.Controls.Add(lblSettings, 0, 0);
            tblControls.Controls.Add(lblShapes, 0, 1);
            tblControls.Controls.Add(lblColorRange, 0, 5);
            tblControls.Controls.Add(tableLayoutPanel1, 0, 6);
            tblControls.Controls.Add(lblSize, 0, 9);
            tblControls.Controls.Add(tblSize, 0, 10);
            tblControls.Controls.Add(btnStart, 0, 12);
            tblControls.Controls.Add(btnClearShapes, 1, 12);
            tblControls.Controls.Add(btnRefreshColor, 2, 12);
            tblControls.Dock = DockStyle.Fill;
            tblControls.Location = new Point(3, 3);
            tblControls.Name = "tblControls";
            tblControls.RowCount = 13;
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 7.472927F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 7.47058439F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 7.47058439F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 7.47058439F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 7.47058439F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 7.47058439F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 7.47058439F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 7.47058439F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 7.47058439F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 7.47058439F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 7.47058439F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 7.47058439F));
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3506451F));
            tblControls.Size = new Size(337, 444);
            tblControls.TabIndex = 0;
            // 
            // pnlShapes
            // 
            tblControls.SetColumnSpan(pnlShapes, 2);
            pnlShapes.Controls.Add(rbtShapeDisplayTime);
            pnlShapes.Controls.Add(rbtShapeFrequency);
            pnlShapes.Controls.Add(rbtShapeCount);
            pnlShapes.Dock = DockStyle.Fill;
            pnlShapes.Location = new Point(3, 69);
            pnlShapes.Name = "pnlShapes";
            tblControls.SetRowSpan(pnlShapes, 3);
            pnlShapes.Size = new Size(218, 93);
            pnlShapes.TabIndex = 2;
            // 
            // rbtShapeDisplayTime
            // 
            rbtShapeDisplayTime.AutoSize = true;
            rbtShapeDisplayTime.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtShapeDisplayTime.Location = new Point(6, 70);
            rbtShapeDisplayTime.Name = "rbtShapeDisplayTime";
            rbtShapeDisplayTime.Size = new Size(185, 21);
            rbtShapeDisplayTime.TabIndex = 2;
            rbtShapeDisplayTime.TabStop = true;
            rbtShapeDisplayTime.Text = "Add Shapes For x Seconds";
            rbtShapeDisplayTime.UseVisualStyleBackColor = true;
            // 
            // rbtShapeFrequency
            // 
            rbtShapeFrequency.AutoSize = true;
            rbtShapeFrequency.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtShapeFrequency.Location = new Point(6, 36);
            rbtShapeFrequency.Name = "rbtShapeFrequency";
            rbtShapeFrequency.Size = new Size(214, 21);
            rbtShapeFrequency.TabIndex = 1;
            rbtShapeFrequency.TabStop = true;
            rbtShapeFrequency.Text = "Add Shape Every x Milliseconds";
            rbtShapeFrequency.UseVisualStyleBackColor = true;
            // 
            // rbtShapeCount
            // 
            rbtShapeCount.AutoSize = true;
            rbtShapeCount.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtShapeCount.Location = new Point(6, 3);
            rbtShapeCount.Name = "rbtShapeCount";
            rbtShapeCount.Size = new Size(187, 21);
            rbtShapeCount.TabIndex = 0;
            rbtShapeCount.TabStop = true;
            rbtShapeCount.Text = "Specific Number of Shapes";
            rbtShapeCount.UseVisualStyleBackColor = true;
            // 
            // txtShapeCount
            // 
            txtShapeCount.BorderStyle = BorderStyle.FixedSingle;
            txtShapeCount.Dock = DockStyle.Fill;
            txtShapeCount.Location = new Point(227, 69);
            txtShapeCount.Name = "txtShapeCount";
            txtShapeCount.PlaceholderText = " # of shapes";
            txtShapeCount.Size = new Size(107, 27);
            txtShapeCount.TabIndex = 3;
            // 
            // txtShapeFrequency
            // 
            txtShapeFrequency.BorderStyle = BorderStyle.FixedSingle;
            txtShapeFrequency.Dock = DockStyle.Top;
            txtShapeFrequency.Location = new Point(227, 102);
            txtShapeFrequency.Name = "txtShapeFrequency";
            txtShapeFrequency.PlaceholderText = " # of milliseconds";
            txtShapeFrequency.Size = new Size(107, 27);
            txtShapeFrequency.TabIndex = 4;
            // 
            // txtShapeDisplayTime
            // 
            txtShapeDisplayTime.BorderStyle = BorderStyle.FixedSingle;
            txtShapeDisplayTime.Dock = DockStyle.Fill;
            txtShapeDisplayTime.Location = new Point(227, 135);
            txtShapeDisplayTime.Name = "txtShapeDisplayTime";
            txtShapeDisplayTime.PlaceholderText = " # of seconds";
            txtShapeDisplayTime.Size = new Size(107, 27);
            txtShapeDisplayTime.TabIndex = 5;
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            tblControls.SetColumnSpan(lblSettings, 3);
            lblSettings.Dock = DockStyle.Fill;
            lblSettings.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSettings.Location = new Point(3, 0);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(331, 33);
            lblSettings.TabIndex = 6;
            lblSettings.Text = "Art Generator Settings";
            lblSettings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShapes
            // 
            lblShapes.AutoSize = true;
            lblShapes.Dock = DockStyle.Fill;
            lblShapes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblShapes.Location = new Point(3, 33);
            lblShapes.Name = "lblShapes";
            lblShapes.Size = new Size(106, 33);
            lblShapes.TabIndex = 7;
            lblShapes.Text = "Shapes";
            lblShapes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblColorRange
            // 
            lblColorRange.AutoSize = true;
            tblControls.SetColumnSpan(lblColorRange, 2);
            lblColorRange.Dock = DockStyle.Fill;
            lblColorRange.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblColorRange.Location = new Point(3, 165);
            lblColorRange.Name = "lblColorRange";
            lblColorRange.Size = new Size(218, 33);
            lblColorRange.TabIndex = 8;
            lblColorRange.Text = "Color Range (RGB)";
            lblColorRange.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tblControls.SetColumnSpan(tableLayoutPanel1, 3);
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(lblRed, 0, 0);
            tableLayoutPanel1.Controls.Add(lblGreen, 0, 1);
            tableLayoutPanel1.Controls.Add(lblBlue, 0, 2);
            tableLayoutPanel1.Controls.Add(lblMinRed, 1, 0);
            tableLayoutPanel1.Controls.Add(lblMinGreen, 1, 1);
            tableLayoutPanel1.Controls.Add(lblMinBlue, 1, 2);
            tableLayoutPanel1.Controls.Add(txtMinRed, 2, 0);
            tableLayoutPanel1.Controls.Add(txtMinGreen, 2, 1);
            tableLayoutPanel1.Controls.Add(txtMinBlue, 2, 2);
            tableLayoutPanel1.Controls.Add(lblMaxRed, 3, 0);
            tableLayoutPanel1.Controls.Add(lblMaxGreen, 3, 1);
            tableLayoutPanel1.Controls.Add(lblMaxBlue, 3, 2);
            tableLayoutPanel1.Controls.Add(txtMaxRed, 4, 0);
            tableLayoutPanel1.Controls.Add(txtMaxGreen, 4, 1);
            tableLayoutPanel1.Controls.Add(txtMaxBlue, 4, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 201);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tblControls.SetRowSpan(tableLayoutPanel1, 3);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(331, 93);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Dock = DockStyle.Fill;
            lblRed.Location = new Point(3, 0);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(60, 31);
            lblRed.TabIndex = 0;
            lblRed.Text = "Red:";
            lblRed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.Dock = DockStyle.Fill;
            lblGreen.Location = new Point(3, 31);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(60, 31);
            lblGreen.TabIndex = 1;
            lblGreen.Text = "Green:";
            lblGreen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.Dock = DockStyle.Fill;
            lblBlue.Location = new Point(3, 62);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(60, 31);
            lblBlue.TabIndex = 2;
            lblBlue.Text = "Blue:";
            lblBlue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMinRed
            // 
            lblMinRed.AutoSize = true;
            lblMinRed.Dock = DockStyle.Fill;
            lblMinRed.Location = new Point(69, 0);
            lblMinRed.Name = "lblMinRed";
            lblMinRed.Size = new Size(60, 31);
            lblMinRed.TabIndex = 3;
            lblMinRed.Text = "Min";
            lblMinRed.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMinGreen
            // 
            lblMinGreen.AutoSize = true;
            lblMinGreen.Dock = DockStyle.Fill;
            lblMinGreen.Location = new Point(69, 31);
            lblMinGreen.Name = "lblMinGreen";
            lblMinGreen.Size = new Size(60, 31);
            lblMinGreen.TabIndex = 4;
            lblMinGreen.Text = "Min";
            lblMinGreen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMinBlue
            // 
            lblMinBlue.AutoSize = true;
            lblMinBlue.Dock = DockStyle.Fill;
            lblMinBlue.Location = new Point(69, 62);
            lblMinBlue.Name = "lblMinBlue";
            lblMinBlue.Size = new Size(60, 31);
            lblMinBlue.TabIndex = 5;
            lblMinBlue.Text = "Min";
            lblMinBlue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMinRed
            // 
            txtMinRed.BorderStyle = BorderStyle.FixedSingle;
            txtMinRed.Dock = DockStyle.Fill;
            txtMinRed.Location = new Point(135, 3);
            txtMinRed.Name = "txtMinRed";
            txtMinRed.Size = new Size(60, 27);
            txtMinRed.TabIndex = 6;
            // 
            // txtMinGreen
            // 
            txtMinGreen.BorderStyle = BorderStyle.FixedSingle;
            txtMinGreen.Dock = DockStyle.Fill;
            txtMinGreen.Location = new Point(135, 34);
            txtMinGreen.Name = "txtMinGreen";
            txtMinGreen.Size = new Size(60, 27);
            txtMinGreen.TabIndex = 7;
            // 
            // txtMinBlue
            // 
            txtMinBlue.BorderStyle = BorderStyle.FixedSingle;
            txtMinBlue.Dock = DockStyle.Fill;
            txtMinBlue.Location = new Point(135, 65);
            txtMinBlue.Name = "txtMinBlue";
            txtMinBlue.Size = new Size(60, 27);
            txtMinBlue.TabIndex = 8;
            // 
            // lblMaxRed
            // 
            lblMaxRed.AutoSize = true;
            lblMaxRed.Dock = DockStyle.Fill;
            lblMaxRed.Location = new Point(201, 0);
            lblMaxRed.Name = "lblMaxRed";
            lblMaxRed.Size = new Size(60, 31);
            lblMaxRed.TabIndex = 9;
            lblMaxRed.Text = "Max";
            lblMaxRed.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMaxGreen
            // 
            lblMaxGreen.AutoSize = true;
            lblMaxGreen.Dock = DockStyle.Fill;
            lblMaxGreen.Location = new Point(201, 31);
            lblMaxGreen.Name = "lblMaxGreen";
            lblMaxGreen.Size = new Size(60, 31);
            lblMaxGreen.TabIndex = 10;
            lblMaxGreen.Text = "Max";
            lblMaxGreen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMaxBlue
            // 
            lblMaxBlue.AutoSize = true;
            lblMaxBlue.Dock = DockStyle.Fill;
            lblMaxBlue.Location = new Point(201, 62);
            lblMaxBlue.Name = "lblMaxBlue";
            lblMaxBlue.Size = new Size(60, 31);
            lblMaxBlue.TabIndex = 11;
            lblMaxBlue.Text = "Max";
            lblMaxBlue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMaxRed
            // 
            txtMaxRed.BorderStyle = BorderStyle.FixedSingle;
            txtMaxRed.Dock = DockStyle.Fill;
            txtMaxRed.Location = new Point(267, 3);
            txtMaxRed.Name = "txtMaxRed";
            txtMaxRed.Size = new Size(61, 27);
            txtMaxRed.TabIndex = 12;
            // 
            // txtMaxGreen
            // 
            txtMaxGreen.BorderStyle = BorderStyle.FixedSingle;
            txtMaxGreen.Dock = DockStyle.Fill;
            txtMaxGreen.Location = new Point(267, 34);
            txtMaxGreen.Name = "txtMaxGreen";
            txtMaxGreen.Size = new Size(61, 27);
            txtMaxGreen.TabIndex = 13;
            // 
            // txtMaxBlue
            // 
            txtMaxBlue.BorderStyle = BorderStyle.FixedSingle;
            txtMaxBlue.Dock = DockStyle.Fill;
            txtMaxBlue.Location = new Point(267, 65);
            txtMaxBlue.Name = "txtMaxBlue";
            txtMaxBlue.Size = new Size(61, 27);
            txtMaxBlue.TabIndex = 14;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Dock = DockStyle.Fill;
            lblSize.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.Location = new Point(3, 297);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(106, 33);
            lblSize.TabIndex = 10;
            lblSize.Text = "Size";
            lblSize.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblSize
            // 
            tblSize.ColumnCount = 5;
            tblControls.SetColumnSpan(tblSize, 3);
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblSize.Controls.Add(lblHeight, 0, 0);
            tblSize.Controls.Add(lblWidth, 0, 1);
            tblSize.Controls.Add(lblMinHeight, 1, 0);
            tblSize.Controls.Add(lblMinWidth, 1, 1);
            tblSize.Controls.Add(lblMaxHeight, 3, 0);
            tblSize.Controls.Add(lblMaxWidth, 3, 1);
            tblSize.Controls.Add(txtMinHeight, 2, 0);
            tblSize.Controls.Add(txtMinWidth, 2, 1);
            tblSize.Controls.Add(txtMaxHeight, 4, 0);
            tblSize.Controls.Add(txtMaxWidth, 4, 1);
            tblSize.Dock = DockStyle.Fill;
            tblSize.Location = new Point(3, 333);
            tblSize.Name = "tblSize";
            tblSize.RowCount = 2;
            tblControls.SetRowSpan(tblSize, 2);
            tblSize.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSize.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSize.Size = new Size(331, 60);
            tblSize.TabIndex = 11;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Dock = DockStyle.Fill;
            lblHeight.Location = new Point(3, 0);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(60, 30);
            lblHeight.TabIndex = 0;
            lblHeight.Text = "Height:";
            lblHeight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Dock = DockStyle.Fill;
            lblWidth.Location = new Point(3, 30);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(60, 30);
            lblWidth.TabIndex = 1;
            lblWidth.Text = "Width:";
            lblWidth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMinHeight
            // 
            lblMinHeight.AutoSize = true;
            lblMinHeight.Dock = DockStyle.Fill;
            lblMinHeight.Location = new Point(69, 0);
            lblMinHeight.Name = "lblMinHeight";
            lblMinHeight.Size = new Size(60, 30);
            lblMinHeight.TabIndex = 2;
            lblMinHeight.Text = "Min";
            lblMinHeight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMinWidth
            // 
            lblMinWidth.AutoSize = true;
            lblMinWidth.Dock = DockStyle.Fill;
            lblMinWidth.Location = new Point(69, 30);
            lblMinWidth.Name = "lblMinWidth";
            lblMinWidth.Size = new Size(60, 30);
            lblMinWidth.TabIndex = 3;
            lblMinWidth.Text = "Min";
            lblMinWidth.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMaxHeight
            // 
            lblMaxHeight.AutoSize = true;
            lblMaxHeight.Dock = DockStyle.Fill;
            lblMaxHeight.Location = new Point(201, 0);
            lblMaxHeight.Name = "lblMaxHeight";
            lblMaxHeight.Size = new Size(60, 30);
            lblMaxHeight.TabIndex = 4;
            lblMaxHeight.Text = "Max";
            lblMaxHeight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMaxWidth
            // 
            lblMaxWidth.AutoSize = true;
            lblMaxWidth.Dock = DockStyle.Fill;
            lblMaxWidth.Location = new Point(201, 30);
            lblMaxWidth.Name = "lblMaxWidth";
            lblMaxWidth.Size = new Size(60, 30);
            lblMaxWidth.TabIndex = 5;
            lblMaxWidth.Text = "Max";
            lblMaxWidth.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMinHeight
            // 
            txtMinHeight.BorderStyle = BorderStyle.FixedSingle;
            txtMinHeight.Dock = DockStyle.Fill;
            txtMinHeight.Location = new Point(135, 3);
            txtMinHeight.Name = "txtMinHeight";
            txtMinHeight.Size = new Size(60, 27);
            txtMinHeight.TabIndex = 6;
            // 
            // txtMinWidth
            // 
            txtMinWidth.BorderStyle = BorderStyle.FixedSingle;
            txtMinWidth.Dock = DockStyle.Fill;
            txtMinWidth.Location = new Point(135, 33);
            txtMinWidth.Name = "txtMinWidth";
            txtMinWidth.Size = new Size(60, 27);
            txtMinWidth.TabIndex = 7;
            // 
            // txtMaxHeight
            // 
            txtMaxHeight.BorderStyle = BorderStyle.FixedSingle;
            txtMaxHeight.Dock = DockStyle.Fill;
            txtMaxHeight.Location = new Point(267, 3);
            txtMaxHeight.Name = "txtMaxHeight";
            txtMaxHeight.Size = new Size(61, 27);
            txtMaxHeight.TabIndex = 8;
            // 
            // txtMaxWidth
            // 
            txtMaxWidth.BorderStyle = BorderStyle.FixedSingle;
            txtMaxWidth.Dock = DockStyle.Fill;
            txtMaxWidth.Location = new Point(267, 33);
            txtMaxWidth.Name = "txtMaxWidth";
            txtMaxWidth.Size = new Size(61, 27);
            txtMaxWidth.TabIndex = 9;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("Segoe UI Semibold", 8.3F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(3, 399);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(106, 42);
            btnStart.TabIndex = 12;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnClearShapes
            // 
            btnClearShapes.Dock = DockStyle.Fill;
            btnClearShapes.Font = new Font("Segoe UI Semibold", 8.3F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearShapes.Location = new Point(115, 399);
            btnClearShapes.Name = "btnClearShapes";
            btnClearShapes.Size = new Size(106, 42);
            btnClearShapes.TabIndex = 13;
            btnClearShapes.Text = "Clear Shapes";
            btnClearShapes.UseVisualStyleBackColor = true;
            // 
            // btnRefreshColor
            // 
            btnRefreshColor.Dock = DockStyle.Fill;
            btnRefreshColor.Font = new Font("Segoe UI Semibold", 8.3F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefreshColor.Location = new Point(227, 399);
            btnRefreshColor.Name = "btnRefreshColor";
            btnRefreshColor.Size = new Size(107, 42);
            btnRefreshColor.TabIndex = 14;
            btnRefreshColor.Text = "Refresh Color";
            btnRefreshColor.UseVisualStyleBackColor = true;
            // 
            // pnlShape
            // 
            pnlShape.Dock = DockStyle.Fill;
            pnlShape.Location = new Point(346, 3);
            pnlShape.Name = "pnlShape";
            pnlShape.Size = new Size(451, 444);
            pnlShape.TabIndex = 1;
            // 
            // ArtGenerator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "ArtGenerator";
            Text = "ArtGenerator";
            tblMain.ResumeLayout(false);
            tblControls.ResumeLayout(false);
            tblControls.PerformLayout();
            pnlShapes.ResumeLayout(false);
            pnlShapes.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tblSize.ResumeLayout(false);
            tblSize.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblControls;
        private Panel pnlShapes;
        private RadioButton rbtShapeCount;
        private Panel pnlShape;
        private RadioButton rbtShapeDisplayTime;
        private RadioButton rbtShapeFrequency;
        private TextBox txtShapeCount;
        private TextBox txtShapeFrequency;
        private TextBox txtShapeDisplayTime;
        private Label lblSettings;
        private Label lblShapes;
        private Label lblColorRange;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private Label lblMinRed;
        private Label lblMinGreen;
        private Label lblMinBlue;
        private TextBox txtMinRed;
        private TextBox txtMinGreen;
        private TextBox txtMinBlue;
        private Label lblMaxRed;
        private Label lblMaxGreen;
        private Label lblMaxBlue;
        private TextBox txtMaxRed;
        private TextBox txtMaxGreen;
        private TextBox txtMaxBlue;
        private Label lblSize;
        private TableLayoutPanel tblSize;
        private Label lblHeight;
        private Label lblWidth;
        private Label lblMinHeight;
        private Label lblMinWidth;
        private Label lblMaxHeight;
        private Label lblMaxWidth;
        private TextBox txtMinHeight;
        private TextBox txtMinWidth;
        private TextBox txtMaxHeight;
        private TextBox txtMaxWidth;
        private Button btnStart;
        private Button btnClearShapes;
        private Button btnRefreshColor;
    }
}