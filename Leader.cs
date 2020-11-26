using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Leader : Enemy
    {
        private Tile tile;

        public Leader(int x, int y) : base(x, y, 2, 20)
        {

        }

        public override Movement ReturnMove(Movement move = Movement.NoMovement)
        {
            return base.ReturnMove(move);
        }
    }
}
