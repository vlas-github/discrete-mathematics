using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using DM_lab5_2.ExpressionClasses;
using System.Diagnostics;

namespace DM_lab5_2.RPN
{
    class PostfixNotation
    {
        private string input;

        public PostfixNotation(string input)
        {
            this.input = input;
        }

        private bool isMatch(string s)
        {
            Regex r = new Regex(@"[()¬ᐱᐯ⊕←→↔↓|]");

            return r.IsMatch(s);
        }
        private bool isConstisVar(string s)
        {
            Regex r = new Regex(@"1|0");
            return r.IsMatch(s);
        }
        private bool isVar(string s)
        {
            Regex r = new Regex(@"[A-za-z][A-za-z0-9]*");
            return r.IsMatch(s);
        }
        private int getPriority(string s)
        {
            switch (s)
            {
                case "(":
                case ")":
                    return 1;
                case "↔":
                case "↓":
                case "|":
                    return 2;
                case "→":
                case "←":
                    return 3;
                case "ᐯ":
                case "⊕":
                    return 4;
                case "ᐱ":
                    return 5;
                case "¬":
                    return 6;
                default:
                    return -1;
            }            
        }
        private MatchCollection split()
        {
            Regex r = new Regex(@"[A-za-z][A-za-z0-9]*|[10()¬ᐱᐯ⊕←→↔↓|]");
            return r.Matches(input);
        }
        private string convertToPostfixNotation()
        {
            StringBuilder result    = new StringBuilder(100);
            MatchCollection mc      = split();
            Stack<string> stack     = new Stack<string>();

            for (int i = 0; i < mc.Count; i++)
            {
                if (isMatch(mc[i].ToString()))
                {
                    if (mc[i].ToString() == ")")
                    {
                        while (stack.Count > 0 && stack.Peek() != "(")
                            result.Append(stack.Pop() + " ");

                        stack.Pop();
                    }
                    else if (stack.Count > 0 && mc[i].ToString() != "(" 
                             && getPriority(mc[i].ToString()) <= getPriority(stack.Peek()))
                    {
                        if(stack.Peek() != "(")
                            result.Append(stack.Pop() + " ");
                        else
                            stack.Pop();
                        
                        stack.Push(mc[i].ToString());
                    }
                    else
                    {
                        stack.Push(mc[i].ToString());
                    }
                }
                else
                {
                    result.Append(mc[i].ToString() + " ");
                }
            }

            while (stack.Count > 0)
                result.Append(stack.Pop() + " ");

            return result.ToString();
        }
        private int getCountVar()
        {
            Regex r = new Regex(@"[A-za-z][A-za-z0-9]*");
            return r.Matches(input).Count;
        }
        public List<string> getVar()
        {
            Regex r = new Regex(@"[A-za-z][A-za-z0-9]*");
            MatchCollection mc = r.Matches(input);
            List<string> list = new List<string>();

            for (int i = 0; i < mc.Count; i++)
            {
                bool f = true;

                for (int j = 0; j < list.Count; j++)
                    if (list[j] == mc[i].ToString())
                        f = false;

                if (f) list.Add(mc[i].ToString());
            }

            list.Sort();

            return list;
        }
        public Expression convertToExpression()
        {
            List<string> mc = new List<string>(convertToPostfixNotation().Split(' '));
            Stack<Expression> stack = new Stack<Expression>();
            List<string> listVar = getVar();

            Debug.WriteLine(mc[0]);

            for (int i = 0; i < mc.Count; i++)
            {
                string tmp = mc[i].ToString();

                if (isConstisVar(tmp))
                    stack.Push(new Number(tmp == "1"));

                if (isVar(tmp))
                    stack.Push(new Variable(listVar.BinarySearch(tmp)));

                if (isMatch(tmp))
                {
                    switch (tmp)
                    {
                        case "↔":
                            stack.Push(new Equivalence(stack.Pop(), stack.Pop()));
                            break;
                        case "↓":
                            stack.Push(new PierceArrow(stack.Pop(), stack.Pop()));
                            break;
                        case "|":
                            stack.Push(new ShefferStroke(stack.Pop(), stack.Pop()));
                            break;
                        case "→":
                            stack.Push(new Implication(stack.Pop(), stack.Pop()));
                            break;
                        case "←":
                            stack.Push(new ConverseImplication(stack.Pop(), stack.Pop()));
                            break;
                        case "ᐯ":
                            stack.Push(new Union(stack.Pop(), stack.Pop()));
                            break;
                        case "⊕":
                            stack.Push(new Modulo2(stack.Pop(), stack.Pop()));
                            break;
                        case "ᐱ":
                            stack.Push(new Intersection(stack.Pop(), stack.Pop()));
                            break;
                        case "¬":
                            stack.Push(new Negation(stack.Pop()));
                            break;
                    } 
                }
                Debug.WriteLine(stack.Peek());
            }
            
            return stack.Pop();            
        }
    }
}
 