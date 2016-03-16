using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Custom_Paint
{
    public partial class MainWindow : Form
    {

        private LinkedList<Shape> drawnShapes;
        private LinkedList<Shape> deletedShapes;
        private String currentShape;
        private Point start, end;
        private bool drawing = false;

        public MainWindow()
        {
            drawnShapes = new LinkedList<Shape>();
            deletedShapes = new LinkedList<Shape>();
            start = new Point(0, 0);
            end = new Point(0, 0);
            InitializeComponent();
        }

        /*
            * Set currently active shape or tool based on button clicked
         */
        private void btnPencil_Click(object sender, EventArgs e)
        {
            currentShape = "Line";
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            currentShape = "Square";
            displaySettings(currentShape);
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currentShape = "Rectangle";
            displaySettings(currentShape);
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentShape = "Circle";
            displaySettings(currentShape);
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            currentShape = "Ellipse";
            displaySettings(currentShape);
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            currentShape = "Text";
            displaySettings(currentShape);
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            currentShape = "Eraser";
        }

        /*
           * Set current tool to paint can 
        */
        private void btnPaintCan_Click(object sender, EventArgs e)
        {
            currentShape = "Paint All";
        }


        /*
            * Delete all shapes from the list and paint panel back to white
         */
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will delete all shapes and cannot be undone. Are you sure?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                if (drawnShapes.Count > 0)
                {
                    drawnShapes.Clear();
                    deletedShapes.Clear();
                    drawPanel.Invalidate();
                    drawPanel.BackColor = Color.White;
                }
                else {
                    MessageBox.Show("Nothing to remove", "Empty drawing", MessageBoxButtons.OK);
                    drawPanel.BackColor = Color.White;
                }
                
            }
        }

        /*
            * Create dialogs for choosing font, line color and fill color
         */
        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgFont.ShowDialog();
            if (result == DialogResult.OK) { 
                
            }
        }

        private void btnLineColor_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgLineColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                lineColor = dlgLineColor.Color;
            }
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgFillColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                fillColor = dlgFillColor.Color;
            }
        }

        /*
            * Handle events on drawPanel component
         */
        private void drawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            try { 
                if (currentShape.Equals("Paint All"))
                {
                    if (e.Button == MouseButtons.Left)
                        drawPanel.BackColor = dlgLineColor.Color;
                    else if (e.Button == MouseButtons.Right)
                        drawPanel.BackColor = dlgFillColor.Color;
                }
               
                if (currentShape.Equals("Square")) {
                        Shape shape = new Shape();
                        shape.shapeType = "Square";

                        if (checkBoxFilled.Checked == true) {
                            shape.filled = true;
                            shape.fillColor = dlgFillColor.Color;
                        }
                        else if (checkBoxFilled.Checked == false) {
                            shape.penWidth = trackBarBrushSize.Value;
                            shape.filled = false;
                            shape.lineColor = dlgLineColor.Color;
                        }

                        shape.start = e.Location;
                        shape.width = int.Parse(numericUpDownWidth.Text);
                        shape.height = shape.width;

                        drawnShapes.AddLast(shape);
                        this.drawPanel.Invalidate();
                }
                else if (currentShape.Equals("Rectangle"))
                {
                    Shape shape = new Shape();
                    shape.shapeType = "Rectangle";

                    if (checkBoxFilled.Checked == true)
                    {
                        shape.filled = true;
                        shape.fillColor = dlgFillColor.Color;
                    }
                    else if (checkBoxFilled.Checked == false)
                    {
                        shape.penWidth = trackBarBrushSize.Value;
                        shape.filled = false;
                        shape.lineColor = dlgLineColor.Color;
                    }

                    shape.start = e.Location;
                    shape.width = int.Parse(numericUpDownWidth.Text);
                    shape.height = int.Parse(numericUpDownHeight.Text);

                    drawnShapes.AddLast(shape);
                    this.drawPanel.Invalidate();
                }
                else if (currentShape.Equals("Circle"))
                {
                    Shape shape = new Shape();
                    shape.shapeType = "Circle";

                    if (checkBoxFilled.Checked == true)
                    {
                        shape.filled = true;
                        shape.fillColor = dlgFillColor.Color;
                    }
                    else if (checkBoxFilled.Checked == false)
                    {
                        shape.penWidth = trackBarBrushSize.Value;
                        shape.filled = false;
                        shape.lineColor = dlgLineColor.Color;
                    }

                    shape.start = e.Location;
                    shape.width = int.Parse(numericUpDownWidth.Text);
                    shape.height = shape.width;

                    drawnShapes.AddLast(shape);
                    this.drawPanel.Invalidate();
                }
                else if (currentShape.Equals("Ellipse"))
                {
                    Shape shape = new Shape();
                    shape.shapeType = "Ellipse";

                    if (checkBoxFilled.Checked == true)
                    {
                        shape.filled = true;
                        shape.fillColor = dlgFillColor.Color;
                    }
                    else if (checkBoxFilled.Checked == false)
                    {
                        shape.penWidth = trackBarBrushSize.Value;
                        shape.filled = false;
                        shape.lineColor = dlgLineColor.Color;
                    }

                    shape.start = e.Location;
                    shape.width = int.Parse(numericUpDownWidth.Text);
                    shape.height = int.Parse(numericUpDownHeight.Text);

                    drawnShapes.AddLast(shape);
                    this.drawPanel.Invalidate();
                }
                else if (currentShape.Equals("Text"))
                {
                    Shape shape = new Shape();
                    shape.shapeType = "Text";
                    shape.text = txtText.Text;
                    shape.fillColor = dlgFillColor.Color;
                    shape.start = e.Location;

                    drawnShapes.AddLast(shape);
                    this.drawPanel.Invalidate();
                }
            } catch (Exception ex) {
                MessageBox.Show("No shape selected", "Error", MessageBoxButtons.OK);
            }
        }

        /*
            * Display shape settings in groupBox based on shape choice
         */

        private void displaySettings(String currentShape) {
            if (currentShape.Equals("Circle") || currentShape.Equals("Square")) {
                lblWidth.Visible = true;
                numericUpDownWidth.Visible = true;
                lblHeight.Visible = false;
                numericUpDownHeight.Visible = false;
                checkBoxFilled.Visible = true;
                lblText.Visible = false;
                txtText.Visible = false;
            }  else if(currentShape.Equals("Rectangle") || currentShape.Equals("Ellipse")) {
                lblWidth.Visible = true;
                numericUpDownWidth.Visible = true;
                lblHeight.Visible = true;
                numericUpDownHeight.Visible = true;
                checkBoxFilled.Visible = true;
                lblText.Visible = false;
                txtText.Visible = false;
            }
            else if (currentShape.Equals("Text")) {
                lblWidth.Visible = false;
                numericUpDownWidth.Visible = false;
                lblHeight.Visible = false;
                numericUpDownHeight.Visible = false;
                checkBoxFilled.Visible = false;
                lblText.Visible = true;
                txtText.Visible = true;
            }
        }

        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentShape.Equals("Line") || currentShape.Equals("Eraser")) {
                start = e.Location;
                drawing = true;
            }
        }

        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing == true) {
                end = e.Location;

                if (currentShape.Equals("Line"))
                {
                    Shape shape = new Shape();
                    shape.shapeType = "Line";
                    shape.lineColor = dlgLineColor.Color;
                    shape.penWidth = trackBarBrushSize.Value;
                    shape.start = start;
                    shape.end = end;
                    drawnShapes.AddLast(shape);
                }
                else if (currentShape.Equals("Eraser"))
                {
                    Shape shape = new Shape();
                    shape.shapeType = "Eraser";
                    shape.filled = true;
                    shape.fillColor = Color.White;
                    shape.width = trackBarBrushSize.Value;
                    shape.height = shape.width;
                    shape.start = start;
                    shape.end = end;
                    drawnShapes.AddLast(shape);    
                }

                
                start = end;
            }
        }

        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            this.drawPanel.Invalidate();
        }

        private void trackBarBrushSize_Scroll(object sender, EventArgs e)
        {
            gbBrushSize.Text = "Brush Size: " + trackBarBrushSize.Value;
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            using(Font font = new Font(dlgFont.Font.FontFamily, dlgFont.Font.Size, dlgFont.Font.Style))
            using(Pen pen = new Pen(dlgLineColor.Color, trackBarBrushSize.Value))
            using (SolidBrush brush = new SolidBrush(dlgFillColor.Color))
            {
                foreach (Shape s in drawnShapes)
                {
                    pen.Color = s.lineColor;
                    pen.Width = s.penWidth;
                    brush.Color = s.fillColor;

                    switch (s.shapeType)
                    {
                        case "Line":
                            e.Graphics.DrawLine(pen, s.start, s.end);
                            break;
                        case "Eraser":
                            e.Graphics.FillRectangle(brush, s.start.X, s.start.Y, s.width, s.height);
                            break;
                        case "Square":
                            if (s.filled == false)
                                e.Graphics.DrawRectangle(pen, s.start.X, s.start.Y, s.width, s.height);
                            else if (s.filled == true)
                                e.Graphics.FillRectangle(brush, s.start.X, s.start.Y, s.width, s.height);
                            break;
                        case "Rectangle":
                            if (s.filled == false)
                                e.Graphics.DrawRectangle(pen, s.start.X, s.start.Y, s.width, s.height);
                            else if (s.filled == true)
                                e.Graphics.FillRectangle(brush, s.start.X, s.start.Y, s.width, s.height);
                            break;
                        case "Circle":
                            if (s.filled == false)
                                e.Graphics.DrawEllipse(pen, s.start.X, s.start.Y, s.width, s.height);
                            else if (s.filled == true)
                                e.Graphics.FillEllipse(brush, s.start.X, s.start.Y, s.width, s.height);
                            break;
                        case "Ellipse":
                            if (s.filled == false)
                                e.Graphics.DrawEllipse(pen, s.start.X, s.start.Y, s.width, s.height);
                            else if (s.filled == true)
                                e.Graphics.FillEllipse(brush, s.start.X, s.start.Y, s.width, s.height);
                            break;
                        case "Text":
                            e.Graphics.DrawString(s.text, font, brush, s.start);
                            break;
                        default:
                            break;
                    }
                }

            }
        }

        /*
            * Implement undo/redo
         */
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (drawnShapes.Count > 0)
            {
                deletedShapes.AddLast(drawnShapes.Last());
                drawnShapes.RemoveLast();
            }
            else {
                MessageBox.Show("Nothing to delete", "No shapes drawn", MessageBoxButtons.OK);
            }
            
            this.drawPanel.Invalidate();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (deletedShapes.Count > 0)
            {
                drawnShapes.AddLast(deletedShapes.Last());
                deletedShapes.RemoveLast();
            } else if (deletedShapes.Count == 0)
            {
                MessageBox.Show("Nothing to redo", "No shapes deleted so far", MessageBoxButtons.OK);
            }
            this.drawPanel.Invalidate();
        }

        public Color lineColor { get; set; }

        public Color fillColor { get; set; }
    }
}
