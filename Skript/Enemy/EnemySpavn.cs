using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DisplayUi;


public class EnemySpavn : MonoBehaviour
{
    [SerializeField] private List<GameObject> SpavnEnemyPrefab = new List<GameObject>();

    [SerializeField] private Transform _directionSpavn;
    [SerializeField] private Vector2 _spavnPosition;
    [SerializeField] private float _timeSpavn;
    [SerializeField] private int _makeGameHarderLvl = 1;

 
    [SerializeField] private float[] makeGamesHarderTimer = {20,30,40};
    enum MakeGamesHarder
    {
        easy = 0,
        normal = 1,
        medium = 2,
        hard = 3,
    }
    private void Start()
    {
      StartCoroutine(nameof(complicateGame));
      StartCoroutine(nameof(nextComplicate));
    }
    public void EnemyRandomSpavn(List<GameObject> Prefab,int GameHarder)
    {
      GameObject PrefabEnemy = Instantiate(Prefab[Random.Range(0,_makeGameHarderLvl +(int)MakeGamesHarder.easy)]);
      SetEnemy(PrefabEnemy, _spavnPosition);
    }
    public void SetEnemy(GameObject gameObject,Vector2 point)
    {
       point  = new Vector2(Random.Range(_directionSpavn.position.x,point.x),Random.Range(_directionSpavn.position.y,point.y)); 
       gameObject.transform.position = point;
    }
    IEnumerator complicateGame()
    {
        while(true)
        {
           EnemyRandomSpavn(SpavnEnemyPrefab,_makeGameHarderLvl);
           yield return new WaitForSeconds(_timeSpavn);
        }
    }
    IEnumerator nextComplicate()
    {
       
            for(int i = 0;i < makeGamesHarderTimer.Length;i++)
            {
              yield return new WaitForSeconds(makeGamesHarderTimer[i]);
              _makeGameHarderLvl++;
              _timeSpavn -= 0.1f;
            }
    }
}
