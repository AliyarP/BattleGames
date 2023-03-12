using UnityEngine.UI;
using TMPro;
using UnityEngine;

 namespace  DisplayUi
{
    public class Displays
    {
        public static void Displaytext(TMP_Text text, float value) => text.text = value.ToString();
        public static void DisplayPlayerBar(Image Health, float minHealth, float maxHealth) => Health.fillAmount = minHealth / maxHealth;
    }
}
