using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    int node_id;
    public Node[] con;
    public Node(int id, int n){
        node_id=id;
        con=new Node[n];

    }

    void Update()
    {

    }
}
