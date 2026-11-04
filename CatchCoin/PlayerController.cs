using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public int score = 0;

    void Update()
    {
        // Gerak kiri dan kanan dengan tombol A/D atau panah keyboard
        float moveInput = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(moveInput * speed * Time.deltaTime, 0, 0);

        // Batasi gerakan agar player tidak keluar layar
        float clampedX = Mathf.Clamp(transform.position.x, -7.5f, 7.5f);
        transform.position = new Vector3(clampedX, transform.position.y, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Cek jika objek yang menyentuh player memiliki tag "Coin"
        if (collision.CompareTag("Coin"))
        {
            score += 10;
            Debug.Log("Skor Saat Ini: " + score);
            Destroy(collision.gameObject); // Hapus koin yang tertangkap
        }
    }
}