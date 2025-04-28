using UnityEngine;
using UnityEngine.SceneManagement; // �V�[���̍ēǂݍ��݂Ɏg��

public class GameOverTrigger : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("�Q�[���I�[�o�[�I");
            // ��F���݂̃V�[���������[�h���ăQ�[�������Z�b�g
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
