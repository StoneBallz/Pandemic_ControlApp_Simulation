using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour{
  public Patient pnode=null;
  public Warehouse wnode=null;
  public House henode=null;
  public Hospital hsnode=null;
  //
  public int pid=-1;
  public int[] pat_change=null;
  public int wid=-1;
  public int[] war_change=null;
  public int hou_id=-1;
  public int[] hou_change=null;
  public int hos_id=-1;
  public int[] hos_change=null;
  //
  bool split = false;
  bool begin=false;
  bool end=false;
  bool pat_del=false;
  bool pat_data_out=false;
  bool war_del=false;
  bool war_data_out=false;
  bool hou_del=false;
  bool hou_data_out=false;
  bool hos_del=false;
  bool hos_data_out=false;
  //
  public void switch_null(){
    split = false;
    begin=false;
    end=false;
    pat_del=false;
    pat_data_out=false;
    war_del=false;
    war_data_out=false;
    hou_del=false;
    hou_data_out=false;
    hos_del=false;
    hos_data_out=false;
    null_out();
  }
  public void switch_split(){
    split=!split;
    //split = false;
    begin=false;
    end=false;
    pat_del=false;
    pat_data_out=false;
    war_del=false;
    war_data_out=false;
    hou_del=false;
    hou_data_out=false;
    hos_del=false;
    hos_data_out=false;
    null_out();
  }
  public void switch_begin(){
    begin=!begin;
    split = false;
    //begin=false;
    end=false;
    pat_del=false;
    pat_data_out=false;
    war_del=false;
    war_data_out=false;
    hou_del=false;
    hou_data_out=false;
    hos_del=false;
    hos_data_out=false;
    null_out();
  }
  public void switch_end(){
    end=!end;
    split = false;
    begin=false;
    //end=false;
    pat_del=false;
    pat_data_out=false;
    war_del=false;
    war_data_out=false;
    hou_del=false;
    hou_data_out=false;
    hos_del=false;
    hos_data_out=false;
    null_out();
  }
  public void switch_pat_data(){
    pat_data_out=!pat_data_out;
    split = false;
    begin=false;
    end=false;
    pat_del=false;
    //pat_data_out=false;
    war_del=false;
    war_data_out=false;
    hou_del=false;
    hou_data_out=false;
    hos_del=false;
    hos_data_out=false;
    null_out();
  }
  public void switch_war_data(){
    war_data_out=!war_data_out;
    split = false;
    begin=false;
    end=false;
    pat_del=false;
    pat_data_out=false;
    war_del=false;
    //war_data_out=false;
    hou_del=false;
    hou_data_out=false;
    hos_del=false;
    hos_data_out=false;
    null_out();
  }
  void null_out(){
    pnode=null;
    wnode=null;
    henode=null;
    hsnode=null;
    pid=-1;
    pat_change=null;
    wid=-1;
    war_change=null;
    hou_id=-1;
    hou_change=null;
    hos_id=-1;
    hos_change=null;
  }
  public bool is_begin(){
    return begin;
  }
  public bool is_split(){
    return split;
  }
  public bool is_end(){
    return end;
  }
  public bool is_pat_data_out(){
    return pat_data_out;
  }
  public bool is_war_data_out(){
    return war_data_out;
  }
}
