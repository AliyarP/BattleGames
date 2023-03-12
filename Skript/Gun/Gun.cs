using TMPro;
using UnityEngine;
using  DisplayUi;

    public class Gun : MonoBehaviour
    {
        [SerializeField] private GameObject _bullPrefab;
        [SerializeField] private Transform _bullPos;
        [SerializeField] private float _ammo = 20;//патрон
        [SerializeField] private TMP_Text _ammoText;
       private void Start()
       {
        Displays.Displaytext(_ammoText, _ammo);
       }
        private void Update()
        {
            Vector3 MousePosion = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float angle = Mathf.Atan2(MousePosion.y, MousePosion.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);

            if (Input.GetMouseButtonDown(0) && _ammo >= 1)
            {
                Instantiate(_bullPrefab, _bullPos.position, _bullPos.rotation);
                TakeAmmo(ref _ammo, 1);
                Displays.Displaytext(_ammoText, _ammo);
            }
        }
       public static void TakeAmmo(ref float value,float Take)=> value -= Take;
    public void GiveAmmo(float ammo)
    {
        _ammo += ammo;
        Displays.Displaytext(_ammoText, _ammo);
    }
    
}  
 