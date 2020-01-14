using UnityEngine;
using UnityEngine.Audio;

public class White : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習


    public GameObject bullets;
    public GameObject shotPos;
    public AudioClip audShot;
    private AudioSource aud;       //音源元件


    private void Shot()
    {
        aud.PlayOneShot(audShot, 1f);       
        

    }
    #endregion

    #region KID 區域 - 不要偷看 @3@
    [Header("移動速度"), Range(0f, 100f)]
    public float speed = 1.5f;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        aud = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        Move();
        if (Input.GetMouseButtonDown(0))
        {
            print("發射");
            Shot();
        }
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        rig.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * speed);
    }
    #endregion
}
