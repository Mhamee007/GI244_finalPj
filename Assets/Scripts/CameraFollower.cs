// Lecture Note:
//
// [1] Order of Execution of Event functions: 
// https://docs.unity3d.com/6000.0/Documentation/Manual/execution-order.html 


using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    
     void Update()
     {
         transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
         transform.position = player.transform.position;
         transform.position = player.transform.position + offset;
     }

    void LateUpdate()
    {
       
        transform.position = player.transform.position + offset;
    }
}
