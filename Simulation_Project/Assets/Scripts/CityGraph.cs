using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityGraph : MonoBehaviour
{
    public static int n=gen_vars.n_nodes;
    public Package[] arr=new Package[4+n];
    public Package[] pat_arr=new Package[gen_vars.num_of_people+2];
    Package temp=new Package();

    void Full_treatment(){
        for(int i=1;i<4+n;i++){
            if(arr[i].hos_del){
                arr[i].hsnode.Treatment();
            }
        }
    }

    void Patient_hou_to_hos(int pid, int[] hos){
        int[] home_tar=pat_arr[pid].pnode.home;
        int flag=0;
        for(int i=1;i<4+n;i++){
            if(arr[i].hou_del&&arr[i].henode.node_id==home_tar){
                for(int j=0;j<arr[i].henode.top;j++){
                    if(arr[i].henode.con[j].node_id==hos){
                        arr[i].henode.Route(pid);
                        flag=1;
                    }
                }
            }
        }
        for(int i=1;i<4+n;i++){
            if(arr[i].hos_del&&arr[i].hsnode.node_id==hos&&flag==1){
                arr[i].hsnode.Admit(pat_arr[pid].pnode);
            }
        }
    }

    void Patient_hos_to_hou(int pid, int[] hos){
        int[] home_tar=pat_arr[pid].pnode.home;
        int flag=0;
        for(int i=1;i<4+n;i++){
            if(arr[i].hou_del&&arr[i].henode.node_id==home_tar){
                for(int j=0;j<arr[i].henode.top;j++){
                    if(arr[i].henode.con[j].node_id==hos){
                        arr[i].henode.Return(pat_arr[pid].pnode);
                        flag=1;
                    }
                }
            }
        }
        for(int i=1;i<4+n;i++){
            if(arr[i].hos_del&&arr[i].hsnode.node_id==hos&&flag==1){
                arr[i].hsnode.Discharge(pid);
            }
        }
    }

    void Resource_war_to_hos(int[] wid, int[] hos, int[] v){
        int flag=0;
        for(int i=1;i<4+n;i++){
            if(!arr[i].split&&!arr[i].end){
                if(arr[i].hos_del&&arr[i].hsnode.node_id==hos){
                    for(int j=0;j<arr[i].hsnode.top;j++){
                        if(arr[i].hsnode.con[j].node_id==wid){
                            flag=1;
                            arr[i].hsnode.Topup(v);
                        }
                    }
                }
                if(arr[i].war_del&&arr[i].wnode.node_id==wid&&flag==1){
                    arr[i].wnode.Dispatch(v);
                }
            }
        }
    }
    

    void Start()
    {
        int i=0;
        arr[0] = new Package();
        arr[0].begin=true;
        i++;

        arr[1]=new Package();
        arr[1].hou_del=true;
        arr[1].henode=new House(1, "Lol");
        i++;

        arr[2]=new Package();
        arr[2].hou_del=true;
        arr[2].henode=new House(2, "Pol");
        i++;

        arr[3] = new Package();
        arr[3].split=true;
        i++;

        arr[4]=new Package();
        arr[4].hos_del=true;
        arr[4].hsnode=new Hospital(1,"Apollo");
        i++;

        arr[5]=new Package();
        arr[5].hos_del=true;
        arr[5].hsnode=new Hospital(2,"Kamakshi");
        i++;

        arr[6] = new Package();
        arr[6].split=true;
        i++;

        arr[7]=new Package();
        arr[7].war_del=true;
        arr[7].wnode=new Warehouse(1,"Trader Joes");
        i++;

        arr[8] = new Package();
        arr[8].end=true;
        i++;

        arr[1].henode.Create_Connection(arr[4].hsnode);
        arr[2].henode.Create_Connection(arr[4].hsnode);
        arr[2].henode.Create_Connection(arr[5].hsnode);
        arr[4].hsnode.Create_Connection(arr[7].wnode);
        arr[5].hsnode.Create_Connection(arr[7].wnode);

        int j=0;
        pat_arr[0] = new Package();
        pat_arr[0].begin=true;
        j++;

        /*temp.switch_pat_del();
        temp.pnode=new Patient(1, "Gowtham", arr[1].henode.node_id);
        temp.pid=temp.pnode.p_id;*/
        pat_arr[1] = new Package();
        pat_arr[1].pat_del=true;
        pat_arr[1].pnode = new Patient(1, "Gowtham", arr[1].henode.node_id);
        pat_arr[1].pid=pat_arr[1].pnode.p_id;
        j++;

        pat_arr[2] = new Package();
        pat_arr[2].pat_del=true;
        pat_arr[2].pnode = new Patient(2, "Austin", arr[1].henode.node_id);
        pat_arr[2].pid=pat_arr[2].pnode.p_id;
        j++;

        pat_arr[3] = new Package();
        pat_arr[3].pat_del=true;
        pat_arr[3].pnode = new Patient(3, "Pavan", arr[1].henode.node_id);
        pat_arr[3].pid=pat_arr[3].pnode.p_id;
        j++;

        pat_arr[4] = new Package();
        pat_arr[4].pat_del=true;
        pat_arr[4].pnode = new Patient(4, "Mukund", arr[2].henode.node_id);
        pat_arr[4].pnode.infected=true;
        pat_arr[4].pid=pat_arr[4].pnode.p_id;
        j++;

        pat_arr[5] = new Package();
        pat_arr[5].pat_del=true;
        pat_arr[5].pnode = new Patient(5, "Ajay", arr[2].henode.node_id);
        pat_arr[5].pid=pat_arr[5].pnode.p_id;
        j++;

        pat_arr[6] = new Package();
        pat_arr[6].end=true;
        j++;
        //arr[1].henode.Print_Connections();
    }

    public void restock_wh(int id){
        var ind= new int[]{id,3};
        for(int i=0;i<4+n;i++){
            if(arr[i].war_del){
                if(arr[i].wnode.warehouse_id==id){
                    arr[i].wnode.Restock();
                }
            }
        }
    }

    // Pre Mukund Merge:
    
}
