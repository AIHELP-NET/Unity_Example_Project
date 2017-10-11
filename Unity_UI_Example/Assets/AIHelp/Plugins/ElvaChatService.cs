using UnityEngine;
using System.Collections.Generic;

public class ElvaChatService
{
    private IElvaChatServiceSDK sdk;

    private string serverId = "1";

    private static ElvaChatService _instance;

    public static ElvaChatService Instance
    {
        get{
            return _instance ?? (_instance = new ElvaChatService());
        }
    }

    public ElvaChatService()
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
			Dictionary<string, object> dict = new Dictionary<string, object>();
			Dictionary<string, object> dict2 = new Dictionary<string, object> () {
				{ "new", "old"}
			};

			dict.Add ("test1", "value1");
			dict.Add ("test2", new List<string> (){"iuu"});
			dict.Add ("test3", dict2);

			#if UNITY_ANDROID
			sdk.showFAQs(dict);
			#elif UNITY_IOS
			sdk.showFAQs();
			#endif
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