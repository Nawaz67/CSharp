using HospitalManagementDAL;
using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBLL
{
    public class RoomBLL
    {
        public bool AddRoomBLL(Room room)
        {
            RoomDAL roomDAL = new RoomDAL();
            return roomDAL.AddRoomsDAL(room);

        }
        public List<Room> GetAllRoomsBLL()
        {
            RoomDAL roomDAL = new RoomDAL();
            return roomDAL.GetAllRoomDetails();

        }
        public bool RemoveRoomsBLL(int room)
        {
            RoomDAL roomDAL = new RoomDAL();
            return roomDAL.RemoveRoomsDAL(room);

        }
        public bool UpdateRoomsBLL(Room room)
        {
            RoomDAL roomDAL = new RoomDAL();
            return roomDAL.UpdateRoomsDAL(room);

        }
    }
}
