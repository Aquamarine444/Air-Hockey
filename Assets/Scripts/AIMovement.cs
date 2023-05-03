
using UnityEngine;


namespace PhysicsAssignment
{
    public class AIMovement : MonoBehaviour
    {
        RaycastHit hit;

        private Rigidbody AIbody;

        public float speed;
        private float vertical;
        private float horizontal;

        public Transform target;
        public float Speed = 0.05f;
        public float step = 0.05f;
        public int AIForce = 4;

        public GameObject Puck;

        void Start()
        {
            AIbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (Puck.transform.position.x <= 0)
                //Code will only run if the puck's x position is lower or equal to zero
            {
                //transform.Translate(Vector3.right * Speed );
                //Vector3 direction = target.position - transform.position;
                //Vector3.Normalize(direction * 5f); //increases the direction speed by 5
                //GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse); 
                AIbody.velocity = (target.position - AIbody.transform.position).normalized * AIForce ;

                /* Ray rat = new Ray(transform.position, transform.forward);
                 if (Physics.Raycast(rat, 7))
                 {
                     transform.Translate(Vector3.Normalize(target.position - transform.position) * step);
                 }*/
            }
        }
        void FixUpdate()
        {
            //transform.Translate(Vector3.Normalize(target.position - transform.position) * step);
        }

    }
}

