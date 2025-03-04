namespace StackClassesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack("a", "b");
            stack.Add(null);
            stack.Add("c");

            Stack stack2 = new Stack("1", "2", "3"); //Merge check

            stack.Merge(stack2);

            Console.WriteLine("Top: " + stack.Top()); // Top check

            Console.WriteLine(stack.Pop() + " Size = " + stack.Size);
            Console.WriteLine(stack.Pop() + " Size = " + stack.Size);
            Console.WriteLine(stack.Pop() + " Size = " + stack.Size);
            Console.WriteLine(stack.Pop() + " Size = " + stack.Size);
            Console.WriteLine(stack.Pop() + " Size = " + stack.Size);
            Console.WriteLine(stack.Pop() + " Size = " + stack.Size);
            //Console.WriteLine(stack.Pop() + " Size = " + stack.Size); //Exception check

            Console.WriteLine("Top: " + (stack.Top()==null? "null" :"not a null" )); //Top null check


            Console.WriteLine("\n");
            stack.ShowAllElements();

            Stack stackmerge1 = new Stack("a", "b", "c");  // Merge from null check
            Stack stackmerge2 = new Stack();
            stackmerge1.Merge(stackmerge2);
            stackmerge1.ShowAllElements();

            stackmerge2.Merge(stackmerge1); // Merge for null check
            stackmerge2.ShowAllElements();



            Console.WriteLine("Hello, World!");
        }
    }
}
