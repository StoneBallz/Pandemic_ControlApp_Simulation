using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityGraph : MonoBehaviour
{
    public int n=10;
    Node[] arr= new Node[10];
    void Start()
    {
        for(int i=0;i<10;i++){
            arr[i]=new Node(i+1, n);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
