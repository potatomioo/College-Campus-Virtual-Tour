using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickmove : MonoBehaviour
{
    public Vector3 targetPosition;
    public GameObject obj;

    public void MoveCamera()
    {
        StartCoroutine(MoveToTarget());
    }

    private IEnumerator MoveToTarget()
    {
        while (Vector3.Distance(obj.transform.position, targetPosition) > 0.1f)
        {
            obj.transform.position = Vector3.Lerp(obj.transform.position, targetPosition, Time.deltaTime);
            yield return null;
        }
    }
}
