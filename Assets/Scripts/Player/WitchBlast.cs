using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchBlast : AttackAbility
{
    public AnimationClip clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out enemyHealthComponent))
        {
            enemyHealthComponent.ReceiveDamage(damageAmount, collision.transform.position - transform.position, pushForce);
        }
    }
}