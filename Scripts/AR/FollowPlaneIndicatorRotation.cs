using UnityEngine;
using Vuforia;

public class FollowPlaneIndicatorRotation : MonoBehaviour
{
    [SerializeField] private float _startRotationOffset;
    private Transform _planeIndicatorTransform;

    void Start()
    {
        AnchorBehaviour anchor = FindObjectOfType<AnchorBehaviour>();

        if (anchor.transform.GetComponentInChildren<LookAtCamera>() != null)
            _planeIndicatorTransform = anchor.GetComponentInChildren<LookAtCamera>().transform;

        float targetRotationY = _planeIndicatorTransform.localEulerAngles.y + _startRotationOffset;
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, targetRotationY, transform.localEulerAngles.z);
    }
}
