using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hospital : Node
{
    int hospital_id;
    string hospital_na;
    public Hospital(int id, int n, string name) : base(id, n, 2,name){
        hospital_id=id;
        hospital_na=name;
    }
    
}
