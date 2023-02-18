using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hospital : Node
{
    int hospital_id;
    string hospital_na;
    int beds;
    Patient[] current_patients;
    public Hospital(int id, int n, string name, int be, int cw, int mw, int co, 
    int mo, int cm, int mm) : base(id, n, 2,name){
        hospital_id=id;
        hospital_na=name;
        beds=be;
    }

    public void Topup(){
        return;
    }

    public void Treatment(){
        return;
    }
    
}
