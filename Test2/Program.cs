using System;
namespace Test2
{
    class Cycler
    {
        object[] list;
        public Cycler(object[] list)
        {
            this.list = list;
        }
        int i = 0;
        public object GetNext()
        {
            object item;
            if (i >= list.Length)
            {
                i = 0;
            }
            item = list[i];
            i++;
            return item;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            object[] list = { 1, 2, 3, 4, 5 };
            Cycler cl = new Cycler(list);
            for (int i = 0; i < 8; i++)
            {
                Console.Write(cl.GetNext() + " ");
            }

            Console.ReadKey();
        }
    }
}
