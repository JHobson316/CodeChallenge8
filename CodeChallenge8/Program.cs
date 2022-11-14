using System.Security.Cryptography.X509Certificates;

namespace CodeChallenge8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            // Populating linked list
            OurNode A = new OurNode("A");
            OurNode B = new OurNode("B");
            OurNode C = new OurNode("C");
            OurNode D = new OurNode("D");
            OurNode E = new OurNode("E");

            OurNode One = new OurNode("1");
            OurNode Two = new OurNode("2");
            OurNode Three = new OurNode("3");
            OurNode Four = new OurNode("4");
            OurNode Five = new OurNode("5");

            OurLinkedList letters = new OurLinkedList(new List<OurNode> { A, B, C, D, E });
            OurLinkedList numbers = new OurLinkedList(new List<OurNode> { One, Two, Three, Four, Five});

            OurNode c = letters.Head;
            OurNode d = letters.Tail;

            OurNode j = numbers.Head;
            OurNode k = numbers.Tail;

            OurNode Starter = new OurNode("start");
            OurLinkedList Zipped = new OurLinkedList(new List<OurNode> {Starter});

            OurNode x = Zipped.Head;
            OurNode y = Zipped.Tail;

            while (c!= null && j!= null)
            {
                int i = 0;
                while(c!= null && i%2==0)
                {
                    string s = c.Info;
                    Zipped.AddFirst(new OurNode (s));
                    c = c.Next;
                    i++;
                }
                while(j != null && i%2!=0)
                {
                    string s = j.Info;
                    Zipped.AddFirst(new OurNode(s));
                    j = j.Next;
                    i++;
                }
                if (i == 10) 
                {
                    break;
                }
            }


            Console.WriteLine("List Values in Order:");
            while (x != null)
            {
                Console.WriteLine(x.Info);
                x = x.Next;
            }
            Console.Write("------------\n");
        }
    }
}