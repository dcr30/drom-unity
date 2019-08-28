﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinAnimator : MonoBehaviour
{
    private EnemyController goblinController;
    public Animator spriteAnimator;

    void Start()
    {
        goblinController = GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = goblinController.MovementVelocity;
        var speed = velocity.magnitude;
        spriteAnimator.SetBool("IsWalking", speed > 0.1);
        if (speed > 0.1)
        {
            spriteAnimator.SetFloat("Horizontal", velocity.x);
            spriteAnimator.SetFloat("Vertical", velocity.y);
        }
    }

    void Attack()
    {
        spriteAnimator.SetTrigger("OnAttack");
    }

    void Die()
    {
        spriteAnimator.SetTrigger("OnDeath");
    }
}
