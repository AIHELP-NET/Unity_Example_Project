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
			sdk = new ElvaChatServiceSDKAndroid("TRYELVA_app_5a6b4540bbee4d7280fda431700ed71a", "TryElva.AIHELP.NET", "TryElva_platform_14970be5-d3bf-4f91-8c70-c2065cc65e9a");
        #endif
		#if UNITY_IOS
			if(Application.platform == RuntimePlatform.IPhonePlayer)
		    sdk = new ElvaChatServiceSDKIOS("TRYELVA_app_5a6b4540bbee4d7280fda431700ed71a","TryElva.AIHELP.NET", "TryElva_pf_ec28eb91dd7d463bb359fc53d43dcfd6");
		#endif
		postInitSetting ();
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
			List<string> tag = new List<string>();
			tag.Add ("server1");
			tag.Add ("pay3");
			tags.Add ("elva-tags", tag);
			Dictionary<string, object> config = new Dictionary<string, object> ();
			config.Add ("elva-custom-metadata", tags);
			config.Add("showConversationFlag", "1");
			sdk.showFAQs(config);
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