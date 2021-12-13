using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private Rigidbody wallRb;
    private float bound = -5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void go(float force)
    {
        wallRb = GetComponent<Rigidbody>();
        wallRb.AddForce(-Vector3.forward * force, ForceMode.VelocityChange);
    }

    public void destroy()
    {
        if (wallRb.position.z < bound)
        {
            Destroy(gameObject);
        }
    }
}
