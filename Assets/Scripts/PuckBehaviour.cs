
using UnityEngine;


namespace PhysicsAssignment
{
    public class PuckBehaviour : MonoBehaviour
    {
        public int PlayerPoints = 0;
        public int AIPoints = 0;

        public GameObject Puck;
        private Rigidbody Puckbody;

        public GameObject AIWins;
        public GameObject PlayerWins;

        public TextMesh AItext;
        public TextMesh PlayerText;

        public float Force = 50f;

        public int CollisionAI = 0;
        public int CollisionPlayer = 0;

        float x = 0.5f;
        float y = 0.5f;
        float z = 0.5f;

        private void Start()
        {
            Puckbody = GetComponent<Rigidbody>();
            //instantiates the playerpoints and Aipoints
            PlayerPoints = 0;
            AIPoints = 0;
        }

        private void OnTriggerEnter(Collider trigger)
        {
            if (trigger.gameObject.tag == "AIGoal")
            {
                AIPoints++;
                Debug.Log("AI scores a goal - " + "AI Points: " + AIPoints);
                gameObject.SetActive(false);
                AItext.text = (AIPoints).ToString();
                
                if (AIPoints == 5) 
                {
                    Debug.Log("AI wins");
                    AIWins.SetActive(true);                     
                }
                else if (AIPoints < 5)
                {
                    Puck.transform.position = new Vector3(1, 1.4f, 1);
                    Puck.SetActive(true);
                }
            }
            else if (trigger.gameObject.tag == "PlayerGoal")
            {
                PlayerPoints++;
                Debug.Log("Player scores a goal - " + "Player Points: " + PlayerPoints);
                gameObject.SetActive(false) ;
                PlayerText.text = (PlayerPoints).ToString();

                if (PlayerPoints == 5)
                {
                    Debug.Log("Player wins");
                    PlayerWins.SetActive(true);                 
                }
                else if (PlayerPoints < 5)
                {
                    Puck.transform.position = new Vector3(1, 1.4f, 1);
                    Puck.SetActive(true);
                }
            }

            if (trigger.gameObject.tag == "1Portal")
            {
                Puck.transform.position = new Vector3(-4.09f, 1.4f, -2.08f);
            }
            else if (trigger.gameObject.tag == "3Portal")
            {
                Puck.transform.position = new Vector3(5.52f, 1.4f, 4.78f);
            }
            else if (trigger.gameObject.tag == "2Portal")
            {
                Puck.transform.position = new Vector3(5.52f, 1.4f, -2.05f);
            }
            else if (trigger.gameObject.tag == "4Portal")
            {
                Puck.transform.position = new Vector3(-4.09f, 1.4f, 4.69f);
            }
        }

        public void ResetPoints()
        {
            PlayerPoints = 0;
            AIPoints = 0;
            AItext.text = "0";
            PlayerText.text = "0";
            CollisionAI = 0;
            CollisionPlayer = 0;
            
        }
        private void Update()
        {
          if (Input.GetKeyDown(KeyCode.R))
            {
                ResetPoints();
                
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            /* x = xForce + x;
             y = yForce + y;
             z = zForce + z;*/

            if (collision.gameObject.name == "PlayerTest")
            {
                Puckbody.AddForce(Vector3.left * Force, ForceMode.Impulse);
                /*CollisionAI = 0;
                CollisionPlayer++;

                if (CollisionPlayer == 2)
                {
                    if (PlayerPoints != 0)
                    {
                        PlayerPoints--;
                    }
                }*/
            }
            else if (collision.gameObject.name == "AITest")
            {
                Puckbody.AddForce(Vector3.right * Force, ForceMode.Impulse);
               /* CollisionPlayer = 0;
                CollisionAI++;

               if (CollisionAI == 2) 
                {
                    if (AIPoints != 0)
                    {
                        AIPoints--;
                    }
                }*/
            }


        }

        private void FixedUpdate()
        {
            /*if ()
            {
                Puckbody.AddForce(Vector3.right * Force, ForceMode.Impulse);
            }*/            
        }

    }
}
