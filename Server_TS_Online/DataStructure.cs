using Microsoft.VisualBasic.CompilerServices;
using System;
namespace Server_TS_Online
{
	[StandardModule]
	public sealed class DataStructure
	{
		public struct Packet
		{
			public static string _Header;
			static Packet()
			{
				DataStructure.Packet._Header = "F444";
			}
		}
		public struct TeamDeffender
		{
			public int _id1;
			public int _id2;
			public int _id3;
			public int _id4;
			public int _id5;
			public int _id6;
			public int _id7;
			public int _id8;
			public int _id9;
			public int _id10;
		}
		public struct HomdoInfo
		{
			public int _ID;
			public int _Lv;
			public int _Count;
			public int _Doben;
			public int _Int1;
			public int _Atk1;
			public int _Def1;
			public int _Hpx1;
			public int _Spx1;
			public int _Agi1;
			public int _Fai1;
			public int _Int2;
			public int _Atk2;
			public int _Def2;
			public int _Hpx2;
			public int _Spx2;
			public int _Agi2;
			public int _Fai2;
			public int _Hp;
			public int _Sp;
			public int _Long;
			public int _GiatriLong;
			public int _Khang;
			public int _Thuoctinh;
			public int _GiatriThuoctinh;
			public int _Loai;
			public int _TExp;
		}
		public struct Npcs
		{
			public int _Id;
			public string _Name;
			public int _Lv;
			public int _Thuoctinh;
			public int _Hp;
			public int _Sp;
			public int _Hpx;
			public int _Spx;
			public int _Int;
			public int _Atk;
			public int _Def;
			public int _Agi;
			public int _Skill1;
			public int _Skill2;
			public int _Skill3;
			public int _Item1;
			public int _Item2;
			public int _Item3;
			public int _Item4;
			public int _Item5;
			public int _Item6;
			public int _Bat;
			public int _Reborn;
		}
		public struct Skills
		{
			public int _ID;
			public int _Sp;
			public int _Point;
			public int _Thuoctinh;
			public int _IdDK1;
			public int _IdDK2;
			public int _IdDK3;
			public int _IdDK4;
			public int _IdDK5;
			public int _IdDK6;
			public int _LvMax;
			public int _Type;
			public int _DoManh;
			public int _SLdanh;
			public int _Reborn;
			public int _Combo;
			public int _Delay;
			public int _TroiBuff;
		}
		public struct BattleGates_key
		{
			public int _MapId;
			public int _WarpId;
		}
		public struct BattleGates
		{
			public int _MapId;
			public int _WarpId;
			public int _Diahinh;
			public int _1;
			public int _2;
			public int _3;
			public int _4;
			public int _5;
			public int _6;
			public int _7;
			public int _8;
			public int _9;
			public int _10;
		}
		public struct Items
		{
			public int _id;
			public string _Name;
			public int _Lv;
			public int _Hp;
			public int _Sp;
			public int _Int1;
			public int _Atk1;
			public int _Def1;
			public int _Hpx1;
			public int _Spx1;
			public int _Agi1;
			public int _Fai1;
			public int _Int2;
			public int _Atk2;
			public int _Def2;
			public int _Hpx2;
			public int _Spx2;
			public int _Agi2;
			public int _Fai2;
			public int _Thuoctinh;
			public int _GiatriThuoctinh;
			public int _Loai;
		}
		public struct Warps
		{
			public int _MapId1;
			public int _WarpId;
			public int _MapId2;
			public int _X;
			public int _Y;
			public int _Battle;
		}
		public struct Key_Warps
		{
			public int _MapId1;
			public int _WarpId;
		}
		public struct _MyPet
		{
			public int _Id;
			public string _Name;
			public int _Quest;
		}
		public struct _Texp
		{
			public int _Lv;
			public int _0;
			public int _1;
			public int _2;
		}
		public struct _Talk
		{
			public int _MapId;
			public string _Type;
			public int _Id;
			public int _Count;
			public int _Step;
			public string _1;
			public string _2;
			public string _3;
			public string _4;
			public string _5;
			public string _6;
			public string _7;
			public string _8;
			public string _9;
			public string _10;
		}
		public struct Key_Talk
		{
			public int _MapId;
			public string _Type;
			public int _Id;
			public int _Step;
		}
		public struct Key_NpcOnMap
		{
			public int _MapId;
			public int _Id;
		}
		public struct _NpcOnMap
		{
			public int _MapId;
			public int _Id;
			public int _NpcId;
			public int _X_First;
			public int _Y_First;
			public int _Coord;
			public int _X;
			public int _Y;
			public int _Delay;
			public int _SoLuong;
			public int _IdBattle;
		}
		public struct Key_ItemOnMap
		{
			public int _MapId;
			public int _ItemId;
			public int _X;
			public int _Y;
		}
		public struct _ItemOnMap
		{
			public int _MapId;
			public int _ItemId;
			public int _X;
			public int _Y;
			public int _Delay;
			public int _DelayDec;
		}
		public struct Key_ItemDropOnMap
		{
			public int _MapId;
			public int _Slot;
		}
		public struct _ItemDropOnMap
		{
			public int _MapId;
			public int _MapX;
			public int _MapY;
			public int _Delay;
			public int _Slot;
			public int _Id;
			public int _Lv;
			public int _Count;
			public int _Doben;
			public int _Int1;
			public int _Atk1;
			public int _Def1;
			public int _Hpx1;
			public int _Spx1;
			public int _Agi1;
			public int _Fai1;
			public int _Int2;
			public int _Atk2;
			public int _Def2;
			public int _Hpx2;
			public int _Spx2;
			public int _Agi2;
			public int _Fai2;
			public int _Hp;
			public int _Sp;
			public int _Long;
			public int _GiatriLong;
			public int _Khang;
			public int _Thuoctinh;
			public int _GiatriThuoctinh;
			public int _Loai;
			public int _TExp;
			public int _Gold;
		}
		public struct WarInfo
		{
			public int _Type;
			public int _Id;
			public int _IdNpcOnMap;
			public int _IdChar;
			public int _Row;
			public int _Column;
			public int _HpMax;
			public int _SpMax;
			public int _Hp;
			public int _Sp;
			public int _Lv;
			public int _Thuoctinh;
			public int _LeaderId;
			public int _IdSkill;
			public int _RowAttack;
			public int _ColumnAttack;
			public int _Int;
			public int _Atk;
			public int _Def;
			public int _Agi;
			public int _Team;
			public int _Random;
			public int _LvSKill;
			public int _Reborn;
			public int _Type3_Id;
			public int _Type3_Lv;
			public int _Type3_Turn;
			public int _Type4_Id;
			public int _Type4_Lv;
			public int _Type4_Turn;
			public int _Type15_Id;
			public int _Type15_Lv;
			public int _Type15_Turn;
			public int _Type19_Id;
			public int _Type19_Lv;
			public int _Type19_Turn;
			public int _Attacked;
			public int _Exp;
			public string _Packet;
		}
		public struct Type_Account
		{
			public static string _Id;
			public static string _pass1;
			public static string _Pass2;
			static Type_Account()
			{
				DataStructure.Type_Account._Id = "Id";
				DataStructure.Type_Account._pass1 = "pass1";
				DataStructure.Type_Account._Pass2 = "Pass2";
			}
		}
		public struct Type_Npc
		{
			public static string _Id;
			public static string _Name;
			public static string _Lv;
			public static string _Thuoctinh;
			public static string _Hp;
			public static string _Sp;
			public static string _Hpx;
			public static string _Spx;
			public static string _Int;
			public static string _Atk;
			public static string _Def;
			public static string _Agi;
			public static string _Skill1;
			public static string _Skill2;
			public static string _Skill3;
			public static string _Item1;
			public static string _Item2;
			public static string _Item3;
			public static string _Item4;
			public static string _Item5;
			public static string _Item6;
			public static string _Bat;
			public static string _Reborn;
			static Type_Npc()
			{
				DataStructure.Type_Npc._Id = "Id";
				DataStructure.Type_Npc._Name = "Name";
				DataStructure.Type_Npc._Lv = "Lv";
				DataStructure.Type_Npc._Thuoctinh = "Thuoctinh";
				DataStructure.Type_Npc._Hp = "Hp";
				DataStructure.Type_Npc._Sp = "Sp";
				DataStructure.Type_Npc._Hpx = "Hpx";
				DataStructure.Type_Npc._Spx = "Spx";
				DataStructure.Type_Npc._Int = "Int";
				DataStructure.Type_Npc._Atk = "Atk";
				DataStructure.Type_Npc._Def = "Def";
				DataStructure.Type_Npc._Agi = "Agi";
				DataStructure.Type_Npc._Skill1 = "Skill1";
				DataStructure.Type_Npc._Skill2 = "Skill2";
				DataStructure.Type_Npc._Skill3 = "Skill3";
				DataStructure.Type_Npc._Item1 = "Item1";
				DataStructure.Type_Npc._Item2 = "Item2";
				DataStructure.Type_Npc._Item3 = "Item3";
				DataStructure.Type_Npc._Item4 = "Item4";
				DataStructure.Type_Npc._Item5 = "Item5";
				DataStructure.Type_Npc._Item6 = "Item6";
				DataStructure.Type_Npc._Bat = "Bat";
				DataStructure.Type_Npc._Reborn = "Reborn";
			}
		}
		public struct Type_Pet
		{
			public static string _Stt;
			public static string _ID;
			public static string _Lv;
			public static string _Name;
			public static string _Thuoctinh;
			public static string _Reborn;
			public static string _Hp;
			public static string _Hpmax;
			public static string _Sp;
			public static string _Spmax;
			public static string _Int;
			public static string _Atk;
			public static string _Def;
			public static string _Hpx;
			public static string _Spx;
			public static string _Agi;
			public static string _Fai;
			public static string _Texp;
			public static string _Int2;
			public static string _Atk2;
			public static string _Def2;
			public static string _Hpx2;
			public static string _Spx2;
			public static string _Agi2;
			public static string _Thd;
			public static string _SkillPoint;
			public static string _Quest;
			public static string _IdSkill1;
			public static string _LvSkill1;
			public static string _IdSkill2;
			public static string _LvSkill2;
			public static string _IdSkill3;
			public static string _LvSkill3;
			public static string _IdSkill4;
			public static string _LvSkill4;
			static Type_Pet()
			{
				DataStructure.Type_Pet._Stt = "Stt";
				DataStructure.Type_Pet._ID = "Id";
				DataStructure.Type_Pet._Lv = "Lv";
				DataStructure.Type_Pet._Name = "Name";
				DataStructure.Type_Pet._Thuoctinh = "Thuoctinh";
				DataStructure.Type_Pet._Reborn = "Reborn";
				DataStructure.Type_Pet._Hp = "Hp";
				DataStructure.Type_Pet._Hpmax = "Hpmax";
				DataStructure.Type_Pet._Sp = "Sp";
				DataStructure.Type_Pet._Spmax = "Spmax";
				DataStructure.Type_Pet._Int = "Int";
				DataStructure.Type_Pet._Atk = "Atk";
				DataStructure.Type_Pet._Def = "Def";
				DataStructure.Type_Pet._Hpx = "Hpx";
				DataStructure.Type_Pet._Spx = "Spx";
				DataStructure.Type_Pet._Agi = "Agi";
				DataStructure.Type_Pet._Fai = "Fai";
				DataStructure.Type_Pet._Texp = "Texp";
				DataStructure.Type_Pet._Int2 = "Int2";
				DataStructure.Type_Pet._Atk2 = "Atk2";
				DataStructure.Type_Pet._Def2 = "Def2";
				DataStructure.Type_Pet._Hpx2 = "Hpx2";
				DataStructure.Type_Pet._Spx2 = "Spx2";
				DataStructure.Type_Pet._Agi2 = "Agi2";
				DataStructure.Type_Pet._Thd = "Thd";
				DataStructure.Type_Pet._SkillPoint = "SkillPoint";
				DataStructure.Type_Pet._Quest = "Quest";
				DataStructure.Type_Pet._IdSkill1 = "IdSkill1";
				DataStructure.Type_Pet._LvSkill1 = "LvSkill1";
				DataStructure.Type_Pet._IdSkill2 = "IdSkill2";
				DataStructure.Type_Pet._LvSkill2 = "LvSkill2";
				DataStructure.Type_Pet._IdSkill3 = "IdSkill3";
				DataStructure.Type_Pet._LvSkill3 = "LvSkill3";
				DataStructure.Type_Pet._IdSkill4 = "IdSkill4";
				DataStructure.Type_Pet._LvSkill4 = "LvSkill4";
			}
		}
		public struct Type_Status
		{
			public static string _Hp;
			public static string _Sp;
			public static string _Int;
			public static string _atk;
			public static string _def;
			public static string _agi;
			public static string _hpx;
			public static string _spx;
			public static string _lv;
			public static string _TExp;
			public static string _SkillPoint;
			public static string _Point;
			public static string _Hpx2;
			public static string _Spx2;
			public static string _Atk2;
			public static string _Def2;
			public static string _Int2;
			public static string _Agi2;
			public static string _TiengTam;
			public static string _Fai;
			static Type_Status()
			{
				DataStructure.Type_Status._Hp = "19";
				DataStructure.Type_Status._Sp = "1A";
				DataStructure.Type_Status._Int = "1B";
				DataStructure.Type_Status._atk = "1C";
				DataStructure.Type_Status._def = "1D";
				DataStructure.Type_Status._agi = "1E";
				DataStructure.Type_Status._hpx = "1F";
				DataStructure.Type_Status._spx = "20";
				DataStructure.Type_Status._lv = "23";
				DataStructure.Type_Status._TExp = "24";
				DataStructure.Type_Status._SkillPoint = "25";
				DataStructure.Type_Status._Point = "26";
				DataStructure.Type_Status._Hpx2 = "CF";
				DataStructure.Type_Status._Spx2 = "D0";
				DataStructure.Type_Status._Atk2 = "D2";
				DataStructure.Type_Status._Def2 = "D3";
				DataStructure.Type_Status._Int2 = "D4";
				DataStructure.Type_Status._Agi2 = "D6";
				DataStructure.Type_Status._TiengTam = "3E";
				DataStructure.Type_Status._Fai = "40";
			}
		}
		public struct Type_Player
		{
			public static string _Id;
			public static string _Name;
			public static string _Lv;
			public static string _Hp;
			public static string _Hpmax;
			public static string _Sp;
			public static string _Spmax;
			public static string _Point;
			public static string _SkillPoint;
			public static string _Int;
			public static string _Atk;
			public static string _Def;
			public static string _Hpx;
			public static string _Spx;
			public static string _Agi;
			public static string _Int2;
			public static string _Atk2;
			public static string _Def2;
			public static string _Hpx2;
			public static string _Spx2;
			public static string _Agi2;
			public static string _TExp;
			public static string _MapId;
			public static string _MapX;
			public static string _MapY;
			public static string _Reborn;
			public static string _Job;
			public static string _Sex;
			public static string _Hair;
			public static string _Thuoctinh;
			public static string _Ghost;
			public static string _God;
			public static string _Color;
			public static string _GOld;
			public static string _Tiengtam;
			public static string _Gocnhin;
			public static string _SttPetXuatChien;
			public static string _Pk;
			public static string _ThamChien;
			static Type_Player()
			{
				DataStructure.Type_Player._Id = "Id";
				DataStructure.Type_Player._Name = "Name";
				DataStructure.Type_Player._Lv = "Lv";
				DataStructure.Type_Player._Hp = "Hp";
				DataStructure.Type_Player._Hpmax = "Hpmax";
				DataStructure.Type_Player._Sp = "Sp";
				DataStructure.Type_Player._Spmax = "Spmax";
				DataStructure.Type_Player._Point = "Point";
				DataStructure.Type_Player._SkillPoint = "SkillPoint";
				DataStructure.Type_Player._Int = "Int";
				DataStructure.Type_Player._Atk = "Atk";
				DataStructure.Type_Player._Def = "Def";
				DataStructure.Type_Player._Hpx = "Hpx";
				DataStructure.Type_Player._Spx = "Spx";
				DataStructure.Type_Player._Agi = "Agi";
				DataStructure.Type_Player._Int2 = "Int2";
				DataStructure.Type_Player._Atk2 = "Atk2";
				DataStructure.Type_Player._Def2 = "Def2";
				DataStructure.Type_Player._Hpx2 = "Hpx2";
				DataStructure.Type_Player._Spx2 = "Spx2";
				DataStructure.Type_Player._Agi2 = "Agi2";
				DataStructure.Type_Player._TExp = "TExp";
				DataStructure.Type_Player._MapId = "MapId";
				DataStructure.Type_Player._MapX = "MapX";
				DataStructure.Type_Player._MapY = "MapY";
				DataStructure.Type_Player._Reborn = "Reborn";
				DataStructure.Type_Player._Job = "Job";
				DataStructure.Type_Player._Sex = "Sex";
				DataStructure.Type_Player._Hair = "Hair";
				DataStructure.Type_Player._Thuoctinh = "Thuoctinh";
				DataStructure.Type_Player._Ghost = "Ghost";
				DataStructure.Type_Player._God = "God";
				DataStructure.Type_Player._Color = "Color";
				DataStructure.Type_Player._GOld = "Gold";
				DataStructure.Type_Player._Tiengtam = "Tiengtam";
				DataStructure.Type_Player._Gocnhin = "Gocnhin";
				DataStructure.Type_Player._SttPetXuatChien = "SttPetXuatChien";
				DataStructure.Type_Player._Pk = "Pk";
				DataStructure.Type_Player._ThamChien = "ThamChien";
			}
		}
		public struct Type_Skill
		{
			public static string _ID;
			public static string _Sp;
			public static string _Point;
			public static string _Thuoctinh;
			public static string _IdDK1;
			public static string _IdDK2;
			public static string _IdDK3;
			public static string _IdDK4;
			public static string _IdDK5;
			public static string _IdDK6;
			public static string _LvMax;
			public static string _Type;
			public static string _DoManh;
			public static string _SLdanh;
			public static string _Reborn;
			public static string _Combo;
			public static string _Delay;
			public static string _TroiBuff;
			static Type_Skill()
			{
				DataStructure.Type_Skill._ID = "Id";
				DataStructure.Type_Skill._Sp = "Sp";
				DataStructure.Type_Skill._Point = "Point";
				DataStructure.Type_Skill._Thuoctinh = "Thuoctinh";
				DataStructure.Type_Skill._IdDK1 = "IdDK1";
				DataStructure.Type_Skill._IdDK2 = "IdDK2";
				DataStructure.Type_Skill._IdDK3 = "IdDK3";
				DataStructure.Type_Skill._IdDK4 = "IdDK4";
				DataStructure.Type_Skill._IdDK5 = "IdDK5";
				DataStructure.Type_Skill._IdDK6 = "IdDK6";
				DataStructure.Type_Skill._LvMax = "LvMax";
				DataStructure.Type_Skill._Type = "Type";
				DataStructure.Type_Skill._DoManh = "DoManh";
				DataStructure.Type_Skill._SLdanh = "SLdanh";
				DataStructure.Type_Skill._Reborn = "Reborn";
				DataStructure.Type_Skill._Combo = "Combo";
				DataStructure.Type_Skill._Delay = "Delay";
				DataStructure.Type_Skill._TroiBuff = "TroiBuff";
			}
		}
		public struct Type_BattleGate
		{
			public static string _Id;
			public static string _Diahinh;
			public static string _1;
			public static string _2;
			public static string _3;
			public static string _4;
			public static string _5;
			public static string _6;
			public static string _7;
			public static string _8;
			public static string _9;
			public static string _10;
			static Type_BattleGate()
			{
				DataStructure.Type_BattleGate._Id = "Id";
				DataStructure.Type_BattleGate._Diahinh = "Diahinh";
				DataStructure.Type_BattleGate._1 = "1";
				DataStructure.Type_BattleGate._2 = "2";
				DataStructure.Type_BattleGate._3 = "3";
				DataStructure.Type_BattleGate._4 = "4";
				DataStructure.Type_BattleGate._5 = "5";
				DataStructure.Type_BattleGate._6 = "6";
				DataStructure.Type_BattleGate._7 = "7";
				DataStructure.Type_BattleGate._8 = "8";
				DataStructure.Type_BattleGate._9 = "9";
				DataStructure.Type_BattleGate._10 = "10";
			}
		}
		public struct Type_Battle
		{
			public static string _Type;
			public static string _Id;
			public static string _IdNpcOnMap;
			public static string _IdChar;
			public static string _Row;
			public static string _Column;
			public static string _HpMax;
			public static string _SpMax;
			public static string _Hp;
			public static string _Sp;
			public static string _Lv;
			public static string _Thuoctinh;
			public static string _LeaderId;
			public static string _IdSkill;
			public static string _RowAttack;
			public static string _ColumnAttack;
			public static string _Int;
			public static string _Atk;
			public static string _Def;
			public static string _Agi;
			public static string _Team;
			public static string _Packet;
			public static string _Random;
			public static string _LvSKill;
			public static string _Reborn;
			public static string _Type3_Id;
			public static string _Type3_Lv;
			public static string _Type3_Turn;
			public static string _Type4_Id;
			public static string _Type4_Lv;
			public static string _Type4_Turn;
			public static string _Type15_Id;
			public static string _Type15_Lv;
			public static string _Type15_Turn;
			public static string _Type19_Id;
			public static string _Type19_Lv;
			public static string _Type19_Turn;
			public static string _Attacked;
			public static string _Exp;
			static Type_Battle()
			{
				DataStructure.Type_Battle._Type = "Type";
				DataStructure.Type_Battle._Id = "Id";
				DataStructure.Type_Battle._IdNpcOnMap = "IdNpcOnMap";
				DataStructure.Type_Battle._IdChar = "IdChar";
				DataStructure.Type_Battle._Row = "Row";
				DataStructure.Type_Battle._Column = "Column";
				DataStructure.Type_Battle._HpMax = "HpMax";
				DataStructure.Type_Battle._SpMax = "SpMax";
				DataStructure.Type_Battle._Hp = "Hp";
				DataStructure.Type_Battle._Sp = "Sp";
				DataStructure.Type_Battle._Lv = "Lv";
				DataStructure.Type_Battle._Thuoctinh = "Thuoctinh";
				DataStructure.Type_Battle._LeaderId = "LeaderId";
				DataStructure.Type_Battle._IdSkill = "IdSkill";
				DataStructure.Type_Battle._RowAttack = "RowAttack";
				DataStructure.Type_Battle._ColumnAttack = "ColumnAttack";
				DataStructure.Type_Battle._Int = "Int";
				DataStructure.Type_Battle._Atk = "Atk";
				DataStructure.Type_Battle._Def = "Def";
				DataStructure.Type_Battle._Agi = "Agi";
				DataStructure.Type_Battle._Team = "Team";
				DataStructure.Type_Battle._Packet = "Packet";
				DataStructure.Type_Battle._Random = "Random";
				DataStructure.Type_Battle._LvSKill = "LvSKill";
				DataStructure.Type_Battle._Reborn = "Reborn";
				DataStructure.Type_Battle._Type3_Id = "Type3_Id";
				DataStructure.Type_Battle._Type3_Lv = "Type3_Lv";
				DataStructure.Type_Battle._Type3_Turn = "Type3_Turn";
				DataStructure.Type_Battle._Type4_Id = "Type4_Id";
				DataStructure.Type_Battle._Type4_Lv = "Type4_Lv";
				DataStructure.Type_Battle._Type4_Turn = "Type4_Turn";
				DataStructure.Type_Battle._Type15_Id = "Type15_Id";
				DataStructure.Type_Battle._Type15_Lv = "Type15_Lv";
				DataStructure.Type_Battle._Type15_Turn = "Type15_Turn";
				DataStructure.Type_Battle._Type19_Id = "Type19_Id";
				DataStructure.Type_Battle._Type19_Lv = "Type19_Lv";
				DataStructure.Type_Battle._Type19_Turn = "Type19_Turn";
				DataStructure.Type_Battle._Attacked = "Attacked";
				DataStructure.Type_Battle._Exp = "Exp";
			}
		}
		public struct Type_MySkill
		{
			public static string _Id;
			public static string _Lv;
			public static string _Sp;
			public static string _Save;
			static Type_MySkill()
			{
				DataStructure.Type_MySkill._Id = "Id";
				DataStructure.Type_MySkill._Lv = "Lv";
				DataStructure.Type_MySkill._Sp = "Sp";
				DataStructure.Type_MySkill._Save = "Save";
			}
		}
		public struct Type_StatusAttack_Def_Lantranh
		{
			public static int _Attack;
			public static int _Def;
			public static int _Lantranh;
			static Type_StatusAttack_Def_Lantranh()
			{
				DataStructure.Type_StatusAttack_Def_Lantranh._Attack = 0;
				DataStructure.Type_StatusAttack_Def_Lantranh._Def = 1;
				DataStructure.Type_StatusAttack_Def_Lantranh._Lantranh = 2;
			}
		}
		public struct Type_StatusAttackMiss
		{
			public static int _Attack;
			public static int _Miss;
			static Type_StatusAttackMiss()
			{
				DataStructure.Type_StatusAttackMiss._Attack = 1;
				DataStructure.Type_StatusAttackMiss._Miss = 0;
			}
		}
		public struct Type_StatusBuffHpSP
		{
			public static int _Attack;
			public static int _Buff;
			static Type_StatusBuffHpSP()
			{
				DataStructure.Type_StatusBuffHpSP._Attack = 1;
				DataStructure.Type_StatusBuffHpSP._Buff = 0;
			}
		}
		public struct Type_StatusTroiBuffHpSp
		{
			public static int _Miss;
			public static int _Type3;
			public static int _Type4;
			public static int _Type15;
			public static int _Type19;
			public static int _Hp;
			public static int _Sp;
			public static int _Hochu;
			static Type_StatusTroiBuffHpSp()
			{
				DataStructure.Type_StatusTroiBuffHpSp._Miss = 0;
				DataStructure.Type_StatusTroiBuffHpSp._Type3 = 221;
				DataStructure.Type_StatusTroiBuffHpSp._Type4 = 222;
				DataStructure.Type_StatusTroiBuffHpSp._Type15 = 223;
				DataStructure.Type_StatusTroiBuffHpSp._Type19 = 225;
				DataStructure.Type_StatusTroiBuffHpSp._Hp = 25;
				DataStructure.Type_StatusTroiBuffHpSp._Sp = 26;
				DataStructure.Type_StatusTroiBuffHpSp._Hochu = 14;
			}
		}
		public struct Type_TroiBuffEnd
		{
			public static int _Type3;
			public static int _Type4;
			public static int _Type15;
			public static int _Type19;
			static Type_TroiBuffEnd()
			{
				DataStructure.Type_TroiBuffEnd._Type3 = 1;
				DataStructure.Type_TroiBuffEnd._Type4 = 2;
				DataStructure.Type_TroiBuffEnd._Type15 = 3;
				DataStructure.Type_TroiBuffEnd._Type19 = 5;
			}
		}
		public struct Type_Homdo
		{
			public static string _ID;
			public static string _Count;
			public static string _Lv;
			public static string _Doben;
			public static string _Int1;
			public static string _Atk1;
			public static string _Def1;
			public static string _Hpx1;
			public static string _Spx1;
			public static string _Agi1;
			public static string _Fai1;
			public static string _Int2;
			public static string _Atk2;
			public static string _Def2;
			public static string _Hpx2;
			public static string _Spx2;
			public static string _Agi2;
			public static string _Fai2;
			public static string _Hp;
			public static string _Sp;
			public static string _Long;
			public static string _GiatriLong;
			public static string _Khang;
			public static string _Thuoctinh;
			public static string _GiatriThuoctinh;
			public static string _Loai;
			public static string _TExp;
			static Type_Homdo()
			{
				DataStructure.Type_Homdo._ID = "Id";
				DataStructure.Type_Homdo._Count = "Count";
				DataStructure.Type_Homdo._Lv = "Lv";
				DataStructure.Type_Homdo._Doben = "Doben";
				DataStructure.Type_Homdo._Int1 = "Int1";
				DataStructure.Type_Homdo._Atk1 = "Atk1";
				DataStructure.Type_Homdo._Def1 = "Def1";
				DataStructure.Type_Homdo._Hpx1 = "Hpx1";
				DataStructure.Type_Homdo._Spx1 = "Spx1";
				DataStructure.Type_Homdo._Agi1 = "Agi1";
				DataStructure.Type_Homdo._Fai1 = "Fai1";
				DataStructure.Type_Homdo._Int2 = "Int2";
				DataStructure.Type_Homdo._Atk2 = "Atk2";
				DataStructure.Type_Homdo._Def2 = "Def2";
				DataStructure.Type_Homdo._Hpx2 = "Hpx2";
				DataStructure.Type_Homdo._Spx2 = "Spx2";
				DataStructure.Type_Homdo._Agi2 = "Agi2";
				DataStructure.Type_Homdo._Fai2 = "Fai2";
				DataStructure.Type_Homdo._Hp = "Hp";
				DataStructure.Type_Homdo._Sp = "Sp";
				DataStructure.Type_Homdo._Long = "Long";
				DataStructure.Type_Homdo._GiatriLong = "GiatriLong";
				DataStructure.Type_Homdo._Khang = "Khang";
				DataStructure.Type_Homdo._Thuoctinh = "Thuoctinh";
				DataStructure.Type_Homdo._GiatriThuoctinh = "GiatriThuoctinh";
				DataStructure.Type_Homdo._Loai = "Loai";
				DataStructure.Type_Homdo._TExp = "TExp";
			}
		}
		public struct Type_Thung
		{
			public static string _Trangbi;
			public static string _Homdo;
			public static string _Tuideo;
			public static string _Luulang;
			static Type_Thung()
			{
				DataStructure.Type_Thung._Trangbi = "Trangbi";
				DataStructure.Type_Thung._Homdo = "Homdo";
				DataStructure.Type_Thung._Tuideo = "Tuideo";
				DataStructure.Type_Thung._Luulang = "Luulang";
			}
		}
		public struct Type_Item
		{
			public static string _id;
			public static string _Name;
			public static string _Lv;
			public static string _Hp;
			public static string _Sp;
			public static string _Int1;
			public static string _Atk1;
			public static string _Def1;
			public static string _Hpx1;
			public static string _Spx1;
			public static string _Agi1;
			public static string _Fai1;
			public static string _Int2;
			public static string _Atk2;
			public static string _Def2;
			public static string _Hpx2;
			public static string _Spx2;
			public static string _Agi2;
			public static string _Fai2;
			public static string _Thuoctinh;
			public static string _GiatriThuoctinh;
			public static string _Loai;
			static Type_Item()
			{
				DataStructure.Type_Item._id = "id";
				DataStructure.Type_Item._Name = "Name";
				DataStructure.Type_Item._Lv = "Lv";
				DataStructure.Type_Item._Hp = "Hp";
				DataStructure.Type_Item._Sp = "Sp";
				DataStructure.Type_Item._Int1 = "Int1";
				DataStructure.Type_Item._Atk1 = "Atk1";
				DataStructure.Type_Item._Def1 = "Def1";
				DataStructure.Type_Item._Hpx1 = "Hpx1";
				DataStructure.Type_Item._Spx1 = "Spx1";
				DataStructure.Type_Item._Agi1 = "Agi1";
				DataStructure.Type_Item._Fai1 = "Fai1";
				DataStructure.Type_Item._Int2 = "Int2";
				DataStructure.Type_Item._Atk2 = "Atk2";
				DataStructure.Type_Item._Def2 = "Def2";
				DataStructure.Type_Item._Hpx2 = "Hpx2";
				DataStructure.Type_Item._Spx2 = "Spx2";
				DataStructure.Type_Item._Agi2 = "Agi2";
				DataStructure.Type_Item._Fai2 = "Fai2";
				DataStructure.Type_Item._Thuoctinh = "Thuoctinh";
				DataStructure.Type_Item._GiatriThuoctinh = "GiatriThuoctinh";
				DataStructure.Type_Item._Loai = "Loai";
			}
		}
		public struct Type_Warp
		{
			public static string _MapId1;
			public static string _WarpId;
			public static string _MapId2;
			public static string _X;
			public static string _Y;
			static Type_Warp()
			{
				DataStructure.Type_Warp._MapId1 = "MapId1";
				DataStructure.Type_Warp._WarpId = "WarpId";
				DataStructure.Type_Warp._MapId2 = "MapId2";
				DataStructure.Type_Warp._X = "X";
				DataStructure.Type_Warp._Y = "Y";
			}
		}
		public struct Type_NpcOnMap
		{
			public static string _MapId;
			public static string _Id;
			public static string _NpcId;
			public static string _X;
			public static string _Y;
			public static string _Coord;
			public static string _SoLuong;
			public static string _Delay;
			public static string _X_First;
			public static string _Y_First;
			public static string _IdBattle;
			static Type_NpcOnMap()
			{
				DataStructure.Type_NpcOnMap._MapId = "MapId";
				DataStructure.Type_NpcOnMap._Id = "Id";
				DataStructure.Type_NpcOnMap._NpcId = "NpcId";
				DataStructure.Type_NpcOnMap._X = "X";
				DataStructure.Type_NpcOnMap._Y = "Y";
				DataStructure.Type_NpcOnMap._Coord = "Coord";
				DataStructure.Type_NpcOnMap._SoLuong = "SoLuong";
				DataStructure.Type_NpcOnMap._Delay = "Delay";
				DataStructure.Type_NpcOnMap._X_First = "X_First";
				DataStructure.Type_NpcOnMap._Y_First = "Y_First";
				DataStructure.Type_NpcOnMap._IdBattle = "IdBattle";
			}
		}
		public struct Type_ItemOnMap
		{
			public static string _MapId;
			public static string _Id;
			public static string _ItemId;
			public static string _X;
			public static string _Y;
			public static string _Delay;
			public static string _DelayDec;
			static Type_ItemOnMap()
			{
				DataStructure.Type_ItemOnMap._MapId = "MapId";
				DataStructure.Type_ItemOnMap._Id = "Id";
				DataStructure.Type_ItemOnMap._ItemId = "ItemId";
				DataStructure.Type_ItemOnMap._X = "X";
				DataStructure.Type_ItemOnMap._Y = "Y";
				DataStructure.Type_ItemOnMap._Delay = "Delay";
				DataStructure.Type_ItemOnMap._DelayDec = "DelayDec";
			}
		}
		public struct Type_GetHp
		{
			public static string _Hp;
			public static string _HpCs;
			public static string _HPTs1;
			public static string _HPTs2;
			public static string _HPTs3;
			public static string _HPTs4;
			static Type_GetHp()
			{
				DataStructure.Type_GetHp._Hp = "FormulaHP";
				DataStructure.Type_GetHp._HpCs = "FormulaHPCS";
				DataStructure.Type_GetHp._HPTs1 = "FormulaHPTS1";
				DataStructure.Type_GetHp._HPTs2 = "FormulaHPTS2";
				DataStructure.Type_GetHp._HPTs3 = "FormulaHPTS3";
				DataStructure.Type_GetHp._HPTs4 = "FormulaHPTS4";
			}
		}
		public struct Type_GetSp
		{
			public static string _Sp;
			public static string _SPCS;
			public static string _SPTs1;
			public static string _SPTs2;
			public static string _SPTs3;
			public static string _SPTs4;
			static Type_GetSp()
			{
				DataStructure.Type_GetSp._Sp = "FormulaSP";
				DataStructure.Type_GetSp._SPCS = "FormulaSPCS";
				DataStructure.Type_GetSp._SPTs1 = "FormulaSPTS1";
				DataStructure.Type_GetSp._SPTs2 = "FormulaSPTS2";
				DataStructure.Type_GetSp._SPTs3 = "FormulaSPTS3";
				DataStructure.Type_GetSp._SPTs4 = "FormulaSPTS4";
			}
		}
		public struct Type_Talk
		{
			public static string _MapId;
			public static string _Type;
			public static string _Id;
			public static string _Count;
			static Type_Talk()
			{
				DataStructure.Type_Talk._MapId = "MapId";
				DataStructure.Type_Talk._Type = "Type";
				DataStructure.Type_Talk._Id = "Id";
				DataStructure.Type_Talk._Count = "Count";
			}
		}
	}
}
