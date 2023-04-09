using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package{
  public Patient pnode;
  public Warehouse wnode;
  public House henode;
  public Hospital hsnode;
  //
  public int pid=-1;
  public int[] pat_change=new int[3];
  public int wid=-1;
  public int[] war_change=new int[1];
  public int hou_id=-1;
  public int[] hou_change=new int[1];
  public int hos_id=-1;
  public int[] hos_change=new int[1];
  //
  public bool split = false;
  public bool begin=false;
  public bool end=false;
  public bool pat_del=false;
  public bool pat_data_out=false;
  public bool war_del=false;
  public bool war_data_out=false;
  public bool hou_del=false;
  public bool hou_data_out=false;
  public bool hos_del=false;
  public bool hos_data_out=false;
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
    //null_out();
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
    //null_out();
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
    //null_out();
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
    //null_out();
  }
  public void switch_war_del(){
    war_del=!war_del;
    split = false;
    begin=false;
    end=false;
    pat_del=false;
    pat_data_out=false;
    //war_del=false;
    war_data_out=false;
    hou_del=false;
    hou_data_out=false;
    hos_del=false;
    hos_data_out=false;
    null_out();
  }
  public void switch_hou_del(){
    hou_del=!hou_del;
    split = false;
    begin=false;
    end=false;
    pat_del=false;
    pat_data_out=false;
    war_del=false;
    war_data_out=false;
    //hou_del=false;
    hou_data_out=false;
    hos_del=false;
    hos_data_out=false;
    null_out();
  }
  public void switch_hos_del(){
    hos_del=!hos_del;
    split = false;
    begin=false;
    end=false;
    pat_del=false;
    pat_data_out=false;
    war_del=false;
    war_data_out=false;
    hou_del=false;
    hou_data_out=false;
    //hos_del=false;
    hos_data_out=false;
    null_out();
  }
  public void switch_pat_del(){
    pat_del=!pat_del;
    split = false;
    begin=false;
    end=false;
    //pat_del=false;
    pat_data_out=false;
    war_del=false;
    war_data_out=false;
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
    pat_change=new int[3];
    wid=-1;
    war_change=new int[1];
    hou_id=-1;
    hou_change=new int[1];
    hos_id=-1;
    hos_change=new int[1];
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
