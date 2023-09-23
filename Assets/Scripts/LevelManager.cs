using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private int currentLevelIndex = 0; // Índice de la escena actual

    private void Start()
    {
        LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        // Incrementa el índice de la escena actual para cargar la siguiente
        currentLevelIndex++;

        // Asegúrate de que el índice no supere la cantidad total de escenas
        if (currentLevelIndex >= SceneManager.sceneCountInBuildSettings)
        {
            // Si has alcanzado el final de las escenas, regresa al primer nivel o realiza otra acción (según tu diseño).
            currentLevelIndex = 0;
        }

        // Carga la siguiente escena según el índice actual
        SceneManager.LoadScene(currentLevelIndex);
    }
}
