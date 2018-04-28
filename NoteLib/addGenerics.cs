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
    public partial class addGenerics : Form
    {
        int mode;
        DbHandle Db = new DbHandle();
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
                Db.insertGeneric("P_INSERT_ARTIST", "name", SqlDbType.VarChar, mainField.Text.ToString());
            }
            if(mode == 2)
            {
                Db.insertGeneric("P_INSERT_GENRE", "name", SqlDbType.VarChar, mainField.Text.ToString());
            }
            if(mode == 3)
            {
                Db.insertGeneric("P_INSERT_ALBUM", "name", SqlDbType.VarChar, mainField.Text.ToString(), "ARTIST_ID", SqlDbType.Int, comboBox1.SelectedValue.ToString());
            }
        }
    }
}
