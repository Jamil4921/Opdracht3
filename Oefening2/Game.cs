using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Oefening2
{
    internal class Game<T>
    {
        
        List<T> game = new List<T>();

        public void toevoegen(T item)
        {
            game.Add(item);
        }

        public T Verwijder()
        {
            if (game.Count == 0)
                throw new StackOverflowException();

            T pos1 = game[0];
            game.RemoveAt(0);
            return pos1;
        }

        public void Leegmaken()
        {
            game.Clear();
        }

        public override string ToString()
        {
            string content = "";
            foreach (T s in game)
                content += s.ToString() + "/ ";
            return content;
        }

        public bool IsAanwezig(T item)
        {
            if (game.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Copy()
        {
            return this.MemberwiseClone();
        }
    }
}
