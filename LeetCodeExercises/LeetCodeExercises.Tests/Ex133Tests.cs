#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex133Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[][] adjList, int[][] expectedAdjList)
    {
        // Arrange
        var ex = new Ex133();
        var originalGraph = BuildGraphFromAdjList(adjList);

        // Act
        var clonedGraph = originalGraph != null ? ex.CloneGraph(originalGraph) : null;

        // Assert
        if (expectedAdjList.Length == 0)
        {
            Assert.Null(clonedGraph);
            return;
        }

        Assert.NotNull(clonedGraph);
        var clonedAdjList = ConvertGraphToAdjList(clonedGraph, adjList.Length);
        
        // Verify structure is the same
        Assert.Equal(expectedAdjList.Length, clonedAdjList.Length);
        for (int i = 0; i < expectedAdjList.Length; i++)
        {
            Assert.Equal(expectedAdjList[i].OrderBy(x => x).ToArray(), 
                        clonedAdjList[i].OrderBy(x => x).ToArray());
        }

        // Verify it's a deep copy (different object references)
        if (originalGraph != null && clonedGraph != null)
        {
            Assert.NotSame(originalGraph, clonedGraph);
            VerifyDeepCopy(originalGraph, clonedGraph, new HashSet<Node>(), new HashSet<Node>());
        }
    }

    public static IEnumerable<object[]> TestData()
    {
        // Example 1: [[2,4],[1,3],[2,4],[1,3]]
        yield return
        [
            new int[][] 
            { 
                new int[] { 2, 4 }, 
                new int[] { 1, 3 }, 
                new int[] { 2, 4 }, 
                new int[] { 1, 3 } 
            },
            new int[][] 
            { 
                new int[] { 2, 4 }, 
                new int[] { 1, 3 }, 
                new int[] { 2, 4 }, 
                new int[] { 1, 3 } 
            }
        ];

        // Example 2: [[]]
        yield return
        [
            new int[][] { new int[] { } },
            new int[][] { new int[] { } }
        ];

        // Example 3: []
        yield return
        [
            new int[0][],
            new int[0][]
        ];
    }

    private Node? BuildGraphFromAdjList(int[][] adjList)
    {
        if (adjList.Length == 0) return null;

        var nodes = new Dictionary<int, Node>();
        
        // Create all nodes first
        for (int i = 1; i <= adjList.Length; i++)
        {
            nodes[i] = new Node(i);
        }

        // Connect neighbors
        for (int i = 0; i < adjList.Length; i++)
        {
            var currentNode = nodes[i + 1];
            foreach (var neighborVal in adjList[i])
            {
                currentNode.neighbors.Add(nodes[neighborVal]);
            }
        }

        return nodes.ContainsKey(1) ? nodes[1] : null;
    }

    private int[][] ConvertGraphToAdjList(Node? startNode, int expectedSize)
    {
        if (startNode == null) return new int[0][];

        var visited = new HashSet<Node>();
        var nodeValues = new Dictionary<Node, int>();
        var adjList = new List<List<int>>();

        // First pass: collect all nodes and assign values
        var queue = new Queue<Node>();
        queue.Enqueue(startNode);
        visited.Add(startNode);
        nodeValues[startNode] = startNode.val;

        var allNodes = new List<Node> { startNode };

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            foreach (var neighbor in current.neighbors)
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    nodeValues[neighbor] = neighbor.val;
                    allNodes.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }

        // Sort nodes by their values to ensure consistent ordering
        allNodes.Sort((a, b) => a.val.CompareTo(b.val));

        // Create adjacency list
        var result = new int[allNodes.Count][];
        for (int i = 0; i < allNodes.Count; i++)
        {
            var node = allNodes[i];
            var neighbors = node.neighbors.Select(n => n.val).OrderBy(x => x).ToArray();
            result[i] = neighbors;
        }

        return result;
    }

    private void VerifyDeepCopy(Node original, Node cloned, HashSet<Node> visitedOriginal, HashSet<Node> visitedCloned)
    {
        if (visitedOriginal.Contains(original)) return;

        visitedOriginal.Add(original);
        visitedCloned.Add(cloned);

        Assert.Equal(original.val, cloned.val);
        Assert.Equal(original.neighbors.Count, cloned.neighbors.Count);

        for (int i = 0; i < original.neighbors.Count; i++)
        {
            var origNeighbor = original.neighbors[i];
            var clonedNeighbor = cloned.neighbors.FirstOrDefault(n => n.val == origNeighbor.val);
            
            Assert.NotNull(clonedNeighbor);
            Assert.NotSame(origNeighbor, clonedNeighbor);

            if (!visitedOriginal.Contains(origNeighbor))
            {
                VerifyDeepCopy(origNeighbor, clonedNeighbor, visitedOriginal, visitedCloned);
            }
        }
    }
}
