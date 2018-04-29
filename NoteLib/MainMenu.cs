using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NoteLib
{
    public partial class MainMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        DbHandle Database;
        public MainMenu()
        {
            Database = new DbHandle();
            InitializeComponent();
            this.BackColor = Color.Lime;
            this.TransparencyKey = Color.Lime;
        }

        private void dragZone(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

      

        private void addSong_Click(object sender, EventArgs e)
        {
            addSongForm frm = new addSongForm();
            frm.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Database.dbDestroy();
            this.Close();
        }

        private void addArtist_Click(object sender, EventArgs e)
        {
            addGenerics frm = new addGenerics(1);
            frm.ShowDialog();
        }

        private void fetchSongs_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = Database.sqlProcedureQuery("P_FETCH_SONGS");
        }

        private void fetchArtists_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.sqlCustomQuery("SELECT ARTIST_NAME as Artist FROM ArtistTB");
        }

        private void fetchGenres_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.sqlCustomQuery("SELECT GENRE_NAME as Genre FROM GenreTB");
        }

        private void searchByLength_Click(object sender, EventArgs e)
        {
            searchGenerics frm = new searchGenerics(1);
            frm.ShowDialog();
            string par = frm.searchPar;
            if(par == "GT")
                dataGridView1.DataSource = Database.sqlProcedureQuery("P_FETCH_SONGS_BY_LENGTH_GT", "length", SqlDbType.Int, frm.searchVal);
            if(par == "LT")
                dataGridView1.DataSource = Database.sqlProcedureQuery("P_FETCH_SONGS_BY_LENGTH_LT", "length", SqlDbType.Int, frm.searchVal);
            if(par == "EQ")
                dataGridView1.DataSource = Database.sqlProcedureQuery("P_FETCH_SONGS_BY_LENGTH_EQ", "length", SqlDbType.Int, frm.searchVal);
        }

        private void addGenre_Click(object sender, EventArgs e)
        {
            addGenerics frm = new addGenerics(2);
            frm.ShowDialog();
        }

        private void addAlbum_Click(object sender, EventArgs e)
        {
            addGenerics frm = new addGenerics(3);
            frm.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addSong.Visible == false)
            {
                flowLayoutPanel1.VerticalScroll.Visible = false;
                flowLayoutPanel1.HorizontalScroll.Visible = false;
                addArtist.Visible = true;
                addGenre.Visible = true;
                addAlbum.Visible = true;
                addSong.Visible = true;


                removeArtist.Visible = false;
                removeGenre.Visible = false;
                removeAlbum.Visible = false;
                removeSong.Visible = false;

                fetchArtists.Visible = false;
                fetchGenres.Visible = false;
                fetchSongs.Visible = false;

                searchByArtist.Visible = false;
                searchByGenre.Visible = false;
                searchByLength.Visible = false;
                searchByYear.Visible = false;
            }
            else
            {
                addArtist.Visible = false;
                addGenre.Visible = false;
                addAlbum.Visible = false;
                addSong.Visible = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchByArtist.Visible == false)
            {
                flowLayoutPanel1.VerticalScroll.Visible = false;
                flowLayoutPanel1.HorizontalScroll.Visible = false;
                searchByArtist.Visible = true;
                searchByGenre.Visible = true;
                searchByLength.Visible = true;
                searchByYear.Visible = true;

                addArtist.Visible = false;
                addGenre.Visible = false;
                addAlbum.Visible = false;
                addSong.Visible = false;

                removeArtist.Visible = false;
                removeGenre.Visible = false;
                removeAlbum.Visible = false;
                removeSong.Visible = false;

                fetchArtists.Visible = false;
                fetchGenres.Visible = false;
                fetchSongs.Visible = false;
            }
            else
            {
                searchByArtist.Visible = false;
                searchByGenre.Visible = false;
                searchByLength.Visible = false;
                searchByYear.Visible = false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (fetchArtists.Visible == false)
            {
                flowLayoutPanel1.VerticalScroll.Visible = false;
                flowLayoutPanel1.HorizontalScroll.Visible = false;
                fetchArtists.Visible = true;
                fetchGenres.Visible = true;
                fetchSongs.Visible = true;

                searchByArtist.Visible = false;
                searchByGenre.Visible = false;
                searchByLength.Visible = false;
                searchByYear.Visible = false;

                addArtist.Visible = false;
                addGenre.Visible = false;
                addAlbum.Visible = false;
                addSong.Visible = false;

                removeArtist.Visible = false;
                removeGenre.Visible = false;
                removeAlbum.Visible = false;
                removeSong.Visible = false;
            }
            else
            {
                fetchArtists.Visible = false;
                fetchGenres.Visible = false;
                fetchSongs.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("About : \n Designed and made by: Daniel Ivanov & CO. (2018) \n TU-Varna SIT 2015-2019");
        }

        private void searchByArtist_Click(object sender, EventArgs e)
        {
            searchGenerics frm = new searchGenerics(2);
            frm.ShowDialog();
            if (frm.searchVal != null)
                dataGridView1.DataSource = Database.sqlProcedureQuery("P_FETCH_SONGS_BY_ARTIST", "artistid", SqlDbType.Int, frm.searchVal);
        }

        private void searchByYear_Click(object sender, EventArgs e)
        {
            searchGenerics frm = new searchGenerics(3);
            frm.ShowDialog();
            if (frm.searchVal != null)
                dataGridView1.DataSource = Database.sqlProcedureQuery("P_FETCH_SONGS_BY_YEAR", "year", SqlDbType.Int, frm.searchVal);
        }

        private void searchByGenre_Click(object sender, EventArgs e)
        {
            searchGenerics frm = new searchGenerics(4);
            frm.ShowDialog();
            if(frm.searchVal != null)
                dataGridView1.DataSource = Database.sqlProcedureQuery("P_FETCH_SONGS_BY_GENRE", "genre_id", SqlDbType.Int, frm.searchVal);
        }

        private void removeAlbum_Click(object sender, EventArgs e)
        {
            searchGenerics frm = new searchGenerics(7);
            frm.ShowDialog();
        }

        private void removeGenre_Click(object sender, EventArgs e)
        {
            searchGenerics frm = new searchGenerics(8);
            frm.ShowDialog();
        }

        private void removeArtist_Click(object sender, EventArgs e)
        {
            searchGenerics frm = new searchGenerics(6);
            frm.ShowDialog();
        }

        private void removeSong_Click(object sender, EventArgs e)
        {
            searchGenerics frm = new searchGenerics(5);
            frm.ShowDialog();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (removeArtist.Visible == false)
            {
                flowLayoutPanel1.VerticalScroll.Visible = false;
                flowLayoutPanel1.HorizontalScroll.Visible = false;
                removeArtist.Visible = true;
                removeGenre.Visible = true;
                removeAlbum.Visible = true;
                removeSong.Visible = true;

                searchByArtist.Visible = false;
                searchByGenre.Visible = false;
                searchByLength.Visible = false;
                searchByYear.Visible = false;

                addArtist.Visible = false;
                addGenre.Visible = false;
                addAlbum.Visible = false;
                addSong.Visible = false;

                fetchArtists.Visible = false;
                fetchGenres.Visible = false;
                fetchSongs.Visible = false;
            }
            else
            {
                removeArtist.Visible = false;
                removeGenre.Visible = false;
                removeAlbum.Visible = false;
                removeSong.Visible = false;
            }
        }
    }
}
