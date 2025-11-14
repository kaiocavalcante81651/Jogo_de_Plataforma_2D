using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Flag : MonoBehaviour
{

    public string nextLevel;
    public AudioSource somDeVitoria; // Referência ao componente AudioSource para o som de vitória

    void Start()
    {
        somDeVitoria = GameObject.Find("NextLevel").GetComponent<AudioSource>(); // Inicializa a variável com o som de vitória
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene(nextLevel);
            somDeVitoria.Play();        // Toca o som de vitória
            StartCoroutine(WaitForSeconds(2.5f));
        }
    }

    private IEnumerator WaitForSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(nextLevel);
    }
}
