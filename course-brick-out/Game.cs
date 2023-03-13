using System;
using System.Windows.Input;

namespace course_brick_out
{
    internal class Game
    {
        public Game()
        {
            Console.WriteLine("Construct");
        }

        public void Init()
        {
            Console.WriteLine("Init");
        }

        // Returns whether the game loop should continue.
        public bool Update()
        {
            Console.WriteLine("Update");

            return !Keyboard.IsKeyDown(Key.Escape);
        }

        public void Render()
        {
            Console.WriteLine("Render");
        }
    }
}
