using System;
using System.Windows.Input;

namespace course_brick_out
{
    internal class Game
    {

        private Bar m_bar;
        

        public Game()
        {
            m_bar = new Bar(2);
        }


        public void Init()
        {
            Console.WriteLine($"La position est : {m_bar.PositionX} et {m_bar.PositionY}");
        }

        public bool ShouldTerminate()
        {
            return Keyboard.IsKeyDown(Key.Escape);
        }

        // Returns whether the game loop should continue.
        public void Update()
        {
            
        }

        public void Render()
        {
            Console.Clear();
            Console.SetCursorPosition(m_bar.PositionX, m_bar.PositionY);
        }
    }
}
