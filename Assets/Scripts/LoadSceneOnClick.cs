using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour 
{
    public void LoadScene(string main)
    {
        SceneManager.LoadScene(main);
    }
}