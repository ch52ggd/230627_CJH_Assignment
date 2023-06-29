using System.Collections;
using System.Collections.Generic;
using UnityEditor.AssetImporters;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] private int dmg;


    public void InitBullet(int damage)
    {
        this.dmg = damage;
    }


    private void Start()
    {
        Physics2D.IgnoreLayerCollision(6, 6);
    }


    public void OnCollisionEnter2D(Collision2D col)
    {

    }



}
