using UnityEngine;

public class PlayerControler : Controler
{
    void Update() => Move();
    protected override void Move()
    {
        float MoveXorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");
        Vector2 move = new Vector2(MoveXorizontal * _speed, MoveVertical * _speed);
        _rb.velocity = move * _speed;
    }
}
