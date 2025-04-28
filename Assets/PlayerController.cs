using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 pos = transform.position;
        pos.x += horizontalInput * 0.1f;
        pos.y += verticalInput * 0.1f;
        transform.position = pos;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "goal")
        {
            SceneManager.LoadScene("omedetou");
        }
    }


}
