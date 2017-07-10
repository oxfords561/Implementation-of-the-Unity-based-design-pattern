using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelTwo : MonoBehaviour {

    private GameObject panelOne;
    private GameObject panelTwo;
    private Text text;


    private void Start()
    {
        panelOne = transform.parent.GetChild(0).gameObject;
        panelTwo = transform.parent.GetChild(1).gameObject;
        if(panelTwo != null)
        {
            text = panelTwo.transform.FindChild("Text").GetComponent<Text>();
        }

        //在接收者中注册事件及其回调方法
        NotificationCenter.Get().AddEventListener("ChangeColor", ChangeColor);
    }


    public void LastOnClick()
    {
        if (panelOne != null && panelTwo != null)
        {
            panelOne.SetActive(true);
            panelTwo.SetActive(false);
        }
    }

    public void ChangeColor(Notification notific)
    {
        print("变换颜色");
        text.color = (Color)notific.param;
    }
}
