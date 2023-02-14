using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : Node
{
    int house_id;
    string house_na;
    public House(int id, int n, string name) : base(id, n, 1,name){
        house_id=id;
        house_na=name;
    }

}
