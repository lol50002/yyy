using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Tree
    {
        string value;
        Tree Left;
        Tree Right;
        public static Tree getTree(string str)
        {
            Stack<char> sm = new Stack<char>();

            for (char chr=str[0];chr<str.Length;chr++)
            {
                if (chr == '(' || chr == '{' || chr == '[')
                {
                    sm.Push(chr);
                    continue;
                }

                if (chr != ')' && chr != '}' && chr != ']')
                    continue;

                char brace;

                if (sm.Count > 0)
                    brace = (Char)sm.Pop();
                if ((sm.Count ==0)&&(chr='+'))
                    return chr='+';
            }
            return 
        }


        
    }
}
