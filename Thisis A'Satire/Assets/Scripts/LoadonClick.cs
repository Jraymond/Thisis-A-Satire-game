using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadonClick : MonoBehaviour {

	public void loadscene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
