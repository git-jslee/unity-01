using UnityEngine;

public class Translate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec);
    }
}
