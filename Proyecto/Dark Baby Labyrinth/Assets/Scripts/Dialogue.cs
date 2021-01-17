using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : SoundEmitter
{
    private FMODUnity.StudioEventEmitter dialogo;

    public float changeCD;
    private float changeTimer;
    bool talking;

    public float soundCD;
    private float soundTimer;

    void Start()
    {
        dialogo = GetComponent<FMODUnity.StudioEventEmitter>();
        changeTimer = changeCD;
    }

    // Update is called once per frame
    void Update()
    {
        changeTimer -= Time.deltaTime;
        soundTimer -= Time.deltaTime;

        if(changeTimer <= 0)
        {
            RandomSelect();
            changeTimer = changeCD + Random.Range(-changeCD / 2, changeCD / 2);
        }

        if(soundTimer <= 0)
        {
            if (talking)
            {
                EmitSound(1.0f);
            }
            else EmitSound(0.2f);
            soundTimer = soundCD;
        }

    }

    private void RandomSelect()
    {
        float random = Random.Range(0, 100);

        if (random < 33)
        {
            dialogo.SetParameter("Dialogue", 0.0f);
            talking = false;
        }
        else if (random >= 33 && random < 66)
        {
            dialogo.SetParameter("Dialogue", 1.0f);
            talking = true;
        }
        else if (random >= 66 && random < 100)
        {
            dialogo.SetParameter("Dialogue", 2.0f);
            talking = true;
        }
    }
}
