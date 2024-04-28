using Assets.Code.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable, IMovable, IDamager
{
    public float hp { get; set; }
    public float armor { get; set; }
    public float damage { get; set; }
    public float maxSpeed { get; set; }

    [SerializeField] private float setHP;
    [SerializeField] private float setArmor;
    [SerializeField] private float setSpeed;
    [SerializeField] private float setDamage;


    public void Awake()
    {
        this.hp = 12;
        this.armor = 1;
        this.maxSpeed = 4f;
        this.damage = 4;
    }

    // Update is called once per frame
    void Move()
    {
        
    }
    private void Update()
    {
        //Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
