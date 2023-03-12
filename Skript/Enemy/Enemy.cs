using UnityEngine;

public class Enemy : MonoBehaviour
{
}
public abstract class VisionEnemy : Enemy
{
    [SerializeField] protected Rigidbody2D Rb;
    [SerializeField] protected Vector2 distanseVar;
    [SerializeField] protected LayerMask Player;
   
    [SerializeField] protected float Speed;
    [SerializeField] protected float angle;
}
public abstract class EnemyBase : Enemy
{
   
    [SerializeField]  abstract protected float _currentHp { get; set;}
    [SerializeField] abstract protected float hpMax { get; set; }
    [SerializeField] abstract protected float hpMin { get; set; }
    [SerializeField] abstract protected float damage { get; set; }
}