using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SoundEmitter
{
    private Transform tr;
    public float moveSpeed;
    public float soundCD;
    private float soundTimer;

    public FMOD.Studio.EventInstance steps;

    void Awake()
    {
        tr = GetComponent<Transform>();
    }
    void Start()
    {
        steps = FMODUnity.RuntimeManager.CreateInstance("event:/Steps");
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EmitSound(1.0f);
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (Mathf.Abs(h) > 0 || Mathf.Abs(v) > 0)
            soundTimer -= Time.deltaTime;

        if(soundTimer<=0)
        {
            steps.start();
            EmitSound(0.2f);
            soundTimer = soundCD;
        }

        tr.position += new Vector3(h * moveSpeed, v * moveSpeed, 0);

    }

    

    void OnDestroy()
    {
        steps.release();
    }



}
