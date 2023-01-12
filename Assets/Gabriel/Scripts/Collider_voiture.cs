using UnityEngine;
using TMPro;

public class Collider_voiture : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public GameObject bagnole;
    public Collider collid;
    bool collide;
    public string tagToCollider;
    public Rigidbody rgbd;
    public int monScore = 0;

    public TextMeshProUGUI monTexte;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        collide = false;

        monTexte.text = "Score : " + monScore.ToString();
    }

    private void OnCollisionEnter(Collision collisioN)
    {
        if (collisioN.transform.gameObject.GetComponent<Ennemi_deplacement>() != null)
        {
            if (collisioN.transform.gameObject.GetComponent<Ennemi_deplacement>().toucher == false)
            {
                monScore++;
                collisioN.transform.gameObject.GetComponent<Ennemi_deplacement>().toucher = true;
            }
        }

    }
}
