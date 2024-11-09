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
        GameManager.instance.score += 2;
        
    }  

    protected override void Attack(int amount)
    {
        Debug.Log("Golem Attacks");
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void TakeDamage(global::System.Int32 amount)
    {
        Debug.Log("You took " + amount + " damage");
    }
}
