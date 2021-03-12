using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveHero : PhysicsObjects
{
    void Start()
    {
        
    }

    void Update()
    {
        targetVelocity = Vector2.left;
    }
}
