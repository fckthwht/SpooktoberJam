using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    protected override void Death()
    {
        Destroy(gameObject);
    }
}
