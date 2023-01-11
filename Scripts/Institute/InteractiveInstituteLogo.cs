using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(InstituteID))]
public class InteractiveInstituteLogo : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] InstituteDisplay _instituteDisplay;
    private int _id;
    private float _lastTimeClick;
    private void Start() => _id = GetComponent<InstituteID>().id;

    public void OnPointerClick(PointerEventData eventData)
    {
        float currentTimeClick = eventData.clickTime;
        try
        {
            if (Mathf.Abs(currentTimeClick - _lastTimeClick) < 0.3f)
                _instituteDisplay.DisplayInstitute(_id);
        }
        catch (System.NullReferenceException) { }

        _lastTimeClick = currentTimeClick;
    }
}
