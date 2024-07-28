using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormFeed : Form
    {
        internal FacebookWrapper.LoginResult m_LoggedInUser { get; set; }
        internal FormMain m_FormMain { get; set; }

        public FormFeed()
        {
            InitializeComponent();
        }

        public void InitializeProfileValues()
        {
            pictureBoxProfilePicture.LoadAsync(m_LoggedInUser.LoggedInUser.PictureNormalURL);
            labelAge.Text = nullStringChecker(calculateAge(m_LoggedInUser.LoggedInUser.Birthday).ToString());
            labelBirthday.Text = nullStringChecker(m_LoggedInUser.LoggedInUser.Birthday);
            labelEmail.Text = nullStringChecker(m_LoggedInUser.LoggedInUser.Email);
            labelGender.Text = nullStringChecker(m_LoggedInUser.LoggedInUser.Gender.ToString());
            labelHometown.Text = nullHometownAndLocationChecker(m_LoggedInUser.LoggedInUser.Hometown);
            labelLocation.Text = nullHometownAndLocationChecker(m_LoggedInUser.LoggedInUser.Location);
            labelName.Text = nullStringChecker(m_LoggedInUser.LoggedInUser.Name);
            friendsIntializer();
            likedPagesIntializer();
        }

        private void friendsIntializer()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            foreach(User friend in m_LoggedInUser.LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend);
            }

            if(listBoxFriends.Items.Count == 0)
            {
                listBoxFriends.Items.Add("No friends available");
                listBoxFriends.Enabled = false;
            }
        }

        private void likedPagesIntializer()
        {
            listBoxLikesPages.Items.Clear();
            listBoxLikesPages.DisplayMember = "Name";
            foreach (Page page in m_LoggedInUser.LoggedInUser.LikedPages)
            {
                listBoxLikesPages.Items.Add(page);
            }

            if (listBoxLikesPages.Items.Count == 0)
            {
                listBoxLikesPages.Items.Add("No Pages available");
                listBoxLikesPages.Enabled = false;
            }
        }

        private int calculateAge(string i_birthday)
        {
            DateTime.TryParseExact(i_birthday, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime v_Birthdate);
            
                DateTime currentDate = DateTime.Now;
            int v_Age = currentDate.Year - v_Birthdate.Year;
            if (currentDate < v_Birthdate.AddYears(v_Age))
            {
                v_Age--;
            }

            return v_Age;
        }

        private String nullStringChecker(String i_StringToCheck)
        {
            String v_output;

            if(i_StringToCheck == null)
            {
                v_output = "Not allowed";
            }
            else 
            {
                v_output = i_StringToCheck;
            }

            return v_output;
        }

        private String nullHometownAndLocationChecker(City i_City)
        {
            String v_Output;

            if(i_City == null) 
            {
                v_Output = nullStringChecker(null);
            }
            else
            {
                v_Output = nullStringChecker(i_City.Name);
            }

            return v_Output;
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            FormAlbums v_formAlbums = new FormAlbums();
            v_formAlbums.m_Feed = this;
            v_formAlbums.InitializeAlbums(m_LoggedInUser.LoggedInUser.Albums);
            this.Visible = false;
            v_formAlbums.ShowDialog();
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            FormPosts v_formPosts = new FormPosts();
            v_formPosts.m_Feed = this;
            v_formPosts.m_LoggedInUser = m_LoggedInUser;
            v_formPosts.InitializePosts(m_LoggedInUser.LoggedInUser.Posts);
            this.Visible = false;
            v_formPosts.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_FormMain.LogOut();
            FacebookService.LogoutWithUI();
            m_FormMain.Visible = true;
            this.Close();
        }

        private void listBoxLikesPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page v_SelecetedPage = m_LoggedInUser.LoggedInUser.LikedPages[listBoxLikesPages.SelectedIndex];

            if (v_SelecetedPage.PictureURL != null)
            {
                pictureBoxPage.LoadAsync(v_SelecetedPage.PictureNormalURL);
            }
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            FormStatistics v_formStatistics = new FormStatistics();
            v_formStatistics.m_Feed = this;
            v_formStatistics.m_LoggedInUser = m_LoggedInUser;
            this.Visible = false;
            v_formStatistics.ShowDialog();
        }
    }
}
