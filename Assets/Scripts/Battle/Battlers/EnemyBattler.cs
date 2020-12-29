﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBattler : Battler
{
    [HideInInspector] public NavMeshAgent NavMeshAgent; // get
    [HideInInspector] public Vector3 Home; // get 

    protected override void Awake()
    {
        base.Awake();

        NavMeshAgent = GetComponent<NavMeshAgent>();
        NavMeshAgent.speed = Data.MoveSpeed;

        Home = this.transform.position;
    } 

    protected override void OnDeath()
    {
        Destroy(this.gameObject);
    }

    public override void OnAttack()
    {
        StartCoroutine(Attack());
    }

    private IEnumerator Attack()
    {
        if (!isAttacking)
        {
            isAttacking = true;

            yield return new WaitForSeconds(Random.Range(0.5f, 1));
            this._animators.PlayAll((i) =>
                this._animators[i].SetBool("isAttacking", true));

            yield return null; 

            this._animators.PlayAll((i) =>
                this._animators[i].SetBool("isAttacking", false));

            yield return new WaitForSeconds(Random.Range(1, 2));

            isAttacking = false;
        }
    }
}
