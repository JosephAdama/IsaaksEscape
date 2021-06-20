using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;


public class applethrower : MonoBehaviour
{
    public LayerMask UI;
    public Transform wapeonspot;
    public GameObject apple;
    public GameObject pickupapple;
    public GameObject applethrow;
    public TextMeshProUGUI appleinventory;
    public Transform playerarmholder;
    RaycastHit2D hit;
    public static bool candestroypolice;
    public GameObject ui;

    Vector3 targetpoint;

    Rigidbody2D rb;

    public float Force;
    public float upwardforce;
    string inv;

    Vector2 touchpos;
    bool eventsystem;

    float dubbletap;
   

    public int inventory;
    int TapCount;
    public float MaxDubbleTapTime;
    float newtime;


    

    private void Start()
    {
        inventory = 0;
        candestroypolice = false;
        TapCount = 0;
    }

    private void Update()
    {




        


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchpos = Camera.main.ScreenToWorldPoint(touch.position);
            if (EventSystem.current.IsPointerOverGameObject(touch.fingerId))
            {
                
                Eventtrue(true);
            }
            else
            {
                Eventtrue(false);
            }
            


        }


        
        if(Input.touchCount > 0)
        {
            Touch dubtaptouch = Input.GetTouch(0);
           
            if(dubtaptouch.phase == TouchPhase.Ended && !EventSystem.current.IsPointerOverGameObject(dubtaptouch.fingerId))
            {

                        
                TapCount += 1;
            }

            if(TapCount == 1)
            {
                newtime = Time.time + MaxDubbleTapTime;
            }
            else if(TapCount == 2 && Time.time <= newtime)
            {
                Debug.Log("Dubble");
                Throw();

                TapCount = 0;
            } 



        }
        if (Time.time > newtime)
        {
            TapCount = 0;
        }







        Vector2 raycastPosition = touchpos;
        hit = Physics2D.Raycast(raycastPosition, Vector2.zero);
  
        
        
        rb = wapeonspot.GetComponent<Rigidbody2D>();

        if(appleinventory != null)
        {
            appleinventory.text = inventory.ToString();

        }


        if(ui != null)
        {
            if (candestroypolice)
            {
                ui.SetActive(true);

            }
            else
                ui.SetActive(false);
        }

      


        PickUp();

    }


    void PickUp()
    {
        Vector2 raycastPosition = touchpos;
        hit = Physics2D.Raycast(raycastPosition, Vector2.zero);


        if (hit.collider != null )
        {



            if (hit.collider.tag == "apple")
            {
                Debug.Log("pick up");
                pickupapple.GetComponent<AudioSource>().Play();
                Destroy(hit.collider.gameObject);
                inventory++;

                
            }
        }

    }


    void Throw()
    {

        

        


        targetpoint = touchpos;
        

        
        Vector2 direction = targetpoint - wapeonspot.position ;
        Vector2 direction2 = new Vector2(direction.x, direction.y);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

        Vector2 raycastui = touchpos;
        RaycastHit2D rayhit = Physics2D.Raycast(raycastui, Vector2.zero);




        if (inventory > 0 && !eventsystem)
        {
            
            
            GameObject currentapple = Instantiate(apple, wapeonspot.position, Quaternion.identity);
            applethrow.GetComponent<AudioSource>().Play();

            
            

            inventory--;
            currentapple.GetComponent<Rigidbody2D>().AddForce(playerarmholder.forward * Force, ForceMode2D.Impulse);

            
            
            
        }


    }

    void Eventtrue(bool _eventtrue)
    {

        eventsystem = _eventtrue;

        if (_eventtrue)
        {
            TapCount = 0;
        }


    }

}
