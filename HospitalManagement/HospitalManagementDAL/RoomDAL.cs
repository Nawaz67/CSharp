using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementDAL
{
    public class RoomDAL
    {
        public static string sqlcon = "Data Source=VDC01LTC2106; Initial Catalog=HospitalManagement;Integrated Security=True";

        public List<Room> rooms;


        public bool AddRoomsDAL(Room room)
        {

            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("insert into Rooms values(" + room.RoomNo + ","+room.PatientId+")", con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public List<Room> GetAllRoomDetails()
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("select * from Rooms", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            rooms = new List<Room>();
            while (dr.Read())
            {
                rooms.Add(new Room
                {
                    RoomNo = Convert.ToInt32(dr["RoomNo"]),
                    PatientId = Convert.ToInt32(dr["PatientId"]),
                    

                });
            }
            con.Close();
            return rooms;
        }

        public bool RemoveRoomsDAL(int Room)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("delete from Rooms where RoomNo=" + Room, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public bool UpdateRoomsDAL(Room room)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("update Rooms set RoomNo=" + room.RoomNo + ", "+room.PatientId+" where PatientId=" + room.PatientId, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool SearchRoomsDAL(Room room, Patient patient)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("select RoomNo from Rooms,PatientClass where "+patient.PatientId+" = "+room.PatientId,con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }



    }
}

