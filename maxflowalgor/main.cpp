#include "maxflow.h"


int main()
{

   int flow;
   
   srand(time(NULL));
    int graph[V][V];
	
	/*int graph[V][V] = { {0, 16, 13, 0, 0, 0},
                     {0, 0, 10, 12, 0, 0},
                     {0, 4, 0, 0, 14, 0},
                     {0, 0, 9, 0, 0, 20},
                     {0, 0, 0, 7, 0, 4},
                     {0, 0, 0, 0, 0, 0}
                   };*/
 
	
    for(int i=0; i < V; i++)
    {
        for(int j=0; j < V; j++)
        {
			
            graph[i][j]=rand()%20+1;
            
        }
    }
      
      
     for(int i=0; i < V; i++)
     {
       for(int j=0; j < V; j++)
       {
         cout <<  graph[i][j] << " ";
                          
       }
       cout << endl;
    }
                                                 
    clock_t start = clock();
	flow=maxFlow(graph, 0, 5);
	float duration = (clock() - start);
	duration = (duration/1000);
	
    cout << "It takes " << duration << "seconds to find the max flow" << endl;
    cout << "The maximum possible flow is " << flow << endl;
    
    /*cout << "The min cut is: " << endl;	
    start = clock();
    //minCut(graph, 0, 5);
    duration = (clock() - start);
    duration = (duration/1000);

    cout << "It takes " << duration << " seconds to find the min cut" << endl;*/
 
    return 0;
}
