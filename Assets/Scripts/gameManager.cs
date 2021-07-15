using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    public GameObject RusherType;
    public GameObject rusherPos1;
    public GameObject rusherPos2;
    public GameObject rusherPos3;
    public GameObject rusherPos4;

    public GameObject GuardType;
    public GameObject guardPos1;
    public GameObject guardPos2;
    public GameObject guardPos3;
    public GameObject guardPos4;


    public GameObject rusheryLocator;
    public float timer = 0f;
    public float timePeriod1 = 30f;
    public bool tp1RusherGenerated = false;
    public float subTimePeriod1 = 45f;
    public bool subtp1Generated = false;

    public float timePeriod2 = 60f;
    public bool tp2RusherGenerated = false;
    public float subTimePeriod2 = 80f;
    public bool subtp2Generated = false;

    public float timePeriod3 = 90f;
    public bool tp3RusherGenerated = false;
    public float subTimePeriod3 = 115f;
    public bool subtp3Generated = false;

    public float timePeriod4 = 120f;
    public bool tp4RusherGenerated = false;


    public int dice = 0;
    // Start is called before the first frame update

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timePeriod1)
        {
            if (!tp1RusherGenerated)
            {
                GameObject rusher1 = Instantiate(RusherType, rusherPos1.transform.position, Quaternion.identity);
                GameObject rusher2 = Instantiate(RusherType, rusherPos2.transform.position, Quaternion.identity);
                GameObject rusher3 = Instantiate(RusherType, rusherPos3.transform.position, Quaternion.identity);
                GameObject rusher4 = Instantiate(RusherType, rusherPos4.transform.position, Quaternion.identity);

                tp1RusherGenerated = true;
            }
            if (timer >= subTimePeriod1 && timer < timePeriod2)
            {
                if (!subtp1Generated)
                {
                    dice = Random.Range(1, 5);
                    if (dice > 1 && dice <= 2)
                    {
                        GameObject newGuard = Instantiate(GuardType, guardPos1.transform.position, Quaternion.identity);
                    }
                    else if (dice > 2 && dice <= 3)
                    {
                        GameObject newGuard = Instantiate(GuardType, guardPos2.transform.position, Quaternion.identity);
                    }
                    else if (dice > 3 && dice <= 4)
                    {
                        GameObject newGuard = Instantiate(GuardType, guardPos3.transform.position, Quaternion.identity);
                    }
                    else
                    {
                        GameObject newGuard = Instantiate(GuardType, guardPos4.transform.position, Quaternion.identity);
                    }
                    subtp1Generated = true;
                }
            }
        }
        if (timer >= timePeriod2)
        {
            if (!tp2RusherGenerated)
            {
                GameObject rusher1 = Instantiate(RusherType, rusherPos1.transform.position, Quaternion.identity);
                GameObject rusher2 = Instantiate(RusherType, rusherPos2.transform.position, Quaternion.identity);
                GameObject rusher3 = Instantiate(RusherType, rusherPos3.transform.position, Quaternion.identity);
                GameObject rusher4 = Instantiate(RusherType, rusherPos4.transform.position, Quaternion.identity);

                tp2RusherGenerated = true;
            }
            if (timer >= subTimePeriod2 && timer < timePeriod3)
            {
                if (!subtp2Generated)
                {
                    dice = Random.Range(1, 5);
                    if (dice > 1 && dice <= 2)
                    {
                        GameObject newGuard = Instantiate(GuardType, guardPos1.transform.position, Quaternion.identity);
                    }
                    else if (dice > 2 && dice <= 3)
                    {
                        GameObject newGuard = Instantiate(GuardType, guardPos2.transform.position, Quaternion.identity);
                    }
                    else if (dice > 3 && dice <= 4)
                    {
                        GameObject newGuard = Instantiate(GuardType, guardPos3.transform.position, Quaternion.identity);
                    }
                    else
                    {
                        GameObject newGuard = Instantiate(GuardType, guardPos4.transform.position, Quaternion.identity);
                    }
                    subtp2Generated = true;
                }
            }
        }
        if (timer >= timePeriod3)
        {
            if (!tp3RusherGenerated)
            {
                GameObject rusher1 = Instantiate(RusherType, rusherPos1.transform.position, Quaternion.identity);
                GameObject rusher2 = Instantiate(RusherType, rusherPos2.transform.position, Quaternion.identity);
                GameObject rusher3 = Instantiate(RusherType, rusherPos3.transform.position, Quaternion.identity);
                GameObject rusher4 = Instantiate(RusherType, rusherPos4.transform.position, Quaternion.identity);

                tp3RusherGenerated = true;
            }
            if (timer >= subTimePeriod3 && timer < timePeriod4)
            {
                if (!subtp3Generated)
                {
                    dice = Random.Range(1, 5);
                    if (dice > 1 && dice <= 2)
                    {
                        GameObject newGuard = Instantiate(GuardType, guardPos1.transform.position, Quaternion.identity);
                    }
                    else if (dice > 2 && dice <= 3)
                    {
                        GameObject newGuard = Instantiate(GuardType, guardPos2.transform.position, Quaternion.identity);
                    }
                    else if (dice > 3 && dice <= 4)
                    {
                        GameObject newGuard = Instantiate(GuardType, guardPos3.transform.position, Quaternion.identity);
                    }
                    else
                    {
                        GameObject newGuard = Instantiate(GuardType, guardPos4.transform.position, Quaternion.identity);
                    }
                    subtp3Generated = true;
                }
            }
        }
        if (timer >= timePeriod4)
        {
            if (!tp4RusherGenerated)
            {
                GameObject rusher1 = Instantiate(RusherType, rusherPos1.transform.position, Quaternion.identity);
                GameObject rusher2 = Instantiate(RusherType, rusherPos2.transform.position, Quaternion.identity);
                GameObject rusher3 = Instantiate(RusherType, rusherPos3.transform.position, Quaternion.identity);
                GameObject rusher4 = Instantiate(RusherType, rusherPos4.transform.position, Quaternion.identity);

                tp4RusherGenerated = true;
            }
        }

        if (timer >= 150f)
        {
            timer = 0;
            tp1RusherGenerated = false;
            subtp1Generated = false;

            tp2RusherGenerated = false;
            subtp2Generated = false;

            tp3RusherGenerated = false;
            subtp3Generated = false;

            tp4RusherGenerated = false;
}
    }

    
}
