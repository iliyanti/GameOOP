using System.Collections.Generic;

namespace RPG.Engine.Scripts.Characters.Shared
{
    interface IMovable
    {
        Stack<Direction> Path { get; set; }
        void Move();
    }
}
