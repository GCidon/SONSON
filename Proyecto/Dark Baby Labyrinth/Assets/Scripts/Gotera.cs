using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gotera : MonoBehaviour
{
    public float soundCD;
    private float soundTimer;
    public float randomRange;

    public GameObject gota;

    public GameObject player;

    private FMODUnity.StudioEventEmitter goteo;
    void Start()
    {
        goteo = GetComponent<FMODUnity.StudioEventEmitter>();
    }

    void Update()
    {
        soundTimer -= Time.deltaTime;

        if (soundTimer <= 0)
        {
            GameObject g = Instantiate(gota);
            g.transform.position = new Vector3(transform.position.x, transform.position.y, 0);

            goteo.SetParameter("Goteo", 1.0f);
            Invoke("callate", 0.5f);
            soundTimer = soundCD + Random.Range(-randomRange, randomRange);
        }
    }

    void callate()
    {
        goteo.SetParameter("Goteo", 0.0f);
    }

}
