/*
 * Josh McGrew
 * Assignment 6
 * weapon
 */
using System.Collections;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damageBonus;

    public Enemy enemyHoldingWeapon;

    private void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
        EnemyEatsWeapon(enemyHoldingWeapon);
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("enemy eats weapon.");
    }

    public void Recharge()
    {
        Debug.Log("recharging weapon");
    }
}