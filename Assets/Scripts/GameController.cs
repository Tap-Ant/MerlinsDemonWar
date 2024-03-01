using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void Quit()
    {
        SceneManager.LoadScene(0);
    }

    //TODO this
    public void SkipTurn()
    {
        Debug.Log("Skip Turn");
    }
}
