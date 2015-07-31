using System;
using System.Web.Script.Serialization;

namespace SerializationDeserializaton
{
    public partial class Serialization : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Creating Instance(object) of employee class
            Employee empObj = new Employee();
            
            // Assinging values to employee object
            empObj.FirstName = "Kannadasan";
            empObj.LastName = "Govindasamy";
            empObj.Designation = "Tech Lead"; ;
            empObj.Department = "Development";
            empObj.DOB.Date = 30;
            empObj.DOB.Month = 4;
            empObj.DOB.Year = 1988;
            
            // Serialize Employee Object
            var json = new JavaScriptSerializer().Serialize(empObj);
            Response.Write(json.ToString());
        }
    }
}