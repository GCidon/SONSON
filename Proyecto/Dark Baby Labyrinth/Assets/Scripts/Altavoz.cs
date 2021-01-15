using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altavoz : SoundEmitter
{
    
    public float soundCD;

    void Start()
    {
        InvokeRepeating("EmitSoundWithColors", 0.0f, soundCD);
    }

    void EmitSoundWithColors()
    {
        Color randomColor = new Color(
            Random.Range(0f, 1f), //Red
            Random.Range(0f, 1f), //Green
            Random.Range(0f, 1f), //Blue
            1 //Alpha (transparency)
        );
        setColor(randomColor);
        EmitSound(1.0f);
    }
}
