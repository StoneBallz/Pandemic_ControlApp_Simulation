using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hospital : Node
{
    int hospital_id;
    string hospital_na;
<<<<<<< Updated upstream
    public Hospital(int id, int n, string name) : base(id, n, 2,name){
        hospital_id=id;
        hospital_na=name;
=======
    int beds,num_pa;
    Patient[] current_patients;
    public Hospital(int id, int n, string name, int be, int np) : base(id, n, 2,name){
        hospital_id=id;
        hospital_na=name;
        beds=be;
        current_patients=new Patient[np];
        num_pa=np;
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
>>>>>>> Stashed changes
    }
    //Resources Section
    
}
