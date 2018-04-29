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
    public partial class searchGenerics : Form
    {
        int searchMode;

        public string searchVal { get; set; }

        public string searchPar { get; set; }

        DbHandle db = new DbHandle();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void dragZone(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public searchGenerics(int mode)
        {
            searchMode = mode;
            InitializeComponent();
        }

        private void searchGenerics_Load(object sender, EventArgs e)
        {
            try
            {
                switch (searchMode)
                {
                    case 1:
                        {
                            //Search by length
                            label1.Visible = true;
                            label1.Text = "Searching by Song Length :";
                            numericUpDown1.Visible = true;
                            numericUpDown2.Visible = true;
                            groupBox1.Visible = true;
                            radioEQ.Visible = true;
                            radioGT.Visible = true;
                            radioLT.Visible = true;
                            break;
                        }
                    case 2:
                        {
                            //Search by artist
                            label1.Visible = true;
                            label1.Text = "Searching by Song Artist :";
                            searchCombo.Visible = true;
                            searchCombo.ValueMember = "Id";
                            searchCombo.DisplayMember = "ARTIST_NAME";
                            searchCombo.DataSource = db.sqlCustomQuery("SELECT * FROM ArtistTb");
                            break;
                        }
                    case 3:
                        {
                            //Search by year
                            label1.Visible = true;
                            label1.Text = "Searching by Song Year :";
                            searchCombo.Visible = true;
                            searchCombo.ValueMember = "SONG_YEAR";
                            searchCombo.DisplayMember = "SONG_YEAR";
                            searchCombo.DataSource = db.sqlCustomQuery("SELECT SONG_YEAR FROM SongListTb");
                            break;
                        }
                    case 4:
                        {
                            //Search by genre
                            label1.Visible = true;
                            label1.Text = "Searching by Song Genre :";
                            searchCombo.Visible = true;
                            searchCombo.ValueMember = "Id";
                            searchCombo.DisplayMember = "GENRE_NAME";
                            searchCombo.DataSource = db.sqlCustomQuery("SELECT * FROM GenreTb");
                            break;
                        }
                    case 5:
                        {
                            //Delete Song
                            label1.Visible = true;
                            label1.Text = "Delete Song :";
                            searchCombo.Visible = true;
                            searchCombo.ValueMember = "Id";
                            searchCombo.DisplayMember = "SONG_NAME";
                            searchCombo.DataSource = db.sqlCustomQuery("SELECT * FROM SongListTb");
                            break;
                        }
                    case 6:
                        {
                            //Delete Artist
                            label1.Visible = true;
                            label1.Text = "Delete Artist :";
                            searchCombo.Visible = true;
                            searchCombo.ValueMember = "Id";
                            searchCombo.DisplayMember = "ARTIST_NAME";
                            searchCombo.DataSource = db.sqlCustomQuery("SELECT * FROM ArtistTb");
                            break;
                        }
                    case 7:
                        {
                            //Delete Album
                            label1.Visible = true;
                            label1.Text = "Delete Album :";
                            searchCombo.Visible = true;
                            searchCombo.ValueMember = "Id";
                            searchCombo.DisplayMember = "ALBUM_NAME";
                            searchCombo.DataSource = db.sqlCustomQuery("SELECT * FROM AlbumTb");
                            break;
                        }
                    case 8:
                        {
                            //Delete Genre 
                            label1.Visible = true;
                            label1.Text = "Delete Genre :";
                            searchCombo.Visible = true;
                            searchCombo.ValueMember = "Id";
                            searchCombo.DisplayMember = "GENRE_NAME";
                            searchCombo.DataSource = db.sqlCustomQuery("SELECT * FROM GenreTb");
                            break;
                        }
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message.ToString()); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            db.dbDestroy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (searchMode)
            {
                case 1:
                    {
                        //by length
                        int length = int.Parse(numericUpDown1.Value.ToString()) * 60;
                        length += int.Parse(numericUpDown2.Value.ToString());
                        searchVal = length.ToString();
                        if(radioEQ.Checked)
                            searchPar = "EQ";
                        if (radioGT.Checked)
                            searchPar = "GT";
                        if (radioLT.Checked)
                            searchPar = "LT";
                        this.Close();
                        break;
                    }
                case 2:
                    {
                        //by artist
                        searchVal = searchCombo.SelectedValue.ToString();
                        this.Close();
                        break;
                    }
                case 3:
                    {
                        // by year
                        searchVal = searchCombo.SelectedValue.ToString();
                        this.Close();
                        break;
                    }
                case 4:
                    {
                        //by genre
                        searchVal = searchCombo.SelectedValue.ToString();
                        this.Close();
                        break;
                    }
                case 5:
                    {
                        //delete song
                        db.sqlProcedureQuery("P_DELETE_SONG", "songid", SqlDbType.Int, searchCombo.SelectedValue.ToString());
                        db.dbDestroy();
                        this.Close();
                        break;
                    }
                case 6:
                    {
                        //delete artist
                        if (db.sqlProcedureQuery("P_FETCH_SONGS_BY_ARTIST","artistid", SqlDbType.Int, searchCombo.SelectedValue.ToString()).Rows.Count == 0 &&
                            db.sqlCustomQuery("SELECT * FROM AlbumTb WHERE ARTIST_ID = " + searchCombo.SelectedValue.ToString()).Rows.Count == 0)
                        {
                            db.sqlProcedureQuery("P_DELETE_ARTIST", "artistid", SqlDbType.Int, searchCombo.SelectedValue.ToString());
                            db.dbDestroy();
                            this.Close();
                        }
                        else
                            MessageBox.Show("Cannot delete Artist! There are song or album entries who depend on this.");
                        break;
                    }
                case  7:
                    {
                        //delete Album
                        if (db.sqlCustomQuery("SELECT * FROM SongListTb WHERE ALBUM_ID = " + searchCombo.SelectedValue.ToString()).Rows.Count == 0)
                        {
                            db.sqlProcedureQuery("P_DELETE_ALBUM", "albumid", SqlDbType.Int, searchCombo.SelectedValue.ToString());
                            db.dbDestroy();
                            this.Close();
                        }
                        else
                            MessageBox.Show("Album can not be deleted! It has dependencies in a song entry.");
                        break;
                    }
                case 8:
                    {
                        //delete genre
                        if (db.sqlCustomQuery("SELECT * FROM SongListTb WHERE SONG_GENRE_ID = " + searchCombo.SelectedValue.ToString()).Rows.Count == 0)
                        {
                            db.sqlProcedureQuery("P_DELETE_GENRE", "genreid", SqlDbType.Int, searchCombo.SelectedValue.ToString());
                            db.dbDestroy();
                            this.Close();
                        }
                        else
                            MessageBox.Show("Genre can not be deleted! It has dependencies in a song entry.");
                        break;
                    }
            }
        }
    }
}
