using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Xml;
using Tweetinvi;

namespace Assignment2App
{
    /// <summary>
    /// Interaction logic for TwitterUI.xaml
    /// </summary>
    public partial class TwitterUI : Window
    {
        private static string APIKey = "KNtyr0MpBJsFPi7JXZ4nboudj";
        private static string APISecret = "H9tt88bVcS4rZOqOuRC7aVBAkGuXbLW81k7LfmRBnRtRzQokt8";
        private static string APIToken = "1448167963266207745-SdRcB0GUIPWjtoWy11XO19xyhoFLZm";
        private static string APITokenSecret = "hm7wIfWeVc2u2hSmjyChq4B6qYrW4DjfHhb6AxaMPIkPw";


        public TwitterUI()
        {
            InitializeComponent();
            Auth.SetUserCredentials(APIKey, APISecret, APIToken, APITokenSecret);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var time = DateTime.Now;
            TimeSpan now = DateTime.Now.TimeOfDay;
            
            if (TweetBox.Text == "") 
                MessageBox.Show("Please enter in text above!");
            else if(FullName.Text == "" || Handler.Text == "")
            {
                MessageBox.Show("Please Load the Twitter Account first!");
            }
            else
            {
                Tweet.PublishTweet(TweetBox.Text);
                MessageBox.Show("Tweet successfully published!");
                TweetBox.Text = "";
            }
        }
        
        private void GetTweet_Click(object sender, RoutedEventArgs e)
        {
            var user = Tweetinvi.User.GetAuthenticatedUser();
            var getTweets = Timeline.GetUserTimeline(user, 1).ToArray(); //credit to the Tweetinvi documentation @ https://github.com/linvi/tweetinvi/wiki/Introduction
            GetTweet2.Text = "";
            if (FullName.Text == "" || Handler.Text == "")
            {
                MessageBox.Show("Please Load the Twitter Account first!");
            }
            else
            {
                foreach (var t in getTweets)
                {
                    GetTweet2.AppendText("-->" + t.FullText + " - " + t.TweetLocalCreationDate + Environment.NewLine + "--------END OF THE TWEET---------" + Environment.NewLine + Environment.NewLine);
                    
                }
                XmlDocument doc = new XmlDocument();
                doc.Load("TwitterFile.xml");
                for (int i = 0; i < getTweets.Length; i++)
                {
                    XmlNode Tweet = doc.CreateElement("Tweet");
                    XmlNode Text = doc.CreateElement("Text");
                    Text.InnerText = getTweets[i].FullText.ToString();
                    Tweet.AppendChild(Text);
                    doc.DocumentElement.AppendChild(Tweet);
                    XmlNode Time = doc.CreateElement("Time");
                    Time.InnerText = getTweets[i].TweetLocalCreationDate.ToString();
                    Tweet.AppendChild(Time);
                }
                doc.Save("TwitterFile.xml");
            }
        }
        private void LoadAccount_Click(object sender, RoutedEventArgs e)
        {
            var user = Tweetinvi.User.GetAuthenticatedUser();
            var getProfilePic = user.ProfileImageUrl;

            //implemented from https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.bitmapimage.urisource?redirectedfrom=MSDN&view=netcore-3.1#System_Windows_Media_Imaging_BitmapImage_UriSource
            //this is used to convert the twitter profile picture into an appropriate format for testimage.Source.
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(getProfilePic);
            bitmap.EndInit();
            //Console.WriteLine(getProfilePic);

            FullName.Text = user.Name;
            Handler.Text = "@" + user.ScreenName;
            testimage.Source = bitmap;
        }

    }

    
}
    

