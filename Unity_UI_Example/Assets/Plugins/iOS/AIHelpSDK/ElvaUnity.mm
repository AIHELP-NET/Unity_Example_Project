//
//  ElvaUnity.m
//  ElvaMqttIOS
//
//  Created by xdl on 2017/2/15.
//  Copyright © 2017年 wwj. All rights reserved.
//

#import "ElvaUnity.h"
#import <Foundation/Foundation.h>
#import "ECServiceSdk.h"
#if defined(__cplusplus)
extern "C"{
#endif
    extern NSString* char2NSString (const char* string);
    extern NSMutableDictionary* customerData2Dic (const char* string);
#if defined(__cplusplus)
}
#endif
//@implementation ElvaUnity
#if defined(__cplusplus)
extern "C"{
#endif
    
    void elvaInit(const char* appKey,const char* appName,const char* appId){
        NSString * _appKey = char2NSString(appKey);
        NSString * _appName = char2NSString(appName);
        NSString * _appId = char2NSString(appId);
        [ECServiceSdk init:_appKey Domain:_appName AppId:_appId];
    }
    
    void elvaShowElva (const char* playerName,const char* playerUid,const char* serverId,const char* playerParseId,const char* showConversationFlag){
        NSString * _playerName = char2NSString(playerName);
        NSString * _playerUid = char2NSString(playerUid);
        NSString * _serverId = char2NSString(serverId);
        NSString * _showConversationFlag = char2NSString(showConversationFlag);
        [ECServiceSdk showElva:_playerName PlayerUid:_playerUid ServerId:_serverId PlayerParseId:@"" PlayershowConversationFlag:_showConversationFlag];
    }
    
    void elvaShowElvaOP (const char* playerName,const char* playerUid,const char* serverId,const char* playerParseId,const char* showConversationFlag,const char*config){
        NSString * _playerName = char2NSString(playerName);
        NSString * _playerUid = char2NSString(playerUid);
        NSString * _serverId = char2NSString(serverId);
        NSString * _showConversationFlag = char2NSString(showConversationFlag);
        NSMutableDictionary *config_2 = customerData2Dic(config);
        [ECServiceSdk showElvaOP:_playerName PlayerUid:_playerUid ServerId:_serverId PlayerParseId:@"" PlayershowConversationFlag:_showConversationFlag Config:config_2];
    }
    
    void elvaShowElvaOPWithTabIndex (const char* playerName,const char* playerUid,const char* serverId,const char* playerParseId,const char* showConversationFlag,const char*config, int defaultTabIndex){
        NSString * _playerName = char2NSString(playerName);
        NSString * _playerUid = char2NSString(playerUid);
        NSString * _serverId = char2NSString(serverId);
        NSString * _showConversationFlag = char2NSString(showConversationFlag);
        NSMutableDictionary *config_2 = customerData2Dic(config);
        [ECServiceSdk showElvaOP:_playerName PlayerUid:_playerUid ServerId:_serverId PlayerParseId:@"" PlayershowConversationFlag:_showConversationFlag Config:config_2 defaultTabIndex:defaultTabIndex];
    }
    
    
    void elvaShowElvaWithConfig (const char* playerName,const char* playerUid,const char* serverId,const char* playerParseId,const char* showConversationFlag,const char* customerData){
        NSString * _playerName = char2NSString(playerName);
        NSString * _playerUid = char2NSString(playerUid);
        NSString * _serverId = char2NSString(serverId);
        NSString * _showConversationFlag = char2NSString(showConversationFlag);
        NSMutableDictionary *config = customerData2Dic(customerData);
        [ECServiceSdk showElva:_playerName PlayerUid:_playerUid ServerId:_serverId PlayerParseId:@"" PlayershowConversationFlag:_showConversationFlag Config:config];
    }
    
    void elvaShowConversation (const char* playerUid,const char* serverId){
        NSString * _playerUid = char2NSString(playerUid);
        NSString * _serverId = char2NSString(serverId);
        [ECServiceSdk showConversation:_playerUid ServerId:_serverId];
    }
    
    void elvaShowConversationWithConfig (const char* playerUid,const char* serverId,const char* customerData){
        NSString * _playerUid = char2NSString(playerUid);
        NSString * _serverId = char2NSString(serverId);
        NSMutableDictionary *config = customerData2Dic(customerData);
        [ECServiceSdk showConversation:_playerUid ServerId:_serverId Config:config];
    }
    
    void elvaShowSingleFAQ (const char* faqId){
        NSString * _faqId = char2NSString(faqId);
        [ECServiceSdk showSingleFAQ:_faqId];
    }
    
    void elvaShowSingleFAQWithConfig (const char* faqId,const char* customerData){
        NSString * _faqId = char2NSString(faqId);
        NSMutableDictionary *config = customerData2Dic(customerData);
        [ECServiceSdk showSingleFAQ:_faqId Config:config];
    }
    
    void elvaShowFAQSection (const char* sectionPublishId){
        NSString * _sectionPublishId = char2NSString(sectionPublishId);
        [ECServiceSdk showFAQSection:_sectionPublishId];
    }
    void elvaShowFAQSectionWithConfig (const char* sectionPublishId,const char* customerData){
        NSString * _sectionPublishId = char2NSString(sectionPublishId);
        NSMutableDictionary *config = customerData2Dic(customerData);
        [ECServiceSdk showFAQSection:_sectionPublishId Config:config];
    }
    
    void elvaShowFAQList (){
        [ECServiceSdk showFAQs];
    }
    
    void elvaShowFAQListWithConfig (const char* customerData){
        NSMutableDictionary *config = customerData2Dic(customerData);
        [ECServiceSdk showFAQs:config];
    }
    
    void elvaSetName (const char* gameName){
        NSString * _gameName = char2NSString(gameName);
        [ECServiceSdk setName:_gameName];
    }
    
    void elvaSetUserId (const char* userId){
        NSString * _userId = char2NSString(userId);
        [ECServiceSdk setUserId:_userId];
    }
    
    void elvaSetServerId (const char* serverId){
        NSString * _serverId = char2NSString(serverId);
        [ECServiceSdk setServerId:_serverId];
    }
    
    void elvaSetUserName (const char* userName){
        NSString * _userName = char2NSString(userName);
        [ECServiceSdk setUserName:_userName];
    }
    
    void elvaSetSDKLanguage (const char* language){
        NSString * _language = char2NSString(language);
        [ECServiceSdk setSDKLanguage:_language];
    }
    
    void elvaSetUseDevice (){
        [ECServiceSdk setUseDevice];
    }
    
    void elvaSetEvaluateStar (int star){
        [ECServiceSdk setEvaluateStar:star];
    }
    
    
    NSString* char2NSString (const char* string)
    {
        if (string){
            return [NSString stringWithUTF8String: string];
        }else{
            return [NSString stringWithUTF8String: ""];
        }
    }
    NSDictionary* char2NSDictionary (const char* string)
    {
        NSString *jsonStr =  char2NSString(string);
        if([jsonStr isEqualToString:@""]){
            return nil;
        }
        NSData *jsonData = [jsonStr dataUsingEncoding:NSUTF8StringEncoding];
        if (jsonData){
            NSError *err;
            NSDictionary *dic = [NSJSONSerialization JSONObjectWithData:jsonData options:0 error:&err];
            if(err){
                NSLog(@"unity config json解析失败：%@",err);
                return nil;
            }
            return dic;
        }else{
            return nil;
        }
    }
    
    NSMutableDictionary* customerData2Dic(const char* string){
        NSDictionary *dic = char2NSDictionary(string);
        if(!dic){
            return nil;
        }
        NSMutableDictionary *customMap = [dic mutableCopy];
        return customMap;
    }
    
#if defined(__cplusplus)
}
#endif



//@end
