using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] public ParticleSystem ps;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit");
        if (collision.gameObject.tag == "Enemy")
        {
            ps.Play();
            Invoke("DestroyObj", 1.0f);
               
        }
    }
    private void DestroyObj()
    {
        Destroy(gameObject);
    }

}
