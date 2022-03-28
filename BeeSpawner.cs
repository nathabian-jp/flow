using UnityEngine;
using System.Collections;

// Spawns a given prefab occasionally at a random x position
public class BeeSpawner: MonoBehaviour
{

    // The object we want to spawn
    public GameObject bee;
    // Spawn every 3 seconds
    public float delay = 3f;
    public float randomSpawn = 0f;

    // How much time has currently elapse?
    float time = 0f;

    // Do some error-checking
    void Start()
    {
        if (bee == null)
        {
            Debug.LogError("Missing a spawn type in Spawner");
            Destroy(this);
        }
        else {
            // Spawn the first one immediately
            time = delay;
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        // We've completed our delay, so spawn and reset the timer
        if (time >= delay)
        {
            // Subtracting rather than setting to zero keeps us from losing the little bit of time
            //  if the time isn't exactly the delay
            time -= delay;

            // Choose a random y (that's close to the center so we don't have to worry about hanging
            //  off the screen
            float posY = Random.Range(-randomSpawn, randomSpawn);


            // Create our new item
            GameObject spawn = Instantiate(bee) as GameObject;
            // Give it the correct position
            spawn.transform.position = new Vector3(transform.position.x, posY, 0);
            // Give it a semi-random downward push
            //spawn.rigidbody2D.AddForce(new Vector2(0, Random.Range (-50, -100)));

            // Now, make it a little harder
            delay += Random.Range(0.1f, 0.5f);
        }
    }
}