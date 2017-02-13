using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using StudentPortalService;
using System.Xml.Serialization;

namespace StudentPortalApp
{
    public partial class StudentInfoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblDate.Text = DateTime.Now.ToString();
        }

        protected void callMe(object sender, EventArgs e)
        {
            StudentPortalService.Student obj = getReport(this.txtId.Text);
            txtFirstName.Text = obj.FirstName;
            txtLastName.Text = obj.LastName;
            txtAddress.Text = obj.Address;
            txtContact.Text = obj.Contact;
            string base64String = Convert.ToBase64String(obj.Image, 0, obj.Image.Length);
            img.ImageUrl = "data:image/jpg;base64," + base64String;

            txtEmail.Text = obj.Email;
            txtGender.Text = obj.Gender;
        }

        private StudentPortalService.Student getReport(string id)
        {
            WebClient myclient = new WebClient();
            string url = string.Format("http://localhost:60008/StudentInfoService.svc/getStudentData/{0}", id);
            byte[] _data = myclient.DownloadData(url);
            var str = System.Text.Encoding.Default.GetString(_data);  // String Format

            Stream _mem = new MemoryStream(_data);

            var reader = new StreamReader(_mem);
            var result = reader.ReadToEnd();

            /* XML Response */
            /*XmlSerializer serializer = new XmlSerializer(typeof(Student));
            using (TextReader reader_xml = new StringReader(result))
            {
                return (Student)serializer.Deserialize(reader_xml);
            }*/

            /* Json Response*/
            var obj = JsonConvert.DeserializeObject<Student>(result);
            return obj;
        }
    }
}