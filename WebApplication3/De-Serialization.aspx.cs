using System;
using System.Web.Script.Serialization;

namespace SerializationDeserializaton
{
    public partial class De_Serialization : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            var json = "{ DOB: { Date: 30,Month: 4,Year:1988},FirstName: \"Kannadasan\",LastName: \"Govindasamy\",Department: \"Development\",Designation:\"Tech Lead\"}";
            Employee empObj = new Employee();
            empObj = new JavaScriptSerializer().Deserialize<Employee>(json);
            if (empObj != null)
            {
                lblFirstName.Text = empObj.FirstName;
                lblLastName.Text = empObj.LastName;
                lblDepartment.Text = empObj.Department;
                lblDesignation.Text = empObj.Designation;
                lblDateOfBirth.Text = empObj.DOB.Date + "/" + empObj.DOB.Month + "/" + empObj.DOB.Year;
            }
        }

    }
}