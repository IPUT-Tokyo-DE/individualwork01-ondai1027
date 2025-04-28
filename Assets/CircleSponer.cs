using UnityEngine;

public class CircleSponer : MonoBehaviour
{
 [SerializeField]GameObject bluecircle;
 [SerializeField]GameObject redcircle;
 [SerializeField]GameObject greencircle;
    float x = -8.93f;
    float x2 = 40f;
    float x3 = 88f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(greencircle, new Vector2(x, 0.44f), Quaternion.identity);
            x += 13f;
        }
        for (int i = 0; i < 3; i++)
        {
            Instantiate(redcircle, new Vector2(x2, 0.44f), Quaternion.identity);
            x2 += 13f;
        }
        for (int i = 0; i < 3; i++)
        {
            Instantiate(bluecircle, new Vector2(x3, 0.44f), Quaternion.identity);
            x3 += 13f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
