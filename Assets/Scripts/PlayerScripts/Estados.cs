using UnityEngine;

public class Estados : MonoBehaviour
{

    [SerializeField] private Animator animator;     // Referência ao componente Animator
    [SerializeField] private Rigidbody2D rb;        // Referência ao componente Rigidbody2D
    [SerializeField] public Movimentos movimentos;  // Referência ao script de Movimentos

    private void Update()
    {
        if (rb.linearVelocityX == 0 && rb.linearVelocityY == 0)
            animator.Play("Parado");
        else if (rb.linearVelocityX != 0 && movimentos.checkFloor) // movimentos.checkFloor importado do script Movimentos.cs
            animator.Play("Correndo");
        else if (!movimentos.checkFloor && rb.linearVelocityY > 0) // movimentos.checkFloor importado do script Movimentos.cs
            animator.Play("Pulando");
        else if (!movimentos.checkFloor && rb.linearVelocityY < 0) // movimentos.checkFloor importado do script Movimentos.cs
            animator.Play("Caindo");
    }
}
