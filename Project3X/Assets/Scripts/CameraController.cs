using UnityEngine;

namespace Project3X
{
    public class CameraController : MonoBehaviour
    {

        [SerializeField] private float panSpeed = 2.5f;
         [SerializeField]  private float minCameraOrthoSize = 100;
        [SerializeField] private float maxCameraOrthoSize = 300;

        private float zoomLevel = 1;
        private bool inverseZoom = false;

        private void Update()
        {
            ChangePosition();
            ChangeZoom();
        }

        private void ChangePosition()
        {

            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            {
                float movementFactor = Mathf.Lerp(maxCameraOrthoSize, minCameraOrthoSize, zoomLevel);
                float distance = panSpeed * Time.deltaTime;
                Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0).normalized;

                float dampingFactor = Mathf.Max(Mathf.Abs(Input.GetAxis("Horizontal")), Mathf.Abs(Input.GetAxis("Vertical")));

                transform.Translate(distance * direction * dampingFactor * movementFactor);

                ClampCameraPan();
            }

        }

        private void ClampCameraPan()
        {
            Vector3 position = transform.position;


            position.x = Mathf.Clamp(transform.position.x, -GalaxyManager.instance.maximumRadius, GalaxyManager.instance.maximumRadius);
            position.y = Mathf.Clamp(transform.position.y, -GalaxyManager.instance.maximumRadius, GalaxyManager.instance.maximumRadius);


            transform.position = position;
        }

        private void ChangeZoom()
        {

            if (Input.GetAxis("Mouse ScrollWheel") != 0)
            {
                if (inverseZoom)
                {
                    zoomLevel = Mathf.Clamp01(zoomLevel - Input.GetAxis("Mouse ScrollWheel"));
                }
                else
                {
                    zoomLevel = Mathf.Clamp01(zoomLevel + Input.GetAxis("Mouse ScrollWheel"));
                }
            }

            float zoom = Mathf.Lerp(maxCameraOrthoSize, minCameraOrthoSize, zoomLevel);
            Camera.main.orthographicSize = zoom;
        }

    }
}
