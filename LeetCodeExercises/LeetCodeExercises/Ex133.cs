namespace LeetCodeExercises;

// Definition for a Node.
public class Node
{
    public int val;
    public IList<Node> neighbors;

    public Node()
    {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val)
    {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors)
    {
        val = _val;
        neighbors = _neighbors;
    }
}

public class Ex133
{
    public Node CloneGraph(Node node)
    {
        if (node == null)
        {
            return null;
        }

        var visited = new Dictionary<Node, Node>();
        return DFS(node, visited);
    }

    private Node DFS(Node node, Dictionary<Node, Node> visited)
    {
        if (visited.TryGetValue(node, out var item))
        {
            return item;
        }

        var clone = new Node(node.val);
        visited[node] = clone;
        foreach (var neighbor in node.neighbors)
        {
            clone.neighbors.Add(DFS(neighbor, visited));
        }

        return clone;
    }
}