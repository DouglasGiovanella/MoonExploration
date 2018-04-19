using System.Collections.Generic;

namespace MoonExploration
{
	/// <summary>
	/// https://www.geeksforgeeks.org/find-if-there-is-a-path-between-two-vertices-in-a-given-graph/
	/// </summary>
	public class Graph
	{
		private int verticesQuantity;

		private LinkedList<int>[] adjList;

		public Graph(int vertices)
		{
			verticesQuantity = vertices;
			InitAdjList();
		}

		private void InitAdjList()
		{
			adjList = new LinkedList<int>[verticesQuantity];

			for (int i = 0; i < verticesQuantity; i++)
			{
				adjList[i] = new LinkedList<int>();
			}
		}

		// add edge from u to v
		public void AddEdge(int source, int destination) => adjList[source].AddLast(destination);

		//prints BFS traversal from a given source s
		public bool IsReachable(int source, int destination)
		{
			LinkedList<int> temp;
			// Mark all the vertices as not visited(By default set
			// as false)
			bool[] visited = new bool[verticesQuantity];

			// Create a queue for BFS
			LinkedList<int> queue = new LinkedList<int>();

			// Mark the current node as visited and enqueue it
			visited[source] = true;
			queue.AddLast(source);

			// 'i' will be used to get all adjacent vertices of a vertex
			while (queue.Count != 0)
			{
				// Dequeue a vertex from queue and print it
				source = queue.First.Value;
				queue.RemoveFirst();

				int n;
				temp = new LinkedList<int>(adjList[source]);

				// Get all adjacent vertices of the dequeued vertex s
				// If a adjacent has not been visited, then mark it
				// visited and enqueue it
				while (temp.Count != 0)
				{
					n = temp.First.Value;
					temp.RemoveFirst();

					// If this adjacent node is the destination node,
					// then return true
					if (n == destination)
						return true;

					// Else, continue to do BFS
					if (!visited[n])
					{
						visited[n] = true;
						queue.AddLast(n);
					}
				}
			}

			// If BFS is complete without visited d
			return false;
		}
	}
}
