using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// INHERITANCE
public class WallRed : Wall
{
    [SerializeField] float force = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        go(force);
        destroy();
    }

    // POLYMORPHISM
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }
}
