using UnityEngine;

public class Movimentos : MonoBehaviour
{
    public float velocidade = 5f;
    public float forcaPulo = 20f;
    public bool checkFloor; // Variável exportada para o script Estados.cs
    [SerializeField] private Rigidbody2D rb;                 // Referência ao componente Rigidbody2D
    [SerializeField] private SpriteRenderer spriteRenderer;  // Referência ao componente SpriteRenderer
    public AudioSource somDePulo; // Referência ao componente AudioSource para o som de pulo

    void Start()
    {
        somDePulo = GameObject.Find("JumpSound").GetComponent<AudioSource>(); // Inicializa a variável com o som de pulo
    }

    void Update()
    {
        Mover();
        Pular();
    }

    private void Mover()
    {
        // Captura a entrada do teclado: -1 (esquerda) até 1 (direita)
        float input = Input.GetAxis("Horizontal");

        // Realiza o movimento do jogador
        rb.linearVelocity = new Vector2(input * velocidade, rb.linearVelocityY);

        // Verifica a direção do movimento para virar o sprite
        if (input < 0)
        {
            // Virar para a esquerda
            spriteRenderer.flipX = true;
        }
        else if (input > 0)
        {
            // Virar para a esquerda
            spriteRenderer.flipX = false;
        }
    }

    private void Pular()
    {
        if (Input.GetButtonDown("Jump") && checkFloor)
        {
            rb.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
            somDePulo.Play();
            checkFloor = false;
        }
    }


    // Detecta colisão com o chão
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            checkFloor = true;
        }
    }
}
