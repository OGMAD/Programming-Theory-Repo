using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall : MonoBehaviour
{
    Vector3 offset = new Vector3(0, 0, -1);
    private float bound = -5.0f;
    protected int score = 0;

    public void go(float force)
    {
        transform.position = transform.position + offset * Time.deltaTime * force;
    }

    public void destroy()
    {
        if (transform.position.z < bound)
        {
            Destroy(gameObject);
        }
    }
}
