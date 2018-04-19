using System;
using System.Collections.Generic;

namespace MoonExploration
{
	class Program
	{
		public static int QntVertices;
		public static string[,] Matrix;
		private static List<(string source, string destionation)> tests;
		private static Dictionary<string, int> nodesPositionRef;

		static void Main(string[] args)
		{
			while (true)
			{
				QntVertices = Convert.ToInt32(Console.In.ReadLine());
				Matrix = new string[QntVertices, QntVertices];
				tests = new List<(string source, string destionation)>();
				nodesPositionRef = new Dictionary<string, int>();

				// ===================
				// Popula a matriz
				for (int i = 0; i < QntVertices; i++)
				{
					var lineElemets = Console.In.ReadLine().Split(" ");
					for (int j = 0; j < lineElemets.Length; j++)
					{
						Matrix[i, j] = lineElemets[j];
					}
				}
				// ===================

				// ===================
				// Casos de teste
				string testPath;
				while (true)
				{
					testPath = Console.In.ReadLine();
					if (testPath == null || testPath == " " || testPath == "")
						break;

					var path = testPath.Split(" ");
					tests.Add((path[0], path[1]));
				}
				// ===================

				// ===================
				// Resultados
				Graph graph = new Graph(QntVertices);

				// Faz a ligação dos nodes
				for (int i = 0; i < QntVertices; i++)
				{
					for (int j = 0; j < QntVertices; j++)
					{
						if (Matrix[j, i] == ".")
						{
							graph.AddEdge(j, i); // Cria a ligação entre os nodes

							// Salva a referenecias string -> posicao
							nodesPositionRef[Matrix[j, j]] = j;
							nodesPositionRef[Matrix[i, i]] = i;
						}
					}
				}

				// Verifica os caminhos requiridos
				for (int i = 0; i < tests.Count; i++)
				{
					// Verifica se os nodes existem no grafo
					if (!nodesPositionRef.ContainsKey(tests[i].source) || !nodesPositionRef.ContainsKey(tests[i].destionation))
					{
						Console.Write("! ");
					}
					else
					{
						if (graph.IsReachable(nodesPositionRef[tests[i].source], nodesPositionRef[tests[i].destionation]))
						{ // Existe caminho
							Console.Write("* ");
						}
						else
						{ // Não existe caminho
							Console.Write("! ");
						}
					}
				}

				Console.Write("\n");
				// ===================
			}
		}
	}
}
