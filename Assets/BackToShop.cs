﻿using Solana.Unity.Wallet;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToShop : MonoBehaviour
{
    public void BackToShopProcess()
    {        
        // Chuyển sang scene mới (ShopAndPlay)
        SceneManager.LoadScene("ShopAndPlay");
    }
}
