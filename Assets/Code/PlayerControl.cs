using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    Animator hairA;
    Animator bodyA;
    Rigidbody2D rb2D;
    float translation;
    GameObject hair;
    GameObject body;
    Vector3 localScale;

    void Start()
        {
        rb2D = GetComponent<Rigidbody2D>();
        hair = GameObject.Find("Player_hair");
        body = GameObject.Find("Player_body");
        localScale = new Vector3(1, 1, 1);
        hairA = hair.GetComponent<Animator>();
        bodyA = body.GetComponent<Animator>();
        }
	
	void Update()
        {
        translation = Input.GetAxis("Horizontal") * 0.05f;
        if ((Input.GetButtonDown("Jump")) && (rb2D.velocity.y == 0))
            rb2D.AddForce(Vector3.up * 200);
        if (translation != 0)
            SetAnimatorsBools("isWalking", true);
        else
            SetAnimatorsBools("isWalking", false);
        if ((translation < 0) && (localScale.x < 0) || (translation > 0) && (localScale.x > 0))
            localScale.x *= -1;
        body.transform.localScale = localScale;
        hair.transform.localScale = localScale;
        }

    void FixedUpdate()
        {
        rb2D.transform.Translate(translation, 0, 0);
        }

    void SetAnimatorsBools(string b, bool p)
        {
        hairA.SetBool(b, p);
        bodyA.SetBool(b, p);
        }
}
