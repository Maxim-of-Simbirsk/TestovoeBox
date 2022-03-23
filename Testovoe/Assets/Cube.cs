using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    
    Vector3 startPosition;

    float distance = 10;
    float speed = 1;
    void Start()
    {
        startPosition = transform.position;
    }

   
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
        if (Vector3.Distance(transform.position, startPosition) >= distance)
            Destroy(gameObject);
    }
   
    public void SetParametrs(float speed, float distance)
    {
        this.speed = speed;
        this.distance = distance;
    }
}
