using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;

public class TrainingScript : MonoBehaviour {

    public Slider HealthBar;

	// Use this for initialization
	void Awake() {
	    HealthBar.maxValue = 50f;
	    HealthBar.value = 50f;
	}
	
	
	// Update is called once per frame
	void Update () {
        HealthBar.value = HealthBar.value - (float) GameManager.instance.GiveDamage();
	}
}
