using UnityEngine;

/// <summary>
/// CameraFollowerV2 class is responsible for following the player with a certain offset.
/// And also support Camera view switching including
/// 1. Rear view อยู่ด้านหลังรถ
/// 2. Front view อยู่ด้านหน้าตรงกระจกรถ
/// 3. Front view 2 อยู่ด้านหน้าตรงกระโปรงรถ
/// ใช้ Keyboard Key "C" เพื่อสลับ camera view เวียนไปเรื่อยๆ จาก 1 => 2 => 3 => 1 => 2 => ...
/// </summary>
public class CameraFollowerV2 : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    void Update()
    {
        // Student code starts here ...
        // handle input and switch camera view
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
