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

        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "子彈") 
        getHurt();
        print("受傷");
    }
    private void getHurt() 
    {
        Hp --;
        if (Hp < 0)
            Hp = 0;
        aud.PlayOneShot(audGethurt, 1f);
        Hpui.text = Hp.ToString();       //更新血量介面

        if (Hp == 0)
        {
            Destroy(gameObject);//破壞此腳本存在的物體
        }
    }


    #endregion
}
