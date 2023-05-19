using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
public class MobileCanvas : MonoBehaviour
{
    [SerializeField] private Button left;
    [SerializeField] private Button right;
    [SerializeField] private Button jump;
    [SerializeField] private float horizontalMovement;
    [SerializeField] private bool isJumping;
    private void Awake()
    {
#if UNITY_ANDROID
        gameObject.SetActive(true);
#else
        gameObject.SetActive(false);
#endif
    }
    // Start is called before the first frame update
    void Start()
    {
        //left.OnPointerDown += (eventData) => { };  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void leftButtonOnPointerDown()
    {
        horizontalMovement = -1f;
    }
    public void leftButtonOnPointerUp()
    {
        horizontalMovement = 0f; 
    }
    public void rightButtonOnPointerDown()
    {
        horizontalMovement = 1f;
    }
    public void rightButtonOnPointerUp()
    {
        horizontalMovement = 0f;
    }
    public async void onJumpClick()
    {
        isJumping = true;
        await Task.Delay(1);
      isJumping = false;
    }
    public float getHorizotalMovement()
    {
        return horizontalMovement;
    }
    public bool getIsJumping()
    {
        return isJumping;
    }
}
