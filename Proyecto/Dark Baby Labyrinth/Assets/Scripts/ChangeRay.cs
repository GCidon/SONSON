using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRay : MonoBehaviour
{
    TrailRenderer trail_;
    private TimeToLive TTL_;
    enum Colors{ Blanco, Azul, Verde }

    void Start()
    {
        TTL_ = GetComponent<TimeToLive>();
        trail_ = GetComponent<TrailRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown("j"))
        {
            GameObject a = Instantiate(gameObject);
            a.GetComponent<TimeToLive>().set(TTL_.time_, TTL_.timeDying_);
            a.GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            a.GetComponent<TrailRenderer>().startColor = Color.blue;
            a.GetComponent<TrailRenderer>().endColor = Color.blue;
        }
    }

    public void ChangeColor(string tag)
    {
        Color c;
        switch (tag)
        {
            case "cesped":
                c = Color.green;
                break;
            default:
                c = Color.white;
                break;
        }
        if (trail_.startColor == c)
            return;

        GameObject a = Instantiate(gameObject);
        a.GetComponent<TimeToLive>().set(TTL_.time_, TTL_.timeDying_);
        a.GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        a.GetComponent<TrailRenderer>().startColor = c;
        a.GetComponent<TrailRenderer>().endColor = c;
    }
}
