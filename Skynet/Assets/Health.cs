using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int currentHP;
    public Text hpText;

    public void TakeDmg()
    {
        currentHP -= 15;
        if(currentHP <= 0)
        {
            currentHP = 0;
            GameOver();
        }
        printHealth();     
    }

    public void Heal()
    {
        currentHP += 1;
        if (currentHP > 100)
        {
            currentHP = 100;
        }
        printHealth();
    }

    void printHealth()
    {
        hpText.text = currentHP + "%";
    }

    void GameOver()
    {
        hpText.text = "f#@!";
    }
}
