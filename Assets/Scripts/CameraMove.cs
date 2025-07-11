using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform playerTr;
    float x;
    float y;
        
    void Update()
    {
        x= Mathf.Clamp(playerTr.position.x, -40, 40);
        y= Mathf.Clamp(playerTr.position.y, -20, 20);
        transform.position = new Vector3(x, y, 0) + Vector3.back;
    }
}
