namespace LinkedListDataStructurres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose what program u want ");
            Console.WriteLine("1.creating linked list");
            int choose=Convert.ToInt32(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    Console.WriteLine("welcome to the creating of linked list program");
                    LinkedList l = new LinkedList();
                    l.Insert(56);
                    l.Insert(30);
                    l.Insert(70);
                    l.Display();
                    break;
            }
        }
    }
}