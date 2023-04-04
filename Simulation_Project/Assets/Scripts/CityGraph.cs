using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityGraph : MonoBehaviour
{
    public static int n=5;
    public Package[] arr=new Package[n];
    public CityGraph(){
        /*arr[0]=new House(1,n,"Subramani's");
        arr[1]=new House(2,n,"Balamurugan's");
        arr[2]=new Hospital(1,n,"Apollo");
        arr[3]=new Hospital(2,n,"Kamakshi");
        arr[4]=new Warehouse(1,n,"LolRetail");

        arr[0].Create_Connection(arr[2]);
        arr[0].Create_Connection(arr[3]);
        arr[1].Create_Connection(arr[3]);
        arr[2].Create_Connection(arr[4]);
        arr[3].Create_Connection(arr[4]);*/
    }

    public Package[] set_get_city_state(){
        
        return arr;
    }
}
