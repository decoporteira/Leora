using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //[SerializeField] public Rigidbody2D rb;
    [SerializeField] public int enemySpeed = 1;
   
    void Update()
    {
        //rb.velocity = transform.right * enemySpeed;
    }
}
