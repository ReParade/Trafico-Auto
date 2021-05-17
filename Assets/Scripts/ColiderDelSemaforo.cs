using UnityEngine;

namespace DefaultNamespace
{
    public class ColiderDelSemaforo : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D auto)
        {
            if (auto.gameObject.CompareTag("Carro"))
            {
                Debug.Log("Un auto paso el semaforo");
                auto.gameObject.GetComponent<Auto>().Detener();
            }
        }
    }
}