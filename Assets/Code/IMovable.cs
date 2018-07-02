using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable
    {

    Vector2 GetVelocity();

    void OrientByDirection(float horizontalMovement);

    }
