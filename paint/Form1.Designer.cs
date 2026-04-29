namespace paint
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.panelShapes = new System.Windows.Forms.Panel();
            this.Fill = new System.Windows.Forms.CheckBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.save = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.ellipse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flood = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.colors = new System.Windows.Forms.Button();
            this.shapes = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.brush = new System.Windows.Forms.Button();
            this.pencil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.panelShapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.flood);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.colors);
            this.panel1.Controls.Add(this.numWidth);
            this.panel1.Controls.Add(this.shapes);
            this.panel1.Controls.Add(this.eraser);
            this.panel1.Controls.Add(this.brush);
            this.panel1.Controls.Add(this.pencil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1062, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 526);
            this.panel1.TabIndex = 0;
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(-1, 284);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(78, 20);
            this.numWidth.TabIndex = 3;
            // 
            // panelShapes
            // 
            this.panelShapes.Controls.Add(this.circle);
            this.panelShapes.Controls.Add(this.line);
            this.panelShapes.Controls.Add(this.Fill);
            this.panelShapes.Controls.Add(this.square);
            this.panelShapes.Controls.Add(this.triangle);
            this.panelShapes.Controls.Add(this.rectangle);
            this.panelShapes.Controls.Add(this.ellipse);
            this.panelShapes.Location = new System.Drawing.Point(931, 205);
            this.panelShapes.Name = "panelShapes";
            this.panelShapes.Size = new System.Drawing.Size(125, 200);
            this.panelShapes.TabIndex = 2;
            this.panelShapes.Visible = false;
            // 
            // Fill
            // 
            this.Fill.AutoSize = true;
            this.Fill.Location = new System.Drawing.Point(3, 171);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(38, 17);
            this.Fill.TabIndex = 3;
            this.Fill.Text = "Fill";
            this.Fill.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.save.BackgroundImage = global::paint.Properties.Resources.download;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.Location = new System.Drawing.Point(987, 0);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 67);
            this.save.TabIndex = 3;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.White;
            this.circle.BackgroundImage = global::paint.Properties.Resources.dry_clean;
            this.circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circle.Location = new System.Drawing.Point(63, 115);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(54, 50);
            this.circle.TabIndex = 3;
            this.circle.UseVisualStyleBackColor = false;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.White;
            this.line.BackgroundImage = global::paint.Properties.Resources.diagonal_line;
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.line.Location = new System.Drawing.Point(3, 115);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(54, 50);
            this.line.TabIndex = 3;
            this.line.UseVisualStyleBackColor = false;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.White;
            this.square.BackgroundImage = global::paint.Properties.Resources.square__1_;
            this.square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.square.Location = new System.Drawing.Point(63, 59);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(54, 50);
            this.square.TabIndex = 7;
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // triangle
            // 
            this.triangle.BackColor = System.Drawing.Color.White;
            this.triangle.BackgroundImage = global::paint.Properties.Resources.triangle;
            this.triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.triangle.Location = new System.Drawing.Point(3, 3);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(54, 50);
            this.triangle.TabIndex = 6;
            this.triangle.UseVisualStyleBackColor = false;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.White;
            this.rectangle.BackgroundImage = global::paint.Properties.Resources.rectangle__1_;
            this.rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangle.Location = new System.Drawing.Point(3, 59);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(54, 50);
            this.rectangle.TabIndex = 5;
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // ellipse
            // 
            this.ellipse.BackColor = System.Drawing.Color.White;
            this.ellipse.BackgroundImage = global::paint.Properties.Resources.ellipse;
            this.ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ellipse.Location = new System.Drawing.Point(63, 3);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(54, 50);
            this.ellipse.TabIndex = 4;
            this.ellipse.UseVisualStyleBackColor = false;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1062, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // flood
            // 
            this.flood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flood.BackgroundImage = global::paint.Properties.Resources.bucket;
            this.flood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flood.Location = new System.Drawing.Point(0, 455);
            this.flood.Name = "flood";
            this.flood.Size = new System.Drawing.Size(77, 68);
            this.flood.TabIndex = 3;
            this.flood.UseVisualStyleBackColor = false;
            this.flood.Click += new System.EventHandler(this.flood_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clear.BackgroundImage = global::paint.Properties.Resources.delete;
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear.Location = new System.Drawing.Point(0, 384);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(77, 68);
            this.clear.TabIndex = 3;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // colors
            // 
            this.colors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colors.BackgroundImage = global::paint.Properties.Resources._64e49c9e580d0;
            this.colors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colors.Location = new System.Drawing.Point(0, 148);
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(77, 68);
            this.colors.TabIndex = 3;
            this.colors.UseVisualStyleBackColor = false;
            this.colors.Click += new System.EventHandler(this.colors_Click);
            // 
            // shapes
            // 
            this.shapes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shapes.BackgroundImage = global::paint.Properties.Resources.shapes;
            this.shapes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shapes.Location = new System.Drawing.Point(0, 220);
            this.shapes.Name = "shapes";
            this.shapes.Size = new System.Drawing.Size(77, 68);
            this.shapes.TabIndex = 3;
            this.shapes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.shapes.UseVisualStyleBackColor = false;
            this.shapes.Click += new System.EventHandler(this.shapes_Click);
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eraser.BackgroundImage = global::paint.Properties.Resources.eraser;
            this.eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraser.Location = new System.Drawing.Point(0, 310);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(77, 68);
            this.eraser.TabIndex = 2;
            this.eraser.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.eraser.UseVisualStyleBackColor = false;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // brush
            // 
            this.brush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.brush.BackgroundImage = global::paint.Properties.Resources.pen;
            this.brush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brush.Location = new System.Drawing.Point(0, 74);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(77, 68);
            this.brush.TabIndex = 4;
            this.brush.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.brush.UseVisualStyleBackColor = false;
            this.brush.Click += new System.EventHandler(this.brush_Click);
            // 
            // pencil
            // 
            this.pencil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pencil.BackgroundImage = global::paint.Properties.Resources.pencil;
            this.pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pencil.Location = new System.Drawing.Point(0, -1);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(77, 68);
            this.pencil.TabIndex = 2;
            this.pencil.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.pencil.UseVisualStyleBackColor = false;
            this.pencil.Click += new System.EventHandler(this.pencil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 526);
            this.Controls.Add(this.save);
            this.Controls.Add(this.panelShapes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "paint";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.panelShapes.ResumeLayout(false);
            this.panelShapes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pencil;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button shapes;
        private System.Windows.Forms.Button brush;
        private System.Windows.Forms.Panel panelShapes;
        private System.Windows.Forms.Button ellipse;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Button colors;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.CheckBox Fill;
        private System.Windows.Forms.Button flood;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button save;
    }
}

