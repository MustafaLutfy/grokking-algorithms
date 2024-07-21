using System.Security.Cryptography;
using HashMap;

class CityRoadNetwork
{
    private Dictionary<string, List<string>> adjList;

    public CityRoadNetwork()
    {
        adjList = new Dictionary<string, List<string>>();
    }

    public void AddLocation(string location)
    {
        if (!adjList.ContainsKey(location))
        {
            adjList[location] = new List<string>();
        }
    }

    public void AddRoad(string location1, string location2)
    {
        if (adjList.ContainsKey(location1) && adjList.ContainsKey(location2))
        {
            adjList[location1].Add(location2);
            adjList[location2].Add(location1);
        }
    }
    public List<string> FindShortestPath(string start, string end){
        if(!adjList.ContainsKey(start) || !adjList.ContainsKey(end)){
            return null;
        }

        Queue<string> queue = new Queue<string>();
        HashSet<string> visited = new HashSet<string>();
        Dictionary<string,string> prev = new Dictionary<string, string>();
        queue.Enqueue(start);
        visited.Add(start);

        while(queue.Count > 0){
            string current = queue.Dequeue();

            if(current == end){
                return PathConstruction(start, end, prev); //construction method call
            }

            foreach(string neighbor in adjList[current]){
                if(!visited.Contains(neighbor)){
                    queue.Enqueue(neighbor);
                    visited.Add(neighbor);
                    prev[neighbor] = current;
                }
            }
        }
        return ["test"];
    }

    public List<string> PathConstruction(string start,string end,Dictionary<string,string> prev){
        List<string> path = new List<string>();

        for(string i = end; i != null ; i = prev.ContainsKey(i) ? prev[i] : null){
            path.Add(i);
        }
        path.Reverse();
        return path;
    }
     public void PrintAllConnections()
    {
        foreach (var location in adjList)
        {
            string locationName = location.Key;
            List<string> connections = location.Value;
            Console.WriteLine($"{locationName} is connected to: {string.Join(", ", connections)}");
        }
    }
}