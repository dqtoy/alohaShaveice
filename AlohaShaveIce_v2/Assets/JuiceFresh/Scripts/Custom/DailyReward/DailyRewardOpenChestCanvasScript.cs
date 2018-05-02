﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyRewardOpenChestCanvasScript : MonoBehaviour 
{

	[SerializeField]
	GameObject chest3DContainer;
	[SerializeField]
	GameObject rewardItemsView;
	[SerializeField]
	GameObject rewardItemContainer;
	[SerializeField]
	GameObject rewardItemPrefab;

	GameObject chest3DObject;
	List<RewardResultContent> rewardResultContentList = new List<RewardResultContent>();

	List<PossibleReward> possibleRewards;

	public void SetupOpenChest (List<PossibleReward> _possibleRewards, GameObject _chestPrefab)
	{
		DailyRewardManager.Instance.EnableReward(false);
		gameObject.SetActive(true);
		rewardItemsView.SetActive(false);

		possibleRewards = _possibleRewards;
		for (int i = 0 ; i < rewardResultContentList.Count ; i++)
		{
			RewardResultContent rewardResultContent = rewardResultContentList[i];
			Destroy(rewardResultContent.gameObject);
		}
		rewardResultContentList.Clear();

		for (int i = 0 ; i < possibleRewards.Count ; i++)
		{
			PossibleReward possibleReward = possibleRewards[i];

			GameObject rewardItem = Instantiate(rewardItemPrefab, rewardItemContainer.transform);
			rewardItem.transform.localScale = Vector3.one;

			RewardResultContent rewardResultContent = rewardItem.GetComponent<RewardResultContent>();
			rewardResultContent.SetItemImage(possibleReward);
			rewardResultContentList.Add(rewardResultContent);
		}


		if (chest3DObject != null && !chest3DObject.name.Contains(_chestPrefab.name))
		{
			Destroy(chest3DObject);
			chest3DObject = null;
		}

		if (chest3DObject == null)
		{
			CreateNewChest(_chestPrefab);
		}

		StartCoroutine(RunOpenChestRoutine());
	}

	void CreateNewChest (GameObject _chestPrefab)
	{
		chest3DObject = Instantiate<GameObject>(_chestPrefab, chest3DContainer.transform);
		chest3DObject.transform.localScale = new Vector3 (100.0f, 100.0f, 100.0f); //Vector3.one;
		chest3DObject.transform.localPosition = Vector3.zero;
		chest3DObject.transform.eulerAngles = new Vector3(0.0f, 162.0f, 0.0f);
		chest3DContainer.SetActive(false);
	}

	IEnumerator RunOpenChestRoutine ()
	{
		//chest animation
		chest3DContainer.SetActive(true);
		yield return new WaitForSeconds(3.0f);

		rewardItemsView.SetActive(true);
		chest3DContainer.SetActive(false);
	}

	public void OnCloseButtonPressed ()
	{
		for (int i = 0 ; i < possibleRewards.Count ; i++)
		{
			PossibleReward possibleReward = possibleRewards[i];
			InitScript.Instance.GiveDailyReward(possibleReward);
		}

		gameObject.SetActive(false);
		DailyRewardManager.Instance.EnableReward(true);
	}
}
