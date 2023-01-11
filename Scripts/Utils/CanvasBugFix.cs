using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasBugFix : MonoBehaviour
{
    private Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canvas.enabled)
            canvas.enabled = true;
    }
}
