using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour{
    bool next = false;
    bool split = false;
    /*types: 0 = next/split
      types: 1 = node send
      types: 2 = event action + required inputs
      types: 3 = compact manager -> wave send*/ 
    int action = 0; 
    int[] node_id = null;
    
}
