using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaer : MonoBehaviour
{
    public void loadScene(string nomeDaCena)
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}
