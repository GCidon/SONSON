using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermaSound : SoundEmitter
{

    public float soundCD;
    public float timeLiving;
    Color c;
    void Start()
    {
        InvokeRepeating("EmitSoundWithColors", 0.0f, soundCD);
    }

    void EmitSoundWithColors()
    {
        EmitSound(timeLiving);
    }
}
