using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AppController : AppElement
{

   public IEnumerator Engine(Path path) {

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2, path.wave));

            if (path.cars.Count < path.maximumCarIsWaiting)
            {

                CarApplication c = Instantiate(Resources.Load<CarApplication>("Car"));
                c.model.id = Random.Range(0, 99);
                c.model.path = path;
                c.model.flag = path.flag;

                path.cars.Add(c.model.id);
            }
        }
    }



    public void OpenScene(string value)
    {
        SceneManager.LoadScene(value);
    }


}

