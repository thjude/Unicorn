using UnityEngine;
using System.Collections;
using System;

public class GameManager : MonoBehaviour {
    public static GameManager instance { get; private set; }

    private float _strength;
    private float _intel;
    private float _dexterity;
    private float _vitality;

    private float _damage;
    private float _life;

    void Awake() {
        instance = this;
    }

    // Use this for initialization
    private void Start() {
        _strength = 10f;
        _intel = 10f;
        _dexterity = 10f;
        _vitality = 10f;
        _damage = _strength/10 + 1f;
        _life = _vitality/10 + 1f;
    }

    #region Setters, getters

    // Update is called once per frame
    private void Update() {
    }

    public float GetStr() {
        return _strength;
    }

    public float GetInt() {
        return _intel;
    }

    public float GetDex() {
        return _dexterity;
    }

    public float GetVit() {
        return _vitality;
    }

    public float UpdateStr(int amount) {
        _strength += amount;
        return _strength;
    }

    public float UpdateInt(int amount) {
        _intel += amount;
        return _intel;
    }

    public float UpdateDex(int amount) {
        _dexterity += amount;
        return _dexterity;
    }

    public float UpdateVit(int amount) {
        _vitality += amount;
        return _vitality;
    }

    #endregion

    public float TakeDamage(int amount) {
        _life -= amount;
        return _life;
    }

    public float GiveDamage() {
        return _damage;
    }
}