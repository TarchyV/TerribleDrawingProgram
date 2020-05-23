namespace funtime
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
            this.components = new System.ComponentModel.Container();
            this.ColorPicker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drawTmr = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.circleRadio = new System.Windows.Forms.RadioButton();
            this.squareRadio = new System.Windows.Forms.RadioButton();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sizeBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorPicker
            // 
            this.ColorPicker.BackColor = System.Drawing.Color.Red;
            this.ColorPicker.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorPicker.Location = new System.Drawing.Point(70, 11);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Size = new System.Drawing.Size(29, 27);
            this.ColorPicker.TabIndex = 1;
            this.ColorPicker.UseVisualStyleBackColor = false;
            this.ColorPicker.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(33, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1850, 1000);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // drawTmr
            // 
            this.drawTmr.Interval = 1;
            this.drawTmr.Tick += new System.EventHandler(this.drawTmr_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Days", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(619, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(666, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "TOMS TERRIBLE DRAWING PROGRAM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.circleRadio);
            this.groupBox1.Controls.Add(this.squareRadio);
            this.groupBox1.Location = new System.Drawing.Point(386, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 28);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // circleRadio
            // 
            this.circleRadio.AutoSize = true;
            this.circleRadio.Location = new System.Drawing.Point(72, 7);
            this.circleRadio.Name = "circleRadio";
            this.circleRadio.Size = new System.Drawing.Size(51, 17);
            this.circleRadio.TabIndex = 1;
            this.circleRadio.TabStop = true;
            this.circleRadio.Text = "Circle";
            this.circleRadio.UseVisualStyleBackColor = true;
            this.circleRadio.CheckedChanged += new System.EventHandler(this.circleRadio_CheckedChanged);
            // 
            // squareRadio
            // 
            this.squareRadio.AutoSize = true;
            this.squareRadio.Location = new System.Drawing.Point(7, 7);
            this.squareRadio.Name = "squareRadio";
            this.squareRadio.Size = new System.Drawing.Size(59, 17);
            this.squareRadio.TabIndex = 0;
            this.squareRadio.TabStop = true;
            this.squareRadio.Text = "Square";
            this.squareRadio.UseVisualStyleBackColor = true;
            this.squareRadio.CheckedChanged += new System.EventHandler(this.squareRadio_CheckedChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(1781, 11);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Days", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1291, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "V 0.02";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // sizeBar
            // 
            this.sizeBar.LargeChange = 10;
            this.sizeBar.Location = new System.Drawing.Point(148, 14);
            this.sizeBar.Maximum = 50;
            this.sizeBar.Name = "sizeBar";
            this.sizeBar.Size = new System.Drawing.Size(214, 45);
            this.sizeBar.TabIndex = 10;
            this.sizeBar.TickFrequency = 2;
            this.sizeBar.Value = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorPicker);
            this.Controls.Add(this.sizeBar);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ColorPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer drawTmr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton circleRadio;
        private System.Windows.Forms.RadioButton squareRadio;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar sizeBar;
    }
}

