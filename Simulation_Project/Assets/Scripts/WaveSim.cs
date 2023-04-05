using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
class pa{
    public int[] pos;
    public int[] hid;
    public bool inf;
    public bool die;
    public bool heal;
    public int pid;
    public int dawinf;
    public int dawotr;
    public int daoftr;
    public bool checked_this_wave=false;

    public int[] changes_out = new int[3];

    public void set(int[] pi,int[] hi,int pd,bool i,bool di, bool he, int dwi, int dwot, int dft){
        pos=pi;
        hid=hi;
        pid=pd;
        inf=i;
        die=di;
        heal=he;
        //days with infected person
        dawinf=dwi;
        //days without treatment
        dawotr=dwot;
        //days of treatment done
        daoftr=dft;
        //init changes [infect, die, heal]
        changes_out[0]=0;
        changes_out[1]=0;
        changes_out[2]=0;
    }

};

class wa{
    public int[] wid;
    public int dasire;
    public int[] changes_out;

    public void set(int[] wi, int das){
        wid=wi;
        //days since last restock
        dasire=das;
        //init changes [restock]
        changes_out=new int[0];
    }
}

public class WaveSim : MonoBehaviour
{
    Package temp=new Package();
    int wave=0;
    Package[] in_msg;
    wa[] warr=new wa[gen_vars.num_of_wares];
    pa[] parr=new pa[gen_vars.num_of_people];
    public Package[] recieve_msg(Package[] m){
        in_msg=m;
        if(wave==0){
            init_arrs();
        }
        int spl=update_parr();
        update_warr();
        wave++;
        return return_msg();
    }

    public Package[] return_msg(){
        int[] ch=new int[]{0,0,0};
        Package[] out_msg=new Package[1+gen_vars.num_of_people+1+gen_vars.num_of_wares+1];
        int j=0,k=0;
        temp.switch_begin();
        out_msg[j]=temp;
        j++;
        temp.switch_pat_data();
        for(int i=1;i<gen_vars.num_of_people;i++){
            temp.pid=parr[i].pid;
            temp.pat_change=parr[i].changes_out;
            out_msg[i]=temp;
            j++;
        }
        temp.switch_split();
        out_msg[j]=temp;
        temp.switch_war_data();
        j++;
        k=j;
        for(int i=0;i<gen_vars.num_of_wares;i++){
            temp.war_change=warr[i].changes_out;
            out_msg[i+j]=temp;
            k++;
        }
        temp.switch_end();
        out_msg[k]=temp;
        temp.switch_null();
        return out_msg;
    }

    void init_arrs(){
        int i=1, splits=0;;
        pa temppa=new pa();
        wa tempwa=new wa();
        int[] widin=new int[2];
        widin[1]=3;

        Package it=in_msg[i];
        while(!it.is_end()){
            while(!it.is_split()&&splits==0){
                temppa.set(it.pnode.pos,it.pnode.home,it.pnode.p_id,it.pnode.infected,it.pnode.alive,it.pnode.healed,0,0,0);
                parr[i-1]=temppa;
                i++;
            }
        }
        for(int j=0;j<gen_vars.num_of_wares;j++){
            widin[0]=j;
            tempwa.set(widin, 0);
            warr[j]=tempwa;
        }
    }

    int update_parr(){
        int i=0;
        int[] ch=new int[]{0,0,0};
        Package it=in_msg[i];
        for(int j=0;j<gen_vars.num_of_people;j++){
            parr[j].checked_this_wave=false;
            parr[j].changes_out=ch;
        }
        while(!it.is_end()){
            i++;
            it=in_msg[i];
            for(int j=0;j<gen_vars.num_of_people;j++){
                pa pe = parr[j];
                if(pe.pid==it.pnode.p_id){ 
                    pe.pos=it.pnode.pos;
                    pe.inf=it.pnode.infected;
                    if(pe.pos[1]==2){
                        pe.daoftr++;
                    }
                    if(pe.daoftr==gen_vars.days_to_heal){                        
                        pe.heal=true;
                        pe.changes_out[2]=1;
                    }
                    if(pe.inf==true && pe.heal==false && pe.hid==pe.pos){
                        pe.dawotr++;
                        if(pe.dawotr>=gen_vars.days_to_die){
                            pe.die=true;
                            pe.changes_out[1]=1;
                        }
                    }
                    if(pe.inf==true && pe.pos==pe.hid){
                        check_house_inf(pe);
                    }
                    break;
                }
            }
        }
        return i;
    }

    void check_house_inf(pa x){
        System.Random rnd = new System.Random();
        for(int j=0;j<gen_vars.num_of_people;j++){
            pa pe=parr[j];
            if(pe.checked_this_wave==false && return_pos_check(x,pe) && pe.inf==false && pe.heal==false){
                pe.dawinf++;
                if(pe.dawinf>=gen_vars.days_with_inf_to_be){
                    pe.inf=true;
                    pe.changes_out[0]=1;
                }
                else if(pe.dawinf>0&&pe.dawinf<gen_vars.days_with_inf_to_be){
                    if(rnd.Next(1,100)>=50){
                        pe.inf=true;
                        pe.changes_out[0]=1;
                    }
                }

            }
        }
    }

    bool return_pos_check(pa x, pa pe){
        for(int i=0;i<2;i++){
            if(x.pos[i]!=pe.pos[i]){
                return false;
            }
        }
        return true;
    }

    void update_warr(){
        int[] ch=new int[]{0};
        for(int j=0;j<gen_vars.num_of_wares;j++){
            warr[j].changes_out=ch;
        }
        for(int j=0;j<gen_vars.num_of_wares;j++){
            warr[j].dasire++;
            if(warr[j].dasire>=gen_vars.days_bfor_re){
                warr[j].dasire=0;
                warr[j].changes_out[0]=1;
            }
        }
    }
    
}
