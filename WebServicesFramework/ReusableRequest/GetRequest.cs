using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using WebServicesFramework.ExtentReports1;

namespace WebServicesFramework.ReusableRequest
{
   
    class GetRequest
    {
        public void getRequest(string url)
        {
            unirest_net.http.HttpResponse<string> jsonResponse = unirest_net.http.Unirest.get(url).asString();

            ExtentReprts extRept = new ExtentReprts();
            
            extRept.reportSetup("GetTest.html");
            extRept.createTest("Get Test");
            extRept.logReportStatement(AventStack.ExtentReports.Status.Pass, jsonResponse.Body.ToString());
            extRept.flushReport();
        }
    }
}
