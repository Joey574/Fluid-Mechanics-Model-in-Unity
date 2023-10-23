using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationManager : MonoBehaviour
{
    public float gravity;
    Vector2[] position;
    Vector2[] velocity;

    void Update()
    {
        for (int i = 0; i < position.Length; i++)
        {
            velocity[i] += Vector2.down * gravity * Time.deltaTime;
            position[i] += velocity[i] * Time.deltaTime;

            ResolveCollisions();

            
        }
       
    }

    private void ResolveCollisions()
    {

    }
}
