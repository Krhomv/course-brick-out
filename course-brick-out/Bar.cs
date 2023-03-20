using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_brick_out
{
    internal class Bar
    {
        private int m_positionX; // Field
        private int m_positionY;
        private int m_width;

        public int PositionX { get => m_positionX; set => m_positionX = value; }
        public int PositionY { get => m_positionY; set => m_positionY = value; }
        public int Width { get => m_width; set => m_width = value; }

        public Bar(int distanceFromBottom) //Constructor
        {
            m_positionX = Console.WindowWidth/2;
            m_positionY = Console.WindowHeight-distanceFromBottom;
            m_width = 3;
        }

    }
}
