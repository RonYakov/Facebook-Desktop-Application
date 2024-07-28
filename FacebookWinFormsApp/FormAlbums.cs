using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormAlbums : Form
    {
        private FacebookObjectCollection<Album> m_Albums;
        private int m_AlbumId;
        internal FormFeed m_Feed { get; set; }

        public FormAlbums()
        {
            InitializeComponent();
        }

        internal void InitializeAlbums(FacebookObjectCollection<Album> i_Albums)
        {
            m_Albums = i_Albums;
            listBoxAlbums.Items.Clear();
            foreach (Album album in i_Albums)
            {
                listBoxAlbums.Items.Add(album);
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                listBoxAlbums.Items.Add("No albums available");
                listBoxAlbums.Enabled = false;
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            m_AlbumId = listBoxAlbums.SelectedIndex;
            labelAlbumsLikesAmount.Text = Utils.LikesAmount(m_Albums[listBoxAlbums.SelectedIndex].LikedBy).ToString();
            initializeAlbumComments(m_Albums[listBoxAlbums.SelectedIndex].Comments);
            initializeAlbumImages(m_Albums[listBoxAlbums.SelectedIndex].Photos);
        }

        private void initializeAlbumImages(FacebookObjectCollection<Photo> i_Photos)
        {
            listBoxImage.Items.Clear();
            foreach (Photo photo in i_Photos)
            {
                listBoxImage.Items.Add(photo);
            }
        }

        private void initializeAlbumComments(FacebookObjectCollection<Comment> i_Comments)
        {
            listBoxAlbumsComments.Items.Clear();
            foreach (Comment comment in i_Comments)
            {
                listBoxAlbumsComments.Items.Add(comment);
            }

            if (listBoxAlbumsComments.Items.Count == 0)
            {
                listBoxAlbumsComments.Items.Add("No comments available");
                listBoxAlbumsComments.Enabled = false;
            }
        }

        private void initializeImageComments(FacebookObjectCollection<Comment> i_Comments)
        {
            listBoxImagesComments.Items.Clear();
            foreach (Comment comment in i_Comments)
            {
                listBoxImagesComments.Items.Add(comment);
            }

            if (listBoxImagesComments.Items.Count == 0)
            {
                listBoxImagesComments.Items.Add("No comments available");
                listBoxImagesComments.Enabled = false;
            }
        }

        private void listBoxImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Photo v_SelectedPhoto = m_Albums[m_AlbumId].Photos[listBoxImage.SelectedIndex];
            
            pictureBox.LoadAsync(v_SelectedPhoto.PictureAlbumURL);
            labelImagesLikesAmount.Text = Utils.LikesAmount(v_SelectedPhoto.LikedBy).ToString();
            initializeImageComments(v_SelectedPhoto.Comments);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if(m_Feed != null)
            {
                m_Feed.Visible = true;
            }

            this.Close();
        }

        private void buttonSavePic_Click(object sender, EventArgs e)
        {
            if(listBoxImage.SelectedIndex != -1)
            {
                string v_ImageUrl = m_Albums[m_AlbumId].Photos[listBoxImage.SelectedIndex].PictureAlbumURL;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "JPEG Files (.jpg)|.jpg|All Files (.)|.";
                    saveFileDialog.Title = "Save Image";
                    saveFileDialog.FileName = "YourImage.jpg";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string v_DestinationPath = saveFileDialog.FileName;

                        try
                        {
                            using (WebClient client = new WebClient())
                            {
                                client.DownloadFile(v_ImageUrl, v_DestinationPath);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}
