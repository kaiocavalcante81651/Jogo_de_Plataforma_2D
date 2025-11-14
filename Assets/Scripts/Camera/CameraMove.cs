using UnityEngine;

public class CameraMove : MonoBehaviour
{

    private GameObject jogador;

    void Start()
    {
        jogador = GameObject.Find("Jogador");
    }

    void Update()
    {
        if (jogador.transform.position.x > transform.position.x)
        {
            transform.position = new Vector3(jogador.transform.position.x, 0, -10);
        }
        else if (jogador.transform.position.x < transform.position.x)
        {
            transform.position = new Vector3(jogador.transform.position.x, 0, -10);
        }
    }
}
