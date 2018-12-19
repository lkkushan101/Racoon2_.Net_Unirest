using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using WebServicesFramework.ExtentReports1;
using unirest_net.request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace WebServicesFramework.ReusableRequest
{
    class PostRequest
    {
        public void postRequest(string url, object body_content)
        {
            unirest_net.http.HttpResponse<string> response = unirest_net.http.Unirest.post(url).body(body_content).asString();

            ExtentReprts extRept = new ExtentReprts();
          
            extRept.reportSetup("PostTest.html");
            extRept.createTest("Post Test");
            extRept.logReportStatement(AventStack.ExtentReports.Status.Pass, response.Body.ToString());
            extRept.flushReport();
        }
    }

}
