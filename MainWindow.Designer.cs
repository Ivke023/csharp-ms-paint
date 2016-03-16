namespace Custom_Paint
{
    partial class MainWindow
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
            this.drawPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPaintCan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.dlgLineColor = new System.Windows.Forms.ColorDialog();
            this.dlgFillColor = new System.Windows.Forms.ColorDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.lblFillColor = new System.Windows.Forms.Label();
            this.lblLineColor = new System.Windows.Forms.Label();
            this.gbShapeSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxFilled = new System.Windows.Forms.CheckBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.trackBarBrushSize = new System.Windows.Forms.TrackBar();
            this.gbBrushSize = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbShapeSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrushSize)).BeginInit();
            this.gbBrushSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPanel.BackColor = System.Drawing.Color.White;
            this.drawPanel.Location = new System.Drawing.Point(12, 87);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(1118, 450);
            this.drawPanel.TabIndex = 0;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            this.drawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseClick);
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseDown);
            this.drawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseMove);
            this.drawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPaintCan);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnEraser);
            this.groupBox1.Controls.Add(this.btnText);
            this.groupBox1.Controls.Add(this.btnPencil);
            this.groupBox1.Location = new System.Drawing.Point(112, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // btnPaintCan
            // 
            this.btnPaintCan.Image = global::Custom_Paint.Properties.Resources.paintcan;
            this.btnPaintCan.Location = new System.Drawing.Point(136, 30);
            this.btnPaintCan.Name = "btnPaintCan";
            this.btnPaintCan.Size = new System.Drawing.Size(24, 23);
            this.btnPaintCan.TabIndex = 4;
            this.btnPaintCan.UseVisualStyleBackColor = true;
            this.btnPaintCan.Click += new System.EventHandler(this.btnPaintCan_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::Custom_Paint.Properties.Resources.arrow_refresh;
            this.btnClear.Location = new System.Drawing.Point(104, 29);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(25, 24);
            this.btnClear.TabIndex = 3;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Image = global::Custom_Paint.Properties.Resources.page_white;
            this.btnEraser.Location = new System.Drawing.Point(74, 29);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(24, 24);
            this.btnEraser.TabIndex = 2;
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnText
            // 
            this.btnText.Image = global::Custom_Paint.Properties.Resources.font;
            this.btnText.Location = new System.Drawing.Point(45, 29);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(23, 24);
            this.btnText.TabIndex = 1;
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.Image = global::Custom_Paint.Properties.Resources.pencil;
            this.btnPencil.Location = new System.Drawing.Point(15, 29);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(24, 24);
            this.btnPencil.TabIndex = 0;
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRedo);
            this.groupBox2.Controls.Add(this.btnUndo);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 68);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btnRedo
            // 
            this.btnRedo.Image = global::Custom_Paint.Properties.Resources.arrow_redo;
            this.btnRedo.Location = new System.Drawing.Point(49, 29);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(28, 23);
            this.btnRedo.TabIndex = 1;
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::Custom_Paint.Properties.Resources.arrow_undo;
            this.btnUndo.Location = new System.Drawing.Point(14, 29);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(28, 23);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEllipse);
            this.groupBox3.Controls.Add(this.btnCircle);
            this.groupBox3.Controls.Add(this.btnRectangle);
            this.groupBox3.Controls.Add(this.btnSquare);
            this.groupBox3.Location = new System.Drawing.Point(296, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 68);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shapes";
            // 
            // btnEllipse
            // 
            this.btnEllipse.Image = global::Custom_Paint.Properties.Resources.stop;
            this.btnEllipse.Location = new System.Drawing.Point(117, 29);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(28, 23);
            this.btnEllipse.TabIndex = 3;
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Image = global::Custom_Paint.Properties.Resources.stop;
            this.btnCircle.Location = new System.Drawing.Point(83, 29);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(28, 23);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Image = global::Custom_Paint.Properties.Resources.shape_move_forwards;
            this.btnRectangle.Location = new System.Drawing.Point(50, 29);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(28, 23);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Image = global::Custom_Paint.Properties.Resources.shape_square;
            this.btnSquare.Location = new System.Drawing.Point(16, 29);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(28, 23);
            this.btnSquare.TabIndex = 0;
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // dlgFillColor
            // 
            this.dlgFillColor.Color = System.Drawing.Color.White;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFillColor);
            this.groupBox4.Controls.Add(this.btnLineColor);
            this.groupBox4.Controls.Add(this.lblFillColor);
            this.groupBox4.Controls.Add(this.lblLineColor);
            this.groupBox4.Location = new System.Drawing.Point(461, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 68);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Colors";
            // 
            // btnFillColor
            // 
            this.btnFillColor.Image = global::Custom_Paint.Properties.Resources.palette;
            this.btnFillColor.Location = new System.Drawing.Point(74, 19);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(30, 23);
            this.btnFillColor.TabIndex = 3;
            this.btnFillColor.UseVisualStyleBackColor = true;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // btnLineColor
            // 
            this.btnLineColor.Image = global::Custom_Paint.Properties.Resources.palette;
            this.btnLineColor.Location = new System.Drawing.Point(17, 19);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(30, 23);
            this.btnLineColor.TabIndex = 2;
            this.btnLineColor.UseVisualStyleBackColor = true;
            this.btnLineColor.Click += new System.EventHandler(this.btnLineColor_Click);
            // 
            // lblFillColor
            // 
            this.lblFillColor.AutoSize = true;
            this.lblFillColor.Location = new System.Drawing.Point(68, 45);
            this.lblFillColor.Name = "lblFillColor";
            this.lblFillColor.Size = new System.Drawing.Size(45, 13);
            this.lblFillColor.TabIndex = 1;
            this.lblFillColor.Text = "Fill color";
            // 
            // lblLineColor
            // 
            this.lblLineColor.AutoSize = true;
            this.lblLineColor.Location = new System.Drawing.Point(9, 45);
            this.lblLineColor.Name = "lblLineColor";
            this.lblLineColor.Size = new System.Drawing.Size(53, 13);
            this.lblLineColor.TabIndex = 0;
            this.lblLineColor.Text = "Line color";
            // 
            // gbShapeSettings
            // 
            this.gbShapeSettings.Controls.Add(this.checkBoxFilled);
            this.gbShapeSettings.Controls.Add(this.txtText);
            this.gbShapeSettings.Controls.Add(this.lblText);
            this.gbShapeSettings.Controls.Add(this.lblHeight);
            this.gbShapeSettings.Controls.Add(this.lblWidth);
            this.gbShapeSettings.Controls.Add(this.numericUpDownHeight);
            this.gbShapeSettings.Controls.Add(this.numericUpDownWidth);
            this.gbShapeSettings.Location = new System.Drawing.Point(586, 13);
            this.gbShapeSettings.Name = "gbShapeSettings";
            this.gbShapeSettings.Size = new System.Drawing.Size(265, 68);
            this.gbShapeSettings.TabIndex = 5;
            this.gbShapeSettings.TabStop = false;
            this.gbShapeSettings.Text = "Shape settings";
            // 
            // checkBoxFilled
            // 
            this.checkBoxFilled.AutoSize = true;
            this.checkBoxFilled.Location = new System.Drawing.Point(209, 27);
            this.checkBoxFilled.Name = "checkBoxFilled";
            this.checkBoxFilled.Size = new System.Drawing.Size(50, 17);
            this.checkBoxFilled.TabIndex = 6;
            this.checkBoxFilled.Text = "Filled";
            this.checkBoxFilled.UseVisualStyleBackColor = true;
            this.checkBoxFilled.Visible = false;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(49, 26);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(79, 20);
            this.txtText.TabIndex = 5;
            this.txtText.Visible = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(9, 29);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Text:";
            this.lblText.Visible = false;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(99, 29);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height:";
            this.lblHeight.Visible = false;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(6, 29);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width:";
            this.lblWidth.Visible = false;
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(146, 26);
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownHeight.TabIndex = 1;
            this.numericUpDownHeight.Visible = false;
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(49, 26);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownWidth.TabIndex = 0;
            this.numericUpDownWidth.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFont);
            this.groupBox5.Location = new System.Drawing.Point(857, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(98, 68);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Font Settings";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(12, 29);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "Choose font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // trackBarBrushSize
            // 
            this.trackBarBrushSize.Location = new System.Drawing.Point(6, 16);
            this.trackBarBrushSize.Maximum = 15;
            this.trackBarBrushSize.Minimum = 1;
            this.trackBarBrushSize.Name = "trackBarBrushSize";
            this.trackBarBrushSize.Size = new System.Drawing.Size(104, 45);
            this.trackBarBrushSize.TabIndex = 6;
            this.trackBarBrushSize.Value = 1;
            this.trackBarBrushSize.Scroll += new System.EventHandler(this.trackBarBrushSize_Scroll);
            // 
            // gbBrushSize
            // 
            this.gbBrushSize.Controls.Add(this.trackBarBrushSize);
            this.gbBrushSize.Location = new System.Drawing.Point(961, 14);
            this.gbBrushSize.Name = "gbBrushSize";
            this.gbBrushSize.Size = new System.Drawing.Size(116, 67);
            this.gbBrushSize.TabIndex = 7;
            this.gbBrushSize.TabStop = false;
            this.gbBrushSize.Text = "Brush Size";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 549);
            this.Controls.Add(this.gbBrushSize);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbShapeSettings);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.drawPanel);
            this.Name = "MainWindow";
            this.Text = "Paint!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbShapeSettings.ResumeLayout(false);
            this.gbShapeSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrushSize)).EndInit();
            this.gbBrushSize.ResumeLayout(false);
            this.gbBrushSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnPaintCan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.ColorDialog dlgLineColor;
        private System.Windows.Forms.ColorDialog dlgFillColor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.Label lblFillColor;
        private System.Windows.Forms.Label lblLineColor;
        private System.Windows.Forms.GroupBox gbShapeSettings;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TrackBar trackBarBrushSize;
        private System.Windows.Forms.GroupBox gbBrushSize;
        private System.Windows.Forms.CheckBox checkBoxFilled;
    }
}

