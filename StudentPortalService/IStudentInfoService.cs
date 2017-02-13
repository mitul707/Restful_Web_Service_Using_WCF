using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentPortalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentInfoService" in both code and config file together.
    [ServiceContract]
    public interface IStudentInfoService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/getStudentData/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        Student getStudentInfo(string id);
    }
}
