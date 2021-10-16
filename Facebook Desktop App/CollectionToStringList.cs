using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    public static class CollectionToStringList
    {
        public static List<string> Posts(FacebookObjectCollection<Post> i_PostCollectionToStringList)
        {
            ICollectionToString<Post> posts = new CollectionAdapter<Post>() { CollectionAdaptee = i_PostCollectionToStringList, DisplayItemStrategyMethod = (post) => post.ToString() };
            return posts.ConvertToStringList();
        }

        public static List<string> Albums(FacebookObjectCollection<Album> i_AlbumsCollectionToStringList)
        {
            ICollectionToString<Album> Albums = new CollectionAdapter<Album>() { CollectionAdaptee = i_AlbumsCollectionToStringList, DisplayItemStrategyMethod = (album) => album.ToString() };
            return Albums.ConvertToStringList();
        }

        public static List<string> FavoriteTeams(Page[] i_FavoriteTeamsCollectionToStringList)
        {
            ICollectionToString<Page> FavoriteTeams = new CollectionAdapter<Page>() { CollectionAdaptee = i_FavoriteTeamsCollectionToStringList, DisplayItemStrategyMethod = (page) => page.ToString() };
            return FavoriteTeams.ConvertToStringList();
        }

        public static List<string> TaggedPlaces(FacebookObjectCollection<Checkin> i_TaggedPlacesCollectionToStringList)
        {
            ICollectionToString<Checkin> TaggedPlaces = new CollectionAdapter<Checkin>() { CollectionAdaptee = i_TaggedPlacesCollectionToStringList, DisplayItemStrategyMethod = (checkin) => checkin.ToString() };
            return TaggedPlaces.ConvertToStringList();
        }

        public static List<string> Friends(FacebookObjectCollection<User> i_FriendsCollectionToStringList)
        {
            ICollectionToString<User> Friends = new CollectionAdapter<User>() { CollectionAdaptee = i_FriendsCollectionToStringList, DisplayItemStrategyMethod = (user) => user.ToString() };
            return Friends.ConvertToStringList();
        }

        public static List<string> LikedPages(FacebookObjectCollection<Page> i_LikedPagesCollectionToStringList)
        {
            ICollectionToString<Page> LikedPages = new CollectionAdapter<Page>() { CollectionAdaptee = i_LikedPagesCollectionToStringList, DisplayItemStrategyMethod = (page) => page.ToString() };
            return LikedPages.ConvertToStringList();
        }

        public static List<string> FriendsBirthday(FacebookObjectCollection<User> i_FriendsBirthdaytCollectionToStringList)
        {
            ICollectionToString<User> FriendsBirthday = new CollectionAdapter<User>() { CollectionAdaptee = i_FriendsBirthdaytCollectionToStringList, DisplayItemStrategyMethod = (user) => user.Name + "- " + user.Birthday };
            return FriendsBirthday.ConvertToStringList();
        }

        public static List<string> Events(FacebookObjectCollection<Event> i_EventCollectionToStringList)
        {
            ICollectionToString<Event> Events = new CollectionAdapter<Event>() { CollectionAdaptee = i_EventCollectionToStringList, DisplayItemStrategyMethod = (events) => events.Name };
            return Events.ConvertToStringList();
        }
    }
}
