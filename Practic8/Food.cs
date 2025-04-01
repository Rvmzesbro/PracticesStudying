using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic8
{
    public class Food
    {

        public Position Position { get; private set; }
        private Random rnd = new Random();


        public Food(int width, int height, List<Position> snakeBody)
        {
            Generate(width, height, snakeBody);
        }


        public void Generate(int width, int height, List<Position> snakeBody)
        {
            do
            {
                int x = rnd.Next(1, width - 1);
                int y = rnd.Next(1, height - 1);
                Position = new Position(x, y);
            } while (snakeBody.Any(p => p.Equals(Position)));
        }
    }
}
