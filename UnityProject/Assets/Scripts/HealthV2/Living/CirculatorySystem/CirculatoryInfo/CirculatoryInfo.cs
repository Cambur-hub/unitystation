﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CirculatoryInfo", menuName = "ScriptableObjects/Health/CirculatoryInfo", order = 0)]
public class CirculatoryInfo : ScriptableObject
{
	//General data that the circulatory system needs.
	[Tooltip("Maximum amount of blood in the system.")]
	public float BLOOD_MAX = 7000;
	public float BLOOD_SLIME_SPLIT = 3500;
	[Tooltip("The normal amount of blood in the body. 5000mL is the human average.")]
	public float BLOOD_NORMAL = 5000; //Normal blood in the body. 5L for a human.
	[Tooltip("Below this, you'll start to feel symptoms, like being light headed.")]
	public float BLOOD_SAFE = 3750; //Below this, you'll start to feel symptoms, like being light headed.
	[Tooltip("While above this, you wont suffer any long lasting ill effects.")]
	public float BLOOD_OKAY = 3000; //While above this, you wont suffer any long lasting ill effects.
	[Tooltip("It is at this point you'll start taking oxygen damage.")]
	public float BLOOD_BAD = 2500; //It is at this point you'll start taking oxygen damage.

	[Tooltip("If we reach critical, the organism will very quickly accumalte damage.")]
	//If we reach critical, the organism will very quickly accumalte damage.
	public float BLOOD_CRITICAL = 2000;

	//Default value for the amount of blood in the circulatory system. Human average is 5000.
	public float BLOOD_DEFAULT = 5000;

	//Important to note - these values will not determine the true heartrate of the organism.
	//That is something that an organ has will do. These represent the ideal conditions for the
	//circulatory system itself.
	//These will be used as suggestions by the organism responsible for circulating blood.

	//The maximum heartrate of the circulatory system. If this is surpassed, the organism will suffer damage.
	[Tooltip("This is the maximum safe heart rate of the circulatory system." +
	         "Be warned, it is entirely possible that heart organs will just overshoot this.")]
	public float HEARTRATE_MAX = 200;

	[Tooltip("This is the normal resting heartrate of the organism." +
	         "Normally, the heart will try to achieve this BPM if it isn't under stress.")]
	//The ideal resting heartrate of the organism.
	public float HEARTRATE_NORMAL = 55;

	[Tooltip("Minimum heart rate of the organism. If this is reached, it will enter cardiac arrest.")]
	//The minimum heartrate of the circulatory system. If this is reached, the organism will enter cardiac arrest.
	public float HEARTRATE_MIN = 5;


	[Tooltip("The maximum strength that a heart can pump with without damaging the organism." +
	         "100 is the human normal.")]
	public float HEART_STRENGTH_MAX = 150;

	//The maximum amount of reagent we can have in our circulatory system.
	//This has no unit, and is an arbitrary amount. Essentially, it will be a value that
	//is purely used for gameplay interaction, with no tangible real world component.
	[Tooltip("The maximum amount of reagent that we can have in our circulatory system." +
	         "This value has no unit and is an arbitrary number." +
	         "It is used purely for gameplay interaction, with no tangible real world component." +
	         "Human max is 200.")]
	public float BLOOD_REAGENT_MAX = 200;

	[Tooltip("Default amount of blood reagent in the body.")]
	public float BLOOD_REAGENT_DEFAULT = 10;

	//How much of our blood reagent is consumed per heartbeat.
	//Organs and body parts may consume additional.
	//How this is refilled isn't handled by the circulatory system.
	[Tooltip("How much of our blood reagent is consumed per heartbeat." +
	         "Organs and body parts may consume additional amounts of oxygen.")]
	public float BLOOD_REAGENT_CONSUME_PER_BEAT = 0.1f;
}
