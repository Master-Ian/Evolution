using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Web : MonoBehaviour
{
    private int numNodes;
    private Node[] nodes;  // an array containing all possible nodes
    private int[,] edges;  // a 2D array of integers, where the row index is the staring node and the column index is the destination node, and the value contained is 0 of there is no edge, or 1 if there is an edge

    // Constructor
    public Web(int _numNodes)
    {
        numNodes = _numNodes;
    }

    // Sets the nodes of the web
    public void setNodes(Node[] _nodes)
    {
        nodes = _nodes;
    }

    // Sets the directed edge of the web
    public void setEdges(int[,] _edges)
    {
        edges = _edges;
    }

    // Gets the nodes of the web
    public Node[] getNodes()
    {
        return nodes;
    }

    // Gets the edges of the web
    public int[,] getEdges()
    {
        return edges;
    }

    // Gets the node at a given index
    public Node getNode(int index)
    {
        return nodes[index];
    }

    // Gets all the child node indices of a given node index
    public List<int> getChildren(int index)
    {
        List<int> childList = new List<int>();

        for(int i = 0; i < numNodes; i++)
        {
            if(edges[index,i] == 1)
            {
                childList.Add(i);
            }
        }

        return childList;
    }

    // Debug function to print out the web in the console
    public void printWeb()
    {
        string nodeNames = "";
        for (int i = 0; i < numNodes; i++)
        {
            nodeNames += nodes[i].getName() + ", ";
        }
        Debug.Log(nodeNames + "\n");

        string rowString;
        for (int i = 0; i < numNodes; i++)
        {
            rowString = "";
            for (int j = 0; j < numNodes; j++)
            {
                rowString += (edges[i, j] + " ");
            }
            Debug.Log(rowString);
        }
    }
}