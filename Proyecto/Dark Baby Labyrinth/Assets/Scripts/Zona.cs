using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zona : MonoBehaviour
{
    public Player player;
    public int tipo;
    public Color c;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            player.steps.setParameterByName("Material", tipo);
            player.setColor(c);
        }
    }
}
