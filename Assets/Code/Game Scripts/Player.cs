using Assets.Code.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour, IDamagable, IDamager, IMovable
{
    public float hp { get; set; }
    public float armor { get; set; }
    public float damage { get; set; }
    public float maxSpeed { get; set; }

    private Rigidbody2D rb;
    private Vector2 inputMovement;
    private PlayerMovement pm;


    public void Initializate(float hp, float armor, float damage, float maxSpeed)
    {
        rb = GetComponent<Rigidbody2D>();
        pm = GetComponent<PlayerMovement>();
        this.hp = hp;
        this.armor = armor;
        this.damage = damage;
        this.maxSpeed = maxSpeed; ;
        print("Inited sucsessfuly!");
    }

    private void FixedUpdate()
    {
        
    }
    public void TakeDamage() { }
    void OnMove(InputValue iv)
    {
        inputMovement = iv.Get<Vector2>().normalized;
        
    }
}
