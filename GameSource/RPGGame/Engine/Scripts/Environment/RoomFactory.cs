using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Engine.Scripts.Environment
{
    public static class RoomFactory
    {
        private const string file1 = @"Engine\Graphics\Room1.txt";
        public static Room Create()
        {
            Room room = new Room();
            room.GenerateRoom(file1);
            return room;
        }
    }
}
