using UnityEngine;

public class destroymeteorgeo : MonoBehaviour
{
    // Start is called before the first frame update

   

    private void Update()
    {

        


        float mycordsf = (transform.position.x  + 40);

        if ((mycordsf) < GameObject.Find("Gamemanager").GetComponent<Transform>().position.x)
        {
            Destroy(gameObject);
        }
    }
}
