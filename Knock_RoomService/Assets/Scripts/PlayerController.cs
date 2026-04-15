using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = Vector3.zero;
        if(Input.GetKey(KeyCode.D))
        {
            position.x += 0.1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= 0.1f;
        }
        transform.position += position; 
    } 
}
