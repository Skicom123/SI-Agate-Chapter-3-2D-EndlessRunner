using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    public float isTime;
    public bool completeTime = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.25f;
    }

    // Update is called once per frame
    private void Update()
    {
        if (completeTime == false)
        {
            Time.timeScale -= 0.02f;
        }
    }
}
