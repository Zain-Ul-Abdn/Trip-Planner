using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    internal class Class1
    {
       // UserDashboard ud = new UserDashboard();
        public int[] array = new int[3];


        //public void call()
        //{
        //    Queue q1 = new Queue();
        //    q1 = UserDashboard.q;
        //    if (q1.rear == 4)
        //    {
        //        distancecreator5(q1);
        //    }
        //    else if (q1.rear == 3)
        //    {
        //        distancecreator4(q1);
        //    }
        //    else if (q1.rear == 2)
        //    {
        //        array = distancecreator3(q1);
        //    }

        //}


      /*  static void Main(string[] args)
        {

            q1.enqueue("Karachi");
            q1.enqueue("Lahore");
            q1.enqueue("Islamabad");
            q1.enqueue("Sukkur");
            q1.enqueue("Hyderabad City");



            Console.WriteLine("How many cities?\na)5 cities \nb)4 cities \nc)3 cities");
            string reply = Console.ReadLine();
           q. if (reply == "a" && q1.rear == 4)
            {
                distancecreator5(q1);
            }
            else if (reply == "b" && q1.rear == 3)
            {
                distancecreator4(q1);
            }
            else if (reply == "c" && q1.rear == 2)
            {
                distancecreator3(q1);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }*/



        public static int[] findcity(string a, string[,] city)
        {

            for (int i = 0; i < city.GetLength(0); i++)
            {
                for (int j = 0; j < city.GetLength(1); j++)
                {
                    if (city[i, j] == a)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };


        }
        public static void distancecreator5(Queue q1)
        {
            int[] d1 = new int[10];
            int k = 0;
            Excel e1 = new Excel(@"C:\Users\M Zain\Desktop\pk.xlsx", 1);
            string[,] cityname = e1.ReadRange(2, 1, 150, 2);
            double[,] latitude = e1.ReadRange2(2, 2, 150, 3);
            double[,] longitude = e1.ReadRange2(2, 3, 150, 4);
            for (int i = q1.front; i < 4; i++)
            {
                for (int j = i + 1; j <= q1.rear; j++)
                {
                    int[] foundat = findcity(q1.Q[i], cityname);
                    int[] foundat1 = findcity(q1.Q[j], cityname);
                    double lat1 = latitude[foundat[0], foundat[1]];
                    double lat2 = latitude[foundat1[0], foundat1[1]];
                    double lng1 = longitude[foundat[0], foundat[1]];
                    double lng2 = longitude[foundat1[0], foundat1[1]];
                    double answer = Distance(lat1, lng1, lat2, lng2);
                    if (k < 10)
                    {
                        d1[k++] = Convert.ToInt32(answer);

                    }

                }

            }
            Console.WriteLine("The edges are:");
            for (int i = 0; i < d1.Length; i++)
            {

                Console.WriteLine(d1[i]);
            }
            fivecities(d1[0], d1[1], d1[2], d1[3], d1[4], d1[5], d1[6], d1[7], d1[8], d1[9]);

            e1.Close();
            Class1 obj = new Class1();
            obj.array = new int [d1.Length];
            for (int i = 0; i < d1.Length; i++)
            {

                // Console.WriteLine(d1[i]);
                obj.array[i] = d1[i];
            }
        }

        public static void distancecreator4(Queue q1)
        {
            int[] d1 = new int[6];
            int k = 0;
            // Excel e1 = new Excel(@"C:\Users\92310\Desktop\city.xlsx", 1);
            Excel e1 = new Excel(@"C:\Users\M Zain\Desktop\pk.xlsx",1);
            string[,] cityname = e1.ReadRange(2, 1, 150, 2);
            double[,] latitude = e1.ReadRange2(2, 2, 150, 3);
            double[,] longitude = e1.ReadRange2(2, 3, 150, 4);
            for (int i = q1.front; i < 3; i++)
            {
                for (int j = i + 1; j <= q1.rear; j++)
                {
                    int[] foundat = findcity(q1.Q[i], cityname);
                    int[] foundat1 = findcity(q1.Q[j], cityname);
                    double lat1 = latitude[foundat[0], foundat[1]];
                    double lat2 = latitude[foundat1[0], foundat1[1]];
                    double lng1 = longitude[foundat[0], foundat[1]];
                    double lng2 = longitude[foundat1[0], foundat1[1]];
                    double answer = Distance(lat1, lng1, lat2, lng2);
                    if (k < 10)
                    {
                        d1[k++] = Convert.ToInt32(answer);

                    }

                }

            }
            Console.WriteLine("The edges are:");
            for (int i = 0; i < d1.Length; i++)
            {

                Console.WriteLine(d1[i]);
            }
            fourcities(d1[0], d1[1], d1[2], d1[3], d1[4], d1[5]);
            e1.Close();

        }


        public static int [] distancecreator3(Queue q1)
        {
            int[] d1 = new int[3];
            int k = 0;
            Excel e1 = new Excel(@"C:\Users\M Zain\Desktop\pk.xlsx", 1);
            string[,] cityname = e1.ReadRange(2, 1, 150, 2);
            double[,] latitude = e1.ReadRange2(2, 2, 150, 3);
            double[,] longitude = e1.ReadRange2(2, 3, 150, 4);
            for (int i = q1.front; i < 2; i++)
            {
                for (int j = i + 1; j <= q1.rear; j++)
                {
                    int[] foundat = findcity(q1.Q[i], cityname);
                    int[] foundat1 = findcity(q1.Q[j], cityname);
                    double lat1 = latitude[foundat[0], foundat[1]];
                    double lat2 = latitude[foundat1[0], foundat1[1]];
                    double lng1 = longitude[foundat[0], foundat[1]];
                    double lng2 = longitude[foundat1[0], foundat1[1]];
                    double answer = Distance(lat1, lng1, lat2, lng2);
                    if (k < 10)
                    {
                        d1[k++] = Convert.ToInt32(answer);

                    }

                }

            }
            Console.WriteLine("The edges are:");
            for (int i = 0; i < d1.Length; i++)
            {

                Console.WriteLine(d1[i]);
            }
            threecities(d1[0], d1[1], d1[2]);
            e1.Close();

            // UserDashboard ud = new UserDashboard();
            Class1 obj = new Class1();
            int[] array = new int[d1.Length];
            //obj.array = new int[d1.Length];
            for (int i = 0; i < 3; i++)
            {

                // Console.WriteLine(d1[i]);
                array[i] = d1[i];
            }
            return array;

        }
        public static bool ContainsValue(double[] values, int endIndex, double valueToFind)
        {
            // simple linq way:
            // return values.Take(endIndex).Contains(valueToFind);

            // classic way:
            for (int i = 0; i < endIndex; i++)
            {
                if (values[i] == valueToFind)
                    return true;
            }
            return false;
        }

        public static double Distance(double lat1, double lon1, double lat2, double lon2)
        {

            double R = 6371; // Earth's radius in kilometers
            double dLat = ToRadians(lat2 - lat1);
            double dLon = ToRadians(lon2 - lon1);
            lat1 = ToRadians(lat1);
            lat2 = ToRadians(lat2);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = R * c;
            return d;
        }

        private static double ToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }


        public static void fivecities(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)

        {
            int V = 5; // Number of vertices in graph
            int E = 10; // Number of edges in graph
            Graph graph = new Graph(V, E);
            graph.fillgraph5(graph, a, b, c, d, e, f, g, h, i, j);



            // Function call
            graph.KruskalMST();
        }
        public static void threecities(int a, int b, int c)

        {
            int V = 3; // Number of vertices in graph
            int E = 3; // Number of edges in graph
            Graph graph = new Graph(V, E);
            graph.fillgraph3(graph, a, b, c);



            // Function call
            graph.KruskalMST();
        }
        public static void fourcities(int a, int b, int c, int d, int e, int f)

        {
            int V = 4; // Number of vertices in graph
            int E = 6; // Number of edges in graph
            Graph graph = new Graph(V, E);
            graph.fillgraph4(graph, a, b, c, d, e, f);



            // Function call
            graph.KruskalMST();
        }

    }

    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);

            ws = wb.Worksheets[Sheet];

        }
        public void Close()
        {

            wb.Close(SaveChanges: false);
            excel.Quit();
        }

        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
            {
                return ws.Cells[i, j].Value2;

            }
            else
            {
                return "";
            }




        }
        public double ReadCell2(int i, int j)
        {

            i++;
            j++;
            double a = ws.Cells[i, j].Value2;
            wb.Close();
            return a;
        }

        public string[,] ReadRange(int starti, int starty, int endi, int endy)
        {

            _Excel.Range range = (_Excel.Range)ws.Range[ws.Cells[starti, starty], ws.Cells[endi, endy]];
            object[,] holder = range.Value2;
            string[,] returnstring = new string[endi - starti, endy - starty];
            for (int p = 1; p <= endi - starti; p++)
            {
                for (int q = 1; q <= endy - starty; q++)
                {
                    returnstring[p - 1, q - 1] = holder[p, q].ToString();
                }
            }
            return returnstring;
        }
        public double[,] ReadRange2(int starti, int starty, int endi, int endy)
        {

            _Excel.Range range = (_Excel.Range)ws.Range[ws.Cells[starti, starty], ws.Cells[endi, endy]];
            object[,] holder = range.Value2;
            double[,] returnstring = new double[endi - starti, endy - starty];
            for (int p = 1; p <= endi - starti; p++)
            {
                for (int q = 1; q <= endy - starty; q++)
                {
                    returnstring[p - 1, q - 1] = Convert.ToDouble(holder[p, q].ToString());
                }
            }
            return returnstring;
        }
    }
    public class Queue
    {
        public const int max = 5;
        public string[] Q = new string[max];
        public int front, rear;
        public Queue()
        {
            front = rear = -1;
        }
        public bool isEmpty()
        {
            return (rear == -1 && front == -1);
        }
        public bool isFull()
        {
            return (rear == max - 1);
        }
        public string peek()
        {
            if (isEmpty() == false)
                return Q[front];
            Console.WriteLine("\nThe queue is empty thus returning -1");
            return "-1";
        }
        public void printQueue()
        {
            if (isEmpty() == false)
            {
                Console.WriteLine("\nQueue: ");
                for (int i = front; i < max; i++)
                {
                    Console.Write(Q[i] + "  ");
                }
                Console.WriteLine("\nFront: {0} Rear: {1}\n", Q[front], Q[rear]);
            }
            else
            {
                Console.WriteLine("The queue is empty.");
            }
        }
        public void enqueue(string data)
        {
            if (isFull() == true)
            {
                Console.WriteLine("Queue is full.");
                return;
            }
            else if (isEmpty() == true)
            {
                front = rear = 0;
                Q[rear] = data;
            }
            else
            {
                rear = rear + 1;
                Q[rear] = data;
            }
            Console.WriteLine(data + " has been enqueued");
        }
        public void dequeue()
        {
            if (isEmpty() == true)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine(Q[front] + " has been dequeued");
            if (front == rear)
                front = rear = -1;
            else
            {
                front = front + 1;
            }
        }
    }

    public class Graph
    {

        // A class to represent a graph edge
        class Edge : IComparable<Edge>
        {
            public int src, dest, weight;

            // Comparator function used for sorting edges
            // based on their weight
            public int CompareTo(Edge compareEdge)
            {
                return this.weight - compareEdge.weight;
            }
        }

        // A class to represent
        // a subset for union-find
        public class subset
        {
            public int parent, rank;
        };

        int V, E; // V-> no. of vertices & E->no.of edges
        Edge[] edge; // collection of all edges

        // Creates a graph with V vertices and E edges
        public Graph(int v, int e)
        {
            V = v;
            E = e;
            edge = new Edge[E];
            string[] name = new string[e];
            for (int i = 0; i < e; ++i)
                edge[i] = new Edge();
        }

        // A utility function to find set of an element i
        // (uses path compression technique)
        int find(subset[] subsets, int i)
        {
            // find root and make root as
            // parent of i (path compression)
            if (subsets[i].parent != i)
                subsets[i].parent
                    = find(subsets, subsets[i].parent);

            return subsets[i].parent;
        }

        // A function that does union of
        // two sets of x and y (uses union by rank)
        void Union(subset[] subsets, int x, int y)
        {
            int xroot = find(subsets, x);
            int yroot = find(subsets, y);

            // Attach smaller rank tree under root of
            // high rank tree (Union by Rank)
            if (subsets[xroot].rank < subsets[yroot].rank)
                subsets[xroot].parent = yroot;
            else if (subsets[xroot].rank > subsets[yroot].rank)
                subsets[yroot].parent = xroot;

            // If ranks are same, then make one as root
            // and increment its rank by one
            else
            {
                subsets[yroot].parent = xroot;
                subsets[xroot].rank++;
            }
        }

        // The main function to construct MST
        // using Kruskal's algorithm
        public void KruskalMST()
        {
            // This will store the
            // resultant MST
            Edge[] result = new Edge[V];
            int e = 0; // An index variable, used for result[]
            int i
                = 0; // An index variable, used for sorted edges
            for (i = 0; i < V; ++i)
                result[i] = new Edge();

            // Step 1: Sort all the edges in non-decreasing
            // order of their weight. If we are not allowed
            // to change the given graph, we can create
            // a copy of array of edges
            Array.Sort(edge);

            // Allocate memory for creating V subsets
            subset[] subsets = new subset[V];
            for (i = 0; i < V; ++i)
                subsets[i] = new subset();

            // Create V subsets with single elements
            for (int v = 0; v < V; ++v)
            {
                subsets[v].parent = v;
                subsets[v].rank = 0;
            }

            i = 0; // Index used to pick next edge

            // Number of edges to be taken is equal to V-1
            while (e < V - 1)
            {
                // Step 2: Pick the smallest edge. And increment
                // the index for next iteration
                Edge next_edge = new Edge();
                next_edge = edge[i++];

                int x = find(subsets, next_edge.src);
                int y = find(subsets, next_edge.dest);

                // If including this edge doesn't cause cycle,
                // include it in result and increment the index
                // of result for next edge
                if (x != y)
                {
                    result[e++] = next_edge;
                    Union(subsets, x, y);
                }
                // Else discard the next_edge
            }

            // print the contents of result[] to display
            // the built MST
            Console.WriteLine("Following are the edges in "
                              + "the constructed MST");

            int minimumCost = 0;
            for (i = 0; i < e; ++i)
            {
                Console.WriteLine(result[i].src + " --> "
                                  + result[i].dest
                                  + " == " + result[i].weight);
                minimumCost += result[i].weight;

            }

            Console.WriteLine("Minimum Cost Spanning Tree: "
                              + minimumCost);
            Console.WriteLine("The answer edges are:");
            for (int s = 0; s < result.Length - 1; s++)
            {

                Console.WriteLine(result[s].weight);
            }

            Console.ReadLine();
        }

        public void fillgraph5(Graph graph, int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
        {


            // add edge 0-1
            graph.edge[0].src = 0;
            graph.edge[0].dest = 1;
            graph.edge[0].weight = a;


            // add edge 0-2
            graph.edge[1].src = 0;
            graph.edge[1].dest = 2;
            graph.edge[1].weight = b;

            // add edge 0-3
            graph.edge[2].src = 0;
            graph.edge[2].dest = 3;
            graph.edge[2].weight = c;

            // add edge 0-4
            graph.edge[3].src = 0;
            graph.edge[3].dest = 4;
            graph.edge[3].weight = d;

            // add edge 1-2
            graph.edge[4].src = 1;
            graph.edge[4].dest = 2;
            graph.edge[4].weight = e;

            // add edge 1-3
            graph.edge[5].src = 1;
            graph.edge[5].dest = 3;
            graph.edge[5].weight = f;

            // add edge 1-4
            graph.edge[6].src = 1;
            graph.edge[6].dest = 4;
            graph.edge[6].weight = g;


            // add edge 2-3
            graph.edge[7].src = 2;
            graph.edge[7].dest = 3;
            graph.edge[7].weight = h;

            // add edge 2-4
            graph.edge[8].src = 2;
            graph.edge[8].dest = 4;
            graph.edge[8].weight = i;

            // add edge 3-4
            graph.edge[9].src = 3;
            graph.edge[9].dest = 4;
            graph.edge[9].weight = j;



        }
        public void fillgraph3(Graph graph, int a, int b, int c)
        {


            // add edge 0-1
            graph.edge[0].src = 0;
            graph.edge[0].dest = 1;
            graph.edge[0].weight = a;


            // add edge 0-2
            graph.edge[1].src = 0;
            graph.edge[1].dest = 2;
            graph.edge[1].weight = b;


            // add edge 1-2
            graph.edge[2].src = 1;
            graph.edge[2].dest = 2;
            graph.edge[2].weight = c;
        }
        public void fillgraph4(Graph graph, int a, int b, int c, int d, int e, int f)
        {


            // add edge 0-1
            graph.edge[0].src = 0;
            graph.edge[0].dest = 1;
            graph.edge[0].weight = a;


            // add edge 0-2
            graph.edge[1].src = 0;
            graph.edge[1].dest = 2;
            graph.edge[1].weight = b;

            // add edge 0-3
            graph.edge[2].src = 0;
            graph.edge[2].dest = 3;
            graph.edge[2].weight = c;



            // add edge 1-2
            graph.edge[3].src = 1;
            graph.edge[3].dest = 2;
            graph.edge[3].weight = d;

            // add edge 1-3
            graph.edge[4].src = 1;
            graph.edge[4].dest = 3;
            graph.edge[4].weight = e;




            // add edge 2-3
            graph.edge[5].src = 2;
            graph.edge[5].dest = 3;
            graph.edge[5].weight = f;

        }

    }
}



