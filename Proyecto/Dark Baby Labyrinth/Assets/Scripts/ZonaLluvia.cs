using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaLluvia : Zona
{
    public GameObject gota;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("creaGota", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void creaGota()
    {
        float x = Random.Range(transform.position.x - GetComponent<BoxCollider2D>().size.x / 2, transform.position.x + GetComponent<BoxCollider2D>().size.x / 2);
        float y = Random.Range(transform.position.y - GetComponent<BoxCollider2D>().size.y / 2, transform.position.y + GetComponent<BoxCollider2D>().size.y / 2);

        GameObject g = Instantiate(gota);
        g.transform.position = new Vector3(x, y, 0);
    }
}
