using NUnit.Framework;
using Assignment2App;

namespace Assignment2Test
{
    /*
    *testing both bad and good user input for Collaborator sign up
    *test returns false if user input is valid
    *test returns true if user input is invalid
    */
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //Test user input first and last name
        [Test]
        public void TestGoodUserUserSignUp()
        {
            SignUpValidation user = new SignUpValidation();
            Assert.AreEqual(false, user.CollaboratorName("Juliver", "Ybarsabal"), "User input: Valid username and lastname input for sign-up");
        }

        [Test]
        public void TestBadUserSignUp()
        {
            SignUpValidation user = new SignUpValidation();
            Assert.AreEqual(true, user.CollaboratorName("", ""), "User input: Invalid username and lastname input for sign-up");
        }

        //Test user input contact details
        [Test]
        public void TestGoodConatactDetail()
        {
            SignUpValidation user = new SignUpValidation();
            Assert.AreEqual(false, user.CollaboratorContact("0481138999"), "User input: Valid contact input for sign - up");
        }

        [Test]
        public void TestBadContactDetail()
        {
            SignUpValidation user = new SignUpValidation();
            Assert.AreEqual(true, user.CollaboratorContact("123"), "User input: Invalid contact input for sign - up");
        }

        //Test user input city
        [Test]
        public void TestGoodCityListDetail()
        {
            SignUpValidation user = new SignUpValidation();
            Assert.AreEqual(false, user.CollaboratorCity(1), "User input: Valid contact input for sign - up");
        }

        [Test]
        public void TestBadCityDetail()
        {
            SignUpValidation user = new SignUpValidation();
            Assert.AreEqual(true, user.CollaboratorCity(-1), "User input: Invalid contact input for sign - up");
        }

        //Test user input Availibity
        [Test]
        public void TestGoodAvailability()
        {
            SignUpValidation user = new SignUpValidation();
            Assert.AreEqual(false, user.CollaboratorAvailability(true,false,false,true), "User input: Valid Availability input for sign - up");
        }

        [Test]
        public void TestBadAvailability()
        {
            SignUpValidation user = new SignUpValidation();
            Assert.AreEqual(true, user.CollaboratorAvailability(false,false,false,false), "User input: Invalid Availability input for sign - up");
        }

        //validate user input Radious
        [Test]
        public void TestGoodHelpRadius()
        {
            SignUpValidation user = new SignUpValidation();
            Assert.AreEqual(false, user.CollaboratorHelpRadius(true, false, true), "User input: Valid Availability input for sign - up");
        }

        [Test]
        public void TestBadHelpRadius()
        {
            SignUpValidation user = new SignUpValidation();
            Assert.AreEqual(true, user.CollaboratorHelpRadius(false, false, false), "User input: Invalid Availability input for sign - up");
        }


    }
}