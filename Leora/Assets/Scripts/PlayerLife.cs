using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] public ParticleSystem ps;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            ps.Play();
            //change rigidbody to kinematic
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            //change color to red
            Debug.Log("Matou player");
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            Invoke("DestroyObj", 1.0f);

        }
        
    }
   
    private void DestroyObj()
    {
        Destroy(gameObject);
        //restart level
        SceneManager.LoadScene(0);
        
    }

}
