namespace NoteLib
{
    partial class addSongForm
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
            this.songName = new System.Windows.Forms.TextBox();
            this.genreCombo = new System.Windows.Forms.ComboBox();
            this.artistCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.albumCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.songYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.songLengthMin = new System.Windows.Forms.NumericUpDown();
            this.songLengthSec = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.songLengthMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songLengthSec)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // songName
            // 
            this.songName.BackColor = System.Drawing.Color.White;
            this.songName.Location = new System.Drawing.Point(81, 12);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(121, 20);
            this.songName.TabIndex = 0;
            // 
            // genreCombo
            // 
            this.genreCombo.FormattingEnabled = true;
            this.genreCombo.Location = new System.Drawing.Point(81, 123);
            this.genreCombo.Name = "genreCombo";
            this.genreCombo.Size = new System.Drawing.Size(121, 21);
            this.genreCombo.TabIndex = 3;
            // 
            // artistCombo
            // 
            this.artistCombo.FormattingEnabled = true;
            this.artistCombo.Location = new System.Drawing.Point(81, 96);
            this.artistCombo.Name = "artistCombo";
            this.artistCombo.Size = new System.Drawing.Size(121, 21);
            this.artistCombo.TabIndex = 4;
            this.artistCombo.SelectedIndexChanged += new System.EventHandler(this.artistCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Song Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Song Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Song Artist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Song Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Song Genre";
            // 
            // albumCombo
            // 
            this.albumCombo.FormattingEnabled = true;
            this.albumCombo.Location = new System.Drawing.Point(81, 152);
            this.albumCombo.Name = "albumCombo";
            this.albumCombo.Size = new System.Drawing.Size(121, 21);
            this.albumCombo.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(104, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Song Album";
            // 
            // songYear
            // 
            this.songYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.songYear.Location = new System.Drawing.Point(106, 70);
            this.songYear.MaxLength = 4;
            this.songYear.Name = "songYear";
            this.songYear.ReadOnly = true;
            this.songYear.Size = new System.Drawing.Size(70, 20);
            this.songYear.TabIndex = 13;
            this.songYear.Text = "2000";
            this.songYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(136, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = ":";
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.button3.Location = new System.Drawing.Point(81, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(19, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.button4.Location = new System.Drawing.Point(183, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(19, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // songLengthMin
            // 
            this.songLengthMin.Location = new System.Drawing.Point(81, 39);
            this.songLengthMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.songLengthMin.Name = "songLengthMin";
            this.songLengthMin.Size = new System.Drawing.Size(41, 20);
            this.songLengthMin.TabIndex = 19;
            // 
            // songLengthSec
            // 
            this.songLengthSec.Location = new System.Drawing.Point(161, 39);
            this.songLengthSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.songLengthSec.Name = "songLengthSec";
            this.songLengthSec.Size = new System.Drawing.Size(41, 20);
            this.songLengthSec.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 211);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 50);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(75, 211);
            this.flowLayoutPanel2.TabIndex = 22;
            this.flowLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragZone);
            // 
            // addSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(217, 261);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.songLengthSec);
            this.Controls.Add(this.songLengthMin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.songYear);
            this.Controls.Add(this.albumCombo);
            this.Controls.Add(this.artistCombo);
            this.Controls.Add(this.genreCombo);
            this.Controls.Add(this.songName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addSongForm";
            this.Text = "addSongForm";
            this.Load += new System.EventHandler(this.addSongForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragZone);
            ((System.ComponentModel.ISupportInitialize)(this.songLengthMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songLengthSec)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox songName;
        private System.Windows.Forms.ComboBox genreCombo;
        private System.Windows.Forms.ComboBox artistCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox albumCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox songYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown songLengthMin;
        private System.Windows.Forms.NumericUpDown songLengthSec;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}