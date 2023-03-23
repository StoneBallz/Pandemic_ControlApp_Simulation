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

    //Resources Section
    Resources res=new Resources();
    string[] ks=Resources.keys;
    int rn=3;
    public int stock_up=50;
    public void Restock(){
        for(int i=0;i<rn;i++){
            res.increment(ks[i],50);
        }
        return;
    }

    public void Dispatch(int[] vals){
        for(int i=0;i<rn;i++){
            res.decrement(ks[i],vals[i]);
        }
        return;
    }
    //Resources Section
    
}
