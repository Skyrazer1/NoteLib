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
                addArtist.Visible = true;
                addGenre.Visible = true;
                addAlbum.Visible = true;
                addSong.Visible = true;
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
                searchByArtist.Visible = true;
                searchByGenre.Visible = true;
                searchByLength.Visible = true;
                searchByYear.Visible = true;
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
                fetchArtists.Visible = true;
                fetchGenres.Visible = true;
                fetchSongs.Visible = true;
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
    }
}
