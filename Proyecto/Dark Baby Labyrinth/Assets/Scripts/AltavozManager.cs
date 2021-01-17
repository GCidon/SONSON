using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltavozManager : MonoBehaviour
{

    public GameObject player;

    public BoxCollider2D zona1;
    public BoxCollider2D zona2;
    public BoxCollider2D zona3;
    public BoxCollider2D banho1;
    public BoxCollider2D banho2;

    void Update()
    {
        if (zona1.bounds.Contains(player.transform.position)) 
        {
            Altavoz.changeGente = false;
            Altavoz.changeObs = false;
            Altavoz.paramZona = 0.0f;
        } 
        else if(zona2.bounds.Contains(player.transform.position))
        {
            Altavoz.changeGente = false;
            Altavoz.changeObs = false;
            Altavoz.paramZona = 1.0f;
        }
        else if (zona3.bounds.Contains(player.transform.position))
        {
            Altavoz.changeGente = true;
            Altavoz.changeObs = false;
            Altavoz.paramZona = 2.0f;
        }
        else if (banho1.bounds.Contains(player.transform.position))
        {
            Altavoz.changeGente = false;
            Altavoz.changeObs = true;
            Altavoz.paramZona = 1.0f;
        }
        else if (banho2.bounds.Contains(player.transform.position))
        {
            Altavoz.changeGente = true;
            Altavoz.changeObs = true;
            Altavoz.paramZona = 2.0f;
        }
    }
}
