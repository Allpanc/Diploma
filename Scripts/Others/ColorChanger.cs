using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorChanger : MonoBehaviour
{
    private Material _material;
    private Color _initialColor;
    private Color _initialHologramColor = new Color(0.04209684f, 0.8113208f, 0.1650207f, 1f);
    private Color _selectedHologramColor = new Color(0.1647059f, 0.5960785f, 0.7372549f, 1f);

    void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
        _initialColor = _material.color;
    }

    public void SetRed() => _material.color = Color.red;
    public void SetBlue() => _material.color = Color.blue;
    public void SetInitialColor() => _material.color = _initialColor;

    public void ChangeHologramColor() 
    {
        if (_material.GetColor("_mainColor") == _initialHologramColor)
            _material.SetColor("_mainColor", _selectedHologramColor);
        else
            _material.SetColor("_mainColor", _initialHologramColor);
    } 

}
