using 0S3Qo4yIEbfEJKcxXW;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
namespace Server_TS_Online
{
	public class Client
	{
		private string CoTHmccdy;
		public OleDbConnection conn;
		private int HwB2jHQm1;
		private string OYaxjjqYB;
		public int _my_DiaHinh;
		public int _My_Logined;
		public int _My_Id;
		public string _My_Name;
		public int _My_Lv;
		public int _My_Hp;
		public int _My_HpMax;
		public int _My_Sp;
		public int _My_SpMax;
		public int _My_Point;
		public int _My_SkillPoint;
		public int _My_Int;
		public int _My_Atk;
		public int _My_Def;
		public int _My_Hpx;
		public int _My_Spx;
		public int _My_Agi;
		public int _My_Int2;
		public int _My_Atk2;
		public int _My_Def2;
		public int _My_Hpx2;
		public int _My_Spx2;
		public int _My_Agi2;
		public int _My_Texp;
		public int _My_MapId;
		public int _My_MapX;
		public int _My_MapY;
		public int _My_Reborn;
		public int _My_Job;
		public int _My_Sex;
		public int _My_Hair;
		public int _My_Thuoctinh;
		public int _My_Ghost;
		public int _My_God;
		public string _My_Color;
		public int _My_Gold;
		public int _My_Tiengtam;
		public int _My_Gocnhin;
		public int _My_SttPetXuatChien;
		public int _My_Pk;
		public int _My_ThamChien;
		public int _My_IdLeader;
		public int _My_IdMem1;
		public int _My_IdMem2;
		public int _My_IdMem3;
		public int _My_IdMem4;
		public int _My_IdQS;
		public int _My_IdXinVaoNhom;
		public int _My_IdMoiVaoNhom;
		public int _My_IdBattle;
		public int _My_Dongtac;
		public int _My_Horse;
		public int _My_WarpingId;
		public int _My_TalkingBattle;
		public Dictionary<int, DataStructure._MyPet> ListPet;
		public bool warpfinish;
		public int talkcount;
		public int idtalking;
		public string Typetalk;
		public int SelectMenu;
		private int[] 4DaMrGOhr;
		public Socket _socket;
		public byte[] _buffer;
		private string 1CcbCDnbw;
		private Random TB0joVLX7;
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Client(Socket _c)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void shutdown()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetupRecieveCallback(Socket sock)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRecievedData(IAsyncResult ar)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateMainGrid(byte[] _buffer)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Sleep()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateMainGrid_Recv(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H0(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H1(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H2(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H3(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H6(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H8(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public void Update_H9(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_HB(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_HC(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_HD(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_HF(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public void Update_H13(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H14(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H17(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H1C(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H20(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H21(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H22(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public void Update_H23(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H28(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update_H32(byte[] packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EndTalk()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Logined1()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public void Logined()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendTSPoint(int _point)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Sendpacket(string packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetlistSkill()
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SkillExits(int Id)
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int SkillGet(int Id, string Type)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SkillAdd(int Id, int Lv, int Sp, int Dk)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SkillUpdate(int Id, string type, int value)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int SkillSaveGetId(int _Id)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SkillSaveUpdateId(int _Id, int _IdSkill)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void QuestInsertData(int _Mapid, int _Npcid, int _Warpid, int _Step)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int QuestGetDataNpc(int _Mapid, int _Npcid)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void QuestUpdateDataNpc(int _Mapid, int _Npcid, int _Step)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int QuestGetDataWarp(int _Mapid, int _Warpid)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void QuestUpdateDataWarp(int _Mapid, int _Warpid, int _Step)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerDeleteDataId(int _id)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateStatusWhenUseItem()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool GetDKThuoctinh(int tt)
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetPointSkillAdd(int tt_skill, int point)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendSkillPointtoClient(int _count)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetNameSlot(int loai)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendMyParty()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GiaiTanParty(int _Idout)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PartySendStatus(int _IdSend, int _Id)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Walked(int _Id, int _x, int _y, int _gocnhin)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WrongPass()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreatChar()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreatedCharName()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreatChar_NameUsed()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreatedCharacter()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetRandomMapY(int _Y)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetRandomMapX(int _X)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int RandomizeArray(int[] items)
		{
			return 0;
		}
		[DebuggerStepThrough, CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _Lambda$__1(object a0)
		{
		}
		static Client()
		{
			i4iw8SpaFI6rqcQywY.UUCbAVAAM();
		}
	}
}
