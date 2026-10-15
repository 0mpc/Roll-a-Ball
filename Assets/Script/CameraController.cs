using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Arraste Player para este campo no Inspector
    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        // Calcula a distância inicial entre a câmera e o jogador
        offset = transform.position - player.transform.position;
    }

    // LateUpdate roda depois que tudo se moveu no frame
    private void LateUpdate()
    {
        //A câmera vai para a posição da bola + a distância
        transform.position = player.transform.position + offset;
    }
}