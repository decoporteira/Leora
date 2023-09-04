using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Head : MonoBehaviour
{
    //[SerializeField] public ParticleSystem psEnemy;
    void OnTriggerEnter2D(Collider2D obj)
  
    {
        if (obj.GetComponent<PlayerFeet>())
         
        {
            Debug.Log("Matou inimigo");
           // psEnemy.Play();
            Destroy(transform.parent.gameObject);
          

        }
    }
   
}
