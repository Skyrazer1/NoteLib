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
    public partial class addSongForm : Form
    {
        DbHandle Db = new DbHandle();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public addSongForm()
        {
            InitializeComponent();

            DateTime td = DateTime.Today;
            songYear.Text = td.Year.ToString();
        }

        private void dragZone(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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
            if (songName.Text.ToString().Length != 0 && length != 0)
            {
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
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString());
                }
                Db.dbDestroy();
                this.Close();
            }
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
