using UnityEngine;

public class Bull : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
   
    [SerializeField] private float _speed;
    [SerializeField] private float _damage = 1;
    [SerializeField] private float _destroyBullPrefabTime;
    [SerializeField] private float _lengtRay = 0.1f;
    [SerializeField] private LayerMask _trueRay;
    private void Start() => Destroy(gameObject, _destroyBullPrefabTime);
    private void Update()
    {
        rb.velocity = transform.right * _speed;
       
        RaycastHit2D ray = Physics2D.Raycast(transform.position, transform.right, _lengtRay, _trueRay);
        if (ray)
        {
            Destroy(gameObject);
            ray.collider.TryGetComponent(out attackEnemy takeDamage);
            takeDamage.TakeDamage(_damage);
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.TryGetComponent(out attackEnemy takeDamage))
    //    {
    //        Destroy(gameObject);
    //        takeDamage.TakeDamage(_damage);
    //    }
    //}
}
