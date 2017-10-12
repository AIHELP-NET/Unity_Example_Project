using UnityEngine;
using System.Collections.Generic;

public class AIhelpServiceExample
{
    private IElvaChatServiceSDK sdk;

    private string serverId = "1";

    private static AIhelpServiceExample _instance;

    public static AIhelpServiceExample Instance
    {
        get{
            return _instance ?? (_instance = new AIhelpServiceExample());
        }
    }

    public AIhelpServiceExample()
    {
        #if UNITY_ANDROID
            if(Application.platform == RuntimePlatform.Android)
                sdk = new ElvaChatServiceSDKAndroid();
        #endif
		#if UNITY_IOS
			if(Application.platform == RuntimePlatform.IPhonePlayer)
				sdk = new ElvaChatServiceSDKIOS();
		#endif
		postInitSetting();
    }

    private void postInitSetting()
    {
        if(sdk != null)
        {
            sdk.setName("AIHelp Example");
            sdk.setServerId(serverId);
        }
    }

    public void ShowFAQs()
    {
        if(sdk != null)
        {
			Dictionary<string, object> tags = new Dictionary<string, object> ();
			tags.Add ("hs-tags", new List<string> (){"vip1", "pay1"});

			sdk.showFAQs(tags);
        }
    }
	public void ShowElva(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag)
	{
		if(sdk != null)
		{
			sdk.showElva(playerName, playerUid,serverId,playerParseId,showConversationFlag);
		}
	}
	public void ShowElva(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag,Dictionary<string,object> config)
	{
		if(sdk != null)
		{
			sdk.showElva(playerName, playerUid,serverId,playerParseId,showConversationFlag,config);
		}
	}
	public void ShowElvaOP(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag)
	{
		if(sdk != null)
		{
			sdk.showElvaOP(playerName, playerUid,serverId,playerParseId,showConversationFlag);
		}
	}

	public void ShowElvaOP(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag,Dictionary<string,object> config)
	{
		if(sdk != null)
		{
			sdk.showElvaOP(playerName, playerUid,serverId,playerParseId,showConversationFlag,config);
		}
	}

	public void ShowElvaOP(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag,Dictionary<string,object> config, int tabIndex)
	{
		if(sdk != null)
		{
			sdk.showElvaOP(playerName, playerUid,serverId,playerParseId,showConversationFlag,config, tabIndex);
		}
	}
    //游戏名字
    public void SetName(string game_name)
    {
        if(sdk != null)
        {
            sdk.setName(game_name);
        }
    }

    public void SetUserId(string serverId)
    {
        if(sdk != null)
        {
            sdk.setUserId(serverId);
        }
    }

    public void SetUserName(string userName)
    {
        if(sdk != null)
        {
            sdk.setUserName(userName);
        }
    }

    public void SetServerId(string serverId)
    {
        if(sdk != null)
        {
            sdk.setServerId(serverId);
        }
    }

    public void ShowConversation(string uid)
    {
        if(sdk != null)
        {
            sdk.showConversation(uid,serverId);
        }
    }

    public void SetSDKLanguage(string lang)
    {
        if(sdk != null)
        {
            sdk.setSDKLanguage(lang);
        }
    }

	public void ShowURL(string url)
	{
		if(sdk != null)
		{
			#if UNITY_ANDROID
			sdk.showURL(url);
			#endif
		}
	}
}