using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    public class Game
    {
        Random rand = new Random();
        public int[,] field;
        public int[,] fieldcopy = new int[4,4];
        
        int size = 4;
        int x0 = 3;
        int y0 = 3;
        public Game(int flag)
        {
            size = flag;
            field = new int[4, 4];
        }

        private int CoordinatesToPosition(int x, int y)
        {
            int button = 4 * y + x;
            return button;
        }

        private void PositionToCoordinates(int position, out int x, out int y)
        {
            x = position % 4;
            y = position / 4;
        }

        public void Start()
        {
            int num;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    num = CoordinatesToPosition(i, j)+1;
                    field[i, j] = num;
                    //x0 = i;
                    //y0 = j;
                }
            field[x0, y0] = 0;
        }

        public int GetNumber(int position)
        {
            int x, y;
            PositionToCoordinates(position, out x, out y);
            if ((x < 0) || (y < 0))
                return 0;
            else
                return field[x, y];
        }

        public void Shift(int position)
        {
            Memento memento = new Memento(field);
            Caretaker.SaveState(memento);
            int x, y;
            PositionToCoordinates(position, out x, out y);
            if (((x == x0) && (Math.Abs(y - y0) == 1)) || (y == y0) && (Math.Abs(x - x0) == 1))
            {
                field[x0, y0] = field[x, y];
                field[x, y] = 0;
                x0 = x;
                y0 = y;
            }
           
        }

        public void ShiftRandom()
        {
            int a = rand.Next(0, 4);
            int x, y;
            x = x0;
            y = y0;
            if (a == 0)
            {
                if (x != 4)
                    x += 1;
                else
                    x -= 1;
            }
            if (a == 1)
            {
                if (x != 0)
                    x -= 1;
                else
                    x += 1;
            }
            if (a == 2)
            {
                if (y != 4)
                    y += 1;
                else
                    y -= 1;
            }
            if ( a == 3)
            {
                if (y != 0)
                    y -= 1;
                else
                    y += 1;
            }
            if ((y != 4) && (x != 4))
            {
                Shift(CoordinatesToPosition(x, y));
            }
        }
        public bool Check()
        {
            if ((x0 == 3) && (y0 == 3))
            {
                if ((field[0, 0] == 1) && (field[1, 0] == 2) && (field[2, 0] == 3) && (field[3, 0] == 4) && (field[0, 1] == 5) && (field[1, 1] == 6)
                    && (field[2, 1] == 7) && (field[3, 1] == 8) && (field[0, 2] == 9) && (field[1, 2] == 10) && (field[2, 2] == 11) && (field[3, 2] == 12)
                    && (field[0, 3] == 13) && (field[1, 3] == 14) && (field[2, 3] == 15))
                    return true;
                else
                    return false;
            }
            else
                return false;

        }
       
        public void Undo()
        {
            Memento memento = Caretaker.PopState();
            
            if (memento != null)
            {
                field = memento.GetState();
                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        if (field[x, y] == 0)
                        {
                            x0 = x;
                            y0 = y;
                            break;
                        }
                    }
                }
            }
        }

    }
}
