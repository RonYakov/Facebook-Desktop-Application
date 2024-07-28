using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormPosts : Form
    {
        internal FacebookWrapper.LoginResult m_LoggedInUser { get; set; }
        internal FormFeed m_Feed { get; set; }
        private int m_PostId;

        public FormPosts()
        {
            InitializeComponent();
        }

        internal void InitializePosts(FacebookObjectCollection<Post> i_Posts)
        {
            listBoxPosts.Items.Clear();
            foreach(Post v_Post in i_Posts)
            {
                listBoxPosts.Items.Add(v_Post);
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                Status v_PostedStatus = m_LoggedInUser.LoggedInUser.PostStatus(textBoxNewPostData.Text);
                MessageBox.Show($"Status posted successfully! ID: {v_PostedStatus.Id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem occurred! (FacebookAPI)");
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (m_Feed != null)
            {
                m_Feed.Visible = true;
            }

            this.Close();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_PostId = listBoxPosts.SelectedIndex;
            Post v_ChosenPost = m_LoggedInUser.LoggedInUser.Posts[m_PostId];
            labelPostMessage.Text = $"\"{v_ChosenPost.Message}\"";
       //   labelLikes.Text = Utils.LikesAmount(v_ChosenPost.LikedBy).ToString();
            labelPostedBy.Text = v_ChosenPost.From.Name;
            labelPublishedDate.Text = v_ChosenPost.CreatedTime.ToString();
            if(v_ChosenPost.PictureURL != null)
            {
                pictureBox.LoadAsync(v_ChosenPost.PictureURL);
            }
            else
            {
                pictureBox.Image = null;
            }

            initializePostsComments(v_ChosenPost.Comments);
        }

        private void initializePostsComments(FacebookObjectCollection<Comment> i_Comments)
        {
            listBoxComments.Items.Clear();
            foreach (Comment comment in i_Comments)
            {
                listBoxComments.Items.Add(comment);
            }

            if (listBoxComments.Items.Count == 0)
            {
                listBoxComments.Items.Add("No comments available");
                listBoxComments.Enabled = false;
            }
        }
    }
}
