using UnityEngine;
using UnityEngine.UI;


public class attackEnemy : EnemyBase
{
     protected override float _currentHp { get; set; } = 3;
     protected override float hpMax { get; set ; } = 3;
     protected override float hpMin { get; set; } = 0;
     protected override float damage { get; set; } = 1;
    
    [SerializeField] private Image EnemyHp;
  
    [SerializeField] private float Hp;
    [SerializeField] private float HPMax;
    [SerializeField] private float HPMin;
    [SerializeField] private float Damage;

    [Header("значение должно быть на 0 ")]
    [SerializeField] private float _timeDamege;
   
    [SerializeField] private float _timeRestartDamage;
  
    private void Start()
    {
         _currentHp = Hp;
         hpMax = HPMax;
         hpMin = HPMin;
         damage = Damage;
    }
    public void TakeDamage(float damage)
    {
        _currentHp -= damage;
        ImageDesplay(_currentHp, hpMax, EnemyHp);
        if (_currentHp <= hpMin)
        { Destroy(gameObject); }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        _timeDamege += Time.deltaTime;
        if (collision.gameObject.TryGetComponent(out PlayerHp takeHp) && _timeDamege > _timeRestartDamage )
        {
            takeHp.TakeDamage(damage);
            _timeDamege = 0;
        }
    }
    public void ImageDesplay(float hp,float maxhp,Image hpImage)=> hpImage.fillAmount = hp / maxhp;
}
