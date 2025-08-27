using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text moneyText;
    public int money = 0;
    public int moneyPerShift = 1;

    public void DoWaitressShift()
    {
        money += moneyPerShift;
        UpdateUI();
    }
}