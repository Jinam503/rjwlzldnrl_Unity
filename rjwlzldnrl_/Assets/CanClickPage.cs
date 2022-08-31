using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanClickPage : MonoBehaviour
{
    private int increase = 1;
    private void Update()
    {
        increase = GameManager.Instance.CharacterLevel * 150;
    }
    public void GetClickMoney()
    {
        GameManager.Instance.gameMoney += GameManager.Instance.moneyPerClick * increase;
    }
}
