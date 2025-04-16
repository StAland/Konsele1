using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Trees
{
    public class Graph
    {
        // Dictionary<Node, List<(Nachbar, Gewicht)>>
        private Dictionary<GraphNode, List<(GraphNode Ziel, int Gewicht)>> adjazenzListe = new();

        public void AddNode(GraphNode node)
        {
            if (!adjazenzListe.ContainsKey(node))
                adjazenzListe[node] = new List<(GraphNode, int)>();
        }
        public void AddEdge(GraphNode from, GraphNode to, int gewicht, bool bidirectional = false)
        {
            AddNode(from);
            AddNode(to);

            adjazenzListe[from].Add((to, gewicht));

            if (bidirectional)
                adjazenzListe[to].Add((from, gewicht));
        }

        public void Print()
        {
            foreach (var eintrag in adjazenzListe)
            {
                Console.Write($"{eintrag.Key}: ");
                foreach (var (ziel, gewicht) in eintrag.Value)
                    Console.Write($"-> {ziel} ({gewicht})  ");
                Console.WriteLine();
            }
        }

        public void Dijkstra(GraphNode start)
        {
            var distanz = new Dictionary<GraphNode, int>();
            var vorgaenger = new Dictionary<GraphNode, GraphNode>();
            var besuchte = new HashSet<GraphNode>();

            foreach (var node in adjazenzListe.Keys)
                distanz[node] = int.MaxValue;

            distanz[start] = 0;

            //Statt einer queue (hier durch ein Sorted Set dargestellt) kann auch eine Liste durchgegangen werden
            var queue = new SortedSet<(int Distanz, GraphNode Knoten)>(Comparer<(int Distanz, GraphNode Knoten)>.Create((a, b) =>
            {
                int cmp = a.Distanz.CompareTo(b.Distanz);
                return cmp == 0 ? a.Knoten.Name.CompareTo(b.Knoten.Name) : cmp;
            }));

            queue.Add((0, start));

            while (queue.Count > 0)
            {
                //hier muss bei einer Liste dann die Liste nach dem niedrigsten wert durchsucht werden.
                var (aktuelleDistanz, aktuellerKnoten) = queue.Min;
                queue.Remove(queue.Min);

                if (besuchte.Contains(aktuellerKnoten))
                    continue;

                besuchte.Add(aktuellerKnoten);

                foreach (var (nachbar, gewicht) in adjazenzListe[aktuellerKnoten])
                {
                    int neueDistanz = aktuelleDistanz + gewicht;
                    if (neueDistanz < distanz[nachbar])
                    {
                        distanz[nachbar] = neueDistanz;
                        vorgaenger[nachbar] = aktuellerKnoten;
                        queue.Add((neueDistanz, nachbar));
                    }
                }
            }

            // Ausgabe
            Console.WriteLine($"Kürzeste Distanzen von {start.Name}:");
            foreach (var kv in distanz)
            {
                Console.WriteLine($"Nach {kv.Key.Name}: {kv.Value}");
            }
        }
    }
}
