using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    public partial class FormFacebookPage : Form
    {
        private string m_ErrorMessage = string.Empty;

        private readonly string r_PostMessage = "What's on your mind?";

        private MainFacebookPageFacade m_MainFacebookPageFacade;

        private ActionListBoxDecorator m_DecoratedPostListBox;

        private ActionListBoxDecorator m_DecoratedAlbumsListBox;

        private ActionListBoxDecorator m_DecoratedEventListBox;

        private ActionListBoxDecorator m_DecoratedFriendListBox;

        private ActionListBoxDecorator m_DecoratedFriendsBirthdayListBox;

        private ActionListBoxDecorator m_DecoratedLikedPagesListBox;

        private ActionListBoxDecorator m_DecoratedFavoriteTeamsListBox;

        private ActionListBoxDecorator m_DecoratedTaggedPlaceListBox;

        private bool v_IsFirstRun;

        public FormFacebookPage()
        {
            this.InitializeComponent();
            this.m_DecoratedPostListBox = new BlinkingListBox(new SoundListBox(this.listBoxPosts));
            this.m_DecoratedAlbumsListBox = new BlinkingListBox(this.listBoxAlbums);
            this.m_DecoratedEventListBox = new BlinkingListBox(this.listBoxEvents);
            this.m_DecoratedFriendListBox = new BlinkingListBox(this.listBoxFriends);
            this.m_DecoratedFriendsBirthdayListBox = new BlinkingListBox(this.listBoxFriendsBirthday);
            this.m_DecoratedLikedPagesListBox = new BlinkingListBox(this.listBoxLikes);
            this.m_DecoratedFavoriteTeamsListBox = new BlinkingListBox(this.listBoxFavoriteTeams);
            this.m_DecoratedTaggedPlaceListBox = new BlinkingListBox(this.listBoxTaggedPlaces);
            this.m_MainFacebookPageFacade = new MainFacebookPageFacade();
            this.m_MainFacebookPageFacade.m_ReportEventDelegate += this.importUserEvents;
            this.m_MainFacebookPageFacade.m_ReportAlbumsDelegate += this.importUserAlbums;
            this.m_MainFacebookPageFacade.m_ReportFriendsDelegate += this.importUserFriends;
            this.m_MainFacebookPageFacade.m_ReportFriendsBirthdayDelegate += this.importUserFriendsBirthday;
            this.m_MainFacebookPageFacade.m_ReportLikedPagesDelegate += this.importUserLikes;
            this.m_MainFacebookPageFacade.m_ReportPostsDelegate += this.importUserPost;
            this.m_MainFacebookPageFacade.m_ReportFavoriteTeamsDelegate += this.importUserFavoriteTeams;
            this.m_MainFacebookPageFacade.m_ReportTaggedPlacesDelegate += this.importUserTaggedPlaces;
            this.m_MainFacebookPageFacade.m_ReportErrorDelegate += this.errorMessageBox;
            this.checkBoxRememberMe.Checked = this.m_MainFacebookPageFacade.IsUserDetailsExist();
        }

        private void loginAndInit()
        {
            try
            {
                if (!this.m_MainFacebookPageFacade.IsConnected())
                {
                    this.v_IsFirstRun = true;
                    this.m_MainFacebookPageFacade.login();
                    new Thread(this.importUserValues).Start();
                    this.Invoke(new Action(() => this.v_IsFirstRun = false));
                }
            }
            catch
            {
                MessageBox.Show("Connection Error.");
            }
        }

        protected override void OnShown(EventArgs e)
        {
            this.v_IsFirstRun = true;
            base.OnShown(e);
            if (this.m_MainFacebookPageFacade.IsTokenExistThenConnect())
            {
                new Thread(logInAutomatically).Start();
                this.v_IsFirstRun = false;
            }
        }

        private void logInAutomatically()
        {
            this.buttonLogin.Invoke(new Action(() => this.buttonLogin.Visible = false));
            this.buttonRefresh.Invoke(new Action(() => this.buttonRefresh.Visible = true));
            this.checkBoxRememberMe.Invoke(new Action(() => this.checkBoxRememberMe.Visible = false));
            this.buttonLogout.Invoke(new Action(() => this.buttonLogout.Visible = true));
            this.importUserValues();
        }

        private void loggedOutFinished()
        {
            this.clearUserData();
            MessageBox.Show("You are now logged out!");
        }

        private void importUserValues()
        {
            this.buttonRefresh.Invoke(new Action(() => this.buttonRefresh.Enabled = false));
            this.buttonLogout.Invoke(new Action(() => this.buttonLogout.Enabled = false));
            this.buttonLogin.Invoke(new Action(() => this.buttonLogin.Enabled = false));
            this.Invoke(new Action(() => this.logicFacebookPageBindingSource.DataSource = this.m_MainFacebookPageFacade));
            if (this.m_MainFacebookPageFacade.IsTokenExist())
            {
                this.Invoke(new Action(() => this.logicFacebookPageBindingSource.ResumeBinding()));
                this.textBoxPost.Invoke(new Action(() => this.textBoxPost.Text = this.r_PostMessage));
                this.textBoxPost.ForeColor = SystemColors.GrayText;
                this.labelCountToBirhday.Invoke(new Action(() => this.startToCalculateTimeToBirthday()));
            }

            if (this.Visible)
            {
                this.buttonLogout.Invoke(new Action(() => this.buttonLogout.Enabled = true));
                this.buttonLogin.Invoke(new Action(() => this.buttonLogin.Enabled = true));
                this.buttonRefresh.Invoke(new Action(() => this.buttonRefresh.Enabled = true));
            }
        }

        private void startToCalculateTimeToBirthday()
        {
            this.labelCountToBirhday.Text = this.m_MainFacebookPageFacade.ImportTimeToBirthday();
            this.timer.Start();
        }

        private void importToListBoxFromStringList(ListBox i_ListBoxToFill, List<string> i_StringListToImport)
        {
            foreach (string item in i_StringListToImport)
            {
                i_ListBoxToFill.Invoke(new Action(() => i_ListBoxToFill.Items.Add(item)));
            }
        }

        private void postStatus()
        {
            if (!string.IsNullOrEmpty(this.textBoxPost.Text) && this.textBoxPost.ForeColor == SystemColors.WindowText)
            {
                this.m_MainFacebookPageFacade.PostStatus(this.textBoxPost.Text);
            }
            else
            {
                MessageBox.Show("Write a post please.");
            }
        }

        private void importUserPost(List<string> i_Posts)
        {
            this.listBoxPosts.Invoke(new Action(() => this.listBoxPosts.Items.Clear()));
            this.importToListBoxFromStringList(this.listBoxPosts, i_Posts);
            if (!this.v_IsFirstRun)
            {
                this.m_DecoratedPostListBox.Operation();
            }
        }

        private void importUserFriends(List<string> i_Friends)
        {
            this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.Items.Clear()));
            this.importToListBoxFromStringList(this.listBoxFriends, i_Friends);
            if (!this.v_IsFirstRun)
            {
                this.m_DecoratedFriendListBox.Operation();
            }
        }

        private void importUserLikes(List<string> i_LikedPages)
        {
            this.listBoxLikes.Invoke(new Action(() => this.listBoxLikes.Items.Clear()));
            this.importToListBoxFromStringList(this.listBoxLikes, i_LikedPages);
            if (!this.v_IsFirstRun)
            {
                this.m_DecoratedLikedPagesListBox.Operation();
            }
        }

        private void importUserEvents(List<string> i_Events)
        {
            this.listBoxEvents.Invoke(new Action(() => this.listBoxEvents.Items.Clear()));
            this.importToListBoxFromStringList(this.listBoxEvents, i_Events);
            if (!this.v_IsFirstRun)
            {
                this.m_DecoratedEventListBox.Operation();
            }
        }

        private void importUserAlbums(List<string> i_Albums)
        {
            this.listBoxAlbums.Invoke(new Action(() => this.listBoxAlbums.Items.Clear()));
            this.importToListBoxFromStringList(this.listBoxAlbums, i_Albums);
            if (!this.v_IsFirstRun)
            {
                this.m_DecoratedAlbumsListBox.Operation();
            }
        }

        private void importUserFavoriteTeams(List<string> i_FavoriteTeams)
        {
            this.listBoxFavoriteTeams.Invoke(new Action(() => this.listBoxFavoriteTeams.Items.Clear()));
            this.importToListBoxFromStringList(this.listBoxFavoriteTeams, i_FavoriteTeams);
            if (!this.v_IsFirstRun)
            {
                this.m_DecoratedFavoriteTeamsListBox.Operation();
            }
        }

        private void importUserTaggedPlaces(List<string> i_TaggedPlaces)
        {
            this.listBoxTaggedPlaces.Invoke(new Action(() => this.listBoxTaggedPlaces.Items.Clear()));
            this.importToListBoxFromStringList(this.listBoxTaggedPlaces, i_TaggedPlaces);
            if (!this.v_IsFirstRun)
            {
                this.m_DecoratedTaggedPlaceListBox.Operation();
            }
        }

        private void importUserFriendsBirthday(List<string> i_FriendsBirthday)
        {
            this.listBoxFriendsBirthday.Invoke(new Action(() => this.listBoxFriendsBirthday.Items.Clear()));
            this.importToListBoxFromStringList(this.listBoxFriendsBirthday, i_FriendsBirthday);
            if (!this.v_IsFirstRun)
            {
                this.m_DecoratedFriendsBirthdayListBox.Operation();
            }
        }

        private void clearUserData()
        {
            this.timer.Stop();
            this.labelCountToBirhday.Invoke(new Action(() => this.labelCountToBirhday.Text = string.Empty));
            this.Invoke(new Action(() => this.logicFacebookPageBindingSource.SuspendBinding()));
            this.clearListBoxesData();
        }

        private void clearListBoxesData()
        {
            this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.Items.Clear()));
            this.listBoxPosts.Invoke(new Action(() => this.listBoxPosts.Items.Clear()));
            this.listBoxAlbums.Invoke(new Action(() => this.listBoxAlbums.Items.Clear()));
            this.listBoxEvents.Invoke(new Action(() => this.listBoxEvents.Items.Clear()));
            this.listBoxFriendsBirthday.Invoke(new Action(() => this.listBoxFriendsBirthday.Items.Clear()));
            this.listBoxTaggedPlaces.Invoke(new Action(() => this.listBoxTaggedPlaces.Items.Clear()));
            this.listBoxFavoriteTeams.Invoke(new Action(() => this.listBoxFavoriteTeams.Items.Clear()));
            this.listBoxLikes.Invoke(new Action(() => this.listBoxLikes.Items.Clear())); ;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.labelCountToBirhday.Text = this.m_MainFacebookPageFacade.Tick();
            if (this.labelCountToBirhday.Text == "Happy Birthday!!")
            {
                this.timer.Stop();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            this.m_MainFacebookPageFacade.RememberToken(this.checkBoxRememberMe.Checked);
        }

        private void listBoxEvents_MouseMove(object sender, MouseEventArgs e)
        {
            int i_indexEvent = this.listBoxEvents.IndexFromPoint(e.Location);
            this.toolTipEvents.SetToolTip(this.listBoxEvents, this.m_MainFacebookPageFacade.EventCounter(i_indexEvent));
        }

        private void textBoxPost_Leave(object sender, EventArgs e)
        {
            if (this.textBoxPost.Text.Length == 0)
            {
                this.textBoxPost.Text = this.r_PostMessage;
                this.textBoxPost.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBoxPost_Enter(object sender, EventArgs e)
        {
            if (this.textBoxPost.Text == this.r_PostMessage)
            {
                this.textBoxPost.Text = string.Empty;
                this.textBoxPost.ForeColor = SystemColors.WindowText;
            }
        }

        private void reconnect()
        {
            this.m_MainFacebookPageFacade.ConnectToFacebookService();
            this.importUserValues();
            this.buttonLogout.Invoke(new Action(() => this.buttonLogout.Enabled = true));
            this.buttonRefresh.Invoke(new Action(() => this.buttonRefresh.Enabled = true));
        }

        private void errorMessageBox(string i_ErrorMessage)
        {
            MessageBox.Show( i_ErrorMessage);
        }

        private void buttomLogout_Click(object sender, EventArgs e)
        {
            this.m_MainFacebookPageFacade.Logout();
            this.loggedOutFinished();
            this.buttonLogin.Visible = true;
            this.buttonLogout.Visible = false;
            this.buttonRefresh.Visible = false;
            this.checkBoxRememberMe.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.loginAndInit();
            if (this.m_MainFacebookPageFacade.DidLoginSuccessded())
            {
                this.buttonLogin.Visible = false;
                this.buttonLogout.Visible = true;
                this.buttonRefresh.Visible = true;
                this.checkBoxRememberMe.Visible = false;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.buttonLogout.Invoke(new Action(() => this.buttonLogout.Enabled = false));
            this.buttonRefresh.Invoke(new Action(() => this.buttonRefresh.Enabled = false));
            new Thread(this.reconnect).Start();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            this.postStatus();
        }
    }
}