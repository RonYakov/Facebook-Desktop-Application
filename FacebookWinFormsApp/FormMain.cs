using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private static FacebookWrapper.LoginResult m_LoginResult;
        private static readonly object s_LockObject = new object();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            if (m_LoginResult == null)
            {
                lock (s_LockObject)
                {
                    if (m_LoginResult == null)
                    {
                        m_LoginResult = FacebookService.Login(
                        "1081700156486616",
                        "public_profile",
                        "user_age_range",
                        "user_birthday",
                        "user_friends",
                        "user_gender",
                        "user_hometown",
                        "user_likes",
                        "user_location",
                        "user_photos",
                        "user_posts",
                        "user_videos",
                        "email"
                        );

                        //  m_LoginResult = FacebookService.Connect("EAAPXzPGUs9gBOwUZAOw9ekPgBfzdrzivZAlkh4g0ZCDZCBrrccUeI5J0nI5lmdnEDlJiG0NCrhQhycjP9DLCn9ivuFBKNJKFwVL42xwDwik7tsF7i0ftOjBhiZAsvDJ1hFSCdQhPwwvH7uX3TFHAfo1zGbRcqRUYu7UzvME8yVs8EteZBuKINfd6kc3ZCYG3drINEeS9P2oywZDZD");
                    }
                }
            }

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                FormFeed v_formFeed = new FormFeed();
                v_formFeed.m_FormMain = this;
                v_formFeed.m_LoggedInUser = m_LoginResult;
                v_formFeed.InitializeProfileValues();
                this.Visible = false;
                v_formFeed.ShowDialog();

                if(m_LoginResult != null)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Login failed, please try again.");
            }
        }

        internal void LogOut()
        {
            m_LoginResult = null;
        }

        public static LoginResult FacebookUser
        {
            get
            {
                if (m_LoginResult == null)
                {
                    lock (s_LockObject)
                    {
                        if (m_LoginResult == null)
                        {
                            throw new Exception("Error! You should be logged in.");
                        }
                    }
                }

                return m_LoginResult;
            }
        }
    }
}
