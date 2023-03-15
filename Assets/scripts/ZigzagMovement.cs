using System.Collections;
using UnityEngine;

public class ZigzagMovement : MonoBehaviour
{
    public float speed = 5.0f; // The speed of the zigzag movement
    public float amplitude = 5.0f; // The amplitude of the zigzag movement

    private Vector3 startingPos; // The starting position of the object
    private float time = 0.0f; // The time elapsed since the start of the zigzag movement

    void Start()
    {
        startingPos = transform.position;
    }

    void Update()
    {
        // Update the time
        time += Time.deltaTime * speed;

        // Calculate the new position based on the time and amplitude
        float x = transform.position.x + Mathf.Sin(time) * amplitude;
        float y = transform.position.y;
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
}
