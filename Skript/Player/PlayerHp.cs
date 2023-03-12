using UnityEngine;
using UnityEngine.UI;
using DisplayUi;

public class PlayerHp : PlayerBase
{
    [SerializeField] private GameObject DiedPanel;
    [SerializeField] protected  Image _hpImage;
    private void OnEnable() => DelagetClass.DiedHandler += Died;
    private void OnDisable() => DelagetClass.DiedHandler -= Died;
    public override void TakeDamage(float damage)
    {
        _curentHp -=  damage;
        Displays.DisplayPlayerBar(_hpImage, _curentHp, _maxHp);
        if (_curentHp <= 0)
        { 
          DelagetClass.DiedHandler?.Invoke();
        }
    }
    public void Died()
    {
      DiedPanel.SetActive(true);
      gameObject.SetActive(false);
      Time.timeScale= 0f;
    }

}
