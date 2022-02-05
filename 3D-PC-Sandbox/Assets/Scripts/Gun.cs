using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public Text m_Text;

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()            
    {
        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            m_Text.text = string.Format("You gun: " + hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.Takedamage(damage);
            }
        }
    }
}