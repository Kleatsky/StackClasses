using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClassesConsole
{
    public static class StackWithStackItemExtensions
    {
        public static void Merge(this StackWithStackItem s1, StackWithStackItem s2)
        {
            if (s2 != null)
            {
                if (s2.Size > 0)
                {
                    while (s2.Size > 0)
                    {
                        try
                        {
                            s1.Add(s2.Pop());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }
    }
}
