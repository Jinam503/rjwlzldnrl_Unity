using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterLevelUp : MonoBehaviour
{
    public Text levelUpCostText;
    public Text CharacterLevelText;

    public void LevelUp()
    {
        CharacterLevelText.text = ++Money.Instance.CharacterLevel+"";
    }
}
