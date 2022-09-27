using HospitalManagementBLL;
using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementPL
{
    public class RoomPL
    {
        public List<Room> Rooms;
        public void AddRoom()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Rooms Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Room Number: ");
            int RoomNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Patient Id: ");
            int PatientId = Convert.ToInt32(Console.ReadLine());


            RoomBLL roomBLL = new RoomBLL();
            Room room = new Room(RoomNo, PatientId);
            bool flag = roomBLL.AddRoomBLL(room);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Room added successfully...");
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }

            Console.Write(flag);
        }
        public void SearchRoom()
        {
            Console.Write("Room Number: ");
            int RoomNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Patient Id: ");
            int PatientId = Convert.ToInt32(Console.ReadLine());

        }
        /*public void GetRoomsPL()
        {
            Console.WriteLine("----------------------------Room-List-------------------------");
            Console.WriteLine("--Room No----------------PatientId------");
            Console.ForegroundColor = ConsoleColor.White;
            RoomBLL roomBLL = new RoomBLL();
            List<Room> roomBLLList = new List<Room>();
            roomBLLList = roomBLL.GetAllRoomsBLL();
            foreach (var item in roomBLLList)
            {
                Console.WriteLine(item.PatientId + "\t \t \t " + item.PatientName + "\t \t \t" + item.PatientEmail + "\t \t \t" + item.PatientPassword + "\t \t \t" + item.PatientType);

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            PatientSection();
        }*/
    }
}
