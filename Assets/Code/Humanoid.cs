using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Humanoid : MonoBehaviour, IKillable, IDamageble, IMovable
    {

    protected GameObject humanoidObject;
    protected Rigidbody2D humanoidRB;
    protected Vector3 localScale = new Vector3(1, 1, 1);

    protected int health;

    public void Kill()
        {
        humanoidObject.SetActive(false);
        }

    public void Damage(int damageTaken)
        {
        health -= damageTaken;
        }

    public void Heal(int healingApplied)
        {
        health += healingApplied;
        }

    public Vector2 GetVelocity()
        {
        return humanoidRB.velocity;
        }

    public void OrientByDirection(float horizontalMovement)
        {
        if ((horizontalMovement < 0) && (localScale.x < 0) || (horizontalMovement > 0) && (localScale.x > 0))
            localScale.x *= -1;
        foreach (Transform child in humanoidObject.transform)
            {
            child.localScale = localScale;
            }
        }

    }
