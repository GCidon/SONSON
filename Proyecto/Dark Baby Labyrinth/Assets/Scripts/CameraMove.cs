using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public GameObject player;
    private Transform tr;
    private Transform playertr;

    private void Awake()
    {
        tr = GetComponent<Transform>();
        playertr = player.GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tr.position = new Vector3(playertr.position.x, playertr.position.y, tr.position.z);
    }
}
