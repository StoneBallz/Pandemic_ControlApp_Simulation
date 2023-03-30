using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class pa{
    int[] pos;
    int[] hid;
    bool inf;
    bool die;
    bool heal;
    int pid;
    int dawinf;
    int dawotr;
    int daoftr;

    public void set(int[] pi,int[] hi,int pd,bool i,bool di, bool he, int dwi, int dwot, int dft){
        pos=pi;
        hid=hi;
        pid=pd;
        inf=i;
        die=di;
        heal=he;
        dawinf=dwi;
        dawotr=dwot;
        daoftr=dft;
    }

};

class wa{
    int[] wid;
    int dasire;

    public void set(int[] wi, int das){
        wid=wi;
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
    public void recieve_msg(Package[] m){
        in_msg=m;
        if(wave==0){
            init_arrs();
        }
        update_parr();
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

    void update_parr(){
        int i=0;
        Package it=in_msg[i];
        while(!it.is_split()){
            i++;
            it=in_msg[i];

        }
    }
    
}
