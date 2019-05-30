using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBar : MonoBehaviour
{
    static RectTransform rectTrans;
    public static float maxHeight = 487;

    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
    }

    public static void ChangeBar(int value, int maxValue)
    {
        if (value > 10)
        {
            rectTrans.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, value * maxHeight / maxValue);
        }
    }
}
