using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// INHERITANCE
public class Wall : MonoBehaviour
{
    Vector3 offset = new Vector3(0, 0, -1);
    private float bound = -5.0f;

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

    // POLYMORPHISM
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision!");
        }
    }
}
