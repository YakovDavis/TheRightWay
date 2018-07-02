using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Humanoid
    {

    public bool IsControllable = true;
    public float Speed = 0.05f;

    private float translation;

    void Start ()
        {
        humanoidObject = gameObject;
        humanoidRB = GetComponent<Rigidbody2D>();
        health = 100;
	    }

    void Update()
        {
        translation = Input.GetAxis("Horizontal") * Speed;
        if ((Input.GetButtonDown("Jump")) && (humanoidRB.velocity.y == 0))
            humanoidRB.AddForce(Vector3.up * 200);
        if (translation != 0)
            SetAnimatorsBools("isWalking", true);
        else
            SetAnimatorsBools("isWalking", false);
        OrientByDirection(translation);
        }

    void FixedUpdate()
        {
        humanoidRB.transform.Translate(translation, 0, 0);
        }

    void SetAnimatorsBools(string b, bool p)
        {
        foreach (Transform child in humanoidObject.transform)
            {
            child.GetComponent<Animator>().SetBool(b, p);
            }
        }
    }
