using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TraficoSpawner : MonoBehaviour
{
    public float range;
    public float minT, maxT;
    public bool up;
    public Car car;

    private float time;

    void Start()
    {
        time = UnityEngine.Random.Range(minT, maxT);
    }

    
    void Update()
    {
        time -= Time.deltaTime;

        if(time <= 0)
        {
            SpawnCar();
            time = UnityEngine.Random.Range(minT, maxT);
        }


           
    }

    void SpawnCar()
    {
        Vector3 pos = transform.position;
        pos.x += UnityEngine.Random.Range(-range, range);
        Car c = Instantiate(car, pos, Quaternion.identity);
        c.dir = Convert.ToInt32(up) * 2 - 1;
        //c.transform.position.x += UnityEngine.Random.Range(-range, range);
    }
}
