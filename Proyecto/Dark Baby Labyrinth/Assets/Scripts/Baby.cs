using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Baby : SoundEmitter
{
    public float soundCD;
    public string scene;
    private float soundTimer;
    public GameObject player;
    private float obsIndex;

    private bool loading = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = (player.transform.position - transform.position);
        LayerMask mask = LayerMask.GetMask("Paredes");
        if (Physics2D.Raycast(transform.position, dir, dir.magnitude, mask)) obstruccion();
        else desobstruccion();

        soundTimer -= Time.deltaTime;

        if (soundTimer <= 0)
        {
            EmitSound(1.0f);
            soundTimer = soundCD;
        }

        GetComponent<FMODUnity.StudioEventEmitter>().SetParameter("Obstruccion", obsIndex);
    }

    private void obstruccion() { 
        if(obsIndex < 0.7f)
        {
            obsIndex += 0.01f;
        }
    }

    private void desobstruccion()
    {
        if (obsIndex > 0.0f)
        {
            obsIndex -= 0.01f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player" && !loading)
        {
            loading = true;
            SceneManager.LoadScene(scene);
        }
    }
}
