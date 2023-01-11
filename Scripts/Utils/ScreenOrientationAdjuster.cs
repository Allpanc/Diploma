using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenOrientationAdjuster : MonoBehaviour
{
    void Awake() => SceneManager.sceneLoaded += AdjustScreenOrientation;

    private void AdjustScreenOrientation(Scene scene, LoadSceneMode mode)
    {
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 01:
                SetAuto();
                break;

            case 2:
                SetLandscape();
                break;
        }
    }

    public void SetPortrait() => Screen.orientation = ScreenOrientation.Portrait;
    public void SetLandscape() => Screen.orientation = ScreenOrientation.Landscape;
    public void SetAuto() => Screen.orientation = ScreenOrientation.AutoRotation;
}
