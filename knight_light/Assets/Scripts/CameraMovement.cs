using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothFactor;

    // Update is called once per frame
    private void Update()
    {
        Vector3 newPosition = new Vector3(target.position.x, target.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor*Time.deltaTime);
    }
}
