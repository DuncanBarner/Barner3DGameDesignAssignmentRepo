﻿using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
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
            Debug.Log("Enemy ate weapon");
        }

        public void Recharge()
        {
            Debug.Log("Recharging Weapon");
        }



        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}