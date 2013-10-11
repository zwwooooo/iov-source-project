#ifndef __CIV_QUOTES_H
#define __CIV_QUOTES_H

#include "Soldier Control.h"

#define			CIV_TYPE_NA									0	
#define			CIV_TYPE_ADULT							1
#define			CIV_TYPE_KID								2	
#define			CIV_TYPE_MARRIED_PC					3
#define			CIV_TYPE_ENEMY							4

enum
{
	CIV_QUOTE_ADULTS_BEGGING, //CIV00.EDT
	CIV_QUOTE_KIDS_BEGGING,   
	CIV_QUOTE_ADULTS_RECENT_BUG_ATTACK,
	CIV_QUOTE_KIDS_RECENT_BUG_ATTACK,
	CIV_QUOTE_ADULTS_BUG_EXTERMINATED_X_TIME,
	CIV_QUOTE_KIDS_BUG_EXTERMINATED_X_TIME,
	CIV_QUOTE_ADULTS_EXTREMLY_LOW_LOYALTY,
	CIV_QUOTE_KIDS_EXTREMLY_LOW_LOYALTY,
	CIV_QUOTE_ADULTS_HIGH_LOYALTY,
	CIV_QUOTE_KIDS_HIGH_LOYALTY,

	CIV_QUOTE_ADULTS_ALL_PURPOSE,  //CIV10.EDT
	CIV_QUOTE_KIDS_ALL_PURPOSE,
	CIV_QUOTE_ADULTS_LIBREATED_FIRST_TIME,	
	CIV_QUOTE_KIDS_LIBREATED_FIRST_TIME,	
	CIV_QUOTE_ADULTS_TOWN_TAKEN_BACK,
	CIV_QUOTE_KIDS_TOWN_TAKEN_BACK,
	CIV_QUOTE_HICKS_FRIENDLY,
	CIV_QUOTE_HICKS_ENEMIES,
	CIV_QUOTE_GOONS_FRIENDLY,
	CIV_QUOTE_GOONS_ENEMIES,

	CIV_QUOTE_ADULTS_REBELS, //CIV20.EDT
	CIV_QUOTE_KIDS_REBELS,
	CIV_QUOTE_GREEN_MILITIA,
	CIV_QUOTE_MEDIUM_MILITIA,
	CIV_QUOTE_ELITE_MILITIA,
	CIV_QUOTE_SAN_MONA_BEGGERS,
	CIV_QUOTE_ENEMY_HURT,
	CIV_QUOTE_ENEMY_ADMIN,
	CIV_QUOTE_ENEMY_THREAT,
	CIV_QUOTE_ENEMY_ELITE,

	CIV_QUOTE_ADULTS_COWER, //CIV30.EDT
	CIV_QUOTE_KIDS_COWER,
	CIV_QUOTE_PC_MARRIED,
	CIV_QUOTE_KID_SLAVES,
	CIV_QUOTE_KID_SLAVES_FREE,
	CIV_QUOTE_MINERS_NOT_FOR_PLAYER,
	CIV_QUOTE_MINERS_FOR_PLAYER,
	CIV_QUOTE_ENEMY_OFFER_SURRENDER,
	CIV_QUOTE_HICKS_SEE_US_AT_NIGHT,
	CIV_QUOTE_DEIDRANNA_DEAD,
#ifdef JA2UB	
	//40
	CIV_QUOTE__CIV_ENEMY_CAN_FIGHT,
	CIV_QUOTE__CIV_ENEMY_GENERIC,
	CIV_QUOTE__CIV_HURT,
	CIV_QUOTE__CIV_NOT_ENEMY,
	CIV_QUOTE_44,
	CIV_QUOTE_45,
	CIV_QUOTE_46,
	CIV_QUOTE_47,
	CIV_QUOTE_48,
	CIV_QUOTE_49,
	
	CIV_QUOTE_NEW = CIV_QUOTE_DEIDRANNA_DEAD + 990, // 500 reserved
#else
	CIV_QUOTE_NEW = CIV_QUOTE_DEIDRANNA_DEAD + 1000, // 500 reserved
#endif	
	NUM_CIV_QUOTES
};

enum //enemy taunts - SANDRO
{
	//kenkenkenken: IoV921+z.5 -->
	TAUNT_GUN_JAM, 
	TAUNT_GUN_UNJAM_S,
	TAUNT_GUN_UNJAM_F, 
	//<-- IoV
	TAUNT_FIRE_GUN,
	TAUNT_FIRE_LAUNCHER,
	TAUNT_THROW,
	TAUNT_CHARGE_KNIFE,
	TAUNT_RUN_AWAY,
	TAUNT_SEEK_NOISE,
	TAUNT_ALERT,
	TAUNT_GOT_HIT,
	TAUNT_NOTICED_UNSEEN_MERC,
};

void StartEnemyTaunt( SOLDIERTYPE *pCiv, INT8 iTauntType ); //enemy taunts - SANDRO

void InitCivQuoteSystem( );

void StartCivQuote( SOLDIERTYPE *pCiv );

INT8 GetCivType( SOLDIERTYPE *pCiv );

void HandleCivQuote( );

BOOLEAN SaveCivQuotesToSaveGameFile( HWFILE hFile );
BOOLEAN LoadCivQuotesFromLoadGameFile( HWFILE hFile );

BOOLEAN ShutDownQuoteBoxIfActive( );

void BeginCivQuote( SOLDIERTYPE *pCiv, UINT16 ubCivQuoteID, UINT16 ubEntryID, INT16 sX, INT16 sY );

#endif