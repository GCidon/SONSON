using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEmitter : MonoBehaviour
{

    public int waveNum_;
    public float speed_;
    public GameObject wave_;

    protected void EmitSound()
    {
        float incr = 360.0f / waveNum_;

        for (int i = 0; i < waveNum_; i++)
        {
            GameObject obj = Instantiate(wave_, gameObject.transform.position, transform.rotation);

            obj.GetComponent<Rigidbody2D>().velocity = Rotate(new Vector2(1, 0), (360.0f / 2.0f) - ((incr * i)+Random.Range(-incr, +incr))) * speed_;

            //fixes rotation so bullets look in the direction they move
            //obj.transform.rotation = Quaternion.LookRotation(obj.GetComponent<Rigidbody2D>().velocity, Vector2.up);
            //obj.transform.rotation *= Quaternion.Euler(90, -90, 0);

            //obj.layer = gameObject.layer;
        }
    }

    private Vector2 Rotate(Vector2 v, float degrees)
    {
        float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
        float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);

        float tx = v.x;
        float ty = v.y;
        v.x = (cos * tx) - (sin * ty);
        v.y = (sin * tx) + (cos * ty);
        return v.normalized;
    }
}
