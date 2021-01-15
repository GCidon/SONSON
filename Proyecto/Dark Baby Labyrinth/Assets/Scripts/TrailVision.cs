using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailVision : MonoBehaviour
{
    private GameObject player;
    private TrailRenderer trail;
    // Start is called before the first frame update
    void Start()
    {
        trail = GetComponent<TrailRenderer>();
        player = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = (player.transform.position - transform.position);
        LayerMask mask = LayerMask.GetMask("Paredes");
        if (Physics2D.Raycast(transform.position, dir, dir.magnitude, mask)) obstruccion();
        else desobstruccion();

    }

    void obstruccion()
    {
        trail.enabled = false;
    }

    void desobstruccion()
    {
        trail.enabled = true;
    }

}
