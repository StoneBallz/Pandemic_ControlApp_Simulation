using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : MonoBehaviour
{
    public int[] pos;
    public int[] home;
    public int p_id, age, time_to_live;
    string p_name;
    public bool infected,alive,healed;
    
    public Patient(int pin, string nam, int[] init, int ag=18){
        pos=init;
        home=init;
        p_id=pin;
        age=ag;
        p_name=nam;
        infected=false;
        alive=true;
        healed=false;
    }

    public void infect(){
        //If person has ald been healed once, we treat them as un-infectable for now 
        if(healed==false && alive==true){
            infected=true;
        }
    }

    public void fully_recover(){
        if(infected==true && alive==true){
            infected=false;
            healed=true;
        }
    }

    public void die(){
        if(infected==true && healed==false){
            alive=false;
        }
    }

    public void travel(int[] new_pos){
        pos=new_pos;
    }
}
