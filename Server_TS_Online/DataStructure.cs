using JuneNameSpace1;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
namespace Server_TS_Online
{
	[StandardModule]
	public sealed class DataStructure
	{
		public struct Packet
		{
			public static string _Header;
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Packet()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Packet._Header = JuneClass02.lxGHuH450(24330);
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
			static TeamDeffender()
			{
				JuneClass02.UUCbAVAAM();
			}
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
			static HomdoInfo()
			{
				JuneClass02.UUCbAVAAM();
			}
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
			static Npcs()
			{
				JuneClass02.UUCbAVAAM();
			}
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
			static Skills()
			{
				JuneClass02.UUCbAVAAM();
			}
		}
		public struct BattleGates
		{
			public int _Id;
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
			static BattleGates()
			{
				JuneClass02.UUCbAVAAM();
			}
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
			static Items()
			{
				JuneClass02.UUCbAVAAM();
			}
		}
		public struct Warps
		{
			public int _MapId1;
			public int _WarpId;
			public int _MapId2;
			public int _X;
			public int _Y;
			public int _Battle;
			static Warps()
			{
				JuneClass02.UUCbAVAAM();
			}
		}
		public struct Key_Warps
		{
			public int _MapId1;
			public int _WarpId;
			static Key_Warps()
			{
				JuneClass02.UUCbAVAAM();
			}
		}
		public struct _MyPet
		{
			public int _Id;
			public string _Name;
			public int _Quest;
			static _MyPet()
			{
				JuneClass02.UUCbAVAAM();
			}
		}
		public struct _Texp
		{
			public int _Lv;
			public int _0;
			public int _1;
			public int _2;
			static _Texp()
			{
				JuneClass02.UUCbAVAAM();
			}
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
			static _Talk()
			{
				JuneClass02.UUCbAVAAM();
			}
		}
		public struct Key_Talk
		{
			public int _MapId;
			public string _Type;
			public int _Id;
			public int _Step;
			static Key_Talk()
			{
				JuneClass02.UUCbAVAAM();
			}
		}
		public struct Key_NpcOnMap
		{
			public int _MapId;
			public int _Id;
			static Key_NpcOnMap()
			{
				JuneClass02.UUCbAVAAM();
			}
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
			static _NpcOnMap()
			{
				JuneClass02.UUCbAVAAM();
			}
		}
		public struct Key_ItemOnMap
		{
			public int _MapId;
			public int _ItemId;
			public int _X;
			public int _Y;
			static Key_ItemOnMap()
			{
				JuneClass02.UUCbAVAAM();
			}
		}
		public struct _ItemOnMap
		{
			public int _MapId;
			public int _ItemId;
			public int _X;
			public int _Y;
			public int _Delay;
			public int _DelayDec;
			static _ItemOnMap()
			{
				JuneClass02.UUCbAVAAM();
			}
		}
		public struct Key_ItemDropOnMap
		{
			public int _MapId;
			public int _Slot;
			static Key_ItemDropOnMap()
			{
				JuneClass02.UUCbAVAAM();
			}
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
			static _ItemDropOnMap()
			{
				JuneClass02.UUCbAVAAM();
			}
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
			static WarInfo()
			{
				JuneClass02.UUCbAVAAM();
			}
		}
		public struct Type_Account
		{
			public static string _Id;
			public static string _pass1;
			public static string _Pass2;
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_Account()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_Account._Id = JuneClass02.lxGHuH450(24342);
				DataStructure.Type_Account._pass1 = JuneClass02.lxGHuH450(24350);
				DataStructure.Type_Account._Pass2 = JuneClass02.lxGHuH450(24364);
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_Npc()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_Npc._Id = JuneClass02.lxGHuH450(24378);
				DataStructure.Type_Npc._Name = JuneClass02.lxGHuH450(24386);
				DataStructure.Type_Npc._Lv = JuneClass02.lxGHuH450(24398);
				DataStructure.Type_Npc._Thuoctinh = JuneClass02.lxGHuH450(24406);
				DataStructure.Type_Npc._Hp = JuneClass02.lxGHuH450(24428);
				DataStructure.Type_Npc._Sp = JuneClass02.lxGHuH450(24436);
				DataStructure.Type_Npc._Hpx = JuneClass02.lxGHuH450(24444);
				DataStructure.Type_Npc._Spx = JuneClass02.lxGHuH450(24454);
				DataStructure.Type_Npc._Int = JuneClass02.lxGHuH450(24464);
				DataStructure.Type_Npc._Atk = JuneClass02.lxGHuH450(24474);
				DataStructure.Type_Npc._Def = JuneClass02.lxGHuH450(24484);
				DataStructure.Type_Npc._Agi = JuneClass02.lxGHuH450(24494);
				DataStructure.Type_Npc._Skill1 = JuneClass02.lxGHuH450(24504);
				DataStructure.Type_Npc._Skill2 = JuneClass02.lxGHuH450(24520);
				DataStructure.Type_Npc._Skill3 = JuneClass02.lxGHuH450(24536);
				DataStructure.Type_Npc._Item1 = JuneClass02.lxGHuH450(24552);
				DataStructure.Type_Npc._Item2 = JuneClass02.lxGHuH450(24566);
				DataStructure.Type_Npc._Item3 = JuneClass02.lxGHuH450(24580);
				DataStructure.Type_Npc._Item4 = JuneClass02.lxGHuH450(24594);
				DataStructure.Type_Npc._Item5 = JuneClass02.lxGHuH450(24608);
				DataStructure.Type_Npc._Item6 = JuneClass02.lxGHuH450(24622);
				DataStructure.Type_Npc._Bat = JuneClass02.lxGHuH450(24636);
				DataStructure.Type_Npc._Reborn = JuneClass02.lxGHuH450(24646);
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_Pet()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_Pet._Stt = JuneClass02.lxGHuH450(24662);
				DataStructure.Type_Pet._ID = JuneClass02.lxGHuH450(24672);
				DataStructure.Type_Pet._Lv = JuneClass02.lxGHuH450(24680);
				DataStructure.Type_Pet._Name = JuneClass02.lxGHuH450(24688);
				DataStructure.Type_Pet._Thuoctinh = JuneClass02.lxGHuH450(24700);
				DataStructure.Type_Pet._Reborn = JuneClass02.lxGHuH450(24722);
				DataStructure.Type_Pet._Hp = JuneClass02.lxGHuH450(24738);
				DataStructure.Type_Pet._Hpmax = JuneClass02.lxGHuH450(24746);
				DataStructure.Type_Pet._Sp = JuneClass02.lxGHuH450(24760);
				DataStructure.Type_Pet._Spmax = JuneClass02.lxGHuH450(24768);
				DataStructure.Type_Pet._Int = JuneClass02.lxGHuH450(24782);
				DataStructure.Type_Pet._Atk = JuneClass02.lxGHuH450(24792);
				DataStructure.Type_Pet._Def = JuneClass02.lxGHuH450(24802);
				DataStructure.Type_Pet._Hpx = JuneClass02.lxGHuH450(24812);
				DataStructure.Type_Pet._Spx = JuneClass02.lxGHuH450(24822);
				DataStructure.Type_Pet._Agi = JuneClass02.lxGHuH450(24832);
				DataStructure.Type_Pet._Fai = JuneClass02.lxGHuH450(24842);
				DataStructure.Type_Pet._Texp = JuneClass02.lxGHuH450(24852);
				DataStructure.Type_Pet._Int2 = JuneClass02.lxGHuH450(24864);
				DataStructure.Type_Pet._Atk2 = JuneClass02.lxGHuH450(24876);
				DataStructure.Type_Pet._Def2 = JuneClass02.lxGHuH450(24888);
				DataStructure.Type_Pet._Hpx2 = JuneClass02.lxGHuH450(24900);
				DataStructure.Type_Pet._Spx2 = JuneClass02.lxGHuH450(24912);
				DataStructure.Type_Pet._Agi2 = JuneClass02.lxGHuH450(24924);
				DataStructure.Type_Pet._Thd = JuneClass02.lxGHuH450(24936);
				DataStructure.Type_Pet._SkillPoint = JuneClass02.lxGHuH450(24946);
				DataStructure.Type_Pet._Quest = JuneClass02.lxGHuH450(24970);
				DataStructure.Type_Pet._IdSkill1 = JuneClass02.lxGHuH450(24984);
				DataStructure.Type_Pet._LvSkill1 = JuneClass02.lxGHuH450(25004);
				DataStructure.Type_Pet._IdSkill2 = JuneClass02.lxGHuH450(25024);
				DataStructure.Type_Pet._LvSkill2 = JuneClass02.lxGHuH450(25044);
				DataStructure.Type_Pet._IdSkill3 = JuneClass02.lxGHuH450(25064);
				DataStructure.Type_Pet._LvSkill3 = JuneClass02.lxGHuH450(25084);
				DataStructure.Type_Pet._IdSkill4 = JuneClass02.lxGHuH450(25104);
				DataStructure.Type_Pet._LvSkill4 = JuneClass02.lxGHuH450(25124);
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_Status()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_Status._Hp = JuneClass02.lxGHuH450(25144);
				DataStructure.Type_Status._Sp = JuneClass02.lxGHuH450(25152);
				DataStructure.Type_Status._Int = JuneClass02.lxGHuH450(25160);
				DataStructure.Type_Status._atk = JuneClass02.lxGHuH450(25168);
				DataStructure.Type_Status._def = JuneClass02.lxGHuH450(25176);
				DataStructure.Type_Status._agi = JuneClass02.lxGHuH450(25184);
				DataStructure.Type_Status._hpx = JuneClass02.lxGHuH450(25192);
				DataStructure.Type_Status._spx = JuneClass02.lxGHuH450(25200);
				DataStructure.Type_Status._lv = JuneClass02.lxGHuH450(25208);
				DataStructure.Type_Status._TExp = JuneClass02.lxGHuH450(25216);
				DataStructure.Type_Status._SkillPoint = JuneClass02.lxGHuH450(25224);
				DataStructure.Type_Status._Point = JuneClass02.lxGHuH450(25232);
				DataStructure.Type_Status._Hpx2 = JuneClass02.lxGHuH450(25240);
				DataStructure.Type_Status._Spx2 = JuneClass02.lxGHuH450(25248);
				DataStructure.Type_Status._Atk2 = JuneClass02.lxGHuH450(25256);
				DataStructure.Type_Status._Def2 = JuneClass02.lxGHuH450(25264);
				DataStructure.Type_Status._Int2 = JuneClass02.lxGHuH450(25272);
				DataStructure.Type_Status._Agi2 = JuneClass02.lxGHuH450(25280);
				DataStructure.Type_Status._TiengTam = JuneClass02.lxGHuH450(25288);
				DataStructure.Type_Status._Fai = JuneClass02.lxGHuH450(25296);
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_Player()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_Player._Id = JuneClass02.lxGHuH450(25304);
				DataStructure.Type_Player._Name = JuneClass02.lxGHuH450(25312);
				DataStructure.Type_Player._Lv = JuneClass02.lxGHuH450(25324);
				DataStructure.Type_Player._Hp = JuneClass02.lxGHuH450(25332);
				DataStructure.Type_Player._Hpmax = JuneClass02.lxGHuH450(25340);
				DataStructure.Type_Player._Sp = JuneClass02.lxGHuH450(25354);
				DataStructure.Type_Player._Spmax = JuneClass02.lxGHuH450(25362);
				DataStructure.Type_Player._Point = JuneClass02.lxGHuH450(25376);
				DataStructure.Type_Player._SkillPoint = JuneClass02.lxGHuH450(25390);
				DataStructure.Type_Player._Int = JuneClass02.lxGHuH450(25414);
				DataStructure.Type_Player._Atk = JuneClass02.lxGHuH450(25424);
				DataStructure.Type_Player._Def = JuneClass02.lxGHuH450(25434);
				DataStructure.Type_Player._Hpx = JuneClass02.lxGHuH450(25444);
				DataStructure.Type_Player._Spx = JuneClass02.lxGHuH450(25454);
				DataStructure.Type_Player._Agi = JuneClass02.lxGHuH450(25464);
				DataStructure.Type_Player._Int2 = JuneClass02.lxGHuH450(25474);
				DataStructure.Type_Player._Atk2 = JuneClass02.lxGHuH450(25486);
				DataStructure.Type_Player._Def2 = JuneClass02.lxGHuH450(25498);
				DataStructure.Type_Player._Hpx2 = JuneClass02.lxGHuH450(25510);
				DataStructure.Type_Player._Spx2 = JuneClass02.lxGHuH450(25522);
				DataStructure.Type_Player._Agi2 = JuneClass02.lxGHuH450(25534);
				DataStructure.Type_Player._TExp = JuneClass02.lxGHuH450(25546);
				DataStructure.Type_Player._MapId = JuneClass02.lxGHuH450(25558);
				DataStructure.Type_Player._MapX = JuneClass02.lxGHuH450(25572);
				DataStructure.Type_Player._MapY = JuneClass02.lxGHuH450(25584);
				DataStructure.Type_Player._Reborn = JuneClass02.lxGHuH450(25596);
				DataStructure.Type_Player._Job = JuneClass02.lxGHuH450(25612);
				DataStructure.Type_Player._Sex = JuneClass02.lxGHuH450(25622);
				DataStructure.Type_Player._Hair = JuneClass02.lxGHuH450(25632);
				DataStructure.Type_Player._Thuoctinh = JuneClass02.lxGHuH450(25644);
				DataStructure.Type_Player._Ghost = JuneClass02.lxGHuH450(25666);
				DataStructure.Type_Player._God = JuneClass02.lxGHuH450(25680);
				DataStructure.Type_Player._Color = JuneClass02.lxGHuH450(25690);
				DataStructure.Type_Player._GOld = JuneClass02.lxGHuH450(25704);
				DataStructure.Type_Player._Tiengtam = JuneClass02.lxGHuH450(25716);
				DataStructure.Type_Player._Gocnhin = JuneClass02.lxGHuH450(25736);
				DataStructure.Type_Player._SttPetXuatChien = JuneClass02.lxGHuH450(25754);
				DataStructure.Type_Player._Pk = JuneClass02.lxGHuH450(25788);
				DataStructure.Type_Player._ThamChien = JuneClass02.lxGHuH450(25796);
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_Skill()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_Skill._ID = JuneClass02.lxGHuH450(25818);
				DataStructure.Type_Skill._Sp = JuneClass02.lxGHuH450(25826);
				DataStructure.Type_Skill._Point = JuneClass02.lxGHuH450(25834);
				DataStructure.Type_Skill._Thuoctinh = JuneClass02.lxGHuH450(25848);
				DataStructure.Type_Skill._IdDK1 = JuneClass02.lxGHuH450(25870);
				DataStructure.Type_Skill._IdDK2 = JuneClass02.lxGHuH450(25884);
				DataStructure.Type_Skill._IdDK3 = JuneClass02.lxGHuH450(25898);
				DataStructure.Type_Skill._IdDK4 = JuneClass02.lxGHuH450(25912);
				DataStructure.Type_Skill._IdDK5 = JuneClass02.lxGHuH450(25926);
				DataStructure.Type_Skill._IdDK6 = JuneClass02.lxGHuH450(25940);
				DataStructure.Type_Skill._LvMax = JuneClass02.lxGHuH450(25954);
				DataStructure.Type_Skill._Type = JuneClass02.lxGHuH450(25968);
				DataStructure.Type_Skill._DoManh = JuneClass02.lxGHuH450(25980);
				DataStructure.Type_Skill._SLdanh = JuneClass02.lxGHuH450(25996);
				DataStructure.Type_Skill._Reborn = JuneClass02.lxGHuH450(26012);
				DataStructure.Type_Skill._Combo = JuneClass02.lxGHuH450(26028);
				DataStructure.Type_Skill._Delay = JuneClass02.lxGHuH450(26042);
				DataStructure.Type_Skill._TroiBuff = JuneClass02.lxGHuH450(26056);
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_BattleGate()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_BattleGate._Id = JuneClass02.lxGHuH450(26076);
				DataStructure.Type_BattleGate._Diahinh = JuneClass02.lxGHuH450(26084);
				DataStructure.Type_BattleGate._1 = JuneClass02.lxGHuH450(26102);
				DataStructure.Type_BattleGate._2 = JuneClass02.lxGHuH450(26108);
				DataStructure.Type_BattleGate._3 = JuneClass02.lxGHuH450(26114);
				DataStructure.Type_BattleGate._4 = JuneClass02.lxGHuH450(26120);
				DataStructure.Type_BattleGate._5 = JuneClass02.lxGHuH450(26126);
				DataStructure.Type_BattleGate._6 = JuneClass02.lxGHuH450(26132);
				DataStructure.Type_BattleGate._7 = JuneClass02.lxGHuH450(26138);
				DataStructure.Type_BattleGate._8 = JuneClass02.lxGHuH450(26144);
				DataStructure.Type_BattleGate._9 = JuneClass02.lxGHuH450(26150);
				DataStructure.Type_BattleGate._10 = JuneClass02.lxGHuH450(26156);
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_Battle()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_Battle._Type = JuneClass02.lxGHuH450(26164);
				DataStructure.Type_Battle._Id = JuneClass02.lxGHuH450(26176);
				DataStructure.Type_Battle._IdNpcOnMap = JuneClass02.lxGHuH450(26184);
				DataStructure.Type_Battle._IdChar = JuneClass02.lxGHuH450(26208);
				DataStructure.Type_Battle._Row = JuneClass02.lxGHuH450(26224);
				DataStructure.Type_Battle._Column = JuneClass02.lxGHuH450(26234);
				DataStructure.Type_Battle._HpMax = JuneClass02.lxGHuH450(26250);
				DataStructure.Type_Battle._SpMax = JuneClass02.lxGHuH450(26264);
				DataStructure.Type_Battle._Hp = JuneClass02.lxGHuH450(26278);
				DataStructure.Type_Battle._Sp = JuneClass02.lxGHuH450(26286);
				DataStructure.Type_Battle._Lv = JuneClass02.lxGHuH450(26294);
				DataStructure.Type_Battle._Thuoctinh = JuneClass02.lxGHuH450(26302);
				DataStructure.Type_Battle._LeaderId = JuneClass02.lxGHuH450(26324);
				DataStructure.Type_Battle._IdSkill = JuneClass02.lxGHuH450(26344);
				DataStructure.Type_Battle._RowAttack = JuneClass02.lxGHuH450(26362);
				DataStructure.Type_Battle._ColumnAttack = JuneClass02.lxGHuH450(26384);
				DataStructure.Type_Battle._Int = JuneClass02.lxGHuH450(26412);
				DataStructure.Type_Battle._Atk = JuneClass02.lxGHuH450(26422);
				DataStructure.Type_Battle._Def = JuneClass02.lxGHuH450(26432);
				DataStructure.Type_Battle._Agi = JuneClass02.lxGHuH450(26442);
				DataStructure.Type_Battle._Team = JuneClass02.lxGHuH450(26452);
				DataStructure.Type_Battle._Packet = JuneClass02.lxGHuH450(26464);
				DataStructure.Type_Battle._Random = JuneClass02.lxGHuH450(26480);
				DataStructure.Type_Battle._LvSKill = JuneClass02.lxGHuH450(26496);
				DataStructure.Type_Battle._Reborn = JuneClass02.lxGHuH450(26514);
				DataStructure.Type_Battle._Type3_Id = JuneClass02.lxGHuH450(26530);
				DataStructure.Type_Battle._Type3_Lv = JuneClass02.lxGHuH450(26550);
				DataStructure.Type_Battle._Type3_Turn = JuneClass02.lxGHuH450(26570);
				DataStructure.Type_Battle._Type4_Id = JuneClass02.lxGHuH450(26594);
				DataStructure.Type_Battle._Type4_Lv = JuneClass02.lxGHuH450(26614);
				DataStructure.Type_Battle._Type4_Turn = JuneClass02.lxGHuH450(26634);
				DataStructure.Type_Battle._Type15_Id = JuneClass02.lxGHuH450(26658);
				DataStructure.Type_Battle._Type15_Lv = JuneClass02.lxGHuH450(26680);
				DataStructure.Type_Battle._Type15_Turn = JuneClass02.lxGHuH450(26702);
				DataStructure.Type_Battle._Type19_Id = JuneClass02.lxGHuH450(26728);
				DataStructure.Type_Battle._Type19_Lv = JuneClass02.lxGHuH450(26750);
				DataStructure.Type_Battle._Type19_Turn = JuneClass02.lxGHuH450(26772);
				DataStructure.Type_Battle._Attacked = JuneClass02.lxGHuH450(26798);
				DataStructure.Type_Battle._Exp = JuneClass02.lxGHuH450(26818);
			}
		}
		public struct Type_MySkill
		{
			public static string _Id;
			public static string _Lv;
			public static string _Sp;
			public static string _Save;
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_MySkill()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_MySkill._Id = JuneClass02.lxGHuH450(26828);
				DataStructure.Type_MySkill._Lv = JuneClass02.lxGHuH450(26836);
				DataStructure.Type_MySkill._Sp = JuneClass02.lxGHuH450(26844);
				DataStructure.Type_MySkill._Save = JuneClass02.lxGHuH450(26852);
			}
		}
		public struct Type_StatusAttack_Def_Lantranh
		{
			public static int _Attack;
			public static int _Def;
			public static int _Lantranh;
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_StatusAttack_Def_Lantranh()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_StatusAttack_Def_Lantranh._Attack = 0;
				DataStructure.Type_StatusAttack_Def_Lantranh._Def = 1;
				DataStructure.Type_StatusAttack_Def_Lantranh._Lantranh = 2;
			}
		}
		public struct Type_StatusAttackMiss
		{
			public static int _Attack;
			public static int _Miss;
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_StatusAttackMiss()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_StatusAttackMiss._Attack = 1;
				DataStructure.Type_StatusAttackMiss._Miss = 0;
			}
		}
		public struct Type_StatusBuffHpSP
		{
			public static int _Attack;
			public static int _Buff;
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_StatusBuffHpSP()
			{
				JuneClass02.UUCbAVAAM();
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_StatusTroiBuffHpSp()
			{
				JuneClass02.UUCbAVAAM();
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_TroiBuffEnd()
			{
				JuneClass02.UUCbAVAAM();
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_Homdo()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_Homdo._ID = JuneClass02.lxGHuH450(26864);
				DataStructure.Type_Homdo._Count = JuneClass02.lxGHuH450(26872);
				DataStructure.Type_Homdo._Lv = JuneClass02.lxGHuH450(26886);
				DataStructure.Type_Homdo._Doben = JuneClass02.lxGHuH450(26894);
				DataStructure.Type_Homdo._Int1 = JuneClass02.lxGHuH450(26908);
				DataStructure.Type_Homdo._Atk1 = JuneClass02.lxGHuH450(26920);
				DataStructure.Type_Homdo._Def1 = JuneClass02.lxGHuH450(26932);
				DataStructure.Type_Homdo._Hpx1 = JuneClass02.lxGHuH450(26944);
				DataStructure.Type_Homdo._Spx1 = JuneClass02.lxGHuH450(26956);
				DataStructure.Type_Homdo._Agi1 = JuneClass02.lxGHuH450(26968);
				DataStructure.Type_Homdo._Fai1 = JuneClass02.lxGHuH450(26980);
				DataStructure.Type_Homdo._Int2 = JuneClass02.lxGHuH450(26992);
				DataStructure.Type_Homdo._Atk2 = JuneClass02.lxGHuH450(27004);
				DataStructure.Type_Homdo._Def2 = JuneClass02.lxGHuH450(27016);
				DataStructure.Type_Homdo._Hpx2 = JuneClass02.lxGHuH450(27028);
				DataStructure.Type_Homdo._Spx2 = JuneClass02.lxGHuH450(27040);
				DataStructure.Type_Homdo._Agi2 = JuneClass02.lxGHuH450(27052);
				DataStructure.Type_Homdo._Fai2 = JuneClass02.lxGHuH450(27064);
				DataStructure.Type_Homdo._Hp = JuneClass02.lxGHuH450(27076);
				DataStructure.Type_Homdo._Sp = JuneClass02.lxGHuH450(27084);
				DataStructure.Type_Homdo._Long = JuneClass02.lxGHuH450(27092);
				DataStructure.Type_Homdo._GiatriLong = JuneClass02.lxGHuH450(27104);
				DataStructure.Type_Homdo._Khang = JuneClass02.lxGHuH450(27128);
				DataStructure.Type_Homdo._Thuoctinh = JuneClass02.lxGHuH450(27142);
				DataStructure.Type_Homdo._GiatriThuoctinh = JuneClass02.lxGHuH450(27164);
				DataStructure.Type_Homdo._Loai = JuneClass02.lxGHuH450(27198);
				DataStructure.Type_Homdo._TExp = JuneClass02.lxGHuH450(27210);
			}
		}
		public struct Type_Thung
		{
			public static string _Trangbi;
			public static string _Homdo;
			public static string _Tuideo;
			public static string _Luulang;
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_Thung()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_Thung._Trangbi = JuneClass02.lxGHuH450(27222);
				DataStructure.Type_Thung._Homdo = JuneClass02.lxGHuH450(27240);
				DataStructure.Type_Thung._Tuideo = JuneClass02.lxGHuH450(27254);
				DataStructure.Type_Thung._Luulang = JuneClass02.lxGHuH450(27270);
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_Item()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_Item._id = JuneClass02.lxGHuH450(27288);
				DataStructure.Type_Item._Name = JuneClass02.lxGHuH450(27296);
				DataStructure.Type_Item._Lv = JuneClass02.lxGHuH450(27308);
				DataStructure.Type_Item._Hp = JuneClass02.lxGHuH450(27316);
				DataStructure.Type_Item._Sp = JuneClass02.lxGHuH450(27324);
				DataStructure.Type_Item._Int1 = JuneClass02.lxGHuH450(27332);
				DataStructure.Type_Item._Atk1 = JuneClass02.lxGHuH450(27344);
				DataStructure.Type_Item._Def1 = JuneClass02.lxGHuH450(27356);
				DataStructure.Type_Item._Hpx1 = JuneClass02.lxGHuH450(27368);
				DataStructure.Type_Item._Spx1 = JuneClass02.lxGHuH450(27380);
				DataStructure.Type_Item._Agi1 = JuneClass02.lxGHuH450(27392);
				DataStructure.Type_Item._Fai1 = JuneClass02.lxGHuH450(27404);
				DataStructure.Type_Item._Int2 = JuneClass02.lxGHuH450(27416);
				DataStructure.Type_Item._Atk2 = JuneClass02.lxGHuH450(27428);
				DataStructure.Type_Item._Def2 = JuneClass02.lxGHuH450(27440);
				DataStructure.Type_Item._Hpx2 = JuneClass02.lxGHuH450(27452);
				DataStructure.Type_Item._Spx2 = JuneClass02.lxGHuH450(27464);
				DataStructure.Type_Item._Agi2 = JuneClass02.lxGHuH450(27476);
				DataStructure.Type_Item._Fai2 = JuneClass02.lxGHuH450(27488);
				DataStructure.Type_Item._Thuoctinh = JuneClass02.lxGHuH450(27500);
				DataStructure.Type_Item._GiatriThuoctinh = JuneClass02.lxGHuH450(27522);
				DataStructure.Type_Item._Loai = JuneClass02.lxGHuH450(27556);
			}
		}
		public struct Type_Warp
		{
			public static string _MapId1;
			public static string _WarpId;
			public static string _MapId2;
			public static string _X;
			public static string _Y;
			public static string _Goxnhin;
			public static string _Battle;
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_Warp()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_Warp._MapId1 = JuneClass02.lxGHuH450(27568);
				DataStructure.Type_Warp._WarpId = JuneClass02.lxGHuH450(27584);
				DataStructure.Type_Warp._MapId2 = JuneClass02.lxGHuH450(27600);
				DataStructure.Type_Warp._X = JuneClass02.lxGHuH450(27616);
				DataStructure.Type_Warp._Y = JuneClass02.lxGHuH450(27622);
				DataStructure.Type_Warp._Goxnhin = JuneClass02.lxGHuH450(27628);
				DataStructure.Type_Warp._Battle = JuneClass02.lxGHuH450(27646);
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_NpcOnMap()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_NpcOnMap._MapId = JuneClass02.lxGHuH450(27662);
				DataStructure.Type_NpcOnMap._Id = JuneClass02.lxGHuH450(27676);
				DataStructure.Type_NpcOnMap._NpcId = JuneClass02.lxGHuH450(27684);
				DataStructure.Type_NpcOnMap._X = JuneClass02.lxGHuH450(27698);
				DataStructure.Type_NpcOnMap._Y = JuneClass02.lxGHuH450(27704);
				DataStructure.Type_NpcOnMap._Coord = JuneClass02.lxGHuH450(27710);
				DataStructure.Type_NpcOnMap._SoLuong = JuneClass02.lxGHuH450(27724);
				DataStructure.Type_NpcOnMap._Delay = JuneClass02.lxGHuH450(27742);
				DataStructure.Type_NpcOnMap._X_First = JuneClass02.lxGHuH450(27756);
				DataStructure.Type_NpcOnMap._Y_First = JuneClass02.lxGHuH450(27774);
				DataStructure.Type_NpcOnMap._IdBattle = JuneClass02.lxGHuH450(27792);
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_ItemOnMap()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_ItemOnMap._MapId = JuneClass02.lxGHuH450(27812);
				DataStructure.Type_ItemOnMap._Id = JuneClass02.lxGHuH450(27826);
				DataStructure.Type_ItemOnMap._ItemId = JuneClass02.lxGHuH450(27834);
				DataStructure.Type_ItemOnMap._X = JuneClass02.lxGHuH450(27850);
				DataStructure.Type_ItemOnMap._Y = JuneClass02.lxGHuH450(27856);
				DataStructure.Type_ItemOnMap._Delay = JuneClass02.lxGHuH450(27862);
				DataStructure.Type_ItemOnMap._DelayDec = JuneClass02.lxGHuH450(27876);
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_GetHp()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_GetHp._Hp = JuneClass02.lxGHuH450(27896);
				DataStructure.Type_GetHp._HpCs = JuneClass02.lxGHuH450(27918);
				DataStructure.Type_GetHp._HPTs1 = JuneClass02.lxGHuH450(27944);
				DataStructure.Type_GetHp._HPTs2 = JuneClass02.lxGHuH450(27972);
				DataStructure.Type_GetHp._HPTs3 = JuneClass02.lxGHuH450(28000);
				DataStructure.Type_GetHp._HPTs4 = JuneClass02.lxGHuH450(28028);
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_GetSp()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_GetSp._Sp = JuneClass02.lxGHuH450(28056);
				DataStructure.Type_GetSp._SPCS = JuneClass02.lxGHuH450(28078);
				DataStructure.Type_GetSp._SPTs1 = JuneClass02.lxGHuH450(28104);
				DataStructure.Type_GetSp._SPTs2 = JuneClass02.lxGHuH450(28132);
				DataStructure.Type_GetSp._SPTs3 = JuneClass02.lxGHuH450(28160);
				DataStructure.Type_GetSp._SPTs4 = JuneClass02.lxGHuH450(28188);
			}
		}
		public struct Type_Talk
		{
			public static string _MapId;
			public static string _Type;
			public static string _Id;
			public static string _Count;
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Type_Talk()
			{
				JuneClass02.UUCbAVAAM();
				DataStructure.Type_Talk._MapId = JuneClass02.lxGHuH450(28216);
				DataStructure.Type_Talk._Type = JuneClass02.lxGHuH450(28230);
				DataStructure.Type_Talk._Id = JuneClass02.lxGHuH450(28242);
				DataStructure.Type_Talk._Count = JuneClass02.lxGHuH450(28250);
			}
		}
		static DataStructure()
		{
			JuneClass02.UUCbAVAAM();
		}
	}
}
