using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Baby : SoundEmitter
{
    public float soundCD;
    public string scene;
    private float soundTimer;
    private bool loading = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        soundTimer -= Time.deltaTime;

        if (soundTimer <= 0)
        {
            EmitSound(1.0f);
            soundTimer = soundCD;
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
