namespace NoteLib
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fetchButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fetchSongs = new System.Windows.Forms.Button();
            this.fetchArtists = new System.Windows.Forms.Button();
            this.fetchGenres = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchByLength = new System.Windows.Forms.Button();
            this.searchByArtist = new System.Windows.Forms.Button();
            this.searchByYear = new System.Windows.Forms.Button();
            this.searchByGenre = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addSong = new System.Windows.Forms.Button();
            this.addArtist = new System.Windows.Forms.Button();
            this.addGenre = new System.Windows.Forms.Button();
            this.addAlbum = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.removeSong = new System.Windows.Forms.Button();
            this.removeArtist = new System.Windows.Forms.Button();
            this.removeGenre = new System.Windows.Forms.Button();
            this.removeAlbum = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fetchButton
            // 
            this.fetchButton.FlatAppearance.BorderSize = 0;
            this.fetchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.fetchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchButton.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchButton.ForeColor = System.Drawing.Color.White;
            this.fetchButton.Location = new System.Drawing.Point(0, 0);
            this.fetchButton.Margin = new System.Windows.Forms.Padding(0);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(178, 56);
            this.fetchButton.TabIndex = 1;
            this.fetchButton.Text = "Fetch Table";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.fetchButton);
            this.flowLayoutPanel1.Controls.Add(this.fetchSongs);
            this.flowLayoutPanel1.Controls.Add(this.fetchArtists);
            this.flowLayoutPanel1.Controls.Add(this.fetchGenres);
            this.flowLayoutPanel1.Controls.Add(this.searchButton);
            this.flowLayoutPanel1.Controls.Add(this.searchByLength);
            this.flowLayoutPanel1.Controls.Add(this.searchByArtist);
            this.flowLayoutPanel1.Controls.Add(this.searchByYear);
            this.flowLayoutPanel1.Controls.Add(this.searchByGenre);
            this.flowLayoutPanel1.Controls.Add(this.addButton);
            this.flowLayoutPanel1.Controls.Add(this.addSong);
            this.flowLayoutPanel1.Controls.Add(this.addArtist);
            this.flowLayoutPanel1.Controls.Add(this.addGenre);
            this.flowLayoutPanel1.Controls.Add(this.addAlbum);
            this.flowLayoutPanel1.Controls.Add(this.removeButton);
            this.flowLayoutPanel1.Controls.Add(this.removeSong);
            this.flowLayoutPanel1.Controls.Add(this.removeArtist);
            this.flowLayoutPanel1.Controls.Add(this.removeGenre);
            this.flowLayoutPanel1.Controls.Add(this.removeAlbum);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 576);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // fetchSongs
            // 
            this.fetchSongs.FlatAppearance.BorderSize = 0;
            this.fetchSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchSongs.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchSongs.ForeColor = System.Drawing.Color.DarkGray;
            this.fetchSongs.Location = new System.Drawing.Point(0, 56);
            this.fetchSongs.Margin = new System.Windows.Forms.Padding(0);
            this.fetchSongs.Name = "fetchSongs";
            this.fetchSongs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fetchSongs.Size = new System.Drawing.Size(178, 56);
            this.fetchSongs.TabIndex = 8;
            this.fetchSongs.Text = "Songs";
            this.fetchSongs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fetchSongs.UseVisualStyleBackColor = true;
            this.fetchSongs.Visible = false;
            this.fetchSongs.Click += new System.EventHandler(this.fetchSongs_Click);
            // 
            // fetchArtists
            // 
            this.fetchArtists.FlatAppearance.BorderSize = 0;
            this.fetchArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchArtists.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchArtists.ForeColor = System.Drawing.Color.DarkGray;
            this.fetchArtists.Location = new System.Drawing.Point(0, 112);
            this.fetchArtists.Margin = new System.Windows.Forms.Padding(0);
            this.fetchArtists.Name = "fetchArtists";
            this.fetchArtists.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fetchArtists.Size = new System.Drawing.Size(178, 56);
            this.fetchArtists.TabIndex = 9;
            this.fetchArtists.Text = "Artists";
            this.fetchArtists.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fetchArtists.UseVisualStyleBackColor = true;
            this.fetchArtists.Visible = false;
            this.fetchArtists.Click += new System.EventHandler(this.fetchArtists_Click);
            // 
            // fetchGenres
            // 
            this.fetchGenres.FlatAppearance.BorderSize = 0;
            this.fetchGenres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchGenres.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchGenres.ForeColor = System.Drawing.Color.DarkGray;
            this.fetchGenres.Location = new System.Drawing.Point(0, 168);
            this.fetchGenres.Margin = new System.Windows.Forms.Padding(0);
            this.fetchGenres.Name = "fetchGenres";
            this.fetchGenres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fetchGenres.Size = new System.Drawing.Size(178, 56);
            this.fetchGenres.TabIndex = 10;
            this.fetchGenres.Text = "Genres";
            this.fetchGenres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fetchGenres.UseVisualStyleBackColor = true;
            this.fetchGenres.Visible = false;
            this.fetchGenres.Click += new System.EventHandler(this.fetchGenres_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(0, 224);
            this.searchButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(178, 56);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchByLength
            // 
            this.searchByLength.FlatAppearance.BorderSize = 0;
            this.searchByLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchByLength.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByLength.ForeColor = System.Drawing.Color.DarkGray;
            this.searchByLength.Location = new System.Drawing.Point(0, 280);
            this.searchByLength.Margin = new System.Windows.Forms.Padding(0);
            this.searchByLength.Name = "searchByLength";
            this.searchByLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchByLength.Size = new System.Drawing.Size(178, 56);
            this.searchByLength.TabIndex = 11;
            this.searchByLength.Text = "By Length";
            this.searchByLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchByLength.UseVisualStyleBackColor = true;
            this.searchByLength.Visible = false;
            this.searchByLength.Click += new System.EventHandler(this.searchByLength_Click);
            // 
            // searchByArtist
            // 
            this.searchByArtist.FlatAppearance.BorderSize = 0;
            this.searchByArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchByArtist.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByArtist.ForeColor = System.Drawing.Color.DarkGray;
            this.searchByArtist.Location = new System.Drawing.Point(0, 336);
            this.searchByArtist.Margin = new System.Windows.Forms.Padding(0);
            this.searchByArtist.Name = "searchByArtist";
            this.searchByArtist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchByArtist.Size = new System.Drawing.Size(178, 56);
            this.searchByArtist.TabIndex = 12;
            this.searchByArtist.Text = "By Artist";
            this.searchByArtist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchByArtist.UseVisualStyleBackColor = true;
            this.searchByArtist.Visible = false;
            this.searchByArtist.Click += new System.EventHandler(this.searchByArtist_Click);
            // 
            // searchByYear
            // 
            this.searchByYear.FlatAppearance.BorderSize = 0;
            this.searchByYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchByYear.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByYear.ForeColor = System.Drawing.Color.DarkGray;
            this.searchByYear.Location = new System.Drawing.Point(0, 392);
            this.searchByYear.Margin = new System.Windows.Forms.Padding(0);
            this.searchByYear.Name = "searchByYear";
            this.searchByYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchByYear.Size = new System.Drawing.Size(178, 56);
            this.searchByYear.TabIndex = 13;
            this.searchByYear.Text = "By Year";
            this.searchByYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchByYear.UseVisualStyleBackColor = true;
            this.searchByYear.Visible = false;
            this.searchByYear.Click += new System.EventHandler(this.searchByYear_Click);
            // 
            // searchByGenre
            // 
            this.searchByGenre.FlatAppearance.BorderSize = 0;
            this.searchByGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchByGenre.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByGenre.ForeColor = System.Drawing.Color.DarkGray;
            this.searchByGenre.Location = new System.Drawing.Point(0, 448);
            this.searchByGenre.Margin = new System.Windows.Forms.Padding(0);
            this.searchByGenre.Name = "searchByGenre";
            this.searchByGenre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchByGenre.Size = new System.Drawing.Size(178, 56);
            this.searchByGenre.TabIndex = 14;
            this.searchByGenre.Text = "By Genre";
            this.searchByGenre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchByGenre.UseVisualStyleBackColor = true;
            this.searchByGenre.Visible = false;
            this.searchByGenre.Click += new System.EventHandler(this.searchByGenre_Click);
            // 
            // addButton
            // 
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(0, 504);
            this.addButton.Margin = new System.Windows.Forms.Padding(0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(178, 56);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add...";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addSong
            // 
            this.addSong.FlatAppearance.BorderSize = 0;
            this.addSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSong.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSong.ForeColor = System.Drawing.Color.DarkGray;
            this.addSong.Location = new System.Drawing.Point(0, 560);
            this.addSong.Margin = new System.Windows.Forms.Padding(0);
            this.addSong.Name = "addSong";
            this.addSong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addSong.Size = new System.Drawing.Size(178, 56);
            this.addSong.TabIndex = 15;
            this.addSong.Text = "Song";
            this.addSong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addSong.UseVisualStyleBackColor = true;
            this.addSong.Visible = false;
            this.addSong.Click += new System.EventHandler(this.addSong_Click);
            // 
            // addArtist
            // 
            this.addArtist.FlatAppearance.BorderSize = 0;
            this.addArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addArtist.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addArtist.ForeColor = System.Drawing.Color.DarkGray;
            this.addArtist.Location = new System.Drawing.Point(0, 616);
            this.addArtist.Margin = new System.Windows.Forms.Padding(0);
            this.addArtist.Name = "addArtist";
            this.addArtist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addArtist.Size = new System.Drawing.Size(178, 56);
            this.addArtist.TabIndex = 16;
            this.addArtist.Text = "Artist";
            this.addArtist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addArtist.UseVisualStyleBackColor = true;
            this.addArtist.Visible = false;
            this.addArtist.Click += new System.EventHandler(this.addArtist_Click);
            // 
            // addGenre
            // 
            this.addGenre.FlatAppearance.BorderSize = 0;
            this.addGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGenre.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGenre.ForeColor = System.Drawing.Color.DarkGray;
            this.addGenre.Location = new System.Drawing.Point(0, 672);
            this.addGenre.Margin = new System.Windows.Forms.Padding(0);
            this.addGenre.Name = "addGenre";
            this.addGenre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addGenre.Size = new System.Drawing.Size(178, 56);
            this.addGenre.TabIndex = 17;
            this.addGenre.Text = "Genre";
            this.addGenre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addGenre.UseVisualStyleBackColor = true;
            this.addGenre.Visible = false;
            this.addGenre.Click += new System.EventHandler(this.addGenre_Click);
            // 
            // addAlbum
            // 
            this.addAlbum.FlatAppearance.BorderSize = 0;
            this.addAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAlbum.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlbum.ForeColor = System.Drawing.Color.DarkGray;
            this.addAlbum.Location = new System.Drawing.Point(0, 728);
            this.addAlbum.Margin = new System.Windows.Forms.Padding(0);
            this.addAlbum.Name = "addAlbum";
            this.addAlbum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addAlbum.Size = new System.Drawing.Size(178, 56);
            this.addAlbum.TabIndex = 18;
            this.addAlbum.Text = "Album";
            this.addAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addAlbum.UseVisualStyleBackColor = true;
            this.addAlbum.Visible = false;
            this.addAlbum.Click += new System.EventHandler(this.addAlbum_Click);
            // 
            // removeButton
            // 
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(0, 784);
            this.removeButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(178, 56);
            this.removeButton.TabIndex = 19;
            this.removeButton.Text = "Remove...";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeSong
            // 
            this.removeSong.FlatAppearance.BorderSize = 0;
            this.removeSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSong.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSong.ForeColor = System.Drawing.Color.DarkGray;
            this.removeSong.Location = new System.Drawing.Point(0, 840);
            this.removeSong.Margin = new System.Windows.Forms.Padding(0);
            this.removeSong.Name = "removeSong";
            this.removeSong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.removeSong.Size = new System.Drawing.Size(178, 56);
            this.removeSong.TabIndex = 20;
            this.removeSong.Text = "Song";
            this.removeSong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeSong.UseVisualStyleBackColor = true;
            this.removeSong.Visible = false;
            this.removeSong.Click += new System.EventHandler(this.removeSong_Click);
            // 
            // removeArtist
            // 
            this.removeArtist.FlatAppearance.BorderSize = 0;
            this.removeArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeArtist.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeArtist.ForeColor = System.Drawing.Color.DarkGray;
            this.removeArtist.Location = new System.Drawing.Point(0, 896);
            this.removeArtist.Margin = new System.Windows.Forms.Padding(0);
            this.removeArtist.Name = "removeArtist";
            this.removeArtist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.removeArtist.Size = new System.Drawing.Size(178, 56);
            this.removeArtist.TabIndex = 21;
            this.removeArtist.Text = "Artist";
            this.removeArtist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeArtist.UseVisualStyleBackColor = true;
            this.removeArtist.Visible = false;
            this.removeArtist.Click += new System.EventHandler(this.removeArtist_Click);
            // 
            // removeGenre
            // 
            this.removeGenre.FlatAppearance.BorderSize = 0;
            this.removeGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeGenre.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGenre.ForeColor = System.Drawing.Color.DarkGray;
            this.removeGenre.Location = new System.Drawing.Point(0, 952);
            this.removeGenre.Margin = new System.Windows.Forms.Padding(0);
            this.removeGenre.Name = "removeGenre";
            this.removeGenre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.removeGenre.Size = new System.Drawing.Size(178, 56);
            this.removeGenre.TabIndex = 22;
            this.removeGenre.Text = "Genre";
            this.removeGenre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeGenre.UseVisualStyleBackColor = true;
            this.removeGenre.Visible = false;
            this.removeGenre.Click += new System.EventHandler(this.removeGenre_Click);
            // 
            // removeAlbum
            // 
            this.removeAlbum.FlatAppearance.BorderSize = 0;
            this.removeAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAlbum.Font = new System.Drawing.Font("Helonia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAlbum.ForeColor = System.Drawing.Color.DarkGray;
            this.removeAlbum.Location = new System.Drawing.Point(0, 1008);
            this.removeAlbum.Margin = new System.Windows.Forms.Padding(0);
            this.removeAlbum.Name = "removeAlbum";
            this.removeAlbum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.removeAlbum.Size = new System.Drawing.Size(178, 56);
            this.removeAlbum.TabIndex = 23;
            this.removeAlbum.Text = "Album";
            this.removeAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeAlbum.UseVisualStyleBackColor = true;
            this.removeAlbum.Visible = false;
            this.removeAlbum.Click += new System.EventHandler(this.removeAlbum_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Orange;
            this.flowLayoutPanel3.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(178, 73);
            this.flowLayoutPanel3.TabIndex = 4;
            this.flowLayoutPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragZone);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragZone);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 55, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "NoteLib";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragZone);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(169, 8);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0, 8, 0, 30);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 47);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(778, 73);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label2);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(181, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(385, 67);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(40, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "A simple Music Library";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.exitButton);
            this.flowLayoutPanel7.Controls.Add(this.button1);
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(569, 0);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(209, 70);
            this.flowLayoutPanel7.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(129, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 8, 0, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "?";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(178, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.Size = new System.Drawing.Size(600, 576);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(778, 649);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "NoteLib";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fetchButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fetchSongs;
        private System.Windows.Forms.Button fetchArtists;
        private System.Windows.Forms.Button fetchGenres;
        private System.Windows.Forms.Button searchByLength;
        private System.Windows.Forms.Button searchByArtist;
        private System.Windows.Forms.Button searchByYear;
        private System.Windows.Forms.Button searchByGenre;
        private System.Windows.Forms.Button addSong;
        private System.Windows.Forms.Button addArtist;
        private System.Windows.Forms.Button addGenre;
        private System.Windows.Forms.Button addAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button removeSong;
        private System.Windows.Forms.Button removeArtist;
        private System.Windows.Forms.Button removeGenre;
        private System.Windows.Forms.Button removeAlbum;
    }
}

