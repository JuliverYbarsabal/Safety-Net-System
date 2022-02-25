using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace Assignment2App
{
    /// <summary>
    /// Interaction logic for viewCollaborators.xaml
    /// </summary>
    public partial class viewContributors : Window
    {
        public viewContributors()
        {
            InitializeComponent();
        }
        private void load_Click(object sender, RoutedEventArgs e)
        {
            contributorBox.Text = "";
            XElement con = XElement.Load("Contributor.xml");
            IEnumerable<Contributors> childElements = from rec in con.Elements()
                                                      select new Contributors
                                                      {
                                                          FirstName = (string)rec.Element("FirstName"),
                                                          LastName = (string)rec.Element("LastName"),
                                                          City = (string)rec.Element("City"),
                                                          Phone = (string)rec.Element("Phone"),
                                                          Twitter = (string)rec.Element("Twitter"),
                                                          Time = (string)rec.Element("Time"),
                                                          weekend = (string)rec.Element("Weekend"),
                                                          radius = (string)rec.Element("Radius")
                                                      };

            int i = 1;
            foreach (Contributors c in childElements)
            {
                contributorBox.AppendText("Contributor: " + i + "\r\n"
                + "First name: " + c.FirstName + "\r\n"
                + "Last name: " + c.LastName + "\r\n"
                + "City: " + c.City + "\r\n"
                + "Contact: " + c.Phone + "\r\n"
                + "Has Twiter: " + c.Twitter + "\r\n"
                + "Time available: " + c.Time + "\r\n"
                + c.weekend + "\r\n"
                + "Radius from city: " + c.radius + "\r\n");
                i++;
                contributorBox.AppendText("********************************************\n");
            }
        }
    }
}
