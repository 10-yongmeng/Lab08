using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public static float score;
    public Text ScoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        if (transform.position.y >= 4f)
        {
            transform.position = new Vector3(-8.545298f, 4f, 0);
        }
        if (transform.position.y <= -4f)
        {
            transform.position = new Vector3(-8.545298f, -4f, 0);
        }

        ScoreTxt.text = "Score: " + score;  



    }
}
