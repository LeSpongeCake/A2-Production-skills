using UnityEngine;

public class playerscript : MonoBehaviour
{
    int movespeed = 10;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * movespeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * movespeed);
        }
    }
}
