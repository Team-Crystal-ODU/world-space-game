using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    public Image xpbar;
    public float xpamount;
    public float fillspeed = 0.001f; 

    // Start is called before the first frame update
    void Start()
    {
    // xpbar.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //xpbar.fillAmount += fillspeed * Time.deltaTime;
    }

   
}
