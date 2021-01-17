using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persone : SoundEmitter
{
    public float soundCD;
    private float soundTimer;

    public float speakCD = 5.0f;
    private float speakTimer;

    private bool speaking = false;

    void Update()
    {
        if (speaking)
        {
            soundTimer -= Time.deltaTime;

            if (soundTimer <= 0)
            {
                EmitSound(0.5f);
                soundTimer = soundCD;
            }
        }

        speakTimer -= Time.deltaTime;

        if (speakTimer <= 0)
        {
            speaking = !speaking;
            speakTimer = speakCD + Random.Range(-speakCD/2, speakCD/2);
        }
    }
}
