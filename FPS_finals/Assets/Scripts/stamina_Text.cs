using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stamina_Text : MonoBehaviour
{
    private Text text;   // text를 입력하기 위한 창
    public static float stm;     // 적의 체력

    void Start()
    {

    }

    void Update()
    {
        text.text = "enemy stamina: " + stm.ToString();
    }
}
