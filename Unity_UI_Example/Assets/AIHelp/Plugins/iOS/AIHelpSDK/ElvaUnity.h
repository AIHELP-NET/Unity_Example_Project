//
//  ElvaUnity.h
//  ElvaMqttIOS
//
//  Created by xdl on 2017/2/15.
//  Copyright © 2017年 wwj. All rights reserved.
//

#ifndef ElvaUnity_h
#define ElvaUnity_h




extern "C" void elvaInit (const char* appKey,const char* domain,const char* appId);

extern "C" void elvaShowElva (const char* playerName,const char* playerUid,const char* serverId,const char* playerParseId,const char* showConversationFlag);

extern "C" void elvaShowElvaWithConfig (const char* playerName,const char* playerUid,const char* serverId,const char* playerParseId,const char* showConversationFlag,const char* jsonConfig);

extern "C" void elvaShowConversation (const char* playerUid,const char* serverId);

extern "C" void elvaShowConversationWithConfig (const char* playerUid,const char* serverId,const char* jsonConfig);

extern "C" void elvaShowSingleFAQ (const char* faqId);

extern "C" void elvaShowSingleFAQWithConfig (const char* faqId,const char* jsonConfig);

extern "C" void elvaShowFAQSection (const char* sectionPublishId);

extern "C" void elvaShowFAQSectionWithConfig (const char* sectionPublishId,const char* jsonConfig);

extern "C" void elvaShowFAQList ();

extern "C" void elvaShowFAQListWithConfig (const char* jsonConfig);

extern "C" void elvaSetName (const char* gameName);

extern "C" void elvaSetUserId (const char* playerUid);

extern "C" void elvaSetServerId (const char* serverId);

extern "C" void elvaSetUserName (const char* playerName);

extern "C" void elvaSetSDKLanguage(const char* sdkLanguage);

extern "C" void elvaSetUseDevice ();

extern "C" void elvaSetEvaluateStar (int star);


extern "C" void elvaShowElvaOP(const char* playerName, const char* playerUid ,const char* serverId ,const char* playerParseId ,const char* playershowConversationFlag ,const char* config);
extern "C" void elvaShowElvaOPWithTabIndex(const char* playerName, const char* playerUid ,const char* serverId ,const char* playerParseId ,const char* playershowConversationFlag ,const char* config, int defaultTabIndex);




#endif /* ElvaUnity_h */
