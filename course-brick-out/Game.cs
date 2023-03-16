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

        public bool ShouldTerminate()
        {
            return Keyboard.IsKeyDown(Key.Escape);
        }

        // Returns whether the game loop should continue.
        public void Update()
        {
            Console.WriteLine("Update");
        }

        public void Render()
        {
            Console.WriteLine("Render");
        }
    }
}
