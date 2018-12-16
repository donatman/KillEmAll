﻿using UnityEngine;
using UnityEngine.EventSystems;

public class FixedJoystick2 : Joystick
{
	Vector2 joystickPosition = Vector2.zero;
	private Camera cam = new Camera();
//	public Transform player;

//	protected Jousiampuja jouskari;




//	GameObject prefab;


	void Start()
	{
//		jouskari = FindObjectOfType<Jousiampuja> ();

		joystickPosition = RectTransformUtility.WorldToScreenPoint(cam, background.position);
//		prefab = Resources.Load ("SwordHit") as GameObject;
	}
		
	public override void OnDrag(PointerEventData eventData)
	{
		Vector2 direction = eventData.position - joystickPosition;
		inputVector = (direction.magnitude > background.sizeDelta.x / 2f) ? direction.normalized : direction / (background.sizeDelta.x / 2f);
		ClampJoystick();
		handle.anchoredPosition = (inputVector * background.sizeDelta.x / 2f) * handleLimit;
	}

	public override void OnPointerDown(PointerEventData eventData)
	{
		OnDrag(eventData);

	}

	public override void OnPointerUp(PointerEventData eventData)
	{
//		jouskari.ammu ();
		inputVector = Vector2.zero;
		handle.anchoredPosition = Vector2.zero;

	}

}



