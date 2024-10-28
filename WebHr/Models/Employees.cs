using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace WebHr.Models
{
    public class Employees
    {

        public int employee_id { get; set; }
        public string first_name {  get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
    }
}