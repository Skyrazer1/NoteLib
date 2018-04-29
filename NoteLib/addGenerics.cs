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
    public partial class addGenerics : Form
    {
        int mode;
        DbHandle Db = new DbHandle();

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

        public addGenerics(int md)
        {
            mode = md;
            InitializeComponent();
           
            if(mode == 1)
            {
                label1.Text = "Artist Name : ";
                label2.Dispose();
                comboBox1.Dispose();
            }
            if(mode == 2)
            {
                label1.Text = "Genre";
                label2.Dispose();
                comboBox1.Dispose();
            }
            if(mode == 3)
            {
                label1.Text = "Album Name";
                label2.Text = "Artist";
                label2.Visible = true;
                comboBox1.Visible = true;
                comboBox1.DisplayMember = "ARTIST_NAME";
                comboBox1.ValueMember = "Id";
                comboBox1.DataSource = Db.sqlCustomQuery("SELECT * FROM ArtistTB");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(mode == 1)
            {
                if (mainField.Text.ToString().Length != 0)
                {
                    Db.insertGeneric("P_INSERT_ARTIST", "name", SqlDbType.VarChar, mainField.Text.ToString());
                    Db.dbDestroy();
                    this.Close();
                }
            }
            if(mode == 2)
            {
                if (mainField.Text.ToString().Length != 0)
                {
                    Db.insertGeneric("P_INSERT_GENRE", "name", SqlDbType.VarChar, mainField.Text.ToString());
                    Db.dbDestroy();
                    this.Close();
                }
                
            }
            if(mode == 3)
            {
                if (mainField.Text.ToString().Length != 0)
                {
                    Db.insertGeneric("P_INSERT_ALBUM", "name", SqlDbType.VarChar, mainField.Text.ToString(), "ARTIST_ID", SqlDbType.Int, comboBox1.SelectedValue.ToString());
                    Db.dbDestroy();
                    this.Close();
                }
               
            }
        }
    }
}
