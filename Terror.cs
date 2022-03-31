using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Terror : MonoBehaviour
{
    static int bullet = 5;
    static int terrors = 4;
    static int money = 0;
    [SerializeField] TextMeshProUGUI bulletText;
    [SerializeField] TextMeshProUGUI terrorsText;
    [SerializeField] TextMeshProUGUI moneyText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        Destroy(gameObject);

        bullet = bullet - 1;
        bulletText.text = bullet + " bullets";

        terrors = terrors -1;
        terrorsText.text = terrors + " terrors";

        money = money + 200;
        moneyText.text = money + " money";
    }
}
