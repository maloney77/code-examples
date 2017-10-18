
#include "maxflow.h"
bool bfs(int rGraph[V][V], int s, int t, int parent[])
{
    // Create a visited array and mark all vertices as not visited
    bool visited[V];
	
    memset(visited, 0, sizeof(visited));
 //Invariant: Queue is non-empty, inflow=outflow at every vertex
//Assert(|Q|>0)
    // Create a queue, enqueue source vertex and mark source vertex
    // as visited
    queue <int> q;
    q.push(s);
    visited[s] = true;
    parent[s] = -1;
 
  /* Invariant: Queue is empty or a path augmented or partial
augment path exists, inflow=outflow at every vertex,
Assert(|Q|<|V|)
until Q is empty*/
    while (!q.empty())
    {
        int u = q.front();
        q.pop();
 
        for (int v=0; v<V; v++)
        {
            if (visited[v]==false && rGraph[u][v] > 0)
            {
                q.push(v);
                parent[v] = u;
                visited[v] = true;
            }
        }
    }
 
    // If we reached sink in BFS starting from source, then return
    // true, else false
    return (visited[t] == true);
}
 

// Returns tne maximum flow from s to t in the given graph
int maxFlow(int graph[V][V], int s, int t)
{
    int u, v;
 
    // Create a residual graph and fill the residual graph with
    // given capacities in the original graph as residual capacities
    // in residual graph
    int rGraph[V][V]; // Residual graph where rGraph[i][j] indicates 
                     // residual capacity of edge from i to j (if there
                     // is an edge. If rGraph[i][j] is 0, then there is not)  
    for (u = 0; u < V; u++)
        for (v = 0; v < V; v++)
             rGraph[u][v] = graph[u][v];
 
    int parent[V];  // This array is filled by BFS and to store path
 
    int max_flow = 0;  // There is no flow initially
 
    // Augment the flow while tere is path from source to sink
    while (bfs(rGraph, s, t, parent))
    {
        
        int path_flow = INT_MAX;
        for (v=t; v!=s; v=parent[v])
        {
            u = parent[v];
            path_flow = min(path_flow, rGraph[u][v]);
        }
 
        // update residual capacities of the edges and reverse edges
        // along the path
        for (v=t; v != s; v=parent[v])
        {
            u = parent[v];
            rGraph[u][v] -= path_flow;
            rGraph[v][u] += path_flow;
        }
 
        // Add path flow to overall flow
        max_flow += path_flow;
    }
 
    // Return the overall flow
    return max_flow;
}

void minCut(int graph[V][V], int s, int t)
{
    int u, v;
    int rGraph[V][V];
    for (u = 0; u < V; u++)
    {
        for (v = 0; v < V; v++)
             rGraph[u][v] = graph[u][v];
    }
    int parent[V];
    while (bfs(rGraph, s, t, parent))
    {
        int path_flow = 65536;
        for (v = t; v != s; v = parent[v])
        {
            u = parent[v];
            path_flow = min(path_flow, rGraph[u][v]);
        }
        for (v = t; v != s; v = parent[v])
        {
            u = parent[v];
            rGraph[u][v] -= path_flow;
            rGraph[v][u] += path_flow;
        }
    }
    bool visited[V];
    memset(visited, 0, sizeof(visited));
    dfs(rGraph, s, visited);
    for (int i = 0; i < V; i++)
    {
        for (int j = 0; j < V; j++)
        {
            if (visited[i] && !visited[j] && graph[i][j])
                cout << i << " - " << j << endl;
        }
    }
    return;
}
void dfs(int rGraph[V][V], int s, bool visited[])
{
    visited[s] = true;
    for (int i = 0; i < V; i++)
    {
        if (rGraph[s][i] && !visited[i])
           dfs(rGraph, i, visited);
    }
}