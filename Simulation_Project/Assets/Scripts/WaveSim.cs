using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class gen_vars{
    public static int days_to_heal=8;
    public static int days_with_inf_to_be=2;
    public static int days_to_die=5;
    public static int num_of_people=9;
}

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
    public bool checked_this_Wave=false;

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
    }

};

class wa{
    int[] wid;
    int dasire;

    public void set(int[] wi, int das){
        wid=wi;
        //days since last restock
        dasire=das;
    }
}

public class WaveSim : MonoBehaviour
{
    int wave=0;
    Package[] in_msg;
    Package[] out_msg;
    wa[] warr;
    pa[] parr;
    gen_vars ge;
    public void recieve_msg(Package[] m){
        in_msg=m;
        if(wave==0){
            init_arrs();
        }
        int spl=update_parr();
        update_warr(spl);
        wave++;
    }

    void init_arrs(){
        int i=1, splits=0;;
        pa temppa=new pa();
        wa tempwa=new wa();

        Package it=in_msg[i];
        while(!it.is_end()){
            while(!it.is_split()&&splits==0){
                temppa.set(it.pnode.pos,it.pnode.home,it.pnode.p_id,it.pnode.infected,it.pnode.alive,it.pnode.healed,0,0,0);
                i++;
            }
            while(!it.is_split()&&splits==1){
                tempwa.set(it.wnode.node_id, 0);
                i++;
            }
            splits++;
            i++;
        }
    }

    int update_parr(){
        int i=0;
        Package it=in_msg[i];
        while(!it.is_split()){
            i++;
            it=in_msg[i];
            for(int j=0;j<gen_vars.num_of_people;j++){
                parr[j].checked_this_Wave=false;
            }
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
                        pe.inf=false;
                    }
                    if(pe.inf==true && pe.heal==false && pe.hid==pe.pos){
                        pe.dawotr++;
                        if(pe.dawotr>=gen_vars.days_to_die){
                            pe.die=true;
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
        for(int j=0;j<gen_vars.num_of_people;j++){
            pa pe=parr[j];
            if(pe.checked_this_Wave==false && x.pos==pe.pos){
                pe.dawinf++;
                if(pe.dawinf>=gen_vars.days_with_inf_to_be){
                    
                }

            }
        }
    }

    void update_warr(int inn){
        int i=inn+1;
        Package it=in_msg[i];
        while(!it.is_end()){
            it=in_msg[i];
            i++;
        }
    }
    
}
