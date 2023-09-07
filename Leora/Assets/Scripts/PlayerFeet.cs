using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFeet : MonoBehaviour
{

    [SerializeField] private Rigidbody2D PlayerRb;
  
  
        void OnTriggerEnter2D(Collider2D obj)
        {
            if (obj.GetComponent<Head>())
            {
           Debug.Log("pisou na cabeça do inimigo");
            PlayerRb.velocity = new Vector2(PlayerRb.velocity.x, 0);
            PlayerRb.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);

            }
        }

    
}
