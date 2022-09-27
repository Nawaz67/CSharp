using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementDAL
{
    public class PatientDAL
    {
            public static string sqlcon = "Data Source=VDC01LTC2106; Initial Catalog=HospitalManagement;Integrated Security=True";

            public List<Patient> Patients;


            public bool AddPatientsDAL(Patient patient)
            {

                SqlConnection con = new SqlConnection(sqlcon);
                SqlCommand cmd = new SqlCommand("insert into PatientClass values(" + patient.PatientId + ",'" + patient.PatientName + "', '" + patient.PatientEmail + "','" + patient.PatientPassword + "','" + patient.PatientType + "')", con);
                con.Open();
                int row = cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }

            public List<Patient> GetAllPatientDetails()
            {
                SqlConnection con = new SqlConnection(sqlcon);
                SqlCommand cmd = new SqlCommand("select * from PatientClass", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Patients = new List<Patient>();
                while (dr.Read())
                {
                    Patients.Add(new Patient
                    {
                        PatientId = Convert.ToInt32(dr["PatientId"]),
                        PatientName = dr["PatientName"].ToString(),
                        PatientEmail = dr["PatientEmail"].ToString(),
                        PatientPassword = dr["PatientPassword"].ToString(),
                        PatientType = dr["PatientType"].ToString()

                    });
                }
                con.Close();
                return Patients;
            }

            public bool RemovePatientsDAL(int Patient)
            {
                SqlConnection con = new SqlConnection(sqlcon);
                SqlCommand cmd = new SqlCommand("delete from PatientClass where PatientId=" + Patient, con);
                con.Open();
                int row = cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }

            public bool UpdatePatientsDAL(Patient patient)
            {
                SqlConnection con = new SqlConnection(sqlcon);
                SqlCommand cmd = new SqlCommand("update PatientClass set PatientId=" + patient.PatientId + ",PatientName='" + patient.PatientName + "', PatientEmail='" + patient.PatientEmail + "',PatientPassword='" + patient.PatientPassword + "', PatientType='" + patient.PatientType + "' where PatientId=" + patient.PatientId, con);
                con.Open();
                int row = cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        
        }
    }

