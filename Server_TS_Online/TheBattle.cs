using 0S3Qo4yIEbfEJKcxXW;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
namespace Server_TS_Online
{
	public class TheBattle
	{
		public Dictionary<string, DataStructure.WarInfo> ListWar;
		public Dictionary<int, int> ListQS;
		public ArrayList _keys;
		public int _idBattle;
		public int _Diahinh;
		private Random lxGHuH450;
		private Random 87T2NGQfS;
		private Random 5Dpx2hsoH;
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreatNewBattle()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangedWar(string _key, int Type, int Id, int IdNpcOnMap, int IdChar, int HpMax, int SpMax, int Hp, int Sp, int Lv, int Thuoctinh, int LeaderId, int IdSkill, int RowAttack, int ColumnAttack, int Team, int Int, int Atk, int Def, int Agi, int Reborn, int Type3_Id, int Type3_Lv, int Type3_Turn, int Type4_Id, int Type4_Lv, int Type4_Turn, int Type15_Id, int Type15_Lv, int Type15_Turn, int Type19_Id, int Type19_Lv, int Type19_Turn, int Attacked, int Exp)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public void AddToBattle(int IdLeader, int IdMem1, int IdMem2, int IdMem3, int IdMem4, int _row, int _Column)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddNPCToBattle(int ID, int _IdNpcOnMap, int _row, int _Column, int _Type)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TheBattle(int IdLeader1, int IdLeader2, int DiaHinh)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TheBattle(int IdLeader, int IdNpc, int IdNpcOnMap, int DiaHinh)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TheBattle(int IdLeader, DataStructure.TeamDeffender _Teamdef, int DiaHinh)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BattlePkPlayer(int DiaHinh)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BattleNpc(int DiaHinh)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendBattleMem1(int DiaHinh, int _row, int _Column)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Battling()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendSKillingToParty(string packetattack)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendBattleLeader(int DiaHinh, int _row, int _Column)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendBattleMemPkPlayer(int DiaHinh, int _row, int _Column)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendBattleLeaderPlayerPK(int DiaHinh, int _row, int _Column)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendBattleMemberPlayerPK(int _IdBattle, int _row, int _Column)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendBattleMem(int _IdBattle, int DiaHinh, int _row, int _Column)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public double GetDamageThuoctinh(int MyTT, int TTAttack)
		{
			return (double)0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetDamageSkillInt(int TTSkill, int TTAttack)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Point GetPosRandom_honLoan(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			return <PrivateImplementationDetails>{DF4733E3-813D-4159-ACCB-42DEDC13E2A8}.fieldimpl8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArrayList GetPosAttack_honLoan(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Point GetPosRandom(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			return <PrivateImplementationDetails>{DF4733E3-813D-4159-ACCB-42DEDC13E2A8}.fieldimpl8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArrayList GetPosAttack(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Point GetPosRandomCombo(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			return <PrivateImplementationDetails>{DF4733E3-813D-4159-ACCB-42DEDC13E2A8}.fieldimpl8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArrayList GetPosAttackCombo(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Point GetPosRandomTG(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			return <PrivateImplementationDetails>{DF4733E3-813D-4159-ACCB-42DEDC13E2A8}.fieldimpl8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArrayList GetPosAttackTG(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Point GetPosRandom3_15(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			return <PrivateImplementationDetails>{DF4733E3-813D-4159-ACCB-42DEDC13E2A8}.fieldimpl8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArrayList GetPosAttack3_15(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Point GetPosRandom_GiaiTru(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			return <PrivateImplementationDetails>{DF4733E3-813D-4159-ACCB-42DEDC13E2A8}.fieldimpl8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArrayList GetPosAttack_GiaiTru(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Point GetPosRandom_Type4(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			return <PrivateImplementationDetails>{DF4733E3-813D-4159-ACCB-42DEDC13E2A8}.fieldimpl8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArrayList GetPosAttack_Type4(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetTurn(int IdSkill, int LvSKill)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string Skilling(int Row, int column, int idskill, int Rowattack, int columnattack, int Type_StatusAttackMiss, int Attack_Def_Lantranh, int CountHieuUng, int TroiBuffHpSp, int Damage, int StatusBuffHpSP)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SkillingInt(int Rowattack, int columnattack, int Type_StatusAttackMiss, int Attack_Def_Lantranh, int CountHieuUng, int TroiBuffHpSp, int Damage, int StatusBuffHpSP)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string Skilling(int Rowattack, int columnattack, int Type_StatusAttackMiss, int Attack_Def_Lantranh)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SkillingHieuUng(int TroiBuffHpSp, int Damage, int StatusBuffHpSP)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TroiEnd(int _IdBattle, int Row, int column, int troiend)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TroiStart(int Row, int column, int troiend, int idskill)
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetRandomMissCombo(int lvtb1, int lvtb2)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetRandomMissDrop(int Idnpc)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetRandomSkillNPC(int lv, int reborn, int skill1, int skill2, int skill3)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetRandomMissAttack(int lv1, int lv2, int lvtb1, int lvtb2)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetRandomMissChayTron(int lv1, int lv2, int lvtb1, int lvtb2)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetRandomMissTroi(int lv1, int lv2, int lvtb1, int lvtb2, int int1, int int2, int reborn1, int reborn2)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int RandomizeArray(ArrayList items)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int RandomizeArrayWithPercent(int value1, int value2, int percentvalue1 = 100)
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetThuoctinhKhac(int thuoctinh1, int thuoctinh2)
		{
			return 0;
		}
		[DebuggerStepThrough, CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _Lambda$__2(object a0)
		{
		}
		[DebuggerStepThrough, CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _Lambda$__3(object a0)
		{
		}
		[DebuggerStepThrough, CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _Lambda$__4(object a0)
		{
		}
		static TheBattle()
		{
			i4iw8SpaFI6rqcQywY.UUCbAVAAM();
		}
	}
}
