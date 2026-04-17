using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    public static void Die() {
        SceneManager.LoadScene(2);
    }

}
