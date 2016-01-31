using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScooperController : MonoBehaviour {

    public float moveSpeed;

    void Start()
    {
        PoopCounter.turdsRemaining = 7;
    }

    // Update is called once per frame
    void Update()
    {
        var x = GetComponent<Rigidbody2D>().position.x;
        var y = GetComponent<Rigidbody2D>().position.y;

        if (Input.GetAxis("Vertical") > 0)
        {
            y += moveSpeed;
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            y -= moveSpeed;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            x -= moveSpeed;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            x += moveSpeed;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        GetComponent<Rigidbody2D>().position = new Vector2(x, y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        PoopCounter.turdsRemaining -= 1;
        Debug.Log(PoopCounter.turdsRemaining);

        if (PoopCounter.turdsRemaining == 0)
        {
            var persistentDataFinder = GameObject.Find("PersistentData");
            var persistentData = persistentDataFinder.GetComponent<PersistentDataScript>();

            //Consider the poo scooped
            persistentData.IsKittyLitterClean = true;

            SceneManager.LoadScene("Bedroom");
        }
    }
}
