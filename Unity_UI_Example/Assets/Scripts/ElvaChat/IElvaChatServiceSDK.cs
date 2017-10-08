using System.Collections.Generic;
public interface IElvaChatServiceSDK
{
    //游戏名字
	void showElva(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag);
	void showElva(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag,Dictionary<string,object> config);
	void showElvaOP(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag);
	void showElvaOP(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag,Dictionary<string,object> config);
	void showElvaOP(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag,Dictionary<string,object> config, int defaultTabIndex);
	void showFAQs();
	void showFAQs(Dictionary<string,object> config);
	void showConversation(string uid,string serverId);
	void showSingleFAQ (string faqId);
	void showSingleFAQ (string faqId, Dictionary<string,object> config);
    void setName(string game_name);
	void setUserName(string userName);
    void setUserId(string serverId);
    void setServerId(string serverId);
	void setSDKLanguage (string language);

	#if UNITY_ANDROID
	void showURL (string URL);
	#endif

}