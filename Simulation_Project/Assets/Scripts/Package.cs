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
    public Patient pnode;
    public int pid;
    public int[] pat_change;
    public Hospital hnode;
    public Warehouse wnode;
    public int[] wid;
    public int[] war_change;
    
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
