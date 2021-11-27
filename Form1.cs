using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSICART_APP
{
    public partial class SongView : Form
    {
        MusicArtEntities12 db;
        public SongView()
        {
            InitializeComponent();
            db = new MusicArtEntities12 ();
            dataGridView1.DataSource = db.SongViews.ToList();
           
        }

        private void btnUploadSong_Click(object sender, EventArgs e)
        {   

            int Album;
            int.TryParse(txtAlbum.Text, out Album);
            decimal Price;
            decimal.TryParse(txtPrice.Text, out Price);
            DateTime releaseDate = DateTime.Now;
            var SongID = db.uspUploadSong(txtSong.Text,txtTitle.Text,Album,txtGenre.Text,releaseDate,Price);
            if (SongID != null)
            {
                MessageBox.Show("New Song has been uploaded", "Upload Music", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = db.uspGetSongs().ToList();
            }
           
            
        }

        private void btnSearchSong_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.uspGetSongName(txtSearchSong.Text).ToList();
        }


        private void SongView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSongID_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.uspGetSongID(txtSongID.Text).ToList();
        }

        private void BtnSearchAlbum_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.uspGetAlbumName(txtAlbumTitle.Text).ToList();
            var AlbumID = db.uspUploadAlbum(txtAlbumTitle.Text);

            if (AlbumID != null)
            {
                dataGridView1.DataSource = db.uspGetAlbum().ToList();
            }
        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            
            var song = db.uspDeleteMusic(txtSongID.Text);

            if(song!= null)
            {
                dataGridView1.DataSource = db.uspGetSongs().ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var alb = db.uspDeleteAlbum(txtAlbumID.Text);
            if (alb != null)
            {
                dataGridView1.DataSource = db.uspGetAlbum().ToList();
            }
        }

        private void btnSearchAlbum2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.uspGetAlbumName(txtSearchAlbumm.Text).ToList();
        }
    }
}
