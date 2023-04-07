using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hospital : Node
{
    int hospital_id;
    string hospital_na;
    int beds,num_pa=gen_vars.num_of_people;
    Patient[] current_patients=new Patient[gen_vars.num_of_people];
    public Hospital(int id, string name, int be=5) : base(id, 2,name){
        hospital_id=id;
        hospital_na=name;
        beds=be;
    }

    //Patient Section
    void p_push(Patient p){
        for(int i=0;i<num_pa;i++){
            if(current_patients[i]==null){
                current_patients[i]=p;
                return;
            }
        }
    }

    public void Admit(Patient p){
        p_push(p);
        p.travel(this.node_id);
    }

    public void Dispatch(int patid){
        for(int i=0;i<num_pa;i++){
            if(current_patients[i].p_id==patid){
                current_patients[i]=null;
                return;
            }
        }
    }
    //Patient Section

    //Resources Section
    Resources res=new Resources();
    string[] ks=Resources.keys;
    int rn=3;
    public void Topup(int[] vals){
        for(int i=0;i<rn;i++){
            res.increment(ks[i],vals[i]);
        }
        return;
    }

    public void Treatment(int[] vals){
        for(int i=0;i<rn;i++){
            res.decrement(ks[i],vals[i]);
        }
        return;
    }
    //Resources Section
    
}
