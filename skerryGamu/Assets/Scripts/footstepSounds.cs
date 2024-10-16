using UnityEngine;

public class FootstepsSounds : MonoBehaviour
{
    public AudioSource foot1, foot2;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                foot1.enabled = false;
                foot2.enabled = true;
            }
            else
            {
                foot1.enabled = true;
                foot2.enabled = false;
            }
        }
        else
        {
            foot1.enabled = false;
            foot2.enabled = false;
        }
    }
}