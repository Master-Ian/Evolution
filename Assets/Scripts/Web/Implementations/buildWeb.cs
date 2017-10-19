using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildWeb : MonoBehaviour {

    private static int NUMNODES = 31;
    private Web web;

	// Initialize on startup
	void Start () {
        // Create an empty web
        web = new Web(NUMNODES);

        // Create a list of Nodes
        web.setNodes(generateNodes());

        // Create an edges graph linking the nodes
        web.setEdges(generateEdges());
	}

    public Web getWeb()
    {
        return web;
    }
    // Generates an empty edges graph with a given number of nodes
    private int[,] makeBaseEdgeGraph(int numNodes)
    {
        int[,] edges = new int[numNodes, numNodes];
        // Assume no connection
        for (int row = 0; row < numNodes; row++)
        {
            for (int col = 0; col < numNodes; col++)
            {
                edges[row, col] = 0;
            }
        }
        return edges;
    }

    private Node[] generateNodes()
    {
        // Init return value
        Node[] nodes = new Node[NUMNODES];

        //==========CENTRAL NODE==========\\
        nodes[0] = new Node("Chordata");

        //===========CORE TREES===========\\

        // Carnivores
        nodes[1] = new Node("Single Jaw Structure");
        nodes[2] = new Node("Chew Food");
        nodes[3] = new Node("Short & Fast Digestive Tract");

        nodes[4] = new Node("Double Jaw Structure");
        nodes[5] = new Node("Swallow Whole");
        nodes[6] = new Node("Teeth with Venom");
        nodes[7] = new Node("Intense Stomach Acids");

        nodes[8] = new Node("Large Stomachs with Specialized Acids");
        nodes[9] = new Node("Foreign Virus Immunity");
        nodes[10] = new Node("Eats Tiny Animals");
        nodes[11] = new Node("Eats Small Animals");
        nodes[12] = new Node("Eats Medium Animals");
        nodes[13] = new Node("Eats Large Animals");
        nodes[14] = new Node("Eats humongous Animals");

        // Herbivores
        nodes[15] = new Node("Chew Food");
        nodes[16] = new Node("Specialized Digestive Tract");
        nodes[17] = new Node("Eats Berries");
        nodes[18] = new Node("Eats Nuts");
        nodes[19] = new Node("Eats Grass");
        nodes[20] = new Node("Eats Leaves");


        //==========AVIARY TREES==========\\
        nodes[21] = new Node("Hard Eggs");
        nodes[22] = new Node("Beak");
        nodes[23] = new Node("Feathers");
        nodes[24] = new Node("Hollow Bones");
        nodes[25] = new Node("Glide Feathers");
        nodes[26] = new Node("Webbing");
        nodes[27] = new Node("Flapping Ability");  // Feathers
        nodes[28] = new Node("Flapping Ability");  // Webbing
        nodes[29] = new Node("Flight Feathers");
        nodes[30] = new Node("Alula");

        return nodes;
    }

    private int[,] generateEdges()
    {
        // Create an empty edge list
        int[,] edges = makeBaseEdgeGraph(NUMNODES);

        //===========CORE TREES===========\\

        // Carnivores
        edges[0, 1] = 1;
        edges[1, 2] = 1;
        edges[2, 3] = 1;

        edges[0, 4] = 1;
        edges[4, 5] = 1;
        edges[5, 6] = 1;
        edges[5, 7] = 1;
        
        edges[3, 8] = 1;
        edges[6, 8] = 1;
        edges[7, 8] = 1;
        edges[8, 9] = 1;
        edges[9, 10] = 1;
        edges[10, 11] = 1;
        edges[11, 12] = 1;
        edges[12, 13] = 1;
        edges[13, 14] = 1;

        // Herbivores
        edges[0,15] = 1;
        edges[15,16] = 1;
        edges[16,17] = 1;
        edges[16,18] = 1;
        edges[16,19] = 1;
        edges[19,20] = 1;

        //==========AVIARY TREES==========\\

        edges[0,21] = 1;
        edges[21,22] = 1;
        edges[22,23] = 1;
        edges[23,24] = 1;
        edges[24,25] = 1;
        edges[24,26] = 1;
        edges[26,28] = 1;
        edges[25,27] = 1;
        edges[27,29] = 1;
        edges[29,30] = 1;

        return edges;
    }
}
