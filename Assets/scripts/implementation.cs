using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class implementation : MonoBehaviour
{
    public GameObject obj;
    public void imp(){
        if(obj.activeInHierarchy==true){
            obj.SetActive(false);
        }
        else{
            obj.SetActive(false);
        }
    }
}
