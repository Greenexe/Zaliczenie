using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{
    static RectTransform rectTrans;

    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
    }

    public static void ChangeBar(int value, int maxValue)
    {
        if (value > 10)
        {
            float maxHeight = 621;
            rectTrans.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, value * maxHeight / maxValue);
        }
    }
}
