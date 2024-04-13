using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    public class Memento
    {
        public int[,] field;

        public Memento(int[,] field)
        {
            this.field = new int[field.GetLength(0), field.GetLength(1)];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    this.field[i, j] = field[i, j];
                }
            }
        }

        public int[,] GetState()
        {
            int[,] fieldCopy = new int[4,4];
            for(int i =0; i < 4; i++)
                for(int j = 0; j < 4; j++)
                {
                    fieldCopy[i, j] = field[i, j];
                }
            return fieldCopy;
        }

    }

}

