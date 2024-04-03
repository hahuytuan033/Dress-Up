using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime= 1f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
       StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex+ 1));
    }

    IEnumerator LoadScene(int sceneIndex)
    {
        //player animation

        transition.SetTrigger("Start");

        //chờ
        yield return new WaitForSeconds(transitionTime);

        //Load Scene
        SceneManager.LoadScene(sceneIndex);
    }
}
