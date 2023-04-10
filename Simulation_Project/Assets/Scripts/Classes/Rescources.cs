using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources
{
    int n=3;
    class re{
        public string key="";
        public int val=0, max=250;
        public re(string k, int v=25){
            key=k;
            val=v;
        }
     }
    re[] res;
    public static string[] keys=new string[]{"water", "medicine", "oxygen"};
    public Resources(){
        res=new re[n];
        for(int i=0;i<n;i++){
            res[i]=new re(keys[i]);
        }
     }

    public int[] get(){
        return new int[]{res[0].val,res[1].val,res[2].val};
    }

    public int get(string k){
        for(int i=0;i<n;i++){
            if(res[i].key==k){
                return res[i].val;
            }
        }
        return -1;
    }

    bool overflow(int v, string k){
        for(int i=0;i<n;i++){
            if(res[i].key==k){
                if(v+res[i].val>res[i].max){
                    return true;
                }
            }
        } 
        return false;
    }

    bool underflow(int v){
        if(v<0){
            return true;
        }
        return false;
    }

    public void set(int[] v){
        for(int i=0;i<n;i++){
            res[i].val=v[i];
        } 
    }

    public void set(string k, int v){
        for(int i=0;i<n;i++){
            if(res[i].key==k){
                res[i].val=v;
            }
        } 
    }
    public void increment(string k, int v){
        for(int i=0;i<n;i++){
            if(res[i].key==k){
                if(!overflow(v,k)){
                    res[i].val+=v;
                }
                else{
                    res[i].val=res[i].max;
                }
            }

        } 
    }
    public void increment(string k){
        for(int i=0;i<n;i++){
            if(res[i].key==k){
                res[i].val++;
            }
        } 
    }

    public void decrement(string k, int v){
        for(int i=0;i<n;i++){
            if(res[i].key==k){
                if(!underflow(res[i].val-v)){
                    res[i].val-=v;
                }
                else{
                    res[i].val=0;
                }
            }
        } 
    }
    public void decrement(string k){
        for(int i=0;i<n;i++){
            if(res[i].key==k){
                res[i].val--;
            }
        } 
    }

}
