using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;
//全屏广告配置
public class FullScreenAdManager : MonoBehaviour {
    private string FullScreen_ID = "ca-app-pub-2501008550889118/1708404985";
    private InterstitialAd ad;
	// Use this for initialization
	void Start () {
        ad = new InterstitialAd(FullScreen_ID);
        AdRequest request = new AdRequest.Builder().Build();
        ad.LoadAd(request);
	}
	
	// Update is called once per frame
	void Update () {
        ShowFullScreenAd();
	}

    public void ShowFullScreenAd() {
      if(ad.IsLoaded()){
          ad.Show();
      }
       
    }
}
