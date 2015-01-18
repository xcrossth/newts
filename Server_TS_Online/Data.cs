using JuneNameSpace1;
using mI8ftgPHdarBr2Ldoi;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
namespace Server_TS_Online
{
	public class Data
	{
		private static Random CoTHmccdy;
		private static Random HwB2jHQm1;
		private static string OYaxjjqYB;
		public static OleDbConnection conn_Account;
		private static Random JuneVariable05;
		public static string _Status;
		public static bool LoadedData;
		public static Dictionary<int, DataStructure.Npcs> Data_Npcs;
		public static Dictionary<int, DataStructure.Items> Data_Items;
		public static Dictionary<int, DataStructure.Skills> Data_Skills;
		public static Dictionary<DataStructure.Key_Warps, DataStructure.Warps> Data_Warps;
		public static Dictionary<DataStructure.Key_Talk, DataStructure._Talk> Data_Talks;
		public static Dictionary<int, DataStructure._Texp> Texps;
		public static Dictionary<int, DataStructure.BattleGates> Data_BattleGates;
		private static Random JuneVariable06;
		public static Dictionary<DataStructure.Key_NpcOnMap, DataStructure._NpcOnMap> NpcOnMap;
		public static ArrayList _ListKeysNpcOnMap;
		public static ArrayList _ListKeysItemOnMap;
		public static ArrayList _ListKeysItemDropOnMap;
		public static Dictionary<DataStructure.Key_ItemOnMap, DataStructure._ItemOnMap> ItemOnMap;
		public static Dictionary<DataStructure.Key_ItemDropOnMap, DataStructure._ItemDropOnMap> ItemDropOnMap;
		public static Dictionary<int, string[]> FormulaHP;
		public static Dictionary<int, string[]> FormulaHPCS;
		public static Dictionary<int, string[]> FormulaSP;
		public static Dictionary<int, string[]> FormulaSPCS;
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		static Data()
		{
			JuneClass02.UUCbAVAAM();
			Data.CoTHmccdy = new Random();
			Data.HwB2jHQm1 = new Random();
			Data.OYaxjjqYB = yjR5mT8ly63SrmNoeB.GIgC68bmG.Info.DirectoryPath + JuneClass02.lxGHuH450(12744);
			Data.conn_Account = new OleDbConnection(JuneClass02.lxGHuH450(12786) + Data.OYaxjjqYB + JuneClass02.lxGHuH450(12882));
			Data.JuneVariable05 = new Random();
			Data._Status = "";
			Data.LoadedData = false;
			Data.Data_Npcs = new Dictionary<int, DataStructure.Npcs>();
			Data.Data_Items = new Dictionary<int, DataStructure.Items>();
			Data.Data_Skills = new Dictionary<int, DataStructure.Skills>();
			Data.Data_Warps = new Dictionary<DataStructure.Key_Warps, DataStructure.Warps>();
			Data.Data_Talks = new Dictionary<DataStructure.Key_Talk, DataStructure._Talk>();
			Data.Texps = new Dictionary<int, DataStructure._Texp>();
			Data.Data_BattleGates = new Dictionary<int, DataStructure.BattleGates>();
			Data.JuneVariable06 = new Random();
			Data.NpcOnMap = new Dictionary<DataStructure.Key_NpcOnMap, DataStructure._NpcOnMap>();
			Data._ListKeysNpcOnMap = new ArrayList();
			Data._ListKeysItemOnMap = new ArrayList();
			Data._ListKeysItemDropOnMap = new ArrayList();
			Data.ItemOnMap = new Dictionary<DataStructure.Key_ItemOnMap, DataStructure._ItemOnMap>();
			Data.ItemDropOnMap = new Dictionary<DataStructure.Key_ItemDropOnMap, DataStructure._ItemDropOnMap>();
			Data.FormulaHP = new Dictionary<int, string[]>();
			Data.FormulaHPCS = new Dictionary<int, string[]>();
			Data.FormulaSP = new Dictionary<int, string[]>();
			Data.FormulaSPCS = new Dictionary<int, string[]>();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Data()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetRandomPointPet(int IdPet)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool PlayerGetIdExits(int _id)
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PlayerUpdateDataId(int _id, string type, int value)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int PlayerGetDataSkillId(OleDbConnection conn, int Id, string type)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool PlayerGetDataSkillExits(OleDbConnection conn, int Id)
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpdateStatusSendtoParty(int _Id, string type, int value)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PlayerUpdateStatus(int _Id, string type, int value)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static string MemberGetData(int _id, string type)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static bool MemberGetIdExits(int _Id)
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static void MemberChangedPass(int _Id, string pass1, string pass2)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetDataTalkCount(int _MapId, string _typenpcwarp, int _Id, int _Step)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetDataTalkString(int _MapId, string _typenpcwarp, int _Id, int _Step, int talk)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetDataTalkExits(int _MapId, string _typenpcwarp, int _Id, int _Step)
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetHP(string type, int lv, int Hpx)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetSP(string type, int lv, int Spx)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PetUpdateStatus(int _Id, int Stt, string Type, int value)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpdateStatusPetWhenUseItemLogin(int _IdPlayer)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpdateStatusPetWhenUseItem(int _IdPlayer, int stt)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SendStatusAllPet(int _IdPlayer)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SendStatusPet(OleDbConnection conn, int _IdPlayer, int Stt)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ChangeNamePet(int _IdPlayer, int _stt, string _name)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Removepet(int _IdPlayer, int _stt)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Addpet(int _IdPlayer, int _id)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PetUpdateAllData(OleDbConnection conn, int Stt, int _id, int _Lv, string _Name, int _Thuoctinh, int _Reborn, int _Hp, int _HpMax, int _Sp, int _SpMax, int _Int, int _Atk, int _Def, int _Hpx, int _Spx, int _Agi, int _Fai, int _Texp, int _Int2, int _Atk2, int _Def2, int _Hpx2, int _Spx2, int _Agi2, int _Thd, int _SkillPoint, int _Quest, int _IdSkill1, int _LvSkill1, int _IdSkill2, int _LvSkill2, int _IdSkill3, int _LvSkill3, int _IdSkill4, int _LvSkill4)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool PetExits(OleDbConnection conn, int Id)
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool PetExitsMangtheo(OleDbConnection conn, int Id)
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool PetExitsNhatro(OleDbConnection conn, int Id)
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int PetGetStt(OleDbConnection conn, int Id)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int PetGetData(OleDbConnection conn, int Stt, string type)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PetGetDataName(OleDbConnection conn, int Stt, string type)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PetUpdateData(int _Idplayer, int Stt, string type, int value)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PetUpdateDataName(OleDbConnection conn, int Stt, string type, string value)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DataStructure.HomdoInfo TrangbiGetDataItem(OleDbConnection conn, int Slot)
		{
			return JuneClass5.fieldimpl3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int TrangbiGetDataItem(OleDbConnection conn, int Slot, string Type)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TrangbiUpdateItem(OleDbConnection conn, int Slot, string type, int value)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TrangbiRemoveItem(int _IdPlayer, int tbslot, int hdslot)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TrangbiRemoveItem_Pet(int _IdPlayer, int stt, int tbslot, int hdslot)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MoveItem(OleDbConnection conn, string thung1, int slot1, string thung2, int slot2)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetDataItemThung(OleDbConnection conn, string thung, int Slot, string Type)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DataStructure.HomdoInfo TuideoGetDataItem(OleDbConnection conn, int Slot)
		{
			return JuneClass5.fieldimpl3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int TuideoGetSlotNothing(OleDbConnection conn)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DataStructure.HomdoInfo LuulangGetDataItem(OleDbConnection conn, int Slot)
		{
			return JuneClass5.fieldimpl3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int LuulangGetSlotNothing(OleDbConnection conn)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int HomdoGetSlotNothing(OleDbConnection conn)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int HomdoGetSlotExits(OleDbConnection conn, int Id)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int HomdoGetSlotConstainId50(OleDbConnection conn, int Id)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DataStructure.HomdoInfo HomdoGetDataItem(OleDbConnection conn, int Slot)
		{
			return JuneClass5.fieldimpl3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HomdoAddItem(int _IdPlayer, int ID, int Count)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HomdoRemoveItem(int _IdPlayer, int ID, int Count)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HomdoRemoveItemSlot(int _IdPlayer, int Slot)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HomdoUpdateSlot(OleDbConnection conn, int _slot, DataStructure.HomdoInfo _homdo)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HomdoUpdateItem(OleDbConnection conn, int Slot, string type, int value)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HomdoDropItem(int _IdPlayer, int _hdslot, int count, int Delay)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HomdoMoveItem(int _IdPlayer, int oldslot, int count, int newslot, byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HomdoUseItemTB(int _IdPlayer, int hdslot, int tbslot)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HomdoUseItemTB_Pet(int _IdPlayer, int stt, int hdslot, int tbslot)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HomdoUseHPSPFAI(int _IdPlayer, int _slot, int _CountUse)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PickupItemOnMap(int _IdPlayer, int _Slot)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int CongthucHP(int reborn, int job, int lv, int HPX)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int CongthucSP(int reborn, int job, int lv, int SPX)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int CongthucHPPet(int reborn, int lv, int HPX)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int CongthucSPPet(int reborn, int lv, int SPX)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetRandomMapY(int _Y)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetRandomMapX(int _X)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int RandomizeArray(int[] items)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Warped(int _Id, int _Mapid1, int _Mapid2, int _x, int _y, int _gocnhin)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SendMemWarp(int _id, int _MapId, int _X, int _Y, int _Gocnhin, int _idleader, int _idmem1, int _idmem2, int _idmem3, int _idmem4)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SendWarpFinish(int ID, int mapid, int mapx, int mapy, int gocnhin)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PetUp(int _IdPlayer, int stt)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Loaded()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadDataNpcs()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetDataNpc(int _id, string type)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetDataNpcName(int _id, string type)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetDataNpcExits(int _Id)
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadDataItems()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetDataItem(int _id, string type)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DataStructure.HomdoInfo GetDataItem(int _id)
		{
			return JuneClass5.fieldimpl3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetDataItemExits(int _Id)
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadDataSkills()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetDataSkill(int _id, string type)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetDataSkillExits(int _Id)
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DataStructure.Key_Warps GetKey_Warps(int _Mapid1, int _WarpId)
		{
			return JuneClass5.fieldimpl4;
		}
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static void LoadDataWarps()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetDataWarpExits(int _MapId1, int _WarpId)
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetDataWarp(int _MapId1, int _WarpId, string type)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadDataTalks()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadDataTexps()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int TexpGetLvUp(int _Lv, int _Reborn, int _Texp)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static void LoadDataBattleGates()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetDataBattleGate(int _Id, string type)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DataStructure.Key_NpcOnMap GetKey_NpcOnMap(int _Mapid, int _Id)
		{
			return JuneClass5.fieldimpl5;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CreatMapNpc()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NpcOnMapWalk()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetDataNpcOnMap(int _Mapid, int _Id, string type)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DataStructure.Key_ItemOnMap GetKey_ItemOnMap(int _Mapid, int _ItemId, int _X, int _Y)
		{
			return JuneClass5.fieldimpl6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DataStructure.Key_ItemDropOnMap GetKey_ItemDropOnMap(int _Mapid, int _Slot)
		{
			return JuneClass5.fieldimpl7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SystemDropItem(int _mapid, int _mapx, int _mapy, int _ItemId, int Delay)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SystemDropItem(int _mapid, int _Slot, int _mapx, int _mapy, int _ItemId, int Delay)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CreatMapItem()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _RemoveItemOnMap()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ItemOnMapShow()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetDataItemOnMap(int _id)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadDataFormulaHP()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadDataFormulaHPCS()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadDataFormulaSP()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadDataFormulaSPCS()
		{
		}
	}
}
