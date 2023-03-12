using UnityEngine.SceneManagement;
using UnityEngine;
// 0 - menu; 1 - PlayGame
public class SceneManagment : MonoBehaviour
{
    public void Menu() => SceneManager.LoadScene(0);
    public void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    public void PlayGame() => SceneManager.LoadScene(1);
   
}
