using UnityEngine;
using Vuforia;

public class GroundPlaneController : MonoBehaviour
{
    [SerializeField] private PlaneFinderBehaviour _planeFinder;
    [SerializeField] private AnchorInputListenerBehaviour _inputListenerBehaviour;
    [SerializeField] private AnchorBehaviour _anchorBehaviour;

    public void SetAnchorsEnabledState(bool state)
    {
        _anchorBehaviour.enabled = state;
    }

    public void SetInputListenerEnabledState(bool state)
    {
        _inputListenerBehaviour.enabled = state;
    }

    public void SetPlaneFinderEnabledState(bool state)
    {
        _planeFinder.enabled = state;
    }

    public void SetAllGroundPlaneItemsEnabledState(bool state)
    {
        SetPlaneFinderEnabledState(state);
        SetInputListenerEnabledState(state);
        SetAnchorsEnabledState(state);
    }

    public bool IsPlaneFinderEnabled() => _planeFinder.enabled;
}
