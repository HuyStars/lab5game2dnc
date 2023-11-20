using UnityEngine;

public class tuongtac : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Lấy giá trị đầu vào từ bàn phím
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Tính toán hướng di chuyển
        Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized;

        // Tính toán vị trí mới
        Vector3 newPosition = transform.position + transform.TransformDirection(movement) * speed * Time.deltaTime;

        // Di chuyển đối tượng đến vị trí mới
        transform.position = newPosition;
    }
}