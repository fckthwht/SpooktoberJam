using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float damageAmount;
    [SerializeField] private float rechargeTime;
    [SerializeField] private float pushForce;

    public float attackDistance;

    private float previousAttack;

    private PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = GameManager.Instance.player.GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        if (Time.time - previousAttack >= rechargeTime)
        {
            if (Vector3.Distance(transform.position, GameManager.Instance.player.transform.position) <= attackDistance)
            {
                Attack();
                previousAttack = Time.time;
            }
        }
    }

    private void Attack()
    {
        playerHealth.ReceiveDamage(damageAmount, GameManager.Instance.player.transform.position - transform.position, pushForce);
    }
}
