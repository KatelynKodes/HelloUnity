using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : HealthBehavior
{
    public Material FailureMaterial;

    public override void OnDeath()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        if (renderer)
        {
            renderer.material = FailureMaterial;
        }

        base.OnDeath();
    }
}
