using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionMaker : MonoBehaviour
{
    
    public Package[] make_decision(Package[] arr){
        
        return form_final_decision();
    }

    Package[] form_final_decision(){
        Package[] out_msg=new Package[1];
        return out_msg;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
