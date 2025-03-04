using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClassesConsole
{
    public class Stack
    {
        private List<string> stack;
        public int Size => stack.Count;
        public Stack(params string[] items)
        {
            stack = new List<string>(items);
        }
        public bool Add(string item)
        {
            try
            {
                if (!string.IsNullOrEmpty(item))
                {
                    stack.Add(item);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public string Pop()
        {
            if (stack.Count == 0 || stack == null)
            {
                throw new Exception("Стек пустой");
            }
            try
            {
                string tempString = stack.Last();
                stack.RemoveAt(stack.Count - 1);
                return tempString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public string Top()
        {
            if(stack.Count == 0 || stack == null)
            {
                return null;
            }
            else
            {
                return stack.Last();
            }
        }
        public static Stack Concat(params Stack[] stacks)
        {
            Stack returnStack = new Stack();
            if (stacks == null || stacks.Length == 0) return null;
            else
            {
                foreach (var item in stacks)
                {
                    try
                    {
                        returnStack.Merge(item);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                return returnStack;
            }   
        }
        public void ShowAllElements()
        {
            if(!( stack.Count == 0 || stack == null))
            {
                int count = 0;
                foreach (var item in stack)
                {
                    Console.Write(count + ": " + item + ", ");
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
