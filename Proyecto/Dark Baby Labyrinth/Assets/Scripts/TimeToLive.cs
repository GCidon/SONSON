using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToLive : MonoBehaviour
{
    public float time_;
    public float timeDying_;

    void Start()
    {
        //Invoke("Die", time_);
    }

    void Update()
    {
        if(time_ <= 0)
        {
            if(timeDying_ <= 0)
                Destroy(gameObject);
            else
                timeDying_ -= Time.deltaTime;
        }
        else
        {
            time_ -= Time.deltaTime;
            if(time_ <= 0) GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }

    public void set(float t, float td)
    {
        time_ = t;
        timeDying_ = td;
    }

    void Die()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        Destroy(gameObject, timeDying_);
    }
}
