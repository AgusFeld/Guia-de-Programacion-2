﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = 0; i < 80; i++)
            {
                GameObject clon;
                clon = Instantiate(prefab);
                Destroy(clon, 2);
            }
            
        }
    }
}
