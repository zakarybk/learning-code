using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography;

namespace TrainingRooms
{
    class RoomRepository
    {
        private List<TrainingRoom> rooms =
            new List<TrainingRoom>
            {
                new TrainingRoom {
                    Id = 1,
                    Name = "Copernicus",
                    Location = "b",
                    NumComputers = 25
                },
                new TrainingRoom {
                    Id = 2,
                    Name = "Sagittarius",
                    Location = "c",
                    NumComputers = 10
                },
                new TrainingRoom {
                    Id = 3,
                    Name = "Luna",
                    Location = "a",
                    NumComputers = 50
                }
            };

        public RoomRepository()
        {

        }

        public List<TrainingRoom> GetRooms()
        {
            return rooms;
        }

        public TrainingRoom GetRoom(int id)
        {
            return (from r in rooms
            where r.Id == id
            select r).FirstOrDefault();
        }
    }
}
