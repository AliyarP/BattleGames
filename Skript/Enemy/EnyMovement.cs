using UnityEngine;

public class EnyMovement : VisionEnemy
{
    void FixedUpdate()
    { 
        if(Physics2D.OverlapBox(transform.position, distanseVar, angle, Player))
        {
          Rb.MovePosition(Vector2.MoveTowards(transform.position,FindObjectOfType<PlayerControler>().transform.position,Time.deltaTime * Speed));
        }
    }
}

