using UnityEngine;

public class Orange : MonoBehaviour
{
    
    public Animator animator; // Referência ao componente Animator
    public AudioSource somDeColeta; // Referência ao componente AudioSource para o som de coleta

    void Start()
    {
        somDeColeta = GameObject.Find("OrangeSound").GetComponent<AudioSource>(); // Inicializa a variável com o som de coleta
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) // Detecta colisão com o jogador
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.Play("Coletado"); // Toca a animação de coleta
            somDeColeta.Play();        // Toca o som de coleta
            Destroy(gameObject, 0.5f); // Destroi o objeto após 0.5 segundos para permitir que a animação seja vista
            Hud.score += 1;            // Incrementa a pontuação no HUD
        }
    }
}
