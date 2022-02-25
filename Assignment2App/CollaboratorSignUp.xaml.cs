using System;
using System.Windows;
using System.Windows.Controls;
using System.Xml;

namespace Assignment2App
{
    /// <summary>
    /// Interaction logic for CollaboratorSignUp.xaml
    /// </summary>
    public partial class CollaboratorSignUp : Window
    {
        public CollaboratorSignUp()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //resets all values on clear button
            #region
            firstnamebox.Text = "";
            lastnamebox.Text = "";
            mobilebox.Text = "";
            citylist.SelectedIndex = -1;
            radio100km.IsChecked = false;
            radio10km.IsChecked = false;
            radio25km.IsChecked = false;
            radio50km.IsChecked = false;
            radio6am.IsChecked = false;
            radio6pm.IsChecked = false;
            radio24hour.IsChecked = false;
            weekendcheck.IsChecked = false;
            twitterbox.IsChecked = false;
            #endregion
        }

        public double SignUpName(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("Contributor.xml");
            XmlNode contributor = doc.CreateElement("Contributor");
            //Creating each element for XML
            #region
            //Creates element FirstName
            XmlNode firstname = doc.CreateElement("FirstName");
            firstname.InnerText = firstnamebox.Text;
            contributor.AppendChild(firstname);
            doc.DocumentElement.AppendChild(contributor);
            //Creates element LastName
            XmlNode lastname = doc.CreateElement("LastName");
            lastname.InnerText = lastnamebox.Text;
            contributor.AppendChild(lastname);
            doc.DocumentElement.AppendChild(contributor);
            //Creates element city
            XmlNode city = doc.CreateElement("City");
            city.InnerText = citylist.Text;
            contributor.AppendChild(city);
            doc.DocumentElement.AppendChild(contributor);
            //Creates element Phone
            XmlNode phone = doc.CreateElement("Phone");
            phone.InnerText = mobilebox.Text;
            contributor.AppendChild(phone);
            doc.DocumentElement.AppendChild(contributor);
            //Creates element Twitter
            XmlNode twitter = doc.CreateElement("Twitter");
            if (twitterbox.IsChecked == true)
            {
                twitter.InnerText = "Yes";
            }
            if (twitterbox.IsChecked == false)
            {
                twitter.InnerText = "No";
            } 
            contributor.AppendChild(twitter);
            doc.DocumentElement.AppendChild(contributor);
            //Creates element Time
            XmlNode time = doc.CreateElement("Time");
            if(radio6am.IsChecked == true)
            {
                time.InnerText = "6am - 12pm";
            }
            if(radio6pm.IsChecked == true)
            {
                time.InnerText = "12pm - 6pm";
            }
            if (radio24hour.IsChecked == true)
            {
                time.InnerText = "24Hours";
            } 
            contributor.AppendChild(time);
            doc.DocumentElement.AppendChild(contributor); 
             //Creates element Weekend
             XmlNode weekend = doc.CreateElement("Weekend");
            if (weekendcheck.IsChecked == true)
            {
                weekend.InnerText = "Available for weekends";
            }
            else
            {
                weekend.InnerText = "Not available for weekends";
            }       
            contributor.AppendChild(weekend);
            doc.DocumentElement.AppendChild(contributor);
            //Creates element Radius
            XmlNode radius = doc.CreateElement("Radius");
            if (radio10km.IsChecked == true)
            {
                radius.InnerText = "10km";
            }
            if (radio25km.IsChecked == true)
            {
                radius.InnerText = "25km";
            }
            if (radio50km.IsChecked == true)
            {
                radius.InnerText = "50km";
            }
            if (radio100km.IsChecked == true)
            {
                radius.InnerText = "100km";
            }  
            contributor.AppendChild(radius);
            doc.DocumentElement.AppendChild(contributor);
            #endregion

            //IF statements to check for invalid form
            //uses SignUpValidation.cs
            #region 
            SignUpValidation user = new SignUpValidation();
            bool invalidName = user.CollaboratorName(firstnamebox.Text, lastnamebox.Text);
            bool invalidConatact = user.CollaboratorContact(mobilebox.Text);
            bool invalidCityList = user.CollaboratorCity(citylist.SelectedIndex);
            bool invalidAvailability = user.CollaboratorAvailability((bool)radio100km.IsChecked, (bool)radio50km.IsChecked, (bool)radio25km.IsChecked, (bool)radio10km.IsChecked);
            bool invalidradius = user.CollaboratorHelpRadius((bool)radio6pm.IsChecked, (bool)radio6am.IsChecked, (bool)radio24hour.IsChecked);

            if (invalidName)
            {
                MessageBox.Show("Please enter a valid name");
            }

            else if (invalidConatact)
            {
                MessageBox.Show("Please enter in a valid mobile number (10 digits)");
            }


            else if (invalidCityList)
            {
                MessageBox.Show("Please select a city!");
            }

            else if (invalidAvailability)
            {
                MessageBox.Show("Please select a time!");
            }

            else if (invalidradius)
            {
                MessageBox.Show("Please select a radius!");
            }
            #endregion

            else
            {
                doc.Save("Contributor.xml");
                MessageBox.Show("Submitted Successfully!");
                this.Close();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void twitterbox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void weekendcheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void facebookbox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radio6am_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
