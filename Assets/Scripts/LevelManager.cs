using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private int currentLevelIndex = 0; // �ndice de la escena actual

    private void Start()
    {
        LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        // Incrementa el �ndice de la escena actual para cargar la siguiente
        currentLevelIndex++;

        // Aseg�rate de que el �ndice no supere la cantidad total de escenas
        if (currentLevelIndex >= SceneManager.sceneCountInBuildSettings)
        {
            // Si has alcanzado el final de las escenas, regresa al primer nivel o realiza otra acci�n (seg�n tu dise�o).
            currentLevelIndex = 0;
        }

        // Carga la siguiente escena seg�n el �ndice actual
        SceneManager.LoadScene(currentLevelIndex);
    }
}
