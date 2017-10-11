//
//  ECServiceCocos2dx.h
//  ElvaChatService Cocos2dx SDK
//

#import <Foundation/Foundation.h>
@interface ECServiceSdk:NSObject


    + (void) init:(NSString*) appSecret Domain:(NSString*) domain AppId:(NSString*) appId;
    + (void) showElva:(NSString*) playerName PlayerUid:(NSString*) playerUid ServerId:(NSString*) serverId PlayerParseId:(NSString*) playerParseId PlayershowConversationFlag:(NSString*) playershowConversationFlag;
    + (void) showElva:(NSString*) playerName PlayerUid:(NSString*) playerUid ServerId:(NSString*) serverId PlayerParseId:(NSString*) playerParseId PlayershowConversationFlag:(NSString*) playershowConversationFlag Config:(NSMutableDictionary*) config;
    + (void) showSingleFAQ:(NSString*) faqId;
    + (void) showSingleFAQ:(NSString*) faqId Config:(NSMutableDictionary*) config;
    + (void) showFAQSection:(NSString*) sectionPublishId;
    + (void) showFAQSection:(NSString*) sectionPublishId Config:(NSMutableDictionary*) config;
    + (void) showFAQs;
    + (void) showFAQs:(NSMutableDictionary*) config;
    + (void) setName:(NSString*) game_name;
    + (void) registerDeviceToken:(NSString*) deviceToken;
    + (void) setUserId:(NSString*) playerUid;//自助服务，在showFAQ之前调用
    + (void) setServerId:(NSString*) serverId;//自助服务，在showFAQ之前调用
    + (void) setUserName:(NSString*) playerName;//在需要的接口之前调用，建议游戏刚进入就默认调用
    + (void) showConversation:(NSString*) playerUid ServerId:(NSString*) serverId;//请优先实现setUserName接口
    + (void) showConversation:(NSString*) playerUid ServerId:(NSString*) serverId Config:(NSMutableDictionary*) config;
    + (BOOL) setSDKLanguage:(NSString*) sdkLanguage;
    + (void) setChangeDirection;
    + (void) setUseDevice;
    + (void) setEvaluateStar:(int) star;
    + (void) setNoMenu;


+ (void) showElvaOP:(NSString*) playerName PlayerUid:(NSString*) playerUid ServerId:(NSString*) serverId PlayerParseId:(NSString*) playerParseId PlayershowConversationFlag:(NSString*) playershowConversationFlag Config:(NSMutableDictionary *)config;

+ (void) showElvaOP:(NSString*) playerName PlayerUid:(NSString*) playerUid ServerId:(NSString*) serverId PlayerParseId:(NSString*) playerParseId PlayershowConversationFlag:(NSString*) playershowConversationFlag Config:(NSMutableDictionary *)config defaultTabIndex:(int)defaultTabIndex;


@end
