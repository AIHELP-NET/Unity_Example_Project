using UnityEngine;
using System.Collections.Generic;
#if UNITY_ANDROID
public class ElvaChatServiceSDKAndroid:IElvaChatServiceSDK
{
    private AndroidJavaClass sdk;
	private AndroidJavaObject currentActivity;


	public ElvaChatServiceSDKAndroid(){
		AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		currentActivity = jc.GetStatic<AndroidJavaObject>("currentActivity");
		sdk = new AndroidJavaClass("com.ljoy.chatbot.sdk.ELvaChatServiceSdk");

		sdk.CallStatic ("init", currentActivity, "SLOTS_app_3372a5c9998540b08da6019f4ff2f6da", "slots.CS30.NET", "slots_platform_2803a29c-e53c-435b-a527-56eab1adfa93");
	}

	public void init(string appKey,string domain,string appId){
		sdk.CallStatic("init",currentActivity,appKey,domain,appId);
	}

	public void showElva(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag){
		sdk.CallStatic("showElvaChatService","elva",playerName,playerUid,serverId,playerParseId,showConversationFlag);
	}

	public void showElva(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag,Dictionary<string,object> config){
		AndroidJavaObject javaMap = customMap(config);
		sdk.CallStatic("showElvaChatService","elva",playerName,playerUid,serverId,playerParseId,showConversationFlag,javaMap);
	}

	public void showFAQs(){
		sdk.CallStatic("showFAQList");
	}

	public void showFAQs(Dictionary<string,object> config){
		AndroidJavaObject javaMap = customMap(config);
		sdk.CallStatic("showFAQList",javaMap);
	}

	public void showFAQSection(string sectionPublishId){
		sdk.CallStatic("showFAQSection",sectionPublishId);
	}

	public void showFAQSection(string sectionPublishId,Dictionary<string,object> config){
		AndroidJavaObject javaMap = customMap(config);
		sdk.CallStatic("showFAQSection",sectionPublishId,javaMap);
	}

	public void showSingleFAQ(string faqId){
		sdk.CallStatic("showSingleFAQ",faqId);
	}

	public void showSingleFAQ(string faqId,Dictionary<string,object> config){
		AndroidJavaObject javaMap = customMap(config);
		sdk.CallStatic("showSingleFAQ",faqId,javaMap);
	}

	public void showConversation(string uid,string serverId){
		sdk.CallStatic("showConversation",uid,serverId);
	}

	public void showConversation(string uid,string serverId,Dictionary<string,object> config){
		AndroidJavaObject javaMap = customMap(config);
		sdk.CallStatic("showConversation",uid,serverId,javaMap);
	}


	public void setName(string gameName)
	{
		sdk.CallStatic("setName",gameName);
	}

	public void setUserId(string playerUid)
	{
		sdk.CallStatic("setUserId",playerUid);
	}

	public void setUserName(string userName)
	{
		sdk.CallStatic("setUserName",userName);
	}

	public void setServerId(string serverId)
	{
		sdk.CallStatic("setServerId",serverId);
	}

	public void setSDKLanguage(string sdkLanguage){
		sdk.CallStatic("setSDKLanguage",sdkLanguage);
	}
		
	public void setEvaluateStar(int star){
		sdk.CallStatic("setEvaluateStar",star);
	}

	public void showElvaOP(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag){
		sdk.CallStatic("showOPList","elva",playerName,playerUid,serverId,playerParseId,showConversationFlag);
	}

	public void showElvaOP(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag,Dictionary<string,object> config){
		AndroidJavaObject javaMap = customMap(config);
		sdk.CallStatic("showOPList","elva",playerName,playerUid,serverId,playerParseId,showConversationFlag,javaMap);
	}

	public void showElvaOP(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag,Dictionary<string,object> config,int defaultTabIndex){
		AndroidJavaObject javaMap = customMap(config);
		sdk.CallStatic("showOPList","elva",playerName,playerUid,serverId,playerParseId,showConversationFlag,javaMap,defaultTabIndex);
	}

	private AndroidJavaObject customMap(Dictionary<string,object> dic){
		AndroidJavaObject map1 = new AndroidJavaObject("java.util.HashMap");
		AndroidJavaObject map = dicToMap(dic);
		map1.Call<string>("put","hs-custom-metadata",map);
		return map1;
	}
	private AndroidJavaObject dicToMap(Dictionary<string,object> dic){
		AndroidJavaObject map = new AndroidJavaObject("java.util.HashMap");
		foreach(KeyValuePair<string,object> pair in dic){
			if(pair.Value is string){
				map.Call<string>("put",pair.Key,pair.Value);
			}else if(pair.Value is List<string>){
				AndroidJavaObject list = new AndroidJavaObject("java.util.ArrayList");
				List<string> l = pair.Value as List<string>;
				foreach(string s in l){
					list.Call<bool>("add",s);
				}
				map.Call<string>("put",pair.Key,list);
			}else if(pair.Value is Dictionary<string, object>){
				map.Call<string>("put",pair.Key,dicToMap(pair.Value as Dictionary<string, object>));
			}
		}
		return map;
	}

	public void showURL(string url)
	{
		sdk.CallStatic ("showURL", url);
	}
}
#endif