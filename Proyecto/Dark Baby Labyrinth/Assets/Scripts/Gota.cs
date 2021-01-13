using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gota : SoundEmitter
{
    public float timetolive;
    // Start is called before the first frame update
    void Start()
    {
        EmitSound(timetolive);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
