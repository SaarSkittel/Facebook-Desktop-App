using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Linq;

namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    public delegate void ReportErrorDelegate(string i_ErrorMessage);

    public delegate void ReportListUpdateDelegate(List<string> i_List);

    public class MainFacebookPageFacade
    {
        private List<string> m_EventsList;

        private LoginResult m_LoginResult;

        private User m_LoggedInUser;

        private Clock m_TimeForBirthday;

        private LoginDetails m_loginDetails;

        private List<string> m_OldEvents;

        private string m_ErrorMessage = string.Empty;

        public event ReportErrorDelegate m_ReportErrorDelegate;

        public event ReportListUpdateDelegate m_ReportEventDelegate;

        public event ReportListUpdateDelegate m_ReportPostsDelegate;

        public event ReportListUpdateDelegate m_ReportAlbumsDelegate;

        public event ReportListUpdateDelegate m_ReportTaggedPlacesDelegate;

        public event ReportListUpdateDelegate m_ReportFriendsDelegate;

        public event ReportListUpdateDelegate m_ReportFriendsBirthdayDelegate;

        public event ReportListUpdateDelegate m_ReportFavoriteTeamsDelegate;

        public event ReportListUpdateDelegate m_ReportLikedPagesDelegate;

        private List<string> m_ListOfEventsLastUpdate;

        private List<string> m_ListOfPostsLastUpdate;

        private List<string> m_ListOfAlbumsLastUpdate;

        private List<string> m_ListOfTaggedPlacesLastUpdate;

        private List<string> m_ListOfFriendsLastUpdate;

        private List<string> m_ListOfFriendsBirthdayLastUpdate;

        private List<string> m_ListOfFavoriteTeamsLastUpdate;

        private List<string> m_ListOfLikedPagesLastUpdate;

        private Timer RefershTimer;

        public MainFacebookPageFacade()
        {
            this.m_loginDetails = LoginDetails.LoadFromFile();
            m_TimeForBirthday = ClockFactoryMethod.ClockCreator(eClock.BirthdayClock);
        }

        public void login()
        {
            if (this.m_LoginResult == null)
            {
                this.m_LoginResult = FacebookService.Login(
                        "682689342230475",
                        "public_profile",
                        "email",
                        "publish_to_groups",
                        "user_birthday",
                        "user_age_range",
                        "user_gender",
                        "user_link",
                        "user_tagged_places",
                        "user_videos",
                        "publish_to_groups",
                        "groups_access_member_info",
                        "user_friends",
                        "user_events",
                        "user_likes",
                        "user_location",
                        "user_photos",
                        "user_posts",
                        "user_hometown",
                        "user_managed_groups",
                        "read_page_mailboxes",
                        "user_status");
                this.notify();
                this.automaticRefresh(true);
            }
        }

        public void Logout()
        {
            FacebookService.Logout();
            this.m_LoggedInUser = null;
            this.m_LoginResult = null;
            this.automaticRefresh(false);
        }

        public string Name { get { return this.m_LoggedInUser.Name; } }

        public string Gender
        {
            get
            {
                string stringGender = string.Empty;
                if (this.m_LoggedInUser.Gender != null)
                {
                    stringGender = this.m_LoggedInUser.Gender.ToString();
                }

                return stringGender;
            }
        }

        public string Email { get { return this.m_LoggedInUser.Email; } }

        public string Hometown
        {
            get
            {
                string stringHometown = string.Empty;
                if (this.m_LoggedInUser.Hometown != null)
                {
                    stringHometown = this.m_LoggedInUser.Hometown.ToString();
                }

                return stringHometown;
            }
        }

        public string Birthday { get { return this.m_LoggedInUser.Birthday; } }

        public Image ProfilePictureURL { get { return this.m_LoggedInUser.ImageNormal; } }

        public Image CoverPictureURL
        {
            get
            {
                Image coverAlbum = null;
                foreach (Album album in this.m_LoggedInUser.Albums)
                {
                    if (album.Name == "Cover Photos")
                    {
                        coverAlbum = album.Photos[0].ImageNormal;
                        break;
                    }
                }

                return coverAlbum;
            }
        }

        private void notify()
        {
            this.notifyEventsObservers();
            this.notifyAlbumsObservers();
            this.notifyFavofriteTeamsObservers();
            this.notifyFriendsBirthdayObservers();
            this.notifyFriendsObservers();
            this.notifyLikedPagesObservers();
            this.notifyPostObservers();
            this.notifyTaggedPlacesObservers();
            this.notifyErrorMessage();
            this.m_LoggedInUser = this.m_LoginResult.LoggedInUser;
        }

        private void notifyEventsObservers()
        {
            try
            {
                if (this.m_ReportEventDelegate != null)
                {

                    List<string> NewListEvents = CollectionToStringList.Events(this.m_LoginResult.LoggedInUser.Events);
                    if (this.m_ListOfEventsLastUpdate == null || !NewListEvents.SequenceEqual(this.m_ListOfEventsLastUpdate))
                    {
                        this.m_ListOfEventsLastUpdate = NewListEvents;
                        this.m_ReportEventDelegate.Invoke(NewListEvents);
                    }
                }
            }
            catch
            {
                this.m_ErrorMessage += "user events, ";
            }
        }

        private void notifyPostObservers()
        {
            try
            {
                if (this.m_ReportPostsDelegate != null)
                {
                    List<string> NewListPosts = CollectionToStringList.Posts(this.m_LoginResult.LoggedInUser.Posts);
                    if (this.m_ListOfPostsLastUpdate == null || !NewListPosts.SequenceEqual(this.m_ListOfPostsLastUpdate))
                    {
                        this.m_ListOfPostsLastUpdate = NewListPosts;
                        this.m_ReportPostsDelegate.Invoke(NewListPosts);
                    }
                }
            }
            catch
            {
                this.m_ErrorMessage += "user posts, ";
            }
        }

        private void notifyAlbumsObservers()
        {
            try
            {
                if (this.m_ReportAlbumsDelegate != null)
                {
                    List<string> NewListAlbums = CollectionToStringList.Albums(this.m_LoginResult.LoggedInUser.Albums);
                    if (this.m_ListOfAlbumsLastUpdate == null || !NewListAlbums.SequenceEqual(this.m_ListOfAlbumsLastUpdate))
                    {
                        this.m_ListOfAlbumsLastUpdate = NewListAlbums;
                        this.m_ReportAlbumsDelegate.Invoke(NewListAlbums);
                    }
                }
            }
            catch
            {
                this.m_ErrorMessage += "user photos, ";
            }
        }

        private void notifyTaggedPlacesObservers()
        {
            try
            {
                if (this.m_ReportTaggedPlacesDelegate != null)
                {
                    List<string> NewListTaggedPlaces = CollectionToStringList.TaggedPlaces(this.m_LoginResult.LoggedInUser.Checkins);
                    if (this.m_ListOfTaggedPlacesLastUpdate == null || !NewListTaggedPlaces.SequenceEqual(this.m_ListOfTaggedPlacesLastUpdate))
                    {
                        this.m_ListOfTaggedPlacesLastUpdate = NewListTaggedPlaces;
                        this.m_ReportTaggedPlacesDelegate.Invoke(NewListTaggedPlaces);
                    }
                }
            }
            catch
            {
                this.m_ErrorMessage += "user tagged places, ";
            }
        }

        private void notifyFriendsObservers()
        {
            try
            {
                if (this.m_ReportFriendsDelegate != null)
                {
                    List<string> NewListFriends = CollectionToStringList.Friends(this.m_LoginResult.LoggedInUser.Friends);
                    if (this.m_ListOfFriendsLastUpdate == null || !NewListFriends.SequenceEqual(this.m_ListOfFriendsLastUpdate))
                    {
                        this.m_ListOfFriendsLastUpdate = NewListFriends;
                        this.m_ReportFriendsDelegate.Invoke(NewListFriends);
                    }
                }
            }
            catch
            {
                this.m_ErrorMessage += "user friends, ";
            }
        }

        private void notifyFavofriteTeamsObservers()
        {
            try
            {
                if (this.m_ReportFavoriteTeamsDelegate != null)
                {
                    List<string> NewListFavoriteTeams = CollectionToStringList.FavoriteTeams(this.m_LoginResult.LoggedInUser.FavofriteTeams);
                    if (this.m_ListOfFavoriteTeamsLastUpdate == null || !NewListFavoriteTeams.SequenceEqual(this.m_ListOfFavoriteTeamsLastUpdate))
                    {
                        this.m_ListOfFavoriteTeamsLastUpdate = NewListFavoriteTeams;
                        this.m_ReportFavoriteTeamsDelegate.Invoke(NewListFavoriteTeams);
                    }
                }
            }
            catch
            {
                this.m_ErrorMessage += "user favorite teams, ";
            }
        }

        private void notifyFriendsBirthdayObservers()
        {
            try
            {
                if (this.m_ReportFriendsBirthdayDelegate != null)
                {
                    List<string> NewListFriendsBirthday = CollectionToStringList.FriendsBirthday(this.m_LoginResult.LoggedInUser.Friends);
                    if (m_ListOfFriendsBirthdayLastUpdate == null || !NewListFriendsBirthday.SequenceEqual(this.m_ListOfFriendsBirthdayLastUpdate))
                    {
                        this.m_ListOfFriendsBirthdayLastUpdate = NewListFriendsBirthday;
                        this.m_ReportFriendsBirthdayDelegate.Invoke(NewListFriendsBirthday);
                    }
                }
            }
            catch
            {
                this.m_ErrorMessage += "user friends birthday, ";
            }
        }

        private void notifyLikedPagesObservers()
        {
            try
            {
                if (this.m_ReportLikedPagesDelegate != null)
                {
                    List<string> NewListLikedPages = CollectionToStringList.LikedPages(this.m_LoginResult.LoggedInUser.LikedPages);
                    if (this.m_ListOfLikedPagesLastUpdate == null || !NewListLikedPages.SequenceEqual(this.m_ListOfLikedPagesLastUpdate))
                    {
                        this.m_ListOfLikedPagesLastUpdate = NewListLikedPages;
                        this.m_ReportLikedPagesDelegate.Invoke(NewListLikedPages);
                    }
                }
            }
            catch
            {
                this.m_ErrorMessage += "user likes, ";
            }
        }

        private void notifyErrorMessage()
        {
            if (this.m_ReportErrorDelegate != null)
            {
                if (!string.IsNullOrEmpty(this.m_ErrorMessage))
                {
                    this.m_ErrorMessage = this.m_ErrorMessage.Remove(this.m_ErrorMessage.Length - 2);
                    this.m_ErrorMessage = string.Format("The program had issues in the following permission: {0}.", this.m_ErrorMessage);
                    this.m_ReportErrorDelegate.Invoke(this.m_ErrorMessage);
                    this.m_ErrorMessage = string.Empty;
                }
            }
        }

        private void automaticRefresh(bool i_Action)
        {
            if (i_Action)
            {
                this.RefershTimer = new Timer(e => this.ConnectToFacebookService(), null, TimeSpan.FromMinutes(5), TimeSpan.FromMinutes(5));
            }
            else
            {
                this.RefershTimer = null;
            }
        }

        public string EventCounter(int i_EventIndex)
        {
            string strDate = string.Empty;
            string countdownString = string.Empty;
            if ((i_EventIndex >= 0) && (i_EventIndex < this.m_LoggedInUser.Events.Count))
            {
                Clock eventCounter = ClockFactoryMethod.ClockCreator(eClock.EventClock);
                strDate = eventCounter.ClockToDisplay( this.m_LoggedInUser.Events[i_EventIndex].TimeString);
            }

            return strDate;
        }

        public void ConnectToFacebookService()
        {
            this.automaticRefresh(false);
            this.m_LoginResult = FacebookService.Connect(this.m_LoginResult.AccessToken);
            this.notify();
            this.automaticRefresh(true);
        }

        public void RememberToken(bool i_IsRememberMeChecked)
        {
            this.m_loginDetails.NeedRememberUser = i_IsRememberMeChecked;
            if (!i_IsRememberMeChecked || this.m_LoginResult == null)
            {
                this.m_loginDetails.AccessTokenToRemember = null;
            }
            else
            {
                this.m_loginDetails.AccessTokenToRemember = this.m_LoginResult.AccessToken;
            }

            this.m_loginDetails.SaveToFile();
        }

        public string ImportTimeToBirthday()
        {
            string stringToReturn = string.Empty;
            if (this.m_LoggedInUser != null)
            {

                stringToReturn = this.m_TimeForBirthday.ClockToDisplay(this.m_LoggedInUser.Birthday);
            }

            return stringToReturn;
        }

        public string Tick()
        {
            return this.m_TimeForBirthday.ClockToDisplay(this.m_LoggedInUser.Birthday);
        }

        public bool IsTokenExistThenConnect()
        {
            bool v_IsTokenExsit = false;
            if (this.m_loginDetails.NeedRememberUser && (!string.IsNullOrEmpty(this.m_loginDetails.AccessTokenToRemember)))
            {
                this.m_LoginResult = FacebookService.Connect(this.m_loginDetails.AccessTokenToRemember);
                this.notify();
                this.m_LoggedInUser = this.m_LoginResult.LoggedInUser;
                v_IsTokenExsit = true;
                this.RefershTimer = new Timer(e => notify(), null, TimeSpan.FromMinutes(5), TimeSpan.FromMinutes(5));
            }

            return v_IsTokenExsit;
        }

        public bool DidLoginSuccessded()
        {
            bool v_HasSuccessded = false;
            if ((this.m_LoginResult != null) && (!string.IsNullOrEmpty(this.m_LoginResult.AccessToken)))
            {
                v_HasSuccessded = true;
            }

            return v_HasSuccessded;
        }

        public bool IsConnected()
        {
            bool v_IsConnected = false;
            if (this.m_LoginResult != null)
            {
                v_IsConnected = true;
            }

            return v_IsConnected;
        }

        public bool IsTokenExist()
        {
            bool v_IsTokenExsit = false;
            if (!string.IsNullOrEmpty(this.m_LoginResult.AccessToken))
            {
                v_IsTokenExsit = true;
            }

            return v_IsTokenExsit;
        }

        public bool IsUserDetailsExist()
        {
            return this.m_loginDetails.NeedRememberUser;
        }

        public void PostStatus(string i_Status)
        {
            try
            {
                this.m_LoggedInUser.PostStatus(i_Status);
                this.notifyPostObservers();
            }
            catch
            {
                this.m_ReportErrorDelegate.Invoke("There are no permission to post.");
            }
        }
    }
}