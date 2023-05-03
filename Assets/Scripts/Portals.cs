using UnityEngine;

namespace PhysicsAssignment
{
    public class Portals : MonoBehaviour
    {
        private int PortalNumb;

        public GameObject Portal1;
        public GameObject Portal2;
        public GameObject Portal3;
        public GameObject Portal4;

        public bool TimerSpawn = false;
        public bool TimerDisappear = false;
        public float TimeBeforeSpawn;
        public float TimeBeforeDisappear; //15-20

        void Start()
        {
            
        }


       void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TimerSpawn = true;
                TimeBeforeSpawn = UnityEngine.Random.Range(10, 25);
                TimeBeforeDisappear = UnityEngine.Random.Range(15, 20);
                PortalNumb = UnityEngine.Random.Range(1, 6);
                Debug.Log("Spawns in " + TimeBeforeSpawn);
            }

            if (TimerSpawn == true)
            {
                if (TimeBeforeSpawn > 0)
                {
                    TimeBeforeSpawn -= Time.deltaTime;
                }
                else
                {
                    TimeBeforeSpawn = 0;
                    TimerSpawn = false;
                    if (PortalNumb == 1)
                    {
                        //Portal 1
                        Instantiate(Portal1, new Vector3(5.52f, 1.7f, 6.38f), Quaternion.identity);
                        //Portal 3
                        Instantiate(Portal3, new Vector3(-4.09f, 1.7f, -3.68f), Quaternion.identity);
                    }
                    else if (PortalNumb == 2)
                    {
                        //Portal 2
                        Instantiate(Portal2, new Vector3(-4.09f, 1.7f, 6.19f), Quaternion.identity);
                        //Portal 4
                        Instantiate(Portal4, new Vector3(5.52f, 1.7f, -3.55f), Quaternion.identity);
                    }
                    else if (PortalNumb == 3)
                    {
                        //Portal 1
                        Instantiate(Portal1, new Vector3(5.52f, 1.7f, 6.38f), Quaternion.identity);
                        //Portal 2
                        Instantiate(Portal2, new Vector3(-4.09f, 1.7f, 6.19f), Quaternion.identity);
                    }
                    else if (PortalNumb == 4)
                    {
                        //Portal 3
                        Instantiate(Portal3, new Vector3(-4.09f, 1.7f, -3.68f), Quaternion.identity);
                        //Portal 4
                        Instantiate(Portal4, new Vector3(5.52f, 1.7f, -3.55f), Quaternion.identity);
                    }
                    else if (PortalNumb == 5)
                    {
                        //Portal 1
                        Instantiate(Portal1, new Vector3(5.52f, 1.7f, 6.38f), Quaternion.identity);
                        //Portal 4
                        Instantiate(Portal4, new Vector3(5.52f, 1.7f, -3.55f), Quaternion.identity);
                    }
                    else if (PortalNumb == 6)
                    {
                        //Portal 2
                        Instantiate(Portal2, new Vector3(-4.09f, 1.7f, 6.19f), Quaternion.identity);
                        //Portal 3
                        Instantiate(Portal3, new Vector3(-4.09f, 1.7f, -3.68f), Quaternion.identity);
                    }
                    TimerDisappear = true;
                    Debug.Log("Disappears in " + TimeBeforeDisappear);
                }
            }

                if (TimerDisappear == true)
                {

                    if (TimeBeforeDisappear > 0)
                    {
                        TimeBeforeDisappear -= Time.deltaTime;
                    }
                    else
                    {
                        TimeBeforeDisappear = 0;
                        TimerDisappear = false;
                        TimerSpawn = false;
                    PortalNumb = UnityEngine.Random.Range(1, 6);
                }
                }

            
        }
    }
}


