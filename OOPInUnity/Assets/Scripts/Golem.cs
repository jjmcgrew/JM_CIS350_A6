/*
 * Josh McGrew
 * Assignment 6
 * golem enemy
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;

    protected override void Awake()
    {
        base.Awake();
        health = 120;
        GameManager.Instance.score = 5;
    }

    protected override void Attack(int amount)
    {
        Debug.Log("golem attack");
    }

    public override void takeDamage(int amount)
    {
        Debug.Log("take damage: " + amount + " damage.");
    }
}
