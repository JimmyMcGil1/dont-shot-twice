using UnityEngine;

public class FlashLightScript : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] float light_rotate_speed;
    Vector2 currMousePoint;
    [SerializeField] float allignAngle;
 



    // Update is called once per frame
    void Update()
    {
        currMousePoint = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position ;

        float angle = Mathf.Atan2(currMousePoint.y, currMousePoint.x)  * Mathf.Rad2Deg  + allignAngle;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, light_rotate_speed * Time.deltaTime);
    }
}
