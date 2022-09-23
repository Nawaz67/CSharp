using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementDAL
{
    public class DoctorDAL
    {
        public static string sqlcon = "Data Source=VDC01LTC2106; Initial Catalog=HospitalManagement;Integrated Security=True";
        public List<Doctor> doctors;
        public bool AddDoctorDAL(Doctor doctor)
        {
            #region connected approach
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("insert into DoctorClass values(" + doctor.DoctorId + ",'" + doctor.DoctorName + "', '" + doctor.DoctorEmail + "','" + doctor.DoctorPassword + "')", con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return true;
            #endregion

        }
        public List<Doctor> GetAllDoctorsDAL()
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("select * from DoctorClass", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            doctors = new List<Doctor>();
            while (dr.Read())
            {
                doctors.Add(new Doctor
                {
                    DoctorId = Convert.ToInt32(dr["DoctorId"]),
                    DoctorName = dr["DoctorName"].ToString(),
                    DoctorEmail = dr["DoctorEmail"].ToString(),
                    DoctorPassword = dr["DoctorPassword"].ToString(),

                });
            }
            con.Close();
            return doctors;
        }
        public bool UpdateDoctorsDAL(Doctor doctor)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("update DoctorClass set DoctorId=" + doctor.DoctorId + ",DoctorName='" + doctor.DoctorName + "', DoctorEmail='" + doctor.DoctorEmail + "',DoctorPassword='" + doctor.DoctorPassword + "' where DoctorId=" + doctor.DoctorId, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return true;


        }
        public bool RemoveDoctorsDAL(int doctor)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("delete from DoctorClass where DoctorId=" + doctor, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return true;


        }
    }
}
