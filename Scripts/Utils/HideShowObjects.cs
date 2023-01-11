using UnityEngine;

public class HideShowObjects : MonoBehaviour
{
    public GameObject[] objectsToHideShow;
    public bool isOpen = true;

    public void SwapObjectsActiveState()
    {
        foreach (GameObject obj in objectsToHideShow)
            obj.SetActive(isOpen);
        isOpen = !isOpen;
    }
}
