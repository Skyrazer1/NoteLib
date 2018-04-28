using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteLib
{
    public partial class addSongForm : Form
    {
        DbHandle Db = new DbHandle();
        public addSongForm()
        {
            InitializeComponent();

            DateTime td = DateTime.Today;
            songYear.Text = td.Year.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            String strTmp = "00:" + songLengthMin.Text.ToString() + ":" + songLengthSec.Text.ToString();
            dt = DateTime.Parse(strTmp);
            int length = dt.Minute*60;
            length += dt.Second;
            try
            {
                if (albumCombo.SelectedValue != null)
                    Db.insertSong(
                        songName.Text.ToString(),
                        length,
                        int.Parse(genreCombo.SelectedValue.ToString()),
                        int.Parse(artistCombo.SelectedValue.ToString()),
                        int.Parse(songYear.Text.ToString()),
                        int.Parse(albumCombo.SelectedValue.ToString()));
                else
                    Db.insertSong(
                     songName.Text.ToString(),
                     length,
                     int.Parse(genreCombo.SelectedValue.ToString()),
                     int.Parse(artistCombo.SelectedValue.ToString()),
                     int.Parse(songYear.Text.ToString()));
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
            Db.dbDestroy();

        }

        private void addSongForm_Load(object sender, EventArgs e)
        {
            try
            {
                artistCombo.ValueMember = "Id";
                artistCombo.DisplayMember = "ARTIST_NAME";
                artistCombo.DataSource = Db.sqlCustomQuery("SELECT Id, ARTIST_NAME FROM ArtistTB");

                genreCombo.ValueMember = "Id";
                genreCombo.DisplayMember = "GENRE_NAME";
                genreCombo.DataSource = Db.sqlCustomQuery("SELECT * FROM GenreTB");
             }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
   
        }

        private void artistCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            albumCombo.ValueMember = "Id";
            albumCombo.DisplayMember = "ALBUM_NAME";
            albumCombo.DataSource = Db.sqlCustomQuery("SELECT * FROM AlbumTb WHERE ARTIST_ID = " + artistCombo.SelectedValue.ToString());
                }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(songYear.Text.ToString());
            a--;
            songYear.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(songYear.Text.ToString());
            a++;
            songYear.Text = a.ToString();
        }
    }
}
