using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    
    public int dir;
    public float speed;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed*dir);
    }
}
