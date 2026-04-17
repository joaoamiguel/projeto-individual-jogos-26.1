using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    private Rigidbody2D enemy;
    private GameObject player;

    [SerializeField]
    private float speed = 1.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player =  GameObject.FindGameObjectWithTag("Player");
        enemy =  GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Swarm();
    }

    private void Swarm()
    {
        transform.position = Vector2.MoveTowards(transform.position,
                                            player.transform.position,
                                        speed * Time.deltaTime);
    }
}
