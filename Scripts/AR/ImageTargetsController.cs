using UnityEngine;
using Vuforia;

public class ImageTargetsController : MonoBehaviour
{

    [SerializeField] private ImageTargetBehaviour[] _targets;

    public void SetTargetsEnabledState(bool state)
    {
        foreach (ImageTargetBehaviour targetBehaviour in _targets)
            targetBehaviour.enabled = state;
    }
}
