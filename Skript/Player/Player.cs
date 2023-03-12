using UnityEngine;

public class Player : MonoBehaviour
{
}
public abstract class Controler : Player
{
   [SerializeField] protected float _speed = 5f;
   [SerializeField] protected Rigidbody2D _rb;
   [SerializeField] protected bool FaceRight;
    [SerializeField] protected abstract void Move();
}
public abstract class PlayerBase : Player
{   [SerializeField] protected float _maxHp = 3f; // HpMax = 3;Min = 0 
    [SerializeField] protected float _curentHp = 3;
    public abstract void TakeDamage(float damage);
 }
