using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習

    private int Hp;
    public Text Hpui  ;
    private AudioSource aud;
    public AudioClip audGethurt;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
        Hp = 10;
        Hpui.text = Hp.ToString();
    }

    private void Update()
    {
       
       // if (gameObject.tag=("子彈"))
       // {
       //     getHurt();
       // }
    }
    private void getHurt() 
    {
        Hp =Hp--;
        if (Hp < 0)
            Hp = 0;
        aud.PlayOneShot(audGethurt, 1f);

    }


    #endregion
}
