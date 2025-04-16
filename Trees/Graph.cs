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
    }
}
