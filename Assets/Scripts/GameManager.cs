using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int coins;
    //public PickUp pickUp;
    // Start is called before the first frame update
    void Start()
    {
       // pickUp = FindObjectOfType<PickUp> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoins (int numberOfCoins)
    {
        coins += numberOfCoins;
        
      /*  musicBar.SetMusic(coins);
        sceneChange.CoinValue(coins);
        loadScene.CoinValue(coins);
        loadStory.CoinValue(coins);

        */
        
    }
}
