using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby : SoundEmitter
{
    public float soundCD;
    private float soundTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        soundTimer -= Time.deltaTime;

        if (soundTimer <= 0)
        {
            EmitSound(1.0f);
            soundTimer = soundCD;
        }
    }
}
