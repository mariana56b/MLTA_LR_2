using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLTA_LR_2
{
    public class GraphTraversal
    {
        public int[,] undirectedGraph; 
        public int[,] directedGraph;    
        string[] vertices = { "a", "b", "c", "d", "e", "f" }; 

        public void InitializeGraphs()
        {
            // Ініціалізація матриці для неорієнтованого графа
            undirectedGraph = new int[,]
            {
                { 0, 1, 1, 0, 1, 0 }, // a
                { 1, 0, 0, 1, 1, 0 }, // b
                { 1, 0, 1, 1, 0, 1 }, // c
                { 0, 1, 1, 1, 0, 1 }, // d
                { 1, 1, 0, 0, 0, 0 }, // e
                { 0, 0, 1, 1, 0, 0 }  // f
            };

            // Ініціалізація матриці для орієнтованого графа
            directedGraph = new int[,]
            {
                { 1, 0, 0, 0, 0, 1 }, // a
                { 1, 1, 0, 1, 0, 1 }, // b
                { 1, 0, 0, 1, 1, 0 }, // c
                { 0, 0, 0, 0, 1, 0 }, // d
                { 0, 0, 0, 0, 0, 0 }, // e
                { 0, 0, 0, 0, 0, 0 }  // f
            };
        }

        // Обхід у глибину (DFS)
        public List<string> DFS(int[,] graph, int start)
        {
            Stack<int> stack = new Stack<int>();
            HashSet<int> visited = new HashSet<int>();
            List<string> result = new List<string>();

            stack.Push(start);
            while (stack.Count > 0)
            {
                int node = stack.Pop();
                if (!visited.Contains(node))
                {
                    visited.Add(node);
                    result.Add(vertices[node]); 

                    for (int neighbor = graph.GetLength(1) - 1; neighbor >= 0; neighbor--)
                    {
                        if (graph[node, neighbor] == 1 && !visited.Contains(neighbor))
                        {
                            stack.Push(neighbor);
                        }
                    }
                }
            }
            return result;
        }

        // Обхід у ширину (BFS)
        public List<string> BFS(int[,] graph, int start)
        {
            Queue<int> queue = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();
            List<string> result = new List<string>();

            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                result.Add(vertices[node]); 

                for (int neighbor = 0; neighbor < graph.GetLength(1); neighbor++)
                {
                    if (graph[node, neighbor] == 1 && !visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }
            return result;
        }
    }
}
