using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources
{
    int n=3;
    class re{
        public string key="";
        public int val=0, max=10;
        public re(string k, int v=0){
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

    int overflow(int v, string k){
        for(int i=0;i<n;i++){
            if(res[i].key==k){
                if(v>res[i].max){
                    return 1;
                }
            }
        } 
        return 0;
    }

    int underflow(int v){
        if(v<0){
            return 1;
        }
        return 0;
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
                res[i].val+=v;
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
                res[i].val-=v;
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
