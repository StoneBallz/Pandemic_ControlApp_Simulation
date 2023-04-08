using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityGraph : MonoBehaviour
{
    public static int n=gen_vars.n_nodes;
    public Package[] arr=new Package[4+n];
    public Package[] pat_arr=new Package[gen_vars.num_of_people+2];
    Package temp=new Package();

    void Start()
    {
        int i=0;
        arr[0] = new Package();
        arr[0].begin=true;
        i++;

        arr[1]=new Package();
        arr[1].henode=new House(1, "Lol");
        i++;

        arr[2]=new Package();
        arr[2].henode=new House(2, "Pol");
        i++;

        arr[3] = new Package();
        arr[3].split=true;
        i++;

        arr[4]=new Package();
        arr[4].hsnode=new Hospital(1,"Apollo");
        i++;

        arr[5]=new Package();
        arr[5].hsnode=new Hospital(2,"Kamakshi");
        i++;

        arr[6] = new Package();
        arr[6].split=true;
        i++;

        arr[7]=new Package();
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
        pat_arr[1].pnode = new Patient(1, "Gowtham", new int[]{1,1});
        pat_arr[1].pid=pat_arr[1].pnode.p_id;
        j++;

        pat_arr[2].pnode = new Patient(2, "Austin", arr[1].henode.node_id);
        pat_arr[2].pid=pat_arr[2].pnode.p_id;
        j++;

        pat_arr[3].pnode = new Patient(3, "Pavan", arr[1].henode.node_id);
        pat_arr[3].pid=pat_arr[3].pnode.p_id;
        j++;

        pat_arr[4].pnode = new Patient(4, "Mukund", arr[2].henode.node_id);
        pat_arr[4].pid=pat_arr[4].pnode.p_id;
        j++;

        pat_arr[5].pnode = new Patient(5, "Ajay", arr[2].henode.node_id);
        pat_arr[5].pid=pat_arr[5].pnode.p_id;
        j++;

        pat_arr[6] = new Package();
        pat_arr[6].end=true;
        j++;

        arr[1].henode.Print_Connections();
    }

    // Pre Mukund Merge:
    
}
