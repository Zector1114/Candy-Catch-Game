using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyManager : MonoBehaviour
{
    private int candy = 0;
    private float timer = 0f;
    float randomNum;
    int candyChance;

    public GameObject candy1;
    public GameObject candy2;
    public GameObject candy3;
    public GameObject candy4;
    public GameObject candy5;
    public GameObject candy6;

    // Start is called before the first frame update
    void Start()
    {
        randomNum = Random.Range(1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer >= randomNum)
        {
            CandySpawn();
            timer = 0f;
            randomNum = Random.Range(1f, 3f);
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    public void CandySpawn()
    {
        if (candy < 15)
        {
            candyChance = Random.Range(1, 100);

            switch (candyChance)
            {
                case >= 1 and <= 40:
                    Instantiate(candy1, new Vector3(Random.Range(-9f, 9f), 8, 0), Quaternion.identity);
                    break;

                case >= 41 and <= 65:
                    Instantiate(candy2, new Vector3(Random.Range(-9f, 9f), 8, 0), Quaternion.identity);
                    break;

                case >= 66 and <= 80:
                    Instantiate(candy3, new Vector3(Random.Range(-9f, 9f), 8, 0), Quaternion.identity);
                    break;

                case >= 81 and <= 90:
                    Instantiate(candy4, new Vector3(Random.Range(-9f, 9f), 8, 0), Quaternion.identity);
                    break;

                case >= 91 and <= 97:
                    Instantiate(candy5, new Vector3(Random.Range(-9f, 9f), 8, 0), Quaternion.identity);
                    break;

                case >= 98 and <= 100:
                    Instantiate(candy6, new Vector3(Random.Range(-9f, 9f), 8, 0), Quaternion.identity);
                    break;
            }

            candy++;
        }
        else
        {
            // Game Ends
        }
    }
}
