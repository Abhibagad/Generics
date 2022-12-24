namespace DataStructure
{
    public class program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);

            //for (Node temp = head; temp != null; temp = temp.next)
            //    Console.WriteLine(temp.data + " ");

            //AddingNumber<int> add = new AddingNumber<int>();

            //add.AddLast("70");
            //add.AddBefore(30);

            RemoveFirst remove = new RemoveFirst();
            //remove.RemoveFirst();
            Console.WriteLine(" REMOVING");
            //foreach(var n in remove)
            {
                Console.WriteLine(n);
            }


        }
    }
}
