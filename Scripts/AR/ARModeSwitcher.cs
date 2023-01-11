using UnityEngine;

public class ARModeSwitcher : MonoBehaviour
{
    #region "Fields"

    [SerializeField] private ImageTargetsController _imageTargetsController;
    [SerializeField] private GroundPlaneController _groundPlaneController;

    public enum ARMode
    {
        Image = 0,
        Plane = 1
    }

    public static ARMode _currentARMode = ARMode.Image;
    #endregion

    public void SwitchARModes(int modeValue)
    {
        if ((ARMode)modeValue == _currentARMode)
            return;

        _currentARMode = modeValue == 0 ? ARMode.Image : ARMode.Plane;
        bool state = _currentARMode == 0 ? true : false;

        _imageTargetsController.SetTargetsEnabledState(state);
        _groundPlaneController.SetAllGroundPlaneItemsEnabledState(!state);

        Debug.LogWarning("AR mode switched, plane finder enabled: " + !state);
        Debug.LogWarning("Current AR mode: " + _currentARMode);
    }
}
