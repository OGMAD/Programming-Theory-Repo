using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGreen : Wall
{
    [SerializeField] float force = 20f;
    // Start is called before the first frame update
    void Start()
    {
        go(force);
    }

    // Update is called once per frame
    void Update()
    {
        destroy();
    }
}
