using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge8
{
    public class OurLinkedList
    {
        public OurNode Head { get; set; }
        public OurNode Tail { get; set; }

        public OurLinkedList()
        {
            Head = new OurNode();
            Tail = null;
        }
        public OurLinkedList(List<OurNode> nodes)
        {
            // try catch
            Head = nodes.First();


            if (nodes.Count == 1)
            {

                Head.Next = null;

            }
            else
            {
                Head.Next = nodes[1];
                OurNode Current = Head.Next;
                //Current.Prev = Head;

                for (int i = 1; i <= nodes.Count - 1; i++)
                {

                    if (i != nodes.Count - 1)
                    {
                        Current.Next = nodes[i + 1];
                        Current.Prev = nodes[i - 1];

                    }
                    else
                    {
                        Current.Next = null;
                        Current.Prev = nodes[i - 1];
                        break;
                    }

                    Current = Current.Next;

                }
                Tail = Current;
            }

        }

        public void AddFirst(OurNode node)
        {
            //If no list, set Head = node. else connect list to new head
            if (Head.Next == null)
            {

                Head = node;

            }
            else
            {

                OurNode Current = Head;

                Head = node;
                Head.Next = Current;
                Current.Prev = Head;

            }

        }

        public void AddLast(OurNode node)
        {
            //Updated to account for Tail
            Tail = node;
            if (Head.Next == null)
            {
                Head.Next = node;
                Tail.Prev = Head;
            }
            else
            {
                OurNode Current = Head;
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = Tail;
                Tail.Prev = Current;
            }


        }


    }

    public class OurNode
    {
        public string Info { get; set; }
        public OurNode Next { get; set; }
        public OurNode Prev { get; set; }
        public OurNode()
        {
            Info = "";
            Next = null;
            Prev = null;
        }
        public OurNode(string info)
        {
            Info = info;
            Next = null;
            Prev = null;
        }
        public OurNode(string info, OurNode next)
        {
            Info = info;
            Next = next;
            Next.Prev = this;
        }
    }
}
