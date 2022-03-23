using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float distance = 20;
    public float speed = 0.5f;
    public float interval = 2;
    public GameObject CubePrefab;
    float lastTime;
    
    void Update()
    {
        if (Time.time > lastTime + interval)
        {
            lastTime = Time.time;
            GameObject currentCube = Instantiate(CubePrefab, transform.position, Quaternion.identity);
            currentCube.GetComponent<Cube>().SetParametrs(speed, distance);
        }
    }
    public void UpdateData(float speed,float interval, float distance)
    {
        this.speed = speed;
        this.interval = interval;
        this.distance = distance;
    }
}
