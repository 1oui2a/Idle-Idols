using UnityEngine;
using UnityEngine.UI;

public class ButtonClicks : MonoBehaviour
{
    public Text moneyText;
    public int money = 0;
    public int moneyPerShift = 1;

    // called when button is pressed
    public void DoWaitressShift()
    {
        money += moneyPerShift;
        UpdateUI();
    }

    void UpdateUI()
    {
        moneyText.text = "Money: $" + money;
    }
    
}