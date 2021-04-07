using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManage : MonoBehaviour
{
	private float showTextTime = 3f;
	private float removeTextTime;

	[SerializeField] Button RecruitButton;
	[SerializeField] Button ScavengeButton;
	[SerializeField] Button SpecialButton;

	[SerializeField] private Text RecruitText;
	[SerializeField] private Text RecruitFailText;
	[SerializeField] private Text ScavengeText;
	[SerializeField] private Text ScavengeFailText;
	[SerializeField] private Text LoseTurnText;
	[SerializeField] private Text MovePlanetText;
	[SerializeField] private Text LoseClothText;
	[SerializeField] private Text FashionShowText;
	[SerializeField] private Text FashionShowFailText;

	[SerializeField] private AudioSource ClickSound;
	[SerializeField] private AudioSource SuccessSound;
	[SerializeField] private AudioSource FailSound;

	public Text scoreText;
	int score;

	public int numAliensHired;
	public int fashionItems;

	[SerializeField] private GameObject FashionItem; //eventually randomize
	Vector3 infront = new Vector3(0, 2, 0);

	public GameObject model;
	public GameObject recruit;
	private Vector3 recruitpos;

	// Start is called before the first frame update
	void Start()
	{
		RecruitButton.onClick.AddListener(RecruitOnClick);
		ScavengeButton.onClick.AddListener(ScavengeOnClick);
		SpecialButton.onClick.AddListener(SpecialOnClick);
		RecruitText.enabled = false;
		RecruitFailText.enabled = false;
		ScavengeText.enabled = false;
		ScavengeFailText.enabled = false;
		LoseTurnText.enabled = false;
		MovePlanetText.enabled = false;
		LoseClothText.enabled = false;
		FashionShowText.enabled = false;
		FashionShowFailText.enabled = false;

		score = 0;
		scoreText.text = "Score: " + score;

		numAliensHired = 0;
		fashionItems = 0;
	}

	// Update is called once per frame
	void Update()
	{
		if (RecruitText.enabled && (Time.time >= removeTextTime)) RecruitText.enabled = false;
		if (RecruitFailText.enabled && (Time.time >= removeTextTime)) RecruitFailText.enabled = false;
		if (ScavengeText.enabled && (Time.time >= removeTextTime)) ScavengeText.enabled = false;
		if (ScavengeFailText.enabled && (Time.time >= removeTextTime)) ScavengeFailText.enabled = false;
		if (LoseTurnText.enabled && (Time.time >= removeTextTime)) LoseTurnText.enabled = false;
		if (MovePlanetText.enabled && (Time.time >= removeTextTime)) MovePlanetText.enabled = false;
		if (LoseClothText.enabled && (Time.time >= removeTextTime)) LoseClothText.enabled = false;
		if (FashionShowText.enabled && (Time.time >= removeTextTime)) FashionShowText.enabled = false;
		if (FashionShowFailText.enabled && (Time.time >= removeTextTime)) FashionShowFailText.enabled = false;
	}

	void RecruitOnClick()
	{
		ClickSound.Play();
		bool result = Random.value > 0.5;
		if (result)
		{
			SuccessSound.Play();
			RecruitText.enabled = true;
			removeTextTime = showTextTime + Time.time; //show text
													   //make alien object appear and follow
			score = score + 2;
			scoreText.text = "Score: " + score;
			numAliensHired++;
			if (numAliensHired==1) Instantiate(recruit, transform.position, transform.rotation);
			else {
				recruitpos = transform.position - transform.forward;
				Instantiate(recruit, recruitpos, transform.rotation);
			}

		}
		else
		{
			FailSound.Play();
			RecruitFailText.enabled = true;
			removeTextTime = showTextTime + Time.time;
		}
	}

	void ScavengeOnClick()
	{
		ClickSound.Play();
		bool result = Random.value > 0.5;
		if (result)
		{
			SuccessSound.Play();
			ScavengeText.enabled = true;
			removeTextTime = showTextTime + Time.time;
			//make 'cloth' object appear
			Instantiate(FashionItem, transform.position + (transform.forward * 2), transform.rotation);
			score++;
			fashionItems++;
			scoreText.text = "Score: " + score;
		}
		else
		{
			FailSound.Play();
			ScavengeFailText.enabled = true;
			removeTextTime = showTextTime + Time.time;
		}
	}

	void SpecialOnClick()
	{
		ClickSound.Play();
		int result = Random.Range(1, 5);
		if (result == 1)
		{ //random player lose turn
			FailSound.Play();
			LoseTurnText.enabled = true;
			removeTextTime = showTextTime + Time.time;
		}
		else if (result == 2)
		{ //move planets if any are free
			SuccessSound.Play();
			MovePlanetText.enabled = true;
			removeTextTime = showTextTime + Time.time;
			//if new planet, give 1 point
		}
		else if (result == 3)
		{ //lose item
			FailSound.Play();
			LoseClothText.enabled = true;
			removeTextTime = showTextTime + Time.time;
			//make 'cloth' object appear and disappear
		}
		else
		{ //fashion show time
			if (numAliensHired >= 3)
			{
				SuccessSound.Play();
				FashionShowText.enabled = true;
				removeTextTime = showTextTime + Time.time;
				score = score + 3;
				scoreText.text = "Score: " + score;
				numAliensHired = numAliensHired - 3;
				Instantiate(model, transform.position+transform.forward, transform.rotation);
				Instantiate(model, transform.position+transform.forward+transform.right, transform.rotation);
				Instantiate(model, transform.position+transform.forward-transform.right, transform.rotation);
			}
			else
			{
				FailSound.Play();
				FashionShowFailText.enabled = true;
				removeTextTime = showTextTime + Time.time;
			}
		}
	}
}
