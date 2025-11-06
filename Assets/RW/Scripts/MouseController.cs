using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float jetpackForce = 75.0f;
    private Rigidbody2D playerRigidbody;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        bool jetpackActive = Input.GetButton("Fire1");
        if (jetpackActive)
        {
            playerRigidbody.AddForce(new UnityEngine.Vector2(0, jetpackForce));
        }
    }
}
