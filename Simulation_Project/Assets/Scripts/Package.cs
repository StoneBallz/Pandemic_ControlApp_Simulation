using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour{
    //bool next = false;
    bool split = false;
    //bool begin=false;
    bool end=false;
    /*types: 0 = next/split
      types: 1 = node send
      types: 2 = event action + required inputs
      types: 3 = compact manager -> wave send*/ 
    public Patient pnode=null;
    public int pid;
    public int[] pat_change=new int[3];
    public Hospital hnode;
    public Warehouse wnode;
    public int wid;
    public int[] war_change=new int[1];
    public int[] node_id=new int[2];
    
    public bool is_split(){
      return split;
    }
    public bool is_end(){
      return end;
    }

    /*public bool is_next(){
      return next;
    }*/
}
