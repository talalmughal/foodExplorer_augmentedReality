using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ImageRecognitionScript : MonoBehaviour
{
    // public static ImageRecognitionScript instance;
    // public Text nameOfPrefab;
    // public Text DEbugText;
    private ARTrackedImageManager _arTrackedImageManager;
    public GameObject trafkedObject;
    private void Awake()
    {
        // instance = this;
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();

    }

    public void OnEnable()
    {
        _arTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable()
    {
        _arTrackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
        }
    }
    // void Start()
    // {
    //     Seardch();
    // }
    // public void Seardch() 
    // {

    //     StartCoroutine(FindInstantcEObject());
    //     nameOfPrefab.text = "Serartchj Called";

    // }
    // IEnumerator FindInstantcEObject()
    // {

    //     yield return new WaitForSeconds(0.5f);
    //     Talal gb = FindObjectOfType<Talal>();

    //     if (gb != null)
    //     {
    //         nameOfPrefab.text = gb.name + "";
    //         trafkedObject = gb.gameObject;
    //     }
    //     else
    //     {
    //         nameOfPrefab.text = "GB Was Null";
    //     }

    // } 
}
