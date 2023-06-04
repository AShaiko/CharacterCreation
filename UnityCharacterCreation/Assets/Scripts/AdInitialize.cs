using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine;

public class AdInitialize : MonoBehaviour
{
    BannerView bannerView;

    private void Start() {
        MobileAds.Initialize(initStatus => { });
        this.RequestBannerAd();
    }

    // These ad units are configured to always serve test ads.
    #if UNITY_ANDROID
          private string adUnitId = "ca-app-pub-3940256099942544/6300978111";
    #elif UNITY_IPHONE
        private string adUnitId = "ca-app-pub-3940256099942544/2934735716";
    #else
          private string adUnitId = "unused";
    #endif

    public void RequestBannerAd() {

        // Clean up banner before reusing
        if (bannerView != null) {
            bannerView.Destroy();
        }

        // Create a 320x50 banner at top of the screen
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Load a banner ad
        bannerView.LoadAd(CreateAdRequest());
    }

    public void DestroyBannerAd() {
        if (bannerView != null) {
            bannerView.Destroy();
        }
    }

    private AdRequest CreateAdRequest() {
        return new AdRequest.Builder()
            .AddKeyword("unity-admob-sample")
            .Build();
    }
}
