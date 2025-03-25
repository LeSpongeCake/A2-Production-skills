using UnityEngine;

public class Instantiate_Script : MonoBehaviour
{

    public GameObject Cube;
    private GameObject newInstance;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            CreatePrefab();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Destroy(newInstance);
        }
    }

    public void CreatePrefab()
    {
        newInstance = Instantiate(Cube);
    }
}
