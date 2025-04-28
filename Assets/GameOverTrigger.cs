using UnityEngine;
using UnityEngine.SceneManagement; // シーンの再読み込みに使う

public class GameOverTrigger : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("ゲームオーバー！");
            // 例：現在のシーンをリロードしてゲームをリセット
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
