using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightchng : MonoBehaviour
{
    public Light a;
    public Light b;
    public void litchg(){
        if(a.enabled==true){
            a.enabled=false;
            b.enabled=true;
        }
        else{
            b.enabled=false;
            a.enabled=true;

        }
    }
}
