using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meta;
using Meta.HandInput;

public class HammerControlManager : MonoBehaviour {

    public Transform HammerPrefab;

    private Dictionary<HandType, Transform> _hammers = new Dictionary<HandType, Transform>();
    private Dictionary<Hand, Transform> _activeHands = new Dictionary<Hand, Transform>();

    void Start()
    {
        if (this.HammerPrefab == null)
        {
            throw new System.Exception("Invalid Prefab");
        }

        HandsProvider provider = GameObject.FindObjectOfType<HandsProvider>();
        provider.events.OnHandEnter.AddListener(this.OnHandEnter);
        provider.events.OnHandExit.AddListener(this.OnHandExit);
    }

    void OnHandEnter(Hand hand)
    {
        Transform hammer = null;
        try
        {
            hammer = this._hammers[hand.HandType];
        }
        catch (KeyNotFoundException)
        {
            hammer = Instantiate(this.HammerPrefab, this.gameObject.transform);
            this._hammers[hand.HandType] = hammer;
        }

        hammer.transform.position = hand.Palm.Position;
        hammer.gameObject.SetActive(true);
        this._activeHands[hand] = hammer;
    }

    void OnHandExit(Hand hand)
    {
        try
        {
            var hammer = this._activeHands[hand];
            this._activeHands.Remove(hand);
            hammer.gameObject.SetActive(false);
        }
        catch (KeyNotFoundException)
        {
            Debug.Log("Did Not Find Hand - Sync Issue?");
        }
    }


    // Update is called once per frame
    void LateUpdate()
    {
        foreach (var hand in this._activeHands.Keys)
        {
            try
            {
                var hammer = this._activeHands[hand];
                hammer.transform.position = hand.Palm.Position;
            }
            catch (KeyNotFoundException)
            {
                Debug.Log("No Hand Obj in Dictionary - Sync Issue?");
            }
        }
    }
}
