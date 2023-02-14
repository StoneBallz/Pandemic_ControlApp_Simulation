using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warehouse : Node
{
    int warehouse_id;
    string warehouse_na;
    public Warehouse(int id, int n, string name) : base(id, n, 3,name){
        warehouse_id=id;
        warehouse_na=name;
    }
    
}
