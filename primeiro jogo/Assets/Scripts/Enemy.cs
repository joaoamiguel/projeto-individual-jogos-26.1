using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D enemy;
    private GameObject player;
    private Animator animator;

    [SerializeField]
    private float speed = 1.5f;

    private Vector2 movement;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Vector2 direction = (player.transform.position - transform.position).normalized;

        movement = direction;

        enemy.MovePosition(enemy.position + direction * speed * Time.fixedDeltaTime);

        animator.SetFloat("InputX", movement.x);
        animator.SetFloat("InputY", movement.y);
    }
}