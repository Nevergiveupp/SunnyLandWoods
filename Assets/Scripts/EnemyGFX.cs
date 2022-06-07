using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aiPath;

    // Update is called once per frame
    void Update()
    {
        // moving to the right
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            // flip to left
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        // moving to the left
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            // flip to right
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
