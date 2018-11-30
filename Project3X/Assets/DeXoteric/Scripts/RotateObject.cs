using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private enum RotationAxis { X, Y, Z }

    private enum RotationDirection { Positive, Negative }

    [SerializeField] private RotationAxis rotationAxis;
    [SerializeField] private RotationDirection rotationDirection;
    [SerializeField] [Tooltip("Degree per second.")] private float rotationSpeed;

    private Vector3 rotation;
    private float direction;

    private void Start()
    {
        switch (rotationAxis)
        {
            case RotationAxis.X:
                rotation = new Vector3(rotationSpeed, 0f, 0f);
                break;

            case RotationAxis.Y:
                rotation = new Vector3(0f, rotationSpeed, 0f);
                break;

            case RotationAxis.Z:
                rotation = new Vector3(0f, 0f, rotationSpeed);
                break;

            default:
                break;
        }

        switch (rotationDirection)
        {
            case RotationDirection.Positive:
                direction = 1;
                break;

            case RotationDirection.Negative:
                direction = -1;
                break;

            default:
                break;
        }
    }

    private void Update()
    {
        transform.Rotate(rotation * direction * Time.deltaTime);
    }
}