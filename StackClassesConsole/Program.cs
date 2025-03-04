namespace StackClassesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack("a", "b");
            stack.Add(null);
            stack.Add("c");

            Console.WriteLine("Top: " + stack.Top());

            Console.WriteLine(stack.Put() + " Size = " + stack.Size);
            Console.WriteLine(stack.Put() + " Size = " + stack.Size);
            Console.WriteLine(stack.Put() + " Size = " + stack.Size);
            //Console.WriteLine(stack.Put() + " Size = " + stack.Size);

            Console.WriteLine("Top: " + (stack.Top()==null? "null" :"not a null" ));



            stack.ShowAllElements();

            Console.WriteLine("Hello, World!");
        }
    }
}
