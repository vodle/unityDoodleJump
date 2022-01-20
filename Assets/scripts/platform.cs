using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class platform : MonoBehaviour
{
    public float jumpForce = 10f;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.relativeVelocity.y <0)
        {
            player.instance.rigitPlayer.velocity = Vector2.up * jumpForce;
        }

        if (other.gameObject.tag == "Player")
        {
            player.instance.Score += 10f;
        }
        
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.name == "DeadZone")
        {

            float randX = Random.Range(-2f, 2f);
            float randY = Random.Range(transform.position.y + 19.5f, transform.position.y + 21f);

            transform.position = new Vector3(randX, randY, 0);

        } 
    }
}
