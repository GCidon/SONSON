using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaLluvia : Zona
{
    public GameObject gota;
    public float maxDistance;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("creaGota", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isInside(player.gameObject.transform.position))
        {
            Vector2 distVec = new Vector2(player.gameObject.transform.position.x - transform.position.x, player.gameObject.transform.position.y - transform.position.y);
            float distance = distVec.magnitude;// + GetComponent<BoxCollider2D>().size.magnitude;
            GetComponent<FMODUnity.StudioEventEmitter>().SetParameter("Obstruccion", (distance / maxDistance));
        }
        else
        {
            GetComponent<FMODUnity.StudioEventEmitter>().SetParameter("Obstruccion", 0.0f);
        }
    }

    void creaGota()
    {
        float x = Random.Range(transform.position.x - GetComponent<BoxCollider2D>().size.x / 2, transform.position.x + GetComponent<BoxCollider2D>().size.x / 2);
        float y = Random.Range(transform.position.y - GetComponent<BoxCollider2D>().size.y / 2, transform.position.y + GetComponent<BoxCollider2D>().size.y / 2);

        GameObject g = Instantiate(gota);
        g.transform.position = new Vector3(x, y, 0);
    }

    bool isInside(Vector3 pos)
    {
        return GetComponent<BoxCollider2D>().bounds.Contains(pos);
    }
}
