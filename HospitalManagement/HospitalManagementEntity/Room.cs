using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementEntity
{
    public class Room
    {
        public Room()
        {

        }
     
        public int RoomNo { get; set; }
        public int PatientId { get; set; }

        public Room(int RoomNo, int PatientId)
        {
            this.RoomNo = RoomNo;
            this.PatientId = PatientId;

        }
    }
}
