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
        temp.switch_begin();
        arr[0] = temp;
        i++;

        /*temp.switch_hou_del();
        temp.henode=new House(1,"Lol's House");
        temp.hou_id=temp.henode.node_id[0];*/
        arr[1]=new Package();
        arr[1].henode=new House(1, "Lol");
        i++;

        arr[2]=new Package();
        arr[2].henode=new House(2, "Pol");
        i++;

        arr[3] = new Package();
        arr[3].switch_split();
        i++;

        arr[4]=new Package();
        arr[4].hsnode=new Hospital(1,"Apollo");
        i++;

        arr[5]=new Package();
        arr[5].hsnode=new Hospital(2,"Kamakshi");
        i++;

        arr[6] = new Package();
        arr[6].switch_split();
        i++;

        arr[7]=new Package();
        arr[7].wnode=new Warehouse(1,"Trader Joes");
        i++;
        i++;

        arr[8] = new Package();
        arr[8].switch_end();
        i++;

        arr[1].henode.Create_Connection(arr[4].hsnode);
        arr[2].henode.Create_Connection(arr[4].hsnode);
        arr[2].henode.Create_Connection(arr[5].hsnode);
        arr[4].hsnode.Create_Connection(arr[7].wnode);
        arr[5].hsnode.Create_Connection(arr[7].wnode);

        int j=0;
        temp.switch_begin();
        pat_arr[0] = temp;
        j++;

        temp.switch_pat_del();
        temp.pnode=new Patient(1, "Gowtham", arr[1].henode.node_id);
        temp.pid=temp.pnode.p_id;
        pat_arr[1] = temp;
        j++;

        temp.pnode=new Patient(2, "Austin", arr[1].henode.node_id);
        temp.pid=temp.pnode.p_id;
        pat_arr[2] = temp;
        j++;

        temp.pnode=new Patient(3, "Pavan", arr[1].henode.node_id);
        temp.pid=temp.pnode.p_id;
        pat_arr[3] = temp;
        j++;

        temp.pnode=new Patient(4, "Mukund", arr[2].henode.node_id);
        temp.pid=temp.pnode.p_id;
        pat_arr[4] = temp;
        j++;

        temp.pnode=new Patient(5, "Ajay", arr[2].henode.node_id);
        temp.pid=temp.pnode.p_id;
        pat_arr[5] = temp;
        j++;

        temp.switch_end();
        arr[j] = temp;
        j++;

        arr[1].henode.Print_Connections();
    }

    // Pre Mukund Merge:
    
}
