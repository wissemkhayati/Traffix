using System.Collections;
using UnityEngine;


public class AppView : AppElement
{

    private IEnumerator Start()
    {
        foreach (Path p in app.model.spawner) {
            yield return new WaitForSeconds(2);
            StartCoroutine(app.controller.Engine(p));
        }
    }


    public void OpenScene(string value) {
        app.controller.OpenScene(value);
    }

}
