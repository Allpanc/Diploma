using UnityEngine;

public class ARMenuGUIController : MonoBehaviour
{
    [SerializeField] GameObject _dvgupsLogo;
    [SerializeField] GameObject _base;
    [SerializeField] Canvas _showInformationCanvas;
    [SerializeField] Canvas _instituteDisplayCanvas;
    [SerializeField] Canvas _homeCanvas;


    public void OnInformationButtonClick()
    {
        _base.SetActive(true);
        _dvgupsLogo.SetActive(false);
        _showInformationCanvas.enabled = false;
        _instituteDisplayCanvas.gameObject.SetActive(true);
        _instituteDisplayCanvas.enabled = false;
        _homeCanvas.gameObject.SetActive(true);
    }

    public void OnHomeButtonClick()
    {
        _base.SetActive(false);
        _dvgupsLogo.SetActive(true);
        _showInformationCanvas.enabled = true;
        _instituteDisplayCanvas.gameObject.SetActive(false);
        _instituteDisplayCanvas.enabled = false;
        _homeCanvas.gameObject.SetActive(false);
    }
}
