using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOne : MonoBehaviour {

    private GameObject panelOne;
    private GameObject panelTwo;

    private void Start()
    {
        panelOne = transform.parent.GetChild(0).gameObject;
        panelTwo = transform.parent.GetChild(1).gameObject;
    }

    public void BlueOnClick()
    {
        //分发事件,注意和接收者协议一致
        NotificationCenter.Get().DispatchEvent("ChangeColor", Color.blue);
    }

    public void RedOnClick()
    {
        //分发事件,注意和接收者协议一致
        NotificationCenter.Get().DispatchEvent("ChangeColor", Color.red);
    }

    public void GreenOnClick()
    {
        //分发事件,注意和接收者协议一致
        NotificationCenter.Get().DispatchEvent("ChangeColor", Color.green);
    }

    public void NextOnClick()
    {
        if (panelOne != null && panelTwo != null)
        {
            panelOne.SetActive(false);
            panelTwo.SetActive(true);
        }
    }

}
