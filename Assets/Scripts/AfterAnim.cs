using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterAnim : MonoBehaviour
{
    public float animStartTime;
    public float timeLeft = 60f;
    public GameObject Gm;
    void Update()
    {
        animStartTime -= Time.deltaTime;
        if (animStartTime < 0)
        {
           // Gm.GetComponent<GameManager>().TimeStart();
            Gm.GetComponent<ChangeScene>().ChangeToScene(2);
            // GameOver.gameObject.SetActive(true);

        }

        /* public void Play()
         {
             GetComponent(gameObject.animation.Play(animName));
             StartCoroutine(LoadAfterAnim());
         }

         public IEnumerator LoadAfterAnim()
         {
             yield return new WaitForSeconds(animation[animName].Length);
             Application.LoadLevelAsync(levelName);
         }
         */

    }
}
