using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pos : MonoBehaviour
{
    public GameObject target;
    public Vector3 newpos;
    public void change(){
        target.transform.position=newpos;
    }
}
