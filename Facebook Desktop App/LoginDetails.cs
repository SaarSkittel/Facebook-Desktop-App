using System.IO;
using System.Xml.Serialization;

namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    public class LoginDetails
    {
        public bool NeedRememberUser { get; set; }

        public string AccessTokenToRemember { get; set; }

        private LoginDetails()
        {
            this.NeedRememberUser = false;
            this.AccessTokenToRemember = null;
        }

        public void SaveToFile()
        {
            using (System.IO.Stream stream = new FileStream(@"LoginDetails.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static LoginDetails LoadFromFile()
        {
            LoginDetails loginDetails = null;
            try
            {
                using (Stream stream = new FileStream(@"LoginDetails.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(LoginDetails));
                    loginDetails = serializer.Deserialize(stream) as LoginDetails;
                }
            }
            catch
            {
                loginDetails = new LoginDetails();
            }

            return loginDetails;
        }
    }
}
