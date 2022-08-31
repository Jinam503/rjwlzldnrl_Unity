using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterLevelUp : MonoBehaviour
{
    public Text levelUpCostText;
    public Text CharacterLevelText;
    private float increase = 0;

    private void Update()
    {
        CharacterLevelText.text = GameManager.Instance.CharacterLevel + "";
        levelUpCostText.text = GameManager.Instance.levelUpCost + "¿ø";
        increase = GameManager.Instance.levelUpCost; 
    }
    public void LevelUp()
    {
        if (GameManager.Instance.gameMoney >= GameManager.Instance.levelUpCost)
        {
            ++GameManager.Instance.CharacterLevel;
            GameManager.Instance.gameMoney -= GameManager.Instance.levelUpCost;
            
            increase *= 1.3f;
            GameManager.Instance.levelUpCost = (int)increase;
            ++GameManager.Instance.levelUpCost;
        }
    }
}
