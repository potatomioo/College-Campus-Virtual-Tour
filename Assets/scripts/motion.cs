using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartbreak : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 targetPosition;
    public float speed = 1.0f;
    private float startTime;
    public GameObject obj;

 
    void Start()
    {
        startTime = Time.time;
    }
 
    void Update()
    {
        float distance = Vector3.Distance(startPosition, targetPosition);
        float time = (Time.time - startTime) * speed / distance;
        obj.transform.position = Vector3.Lerp(startPosition, targetPosition, time);
    }
}

