using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : Node
{
    int house_id;
    string house_na;
    int num_pa=gen_vars.num_of_people;
    Patient[] current_patients;
    public House(int id, string name) : base(id, 1,name){
        house_id=id;
        house_na=name;
        current_patients=new Patient[num_pa];
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

    public void Return(Patient p){
        p_push(p);
        p.travel(this.node_id);
    }

    public void Route(int patid){
        for(int i=0;i<num_pa;i++){
            if(current_patients[i].p_id==patid){
                current_patients[i]=null;
                return;
            }
        }
    }
    //Patient Section

}
