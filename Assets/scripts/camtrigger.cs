using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camtrigger : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject r1;
    public GameObject r2;
    public void camtri(){
        if(p1.activeInHierarchy==true){
            r1.SetActive(false);
            p1.SetActive(false);
            p2.SetActive(true);
            r2.SetActive(true);
        }
        else if(p2.activeInHierarchy==true){
            r2.SetActive(false);
            p2.SetActive(false);
            p1.SetActive(true);
            r1.SetActive(true);
        }
    }
}
