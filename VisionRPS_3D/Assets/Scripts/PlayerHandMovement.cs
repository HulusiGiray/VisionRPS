using UnityEngine;
using Mirror;

public class PlayerHandMovement : NetworkBehaviour
{
    public float moveSpeed = 3f; // Hareket hızı

    void Update()
    {
        if (!isLocalPlayer) return; // ❗ Sadece kendi elini kontrol etsin ❗

        float h = Input.GetAxis("Horizontal"); // A ve D tuşları
        float v = Input.GetAxis("Vertical");   // W ve S tuşları

        Vector3 movement = new Vector3(h, v, 0) * moveSpeed * Time.deltaTime;
        transform.position += movement; // Pozisyonu güncelle
    }
}