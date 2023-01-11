using UnityEngine;

public class CanvasShowFix : MonoBehaviour
{
    public Canvas canvas;
    private bool canvasEnabledState;

    public void RememberCanvasEnabledState() => canvasEnabledState = canvas.enabled;
    public void FixCanvasEnabledState() => canvas.enabled = canvasEnabledState;
}
