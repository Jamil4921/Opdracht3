namespace Oefening1
{
    internal class ArrayList<T>
    {
        private List<T> container;


        public  ArrayList()        
        {
            this.container = new List<T>();
        }

        public void toevoegen(T item)
        {
            container.Add(item);
        }

        public T Verwijder()
        {
            if (container.Count == 0)
                throw new StackOverflowException();

            T pos1 = container[0];
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

        public bool IsAanwezig(T item)
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