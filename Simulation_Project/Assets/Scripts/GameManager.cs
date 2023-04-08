using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managed_vars{
    public int num_dead=0;
    public int num_healed=0;
}

class gen_vars{
    //Simulation Numbers
    public static int n_nodes=5;
    public static int num_of_people=5;
    public static int num_of_wares=1;
    public static int num_of_hou=2;
    public static int num_of_hos=2;

    // Simulation Factors
    public static int days_to_heal=8;
    public static int days_with_inf_to_be=2;
    public static int days_to_die=5;
    public static int days_bfor_re=5;

}

public class GameManager : MonoBehaviour
{
    public CityGraph city_graph;
    public WaveSim wave_Sim;
    public DecisionMaker decision_maker;
    //int running;
    Package[] f_quad_out;
    Package[] s_quad_out;
    Package[] t_quad_out;

    int first_qudrant(){
        f_quad_out = wave_Sim.recieve_msg(city_graph.pat_arr);
        return 1;
    }

    int second_quadrant(){
        int x=1+gen_vars.num_of_people+1+gen_vars.num_of_wares+1;
        for(int i=1;i<x;i++){
            if(f_quad_out[i].is_pat_data_out()){
                int ind=f_quad_out[i].pid;
                if(f_quad_out[i].pat_change[0]==1){
                    city_graph.pat_arr[ind].pnode.infect();
                }
                else if(f_quad_out[i].pat_change[1]==1){
                    city_graph.pat_arr[ind].pnode.die();
                }
                else if(f_quad_out[i].pat_change[2]==1){
                    city_graph.pat_arr[ind].pnode.fully_recover();
                }
            }
            if(f_quad_out[i].is_war_data_out()){
                int ind=f_quad_out[i].wid;
                if(f_quad_out[i].war_change[0]==1){
                    city_graph.arr[ind].wnode.Restock();
                }
            }
        }
        return 1;
    }

    int third_quadrant(){
        t_quad_out=decision_maker.make_decision(city_graph.arr);
        return 1;
    }

    int fourth_quadrant(){
        return 1;
    }

    int end_sim(){
        //running=-1;
        return -1;
    }

    void Start()
    {
        //running=1;
        first_qudrant();
        second_quadrant();
        third_quadrant();
        fourth_quadrant();
    }
    void Update()
    {
        
    }
}
