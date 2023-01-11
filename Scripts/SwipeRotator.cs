using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeRotator : MonoBehaviour, IDragHandler
{

    [Header("Rotation speed")]
    [SerializeField] float rotationSpeed = 1f;

    [Header("Extra params for enabling physics")]
    [SerializeField] Rigidbody _rotatingRigidBody;

    public void OnDrag(PointerEventData eventData)
    {
        if (!_rotatingRigidBody)
            transform.Rotate(0f, -eventData.delta.x * rotationSpeed * Time.deltaTime, 0f);
        else
            _rotatingRigidBody.AddTorque(new Vector3(0, -eventData.delta.x * rotationSpeed / 50, 0), ForceMode.Acceleration);
    }
}
