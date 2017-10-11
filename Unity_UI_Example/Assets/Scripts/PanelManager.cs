using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class PanelManager : MonoBehaviour {

	public Animator initiallyOpen;

	private int m_OpenParameterId;
	private Animator m_Open;
	private GameObject m_PreviouslySelected;

	const string k_OpenTransitionName = "Open";
	const string k_ClosedStateName = "Closed";

	private ElvaChatService elvaChatService;


	void Awake()
	{
		Debug.Log ("Initialize AI Help SDK");
		initAIHelpSDK ();
	}

	public void OnEnable()
	{
		m_OpenParameterId = Animator.StringToHash (k_OpenTransitionName);

		if (initiallyOpen == null)
			return;

		OpenPanel(initiallyOpen);

	}

	private void initAIHelpSDK()
	{
		elvaChatService = ElvaChatService.Instance;
	}

	public void AIChat()
	{
		Debug.Log ("Open AIChat");
		ElvaChatService.Instance.ShowElva ("TEST_PLAYER_NAME", "TEST_UID_123", "TEST_SRV_ID_123", "", "1");
	}

	public void OperationModule()
	{
		Debug.Log ("Open Operational");
		Dictionary<string, object> config = new Dictionary<string, object> ();
		config.Add ("dic1", "aaa");
		ElvaChatService.Instance.ShowElvaOP ("TEST_PLAYER_NAME", "TEST_UID_123", "TEST_SRV_ID_123", "", "1", config);
	}

	public void ShowFaq()
	{
		Debug.Log ("Show FAQ");
		ElvaChatService.Instance.SetUserName ("TEST_PLAYER_NAME");
		ElvaChatService.Instance.SetUserId ("TEST_UID_123");
		ElvaChatService.Instance.ShowFAQs ();
	}

	public void VIPChat()
	{
		Debug.Log ("Show Conversation");
		ElvaChatService.Instance.SetUserName ("TEST_PLAYER_NAME");
		ElvaChatService.Instance.ShowConversation ("TEST_UID_123");
	}

	public void OpenPanel (Animator anim)
	{
		if (m_Open == anim)
			return;

		anim.gameObject.SetActive(true);
		var newPreviouslySelected = EventSystem.current.currentSelectedGameObject;

		anim.transform.SetAsLastSibling();

		CloseCurrent();

		m_PreviouslySelected = newPreviouslySelected;

		m_Open = anim;
		m_Open.SetBool(m_OpenParameterId, true);

		GameObject go = FindFirstEnabledSelectable(anim.gameObject);

		SetSelected(go);
	}

	static GameObject FindFirstEnabledSelectable (GameObject gameObject)
	{
		GameObject go = null;
		var selectables = gameObject.GetComponentsInChildren<Selectable> (true);
		foreach (var selectable in selectables) {
			if (selectable.IsActive () && selectable.IsInteractable ()) {
				go = selectable.gameObject;
				break;
			}
		}
		return go;
	}

	public void CloseCurrent()
	{
		if (m_Open == null)
			return;

		m_Open.SetBool(m_OpenParameterId, false);
		SetSelected(m_PreviouslySelected);
		StartCoroutine(DisablePanelDeleyed(m_Open));
		m_Open = null;
	}

	IEnumerator DisablePanelDeleyed(Animator anim)
	{
		bool closedStateReached = false;
		bool wantToClose = true;
		while (!closedStateReached && wantToClose)
		{
			if (!anim.IsInTransition(0))
				closedStateReached = anim.GetCurrentAnimatorStateInfo(0).IsName(k_ClosedStateName);

			wantToClose = !anim.GetBool(m_OpenParameterId);

			yield return new WaitForEndOfFrame();
		}

		if (wantToClose)
			anim.gameObject.SetActive(false);
	}

	private void SetSelected(GameObject go)
	{
		EventSystem.current.SetSelectedGameObject(go);
	}
}
