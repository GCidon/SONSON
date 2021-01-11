using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zona : MonoBehaviour
{
    public Player player;
    public int tipo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.tag);
        if(collision.tag == "player")
            player.steps.setParameterByName("Material", tipo);
        if (collision.tag == "Wave")
            collision.GetComponent<ChangeRay>().ChangeColor(tag);
    }
}
