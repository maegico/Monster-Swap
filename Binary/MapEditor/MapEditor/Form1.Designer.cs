namespace MapEditor
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
            this.loadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mapBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mapBox2 = new System.Windows.Forms.RichTextBox();
            this.mapBox3 = new System.Windows.Forms.RichTextBox();
            this.mapBox4 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mapBox5 = new System.Windows.Forms.RichTextBox();
            this.mapBox6 = new System.Windows.Forms.RichTextBox();
            this.mapBox7 = new System.Windows.Forms.RichTextBox();
            this.mapBox8 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(425, 292);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(134, 64);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load Map";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Map (203 x 8)";
            // 
            // mapBox1
            // 
            this.mapBox1.Location = new System.Drawing.Point(8, 154);
            this.mapBox1.Margin = new System.Windows.Forms.Padding(2);
            this.mapBox1.Name = "mapBox1";
            this.mapBox1.Size = new System.Drawing.Size(116, 109);
            this.mapBox1.TabIndex = 4;
            this.mapBox1.Text = "";
            this.mapBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "i = Grey Stone Tile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "r = floor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "b = Blue Stone Tile";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(746, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = ". = space or nothing";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(367, 21);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(225, 60);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Map Editor";
            this.richTextBox1.ZoomFactor = 4F;
            // 
            // mapBox2
            // 
            this.mapBox2.Location = new System.Drawing.Point(129, 154);
            this.mapBox2.Name = "mapBox2";
            this.mapBox2.Size = new System.Drawing.Size(116, 109);
            this.mapBox2.TabIndex = 10;
            this.mapBox2.Text = "";
            // 
            // mapBox3
            // 
            this.mapBox3.Location = new System.Drawing.Point(251, 154);
            this.mapBox3.Name = "mapBox3";
            this.mapBox3.Size = new System.Drawing.Size(116, 109);
            this.mapBox3.TabIndex = 11;
            this.mapBox3.Text = "";
            // 
            // mapBox4
            // 
            this.mapBox4.Location = new System.Drawing.Point(373, 154);
            this.mapBox4.Name = "mapBox4";
            this.mapBox4.Size = new System.Drawing.Size(116, 109);
            this.mapBox4.TabIndex = 12;
            this.mapBox4.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Part 1 (36 x 8)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Part 2 (36 x 8)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Part 3 (36 x 8)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Part 4 (36 x 8)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // mapBox5
            // 
            this.mapBox5.Location = new System.Drawing.Point(495, 154);
            this.mapBox5.Name = "mapBox5";
            this.mapBox5.Size = new System.Drawing.Size(116, 109);
            this.mapBox5.TabIndex = 17;
            this.mapBox5.Text = "";
            // 
            // mapBox6
            // 
            this.mapBox6.Location = new System.Drawing.Point(617, 154);
            this.mapBox6.Name = "mapBox6";
            this.mapBox6.Size = new System.Drawing.Size(116, 109);
            this.mapBox6.TabIndex = 18;
            this.mapBox6.Text = "";
            // 
            // mapBox7
            // 
            this.mapBox7.Location = new System.Drawing.Point(739, 154);
            this.mapBox7.Name = "mapBox7";
            this.mapBox7.Size = new System.Drawing.Size(116, 109);
            this.mapBox7.TabIndex = 19;
            this.mapBox7.Text = "";
            // 
            // mapBox8
            // 
            this.mapBox8.Location = new System.Drawing.Point(861, 154);
            this.mapBox8.Name = "mapBox8";
            this.mapBox8.Size = new System.Drawing.Size(131, 109);
            this.mapBox8.TabIndex = 20;
            this.mapBox8.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(492, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Part 5 (36 x 8)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(614, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Part 6 (36 x 8)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(736, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Part 7 (36 x 8)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(858, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Part 8 (41 x 8)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(746, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "e = collectible";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(523, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "In Row 7 Column 4 Is Where the Character Spawns, so it will always be a \'.\' or sp" +
    "ace, no matter what you put.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 392);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mapBox8);
            this.Controls.Add(this.mapBox7);
            this.Controls.Add(this.mapBox6);
            this.Controls.Add(this.mapBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mapBox4);
            this.Controls.Add(this.mapBox3);
            this.Controls.Add(this.mapBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mapBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Map Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox mapBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox mapBox2;
        private System.Windows.Forms.RichTextBox mapBox3;
        private System.Windows.Forms.RichTextBox mapBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox mapBox5;
        private System.Windows.Forms.RichTextBox mapBox6;
        private System.Windows.Forms.RichTextBox mapBox7;
        private System.Windows.Forms.RichTextBox mapBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

