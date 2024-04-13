using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    public class Caretaker
    {
        public static Stack<Memento> mementos = new Stack<Memento>();

        public static void SaveState(Memento memento)
        {
            mementos.Push(memento);
        }

        public static Memento PopState()
        {
            if (mementos.Count > 0)
            {
                return mementos.Pop();
            }
            else
            {
                return null;
            }
        }

    }
}

