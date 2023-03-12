using UnityEngine;

public class ControlScene : MonoBehaviour
{
    [SerializeField] GameObject PanelDied;
    public void Start()
    {
        PanelDied.SetActive(false);
        Time.timeScale = 1.0f;
    }

}
