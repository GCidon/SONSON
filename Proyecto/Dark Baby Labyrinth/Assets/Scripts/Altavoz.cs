using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altavoz : SoundEmitter
{
    
    public float soundCD;

    private float paramObs;
    public static float paramZona;
    private float paramGente;

    public static bool changeGente;
    public static bool changeObs;

    void Start()
    {
        InvokeRepeating("EmitSoundWithColors", 0.0f, soundCD);
    }

    void Update()
    {
        if (changeGente) genteUp();
        else genteDown();
        if (changeObs) obsUp();
        else obsDown();

        GetComponent<FMODUnity.StudioEventEmitter>().SetParameter("Obstruccion", paramObs);
        GetComponent<FMODUnity.StudioEventEmitter>().SetParameter("Gente", paramGente);
        GetComponent<FMODUnity.StudioEventEmitter>().SetParameter("Zona", paramZona);
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
        EmitRandomSound(1.0f);
    }

    void genteUp()
    {
        if(paramGente < 0.9f)
        {
            paramGente += 0.01f;
        }
    }
    void genteDown()
    {
        if (paramGente > 0.0f)
        {
            paramGente -= 0.01f;
        }

    }
    void obsUp()
    {
        if (paramObs < 0.8f)
        {
            paramObs += 0.01f;
        }
    }
    void obsDown()
    {
        if (paramObs > 0.0f)
        {
            paramObs -= 0.01f;
        }
    }
}
