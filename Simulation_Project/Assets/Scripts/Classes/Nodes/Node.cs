using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node 
{
    public int[] node_id;
    public Node[] con;
    int n=gen_vars.n_nodes;
    string n_name;
    public int top=0;
    bool full=false;
    public Node(int id, int type, string name){
        node_id=new int[]{id,type};
        con=new Node[n+1];
        n_name=name;
    }

    public void Create_Connection(Node target){
        bool check=false;
        if(!full && !target.full){
            for(int i=0;i<top;i++){
                if(con[i].node_id==target.node_id){
                    check=true;
                    break;
                }
            }
            if(!check){
                con[top]=target;
                top++;
                target.con[target.top]=this;
                target.top++;
                this.Check_Full();
                target.Check_Full();
                return;
            }
        }
        Debug.Log("Connection Denied: "+n_name+"->"+target.n_name);
    }

    public void Check_Full(){
        if(top<n){
            full=false;
        }
        else{
            full=true;
        }
    }

    public string Get_N(){
        string full="";
        full+="ID=["+node_id[0]+","+node_id[1]+"], Name="+n_name;
        return full;
    }
    public string Get_N_Name(){
        string full="";
        full+="Name="+n_name;
        return full;
    }

    public void Print(){
        Debug.Log(this.Get_N());
    }

    public void Print_Connections(){
        Debug.Log(this.Get_N_Name()+" Connected to:");
        for(int i=0;i<top;i++){
            con[i].Print();
        }
        Debug.Log("All Connections Done");
    }
}
