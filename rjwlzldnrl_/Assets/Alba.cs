using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alba : MonoBehaviour
{
    new public string name;
    public int lvl;
    public int employCost = 0;
    public int upgradeCose = 0;
    public float costIncrease = 0;
    public int moneyPerSec = 0;
    public bool employed = false;

    private void Start()
    {
        StartCoroutine(CountTime(1)); 
    }
    private void Update()
    {
        
    }
    IEnumerator CountTime(float delayTime) 
    {
        if (employed)
        {
            GameManager.Instance.gameMoney += moneyPerSec;
        }
        yield return new WaitForSeconds(delayTime); 
        StartCoroutine(CountTime(1)); 
    }
    public void Click()
    {
        if (!employed && GameManager.Instance.gameMoney >= employCost)
        {
            GameManager.Instance.gameMoney -= employCost;
            employed = true;
        }
    }
}
