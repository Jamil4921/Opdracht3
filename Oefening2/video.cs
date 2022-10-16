using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    public class video<String>
    {

        private List<String> container;


        public video()
        {
            this.container = new List<String>();
        }

        public void toevoegen(String item)
        {
            container.Add(item);
        }

        public String Verwijder()
        {
            if (container.Count == 0)
                throw new StackOverflowException();

            String pos1 = container[0];
            container.RemoveAt(0);
            return pos1;
        }

        public void Leegmaken()
        {
            container.Clear();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public bool IsAanwezig(String item)
        {
            if (container.Contains(item))
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
