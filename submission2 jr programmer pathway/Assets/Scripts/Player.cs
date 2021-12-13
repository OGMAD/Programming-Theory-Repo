using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField] float force = 0.05f;
    [SerializeField] float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        playerRb.AddForce(Vector3.right * force * horizontalInput, ForceMode.Impulse);
        playerRb.transform.position = new Vector3(playerRb.position.x, playerRb.position.y, 0);
    }
}
