using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFireball : AttackAbility
{
    [HideInInspector] public Vector3 direction;
    public float speed;

    private void Update()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out enemyHealthComponent))
        {
            enemyHealthComponent.ReceiveDamage(damageAmount, collision.transform.position - transform.position, pushForce);
        }
    }
}
