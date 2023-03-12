using UnityEngine;

public class DiedSpavnGameObject : MonoBehaviour
{
    [SerializeField] private GameObject[] _gameObject;
    [SerializeField] private int probabitly,min,max;
    private void OnDisable()
    {
        SpavnGameOject(_gameObject,probabitly,min,max);
    }
    public void SpavnGameOject(GameObject[] GameObject,int Probabitly = 2,int min = 0,int max= 4)
    {
       if(Random.Range(min,max) == Probabitly)
       {
        Instantiate(GameObject[0],transform.position,Quaternion.identity);
       }
    }
    
}
