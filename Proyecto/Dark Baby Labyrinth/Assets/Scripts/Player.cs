﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SoundEmitter
{
  
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.anyKey)
        {
            EmitSound();
        }
    }


   
}
