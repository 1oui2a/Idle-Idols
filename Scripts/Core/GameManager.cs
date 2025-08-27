using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance; // makes script accessible

    public Text moneyText;
    public int money = 0;

    void Awake()
    {
        // making sure only one instance of gamemanager exists
        if (instance == null)
        {
            instance = this;
        }
        else 
        {
            Destroy(gameObject);    
        }
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddMoney(int amount)
    {
        money += amount;
        UpdateUI();
    }

    void UpdateUI()
    {
        moneyText.text = "Money: $" + money;
    }
}


