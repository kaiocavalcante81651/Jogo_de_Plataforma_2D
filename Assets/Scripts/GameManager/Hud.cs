using TMPro;
using UnityEngine;

public class Hud : MonoBehaviour
{

    public static int score;           // Variável que guarda a pontuação do jogador
    private TextMeshProUGUI scoreText; // Referência ao componente TextMeshProUGUI para exibir a pontuação
    public static int lifes = 3;       // Variável que guarda o número de vidas do jogador
    private TextMeshProUGUI lifesText; // Referência ao componente TextMeshProUGUI para exibir as vidas

    void Start()
    {
        DontDestroyOnLoad(gameObject); // Mantém o HUD entre as cenas
    }

    void Update()
    {
        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>(); // Encontra o componente de texto na cena
        scoreText.text = score.ToString();                                    // Atualiza o texto com a pontuação atual
        lifesText = GameObject.Find("Vida").GetComponent<TextMeshProUGUI>();  // Encontra o componente de texto na cena
        lifesText.text = lifes.ToString();                                    // Atualiza o texto com o número de vidas atual
    }
}
