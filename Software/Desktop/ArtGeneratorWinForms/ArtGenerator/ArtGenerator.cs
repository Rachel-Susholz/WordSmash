using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGenerator
{
    public partial class ArtGenerator : Form
    {
        System.Windows.Forms.Timer shapeGenerationTimer = new();
        Random rnd = new();
        bool isGenerating = false;
        int MinRGB = 0;
        int MaxRGB = 256;

        public ArtGenerator()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
            btnClearShapes.Click += BtnClearShapes_Click;
            btnRefreshColor.Click += BtnRefreshColor_Click;
            shapeGenerationTimer.Tick += ShapeGenerationTimer_Tick;
            rbtShapeCount.CheckedChanged += RadioButton_CheckedChanged;
            rbtShapeFrequency.CheckedChanged += RadioButton_CheckedChanged;
            rbtShapeDisplayTime.CheckedChanged += RadioButton_CheckedChanged;
            UpdateTextBoxStates();
        }


        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!isGenerating)
            {
                // Start mode
                StartShapeGeneration();
            }
            else
            {
                // Stop mode
                StopShapeGeneration();
            }
        }
        //RS I cant figure out how to get the UI to change right away when selecting the
        //Add shapes for x seconds option. Like the start button only reads stop once the
        //form is finished executing the run. It seems that
        //the while loop is whats delaying it. Can you help me? I tried setting a 
        //duration timer, but that was very complicated.
        private void StartShapeGeneration()
        {
            UpdateControlStates();
            pnlShape.Controls.Clear();
            isGenerating = true;
            btnStart.Text = "Stop";

            if (rbtShapeCount.Checked)
            {
                GenerateRandomShapeForXNumberOfShapes();
            }
            else if (rbtShapeFrequency.Checked)
            {
                int frequency = int.TryParse(txtShapeFrequency.Text, out var interval) ? interval : 500;
                shapeGenerationTimer.Interval = frequency;
                shapeGenerationTimer.Start();
            }
            else if (rbtShapeDisplayTime.Checked)
            {
                DateTime startTime = DateTime.Now;
                int displayTime = int.TryParse(txtShapeDisplayTime.Text, out var durationSec) ? durationSec : 3;
                while ((DateTime.Now - startTime).TotalSeconds < displayTime)
                {
                    GenerateRandomShape();
                }

            }

        }

        private void StopShapeGeneration()
        {
            UpdateControlStates();
            pnlShape.Controls.Clear();
            isGenerating = false;
            shapeGenerationTimer.Stop();
            btnStart.Text = "Start";

        }
        private void BtnClearShapes_Click(object sender, EventArgs e)
        {
            UpdateControlStates();
            pnlShape.Controls.Clear();
        }
        private Color GetRandomColor()
        {
            int minR = int.TryParse(txtMinRed.Text, out var minRed) ? minRed : 0;
            int maxR = int.TryParse(txtMaxRed.Text, out var maxRed) ? maxRed : MaxRGB;

            int minG = int.TryParse(txtMinGreen.Text, out var minGreen) ? minGreen : 0;
            int maxG = int.TryParse(txtMaxGreen.Text, out var maxGreen) ? maxGreen : MaxRGB;

            int minB = int.TryParse(txtMinBlue.Text, out var minBlue) ? minBlue : 0;
            int maxB = int.TryParse(txtMaxBlue.Text, out var maxBlue) ? maxBlue : MaxRGB;

            return Color.FromArgb(
            rnd.Next(minR, maxR),
            rnd.Next(minG, maxG),
            rnd.Next(minB, maxB));
        }

        private void BtnRefreshColor_Click(object sender, EventArgs e)
        {
            UpdateControlStates();
            foreach (Control control in pnlShape.Controls)
            {
                if (control is Panel shape)
                {
                    shape.BackColor = GetRandomColor();
                }
            }
        }


        private void ShapeGenerationTimer_Tick(object? sender, EventArgs e)
        {
            GenerateRandomShape();
        }
        private void GenerateRandomShapeForXNumberOfShapes()
        {

            int count = int.TryParse(txtShapeCount.Text, out var shapeCount) ? shapeCount : 5;
            for (int i = 0; i < count; i++)
            {
                GenerateRandomShape();
            }

        }
        private void GenerateRandomShape()
        {
            int minHeight = int.TryParse(txtMinHeight.Text, out var userMinHeight) ? userMinHeight : 50;
            int minWidth = int.TryParse(txtMinWidth.Text, out var userMinWidth) ? userMinWidth : 50;
            int maxHeight = int.TryParse(txtMaxHeight.Text, out var userMaxHeight) ? userMaxHeight : 50;
            int maxWidth = int.TryParse(txtMaxWidth.Text, out var userMaxWidth) ? userMaxWidth : 50;
            int width = rnd.Next(minWidth, maxWidth);
            int height = rnd.Next(minHeight, maxHeight);

            Panel shape = new()
            {
                Size = new Size(width, height),
                Location = new Point(rnd.Next(pnlShape.Width - width), rnd.Next(pnlShape.Height - height)),
                BackColor = GetRandomColor()
            };
            pnlShape.Controls.Add(shape);


        }
        private void UpdateControlStates()
        {
            bool hasShapes = pnlShape.Controls.Count > 0;

            btnClearShapes.Enabled = hasShapes;
            btnRefreshColor.Enabled = hasShapes;


            txtShapeCount.Enabled = isGenerating;
            txtShapeFrequency.Enabled = isGenerating;
            txtShapeDisplayTime.Enabled = isGenerating;
            txtMinHeight.Enabled = isGenerating;
            txtMaxHeight.Enabled = isGenerating;
            txtMinWidth.Enabled = isGenerating;
            txtMaxWidth.Enabled = isGenerating;

            txtMinRed.Enabled = isGenerating;
            txtMinGreen.Enabled = isGenerating;
            txtMinBlue.Enabled = isGenerating;

            txtMaxRed.Enabled = isGenerating;
            txtMaxGreen.Enabled = isGenerating;
            txtMaxBlue.Enabled = isGenerating;
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextBoxStates();
        }
        private void UpdateTextBoxStates()
        {
            // Enable or disable textboxes based on the checked radio button
            txtShapeCount.Enabled = rbtShapeCount.Checked;
            txtShapeFrequency.Enabled = rbtShapeFrequency.Checked;
            txtShapeDisplayTime.Enabled = rbtShapeDisplayTime.Checked;
        }
    }

}
