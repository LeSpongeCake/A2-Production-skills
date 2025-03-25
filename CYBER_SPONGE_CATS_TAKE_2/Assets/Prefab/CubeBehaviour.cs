using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            this.GetComponent<Renderer>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.GetComponent<Renderer>().enabled = true;
        }
    }
}
