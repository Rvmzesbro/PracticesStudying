using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic8
{
    public class Snake
    {

        public List<Position> Body { get; private set; }
        public int Dx { get; private set; }
        public int Dy { get; private set; }

        private bool growing = false;


        public Snake(int startX, int startY)
        {
            Body = new List<Position> { new Position(startX, startY) };
            Dx = 1;
            Dy = 0;
        }


        public void Move()
        {
            Position head = GetHead();
            Position newHead = new Position(head.X + Dx, head.Y + Dy);

            Body.Insert(0, newHead);

            if (growing)
            {
                growing = false;
            }
            else
            {

                if (Body.Count > 1)
                {
                    Body.RemoveAt(Body.Count - 1);
                }
                else if (Body.Count == 1 && !growing)
                {

                    Body.RemoveAt(Body.Count - 1);
                }
            }
        }

        public void Grow()
        {
            growing = true;
        }


        public bool CollidesWithSelf()
        {
            Position head = GetHead();
            for (int i = 1; i < Body.Count; i++)
            {
                if (Body[i].Equals(head))
                {
                    return true;
                }
            }
            return false;
        }


        public bool CollidesWithWall(int width, int height)
        {
            Position head = GetHead();
            return head.X <= 0 || head.X >= width - 1 || head.Y <= 0 || head.Y >= height - 1;
        }

        public Position GetHead()
        {

            return Body.Count > 0 ? Body[0] : null;
        }


        public void ChangeDirection(int newDx, int newDy)
        {

            if (Body.Count > 1 && Dx + newDx == 0 && Dy + newDy == 0)
            {

                return;
            }


            Dx = newDx;
            Dy = newDy;
        }


        public bool IsGrowing => growing;
    }

}
