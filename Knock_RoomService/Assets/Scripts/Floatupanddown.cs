using UnityEngine;


public class Floatupanddown : MonoBehaviour
{
    public float amplitude = 0.5f;
    public float frequency = 1f;

    
    Vector2 posOffset = new Vector2();
    Vector2 tempPos = new Vector2();

    void Start()
    {
        posOffset = transform.position; //starting position
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0f) return; //Pause Menu

        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude; //makes the object floagt up and down 
        transform.position = tempPos;
    }
}
