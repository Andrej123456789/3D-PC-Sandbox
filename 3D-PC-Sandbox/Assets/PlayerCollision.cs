using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Text m_Text;

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.collider.name);

        m_Text.text = string.Format("You touch: " + collision.collider.name);
    }
}