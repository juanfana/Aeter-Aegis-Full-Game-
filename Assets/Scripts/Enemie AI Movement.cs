using UnityEngine;

public class EnemieAIMovement : MonoBehaviour
{  
    public float speed;

    public Vector2 Flower;
    public Vector2 position;

void Start()
{
        Flower = new Vector2(8.0f, 4.0f);
    
        position = gameObject.transform.position;


}
    // Update is called once per frame
    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;

       transform.position = Vector2.MoveTowards(transform.position, Flower, step);
     

    }
}
