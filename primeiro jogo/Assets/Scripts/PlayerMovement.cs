using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody2D rb;
    AudioSource audio;
    public float speed;
    public static int player_health = 1;
    private Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        animator.SetBool("IsRunning", true);
        
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
        animator.SetFloat("InputX", moveHorizontal);
        animator.SetFloat("InputY", moveVertical);
        
        if (GameController.gameOver == true)
        {
            UIController.StopTimer();
            EndGame.Die();
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coletavel")
        {
            audio.Play();
            GameController.Collect();
            SpawnerController spawner = FindObjectOfType<SpawnerController>();
            spawner.SpawnFood();
            
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            player_health--;
        }
    }
}
