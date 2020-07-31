using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Stack
{
  
    public class Stack
    {
        public static ArrayList list = new ArrayList();
        public void Push(object obj)
        {
            if (obj is null)
                throw new InvalidOperationException("please enter a value");
            list.Add(obj);
        }
        public object Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("The stack is empty");
            Object lastObject = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return lastObject;

        }
        public void Clear()
        {
            list.Clear();
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            

        }
    }
}
