using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;
using System.Web.Mvc;
using WebHr.Models;

namespace WebHr.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult BusquedaEmployees() {
             
        //}

        //public List<Jobs> listaJobs()
        //{
        //    List<Jobs> lista = new List<Jobs>();
        //    Jobs objJob;

        //    string cadenaCon = ConfigurationManager.ConnectionStrings["cnx_bd_hr"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(cadenaCon))
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("select job_id, job_title from jobs", con);
        //        cmd.CommandType = System.Data.CommandType.Text;

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                objJob = new Jobs();
        //                objJob.job_id = reader.GetInt32(0);
        //                objJob.job_title = reader.GetString(1);
        //                lista.Add(objJob);
        //            }
        //        }
        //    }

        //    return lista;
        //}

        //public List<Employees> listaEmployees()
        //{
        //    List<Employees> lista = new List<Employees>();
        //    Employees objEmp;
        //    string cadenaCon = ConfigurationManager.ConnectionStrings["cnx_bd_hr"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(cadenaCon))
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("usp_employees_busqueda", con);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Clear();
        //        //cmd.Parameters.AddWithValue("@employee_id", employee_id);
        //        //cmd.Parameters.AddWithValue("@first_name", first_name);
        //        //cmd.Parameters.AddWithValue("@last_name", last_name);
        //        //cmd.Parameters.AddWithValue("@email", email);
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                objEmp = new Employees();
        //                objEmp.employee_id = reader.GetInt32(0);
        //                objEmp.first_name = reader.GetString(1);
        //                objEmp.last_name = reader.GetString(2);
        //                objEmp.email = reader.GetString(3);
        //                lista.Add(objEmp);
        //            }
        //        }
        //    }
        //    return lista;

        //}

    }
}