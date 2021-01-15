using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SoundEmitter
{
    private Transform tr;
    public float moveSpeed;
    public float soundCD;
    private float soundTimer;
    public float clapCD;
    private float clapTimer;
    

    public FMOD.Studio.EventInstance steps;
    public FMOD.Studio.EventInstance clap;

    void Awake()
    {
        tr = GetComponent<Transform>();
    }
    void Start()
    {
        steps = FMODUnity.RuntimeManager.CreateInstance("event:/Steps");
        clap = FMODUnity.RuntimeManager.CreateInstance("event:/Clap");

        soundTimer = soundCD;
        clapTimer = 1.0f;
    }
    
    void Update()
    {
        clapTimer -= Time.deltaTime;
        if (clapTimer <= 0) clapTimer = 0;
        if (Input.GetKeyDown(KeyCode.Space) && clapTimer <= 0)
        {
            Color ant = color_;
            setColor(Color.yellow);
            EmitSound(1.0f);
            setColor(ant);
            clap.start();
            clapTimer = clapCD;
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
