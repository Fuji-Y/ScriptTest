using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss   //応用課題
{
    private int mp = 53;
    public void Magic()
    {
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //課題
        int[] array = { 10, 20, 30, 40, 50 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //応用課題
        Boss boss = new Boss();
            boss.Magic();
            boss.Magic();
            boss.Magic();
            boss.Magic();
            boss.Magic();
            boss.Magic();
            boss.Magic();
            boss.Magic();
            boss.Magic();
            boss.Magic();
            boss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
