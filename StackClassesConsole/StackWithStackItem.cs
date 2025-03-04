using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClassesConsole
{
    public class StackWithStackItem
    {
        private class StackItem
        {
            public string Item;
            public StackItem PreviousStackItem;
            public StackItem(string item, StackItem previousStackItem)
            {
                Item = item;
                PreviousStackItem = previousStackItem;
            }
        }
        private StackItem stack;
        private int size;
        public int Size => size;

        public StackWithStackItem(params string[] items)
        {
            if (items == null || items.Length == 0)
            {
                size = 0;
                stack = null;
            }
            else
            {
                size = 1;
                stack = new StackItem(items[0], null);
                for (int i = 1; i < items.Length; i++)
                {
                    stack = new StackItem(items[i], stack);
                    size++;
                }
            }
        }
        public bool Add(string item)
        {
            try
            {
                if (!string.IsNullOrEmpty(item))
                {
                    stack = new StackItem(item, stack);
                    size++;
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
            if (size == 0 || stack == null)
            {
                throw new Exception("Стек пустой");
            }
            try
            {
                string tempString = stack.Item;
                stack = stack.PreviousStackItem;
                size--;
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
            if (size == 0 || stack == null)
            {
                return null;
            }
            else
            {
                return stack.Item;
            }
        }
        public static StackWithStackItem Concat(params StackWithStackItem[] stacks)
        {
            StackWithStackItem returnStack = new StackWithStackItem();
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
            if (!(size == 0 || stack == null))
            {
                StackItem previousStackItem = stack;
                int count = 0;
                while (previousStackItem != null)
                {
                    Console.Write(count + ": " + previousStackItem.Item + ", ");
                    count++;
                    previousStackItem = previousStackItem.PreviousStackItem;
                }
                Console.WriteLine();
            }
        }
    }
}
