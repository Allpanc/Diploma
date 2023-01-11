using TMPro;
using UnityEngine;

public class ListItem : MonoBehaviour
{
    private TMP_Text _text;
    private Vector2 _currentRectSize;

    private void Awake()
    {
        _text = GetComponentInChildren<TMP_Text>();
        _currentRectSize = GetComponent<RectTransform>().sizeDelta;
    }

    public string GetText() => _text.text;

    public void SetText(string text) => _text.text = text;

    public void SetFixedMinFontSize()
    {
        float minFontSize = _text.fontSizeMin; 
        _text.enableAutoSizing = false;
        _text.fontSize = minFontSize;
        GetComponent<RectTransform>().sizeDelta =  new Vector2(_currentRectSize.x, _text.preferredHeight);
    }
}
