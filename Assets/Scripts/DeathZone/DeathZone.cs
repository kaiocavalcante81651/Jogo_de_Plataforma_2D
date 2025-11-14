using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class DeathZone : MonoBehaviour
{

    public AudioSource somDeMorte; // Referência ao componente AudioSource para o som de morte

    void Start()
    {
        somDeMorte = GameObject.Find("Morte").GetComponent<AudioSource>(); // Inicializa a variável com o som de morte
    }

    void Update()
    {
        if (Hud.lifes == 0) 
        {
            SceneManager.LoadScene("Fase_1");
            Hud.lifes = 3;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            somDeMorte.Play();        // Toca o som de morte
            StartCoroutine(WaitForSeconds(0.7f));
            Hud.score = 0;
            Hud.lifes -= 1;
        }
    }

    private IEnumerator WaitForSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
