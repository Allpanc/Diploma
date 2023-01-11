using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class VRModeSwitcher : MonoBehaviour
{
    public static VRModeSwitcher _singleton;
    private int _activeSceneBuildIndex = 0;
    private int _previousSceneBuildIndex = 0;

    void Awake()
    {
        if (_singleton == null)
        {
            SceneManager.sceneLoaded += LoadedScene;
            _singleton = this;
        }
        else
            Destroy(gameObject);
        DontDestroyOnLoad(this);
    }

    private void LoadedScene(Scene scene, LoadSceneMode mode)
    {
        StopAllCoroutines();
        _activeSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;

        switch (_activeSceneBuildIndex)
        {
            case 0:
                DisableXR();
                break;

            case 1:
                EnableXR();
                break;
        }

        if (_activeSceneBuildIndex != _previousSceneBuildIndex)
        {
            SceneManager.LoadScene(_activeSceneBuildIndex);
            _previousSceneBuildIndex = _activeSceneBuildIndex;
        }
    }

    private void EnableXR() => StartCoroutine(LoadDevice("cardboard", true));
    
    private void DisableXR() => StartCoroutine(LoadDevice("", false));

    IEnumerator LoadDevice(string newDevice, bool enabledState)
    {
        XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        XRSettings.enabled = enabledState;
        Debug.LogWarning("Load Device " + enabledState);
    }
}
