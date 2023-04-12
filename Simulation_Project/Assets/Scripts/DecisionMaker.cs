using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DecisionMaker : MonoBehaviour
{
    //int k=0
    int max=gen_vars.num_of_people*2+gen_vars.num_of_hos*2;
    Package[] out_msg=new Package[gen_vars.num_of_people*2+gen_vars.num_of_hos*2+1];
    
    void Start()
    {
        out_msg[0] = new Package();
        out_msg[0].switch_begin();
    }

    public Package[] make_decision(Package[] arr, int n){
        //k=1;
        return form_final_decision();
    }
    
    Package[] pure_rand_descs(){
        int nd=gen_vars.num_of_people*2+gen_vars.num_of_hos*2+1;
        System.Random rnd = new System.Random();
        for(int i=1;i<nd;i+=2){
            int func=rnd.Next(0,3);
            if(func>0&&func<4){
                out_msg[i]=new Package();
                out_msg[i].decision_out=true;
                out_msg[i].decision_pack[0]=func;
                if(func==1){
                    out_msg[i].decision_pack[1]=rnd.Next(1,gen_vars.num_of_people);
                    out_msg[i].decision_pack[2]=rnd.Next(1,gen_vars.num_of_hos);
                    out_msg[i].decision_pack[3]=2;
                }
                else if(func==2){
                    out_msg[i].decision_pack[1]=rnd.Next(1,gen_vars.num_of_people);
                    out_msg[i].decision_pack[2]=rnd.Next(1,gen_vars.num_of_hos);
                    out_msg[i].decision_pack[3]=2;
                }
                else if(func==3){
                    out_msg[i].decision_pack[1]=rnd.Next(1,gen_vars.num_of_wares);
                    out_msg[i].decision_pack[2]=3;
                    out_msg[i].decision_pack[3]=rnd.Next(1,gen_vars.num_of_hos);
                    out_msg[i].decision_pack[4]=2;
                    out_msg[i].decision_pack[5]=rnd.Next(0,50);
                    out_msg[i].decision_pack[6]=rnd.Next(0,50);
                    out_msg[i].decision_pack[7]=rnd.Next(0,50);
                }
                out_msg[i+1]=new Package();
                out_msg[i+1].switch_split();
            }
        }
        return out_msg;
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
