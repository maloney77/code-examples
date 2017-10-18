#include <iostream>
#include <climits>
#include <cstdlib>
#include <cstring>
#include <queue>
using namespace std;

#ifndef MAXFLOW_H
#define MAXFLOW_H

const int V=100;


bool bfs(int rGraph[V][V], int s, int t, int parent[]);
int maxFlow(int graph[V][V], int s, int t);
void minCut(int graph[V][V], int s, int t);
void dfs(int rGraph[V][V], int s, bool visited[]);

#endif
