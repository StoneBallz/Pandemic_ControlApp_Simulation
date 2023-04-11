using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionMaker : MonoBehaviour
{
    int k=0, max=gen_vars.num_of_people*2+gen_vars.num_of_hos*2;
    Package[] out_msg=new Package[gen_vars.num_of_people*2+gen_vars.num_of_hos*2];
    
    void Start()
    {
        out_msg[0] = new Package();
        out_msg[0].switch_begin();
    }

    void rand_descs(){
        
    }

    public Package[] make_decision(Package[] arr, int n){
        k=1;
        return form_final_decision();
    }

    /*void hard_descs(Package[] arr, int n){
        for(int i=1;i<n;i++){
            if(arr[i].hou_del){
                House cur_hou=arr[i].henode;
                for(int j=0;j<cur_hou.top;j++){
                    if(cur_hou.current_patients[j].infected){
                        out_msg[k]= new Package();
                        out_msg[k].decision_out=true;
                        out_msg[k].decision_pack[0]=1;
                        out_msg[k].decision_pack[1]=cur_hou.current_patients[j].p_id;
                        out_msg[k].decision_pack[2]=;
                    }
                }
            }
        }
    }*/

    Package[] form_final_decision(){
        return out_msg;
    }

    void Update()
    {
        
    }
}
