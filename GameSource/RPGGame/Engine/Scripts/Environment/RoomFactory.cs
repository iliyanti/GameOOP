namespace RPG.Engine.Scripts.Environment
{
    /// <summary>
    /// A Room factory class to create a random room
    /// </summary>
    public static class RoomFactory
    {
        /// <summary>
        /// string array with text files 
        /// </summary>
        private static readonly string[] Rooms = { "Data/Graphics/Room1.txt", "Data/Graphics/Room2.txt", "Data/Graphics/Room3.txt" };

        /// <summary>
        /// Creates a random room
        /// </summary>
        /// <returns></returns>
        public static Room Create()
        {
            // TODO Add random generator
            var room = new Room();
            room.GenerateRoom(Rooms[0]);
            return room;
        }
    }
}
