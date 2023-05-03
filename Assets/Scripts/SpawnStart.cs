
using UnityEngine;
using UnityEngine.UI;


namespace PhysicsAssignment
{
    public class SpawnStart : MonoBehaviour
    {
        //Declaring public GameObjects in order to assign an object in the inspector
        public GameObject puck;
        public GameObject player;
        public GameObject AI;
        public GameObject StartScreen;
        public GameObject PlayerScreen;
        public GameObject AIScreen;

        public Text starttext;

        public float TimeRemaining = 5;
        public bool TimeIsRunning = false;
        
        public void SpawnPuck()
        {
            //makes the puck visible
            puck.SetActive(true);
        }

        public void SpawnPlayer()
        {
            //makes the Player visible
            player.SetActive(true);
        }

        public void SpawnAI()
        {
            //makes the AI visible
            AI.SetActive(true);
        }

        public void Reset()
        {
            //sets the player, AI and puck back to their starting positions
            player.transform.position = new Vector3(8.05f, 1.4f, 1.3f);
            AI.transform.position = new Vector3(-6.8f, 1.4f, 1.05f);
            puck.transform.position = new Vector3(1, 1.4f, 1);

            //makes the puck visible and ensures that the UI screens aren't visible
            puck.SetActive(true);
            PlayerScreen.SetActive(false);
            AIScreen.SetActive(false);

            //this code allows SpawnStart to access the PuckBehaviour script
            GameObject puckObject = GameObject.Find("PuckTest");
            PuckBehaviour puckBehaviour = puckObject.GetComponent<PuckBehaviour>();
            puckBehaviour.ResetPoints();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                //if the button is pressed the Reset function is callled
                Reset();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                //if Space is pressed TimeIsRunning is set to true
                TimeIsRunning = true;
            }

            if (TimeIsRunning == true)
            {
                //if TimeIsRunning is true then the code will run
                if (TimeRemaining > 0)
                {
                    //if the timer is not finished then the code will run
                    Debug.Log(TimeRemaining); //displays time in debug
                    TimeRemaining -= Time.deltaTime; //decreases the timeramount
                    starttext.text = (TimeRemaining).ToString("0");//displays the timer in text
                }
                else
                {
                    //if the timer hits 0 then the following code is run
                    TimeRemaining = 0;
                    TimeIsRunning = false;
                    Debug.Log("Timer is finished");
                    //Calls the SpawnPuck, SpawnAI and SpawnPlayer functions
                    SpawnPuck();
                    SpawnAI();
                    SpawnPlayer();
                    //sets the UI start screen to false
                    StartScreen.SetActive(false);
                }

            }
        }
    }
}
