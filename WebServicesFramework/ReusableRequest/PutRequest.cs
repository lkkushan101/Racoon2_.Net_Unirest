using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using WebServicesFramework.ExtentReports1;
namespace WebServicesFramework.ReusableRequest
{
    class PutRequest
    {
        public void putRequest(string url, object body)
        {
            ExtentReprts extRept = new ExtentReprts();
            var client = new RestClient(url);
            unirest_net.http.HttpResponse<string> response = unirest_net.http.Unirest.put(url).body(body).asString();


          
            extRept.reportSetup("PutTest.html");
            extRept.createTest("Put Test");
            extRept.logReportStatement(AventStack.ExtentReports.Status.Pass, response.Body.ToString());
            extRept.flushReport();
        }
    }
}
