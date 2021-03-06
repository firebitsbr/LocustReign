﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pawn : MonoBehaviour {
    CombatManager combat;

    public Attribute attribute;
    public Dominion dominion;
    public Health health;
    public Mana mana;
    public PersonaManager persona;
    public Line line;
    public Hand hand;
    public Hand personaHand;

    public Button button_OnReady;

    public bool hasHand;
    public bool isWinner;
    public bool isAttacker;

    public int dice;
    public int power;

    void Awake()
    {
        attribute = GetComponent<Attribute>();
        dominion = GetComponent<Dominion>();
        health = GetComponent<Health>();
        persona = GetComponent<PersonaManager>();
        line = GetComponent<Line>();
        hand = GetComponents<Hand>()[0];
        personaHand = GetComponents<Hand>()[1];
    }

    void Start()
    {
        combat = GameObject.Find("Combat").GetComponent<CombatManager>();

        persona.ActivatePersona();
    }

    public void ManaCollection()
    {
    }

    public void CharmCast()
    {
    }

    public void Die()
    {
        Debug.Log(name + ": Dead!");
        combat.CombatOver();
    }

    public void CloseCombatUI()
    {
        hand.handUI.SetActive(false);
        line.Show(false);
    }
}
