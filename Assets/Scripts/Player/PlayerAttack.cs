using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float rechargeTime;

    public float damageAmount;
    public float attackRadius;
    public Vector3 attackPoint;
    public float pushForce;

    private float previousAttack = 0;

    private void Update()
    {
        if (Time.time - previousAttack >= rechargeTime)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Attack();
                previousAttack = Time.time;
            }
        }
    }

    private void Attack()
    {
        GameManager.Instance.playerInteraction.Attack();
    }
}
