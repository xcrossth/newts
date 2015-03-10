using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
namespace Server_TS_Online
{
	public class TheBattle
	{
		public Dictionary<string, DataStructure.WarInfo> ListWar;
		public Dictionary<int, int> ListQS;
		public ArrayList _keys;
		public int _idBattle;
		public int _Diahinh;
		private Random random_0;
		private Random random_1;
		private Random random_2;
		public void CreatNewBattle()
		{
			int num = 1;
			checked
			{
				do
				{
					this.ListQS.Add(num, 0);
					num++;
				}
				while (num <= 50);
				int num2 = 0;
				do
				{
					int num3 = 0;
					do
					{
						DataStructure.WarInfo value = default(DataStructure.WarInfo);
						value._Row = num2;
						value._Column = num3;
						this.ListWar.Add(Class5.smethod_3(new byte[]
						{
							(byte)num2,
							(byte)num3
						}), value);
						this._keys.Add(Class5.smethod_3(new byte[]
						{
							(byte)num2,
							(byte)num3
						}));
						num3++;
					}
					while (num3 <= 4);
					num2++;
				}
				while (num2 <= 3);
			}
		}
		public void ChangedWar(string _key, int Type, int Id, int IdNpcOnMap, int IdChar, int HpMax, int SpMax, int Hp, int Sp, int Lv, int Thuoctinh, int LeaderId, int IdSkill, int RowAttack, int ColumnAttack, int Team, int Int, int Atk, int Def, int Agi, int Reborn, int Type3_Id, int Type3_Lv, int Type3_Turn, int Type4_Id, int Type4_Lv, int Type4_Turn, int Type15_Id, int Type15_Lv, int Type15_Turn, int Type19_Id, int Type19_Lv, int Type19_Turn, int Attacked, int Exp)
		{
			DataStructure.WarInfo value = this.ListWar[_key];
			value._Type = Type;
			value._Id = Id;
			value._IdNpcOnMap = IdNpcOnMap;
			value._IdChar = IdChar;
			value._HpMax = HpMax;
			value._SpMax = SpMax;
			value._Hp = Hp;
			value._Sp = Sp;
			value._Lv = Lv;
			value._Thuoctinh = Thuoctinh;
			value._LeaderId = LeaderId;
			value._IdSkill = IdSkill;
			value._RowAttack = RowAttack;
			value._ColumnAttack = ColumnAttack;
			value._Team = Team;
			value._Int = Int;
			value._Atk = Atk;
			value._Def = Def;
			value._Agi = Agi;
			value._Reborn = Reborn;
			value._Type3_Id = Type3_Id;
			value._Type3_Lv = Type3_Lv;
			value._Type3_Turn = Type3_Turn;
			value._Type4_Id = Type4_Id;
			value._Type4_Lv = Type4_Lv;
			value._Type4_Turn = Type4_Turn;
			value._Type15_Id = Type15_Id;
			value._Type15_Lv = Type15_Lv;
			value._Type15_Turn = Type15_Turn;
			value._Type19_Id = Type19_Id;
			value._Type19_Lv = Type19_Lv;
			value._Type19_Turn = Type19_Turn;
			value._Attacked = Attacked;
			value._Exp = Exp;
			string packet = string.Concat(new string[]
			{
				Type.ToString("X2"),
				Class5.smethod_12(Id),
				Class5.smethod_11(IdNpcOnMap),
				Class5.smethod_12(IdChar),
				Class5.smethod_4(_key)[0].ToString("X2"),
				Class5.smethod_4(_key)[1].ToString("X2"),
				Class5.smethod_11(HpMax),
				Class5.smethod_11(SpMax),
				Class5.smethod_11(Hp),
				Class5.smethod_11(Sp),
				Lv.ToString("X2"),
				Thuoctinh.ToString("X2")
			});
			value._Packet = packet;
			this.ListWar[_key] = value;
		}
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void AddToBattle(int IdLeader, int IdMem1, int IdMem2, int IdMem3, int IdMem4, int _row, int _Column)
		{
			int team = 1;
			if (_row == 0)
			{
				team = 2;
			}
			checked
			{
				if (Server.Clients.ContainsKey(IdLeader))
				{
					Server.Clients[IdLeader]._My_IdBattle = this._idBattle;
					Server.Clients[IdLeader]._my_DiaHinh = this._Diahinh;
					Client client = Server.Clients[IdLeader];
					this.ChangedWar(Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					}), 2, client._My_Id, 0, 0, client._My_HpMax, client._My_SpMax, client._My_Hp, client._My_Sp, client._My_Lv, client._My_Thuoctinh, IdLeader, 0, 0, 0, team, client._My_Int + client._My_Int2, client._My_Atk + client._My_Atk2, client._My_Def + client._My_Def2, client._My_Agi + client._My_Agi2, client._My_Reborn, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
					int my_SttPetXuatChien = client._My_SttPetXuatChien;
					if (my_SttPetXuatChien > 0 & my_SttPetXuatChien <= 4)
					{
						string str = Class1.Form0_0.Info.DirectoryPath + "\\member\\vn" + IdLeader.ToString() + ".accdb";
						OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + str + ";Persist Security Info=False;");
						OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Pet Where Stt = " + Conversions.ToString(my_SttPetXuatChien), oleDbConnection);
						if (oleDbConnection.State == ConnectionState.Closed)
						{
							oleDbConnection.Open();
						}
						OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
						if (oleDbDataReader.Read())
						{
							int id = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._ID]);
							int hpMax = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Hpmax]);
							int spMax = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Spmax]);
							int hp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Hp]);
							int sp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Sp]);
							int lv = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Lv]);
							int thuoctinh = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Thuoctinh]);
							int reborn = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Reborn]);
							int @int = Conversions.ToInteger(Operators.AddObject(oleDbDataReader[DataStructure.Type_Pet._Int], oleDbDataReader[DataStructure.Type_Pet._Int2]));
							int atk = Conversions.ToInteger(Operators.AddObject(oleDbDataReader[DataStructure.Type_Pet._Atk], oleDbDataReader[DataStructure.Type_Pet._Atk2]));
							int def = Conversions.ToInteger(Operators.AddObject(oleDbDataReader[DataStructure.Type_Pet._Def], oleDbDataReader[DataStructure.Type_Pet._Def2]));
							int agi = Conversions.ToInteger(Operators.AddObject(oleDbDataReader[DataStructure.Type_Pet._Agi], oleDbDataReader[DataStructure.Type_Pet._Agi2]));
							this.ChangedWar(Class5.smethod_3(new byte[]
							{
								(byte)(_row ^ 1),
								(byte)_Column
							}), 4, id, my_SttPetXuatChien, client._My_Id, hpMax, spMax, hp, sp, lv, thuoctinh, IdLeader, 0, 0, 0, team, @int, atk, def, agi, reborn, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
						}
						oleDbDataReader.Close();
					}
				}
				if (IdMem1 > 0 & Server.Clients.ContainsKey(IdMem1))
				{
					Server.Clients[IdMem1]._My_IdBattle = this._idBattle;
					Server.Clients[IdMem1]._my_DiaHinh = this._Diahinh;
					_Column = 1;
					Client client2 = Server.Clients[IdMem1];
					this.ChangedWar(Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					}), 2, client2._My_Id, 0, 0, client2._My_HpMax, client2._My_SpMax, client2._My_Hp, client2._My_Sp, client2._My_Lv, client2._My_Thuoctinh, IdLeader, 0, 0, 0, team, client2._My_Int + client2._My_Int2, client2._My_Atk + client2._My_Atk2, client2._My_Def + client2._My_Def2, client2._My_Agi + client2._My_Agi2, client2._My_Reborn, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
					int my_SttPetXuatChien2 = client2._My_SttPetXuatChien;
					if (my_SttPetXuatChien2 > 0 & my_SttPetXuatChien2 <= 4)
					{
						string str2 = Class1.Form0_0.Info.DirectoryPath + "\\member\\vn" + IdMem1.ToString() + ".accdb";
						OleDbConnection oleDbConnection2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + str2 + ";Persist Security Info=False;");
						OleDbCommand oleDbCommand2 = new OleDbCommand("SELECT * FROM Pet Where Stt = " + Conversions.ToString(my_SttPetXuatChien2), oleDbConnection2);
						if (oleDbConnection2.State == ConnectionState.Closed)
						{
							oleDbConnection2.Open();
						}
						OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
						if (oleDbDataReader2.Read())
						{
							int id2 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Pet._ID]);
							int hpMax2 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Pet._Hpmax]);
							int spMax2 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Pet._Spmax]);
							int hp2 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Pet._Hp]);
							int sp2 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Pet._Sp]);
							int lv2 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Pet._Lv]);
							int thuoctinh2 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Pet._Thuoctinh]);
							int reborn2 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Pet._Reborn]);
							int int2 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader2[DataStructure.Type_Pet._Int], oleDbDataReader2[DataStructure.Type_Pet._Int2]));
							int atk2 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader2[DataStructure.Type_Pet._Atk], oleDbDataReader2[DataStructure.Type_Pet._Atk2]));
							int def2 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader2[DataStructure.Type_Pet._Def], oleDbDataReader2[DataStructure.Type_Pet._Def2]));
							int agi2 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader2[DataStructure.Type_Pet._Agi], oleDbDataReader2[DataStructure.Type_Pet._Agi2]));
							this.ChangedWar(Class5.smethod_3(new byte[]
							{
								(byte)(_row ^ 1),
								(byte)_Column
							}), 4, id2, my_SttPetXuatChien2, client2._My_Id, hpMax2, spMax2, hp2, sp2, lv2, thuoctinh2, IdLeader, 0, 0, 0, team, int2, atk2, def2, agi2, reborn2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
						}
						oleDbDataReader2.Close();
					}
				}
				if (IdMem2 > 0 & Server.Clients.ContainsKey(IdMem2))
				{
					Server.Clients[IdMem2]._My_IdBattle = this._idBattle;
					Server.Clients[IdMem2]._my_DiaHinh = this._Diahinh;
					_Column = 3;
					Client client3 = Server.Clients[IdMem2];
					this.ChangedWar(Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					}), 2, client3._My_Id, 0, 0, client3._My_HpMax, client3._My_SpMax, client3._My_Hp, client3._My_Sp, client3._My_Lv, client3._My_Thuoctinh, IdLeader, 0, 0, 0, team, client3._My_Int + client3._My_Int2, client3._My_Atk + client3._My_Atk2, client3._My_Def + client3._My_Def2, client3._My_Agi + client3._My_Agi2, client3._My_Reborn, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
					int my_SttPetXuatChien3 = client3._My_SttPetXuatChien;
					if (my_SttPetXuatChien3 > 0 & my_SttPetXuatChien3 <= 4)
					{
						string str3 = Class1.Form0_0.Info.DirectoryPath + "\\member\\vn" + IdMem2.ToString() + ".accdb";
						OleDbConnection oleDbConnection3 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + str3 + ";Persist Security Info=False;");
						OleDbCommand oleDbCommand3 = new OleDbCommand("SELECT * FROM Pet Where Stt = " + Conversions.ToString(my_SttPetXuatChien3), oleDbConnection3);
						if (oleDbConnection3.State == ConnectionState.Closed)
						{
							oleDbConnection3.Open();
						}
						OleDbDataReader oleDbDataReader3 = oleDbCommand3.ExecuteReader();
						if (oleDbDataReader3.Read())
						{
							int id3 = Conversions.ToInteger(oleDbDataReader3[DataStructure.Type_Pet._ID]);
							int hpMax3 = Conversions.ToInteger(oleDbDataReader3[DataStructure.Type_Pet._Hpmax]);
							int spMax3 = Conversions.ToInteger(oleDbDataReader3[DataStructure.Type_Pet._Spmax]);
							int hp3 = Conversions.ToInteger(oleDbDataReader3[DataStructure.Type_Pet._Hp]);
							int sp3 = Conversions.ToInteger(oleDbDataReader3[DataStructure.Type_Pet._Sp]);
							int lv3 = Conversions.ToInteger(oleDbDataReader3[DataStructure.Type_Pet._Lv]);
							int thuoctinh3 = Conversions.ToInteger(oleDbDataReader3[DataStructure.Type_Pet._Thuoctinh]);
							int reborn3 = Conversions.ToInteger(oleDbDataReader3[DataStructure.Type_Pet._Reborn]);
							int int3 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader3[DataStructure.Type_Pet._Int], oleDbDataReader3[DataStructure.Type_Pet._Int2]));
							int atk3 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader3[DataStructure.Type_Pet._Atk], oleDbDataReader3[DataStructure.Type_Pet._Atk2]));
							int def3 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader3[DataStructure.Type_Pet._Def], oleDbDataReader3[DataStructure.Type_Pet._Def2]));
							int agi3 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader3[DataStructure.Type_Pet._Agi], oleDbDataReader3[DataStructure.Type_Pet._Agi2]));
							this.ChangedWar(Class5.smethod_3(new byte[]
							{
								(byte)(_row ^ 1),
								(byte)_Column
							}), 4, id3, my_SttPetXuatChien3, client3._My_Id, hpMax3, spMax3, hp3, sp3, lv3, thuoctinh3, IdLeader, 0, 0, 0, team, int3, atk3, def3, agi3, reborn3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
						}
						oleDbDataReader3.Close();
					}
				}
				if (IdMem3 > 0 & Server.Clients.ContainsKey(IdMem3))
				{
					Server.Clients[IdMem3]._My_IdBattle = this._idBattle;
					Server.Clients[IdMem3]._my_DiaHinh = this._Diahinh;
					_Column = 0;
					Client client4 = Server.Clients[IdMem3];
					this.ChangedWar(Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					}), 2, client4._My_Id, 0, 0, client4._My_HpMax, client4._My_SpMax, client4._My_Hp, client4._My_Sp, client4._My_Lv, client4._My_Thuoctinh, IdLeader, 0, 0, 0, team, client4._My_Int + client4._My_Int2, client4._My_Atk + client4._My_Atk2, client4._My_Def + client4._My_Def2, client4._My_Agi + client4._My_Agi2, client4._My_Reborn, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
					int my_SttPetXuatChien4 = client4._My_SttPetXuatChien;
					if (my_SttPetXuatChien4 > 0 & my_SttPetXuatChien4 <= 4)
					{
						string str4 = Class1.Form0_0.Info.DirectoryPath + "\\member\\vn" + IdMem3.ToString() + ".accdb";
						OleDbConnection oleDbConnection4 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + str4 + ";Persist Security Info=False;");
						OleDbCommand oleDbCommand4 = new OleDbCommand("SELECT * FROM Pet Where Stt = " + Conversions.ToString(my_SttPetXuatChien4), oleDbConnection4);
						if (oleDbConnection4.State == ConnectionState.Closed)
						{
							oleDbConnection4.Open();
						}
						OleDbDataReader oleDbDataReader4 = oleDbCommand4.ExecuteReader();
						if (oleDbDataReader4.Read())
						{
							int id4 = Conversions.ToInteger(oleDbDataReader4[DataStructure.Type_Pet._ID]);
							int hpMax4 = Conversions.ToInteger(oleDbDataReader4[DataStructure.Type_Pet._Hpmax]);
							int spMax4 = Conversions.ToInteger(oleDbDataReader4[DataStructure.Type_Pet._Spmax]);
							int hp4 = Conversions.ToInteger(oleDbDataReader4[DataStructure.Type_Pet._Hp]);
							int sp4 = Conversions.ToInteger(oleDbDataReader4[DataStructure.Type_Pet._Sp]);
							int lv4 = Conversions.ToInteger(oleDbDataReader4[DataStructure.Type_Pet._Lv]);
							int thuoctinh4 = Conversions.ToInteger(oleDbDataReader4[DataStructure.Type_Pet._Thuoctinh]);
							int reborn4 = Conversions.ToInteger(oleDbDataReader4[DataStructure.Type_Pet._Reborn]);
							int int4 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader4[DataStructure.Type_Pet._Int], oleDbDataReader4[DataStructure.Type_Pet._Int2]));
							int atk4 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader4[DataStructure.Type_Pet._Atk], oleDbDataReader4[DataStructure.Type_Pet._Atk2]));
							int def4 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader4[DataStructure.Type_Pet._Def], oleDbDataReader4[DataStructure.Type_Pet._Def2]));
							int agi4 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader4[DataStructure.Type_Pet._Agi], oleDbDataReader4[DataStructure.Type_Pet._Agi2]));
							this.ChangedWar(Class5.smethod_3(new byte[]
							{
								(byte)(_row ^ 1),
								(byte)_Column
							}), 4, id4, my_SttPetXuatChien4, client4._My_Id, hpMax4, spMax4, hp4, sp4, lv4, thuoctinh4, IdLeader, 0, 0, 0, team, int4, atk4, def4, agi4, reborn4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
						}
						oleDbDataReader4.Close();
					}
				}
				if (IdMem4 > 0 & Server.Clients.ContainsKey(IdMem4))
				{
					Server.Clients[IdMem4]._My_IdBattle = this._idBattle;
					Server.Clients[IdMem4]._my_DiaHinh = this._Diahinh;
					_Column = 4;
					Client client5 = Server.Clients[IdMem4];
					this.ChangedWar(Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					}), 2, client5._My_Id, 0, 0, client5._My_HpMax, client5._My_SpMax, client5._My_Hp, client5._My_Sp, client5._My_Lv, client5._My_Thuoctinh, IdLeader, 0, 0, 0, team, client5._My_Int + client5._My_Int2, client5._My_Atk + client5._My_Atk2, client5._My_Def + client5._My_Def2, client5._My_Agi + client5._My_Agi2, client5._My_Reborn, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
					int my_SttPetXuatChien5 = client5._My_SttPetXuatChien;
					if (my_SttPetXuatChien5 > 0 & my_SttPetXuatChien5 <= 4)
					{
						string str5 = Class1.Form0_0.Info.DirectoryPath + "\\member\\vn" + IdMem4.ToString() + ".accdb";
						OleDbConnection oleDbConnection5 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + str5 + ";Persist Security Info=False;");
						OleDbCommand oleDbCommand5 = new OleDbCommand("SELECT * FROM Pet Where Stt = " + Conversions.ToString(my_SttPetXuatChien5), oleDbConnection5);
						if (oleDbConnection5.State == ConnectionState.Closed)
						{
							oleDbConnection5.Open();
						}
						OleDbDataReader oleDbDataReader5 = oleDbCommand5.ExecuteReader();
						if (oleDbDataReader5.Read())
						{
							int id5 = Conversions.ToInteger(oleDbDataReader5[DataStructure.Type_Pet._ID]);
							int hpMax5 = Conversions.ToInteger(oleDbDataReader5[DataStructure.Type_Pet._Hpmax]);
							int spMax5 = Conversions.ToInteger(oleDbDataReader5[DataStructure.Type_Pet._Spmax]);
							int hp5 = Conversions.ToInteger(oleDbDataReader5[DataStructure.Type_Pet._Hp]);
							int sp5 = Conversions.ToInteger(oleDbDataReader5[DataStructure.Type_Pet._Sp]);
							int lv5 = Conversions.ToInteger(oleDbDataReader5[DataStructure.Type_Pet._Lv]);
							int thuoctinh5 = Conversions.ToInteger(oleDbDataReader5[DataStructure.Type_Pet._Thuoctinh]);
							int reborn5 = Conversions.ToInteger(oleDbDataReader5[DataStructure.Type_Pet._Reborn]);
							int int5 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader5[DataStructure.Type_Pet._Int], oleDbDataReader5[DataStructure.Type_Pet._Int2]));
							int atk5 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader5[DataStructure.Type_Pet._Atk], oleDbDataReader5[DataStructure.Type_Pet._Atk2]));
							int def5 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader5[DataStructure.Type_Pet._Def], oleDbDataReader5[DataStructure.Type_Pet._Def2]));
							int agi5 = Conversions.ToInteger(Operators.AddObject(oleDbDataReader5[DataStructure.Type_Pet._Agi], oleDbDataReader5[DataStructure.Type_Pet._Agi2]));
							this.ChangedWar(Class5.smethod_3(new byte[]
							{
								(byte)(_row ^ 1),
								(byte)_Column
							}), 4, id5, my_SttPetXuatChien5, client5._My_Id, hpMax5, spMax5, hp5, sp5, lv5, thuoctinh5, IdLeader, 0, 0, 0, team, int5, atk5, def5, agi5, reborn5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
						}
						oleDbDataReader5.Close();
					}
				}
			}
		}
		public void AddNPCToBattle(int ID, int _IdNpcOnMap, int _row, int _Column, int _Type)
		{
			int dataNpc = Data.GetDataNpc(ID, DataStructure.Type_Npc._Hp);
			int dataNpc2 = Data.GetDataNpc(ID, DataStructure.Type_Npc._Sp);
			int dataNpc3 = Data.GetDataNpc(ID, DataStructure.Type_Npc._Hp);
			int dataNpc4 = Data.GetDataNpc(ID, DataStructure.Type_Npc._Sp);
			int dataNpc5 = Data.GetDataNpc(ID, DataStructure.Type_Npc._Lv);
			int dataNpc6 = Data.GetDataNpc(ID, DataStructure.Type_Npc._Thuoctinh);
			int dataNpc7 = Data.GetDataNpc(ID, DataStructure.Type_Npc._Reborn);
			int dataNpc8 = Data.GetDataNpc(ID, DataStructure.Type_Npc._Int);
			int dataNpc9 = Data.GetDataNpc(ID, DataStructure.Type_Npc._Atk);
			int dataNpc10 = Data.GetDataNpc(ID, DataStructure.Type_Npc._Def);
			int dataNpc11 = Data.GetDataNpc(ID, DataStructure.Type_Npc._Agi);
			this.ChangedWar(Class5.smethod_3(checked(new byte[]
			{
				(byte)_row,
				(byte)_Column
			})), _Type, ID, _IdNpcOnMap, 0, dataNpc, dataNpc2, dataNpc3, dataNpc4, dataNpc5, dataNpc6, 0, 0, 0, 0, 2, dataNpc8, dataNpc9, dataNpc10, dataNpc11, dataNpc7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
		}
		public TheBattle(int IdLeader1, int IdLeader2, int DiaHinh)
		{
			this.ListWar = new Dictionary<string, DataStructure.WarInfo>();
			this.ListQS = new Dictionary<int, int>();
			this._keys = new ArrayList();
			this._idBattle = 0;
			this._Diahinh = 0;
			this.random_0 = new Random();
			this.random_1 = new Random();
			this.random_2 = new Random();
			checked
			{
				while (true)
				{
					try
					{
						this._Diahinh = DiaHinh;
						this._idBattle = Server.IdBattleCount;
						if (!Server.TheBattles.ContainsKey(this._idBattle))
						{
							Server.TheBattles.Add(this._idBattle, this);
							Server.IdBattleCount++;
							this.CreatNewBattle();
							this.AddToBattle(IdLeader1, Server.Clients[IdLeader1]._My_IdMem1, Server.Clients[IdLeader1]._My_IdMem2, Server.Clients[IdLeader1]._My_IdMem3, Server.Clients[IdLeader1]._My_IdMem4, 3, 2);
							this.AddToBattle(IdLeader2, Server.Clients[IdLeader2]._My_IdMem1, Server.Clients[IdLeader2]._My_IdMem2, Server.Clients[IdLeader2]._My_IdMem3, Server.Clients[IdLeader2]._My_IdMem4, 0, 2);
							new Thread(delegate(object a0)
							{
								this.BattlePkPlayer(Conversions.ToInteger(a0));
							})
							{
								IsBackground = true
							}.Start(DiaHinh);
							break;
						}
					}
					catch (Exception expr_163)
					{
						ProjectData.SetProjectError(expr_163);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		public TheBattle(int IdLeader, int IdNpc, int IdNpcOnMap, int DiaHinh)
		{
			this.ListWar = new Dictionary<string, DataStructure.WarInfo>();
			this.ListQS = new Dictionary<int, int>();
			this._keys = new ArrayList();
			this._idBattle = 0;
			this._Diahinh = 0;
			this.random_0 = new Random();
			this.random_1 = new Random();
			this.random_2 = new Random();
			checked
			{
				while (true)
				{
					try
					{
						this._Diahinh = DiaHinh;
						this._idBattle = Server.IdBattleCount;
						if (!Server.TheBattles.ContainsKey(this._idBattle))
						{
							Server.TheBattles.Add(this._idBattle, this);
							Server.IdBattleCount++;
							this.CreatNewBattle();
							this.AddToBattle(IdLeader, Server.Clients[IdLeader]._My_IdMem1, Server.Clients[IdLeader]._My_IdMem2, Server.Clients[IdLeader]._My_IdMem3, Server.Clients[IdLeader]._My_IdMem4, 3, 2);
							this.AddNPCToBattle(IdNpc, IdNpcOnMap, 0, 2, 3);
							new Thread(delegate(object a0)
							{
								this.BattleNpc(Conversions.ToInteger(a0));
							})
							{
								IsBackground = true
							}.Start(DiaHinh);
							break;
						}
					}
					catch (Exception expr_127)
					{
						ProjectData.SetProjectError(expr_127);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		public TheBattle(int IdLeader, DataStructure.TeamDeffender _Teamdef, int DiaHinh)
		{
			this.ListWar = new Dictionary<string, DataStructure.WarInfo>();
			this.ListQS = new Dictionary<int, int>();
			this._keys = new ArrayList();
			this._idBattle = 0;
			this._Diahinh = 0;
			this.random_0 = new Random();
			this.random_1 = new Random();
			this.random_2 = new Random();
			checked
			{
				while (true)
				{
					try
					{
						this._Diahinh = DiaHinh;
						this._idBattle = Server.IdBattleCount;
						if (!Server.TheBattles.ContainsKey(this._idBattle))
						{
							Server.TheBattles.Add(this._idBattle, this);
							Server.IdBattleCount++;
							this.CreatNewBattle();
							this.AddToBattle(IdLeader, Server.Clients[IdLeader]._My_IdMem1, Server.Clients[IdLeader]._My_IdMem2, Server.Clients[IdLeader]._My_IdMem3, Server.Clients[IdLeader]._My_IdMem4, 3, 2);
							if (_Teamdef._id1 > 0)
							{
								this.AddNPCToBattle(_Teamdef._id1, 1, 0, 0, 7);
							}
							if (_Teamdef._id2 > 0)
							{
								this.AddNPCToBattle(_Teamdef._id2, 2, 0, 1, 7);
							}
							if (_Teamdef._id3 > 0)
							{
								this.AddNPCToBattle(_Teamdef._id3, 3, 0, 2, 7);
							}
							if (_Teamdef._id4 > 0)
							{
								this.AddNPCToBattle(_Teamdef._id4, 4, 0, 3, 7);
							}
							if (_Teamdef._id5 > 0)
							{
								this.AddNPCToBattle(_Teamdef._id5, 5, 0, 4, 7);
							}
							if (_Teamdef._id6 > 0)
							{
								this.AddNPCToBattle(_Teamdef._id6, 6, 1, 0, 7);
							}
							if (_Teamdef._id7 > 0)
							{
								this.AddNPCToBattle(_Teamdef._id7, 7, 1, 1, 7);
							}
							if (_Teamdef._id8 > 0)
							{
								this.AddNPCToBattle(_Teamdef._id8, 8, 1, 2, 7);
							}
							if (_Teamdef._id9 > 0)
							{
								this.AddNPCToBattle(_Teamdef._id9, 9, 1, 3, 7);
							}
							if (_Teamdef._id10 > 0)
							{
								this.AddNPCToBattle(_Teamdef._id10, 10, 1, 4, 7);
							}
							new Thread(delegate(object a0)
							{
								this.BattleNpc(Conversions.ToInteger(a0));
							})
							{
								IsBackground = true
							}.Start(DiaHinh);
							break;
						}
					}
					catch (Exception expr_22A)
					{
						ProjectData.SetProjectError(expr_22A);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		public void BattlePkPlayer(int DiaHinh)
		{
			int num = 3;
			this.SendBattleLeader(DiaHinh, 3, 2);
			if (this.ListWar[Class5.smethod_3(new byte[]
			{
				3,
				1
			})]._Id > 0)
			{
				this.SendBattleMemPkPlayer(DiaHinh, num, 1);
			}
			checked
			{
				if (this.ListWar[Class5.smethod_3(new byte[]
				{
					(byte)num,
					3
				})]._Id > 0)
				{
					this.SendBattleMemPkPlayer(DiaHinh, num, 3);
				}
				if (this.ListWar[Class5.smethod_3(new byte[]
				{
					(byte)num,
					0
				})]._Id > 0)
				{
					this.SendBattleMemPkPlayer(DiaHinh, num, 0);
				}
				if (this.ListWar[Class5.smethod_3(new byte[]
				{
					(byte)num,
					4
				})]._Id > 0)
				{
					this.SendBattleMemPkPlayer(DiaHinh, num, 4);
				}
				num = 0;
				this.SendBattleLeaderPlayerPK(DiaHinh, 0, 2);
				if (this.ListWar[Class5.smethod_3(new byte[]
				{
					0,
					1
				})]._Id > 0)
				{
					this.SendBattleMemPkPlayer(DiaHinh, num, 1);
				}
				if (this.ListWar[Class5.smethod_3(new byte[]
				{
					(byte)num,
					3
				})]._Id > 0)
				{
					this.SendBattleMemPkPlayer(DiaHinh, num, 3);
				}
				if (this.ListWar[Class5.smethod_3(new byte[]
				{
					(byte)num,
					0
				})]._Id > 0)
				{
					this.SendBattleMemPkPlayer(DiaHinh, num, 0);
				}
				if (this.ListWar[Class5.smethod_3(new byte[]
				{
					(byte)num,
					4
				})]._Id > 0)
				{
					this.SendBattleMemPkPlayer(DiaHinh, num, 4);
				}
				this.Battling();
			}
		}
		public void BattleNpc(int DiaHinh)
		{
			DataStructure.WarInfo warInfo = this.ListWar[Class5.smethod_3(new byte[]
			{
				3,
				2
			})];
			int id = warInfo._Id;
			int id2 = warInfo._Id;
			string packet = warInfo._Packet;
			string packet2 = string.Concat(new string[]
			{
				"F4441C000BFA",
				Class5.smethod_11(DiaHinh),
				"03",
				packet,
				"F44403000B0A01"
			});
			Server.SendToClient(id, packet2);
			Server.SendToAllClientMapid(id2, "F4440A000B0402" + Class5.smethod_12(id2) + "000003");
			warInfo = this.ListWar[Class5.smethod_3(new byte[]
			{
				2,
				2
			})];
			if (warInfo._Id > 0)
			{
				packet = warInfo._Packet;
				packet2 = "F4441A000B0505" + packet;
				Server.SendToClient(id, packet2);
			}
			warInfo = this.ListWar[Class5.smethod_3(new byte[]
			{
				3,
				1
			})];
			if (warInfo._Id > 0)
			{
				id2 = warInfo._Id;
				packet = warInfo._Packet;
				packet2 = string.Concat(new string[]
				{
					"F4441A000B0505",
					packet,
					"F4440A000B0402",
					Class5.smethod_12(id2),
					"000005"
				});
				Server.SendToClient(id, packet2);
				warInfo = this.ListWar[Class5.smethod_3(new byte[]
				{
					2,
					1
				})];
				if (warInfo._Id > 0)
				{
					packet = warInfo._Packet;
					packet2 = "F4441A000B0505" + packet;
					Server.SendToClient(id, packet2);
				}
				this.SendBattleMem1(DiaHinh, 3, 1);
			}
			warInfo = this.ListWar[Class5.smethod_3(new byte[]
			{
				3,
				3
			})];
			if (warInfo._Id > 0)
			{
				id2 = warInfo._Id;
				packet = warInfo._Packet;
				packet2 = string.Concat(new string[]
				{
					"F4441A000B0505",
					packet,
					"F4440A000B0402",
					Class5.smethod_12(id2),
					"000005"
				});
				Server.SendToClient(id, packet2);
				warInfo = this.ListWar[Class5.smethod_3(new byte[]
				{
					2,
					3
				})];
				if (warInfo._Id > 0)
				{
					packet = warInfo._Packet;
					packet2 = "F4441A000B0505" + packet;
					Server.SendToClient(id, packet2);
				}
				this.SendBattleMem1(DiaHinh, 3, 3);
			}
			warInfo = this.ListWar[Class5.smethod_3(new byte[]
			{
				3,
				0
			})];
			if (warInfo._Id > 0)
			{
				id2 = warInfo._Id;
				packet = warInfo._Packet;
				packet2 = string.Concat(new string[]
				{
					"F4441A000B0505",
					packet,
					"F4440A000B0402",
					Class5.smethod_12(id2),
					"000005"
				});
				Server.SendToClient(id, packet2);
				warInfo = this.ListWar[Class5.smethod_3(new byte[]
				{
					2,
					0
				})];
				if (warInfo._Id > 0)
				{
					packet = warInfo._Packet;
					packet2 = "F4441A000B0505" + packet;
					Server.SendToClient(id, packet2);
				}
				this.SendBattleMem1(DiaHinh, 3, 0);
			}
			warInfo = this.ListWar[Class5.smethod_3(new byte[]
			{
				3,
				4
			})];
			if (warInfo._Id > 0)
			{
				id2 = warInfo._Id;
				packet = warInfo._Packet;
				packet2 = string.Concat(new string[]
				{
					"F4441A000B0505",
					packet,
					"F4440A000B0402",
					Class5.smethod_12(id2),
					"000005"
				});
				Server.SendToClient(id, packet2);
				warInfo = this.ListWar[Class5.smethod_3(new byte[]
				{
					2,
					4
				})];
				if (warInfo._Id > 0)
				{
					packet = warInfo._Packet;
					packet2 = "F4441A000B0505" + packet;
					Server.SendToClient(id, packet2);
				}
				this.SendBattleMem1(DiaHinh, 3, 4);
			}
			int num = 0;
			checked
			{
				do
				{
					warInfo = this.ListWar[Class5.smethod_3(new byte[]
					{
						0,
						(byte)num
					})];
					if (warInfo._Id > 0)
					{
						packet = warInfo._Packet;
						packet2 = "F4441A000B0503" + packet;
						Server.SendToClient(id, packet2);
					}
					warInfo = this.ListWar[Class5.smethod_3(new byte[]
					{
						1,
						(byte)num
					})];
					if (warInfo._Id > 0)
					{
						packet = warInfo._Packet;
						packet2 = "F4441A000B0503" + packet;
						Server.SendToClient(id, packet2);
					}
					num++;
				}
				while (num <= 4);
				this.Battling();
			}
		}
		public void SendBattleMem1(int DiaHinh, int _row, int _Column)
		{
			checked
			{
				DataStructure.WarInfo warInfo = this.ListWar[Class5.smethod_3(new byte[]
				{
					(byte)_row,
					(byte)_Column
				})];
				int num = 2;
				if (_row == 0)
				{
					num = 1;
				}
				if (warInfo._Id > 0)
				{
					int id = warInfo._Id;
					int num2 = Data.PetGetData(Server.Clients[id].conn, Server.Clients[id]._My_SttPetXuatChien, DataStructure.Type_Pet._ID);
					string packet = warInfo._Packet;
					string packet2 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)num,
						(byte)_Column
					})]._Packet;
					string text = "";
					int id2 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						2
					})]._Id;
					int id3 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Id;
					int id4 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Id;
					int id5 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Id;
					int id6 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Id;
					int id7 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)num,
						2
					})]._Id;
					int id8 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)num,
						1
					})]._Id;
					int id9 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)num,
						3
					})]._Id;
					int id10 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)num,
						0
					})]._Id;
					int id11 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)num,
						4
					})]._Id;
					string packet3 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						2
					})]._Packet;
					string packet4 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Packet;
					string packet5 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Packet;
					string packet6 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Packet;
					string packet7 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Packet;
					string packet8 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)num,
						2
					})]._Packet;
					string packet9 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)num,
						1
					})]._Packet;
					string packet10 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)num,
						3
					})]._Packet;
					string packet11 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)num,
						0
					})]._Packet;
					string packet12 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)num,
						4
					})]._Packet;
					text = string.Concat(new string[]
					{
						text,
						"05",
						packet,
						"03",
						packet3
					});
					if (id7 > 0)
					{
						text = text + "03" + packet8;
					}
					Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id2) + "000003");
					if (id3 != id & id3 > 0)
					{
						text = text + "64" + packet4;
						if (id8 > 0)
						{
							text = text + "64" + packet9;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id3) + "000005");
					}
					if (id4 != id & id4 > 0)
					{
						text = text + "64" + packet5;
						if (id9 > 0)
						{
							text = text + "64" + packet10;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id4) + "000005");
					}
					if (id5 != id & id5 > 0)
					{
						text = text + "64" + packet6;
						if (id10 > 0)
						{
							text = text + "64" + packet11;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id5) + "000005");
					}
					if (id6 != id & id6 > 0)
					{
						text = text + "64" + packet7;
						if (id11 > 0)
						{
							text = text + "64" + packet12;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id6) + "000005");
					}
					Server.SendToClient(id, string.Concat(new string[]
					{
						"F444",
						Class5.smethod_11(4 + (int)Math.Round((double)text.Length / 2.0)),
						"0BFA",
						Class5.smethod_11(DiaHinh),
						text,
						"F44403000B0A01"
					}));
					Server.SendToAllClientMapid(id, "F4440A000B0402" + Class5.smethod_12(id) + "000003");
					if (num2 > 0)
					{
						Server.SendToClient(id, "F4441A000B0505" + packet2);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						0,
						2
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							2
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						0,
						1
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							1
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						0,
						3
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							3
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						0,
						0
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							0
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						0,
						4
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							4
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						1,
						2
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							2
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						1,
						1
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							1
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						1,
						3
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							3
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						1,
						0
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							0
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						1,
						4
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							4
						})]._Packet);
					}
				}
			}
		}
		public void Battling()
		{
			int num = 0;
			double num2 = 0.0;
			int num3 = 0;
			int num4 = 0;
			double num5 = 0.0;
			int num6 = 0;
			int num7 = 0;
			string text = "";
			ArrayList arrayList = new ArrayList();
			ArrayList arrayList2 = new ArrayList();
			string text2 = "";
			checked
			{
				while (!(this.ListWar[Class5.smethod_3(new byte[]
				{
					0,
					2
				})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
				{
					0,
					1
				})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
				{
					0,
					3
				})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
				{
					0,
					0
				})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
				{
					0,
					4
				})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
				{
					1,
					2
				})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
				{
					1,
					1
				})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
				{
					1,
					3
				})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
				{
					1,
					0
				})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
				{
					1,
					4
				})]._Hp <= 0))
				{
					string text7;
					if (!(this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						2
					})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						1
					})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						3
					})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						0
					})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						4
					})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						2
					})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						1
					})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						3
					})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						0
					})]._Hp <= 0 & this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						4
					})]._Hp <= 0))
					{
						try
						{
							IEnumerator enumerator = this._keys.GetEnumerator();
							while (enumerator.MoveNext())
							{
								string key = Conversions.ToString(enumerator.Current);
								DataStructure.WarInfo value = this.ListWar[key];
								int id = value._Id;
								int lv = value._Lv;
								int team = value._Team;
								if (id > 0)
								{
									value._IdSkill = 0;
									value._RowAttack = 0;
									value._ColumnAttack = 0;
									value._Attacked = 0;
									value._Random = this.random_1.Next(0, 100);
									int type = value._Type;
									int row = value._Row;
									int column = value._Column;
									if (team == 1)
									{
										if (num2 == 0.0)
										{
											num3 += lv;
											num4++;
										}
									}
									else
									{
										if (team == 2 && num5 == 0.0)
										{
											num6 += lv;
											num7++;
										}
									}
									int idNpcOnMap = value._IdNpcOnMap;
									int idChar = value._IdChar;
									int type3_Id = value._Type3_Id;
									int type3_Turn = value._Type3_Turn;
									int type3_Lv = value._Type3_Lv;
									int type4_Id = value._Type4_Id;
									int type4_Turn = value._Type4_Turn;
									int type15_Id = value._Type15_Id;
									int type15_Lv = value._Type15_Lv;
									int type15_Turn = value._Type15_Turn;
									int type19_Id = value._Type19_Id;
									int type19_Turn = value._Type19_Turn;
									if (type3_Id > 1)
									{
										value._Type3_Turn = type3_Turn - 1;
									}
									if (type4_Id > 1)
									{
										value._Type4_Turn = type4_Turn - 1;
									}
									if (type15_Id > 1)
									{
										value._Type15_Turn = type15_Turn - 1;
									}
									if (type19_Id > 1)
									{
										value._Type19_Turn = type19_Turn - 1;
									}
									if (type3_Id == 10004 | type3_Id == 10033)
									{
										int num8 = 10 + type3_Lv * 2;
										if (type3_Id == 10033)
										{
											num8 = 30 + type3_Lv * 10;
										}
										if (type != 3 & type != 7)
										{
											if (idChar == 0)
											{
												if (value._Hp - num8 < 0)
												{
													Data.PlayerUpdateDataId(id, DataStructure.Type_Player._Hp, 0);
												}
												else
												{
													Data.PlayerUpdateDataId(id, DataStructure.Type_Player._Hp, value._Hp - num8);
												}
												value._Hp -= num8;
											}
											else
											{
												if (value._Hp - num8 < 0)
												{
													if (Server.Clients.ContainsKey(idChar))
													{
														Data.PetUpdateData(idChar, idNpcOnMap, DataStructure.Type_Pet._Hp, 0);
													}
												}
												else
												{
													if (Server.Clients.ContainsKey(idChar))
													{
														Data.PetUpdateData(idChar, idNpcOnMap, DataStructure.Type_Pet._Hp, value._Hp - num8);
													}
												}
												value._Hp -= num8;
											}
										}
										else
										{
											value._Hp -= num8;
										}
										string text3 = string.Concat(new string[]
										{
											row.ToString("X2"),
											column.ToString("X2"),
											Class5.smethod_11(20001),
											"0101",
											this.SkillingInt(row, column, 1, 0, 1, DataStructure.Type_StatusTroiBuffHpSp._Hp, num8, 1)
										});
										string str = Class5.smethod_11((int)Math.Round((double)text3.Length / 2.0)) + text3;
										string text4 = "3201" + str;
										this.SendSKillingToParty("F444" + Class5.smethod_11((int)Math.Round((double)text4.Length / 2.0)) + text4);
									}
									if (type3_Turn == 1)
									{
										value._Type3_Id = 0;
										value._Type3_Lv = 0;
										value._Type3_Turn = 0;
										this.TroiEnd(this._idBattle, row, column, DataStructure.Type_TroiBuffEnd._Type3);
									}
									if (type4_Turn == 1)
									{
										value._Type4_Id = 0;
										value._Type4_Lv = 0;
										value._Type4_Turn = 0;
										this.TroiEnd(this._idBattle, row, column, DataStructure.Type_TroiBuffEnd._Type4);
									}
									if (type15_Id == 14015)
									{
										int num9 = 30 + type15_Lv * 15;
										if (type != 3 & type != 7)
										{
											if (idChar == 0)
											{
												if (value._Hp - num9 < 0)
												{
													Data.PlayerUpdateDataId(id, DataStructure.Type_Player._Hp, 0);
												}
												else
												{
													Data.PlayerUpdateDataId(id, DataStructure.Type_Player._Hp, value._Hp - num9);
												}
												value._Hp -= num9;
											}
											else
											{
												if (value._Hp - num9 < 0)
												{
													if (Server.Clients.ContainsKey(idChar))
													{
														Data.PetUpdateData(idChar, idNpcOnMap, DataStructure.Type_Pet._Hp, 0);
													}
												}
												else
												{
													if (Server.Clients.ContainsKey(idChar))
													{
														Data.PetUpdateData(idChar, idNpcOnMap, DataStructure.Type_Pet._Hp, value._Hp - num9);
													}
												}
												value._Hp -= num9;
											}
										}
										else
										{
											value._Hp -= num9;
										}
										string text5 = string.Concat(new string[]
										{
											row.ToString("X2"),
											column.ToString("X2"),
											Class5.smethod_11(20003),
											"0101",
											this.SkillingInt(row, column, 1, 0, 1, DataStructure.Type_StatusTroiBuffHpSp._Hp, num9, 1)
										});
										string str2 = Class5.smethod_11((int)Math.Round((double)text5.Length / 2.0)) + text5;
										string text6 = "3201" + str2;
										this.SendSKillingToParty("F444" + Class5.smethod_11((int)Math.Round((double)text6.Length / 2.0)) + text6);
									}
									if (type15_Turn == 1)
									{
										ArrayList arrayList3 = new ArrayList(new int[]
										{
											10016,
											10017,
											10018,
											10019,
											10025,
											20022
										});
										if (arrayList3.Contains(type15_Id))
										{
											value._Agi += 200;
										}
										value._Type15_Id = 0;
										value._Type15_Lv = 0;
										value._Type15_Turn = 0;
										this.TroiEnd(this._idBattle, row, column, DataStructure.Type_TroiBuffEnd._Type15);
									}
									if (type19_Turn == 1)
									{
										value._Type19_Id = 0;
										value._Type19_Lv = 0;
										value._Type19_Turn = 0;
										this.TroiEnd(this._idBattle, row, column, DataStructure.Type_TroiBuffEnd._Type19);
									}
									if (type == 2)
									{
										Server.SendToClient(id, "F44402003401");
									}
									if (type3_Turn > 0)
									{
										this.SendSKillingToParty("F44404003505" + row.ToString("X2") + column.ToString("X2"));
									}
								}
								this.ListWar[key] = value;
							}
						}
						finally
						{

						}
						num2 = (double)num3 / (double)num4;
						num5 = (double)num6 / (double)num7;
						if (!(this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							2
						})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							1
						})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							3
						})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							0
						})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							4
						})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							2
						})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							1
						})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							3
						})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							0
						})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							4
						})]._Id == 0))
						{
							if (this.ListWar[Class5.smethod_3(new byte[]
							{
								3,
								2
							})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
							{
								3,
								1
							})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
							{
								3,
								3
							})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
							{
								3,
								0
							})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
							{
								3,
								4
							})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
							{
								2,
								2
							})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
							{
								2,
								1
							})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
							{
								2,
								3
							})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
							{
								2,
								0
							})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
							{
								2,
								4
							})]._Id == 0)
							{
								num = 2;
							}
							else
							{
								long num10;
								int num11 = 0;
								do
								{
									Thread.Sleep(100);
									num10 = 1L;
									num11++;
									try
									{
										IEnumerator enumerator2 = this._keys.GetEnumerator();
										while (enumerator2.MoveNext())
										{
											string key2 = Conversions.ToString(enumerator2.Current);
											DataStructure.WarInfo value2 = this.ListWar[key2];
											int id2 = value2._Id;
											int hp = value2._Hp;
											if (id2 > 0 & hp > 0)
											{
												int idSkill = value2._IdSkill;
												int type3_Turn2 = value2._Type3_Turn;
												int type15_Id2 = value2._Type15_Id;
												int row2 = value2._Row;
												int num12 = 0;
												if (type15_Id2 == 14021 | type15_Id2 == 20014)
												{
													int num13;
													do
													{
														if (row2 == 0 | row2 == 1)
														{
															num12 = this.RandomizeArrayWithPercent(0, 1, 50);
														}
														else
														{
															if (row2 == 2 | row2 == 3)
															{
																num12 = this.RandomizeArrayWithPercent(2, 3, 50);
															}
														}
														ArrayList arrayList4 = new ArrayList();
														if (this.ListWar[Class5.smethod_3(new byte[]
														{
															(byte)num12,
															2
														})]._Hp > 0)
														{
															arrayList4.Add(2);
														}
														if (this.ListWar[Class5.smethod_3(new byte[]
														{
															(byte)num12,
															1
														})]._Hp > 0)
														{
															arrayList4.Add(1);
														}
														if (this.ListWar[Class5.smethod_3(new byte[]
														{
															(byte)num12,
															3
														})]._Hp > 0)
														{
															arrayList4.Add(3);
														}
														if (this.ListWar[Class5.smethod_3(new byte[]
														{
															(byte)num12,
															0
														})]._Hp > 0)
														{
															arrayList4.Add(0);
														}
														if (this.ListWar[Class5.smethod_3(new byte[]
														{
															(byte)num12,
															4
														})]._Hp > 0)
														{
															arrayList4.Add(4);
														}
														num13 = this.RandomizeArray(arrayList4);
													}
													while (this.ListWar[Class5.smethod_3(new byte[]
													{
														(byte)num12,
														(byte)num13
													})]._Hp <= 0);
													value2._IdSkill = 10000;
													value2._LvSKill = 1;
													value2._RowAttack = num12;
													value2._ColumnAttack = num13;
													value2._Attacked = 1;
												}
												if (type3_Turn2 == 0)
												{
													if (idSkill == 0)
													{
														if (value2._Type == 3 | value2._Type == 7)
														{
															int num13;
															do
															{
																num12 = this.RandomizeArrayWithPercent(2, 3, 50);
																ArrayList arrayList5 = new ArrayList();
																if (this.ListWar[Class5.smethod_3(new byte[]
																{
																	(byte)num12,
																	2
																})]._Hp > 0)
																{
																	arrayList5.Add(2);
																}
																if (this.ListWar[Class5.smethod_3(new byte[]
																{
																	(byte)num12,
																	1
																})]._Hp > 0)
																{
																	arrayList5.Add(1);
																}
																if (this.ListWar[Class5.smethod_3(new byte[]
																{
																	(byte)num12,
																	3
																})]._Hp > 0)
																{
																	arrayList5.Add(3);
																}
																if (this.ListWar[Class5.smethod_3(new byte[]
																{
																	(byte)num12,
																	0
																})]._Hp > 0)
																{
																	arrayList5.Add(0);
																}
																if (this.ListWar[Class5.smethod_3(new byte[]
																{
																	(byte)num12,
																	4
																})]._Hp > 0)
																{
																	arrayList5.Add(4);
																}
																num13 = this.RandomizeArray(arrayList5);
															}
															while (this.ListWar[Class5.smethod_3(new byte[]
															{
																(byte)num12,
																(byte)num13
															})]._Hp <= 0);
															value2._IdSkill = this.GetRandomSkillNPC(Data.GetDataNpc(id2, DataStructure.Type_Npc._Lv), Data.GetDataNpc(id2, DataStructure.Type_Npc._Reborn), Data.GetDataNpc(id2, DataStructure.Type_Npc._Skill1), Data.GetDataNpc(id2, DataStructure.Type_Npc._Skill2), Data.GetDataNpc(id2, DataStructure.Type_Npc._Skill3));
															value2._LvSKill = Data.GetDataSkill(value2._IdSkill, DataStructure.Type_Skill._LvMax);
															value2._RowAttack = num12;
															value2._ColumnAttack = num13;
															value2._Attacked = 1;
														}
													}
													else
													{
														if (idSkill > 0)
														{
															value2._Attacked = 1;
														}
													}
												}
												else
												{
													value2._Attacked = 1;
												}
											}
											else
											{
												value2._Attacked = 1;
											}
											num10 *= unchecked((long)value2._Attacked);
											this.ListWar[key2] = value2;
										}
									}
									finally
									{

									}
								}
								while (!(num11 >= 210 | num10 > 0L));
								num11 = 0;
								try
								{
									IEnumerator enumerator3 = this._keys.GetEnumerator();
									while (enumerator3.MoveNext())
									{
										string key3 = Conversions.ToString(enumerator3.Current);
										DataStructure.WarInfo value3 = this.ListWar[key3];
										value3._Attacked = 1;
										this.ListWar[key3] = value3;
									}
								}
								finally
								{

								}
								arrayList2.Clear();
								arrayList.Clear();
								DataTable dataTable = new DataTable();
								dataTable.Columns.Add("Row").DataType = Type.GetType("System.Int32");
								dataTable.Columns.Add("Column").DataType = Type.GetType("System.Int32");
								dataTable.Columns.Add("Agi").DataType = Type.GetType("System.Int32");
								dataTable.Columns.Add("Random").DataType = Type.GetType("System.Int32");
								dataTable.Columns.Add("Attacked").DataType = Type.GetType("System.Int32");
								try
								{
									Dictionary<string, DataStructure.WarInfo>.ValueCollection.Enumerator enumerator4 = this.ListWar.Values.GetEnumerator();
									while (enumerator4.MoveNext())
									{
										DataStructure.WarInfo current = enumerator4.Current;
										dataTable.Rows.Add(new object[]
										{
											current._Row,
											current._Column,
											current._Agi,
											current._Random,
											current._Attacked
										});
									}
								}
								finally
								{
									
								}
								DataView dataView = new DataView(dataTable);
								dataView.Sort = "Attacked DESC, Agi DESC, Random DESC";
								int num14 = 0;
								int num15 = 0;
								int num16 = 0;
								int num17 = 0;
								text7 = "";
								string text8 = "";
								int num18 = 0;
								do
								{
									int num19 = Conversions.ToInteger(dataView[num18].Row[DataStructure.Type_Battle._Row]);
									int num20 = Conversions.ToInteger(dataView[num18].Row[DataStructure.Type_Battle._Column]);
									string text9 = Class5.smethod_3(new byte[]
									{
										(byte)num19,
										(byte)num20
									});
									DataStructure.WarInfo warInfo = this.ListWar[text9];
									int type2 = warInfo._Type;
									int id3 = warInfo._Id;
									if (id3 > 0)
									{
										int idNpcOnMap2 = warInfo._IdNpcOnMap;
										int idChar2 = warInfo._IdChar;
										int hpMax = warInfo._HpMax;
										int hp2 = warInfo._Hp;
										int sp = warInfo._Sp;
										int lv2 = warInfo._Lv;
										int thuoctinh = warInfo._Thuoctinh;
										int reborn = warInfo._Reborn;
										int leaderId = warInfo._LeaderId;
										int num21 = warInfo._IdSkill;
										int num22 = warInfo._RowAttack;
										int num23 = warInfo._ColumnAttack;
										int team2 = warInfo._Team;
										int @int = warInfo._Int;
										int atk = warInfo._Atk;
										int agi = warInfo._Agi;
										int num24 = warInfo._LvSKill;
										int attacked = warInfo._Attacked;
										int type3_Id2 = warInfo._Type3_Id;
										int num25 = warInfo._Type4_Id;
										int num26 = warInfo._Type4_Lv;
										int type15_Id3 = warInfo._Type15_Id;
										int type15_Lv2 = warInfo._Type15_Lv;
										int type19_Id2 = warInfo._Type19_Id;
										int dataSkill = Data.GetDataSkill(num21, DataStructure.Type_Skill._Sp);
										if (type3_Id2 == 0 & attacked == 1)
										{
											if (sp >= dataSkill)
											{
												if (type2 != 3 & type2 != 7)
												{
													if (idChar2 == 0)
													{
														Data.PlayerUpdateDataId(id3, DataStructure.Type_Player._Sp, sp - dataSkill);
													}
													else
													{
														if (Server.Clients.ContainsKey(idChar2))
														{
															Data.PetUpdateData(idChar2, idNpcOnMap2, DataStructure.Type_Pet._Sp, sp - dataSkill);
														}
													}
												}
												warInfo._Sp -= dataSkill;
											}
											else
											{
												num21 = 10000;
												num24 = 1;
											}
											if ((hp2 > 0 & num21 > 0 & num22 < 4 & num23 < 5) && (Data.GetDataSkillExits(num21) | type2 == 3 | type2 == 7))
											{
												bool flag = false;
												ArrayList arrayList6 = new ArrayList(new int[]
												{
													10000,
													15001,
													15002,
													15003,
													17001,
													18001,
													18002,
													19001
												});
												switch (type2)
												{
												case 2:
													if (Server.Clients.ContainsKey(id3) && Data.PlayerGetDataSkillId(Server.Clients[id3].conn, num21, DataStructure.Type_MySkill._Lv) > 0)
													{
														flag = true;
														num24 = Data.PlayerGetDataSkillId(Server.Clients[id3].conn, num21, DataStructure.Type_MySkill._Lv);
													}
													break;
												case 4:
												{
													ArrayList arrayList7 = new ArrayList(new int[]
													{
														Data.GetDataNpc(id3, DataStructure.Type_Npc._Skill1),
														Data.GetDataNpc(id3, DataStructure.Type_Npc._Skill2),
														Data.GetDataNpc(id3, DataStructure.Type_Npc._Skill3)
													});
													if (arrayList7.Contains(num21))
													{
														flag = true;
													}
													break;
												}
												}
												if (flag | arrayList6.Contains(num21) | type2 == 3 | type2 == 7)
												{
													int dataSkill2 = Data.GetDataSkill(num21, DataStructure.Type_Skill._Type);
													double num27 = (double)Data.GetDataSkill(num21, DataStructure.Type_Skill._DoManh);
													int num28 = Data.GetDataSkill(num21, DataStructure.Type_Skill._SLdanh);
													int dataSkill3 = Data.GetDataSkill(num21, DataStructure.Type_Skill._Combo);
													int dataSkill4 = Data.GetDataSkill(num21, DataStructure.Type_Skill._Delay);
													int num29 = this.random_1.Next(0, 1);
													int attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
													int num30 = 0;
													double num31 = 1.0;
													ArrayList arrayList8 = this.GetPosAttack(this._idBattle, team2, num22, num23, num28);
													unchecked
													{
														if (num14 == 1)
														{
															num31 *= 1.3;
															arrayList8.Clear();
															int rowAttack = 0;
															int columnAttack = 0;
															arrayList8 = this.GetPosAttackCombo(this._idBattle, team2, rowAttack, columnAttack, num28);
														}
													}
													if (dataSkill2 == 8)
													{
														arrayList8.Clear();
														DataStructure.WarInfo warInfo2 = this.ListWar[Class5.smethod_3(new byte[]
														{
															(byte)num22,
															(byte)num23
														})];
														int id4 = warInfo2._Id;
														int team3 = warInfo2._Team;
														if (id4 > 0 & team2 == team3)
														{
															Point point = new Point(num22, num23);
															arrayList8.Add(point);
														}
													}
													if (dataSkill2 == 17)
													{
														arrayList8.Clear();
														if (num19 == num22 & num20 == num23)
														{
															Point point2 = new Point(num19, num20);
															arrayList8.Add(point2);
														}
													}
													if (dataSkill2 == 3 | dataSkill2 == 15)
													{
														arrayList8.Clear();
														arrayList8 = this.GetPosAttack3_15(this._idBattle, team2, num22, num23, num28);
													}
													if (dataSkill2 == 4 | dataSkill2 == 6 | dataSkill2 == 7 | dataSkill2 == 14 | dataSkill2 == 19)
													{
														if (num21 == 11010 | num21 == 11009 | num21 == 11026 | num21 == 11030)
														{
															if (num24 == 1)
															{
																num28 = 1;
															}
															else
															{
																if (num24 == 2 | num24 == 3)
																{
																	num28 = 3;
																}
																else
																{
																	if (num24 == 4 | num24 == 5 | num24 == 6)
																	{
																		num28 = 5;
																	}
																	else
																	{
																		if (num24 == 7 | num24 == 8 | num24 == 9)
																		{
																			num28 = 6;
																		}
																		else
																		{
																			if (num24 == 10)
																			{
																				num28 = 8;
																			}
																		}
																	}
																}
															}
														}
														arrayList8.Clear();
														arrayList8 = this.GetPosAttack_Type4(this._idBattle, team2, num22, num23, num28);
													}
													if (type15_Id3 == 14021 | type15_Id3 == 20014)
													{
														arrayList8.Clear();
														num21 = 10000;
														num28 = 1;
														arrayList8 = this.GetPosAttack_honLoan(this._idBattle, team2, num22, num23, 1);
													}
													ArrayList arrayList9 = new ArrayList(new int[]
													{
														10016,
														11016,
														12016,
														13015
													});
													if (arrayList9.Contains(num21) | dataSkill2 == 18)
													{
														arrayList8.Clear();
														if (num24 == 1 | num24 == 2 | num24 == 3)
														{
															num28 = 3;
														}
														else
														{
															if (num24 == 4 | num24 == 5 | num24 == 6)
															{
																num28 = 5;
																int num32 = num21;
																if (num32 == 10016)
																{
																	num21 = 10017;
																}
																else
																{
																	if (num32 == 11016)
																	{
																		num21 = 11017;
																	}
																	else
																	{
																		if (num32 == 12016)
																		{
																			num21 = 12017;
																		}
																		else
																		{
																			if (num32 == 13015)
																			{
																				num21 = 13016;
																			}
																		}
																	}
																}
															}
															else
															{
																if (num24 == 7 | num24 == 8 | num24 == 9)
																{
																	num28 = 6;
																	int num33 = num21;
																	if (num33 == 10016)
																	{
																		num21 = 10018;
																	}
																	else
																	{
																		if (num33 == 11016)
																		{
																			num21 = 11018;
																		}
																		else
																		{
																			if (num33 == 12016)
																			{
																				num21 = 12018;
																			}
																			else
																			{
																				if (num33 == 13015)
																				{
																					num21 = 13017;
																				}
																			}
																		}
																	}
																}
																else
																{
																	if (num24 == 10)
																	{
																		num28 = 8;
																		int num34 = num21;
																		if (num34 == 10016)
																		{
																			num21 = 10019;
																		}
																		else
																		{
																			if (num34 == 11016)
																			{
																				num21 = 11019;
																			}
																			else
																			{
																				if (num34 == 12016)
																				{
																					num21 = 12019;
																				}
																				else
																				{
																					if (num34 == 13015)
																					{
																						num21 = 13018;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
														arrayList8 = this.GetPosAttackTG(this._idBattle, team2, num22, num23, num28);
													}
													if (dataSkill2 == 5 | dataSkill2 == 16 | dataSkill2 == 17 | dataSkill2 == 18)
													{
														arrayList8.Clear();
														arrayList8 = this.GetPosAttack_GiaiTru(this._idBattle, team2, num22, num23, num28);
													}
													if (num18 < 19 & dataSkill2 == 1)
													{
														int num35 = Conversions.ToInteger(dataView[num18 + 1].Row[DataStructure.Type_Battle._Row]);
														int num36 = Conversions.ToInteger(dataView[num18 + 1].Row[DataStructure.Type_Battle._Column]);
														string key4 = Class5.smethod_3(new byte[]
														{
															(byte)num35,
															(byte)num36
														});
														DataStructure.WarInfo warInfo3 = this.ListWar[key4];
														int id5 = warInfo3._Id;
														int team4 = warInfo3._Team;
														int agi2 = warInfo3._Agi;
														if (id5 > 0 & team2 == team4)
														{
															int idSkill2 = warInfo3._IdSkill;
															int dataSkill5 = Data.GetDataSkill(idSkill2, DataStructure.Type_Skill._Type);
															if (dataSkill5 == 1)
															{
																int lv3 = warInfo3._Lv;
																int rowAttack2 = warInfo3._RowAttack;
																int columnAttack2 = warInfo3._ColumnAttack;
																DataStructure.WarInfo warInfo4 = this.ListWar[Class5.smethod_3(new byte[]
																{
																	(byte)rowAttack2,
																	(byte)columnAttack2
																})];
																int id6 = warInfo4._Id;
																int hp3 = warInfo4._Hp;
																if (num22 == rowAttack2 & num23 == columnAttack2 & id6 > 0)
																{
																	if (num16 == 0 & hp3 > 0)
																	{
																		int num37 = agi;
																		int num38 = num37 - 20;
																		int num39 = num37 + 20;
																		if (agi2 >= num38 & agi2 <= num39)
																		{
																			if (agi2 >= agi)
																			{
																				num16 = agi2;
																				num15 = agi;
																			}
																			else
																			{
																				num16 = agi;
																				num15 = agi2;
																			}
																			if (team2 == 1)
																			{
																				num14 = this.GetRandomMissCombo((int)Math.Round(num2), (int)Math.Round(num5));
																			}
																			else
																			{
																				num14 = this.GetRandomMissCombo((int)Math.Round(num5), (int)Math.Round(num2));
																			}
																			num17 = dataSkill4;
																			int rowAttack = num22;
																			int columnAttack = num23;
																			if (num14 == 1 & text8.Length == 0)
																			{
																				num31 = 1.3;
																				if (!arrayList.Contains(string.Concat(new string[]
																				{
																					num19.ToString(),
																					".",
																					num20.ToString(),
																					"/",
																					Conversions.ToString(lv2)
																				})))
																				{
																					arrayList.Add(string.Concat(new string[]
																					{
																						num19.ToString(),
																						".",
																						num20.ToString(),
																						"/",
																						Conversions.ToString(lv2)
																					}));
																				}
																				if (!arrayList.Contains(string.Concat(new string[]
																				{
																					num35.ToString(),
																					".",
																					num36.ToString(),
																					"/",
																					Conversions.ToString(lv3)
																				})))
																				{
																					arrayList.Add(string.Concat(new string[]
																					{
																						num35.ToString(),
																						".",
																						num36.ToString(),
																						"/",
																						Conversions.ToString(lv3)
																					}));
																				}
																			}
																		}
																		else
																		{
																			num14 = 0;
																		}
																	}
																	else
																	{
																		if (num16 > 0)
																		{
																			int num40 = (num15 + num16) / 2;
																			int num41 = num40 - 20;
																			int num42 = num40 + 20;
																			if (agi2 >= num41 & agi2 <= num42)
																			{
																				if (agi2 < num15)
																				{
																					num15 = agi2;
																				}
																				else
																				{
																					if (agi2 > num16)
																					{
																						num16 = agi2;
																					}
																				}
																				if (team2 == 1)
																				{
																					num14 = this.GetRandomMissCombo((int)Math.Round(num2), (int)Math.Round(num5));
																				}
																				else
																				{
																					num14 = this.GetRandomMissCombo((int)Math.Round(num5), (int)Math.Round(num2));
																				}
																				if (num17 <= dataSkill4)
																				{
																					num17 = dataSkill4;
																				}
																				if (num14 == 1 & text8.Length == 0)
																				{
																					num31 = 1.3;
																					if (!arrayList.Contains(string.Concat(new string[]
																					{
																						num19.ToString(),
																						".",
																						num20.ToString(),
																						"/",
																						Conversions.ToString(lv2)
																					})))
																					{
																						arrayList.Add(string.Concat(new string[]
																						{
																							num19.ToString(),
																							".",
																							num20.ToString(),
																							"/",
																							Conversions.ToString(lv2)
																						}));
																					}
																					if (!arrayList.Contains(string.Concat(new string[]
																					{
																						num35.ToString(),
																						".",
																						num36.ToString(),
																						"/",
																						Conversions.ToString(lv3)
																					})))
																					{
																						arrayList.Add(string.Concat(new string[]
																						{
																							num35.ToString(),
																							".",
																							num36.ToString(),
																							"/",
																							Conversions.ToString(lv3)
																						}));
																					}
																				}
																			}
																			else
																			{
																				num14 = 0;
																			}
																		}
																	}
																}
																else
																{
																	num14 = 0;
																}
															}
															else
															{
																num14 = 0;
															}
														}
														else
														{
															num14 = 0;
														}
													}
													else
													{
														num14 = 0;
													}
													int num43 = 0;
													try
													{
														IEnumerator enumerator5 = arrayList8.GetEnumerator();
														while (enumerator5.MoveNext())
														{
															object expr_24BF = enumerator5.Current;
															Point point4 = new Point();
															Point point3 = (expr_24BF != null) ? ((Point)expr_24BF) : point4;
															num22 = point3.X;
															num23 = point3.Y;
															string text10 = Class5.smethod_3(new byte[]
															{
																(byte)num22,
																(byte)num23
															});
															DataStructure.WarInfo warInfo5 = this.ListWar[text10];
															if (Operators.CompareString(text10, text9, false) == 0)
															{
																warInfo5 = warInfo;
															}
															int id7 = warInfo5._Id;
															int lv4 = warInfo5._Lv;
															int idNpcOnMap3 = warInfo5._IdNpcOnMap;
															int idChar3 = warInfo5._IdChar;
															int type3 = warInfo5._Type;
															int int2 = warInfo5._Int;
															int def = warInfo5._Def;
															int hp4 = warInfo5._Hp;
															int hpMax2 = warInfo5._HpMax;
															int sp2 = warInfo5._Sp;
															int spMax = warInfo5._SpMax;
															int reborn2 = warInfo5._Reborn;
															int team5 = warInfo5._Team;
															int idSkill3 = warInfo5._IdSkill;
															int type3_Id3 = warInfo5._Type3_Id;
															int type3_Lv2 = warInfo5._Type3_Lv;
															int type4_Id2 = warInfo5._Type4_Id;
															int type4_Lv = warInfo5._Type4_Lv;
															int type15_Id4 = warInfo5._Type15_Id;
															int type15_Lv3 = warInfo5._Type15_Lv;
															int type19_Id3 = warInfo5._Type19_Id;
															switch (dataSkill2)
															{
															case 1:
															{
																if (num17 == 0)
																{
																	num17 = dataSkill4;
																}
																else
																{
																	if (num17 <= dataSkill4)
																	{
																		num17 = dataSkill4;
																	}
																}
																int num44 = atk;
																string key5 = Class5.smethod_3(new byte[]
																{
																	(byte)(num22 ^ 1),
																	(byte)num23
																});
																DataStructure.WarInfo value4 = this.ListWar[key5];
																int idSkill4 = 0;
																int hp5 = 0;
																if (num22 == 3 | num22 == 0)
																{
																	idSkill4 = value4._IdSkill;
																	hp5 = value4._Hp;
																}
																if (idSkill4 == 20006 & hp5 > 0)
																{
																	int idNpcOnMap4 = value4._IdNpcOnMap;
																	int idChar4 = value4._IdChar;
																	int type4 = value4._Type;
																	int def2 = value4._Def;
																	int type3_Id4 = value4._Type3_Id;
																	int type3_Lv3 = value4._Type3_Lv;
																	int type4_Id3 = value4._Type4_Id;
																	int type4_Lv2 = value4._Type4_Lv;
																	int type15_Id5 = value4._Type15_Id;
																	int type15_Lv4 = value4._Type15_Lv;
																	if (num21 == 10000)
																	{
																		num44 = atk;
																		num30 = (int)Math.Round(unchecked((double)num44 * this.GetDamageThuoctinh(thuoctinh, value4._Thuoctinh) * 2.0 - (double)checked(def2 * 2)));
																	}
																	if (dataSkill3 == 84)
																	{
																		num44 = atk;
																		num30 = (int)Math.Round(unchecked((double)num44 * this.GetDamageThuoctinh(thuoctinh, value4._Thuoctinh) * 2.0 - (double)checked(def2 * 2)));
																	}
																	else
																	{
																		if (dataSkill3 == 87)
																		{
																			num44 = @int;
																			num30 = (int)Math.Round(unchecked((double)num44 * this.GetDamageThuoctinh(thuoctinh, value4._Thuoctinh) * 1.6 - (double)def2 * 1.6));
																		}
																	}
																	num30 = (int)Math.Round(unchecked((double)num44 * this.GetDamageThuoctinh(thuoctinh, value4._Thuoctinh) * 2.0 - (double)def2 * 1.6));
																	num30 += (int)Math.Round((double)(lv2 - value4._Lv) / 1.5) + (int)Math.Round((double)lv2 / 20.0) * 8;
																	num30 = (int)Math.Round(unchecked((double)num30 + (double)this.GetDamageSkillInt(Data.GetDataSkill(num21, DataStructure.Type_Skill._Thuoctinh), value4._Thuoctinh) * num27 * (1.0 + (double)num24 * 0.033)));
																	num30 = (int)Math.Round(unchecked((double)num30 * num31));
																	int num45 = type3_Id4;
																	if (num45 == 11014)
																	{
																		num30 += (int)Math.Round(unchecked((double)num30 * (0.01 * (double)type3_Lv3)));
																	}
																	int num46 = num25;
																	if (num46 == 11002)
																	{
																		num30 -= (int)Math.Round(unchecked((double)num30 * (0.01 * (double)num26)));
																	}
																	int num47 = type19_Id2;
																	if (num47 == 12025)
																	{
																		num30 += (int)Math.Round(unchecked((double)num30 * (0.02 * (double)num26)));
																	}
																	if (num25 == 13012)
																	{
																		num30 += (int)Math.Round(unchecked((double)checked(num30 * num26) * 0.033));
																	}
																	if (type4_Id3 == 13012)
																	{
																		num30 -= (int)Math.Round(unchecked((double)checked(num30 * type4_Lv2) * 0.033));
																	}
																	if (type15_Id5 == 13011)
																	{
																		num30 += (int)Math.Round(unchecked((double)checked(num30 * type15_Lv4) * 0.033));
																	}
																	if (type15_Id3 == 13011)
																	{
																		num30 -= (int)Math.Round(unchecked((double)checked(num30 * type15_Lv2) * 0.033));
																	}
																	if (num28 > 1)
																	{
																		num30 = (int)Math.Round((double)num30 / unchecked((double)num28 * 0.75));
																	}
																	if (team2 == 1)
																	{
																		num29 = this.GetRandomMissAttack(lv2, value4._Lv, (int)Math.Round(num2), (int)Math.Round(num5));
																	}
																	else
																	{
																		num29 = this.GetRandomMissAttack(value4._Lv, lv2, (int)Math.Round(num5), (int)Math.Round(num2));
																	}
																	if (num29 == DataStructure.Type_StatusAttackMiss._Miss)
																	{
																		num30 = 0;
																		attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																		if (idSkill4 == 17001)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																		}
																		int num48 = type4_Id3;
																		if (num48 == 13003)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Lantranh;
																		}
																	}
																	else
																	{
																		if (num29 == DataStructure.Type_StatusAttackMiss._Attack)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																			if (idSkill4 == 17001)
																			{
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																				if (num21 == 10000)
																				{
																					if (this.GetThuoctinhKhac(thuoctinh, value4._Thuoctinh) == 2)
																					{
																						num30 = 1;
																					}
																					else
																					{
																						if (this.GetThuoctinhKhac(thuoctinh, value4._Thuoctinh) == 1)
																						{
																							num30 /= 3;
																						}
																						else
																						{
																							num30 /= 5;
																						}
																					}
																				}
																				else
																				{
																					if (this.GetThuoctinhKhac(Data.GetDataSkill(num21, DataStructure.Type_Skill._Thuoctinh), value4._Thuoctinh) == 2)
																					{
																						num30 = 1;
																					}
																					else
																					{
																						if (this.GetThuoctinhKhac(Data.GetDataSkill(num21, DataStructure.Type_Skill._Thuoctinh), value4._Thuoctinh) == 1)
																						{
																							num30 /= 3;
																						}
																						else
																						{
																							num30 /= 5;
																						}
																					}
																				}
																			}
																			if (num30 >= 1)
																			{
																				num30 += this.random_1.Next(0, 2);
																			}
																			else
																			{
																				num30 = 1;
																			}
																			int num49 = type4_Id3;
																			if (num49 == 10010)
																			{
																				num30 = 0;
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																			}
																			else
																			{
																				if (num49 == 13003)
																				{
																					num30 = 0;
																					attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Lantranh;
																					num29 = DataStructure.Type_StatusAttackMiss._Miss;
																				}
																			}
																			if (type4 != 3 & type4 != 7)
																			{
																				if (idChar4 > 0)
																				{
																					if (value4._Hp - num30 < 0)
																					{
																						if (Server.Clients.ContainsKey(idChar4))
																						{
																							Data.PetUpdateData(idChar4, idNpcOnMap4, DataStructure.Type_Pet._Hp, 0);
																						}
																					}
																					else
																					{
																						if (Server.Clients.ContainsKey(idChar4))
																						{
																							Data.PetUpdateData(idChar4, idNpcOnMap4, DataStructure.Type_Pet._Hp, value4._Hp - num30);
																						}
																					}
																					value4._Hp -= num30;
																				}
																			}
																			else
																			{
																				value4._Hp -= num30;
																			}
																		}
																	}
																	if (num25 == 13005)
																	{
																		num25 = 0;
																		num26 = 0;
																		this.TroiEnd(this._idBattle, num19, num20, DataStructure.Type_TroiBuffEnd._Type4);
																	}
																	if ((num21 == 13007 | num21 == 13029) & type3_Id4 == 0)
																	{
																		text8 = text8 + this.Skilling(num22 ^ 1, num23, num29, attack_Def_Lantranh) + "02";
																		text8 += this.SkillingHieuUng(DataStructure.Type_StatusTroiBuffHpSp._Hp, num30, 1);
																		text8 += this.SkillingHieuUng(DataStructure.Type_StatusTroiBuffHpSp._Type3, 0, 1);
																		value4._Type3_Id = num21;
																		value4._Type3_Lv = num24;
																		value4._Type3_Turn = 3;
																	}
																	else
																	{
																		text8 += this.SkillingInt(num22 ^ 1, num23, num29, attack_Def_Lantranh, 1, DataStructure.Type_StatusTroiBuffHpSp._Hp, num30, 1);
																	}
																	text2 = string.Concat(new string[]
																	{
																		"F444130032010F00",
																		(num22 ^ 1).ToString("X2"),
																		num23.ToString("X2"),
																		"264E0101",
																		(num22 ^ 1).ToString("X2"),
																		num23.ToString("X2"),
																		"010301E0000000"
																	});
																	this.ListWar[key5] = value4;
																}
																else
																{
																	if (num21 == 10000)
																	{
																		num44 = atk;
																		num30 = (int)Math.Round(unchecked((double)num44 * this.GetDamageThuoctinh(thuoctinh, warInfo5._Thuoctinh) * 2.0 - (double)checked(def * 2)));
																	}
																	if (dataSkill3 == 84)
																	{
																		num44 = atk;
																		num30 = (int)Math.Round(unchecked((double)num44 * this.GetDamageThuoctinh(thuoctinh, warInfo5._Thuoctinh) * 2.0 - (double)checked(def * 2)));
																	}
																	else
																	{
																		if (dataSkill3 == 87)
																		{
																			num44 = @int;
																			num30 = (int)Math.Round(unchecked((double)num44 * this.GetDamageThuoctinh(thuoctinh, warInfo5._Thuoctinh) * 1.6 - (double)def * 1.6));
																		}
																	}
																	num30 = (int)Math.Round(unchecked((double)num44 * this.GetDamageThuoctinh(thuoctinh, warInfo5._Thuoctinh) * 2.0 - (double)def * 1.6));
																	num30 += (int)Math.Round((double)(lv2 - warInfo5._Lv) / 1.5) + (int)Math.Round((double)lv2 / 20.0) * 8;
																	num30 = (int)Math.Round(unchecked((double)num30 + (double)this.GetDamageSkillInt(Data.GetDataSkill(num21, DataStructure.Type_Skill._Thuoctinh), warInfo5._Thuoctinh) * num27 * (1.0 + (double)num24 * 0.033)));
																	num30 = (int)Math.Round(unchecked((double)num30 * num31));
																	int num50 = type3_Id3;
																	if (num50 == 11014)
																	{
																		num30 += (int)Math.Round(unchecked((double)num30 * (0.01 * (double)type3_Lv2)));
																	}
																	int num51 = num25;
																	if (num51 == 11002)
																	{
																		num30 -= (int)Math.Round(unchecked((double)num30 * (0.01 * (double)num26)));
																	}
																	int num52 = type19_Id2;
																	if (num52 == 12025)
																	{
																		num30 += (int)Math.Round(unchecked((double)num30 * (0.02 * (double)num26)));
																	}
																	if (num25 == 13012)
																	{
																		num30 += (int)Math.Round(unchecked((double)checked(num30 * num26) * 0.033));
																	}
																	if (type4_Id2 == 13012)
																	{
																		num30 -= (int)Math.Round(unchecked((double)checked(num30 * type4_Lv) * 0.033));
																	}
																	if (type15_Id4 == 13011)
																	{
																		num30 += (int)Math.Round(unchecked((double)checked(num30 * type15_Lv3) * 0.033));
																	}
																	if (type15_Id3 == 13011)
																	{
																		num30 -= (int)Math.Round(unchecked((double)checked(num30 * type15_Lv2) * 0.033));
																	}
																	if (num28 > 1)
																	{
																		num30 = (int)Math.Round((double)num30 / unchecked((double)num28 * 0.75));
																	}
																	if (team2 == 1)
																	{
																		num29 = this.GetRandomMissAttack(lv2, warInfo5._Lv, (int)Math.Round(num2), (int)Math.Round(num5));
																	}
																	else
																	{
																		num29 = this.GetRandomMissAttack(warInfo5._Lv, lv2, (int)Math.Round(num5), (int)Math.Round(num2));
																	}
																	if (num29 == DataStructure.Type_StatusAttackMiss._Miss)
																	{
																		num30 = 0;
																		attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																		if (idSkill3 == 17001)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																		}
																		int num53 = type4_Id2;
																		if (num53 == 13003)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Lantranh;
																		}
																	}
																	else
																	{
																		if (num29 == DataStructure.Type_StatusAttackMiss._Attack)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																			if (idSkill3 == 17001)
																			{
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																				if (num21 == 10000)
																				{
																					if (this.GetThuoctinhKhac(thuoctinh, warInfo5._Thuoctinh) == 2)
																					{
																						num30 = 1;
																					}
																					else
																					{
																						if (this.GetThuoctinhKhac(thuoctinh, warInfo5._Thuoctinh) == 1)
																						{
																							num30 /= 3;
																						}
																						else
																						{
																							num30 /= 5;
																						}
																					}
																				}
																				else
																				{
																					if (this.GetThuoctinhKhac(Data.GetDataSkill(num21, DataStructure.Type_Skill._Thuoctinh), warInfo5._Thuoctinh) == 2)
																					{
																						num30 = 1;
																					}
																					else
																					{
																						if (this.GetThuoctinhKhac(Data.GetDataSkill(num21, DataStructure.Type_Skill._Thuoctinh), warInfo5._Thuoctinh) == 1)
																						{
																							num30 /= 3;
																						}
																						else
																						{
																							num30 /= 5;
																						}
																					}
																				}
																			}
																			if (num30 >= 1)
																			{
																				num30 += this.random_1.Next(0, 2);
																			}
																			else
																			{
																				num30 = 1;
																			}
																			int num54 = type4_Id2;
																			if (num54 == 10010)
																			{
																				num30 = 0;
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																			}
																			else
																			{
																				if (num54 == 13003)
																				{
																					num30 = 0;
																					attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Lantranh;
																					num29 = DataStructure.Type_StatusAttackMiss._Miss;
																				}
																			}
																			if (type3 != 3 & type3 != 7)
																			{
																				if (idChar3 == 0)
																				{
																					if (warInfo5._Hp - num30 < 0)
																					{
																						Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Hp, 0);
																					}
																					else
																					{
																						Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Hp, warInfo5._Hp - num30);
																					}
																					warInfo5._Hp -= num30;
																				}
																				else
																				{
																					if (warInfo5._Hp - num30 < 0)
																					{
																						if (Server.Clients.ContainsKey(idChar3))
																						{
																							Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Hp, 0);
																						}
																					}
																					else
																					{
																						if (Server.Clients.ContainsKey(idChar3))
																						{
																							Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Hp, warInfo5._Hp - num30);
																						}
																					}
																					warInfo5._Hp -= num30;
																				}
																			}
																			else
																			{
																				warInfo5._Hp -= num30;
																			}
																		}
																	}
																	if (num25 == 13005)
																	{
																		num25 = 0;
																		num26 = 0;
																		this.TroiEnd(this._idBattle, num19, num20, DataStructure.Type_TroiBuffEnd._Type4);
																	}
																	if (type3 == 7)
																	{
																		if (!arrayList2.Contains(string.Concat(new string[]
																		{
																			num22.ToString(),
																			".",
																			num23.ToString(),
																			"/",
																			Conversions.ToString(lv4)
																		})))
																		{
																			arrayList2.Add(string.Concat(new string[]
																			{
																				num22.ToString(),
																				".",
																				num23.ToString(),
																				"/",
																				Conversions.ToString(lv4)
																			}));
																		}
																		if ((arrayList.Count == 0 & num14 == 0) && lv2 - lv4 <= 20)
																		{
																			int num55 = (int)Math.Round(unchecked((double)lv4 / 2.0 + (double)checked(lv4 - lv2)));
																			if (warInfo5._Hp <= 0)
																			{
																				warInfo._Exp += num55;
																			}
																			else
																			{
																				warInfo._Exp += (int)Math.Round((double)num55 / 10.0);
																			}
																		}
																	}
																	if ((num21 == 13007 | num21 == 13029) & type3_Id3 == 0 & this.GetRandomMissTroi(lv2, warInfo5._Lv, (int)Math.Round(num2), (int)Math.Round(num5), @int, int2, reborn, reborn2) == 1)
																	{
																		text8 = text8 + this.Skilling(num22, num23, num29, attack_Def_Lantranh) + "02";
																		text8 += this.SkillingHieuUng(DataStructure.Type_StatusTroiBuffHpSp._Hp, num30, 1);
																		text8 += this.SkillingHieuUng(DataStructure.Type_StatusTroiBuffHpSp._Type3, 0, 1);
																		warInfo5._Type3_Id = num21;
																		warInfo5._Type3_Lv = num24;
																		warInfo5._Type3_Turn = 3;
																	}
																	else
																	{
																		text8 += this.SkillingInt(num22, num23, num29, attack_Def_Lantranh, 1, DataStructure.Type_StatusTroiBuffHpSp._Hp, num30, 1);
																	}
																}
																break;
															}
															case 2:
															{
																num17 = dataSkill4;
																int num56 = @int;
																string key6 = Class5.smethod_3(new byte[]
																{
																	(byte)(num22 ^ 1),
																	(byte)num23
																});
																DataStructure.WarInfo value5 = this.ListWar[key6];
																int idSkill5 = 0;
																int hp6 = 0;
																if (num22 == 3 | num22 == 0)
																{
																	idSkill5 = value5._IdSkill;
																	hp6 = value5._Hp;
																}
																if (idSkill5 == 20006 & hp6 > 0)
																{
																	int idNpcOnMap5 = value5._IdNpcOnMap;
																	int idChar5 = value5._IdChar;
																	int type5 = value5._Type;
																	int def3 = value5._Def;
																	int type3_Id5 = value5._Type3_Id;
																	int type3_Lv4 = value5._Type3_Lv;
																	int type4_Id4 = value5._Type4_Id;
																	int type4_Lv3 = value5._Type4_Lv;
																	int type15_Id6 = value5._Type15_Id;
																	int type15_Lv5 = value5._Type15_Lv;
																	num30 = (int)Math.Round(unchecked((double)num56 * this.GetDamageThuoctinh(thuoctinh, value5._Thuoctinh) * 2.0 - (double)def3 * 1.6));
																	num30 += (int)Math.Round((double)(lv2 - value5._Lv) / 1.5) + (int)Math.Round((double)lv2 / 20.0) * 8;
																	num30 = (int)Math.Round(unchecked((double)num30 + (double)this.GetDamageSkillInt(Data.GetDataSkill(num21, DataStructure.Type_Skill._Thuoctinh), value5._Thuoctinh) * num27 * (1.0 + (double)num24 * 0.033)));
																	int num57 = type3_Id5;
																	if (num57 == 11014)
																	{
																		num30 += (int)Math.Round(unchecked((double)num30 * (0.01 * (double)type3_Lv4)));
																	}
																	int num58 = num25;
																	if (num58 == 11002)
																	{
																		num30 -= (int)Math.Round(unchecked((double)num30 * (0.01 * (double)num26)));
																	}
																	if (num25 == 13012)
																	{
																		num30 += (int)Math.Round(unchecked((double)checked(num30 * num26) * 0.033));
																	}
																	if (type4_Id4 == 13012)
																	{
																		num30 -= (int)Math.Round(unchecked((double)checked(num30 * type4_Lv3) * 0.033));
																	}
																	if (type15_Id6 == 13011)
																	{
																		num30 += (int)Math.Round(unchecked((double)checked(num30 * type15_Lv5) * 0.033));
																	}
																	if (type15_Id3 == 13011)
																	{
																		num30 -= (int)Math.Round(unchecked((double)checked(num30 * type15_Lv2) * 0.033));
																	}
																	if (num21 >= 12016 & num21 <= 12019)
																	{
																		if (num28 > 1)
																		{
																			num30 = (int)Math.Round((double)num30 / unchecked((double)num28 * 0.5)) + num24 * 50;
																		}
																	}
																	else
																	{
																		if (num28 > 1)
																		{
																			num30 = (int)Math.Round((double)num30 / unchecked((double)num28 * 0.75));
																		}
																	}
																	if (num30 >= 1)
																	{
																		num30 += this.random_1.Next(0, 2);
																	}
																	else
																	{
																		num30 = 1;
																	}
																	if (team2 == 1)
																	{
																		num29 = this.GetRandomMissAttack(lv2, value5._Lv, (int)Math.Round(num2), (int)Math.Round(num5));
																	}
																	else
																	{
																		num29 = this.GetRandomMissAttack(value5._Lv, lv2, (int)Math.Round(num5), (int)Math.Round(num2));
																	}
																	if (num29 == DataStructure.Type_StatusAttackMiss._Miss)
																	{
																		num30 = 0;
																		attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																		if (idSkill5 == 17001)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																		}
																		int num59 = type4_Id4;
																		if (num59 == 13003)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Lantranh;
																		}
																	}
																	else
																	{
																		if (num29 == DataStructure.Type_StatusAttackMiss._Attack)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																			if (idSkill5 == 17001)
																			{
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																				if (this.GetThuoctinhKhac(Data.GetDataSkill(num21, DataStructure.Type_Skill._Thuoctinh), value5._Thuoctinh) == 2)
																				{
																					num30 = 1;
																				}
																				else
																				{
																					if (this.GetThuoctinhKhac(Data.GetDataSkill(num21, DataStructure.Type_Skill._Thuoctinh), value5._Thuoctinh) == 1)
																					{
																						num30 /= 3;
																					}
																					else
																					{
																						num30 /= 5;
																					}
																				}
																			}
																			int num60 = type4_Id4;
																			if (num60 == 10010)
																			{
																				num30 = 0;
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																			}
																			if (type5 != 3 & type5 != 7)
																			{
																				if (value5._Hp - num30 < 0)
																				{
																					if (Server.Clients.ContainsKey(idChar5))
																					{
																						Data.PetUpdateData(idChar5, idNpcOnMap5, DataStructure.Type_Pet._Hp, 0);
																					}
																				}
																				else
																				{
																					if (Server.Clients.ContainsKey(idChar5))
																					{
																						Data.PetUpdateData(idChar5, idNpcOnMap5, DataStructure.Type_Pet._Hp, value5._Hp - num30);
																					}
																				}
																			}
																			value5._Hp -= num30;
																		}
																	}
																	text8 += this.SkillingInt(num22 ^ 1, num23, num29, attack_Def_Lantranh, 1, DataStructure.Type_StatusTroiBuffHpSp._Hp, num30, 1);
																	text2 = string.Concat(new string[]
																	{
																		"F444130032010F00",
																		(num22 ^ 1).ToString("X2"),
																		num23.ToString("X2"),
																		"264E0101",
																		(num22 ^ 1).ToString("X2"),
																		num23.ToString("X2"),
																		"010301E0000000"
																	});
																	this.ListWar[key6] = value5;
																}
																else
																{
																	num30 = (int)Math.Round(unchecked((double)num56 * this.GetDamageThuoctinh(thuoctinh, warInfo5._Thuoctinh) * 2.0 - (double)def * 1.6));
																	num30 += (int)Math.Round((double)(lv2 - warInfo5._Lv) / 1.5) + (int)Math.Round((double)lv2 / 20.0) * 8;
																	num30 = (int)Math.Round(unchecked((double)num30 + (double)this.GetDamageSkillInt(Data.GetDataSkill(num21, DataStructure.Type_Skill._Thuoctinh), warInfo5._Thuoctinh) * num27 * (1.0 + (double)num24 * 0.033)));
																	int num61 = type3_Id3;
																	if (num61 == 11014)
																	{
																		num30 += (int)Math.Round(unchecked((double)num30 * (0.01 * (double)type3_Lv2)));
																	}
																	int num62 = num25;
																	if (num62 == 11002)
																	{
																		num30 -= (int)Math.Round(unchecked((double)num30 * (0.01 * (double)num26)));
																	}
																	if (num25 == 13012)
																	{
																		num30 += (int)Math.Round(unchecked((double)checked(num30 * num26) * 0.033));
																	}
																	if (type4_Id2 == 13012)
																	{
																		num30 -= (int)Math.Round(unchecked((double)checked(num30 * type4_Lv) * 0.033));
																	}
																	if (type15_Id4 == 13011)
																	{
																		num30 += (int)Math.Round(unchecked((double)checked(num30 * type15_Lv3) * 0.033));
																	}
																	if (type15_Id3 == 13011)
																	{
																		num30 -= (int)Math.Round(unchecked((double)checked(num30 * type15_Lv2) * 0.033));
																	}
																	if (num21 >= 12016 & num21 <= 12019)
																	{
																		if (num28 > 1)
																		{
																			num30 = (int)Math.Round((double)num30 / unchecked((double)num28 * 0.5)) + num24 * 50;
																		}
																	}
																	else
																	{
																		if (num28 > 1)
																		{
																			num30 = (int)Math.Round((double)num30 / unchecked((double)num28 * 0.75));
																		}
																	}
																	if (num30 >= 1)
																	{
																		num30 += this.random_1.Next(0, 2);
																	}
																	else
																	{
																		num30 = 1;
																	}
																	if (team2 == 1)
																	{
																		num29 = this.GetRandomMissAttack(lv2, warInfo5._Lv, (int)Math.Round(num2), (int)Math.Round(num5));
																	}
																	else
																	{
																		num29 = this.GetRandomMissAttack(warInfo5._Lv, lv2, (int)Math.Round(num5), (int)Math.Round(num2));
																	}
																	if (num29 == DataStructure.Type_StatusAttackMiss._Miss)
																	{
																		num30 = 0;
																		attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																		if (idSkill3 == 17001)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																		}
																		int num63 = type4_Id2;
																		if (num63 == 13003)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Lantranh;
																		}
																	}
																	else
																	{
																		if (num29 == DataStructure.Type_StatusAttackMiss._Attack)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																			if (idSkill3 == 17001)
																			{
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																				if (this.GetThuoctinhKhac(Data.GetDataSkill(num21, DataStructure.Type_Skill._Thuoctinh), warInfo5._Thuoctinh) == 2)
																				{
																					num30 = 1;
																				}
																				else
																				{
																					if (this.GetThuoctinhKhac(Data.GetDataSkill(num21, DataStructure.Type_Skill._Thuoctinh), warInfo5._Thuoctinh) == 1)
																					{
																						num30 /= 3;
																					}
																					else
																					{
																						num30 /= 5;
																					}
																				}
																			}
																			int num64 = type4_Id2;
																			if (num64 == 10010)
																			{
																				num30 = 0;
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																			}
																			if (type3 != 3 & type3 != 7)
																			{
																				if (idChar3 == 0)
																				{
																					if (warInfo5._Hp - num30 < 0)
																					{
																						Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Hp, 0);
																					}
																					else
																					{
																						Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Hp, warInfo5._Hp - num30);
																					}
																				}
																				else
																				{
																					if (warInfo5._Hp - num30 < 0)
																					{
																						if (Server.Clients.ContainsKey(idChar3))
																						{
																							Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Hp, 0);
																						}
																					}
																					else
																					{
																						if (Server.Clients.ContainsKey(idChar3))
																						{
																							Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Hp, warInfo5._Hp - num30);
																						}
																					}
																				}
																			}
																			warInfo5._Hp -= num30;
																		}
																	}
																	if (num30 > 0 && type3 == 7)
																	{
																		if (!arrayList2.Contains(string.Concat(new string[]
																		{
																			num22.ToString(),
																			".",
																			num23.ToString(),
																			"/",
																			Conversions.ToString(lv4)
																		})))
																		{
																			arrayList2.Add(string.Concat(new string[]
																			{
																				num22.ToString(),
																				".",
																				num23.ToString(),
																				"/",
																				Conversions.ToString(lv4)
																			}));
																		}
																		if (lv2 - lv4 <= 20)
																		{
																			int num65 = (int)Math.Round(unchecked((double)lv4 / 2.0 + (double)checked(lv4 - lv2)));
																			if (warInfo5._Hp <= 0)
																			{
																				warInfo._Exp += num65;
																			}
																			else
																			{
																				warInfo._Exp += (int)Math.Round((double)num65 / 10.0);
																			}
																		}
																	}
																	text8 += this.SkillingInt(num22, num23, num29, attack_Def_Lantranh, 1, DataStructure.Type_StatusTroiBuffHpSp._Hp, num30, 1);
																}
																break;
															}
															case 3:
															{
																num17 = dataSkill4;
																int turn = this.GetTurn(num21, num24);
																int troiBuffHpSp = DataStructure.Type_StatusTroiBuffHpSp._Type4;
																if (type3_Id3 > 0)
																{
																	num29 = DataStructure.Type_StatusAttackMiss._Miss;
																}
																else
																{
																	num29 = this.GetRandomMissTroi(lv2, warInfo5._Lv, (int)Math.Round(num2), (int)Math.Round(num5), @int, int2, reborn, reborn2);
																	if (num29 == DataStructure.Type_StatusAttackMiss._Miss)
																	{
																		troiBuffHpSp = DataStructure.Type_StatusTroiBuffHpSp._Miss;
																		attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																		if (warInfo5._IdSkill == 17001)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																		}
																		if (type4_Id2 == 13003)
																		{
																			num30 = 0;
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Lantranh;
																		}
																		if (type4_Id2 == 10010)
																		{
																			num30 = 0;
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																		}
																	}
																	else
																	{
																		if (num29 == DataStructure.Type_StatusAttackMiss._Attack)
																		{
																			troiBuffHpSp = DataStructure.Type_StatusTroiBuffHpSp._Type3;
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																			if (warInfo5._IdSkill == 17001)
																			{
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																			}
																			if (type4_Id2 == 13003)
																			{
																				num30 = 0;
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Lantranh;
																			}
																			if (type4_Id2 == 10010)
																			{
																				num30 = 0;
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																			}
																			if (num21 >= 13015 & num21 <= 13018)
																			{
																				int num66 = warInfo5._Sp - num24 * 30;
																				num43 += num24 * 30;
																				if (num66 >= 0)
																				{
																					if (type3 != 3 & type3 != 7)
																					{
																						if (idChar3 == 0)
																						{
																							Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Sp, num66);
																						}
																						else
																						{
																							if (Server.Clients.ContainsKey(idChar3))
																							{
																								Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Sp, num66);
																							}
																						}
																					}
																					warInfo5._Sp = num66;
																				}
																				else
																				{
																					if (type3 != 3 & type3 != 7)
																					{
																						if (idChar3 == 0)
																						{
																							Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Sp, 0);
																						}
																						else
																						{
																							if (Server.Clients.ContainsKey(idChar3))
																							{
																								Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Sp, 0);
																							}
																						}
																					}
																					warInfo5._Sp = 0;
																				}
																				if (hp2 + num43 > hpMax)
																				{
																					num43 = hpMax - hp2;
																					if (type2 != 3 & type2 != 7)
																					{
																						if (idChar2 == 0)
																						{
																							Data.PlayerUpdateDataId(id3, DataStructure.Type_Player._Hp, hpMax);
																						}
																						else
																						{
																							if (Server.Clients.ContainsKey(idChar2))
																							{
																								Data.PetUpdateData(idChar2, idNpcOnMap3, DataStructure.Type_Pet._Hp, hpMax);
																							}
																						}
																					}
																					warInfo._Hp = hpMax;
																				}
																				else
																				{
																					if (type2 != 3 & type2 != 7)
																					{
																						if (idChar2 == 0)
																						{
																							Data.PlayerUpdateDataId(id3, DataStructure.Type_Player._Hp, hp2 + num43);
																						}
																						else
																						{
																							if (Server.Clients.ContainsKey(idChar2))
																							{
																								Data.PetUpdateData(idChar2, idNpcOnMap3, DataStructure.Type_Pet._Hp, hp2 + num43);
																							}
																						}
																					}
																					warInfo._Hp = hp2 + num43;
																				}
																				warInfo5._Type3_Id = num21;
																				warInfo5._Type3_Lv = num24;
																				warInfo5._Type3_Turn = turn;
																			}
																			else
																			{
																				if (type4_Id2 == 10026)
																				{
																					num29 = DataStructure.Type_StatusAttackMiss._Attack;
																					troiBuffHpSp = DataStructure.Type_StatusTroiBuffHpSp._Miss;
																					if (type3_Id2 == 0)
																					{
																						warInfo._Type3_Id = num21;
																						warInfo._Type3_Lv = num24;
																						warInfo._Type3_Turn = turn;
																						text = this.TroiStart(num19, num20, 1, num21);
																					}
																				}
																				else
																				{
																					warInfo5._Type3_Id = num21;
																					warInfo5._Type3_Lv = num24;
																					warInfo5._Type3_Turn = turn;
																				}
																			}
																		}
																	}
																}
																if (num21 >= 13015 & num21 <= 13018)
																{
																	text8 = string.Concat(new string[]
																	{
																		text8,
																		this.SkillingInt(num22, num23, num29, attack_Def_Lantranh, 2, troiBuffHpSp, 0, 1),
																		DataStructure.Type_StatusTroiBuffHpSp._Sp.ToString("X2"),
																		Class5.smethod_11(num24 * 64),
																		"01"
																	});
																}
																else
																{
																	text8 += this.SkillingInt(num22, num23, num29, attack_Def_Lantranh, 1, troiBuffHpSp, num30, 1);
																}
																break;
															}
															case 4:
															{
																num17 = dataSkill4;
																int turn2 = this.GetTurn(num21, num24);
																if (type4_Id2 == 0)
																{
																	num29 = DataStructure.Type_StatusAttackMiss._Attack;
																	attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																}
																else
																{
																	num29 = DataStructure.Type_StatusAttackMiss._Miss;
																	attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																}
																int troiBuffHpSp2 = DataStructure.Type_StatusTroiBuffHpSp._Type4;
																if (num29 == DataStructure.Type_StatusAttackMiss._Miss)
																{
																	troiBuffHpSp2 = 0;
																}
																else
																{
																	troiBuffHpSp2 = DataStructure.Type_StatusTroiBuffHpSp._Type4;
																	warInfo5._Type4_Id = num21;
																	warInfo5._Type4_Lv = num24;
																	warInfo5._Type4_Turn = turn2;
																}
																text8 += this.SkillingInt(num22, num23, num29, attack_Def_Lantranh, 1, troiBuffHpSp2, 0, 1);
																break;
															}
															case 5:
															{
																num17 = dataSkill4;
																int num67 = num21;
																if (num67 == 11014)
																{
																	if (type4_Id2 == 10010)
																	{
																		warInfo5._Type4_Id = 0;
																		warInfo5._Type4_Lv = 0;
																		warInfo5._Type4_Turn = 0;
																		num29 = DataStructure.Type_StatusAttackMiss._Attack;
																	}
																	else
																	{
																		num29 = DataStructure.Type_StatusAttackMiss._Miss;
																	}
																	text8 += this.SkillingInt(num22, num23, num29, 0, 1, DataStructure.Type_StatusTroiBuffHpSp._Type4, 0, 1);
																}
																else
																{
																	if (num67 == 14007)
																	{
																		if (type4_Id2 == 14008)
																		{
																			warInfo5._Type4_Id = 0;
																			warInfo5._Type4_Lv = 0;
																			warInfo5._Type4_Turn = 0;
																			num29 = DataStructure.Type_StatusAttackMiss._Attack;
																		}
																		else
																		{
																			num29 = DataStructure.Type_StatusAttackMiss._Miss;
																		}
																		text8 += this.SkillingInt(num22, num23, num29, 0, 1, DataStructure.Type_StatusTroiBuffHpSp._Type4, 0, 1);
																	}
																	else
																	{
																		if (num67 == 14014)
																		{
																			if (type4_Id2 == 14015)
																			{
																				warInfo5._Type4_Id = 0;
																				warInfo5._Type4_Lv = 0;
																				warInfo5._Type4_Turn = 0;
																				num29 = DataStructure.Type_StatusAttackMiss._Attack;
																			}
																			else
																			{
																				num29 = DataStructure.Type_StatusAttackMiss._Miss;
																			}
																			text8 += this.SkillingInt(num22, num23, num29, 0, 1, DataStructure.Type_StatusTroiBuffHpSp._Type4, 0, 1);
																		}
																		else
																		{
																			if (num67 == 14022)
																			{
																				if (type4_Id2 == 10021)
																				{
																					warInfo5._Type4_Id = 0;
																					warInfo5._Type4_Lv = 0;
																					warInfo5._Type4_Turn = 0;
																					num29 = DataStructure.Type_StatusAttackMiss._Attack;
																				}
																				else
																				{
																					num29 = DataStructure.Type_StatusAttackMiss._Miss;
																				}
																				text8 += this.SkillingInt(num22, num23, num29, 0, 1, DataStructure.Type_StatusTroiBuffHpSp._Type4, 0, 1);
																			}
																			else
																			{
																				warInfo5._Type3_Id = 0;
																				warInfo5._Type3_Lv = 0;
																				warInfo5._Type3_Turn = 0;
																				warInfo5._Type4_Id = 0;
																				warInfo5._Type4_Lv = 0;
																				warInfo5._Type4_Turn = 0;
																				warInfo5._Type15_Id = 0;
																				warInfo5._Type15_Lv = 0;
																				warInfo5._Type15_Turn = 0;
																				warInfo5._Type19_Id = 0;
																				warInfo5._Type19_Lv = 0;
																				warInfo5._Type19_Turn = 0;
																				num29 = DataStructure.Type_StatusAttackMiss._Attack;
																				text8 = text8 + this.SkillingInt(num22, num23, num29, 0, 5, DataStructure.Type_StatusTroiBuffHpSp._Miss, 0, 1) + "DD000001DE000001DF000001E1000001";
																			}
																		}
																	}
																}
																break;
															}
															case 6:
															{
																num17 = dataSkill4;
																num29 = DataStructure.Type_StatusAttackMiss._Attack;
																attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																int num68 = (int)Math.Round(unchecked((double)@int * 0.25));
																if (num21 == 11009)
																{
																	num68 = (int)Math.Round(unchecked((double)@int * 0.05 * (double)num24));
																}
																else
																{
																	if (num21 == 11006)
																	{
																		num68 = (int)Math.Round(unchecked((double)@int * 0.1 * (double)num24));
																	}
																}
																if (id3 == id7)
																{
																	num68 = 0;
																}
																if (sp2 + num68 <= spMax)
																{
																	warInfo5._Sp = sp2 + num68;
																	if (idChar3 == 0)
																	{
																		Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Sp, sp2 + num68);
																	}
																	else
																	{
																		if (Server.Clients.ContainsKey(idChar3))
																		{
																			Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Sp, sp2 + num68);
																		}
																	}
																}
																else
																{
																	if (sp2 + num68 > spMax)
																	{
																		num68 = spMax - sp2;
																		warInfo5._Sp = spMax;
																		if (idChar3 == 0)
																		{
																			Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Sp, spMax);
																		}
																		else
																		{
																			if (Server.Clients.ContainsKey(idChar3))
																			{
																				Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Sp, spMax);
																			}
																		}
																	}
																	else
																	{
																		if (sp2 == spMax)
																		{
																			num68 = 0;
																		}
																	}
																}
																if (num19 == num22 & num20 == num23)
																{
																	num68 = 0;
																}
																text8 += this.SkillingInt(num22, num23, num29, attack_Def_Lantranh, 1, DataStructure.Type_StatusTroiBuffHpSp._Sp, num68, 0);
																break;
															}
															case 7:
															{
																num17 = dataSkill4;
																num29 = DataStructure.Type_StatusAttackMiss._Attack;
																attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																int num69 = (int)Math.Round(unchecked((double)@int * 0.5));
																if (num21 == 11010)
																{
																	num69 = (int)Math.Round(unchecked((double)@int * 0.1 * (double)num24));
																}
																else
																{
																	if (num21 == 11007)
																	{
																		num69 = (int)Math.Round(unchecked((double)@int * 0.2 * (double)num24));
																	}
																}
																if (hp4 + num69 <= hpMax2)
																{
																	warInfo5._Hp = hp4 + num69;
																	if (idChar3 == 0)
																	{
																		Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Hp, hp4 + num69);
																	}
																	else
																	{
																		if (Server.Clients.ContainsKey(idChar3))
																		{
																			Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Hp, hp4 + num69);
																		}
																	}
																}
																else
																{
																	if (hp4 + num69 > hpMax2)
																	{
																		num69 = hpMax2 - hp4;
																		warInfo5._Hp = hpMax2;
																		if (idChar3 == 0)
																		{
																			Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Hp, hpMax2);
																		}
																		else
																		{
																			if (Server.Clients.ContainsKey(idChar3))
																			{
																				Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Hp, hpMax2);
																			}
																		}
																	}
																	else
																	{
																		if (hp4 == hpMax2)
																		{
																			num69 = 0;
																		}
																	}
																}
																text8 += this.SkillingInt(num22, num23, num29, attack_Def_Lantranh, 1, DataStructure.Type_StatusTroiBuffHpSp._Hp, num69, 0);
																break;
															}
															case 8:
															{
																num17 = dataSkill4;
																int num70 = 0;
																if (hp4 <= 0)
																{
																	num70 = (int)Math.Round((double)warInfo5._HpMax / (10.0 / (double)num24));
																	num29 = DataStructure.Type_StatusAttackMiss._Attack;
																	attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																	warInfo5._Hp = num70;
																	if (idChar3 == 0)
																	{
																		Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Hp, num70);
																	}
																	else
																	{
																		if (Server.Clients.ContainsKey(idChar3))
																		{
																			Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Hp, num70);
																		}
																	}
																}
																else
																{
																	num29 = DataStructure.Type_StatusAttackMiss._Miss;
																	attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																}
																text8 += this.SkillingInt(num22, num23, num29, attack_Def_Lantranh, 1, DataStructure.Type_StatusTroiBuffHpSp._Hp, num70, 0);
																break;
															}
															case 11:
																if (type3_Id3 == 0)
																{
																	num17 = dataSkill4;
																	if ((type3 != 2 & type3 != 4) && (Data.GetDataNpc(id7, DataStructure.Type_Npc._Bat) == 0 & type3_Id3 == 0) && (lv2 - lv4 >= 5 & (int)Math.Round(unchecked((double)hp4 / (double)hpMax2 * 100.0)) < 50))
																	{
																		int num71 = this.RandomizeArrayWithPercent(1, 0, 50 + (int)Math.Round((double)(lv2 - lv4) / 2.0));
																		int num72 = Data.PetGetData(Server.Clients[id3].conn, 1, DataStructure.Type_Pet._ID);
																		int num73 = Data.PetGetData(Server.Clients[id3].conn, 2, DataStructure.Type_Pet._ID);
																		int num74 = Data.PetGetData(Server.Clients[id3].conn, 3, DataStructure.Type_Pet._ID);
																		int num75 = Data.PetGetData(Server.Clients[id3].conn, 4, DataStructure.Type_Pet._ID);
																		switch (num71)
																		{
																		case 0:
																			num21 = 15002;
																			break;
																		case 1:
																			if (num72 == 0 & num73 == 0 & num74 == 0 & num75 == 0)
																			{
																				num21 = 15003;
																				this.ChangedWar(Class5.smethod_3(new byte[]
																				{
																					(byte)num22,
																					(byte)num23
																				}), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
																				Data.Addpet(id3, id7);
																			}
																			else
																			{
																				num21 = 15002;
																			}
																			break;
																		}
																	}
																	num29 = DataStructure.Type_StatusAttackMiss._Attack;
																	attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																	text8 += this.SkillingInt(num22, num23, num29, attack_Def_Lantranh, 1, DataStructure.Type_StatusTroiBuffHpSp._Miss, 0, 1);
																}
																break;
															case 12:
																num17 = dataSkill4;
																num22 = num19;
																num23 = num20;
																num29 = this.GetRandomMissChayTron(lv2, warInfo5._Lv, (int)Math.Round(num2), (int)Math.Round(num5));
																if (num29 == 1 | num21 == 14002)
																{
																	if ((id3 == leaderId | idChar2 == leaderId) & leaderId > 0)
																	{
																		goto IL_746D;
																	}
																	text7 = text7 + "F44404003505" + num19.ToString("X2") + num20.ToString("X2");
																	text7 = text7 + "F44404003505" + (num19 ^ 1).ToString("X2") + num20.ToString("X2");
																	int key7;
																	if (idChar2 == 0)
																	{
																		key7 = id3;
																		text7 = string.Concat(new string[]
																		{
																			text7,
																			"F44404000B01",
																			(num19 ^ 1).ToString("X2"),
																			num20.ToString("X2"),
																			"F44404000B01",
																			num19.ToString("X2"),
																			num20.ToString("X2"),
																			"F44408000B00",
																			Class5.smethod_12(id3),
																			"0000F44405000B01",
																			num19.ToString("X2"),
																			num20.ToString("X2"),
																			"00"
																		});
																		Server.SendToAllClientMapid(id3, "F44408000B00" + Class5.smethod_12(id3) + "0000");
																		if (Server.Clients.ContainsKey(id3))
																		{
																			Server.Clients[id3]._My_WarpingId = 0;
																		}
																		Server.SendToClient(id3, "F44402000504");
																		Server.SendToClient(id3, "F44402001408");
																	}
																	else
																	{
																		key7 = idChar2;
																		text7 = string.Concat(new string[]
																		{
																			text7,
																			"F44404000B01",
																			num19.ToString("X2"),
																			num20.ToString("X2"),
																			"F44404000B01",
																			(num19 ^ 1).ToString("X2"),
																			num20.ToString("X2"),
																			"F44408000B00",
																			Class5.smethod_12(idChar2),
																			"0000F44405000B01",
																			(num19 ^ 1).ToString("X2"),
																			num20.ToString("X2"),
																			"00"
																		});
																		Server.SendToAllClientMapid(idChar2, "F44408000B00" + Class5.smethod_12(idChar2) + "0000");
																		if (Server.Clients.ContainsKey(idChar2))
																		{
																			Server.Clients[idChar2]._My_WarpingId = 0;
																		}
																		Server.SendToClient(idChar2, "F44402000504");
																		Server.SendToClient(idChar2, "F44402001408");
																	}
																	if (text7.Length > 0)
																	{
																		this.SendSKillingToParty(text7);
																		this.ChangedWar(Class5.smethod_3(new byte[]
																		{
																			(byte)num19,
																			(byte)num20
																		}), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
																		this.ChangedWar(Class5.smethod_3(new byte[]
																		{
																			(byte)(num19 ^ 1),
																			(byte)num20
																		}), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
																		text7 = "";
																		int num76;
																		if (idChar2 == 0)
																		{
																			num76 = id3;
																		}
																		else
																		{
																			num76 = idChar2;
																		}
																		if (Server.Clients.ContainsKey(num76))
																		{
																			Server.Clients[num76]._My_IdBattle = 0;
																			if (Server.Clients[num76]._My_Hp <= 0)
																			{
																				Data.PlayerUpdateDataId(num76, DataStructure.Type_Player._Hp, 1);
																			}
																			int num77 = 1;
																			do
																			{
																				if (Data.PetGetData(Server.Clients[num76].conn, num77, DataStructure.Type_Pet._ID) > 0 && Data.PetGetData(Server.Clients[num76].conn, num77, DataStructure.Type_Pet._Hp) <= 0)
																				{
																					Data.PetUpdateData(num76, num77, DataStructure.Type_Pet._Hp, 1);
																				}
																				num77++;
																			}
																			while (num77 <= 4);
																		}
																		int my_TalkingBattle = Server.Clients[key7]._My_TalkingBattle;
																		if (my_TalkingBattle > 0)
																		{
																			Server.Clients[key7]._My_TalkingBattle = 0;
																			int my_MapId = Server.Clients[key7]._My_MapId;
																			if (Data.NpcOnMap.ContainsKey(Data.GetKey_NpcOnMap(my_MapId, my_TalkingBattle)))
																			{
																				DataStructure._NpcOnMap value6 = Data.NpcOnMap[Data.GetKey_NpcOnMap(my_MapId, my_TalkingBattle)];
																				if (value6._Delay == 0)
																				{
																					string text11 = "F44406001603" + Class5.smethod_11(my_TalkingBattle) + "0A00";
																					int coord = value6._Coord;
																					int x_First = value6._X_First;
																					int y_First = value6._Y_First;
																					int num78 = x_First - coord;
																					int maxValue = x_First + coord;
																					if (num78 < 0)
																					{
																						num78 = x_First;
																					}
																					int num79 = y_First - coord;
																					int maxValue2 = y_First + coord;
																					if (num79 < 0)
																					{
																						num79 = y_First;
																					}
																					int int_ = this.random_2.Next(num78, maxValue);
																					int int_2 = this.random_2.Next(num79, maxValue2);
																					text11 = string.Concat(new string[]
																					{
																						text11,
																						"F44408001605",
																						Class5.smethod_11(my_TalkingBattle),
																						Class5.smethod_11(int_),
																						Class5.smethod_11(int_2)
																					});
																					Server.SendToAllMapid(my_MapId, text11);
																					value6._Delay = 10;
																					Data.NpcOnMap[Data.GetKey_NpcOnMap(my_MapId, my_TalkingBattle)] = value6;
																				}
																			}
																		}
																	}
																}
																else
																{
																	text8 = this.Skilling(num19, num20, num21 + 1, num22, num23, DataStructure.Type_StatusAttackMiss._Miss, DataStructure.Type_StatusAttack_Def_Lantranh._Lantranh, 1, DataStructure.Type_StatusTroiBuffHpSp._Miss, 0, 1);
																	this.SendSKillingToParty("F44413003201" + text8);
																	text8 = "";
																	text7 = "";
																	Thread.Sleep(num17);
																}
																break;
															case 14:
															{
																num17 = dataSkill4;
																num29 = DataStructure.Type_StatusAttackMiss._Attack;
																attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																int num80 = (int)Math.Round(unchecked((double)@int * 0.5));
																int num81 = (int)Math.Round(unchecked((double)@int * 0.5));
																if (num21 == 11004)
																{
																	num80 = (int)Math.Round((double)@int / 1.7) + 3 * num24;
																	num81 = (int)Math.Round((double)@int / 3.7) + num24;
																}
																else
																{
																	if (num21 == 11026)
																	{
																		num80 = (int)Math.Round((double)@int / 2.7) + 3 * num24;
																		num81 = (int)Math.Round((double)@int / 7.0) + 2 * num24;
																	}
																	else
																	{
																		if (num21 == 11030)
																		{
																			num80 = (int)Math.Round((double)@int / 1.7) + 3 * num24;
																			num81 = (int)Math.Round((double)@int / 4.7) + 3 * num24;
																		}
																	}
																}
																if (hp4 + num80 <= hpMax2)
																{
																	warInfo5._Hp = hp4 + num80;
																	if (idChar3 == 0)
																	{
																		Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Hp, hp4 + num80);
																	}
																	else
																	{
																		if (Server.Clients.ContainsKey(idChar3))
																		{
																			Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Hp, hp4 + num80);
																		}
																	}
																}
																else
																{
																	if (hp4 + num80 > hpMax2)
																	{
																		num80 = hpMax2 - hp4;
																		warInfo5._Hp = hpMax2;
																		if (idChar3 == 0)
																		{
																			Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Hp, hpMax2);
																		}
																		else
																		{
																			if (Server.Clients.ContainsKey(idChar3))
																			{
																				Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Hp, hpMax2);
																			}
																		}
																	}
																	else
																	{
																		if (hp4 == hpMax2)
																		{
																			num80 = 0;
																		}
																	}
																}
																if (id3 == id7)
																{
																	num81 = 0;
																}
																if (sp2 + num81 <= spMax)
																{
																	warInfo5._Sp = sp2 + num81;
																	if (idChar3 == 0)
																	{
																		Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Sp, sp2 + num81);
																	}
																	else
																	{
																		if (Server.Clients.ContainsKey(idChar3))
																		{
																			Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Sp, sp2 + num81);
																		}
																	}
																}
																else
																{
																	if (sp2 + num81 > spMax)
																	{
																		num81 = spMax - sp2;
																		warInfo5._Sp = spMax;
																		if (idChar3 == 0)
																		{
																			Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Sp, spMax);
																		}
																		else
																		{
																			if (Server.Clients.ContainsKey(idChar3))
																			{
																				Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Sp, spMax);
																			}
																		}
																	}
																	else
																	{
																		if (sp2 == spMax)
																		{
																			num81 = 0;
																		}
																	}
																}
																text8 = string.Concat(new string[]
																{
																	text8,
																	this.SkillingInt(num22, num23, num29, attack_Def_Lantranh, 2, DataStructure.Type_StatusTroiBuffHpSp._Hp, num80, 0),
																	DataStructure.Type_StatusTroiBuffHpSp._Sp.ToString("X2"),
																	Class5.smethod_11(num81),
																	"00"
																});
																break;
															}
															case 15:
															{
																num17 = dataSkill4;
																int turn3 = this.GetTurn(num21, num24);
																int troiBuffHpSp3 = DataStructure.Type_StatusTroiBuffHpSp._Type19;
																if (type15_Id4 > 0)
																{
																	num29 = DataStructure.Type_StatusAttackMiss._Miss;
																}
																else
																{
																	num29 = this.GetRandomMissTroi(lv2, warInfo5._Lv, (int)Math.Round(num2), (int)Math.Round(num5), @int, int2, reborn, reborn2);
																	if (num29 == DataStructure.Type_StatusAttackMiss._Miss)
																	{
																		troiBuffHpSp3 = 0;
																		attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																		if (warInfo5._IdSkill == 17001)
																		{
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																		}
																		if (type4_Id2 == 13003)
																		{
																			num30 = 0;
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Lantranh;
																		}
																		if (type4_Id2 == 10010)
																		{
																			num30 = 0;
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																		}
																	}
																	else
																	{
																		if (num29 == DataStructure.Type_StatusAttackMiss._Attack)
																		{
																			troiBuffHpSp3 = DataStructure.Type_StatusTroiBuffHpSp._Type15;
																			attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																			if (warInfo5._IdSkill == 17001)
																			{
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																			}
																			if (type4_Id2 == 13003)
																			{
																				num30 = 0;
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Lantranh;
																			}
																			if (type4_Id2 == 10010)
																			{
																				num30 = 0;
																				attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																			}
																			if (type4_Id2 == 10026)
																			{
																				num29 = DataStructure.Type_StatusAttackMiss._Attack;
																				troiBuffHpSp3 = DataStructure.Type_StatusTroiBuffHpSp._Miss;
																				if (type15_Id3 == 0)
																				{
																					ArrayList arrayList10 = new ArrayList(new int[]
																					{
																						10016,
																						10017,
																						10018,
																						10019,
																						10025,
																						20022
																					});
																					if (arrayList10.Contains(num21))
																					{
																						warInfo5._Agi -= 200;
																					}
																					warInfo._Type15_Id = num21;
																					warInfo._Type15_Lv = num24;
																					warInfo._Type15_Turn = turn3;
																					text = this.TroiStart(num19, num20, 1, num21);
																				}
																			}
																			else
																			{
																				ArrayList arrayList11 = new ArrayList(new int[]
																				{
																					10016,
																					10017,
																					10018,
																					10019,
																					10025,
																					20022
																				});
																				if (arrayList11.Contains(num21))
																				{
																					warInfo5._Agi -= 200;
																				}
																				warInfo5._Type15_Id = num21;
																				warInfo5._Type15_Lv = num24;
																				warInfo5._Type15_Turn = turn3;
																			}
																		}
																	}
																}
																text8 += this.SkillingInt(num22, num23, num29, attack_Def_Lantranh, 1, troiBuffHpSp3, num30, 1);
																break;
															}
															case 16:
																num17 = dataSkill4;
																switch (num21)
																{
																case 10009:
																	if (type4_Id2 == 10010)
																	{
																		warInfo5._Type4_Id = 0;
																		warInfo5._Type4_Lv = 0;
																		warInfo5._Type4_Turn = 0;
																		num29 = DataStructure.Type_StatusAttackMiss._Attack;
																	}
																	else
																	{
																		num29 = DataStructure.Type_StatusAttackMiss._Miss;
																	}
																	break;
																case 10014:
																	if (type4_Id2 == 10015)
																	{
																		warInfo5._Type4_Id = 0;
																		warInfo5._Type4_Lv = 0;
																		warInfo5._Type4_Turn = 0;
																		num29 = DataStructure.Type_StatusAttackMiss._Attack;
																	}
																	else
																	{
																		num29 = DataStructure.Type_StatusAttackMiss._Miss;
																	}
																	break;
																}
																text8 += this.SkillingInt(num22, num23, num29, 0, 1, DataStructure.Type_StatusTroiBuffHpSp._Type4, 0, 1);
																break;
															case 18:
																num17 = dataSkill4;
																switch (num21)
																{
																case 11016:
																case 11017:
																case 11018:
																case 11019:
																	if (team2 == team5)
																	{
																		int num82 = (int)Math.Round(unchecked((double)@int * 0.5));
																		int num83 = (int)Math.Round(unchecked((double)@int * 0.5));
																		if (num21 == 11016)
																		{
																			num82 = 400;
																			num83 = 100;
																		}
																		else
																		{
																			if (num21 == 11017)
																			{
																				num82 = 500;
																				num83 = 150;
																			}
																			else
																			{
																				if (num21 == 11018)
																				{
																					num82 = 600;
																					num83 = 200;
																				}
																				else
																				{
																					if (num21 == 11019)
																					{
																						num82 = 700;
																						num83 = 250;
																					}
																				}
																			}
																		}
																		if (hp4 + num82 <= hpMax2)
																		{
																			warInfo5._Hp = hp4 + num82;
																			if (idChar3 == 0)
																			{
																				Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Hp, hp4 + num82);
																			}
																			else
																			{
																				if (Server.Clients.ContainsKey(idChar3))
																				{
																					Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Hp, hp4 + num82);
																				}
																			}
																		}
																		else
																		{
																			if (hp4 + num82 > hpMax2)
																			{
																				num82 = hpMax2 - hp4;
																				warInfo5._Hp = hpMax2;
																				if (idChar3 == 0)
																				{
																					Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Hp, hpMax2);
																				}
																				else
																				{
																					if (Server.Clients.ContainsKey(idChar3))
																					{
																						Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Hp, hpMax2);
																					}
																				}
																			}
																			else
																			{
																				if (hp4 == hpMax2)
																				{
																					num82 = 0;
																				}
																			}
																		}
																		if (id3 == id7)
																		{
																			num83 = 0;
																		}
																		if (sp2 + num83 <= spMax)
																		{
																			warInfo5._Sp = sp2 + num83;
																			if (idChar3 == 0)
																			{
																				Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Sp, sp2 + num83);
																			}
																			else
																			{
																				if (Server.Clients.ContainsKey(idChar3))
																				{
																					Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Sp, sp2 + num83);
																				}
																			}
																		}
																		else
																		{
																			if (sp2 + num83 > spMax)
																			{
																				num83 = spMax - sp2;
																				warInfo5._Sp = spMax;
																				if (idChar3 == 0)
																				{
																					Data.PlayerUpdateDataId(id7, DataStructure.Type_Player._Sp, spMax);
																				}
																				else
																				{
																					if (Server.Clients.ContainsKey(idChar3))
																					{
																						Data.PetUpdateData(idChar3, idNpcOnMap3, DataStructure.Type_Pet._Sp, spMax);
																					}
																				}
																			}
																			else
																			{
																				if (sp2 == spMax)
																				{
																					num83 = 0;
																				}
																			}
																		}
																		warInfo5._Type3_Id = 0;
																		warInfo5._Type3_Lv = 0;
																		warInfo5._Type3_Turn = 0;
																		warInfo5._Type15_Id = 0;
																		warInfo5._Type15_Lv = 0;
																		warInfo5._Type15_Turn = 0;
																		num29 = DataStructure.Type_StatusAttackMiss._Attack;
																		text8 = string.Concat(new string[]
																		{
																			text8,
																			this.SkillingInt(num22, num23, num29, 0, 4, DataStructure.Type_StatusTroiBuffHpSp._Type3, 0, 1),
																			"DF000001",
																			DataStructure.Type_StatusTroiBuffHpSp._Hp.ToString("X2"),
																			Class5.smethod_11(num82),
																			"00",
																			DataStructure.Type_StatusTroiBuffHpSp._Sp.ToString("X2"),
																			Class5.smethod_11(num83),
																			"00"
																		});
																	}
																	else
																	{
																		warInfo5._Type4_Id = 0;
																		warInfo5._Type4_Lv = 0;
																		warInfo5._Type4_Turn = 0;
																		warInfo5._Type19_Id = 0;
																		warInfo5._Type19_Lv = 0;
																		warInfo5._Type19_Turn = 0;
																		num29 = DataStructure.Type_StatusAttackMiss._Attack;
																		text8 = text8 + this.SkillingInt(num22, num23, num29, 0, 2, DataStructure.Type_StatusTroiBuffHpSp._Type4, 0, 1) + "E1000001";
																	}
																	break;
																}
																break;
															case 19:
															{
																num17 = dataSkill4;
																int turn4 = this.GetTurn(num21, num24);
																if (type19_Id3 == 0)
																{
																	num29 = DataStructure.Type_StatusAttackMiss._Attack;
																	attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Attack;
																}
																else
																{
																	num29 = DataStructure.Type_StatusAttackMiss._Miss;
																	attack_Def_Lantranh = DataStructure.Type_StatusAttack_Def_Lantranh._Def;
																}
																int troiBuffHpSp4 = DataStructure.Type_StatusTroiBuffHpSp._Type19;
																if (num29 == DataStructure.Type_StatusAttackMiss._Miss)
																{
																	troiBuffHpSp4 = 0;
																}
																else
																{
																	troiBuffHpSp4 = DataStructure.Type_StatusTroiBuffHpSp._Type19;
																	warInfo5._Type19_Id = num21;
																	warInfo5._Type19_Lv = num24;
																	warInfo5._Type19_Turn = turn4;
																}
																text8 += this.SkillingInt(num22, num23, num29, attack_Def_Lantranh, 1, troiBuffHpSp4, 0, 1);
																break;
															}
															}
															if (Operators.CompareString(text10, text9, false) == 0)
															{
																warInfo = warInfo5;
																this.ListWar[text10] = warInfo5;
															}
															else
															{
																this.ListWar[text10] = warInfo5;
															}
														}
													}
													finally
													{

													}
													if (text8.Length > 0)
													{
														if (num43 > 0)
														{
															text8 = string.Concat(new string[]
															{
																num19.ToString("X2"),
																num20.ToString("X2"),
																Class5.smethod_11(num21),
																num28.ToString("X2"),
																(arrayList8.Count + 1).ToString("X2"),
																text8,
																this.SkillingInt(num19, num20, 1, 0, 1, DataStructure.Type_StatusTroiBuffHpSp._Hp, num43, 0)
															});
															num43 = 0;
														}
														else
														{
															text8 = string.Concat(new string[]
															{
																num19.ToString("X2"),
																num20.ToString("X2"),
																Class5.smethod_11(num21),
																num28.ToString("X2"),
																arrayList8.Count.ToString("X2"),
																text8
															});
														}
														text7 = text7 + Class5.smethod_11((int)Math.Round((double)text8.Length / 2.0)) + text8;
														text8 = "";
													}
													if (text7.Length > 0 & num14 == 0)
													{
														num15 = 0;
														num16 = 0;
														string text12 = "3201" + text7;
														this.SendSKillingToParty(text2 + "F444" + Class5.smethod_11((int)Math.Round((double)text12.Length / 2.0)) + text12);
														text7 = "";
														Thread.Sleep(num17);
														try
														{
															IEnumerator enumerator6 = arrayList2.GetEnumerator();
															while (enumerator6.MoveNext())
															{
																string text13 = Conversions.ToString(enumerator6.Current);
																int num84 = Conversions.ToInteger(text13.Substring(0, text13.LastIndexOf(".")));
																int num85 = Conversions.ToInteger(text13.Substring(text13.LastIndexOf(".") + 1, text13.LastIndexOf("/") - text13.LastIndexOf(".") - 1));
																int num86 = Conversions.ToInteger(text13.Substring(text13.LastIndexOf("/") + 1));
																int num87 = 0;
																if (this.ListWar[Class5.smethod_3(new byte[]
																{
																	(byte)num84,
																	(byte)num85
																})]._Hp <= 0)
																{
																	num87 = this.GetRandomMissDrop(this.ListWar[Class5.smethod_3(new byte[]
																	{
																		(byte)num84,
																		(byte)num85
																	})]._Id);
																}
																if (arrayList.Count == 0)
																{
																	if (num87 > 0)
																	{
																		if (idChar2 > 0 & Server.Clients.ContainsKey(idChar2))
																		{
																			Data.HomdoAddItem(idChar2, num87, 1);
																			this.SendSKillingToParty(string.Concat(new string[]
																			{
																				"F44408003504",
																				Class5.smethod_11(num87),
																				num84.ToString("X2"),
																				num85.ToString("X2"),
																				num19.ToString("X2"),
																				num20.ToString("X2")
																			}));
																		}
																		else
																		{
																			if (idChar2 == 0 & Server.Clients.ContainsKey(id3))
																			{
																				Data.HomdoAddItem(id3, num87, 1);
																				this.SendSKillingToParty(string.Concat(new string[]
																				{
																					"F44408003504",
																					Class5.smethod_11(num87),
																					num84.ToString("X2"),
																					num85.ToString("X2"),
																					num19.ToString("X2"),
																					num20.ToString("X2")
																				}));
																			}
																		}
																	}
																	string text14 = Class5.smethod_3(new byte[]
																	{
																		(byte)warInfo._Row,
																		(byte)warInfo._Column
																	});
																	DataStructure.WarInfo warInfo6 = this.ListWar[text14];
																	int lv5 = warInfo6._Lv;
																	if (lv5 - num86 <= 20)
																	{
																		int num88 = 0;
																		int num89 = lv5 - num86;
																		if (num89 < 0)
																		{
																			num88 = (int)Math.Round(unchecked((double)checked(num86 - lv5) + (double)num86 / 5.0));
																		}
																		else
																		{
																			if (num89 == 0)
																			{
																				num88 = (int)Math.Round(unchecked(5.0 + (double)num86 / 5.0));
																			}
																			else
																			{
																				if (num89 == 1)
																				{
																					num88 = (int)Math.Round(unchecked(5.0 + (double)num86 / 5.0));
																				}
																				else
																				{
																					if (num89 == 2)
																					{
																						num88 = (int)Math.Round(unchecked(5.0 + (double)num86 / 5.0));
																					}
																					else
																					{
																						if (num89 == 3)
																						{
																							num88 = (int)Math.Round(unchecked(4.0 + (double)num86 / 5.0));
																						}
																						else
																						{
																							if (num89 == 4)
																							{
																								num88 = (int)Math.Round(unchecked(4.0 + (double)num86 / 5.0));
																							}
																							else
																							{
																								if (num89 == 5)
																								{
																									num88 = (int)Math.Round(unchecked(4.0 + (double)num86 / 5.0));
																								}
																								else
																								{
																									if (num89 == 6)
																									{
																										num88 = (int)Math.Round(unchecked(3.0 + (double)num86 / 5.0));
																									}
																									else
																									{
																										if (num89 == 7)
																										{
																											num88 = (int)Math.Round(unchecked(3.0 + (double)num86 / 5.0));
																										}
																										else
																										{
																											if (num89 == 8)
																											{
																												num88 = (int)Math.Round(unchecked(3.0 + (double)num86 / 5.0));
																											}
																											else
																											{
																												if (num89 == 9)
																												{
																													num88 = (int)Math.Round(unchecked(3.0 + (double)num86 / 5.0));
																												}
																												else
																												{
																													if (num89 == 10)
																													{
																														num88 = (int)Math.Round(unchecked(3.0 + (double)num86 / 5.0));
																													}
																													else
																													{
																														if (num89 == 11)
																														{
																															num88 = (int)Math.Round(unchecked(2.0 + (double)num86 / 5.0));
																														}
																														else
																														{
																															if (num89 == 12)
																															{
																																num88 = (int)Math.Round(unchecked(2.0 + (double)num86 / 5.0));
																															}
																															else
																															{
																																if (num89 == 13)
																																{
																																	num88 = (int)Math.Round(unchecked(2.0 + (double)num86 / 5.0));
																																}
																																else
																																{
																																	if (num89 == 14)
																																	{
																																		num88 = (int)Math.Round(unchecked(2.0 + (double)num86 / 5.0));
																																	}
																																	else
																																	{
																																		if (num89 == 15)
																																		{
																																			num88 = (int)Math.Round(unchecked(2.0 + (double)num86 / 5.0));
																																		}
																																		else
																																		{
																																			if (num89 == 16)
																																			{
																																				num88 = (int)Math.Round(unchecked(1.0 + (double)num86 / 5.0));
																																			}
																																			else
																																			{
																																				if (num89 == 17)
																																				{
																																					num88 = (int)Math.Round(unchecked(1.0 + (double)num86 / 5.0));
																																				}
																																				else
																																				{
																																					if (num89 == 18)
																																					{
																																						num88 = (int)Math.Round(unchecked(1.0 + (double)num86 / 5.0));
																																					}
																																					else
																																					{
																																						if (num89 == 19)
																																						{
																																							num88 = (int)Math.Round(unchecked(1.0 + (double)num86 / 5.0));
																																						}
																																						else
																																						{
																																							if (num89 == 20)
																																							{
																																								num88 = (int)Math.Round(unchecked(1.0 + (double)num86 / 5.0));
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																		int hp7 = this.ListWar[Class5.smethod_3(new byte[]
																		{
																			(byte)num84,
																			(byte)num85
																		})]._Hp;
																		if (hp7 <= 0)
																		{
																			warInfo6._Exp += num88;
																		}
																		else
																		{
																			warInfo6._Exp += (int)Math.Round((double)num88 / 10.0);
																		}
																	}
																	this.ListWar[text14] = warInfo6;
																	if (Operators.CompareString(text14, text9, false) == 0)
																	{
																		warInfo = warInfo6;
																		this.ListWar[text14] = warInfo6;
																	}
																	else
																	{
																		this.ListWar[text14] = warInfo6;
																	}
																}
																try
																{
																	IEnumerator enumerator7 = arrayList.GetEnumerator();
																	while (enumerator7.MoveNext())
																	{
																		string text15 = Conversions.ToString(enumerator7.Current);
																		int num90 = Conversions.ToInteger(text15.Substring(0, text15.LastIndexOf(".")));
																		int num91 = Conversions.ToInteger(text15.Substring(text15.LastIndexOf(".") + 1, text15.LastIndexOf("/") - text15.LastIndexOf(".") - 1));
																		int num92 = Conversions.ToInteger(text15.Substring(text15.LastIndexOf("/") + 1));
																		string text16 = Class5.smethod_3(new byte[]
																		{
																			(byte)num90,
																			(byte)num91
																		});
																		DataStructure.WarInfo warInfo7 = this.ListWar[text16];
																		if (Operators.CompareString(text16, text9, false) == 0)
																		{
																			warInfo7 = warInfo;
																		}
																		int id8 = warInfo7._Id;
																		int idChar6 = warInfo7._IdChar;
																		if (num92 - num86 <= 20)
																		{
																			int num93 = 0;
																			int num94 = num92 - num86;
																			if (num94 < 0)
																			{
																				num93 = (int)Math.Round(unchecked((double)checked(num86 - num92) + (double)num86 / 5.0));
																			}
																			else
																			{
																				if (num94 == 0)
																				{
																					num93 = (int)Math.Round(unchecked(5.0 + (double)num86 / 5.0));
																				}
																				else
																				{
																					if (num94 == 1)
																					{
																						num93 = (int)Math.Round(unchecked(5.0 + (double)num86 / 5.0));
																					}
																					else
																					{
																						if (num94 == 2)
																						{
																							num93 = (int)Math.Round(unchecked(5.0 + (double)num86 / 5.0));
																						}
																						else
																						{
																							if (num94 == 3)
																							{
																								num93 = (int)Math.Round(unchecked(4.0 + (double)num86 / 5.0));
																							}
																							else
																							{
																								if (num94 == 4)
																								{
																									num93 = (int)Math.Round(unchecked(4.0 + (double)num86 / 5.0));
																								}
																								else
																								{
																									if (num94 == 5)
																									{
																										num93 = (int)Math.Round(unchecked(4.0 + (double)num86 / 5.0));
																									}
																									else
																									{
																										if (num94 == 6)
																										{
																											num93 = (int)Math.Round(unchecked(3.0 + (double)num86 / 5.0));
																										}
																										else
																										{
																											if (num94 == 7)
																											{
																												num93 = (int)Math.Round(unchecked(3.0 + (double)num86 / 5.0));
																											}
																											else
																											{
																												if (num94 == 8)
																												{
																													num93 = (int)Math.Round(unchecked(3.0 + (double)num86 / 5.0));
																												}
																												else
																												{
																													if (num94 == 9)
																													{
																														num93 = (int)Math.Round(unchecked(3.0 + (double)num86 / 5.0));
																													}
																													else
																													{
																														if (num94 == 10)
																														{
																															num93 = (int)Math.Round(unchecked(3.0 + (double)num86 / 5.0));
																														}
																														else
																														{
																															if (num94 == 11)
																															{
																																num93 = (int)Math.Round(unchecked(2.0 + (double)num86 / 5.0));
																															}
																															else
																															{
																																if (num94 == 12)
																																{
																																	num93 = (int)Math.Round(unchecked(2.0 + (double)num86 / 5.0));
																																}
																																else
																																{
																																	if (num94 == 13)
																																	{
																																		num93 = (int)Math.Round(unchecked(2.0 + (double)num86 / 5.0));
																																	}
																																	else
																																	{
																																		if (num94 == 14)
																																		{
																																			num93 = (int)Math.Round(unchecked(2.0 + (double)num86 / 5.0));
																																		}
																																		else
																																		{
																																			if (num94 == 15)
																																			{
																																				num93 = (int)Math.Round(unchecked(2.0 + (double)num86 / 5.0));
																																			}
																																			else
																																			{
																																				if (num94 == 16)
																																				{
																																					num93 = (int)Math.Round(unchecked(1.0 + (double)num86 / 5.0));
																																				}
																																				else
																																				{
																																					if (num94 == 17)
																																					{
																																						num93 = (int)Math.Round(unchecked(1.0 + (double)num86 / 5.0));
																																					}
																																					else
																																					{
																																						if (num94 == 18)
																																						{
																																							num93 = (int)Math.Round(unchecked(1.0 + (double)num86 / 5.0));
																																						}
																																						else
																																						{
																																							if (num94 == 19)
																																							{
																																								num93 = (int)Math.Round(unchecked(1.0 + (double)num86 / 5.0));
																																							}
																																							else
																																							{
																																								if (num94 == 20)
																																								{
																																									num93 = (int)Math.Round(unchecked(1.0 + (double)num86 / 5.0));
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																			num93 = (int)Math.Round(unchecked((double)num93 * 1.086));
																			int hp8 = this.ListWar[Class5.smethod_3(new byte[]
																			{
																				(byte)num84,
																				(byte)num85
																			})]._Hp;
																			if (hp8 <= 0)
																			{
																				warInfo7._Exp += num93;
																			}
																			else
																			{
																				warInfo7._Exp += (int)Math.Round((double)num93 / 10.0);
																			}
																		}
																		this.ListWar[text16] = warInfo7;
																		if (Operators.CompareString(text16, text9, false) == 0)
																		{
																			warInfo = warInfo7;
																			this.ListWar[text16] = warInfo7;
																		}
																		else
																		{
																			this.ListWar[text16] = warInfo7;
																		}
																		if (num87 > 0)
																		{
																			if (idChar6 > 0 & Server.Clients.ContainsKey(idChar6))
																			{
																				Data.HomdoAddItem(idChar6, num87, 1);
																				this.SendSKillingToParty(string.Concat(new string[]
																				{
																					"F44408003504",
																					Class5.smethod_11(num87),
																					num84.ToString("X2"),
																					num85.ToString("X2"),
																					num90.ToString("X2"),
																					num91.ToString("X2")
																				}));
																			}
																			else
																			{
																				if (idChar6 == 0 & Server.Clients.ContainsKey(id8))
																				{
																					Data.HomdoAddItem(id8, num87, 1);
																					this.SendSKillingToParty(string.Concat(new string[]
																					{
																						"F44408003504",
																						Class5.smethod_11(num87),
																						num84.ToString("X2"),
																						num85.ToString("X2"),
																						num90.ToString("X2"),
																						num91.ToString("X2")
																					}));
																				}
																			}
																		}
																	}
																}
																finally
																{

																}
															}
														}
														finally
														{

														}
														arrayList2.Clear();
														arrayList.Clear();
														num17 = 0;
														if (text.Length > 0)
														{
															this.SendSKillingToParty(text);
															text = "";
														}
														if (text2.Length > 0)
														{
															text2 = "";
															this.SendSKillingToParty(string.Concat(new string[]
															{
																"F444130032010F00",
																num22.ToString("X2"),
																num23.ToString("X2"),
																Class5.smethod_11(20007),
																"0101",
																num22.ToString("X2"),
																num23.ToString("X2"),
																"01030119000000"
															}));
														}
													}
												}
											}
										}
										if (hp2 <= 0 & num21 == 20006)
										{
											warInfo._IdSkill = 0;
										}
									}
									warInfo._Attacked = 2;
									this.ListWar[text9] = warInfo;
									if (this.ListWar[Class5.smethod_3(new byte[]
									{
										0,
										2
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										0,
										1
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										0,
										3
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										0,
										0
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										0,
										4
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										1,
										2
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										1,
										1
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										1,
										3
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										1,
										0
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										1,
										4
									})]._Id == 0)
									{
										goto IL_7467;
									}
									if (this.ListWar[Class5.smethod_3(new byte[]
									{
										3,
										2
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										3,
										1
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										3,
										3
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										3,
										0
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										3,
										4
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										2,
										2
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										2,
										1
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										2,
										3
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										2,
										0
									})]._Id == 0 & this.ListWar[Class5.smethod_3(new byte[]
									{
										2,
										4
									})]._Id == 0)
									{
										goto IL_746B;
									}
									num18++;
								}
								while (num18 <= 19);
								try
								{
									IEnumerator enumerator8 = this._keys.GetEnumerator();
									while (enumerator8.MoveNext())
									{
										string key8 = Conversions.ToString(enumerator8.Current);
										DataStructure.WarInfo value7 = this.ListWar[key8];
										int id9 = value7._Id;
										int leaderId2 = value7._LeaderId;
										int row3 = value7._Row;
										int column2 = value7._Column;
										if ((id9 > 0 & Server.Clients.ContainsKey(id9)) && id9 == leaderId2)
										{
											int my_IdQS = Server.Clients[id9]._My_IdQS;
											if (my_IdQS > 0 & Server.Clients.ContainsKey(my_IdQS))
											{
												int num95 = Server.Clients[my_IdQS]._My_Int + Server.Clients[my_IdQS]._My_Int2;
												int num96 = (int)Math.Round((double)num95 / 15.0);
												if (value7._Sp + num96 <= value7._SpMax)
												{
													value7._Sp += num96;
													Data.PlayerUpdateDataId(id9, DataStructure.Type_Player._Sp, value7._Sp + num96);
												}
												else
												{
													if (value7._Sp + num96 > value7._SpMax)
													{
														value7._Sp = value7._SpMax;
														Data.PlayerUpdateDataId(id9, DataStructure.Type_Player._Sp, value7._SpMax);
													}
												}
												string key9 = Class5.smethod_3(new byte[]
												{
													(byte)(row3 ^ 1),
													(byte)column2
												});
												DataStructure.WarInfo value8 = this.ListWar[key9];
												if (value8._Id > 0)
												{
													int my_SttPetXuatChien = Server.Clients[id9]._My_SttPetXuatChien;
													if (value8._Sp + num96 <= value8._SpMax)
													{
														value8._Sp += num96;
														Data.PetUpdateData(id9, my_SttPetXuatChien, DataStructure.Type_Pet._Sp, value8._Sp + num96);
													}
													else
													{
														if (value8._Sp + num96 > value8._SpMax)
														{
															value8._Sp = value8._SpMax;
															Data.PetUpdateData(id9, my_SttPetXuatChien, DataStructure.Type_Pet._Sp, value8._SpMax);
														}
													}
												}
												this.ListWar[key9] = value8;
												Client client = Server.Clients[id9];
												int num97 = 0;
												do
												{
													if (num97 != column2)
													{
														string key10 = Class5.smethod_3(new byte[]
														{
															(byte)row3,
															(byte)num97
														});
														DataStructure.WarInfo value9 = this.ListWar[key10];
														int id10 = value9._Id;
														if ((id10 > 0 & Server.Clients.ContainsKey(id10)) && (id10 == client._My_IdMem1 | id10 == client._My_IdMem2 | id10 == client._My_IdMem3 | id10 == client._My_IdMem4))
														{
															if (value9._Sp + num96 <= value9._SpMax)
															{
																value9._Sp += num96;
																Data.PlayerUpdateDataId(id10, DataStructure.Type_Player._Sp, value9._Sp + num96);
															}
															else
															{
																value9._Sp = value9._SpMax;
																Data.PlayerUpdateDataId(id10, DataStructure.Type_Player._Sp, value9._SpMax);
															}
															string key11 = Class5.smethod_3(new byte[]
															{
																(byte)(row3 ^ 1),
																(byte)num97
															});
															DataStructure.WarInfo value10 = this.ListWar[key11];
															if (value10._Id > 0)
															{
																int my_SttPetXuatChien2 = Server.Clients[id10]._My_SttPetXuatChien;
																if (value10._Sp + num96 <= value10._SpMax)
																{
																	value10._Sp += num96;
																	Data.PetUpdateData(id10, my_SttPetXuatChien2, DataStructure.Type_Pet._Sp, value10._Sp + num96);
																}
																else
																{
																	value10._Sp = value10._SpMax;
																	Data.PetUpdateData(id10, my_SttPetXuatChien2, DataStructure.Type_Pet._Sp, value10._SpMax);
																}
															}
															this.ListWar[key11] = value10;
														}
														this.ListWar[key10] = value9;
													}
													num97++;
												}
												while (num97 <= 4);
											}
										}
										this.ListWar[Class5.smethod_3(new byte[]
										{
											(byte)row3,
											(byte)column2
										})] = value7;
									}
								}
                                finally { }

								continue;
								IL_7467:
								num = 1;
								goto IL_746D;
								IL_746B:
								num = 2;
							}
						}
						else
						{
							num = 1;
						}
					}
					else
					{
						num = 2;
					}
					IL_746D:
					text7 = "";
					int num98 = 0;
					do
					{
						DataStructure.WarInfo warInfo8 = this.ListWar[Class5.smethod_3(new byte[]
						{
							3,
							(byte)num98
						})];
						int id11 = warInfo8._Id;
						int hp9 = warInfo8._Hp;
						if (id11 > 0 & Server.Clients.ContainsKey(id11))
						{
							Client client2 = Server.Clients[id11];
							int type6 = warInfo8._Type;
							if (type6 == 2)
							{
								int my_Lv = client2._My_Lv;
								int num99 = Server.PerEXP * warInfo8._Exp;
								if (my_Lv < 200 & hp9 > 0 & num99 > 0)
								{
									int my_Reborn = client2._My_Reborn;
									if (my_Reborn == 2)
									{
										num99 = (int)Math.Round((double)num99 / 2.0);
									}
									int my_Job = client2._My_Job;
									int my_Point = client2._My_Point;
									int my_SkillPoint = client2._My_SkillPoint;
									int my_Hpx = client2._My_Hpx;
									int my_Spx = client2._My_Spx;
									int my_Hpx2 = client2._My_Hpx2;
									int my_Spx2 = client2._My_Spx2;
									int my_Texp = client2._My_Texp;
									Data.PlayerUpdateDataId(id11, DataStructure.Type_Player._TExp, my_Texp + num99);
									int num100 = Data.TexpGetLvUp(my_Lv, my_Reborn, my_Texp + num99);
									if (num100 > 0)
									{
										int value11 = Data.CongthucHP(my_Reborn, my_Job, my_Lv + num100, my_Hpx) + my_Hpx2;
										int value12 = Data.CongthucSP(my_Reborn, my_Job, my_Lv + num100, my_Spx) + my_Spx2;
										Data.PlayerUpdateDataId(id11, DataStructure.Type_Player._Hp, value11);
										Data.PlayerUpdateDataId(id11, DataStructure.Type_Player._Hpmax, value11);
										Data.PlayerUpdateDataId(id11, DataStructure.Type_Player._Sp, value12);
										Data.PlayerUpdateDataId(id11, DataStructure.Type_Player._Spmax, value12);
										Data.PlayerUpdateDataId(id11, DataStructure.Type_Player._Lv, my_Lv + num100);
										Data.PlayerUpdateDataId(id11, DataStructure.Type_Player._Point, my_Point + 2 * num100);
										Data.PlayerUpdateDataId(id11, DataStructure.Type_Player._SkillPoint, my_SkillPoint + num100);
									}
								}
								int num101 = id11;
								if (Server.Clients.ContainsKey(num101))
								{
									int my_SttPetXuatChien3 = Server.Clients[num101]._My_SttPetXuatChien;
									int num102 = Data.PetGetData(Server.Clients[num101].conn, my_SttPetXuatChien3, DataStructure.Type_Pet._Lv);
									int num103 = Data.PetGetData(Server.Clients[num101].conn, my_SttPetXuatChien3, DataStructure.Type_Pet._Hp);
									if (num102 < 200 & num103 > 0)
									{
										DataStructure.WarInfo warInfo9 = this.ListWar[Class5.smethod_3(new byte[]
										{
											2,
											(byte)num98
										})];
										if (warInfo9._Id > 0)
										{
											int num104 = Server.PerEXP * warInfo9._Exp;
											if (num104 > 0)
											{
												int num105 = Data.PetGetData(Server.Clients[num101].conn, my_SttPetXuatChien3, DataStructure.Type_Pet._Reborn);
												int num106 = Data.PetGetData(Server.Clients[num101].conn, my_SttPetXuatChien3, DataStructure.Type_Pet._Texp);
												if (num105 == 1)
												{
													num105 = 0;
												}
												if (num105 == 2)
												{
													num105 = 1;
												}
												if (num105 == 1)
												{
													num104 = (int)Math.Round((double)num104 / 2.0);
												}
												Data.PetUpdateData(num101, my_SttPetXuatChien3, DataStructure.Type_Pet._Texp, num106 + num104);
												int num107 = Data.TexpGetLvUp(num102, num105, num106 + num104);
												if (num107 > 0)
												{
													int arg_785D_0 = 1;
													int num108 = num107;
													for (int i = arg_785D_0; i <= num108; i++)
													{
														Data.PetUp(num101, my_SttPetXuatChien3);
													}
												}
											}
										}
									}
								}
								int leaderId3 = warInfo8._LeaderId;
								int row4 = warInfo8._Row;
								int column3 = warInfo8._Column;
								int num109 = id11;
								if (id11 > 0)
								{
									text7 = string.Concat(new string[]
									{
										text7,
										"F44408000B00",
										Class5.smethod_12(id11),
										"0000F44405000B01",
										row4.ToString("X2"),
										column3.ToString("X2"),
										"00"
									});
								}
								Server.SendToAllClientMapid(id11, "F44408000B00" + Class5.smethod_12(id11) + "0000");
								this.SendSKillingToParty(text7);
								this.SendSKillingToParty("F44402000504");
								this.SendSKillingToParty("F44402001408");
								if (leaderId3 == 0 | leaderId3 == num109)
								{
									int num110 = num109;
									if (Server.Clients.ContainsKey(num110))
									{
										int my_TalkingBattle2 = Server.Clients[num110]._My_TalkingBattle;
										if (my_TalkingBattle2 > 0)
										{
											Server.Clients[num110]._My_TalkingBattle = 0;
											int my_MapId2 = Server.Clients[num110]._My_MapId;
											if (Data.NpcOnMap.ContainsKey(Data.GetKey_NpcOnMap(my_MapId2, my_TalkingBattle2)))
											{
												DataStructure._NpcOnMap value13 = Data.NpcOnMap[Data.GetKey_NpcOnMap(my_MapId2, my_TalkingBattle2)];
												if (value13._Delay == 0)
												{
													string text17 = "F44406001603" + Class5.smethod_11(my_TalkingBattle2) + "0A00";
													int coord2 = value13._Coord;
													int x_First2 = value13._X_First;
													int y_First2 = value13._Y_First;
													int num111 = x_First2 - coord2;
													int maxValue3 = x_First2 + coord2;
													if (num111 < 0)
													{
														num111 = x_First2;
													}
													int num112 = y_First2 - coord2;
													int maxValue4 = y_First2 + coord2;
													if (num112 < 0)
													{
														num112 = y_First2;
													}
													int int_3 = this.random_2.Next(num111, maxValue3);
													int int_4 = this.random_2.Next(num112, maxValue4);
													text17 = string.Concat(new string[]
													{
														text17,
														"F44408001605",
														Class5.smethod_11(my_TalkingBattle2),
														Class5.smethod_11(int_3),
														Class5.smethod_11(int_4)
													});
													Server.SendToAllMapid(my_MapId2, text17);
													value13._Delay = 10;
													Data.NpcOnMap[Data.GetKey_NpcOnMap(my_MapId2, my_TalkingBattle2)] = value13;
												}
											}
										}
										int my_WarpingId = Server.Clients[num110]._My_WarpingId;
										if (my_WarpingId > 0 & num110 > 0 & hp9 > 0 & num == 1)
										{
											int warpId = my_WarpingId;
											int my_MapId3 = Server.Clients[num110]._My_MapId;
											int dataWarp = Data.GetDataWarp(my_MapId3, warpId, DataStructure.Type_Warp._MapId2);
											int dataWarp2 = Data.GetDataWarp(my_MapId3, warpId, DataStructure.Type_Warp._X);
											int dataWarp3 = Data.GetDataWarp(my_MapId3, warpId, DataStructure.Type_Warp._Y);
											int gocnhin = 1;
											Data.Warped(num110, my_MapId3, dataWarp, dataWarp2, dataWarp3, 1);
											client2 = Server.Clients[num110];
											if (client2._My_IdMem1 > 0)
											{
												Data.Warped(client2._My_IdMem1, my_MapId3, dataWarp, dataWarp2, dataWarp3, gocnhin);
											}
											if (client2._My_IdMem2 > 0)
											{
												Data.Warped(client2._My_IdMem2, my_MapId3, dataWarp, dataWarp2, dataWarp3, gocnhin);
											}
											if (client2._My_IdMem3 > 0)
											{
												Data.Warped(client2._My_IdMem3, my_MapId3, dataWarp, dataWarp2, dataWarp3, gocnhin);
											}
											if (client2._My_IdMem4 > 0)
											{
												Data.Warped(client2._My_IdMem4, my_MapId3, dataWarp, dataWarp2, dataWarp3, gocnhin);
											}
											Server.Clients[num110]._My_WarpingId = 0;
											Server.SendToAllClientMapid(id11, "F44408000B00" + Class5.smethod_12(id11) + "0000");
										}
									}
								}
								if (Server.Clients.ContainsKey(num109))
								{
									if (Server.Clients[num109]._My_Hp <= 0)
									{
										Data.PlayerUpdateDataId(num109, DataStructure.Type_Player._Hp, 1);
									}
									int num113 = 1;
									do
									{
										if (Server.Clients.ContainsKey(num109) && Data.PetGetData(Server.Clients[num109].conn, num113, DataStructure.Type_Pet._ID) > 0 && Data.PetGetData(Server.Clients[num109].conn, num113, DataStructure.Type_Pet._Hp) <= 0)
										{
											Data.PetUpdateData(num109, num113, DataStructure.Type_Pet._Hp, 1);
										}
										num113++;
									}
									while (num113 <= 4);
								}
								if (Server.Clients.ContainsKey(id11))
								{
									Server.Clients[id11]._My_IdBattle = 0;
								}
							}
							if (Server.Clients.ContainsKey(id11))
							{
								Server.Clients[id11]._My_WarpingId = 0;
							}
						}
						num98++;
					}
					while (num98 <= 4);
					int num114 = 0;
					do
					{
						DataStructure.WarInfo warInfo10 = this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							(byte)num114
						})];
						int id12 = warInfo10._Id;
						if (id12 > 0 & Server.Clients.ContainsKey(id12))
						{
							int type7 = warInfo10._Type;
							if (type7 == 2)
							{
								int row5 = warInfo10._Row;
								int column4 = warInfo10._Column;
								int num115 = id12;
								if (Server.Clients[num115]._My_Hp <= 0)
								{
									Data.PlayerUpdateDataId(num115, DataStructure.Type_Player._Hp, 1);
								}
								int num116 = 1;
								do
								{
									if (Data.PetGetData(Server.Clients[num115].conn, num116, DataStructure.Type_Pet._ID) > 0 && Data.PetGetData(Server.Clients[num115].conn, num116, DataStructure.Type_Pet._Hp) <= 0)
									{
										Data.PetUpdateData(num115, num116, DataStructure.Type_Pet._Hp, 1);
									}
									num116++;
								}
								while (num116 <= 4);
								if (id12 > 0)
								{
									text7 = string.Concat(new string[]
									{
										text7,
										"F44408000B00",
										Class5.smethod_12(id12),
										"0000F44405000B01",
										row5.ToString("X2"),
										column4.ToString("X2"),
										"00"
									});
								}
								Server.SendToAllClientMapid(id12, "F44408000B00" + Class5.smethod_12(id12) + "0000");
								this.SendSKillingToParty(text7);
								this.SendSKillingToParty("F44402000504");
								this.SendSKillingToParty("F44402001408");
								Server.Clients[id12]._My_IdBattle = 0;
							}
						}
						num114++;
					}
					while (num114 <= 4);
					try
					{
						Dictionary<int, int>.ValueCollection.Enumerator enumerator9 = this.ListQS.Values.GetEnumerator();
						while (enumerator9.MoveNext())
						{
							int current2 = enumerator9.Current;
							if (current2 > 0 && Server.Clients.ContainsKey(current2))
							{
								Server.Clients[current2]._My_IdBattle = 0;
								Server.Clients[current2].Sendpacket("F44408000B00" + Class5.smethod_12(current2) + "0000");
							}
						}
					}
					finally
					{
						
					}
					return;
				}
				num = 1;
				//goto IL_746D;
			}
		}
		public void SendSKillingToParty(string packetattack)
		{
			int num = 0;
			checked
			{
				do
				{
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						(byte)num
					})]._Id > 0)
					{
						int id = this.ListWar[Class5.smethod_3(new byte[]
						{
							3,
							(byte)num
						})]._Id;
						int type = this.ListWar[Class5.smethod_3(new byte[]
						{
							3,
							(byte)num
						})]._Type;
						if (type == 2)
						{
							Server.SendToClient(id, packetattack);
						}
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						0,
						(byte)num
					})]._Id > 0)
					{
						int id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							(byte)num
						})]._Id;
						int type2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							(byte)num
						})]._Type;
						if (type2 == 2)
						{
							Server.SendToClient(id2, packetattack);
						}
					}
					num++;
				}
				while (num <= 4);
				try
				{
					Dictionary<int, int>.ValueCollection.Enumerator enumerator = this.ListQS.Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						if (current > 0 && Server.Clients.ContainsKey(current))
						{
							Server.Clients[current].Sendpacket(packetattack);
						}
					}
				}
				finally
				{
					
				}
			}
		}
		public void SendBattleLeader(int DiaHinh, int _row, int _Column)
		{
			checked
			{
				if (this.ListWar[Class5.smethod_3(new byte[]
				{
					(byte)_row,
					(byte)_Column
				})]._Id > 0)
				{
					int id = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Id;
					int id2 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Id;
					string packet = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Packet;
					string packet2 = string.Concat(new string[]
					{
						"F4441C000BFA",
						Class5.smethod_11(DiaHinh),
						"03",
						packet,
						"F44403000B0A01"
					});
					Server.SendToClient(id, packet2);
					Server.SendToAllClientMapid(id2, "F4440A000B0402" + Class5.smethod_12(id2) + "000003");
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						packet2 = "F4441A000B0505" + packet;
						Server.SendToClient(id, packet2);
					}
					_Column = 1;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Id > 0)
					{
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						packet2 = string.Concat(new string[]
						{
							"F4441A000B0505",
							packet,
							"F4440A000B0402",
							Class5.smethod_12(id2),
							"000005"
						});
						Server.SendToClient(id, packet2);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						packet2 = "F4441A000B0505" + packet;
						Server.SendToClient(id, packet2);
					}
					_Column = 3;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Id > 0)
					{
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						packet2 = string.Concat(new string[]
						{
							"F4441A000B0505",
							packet,
							"F4440A000B0402",
							Class5.smethod_12(id2),
							"000005"
						});
						Server.SendToClient(id, packet2);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						packet2 = "F4441A000B0505" + packet;
						Server.SendToClient(id, packet2);
					}
					_Column = 0;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Id > 0)
					{
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						packet2 = string.Concat(new string[]
						{
							"F4441A000B0505",
							packet,
							"F4440A000B0402",
							Class5.smethod_12(id2),
							"000005"
						});
						Server.SendToClient(id, packet2);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						packet2 = "F4441A000B0505" + packet;
						Server.SendToClient(id, packet2);
					}
					_Column = 4;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Id > 0)
					{
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						packet2 = string.Concat(new string[]
						{
							"F4441A000B0505",
							packet,
							"F4440A000B0402",
							Class5.smethod_12(id2),
							"000005"
						});
						Server.SendToClient(id, packet2);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						packet2 = "F4441A000B0505" + packet;
						Server.SendToClient(id, packet2);
					}
					_row ^= 3;
					_Column = 2;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						2
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						packet2 = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							packet2 = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							packet2 = "F4441A000B0503" + packet;
							break;
						case 4:
							packet2 = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, packet2);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						packet2 = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							packet2 = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							packet2 = "F4441A000B0503" + packet;
							break;
						case 4:
							packet2 = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, packet2);
					}
					_Column = 1;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						packet2 = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							packet2 = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							packet2 = "F4441A000B0503" + packet;
							break;
						case 4:
							packet2 = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, packet2);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						packet2 = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							packet2 = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							packet2 = "F4441A000B0503" + packet;
							break;
						case 4:
							packet2 = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, packet2);
					}
					_Column = 3;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						packet2 = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							packet2 = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							packet2 = "F4441A000B0503" + packet;
							break;
						case 4:
							packet2 = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, packet2);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						packet2 = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							packet2 = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							packet2 = "F4441A000B0503" + packet;
							break;
						case 4:
							packet2 = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, packet2);
					}
					_Column = 0;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						packet2 = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							packet2 = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							packet2 = "F4441A000B0503" + packet;
							break;
						case 4:
							packet2 = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, packet2);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						packet2 = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							packet2 = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							packet2 = "F4441A000B0503" + packet;
							break;
						case 4:
							packet2 = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, packet2);
					}
					_Column = 4;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						packet2 = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							packet2 = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							packet2 = "F4441A000B0503" + packet;
							break;
						case 4:
							packet2 = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, packet2);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						packet2 = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							packet2 = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							packet2 = "F4441A000B0503" + packet;
							break;
						case 4:
							packet2 = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, packet2);
					}
				}
			}
		}
		public void SendBattleMemPkPlayer(int DiaHinh, int _row, int _Column)
		{
			checked
			{
				if (this.ListWar[Class5.smethod_3(new byte[]
				{
					(byte)_row,
					(byte)_Column
				})]._Id > 0)
				{
					int id = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Id;
					int id2 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Id;
					int my_SttPetXuatChien = Server.Clients[id2]._My_SttPetXuatChien;
					string packet = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Packet;
					string packet2 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Packet;
					string text = "";
					int id3 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						2
					})]._Id;
					int id4 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Id;
					int id5 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Id;
					int id6 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Id;
					int id7 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Id;
					int id8 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						2
					})]._Id;
					int id9 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						1
					})]._Id;
					int id10 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						3
					})]._Id;
					int id11 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						0
					})]._Id;
					int id12 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						4
					})]._Id;
					string packet3 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						2
					})]._Packet;
					string packet4 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Packet;
					string packet5 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Packet;
					string packet6 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Packet;
					string packet7 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Packet;
					string packet8 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						2
					})]._Packet;
					string packet9 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						1
					})]._Packet;
					string packet10 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						3
					})]._Packet;
					string packet11 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						0
					})]._Packet;
					string packet12 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						4
					})]._Packet;
					text = string.Concat(new string[]
					{
						text,
						"05",
						packet,
						"02",
						packet3
					});
					if (id8 > 0)
					{
						text = text + "02" + packet8;
					}
					Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id3) + "000002");
					if (id4 != id2 & id4 > 0)
					{
						text = text + "64" + packet4;
						if (id9 > 0)
						{
							text = text + "64" + packet9;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id4) + "000005");
					}
					if (id5 != id2 & id5 > 0)
					{
						text = text + "64" + packet5;
						if (id10 > 0)
						{
							text = text + "64" + packet10;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id5) + "000005");
					}
					if (id6 != id2 & id6 > 0)
					{
						text = text + "64" + packet6;
						if (id11 > 0)
						{
							text = text + "64" + packet11;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id6) + "000005");
					}
					if (id7 != id2 & id7 > 0)
					{
						text = text + "64" + packet7;
						if (id12 > 0)
						{
							text = text + "64" + packet12;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id7) + "000005");
					}
					Server.SendToClient(id, string.Concat(new string[]
					{
						"F444",
						Class5.smethod_11(4 + (int)Math.Round((double)text.Length / 2.0)),
						"0BFA",
						Class5.smethod_11(DiaHinh),
						text,
						"F44403000B0A01"
					}));
					Server.SendToAllClientMapid(id2, "F4440A000B0402" + Class5.smethod_12(id2) + "000003");
					if (my_SttPetXuatChien > 0 & my_SttPetXuatChien <= 4)
					{
						Server.SendToClient(id, "F4441A000B0505" + packet2);
					}
					_row ^= 3;
					_Column = 2;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						2
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					_Column = 1;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					_Column = 3;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					_Column = 0;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					_Column = 4;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
				}
			}
		}
		public void SendBattleLeaderPlayerPK(int DiaHinh, int _row, int _Column)
		{
			checked
			{
				if (this.ListWar[Class5.smethod_3(new byte[]
				{
					(byte)_row,
					(byte)_Column
				})]._Id > 0)
				{
					int id = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Id;
					int id2 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Id;
					string packet = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Packet;
					string value = Conversions.ToString(this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id);
					string packet2 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Packet;
					string text = "";
					int id3 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						2
					})]._Id;
					int id4 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Id;
					int id5 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Id;
					int id6 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Id;
					int id7 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Id;
					DataStructure.WarInfo warInfo = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						2
					})];
					int id8 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						1
					})]._Id;
					int id9 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						3
					})]._Id;
					int id10 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						0
					})]._Id;
					int id11 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						4
					})]._Id;
					warInfo = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						2
					})];
					string packet3 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Packet;
					string packet4 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Packet;
					string packet5 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Packet;
					string packet6 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Packet;
					warInfo = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						2
					})];
					string packet7 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						1
					})]._Packet;
					string packet8 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						3
					})]._Packet;
					string packet9 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						0
					})]._Packet;
					string packet10 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						4
					})]._Packet;
					int id12 = this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						(byte)_Column
					})]._Id;
					int id13 = this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						(byte)_Column
					})]._Id;
					string packet11 = this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						(byte)_Column
					})]._Packet;
					string packet12 = this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						(byte)_Column
					})]._Packet;
					text = text + "05" + packet;
					if (id12 > 0)
					{
						text = text + "02" + packet11;
						if (id13 > 0)
						{
							text = text + "02" + packet12;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id12) + "000002");
					}
					Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id3) + "000005");
					if (id4 > 0)
					{
						text = text + "64" + packet3;
						if (id8 > 0)
						{
							text = text + "64" + packet7;
						}
					}
					if (id5 > 0)
					{
						text = text + "64" + packet4;
						if (id9 > 0)
						{
							text = text + "64" + packet8;
						}
					}
					if (id6 > 0)
					{
						text = text + "64" + packet5;
						if (id10 > 0)
						{
							text = text + "64" + packet9;
						}
					}
					if (id7 > 0)
					{
						text = text + "64" + packet6;
						if (id11 > 0)
						{
							text = text + "64" + packet10;
						}
					}
					Server.SendToClient(id, string.Concat(new string[]
					{
						"F444",
						Class5.smethod_11(4 + (int)Math.Round((double)text.Length / 2.0)),
						"0BFA",
						Class5.smethod_11(DiaHinh),
						text,
						"F44403000B0A01"
					}));
					Server.SendToAllClientMapid(id2, "F4440A000B0402" + Class5.smethod_12(id2) + "000003");
					if (Conversions.ToDouble(value) > 0.0)
					{
						Server.SendToClient(id, "F4441A000B0505" + packet2);
					}
					_row ^= 3;
					_Column = 1;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Id > 0)
					{
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					_Column = 3;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Id > 0)
					{
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					_Column = 0;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Id > 0)
					{
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					_Column = 4;
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Id > 0)
					{
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)_row,
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id > 0)
					{
						packet = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Packet;
						text = "";
						id2 = this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Id;
						switch (this.ListWar[Class5.smethod_3(new byte[]
						{
							(byte)(_row ^ 1),
							(byte)_Column
						})]._Type)
						{
						case 2:
							text = string.Concat(new string[]
							{
								"F4441A000B0505",
								packet,
								"F4440A000B0402",
								Class5.smethod_12(id2),
								"000005"
							});
							break;
						case 3:
							text = "F4441A000B0503" + packet;
							break;
						case 4:
							text = "F4441A000B0505" + packet;
							break;
						}
						Server.SendToClient(id, text);
					}
				}
			}
		}
		public void SendBattleMemberPlayerPK(int _IdBattle, int _row, int _Column)
		{
			checked
			{
				if (this.ListWar[Class5.smethod_3(new byte[]
				{
					(byte)_row,
					(byte)_Column
				})]._Id > 0)
				{
					int id = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Id;
					int id2 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Id;
					string packet = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Packet;
					string value = Conversions.ToString(this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id);
					string packet2 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Packet;
					string text = "";
					int id3 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						2
					})]._Id;
					int id4 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Id;
					int id5 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Id;
					int id6 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Id;
					int id7 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Id;
					int id8 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						2
					})]._Id;
					int id9 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						1
					})]._Id;
					int id10 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						3
					})]._Id;
					int id11 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						0
					})]._Id;
					int id12 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						4
					})]._Id;
					string packet3 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						2
					})]._Packet;
					string packet4 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Packet;
					string packet5 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Packet;
					string packet6 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Packet;
					string packet7 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Packet;
					string packet8 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						2
					})]._Packet;
					string packet9 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						1
					})]._Packet;
					string packet10 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						3
					})]._Packet;
					string packet11 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						0
					})]._Packet;
					string packet12 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						4
					})]._Packet;
					int id13 = this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						2
					})]._Id;
					int id14 = this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						2
					})]._Id;
					string packet13 = this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						2
					})]._Packet;
					string packet14 = this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						2
					})]._Packet;
					text = text + "05" + packet;
					if (id13 > 0)
					{
						text = text + "02" + packet13;
						if (id14 > 0)
						{
							text = text + "02" + packet14;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id13) + "000002");
					}
					if (id3 > 0)
					{
						text = text + "64" + packet3;
						if (id8 > 0)
						{
							text = text + "64" + packet8;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id3) + "000005");
					}
					if (id4 != id2 & id4 > 0)
					{
						text = text + "64" + packet4;
						if (id9 > 0)
						{
							text = text + "64" + packet9;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id4) + "000005");
					}
					if (id5 != id2 & id5 > 0)
					{
						text = text + "64" + packet5;
						if (id10 > 0)
						{
							text = text + "64" + packet10;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id5) + "000005");
					}
					if (id6 != id2 & id6 > 0)
					{
						text = text + "64" + packet6;
						if (id11 > 0)
						{
							text = text + "64" + packet11;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id6) + "000005");
					}
					if (id7 != id2 & id7 > 0)
					{
						text = text + "64" + packet7;
						if (id12 > 0)
						{
							text = text + "64" + packet12;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id7) + "000005");
					}
					_row = 3;
					id4 = this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						1
					})]._Id;
					id5 = this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						3
					})]._Id;
					id6 = this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						0
					})]._Id;
					id7 = this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						4
					})]._Id;
					id9 = this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						1
					})]._Id;
					id10 = this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						3
					})]._Id;
					id11 = this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						0
					})]._Id;
					id12 = this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						4
					})]._Id;
					packet4 = this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						1
					})]._Packet;
					packet5 = this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						3
					})]._Packet;
					packet6 = this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						0
					})]._Packet;
					packet7 = this.ListWar[Class5.smethod_3(new byte[]
					{
						3,
						4
					})]._Packet;
					packet9 = this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						1
					})]._Packet;
					packet10 = this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						3
					})]._Packet;
					packet11 = this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						0
					})]._Packet;
					packet12 = this.ListWar[Class5.smethod_3(new byte[]
					{
						2,
						4
					})]._Packet;
					if (id4 != id2 & id4 > 0)
					{
						text = text + "64" + packet4;
						if (id9 > 0)
						{
							text = text + "64" + packet9;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id4) + "000005");
					}
					if (id5 != id2 & id5 > 0)
					{
						text = text + "64" + packet5;
						if (id10 > 0)
						{
							text = text + "64" + packet10;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id5) + "000005");
					}
					if (id6 != id2 & id6 > 0)
					{
						text = text + "64" + packet6;
						if (id11 > 0)
						{
							text = text + "64" + packet11;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id6) + "000005");
					}
					if (id7 != id2 & id7 > 0)
					{
						text = text + "64" + packet7;
						if (id12 > 0)
						{
							text = text + "64" + packet12;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id7) + "000005");
					}
					Server.SendToClient(id, string.Concat(new string[]
					{
						"F444",
						Class5.smethod_11(4 + (int)Math.Round((double)text.Length / 2.0)),
						"0BFA7000",
						text,
						"F44403000B0A01"
					}));
					Server.SendToAllClientMapid(id2, "F4440A000B0402" + Class5.smethod_12(id2) + "000003");
					if (Conversions.ToDouble(value) > 0.0)
					{
						Server.SendToClient(id, "F4441A000B0505" + packet2);
					}
				}
			}
		}
		public void SendBattleMem(int _IdBattle, int DiaHinh, int _row, int _Column)
		{
			checked
			{
				if (this.ListWar[Class5.smethod_3(new byte[]
				{
					(byte)_row,
					(byte)_Column
				})]._Id > 0)
				{
					int id = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Id;
					int id2 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Id;
					string packet = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						(byte)_Column
					})]._Packet;
					string packet2 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						(byte)_Column
					})]._Packet;
					string text = "";
					int id3 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						2
					})]._Id;
					int id4 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Id;
					int id5 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Id;
					int id6 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Id;
					int id7 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Id;
					int id8 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						2
					})]._Id;
					int id9 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						1
					})]._Id;
					int id10 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						3
					})]._Id;
					int id11 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						0
					})]._Id;
					int id12 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						4
					})]._Id;
					string packet3 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						2
					})]._Packet;
					string packet4 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						1
					})]._Packet;
					string packet5 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						3
					})]._Packet;
					string packet6 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						0
					})]._Packet;
					string packet7 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)_row,
						4
					})]._Packet;
					string packet8 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						2
					})]._Packet;
					string packet9 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						1
					})]._Packet;
					string packet10 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						3
					})]._Packet;
					string packet11 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						0
					})]._Packet;
					string packet12 = this.ListWar[Class5.smethod_3(new byte[]
					{
						(byte)(_row ^ 1),
						4
					})]._Packet;
					text = string.Concat(new string[]
					{
						text,
						"05",
						packet,
						"03",
						packet3
					});
					if (id8 > 0)
					{
						text = text + "03" + packet8;
					}
					Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id3) + "000003");
					if (id4 != id & id4 > 0)
					{
						text = text + "64" + packet4;
						if (id9 > 0)
						{
							text = text + "64" + packet9;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id4) + "000005");
					}
					if (id5 != id & id5 > 0)
					{
						text = text + "64" + packet5;
						if (id10 > 0)
						{
							text = text + "64" + packet10;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id5) + "000005");
					}
					if (id6 != id & id6 > 0)
					{
						text = text + "64" + packet6;
						if (id11 > 0)
						{
							text = text + "64" + packet11;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id6) + "000005");
					}
					if (id7 != id & id7 > 0)
					{
						text = text + "64" + packet7;
						if (id12 > 0)
						{
							text = text + "64" + packet12;
						}
						Server.SendToClient(id, "F4440A000B0402" + Class5.smethod_12(id7) + "000005");
					}
					Server.SendToClient(id, string.Concat(new string[]
					{
						"F444",
						Class5.smethod_11(4 + (int)Math.Round((double)text.Length / 2.0)),
						"0BFA",
						Class5.smethod_11(DiaHinh),
						text,
						"F44403000B0A01"
					}));
					Server.SendToAllClientMapid(id, "F4440A000B0402" + Class5.smethod_12(id) + "000003");
					if (id2 > 0)
					{
						Server.SendToClient(id, "F4441A000B0505" + packet2);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						0,
						2
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							2
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						0,
						1
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							1
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						0,
						3
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							3
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						0,
						0
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							0
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						0,
						4
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							0,
							4
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						1,
						2
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							2
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						1,
						1
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							1
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						1,
						3
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							3
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						1,
						0
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							0
						})]._Packet);
					}
					if (this.ListWar[Class5.smethod_3(new byte[]
					{
						1,
						4
					})]._Id > 0)
					{
						Server.SendToClient(id, "F4441A000B0503" + this.ListWar[Class5.smethod_3(new byte[]
						{
							1,
							4
						})]._Packet);
					}
				}
			}
		}
		public double GetDamageThuoctinh(int MyTT, int TTAttack)
		{
			double result;
			switch (MyTT)
			{
			case 1:
				switch (TTAttack)
				{
				case 1:
					result = 1.0;
					break;
				case 2:
					result = 1.55;
					break;
				case 3:
					result = 1.3;
					break;
				case 4:
					result = 0.65;
					break;
				default:
					result = 1.0;
					break;
				}
				break;
			case 2:
				switch (TTAttack)
				{
				case 1:
					result = 0.6;
					break;
				case 2:
					result = 1.0;
					break;
				case 3:
					result = 1.7;
					break;
				case 4:
					result = 1.0;
					break;
				default:
					result = 1.0;
					break;
				}
				break;
			case 3:
				switch (TTAttack)
				{
				case 1:
					result = 1.6;
					break;
				case 2:
					result = 0.7;
					break;
				case 3:
					result = 1.0;
					break;
				case 4:
					result = 1.9;
					break;
				default:
					result = 1.0;
					break;
				}
				break;
			case 4:
				switch (TTAttack)
				{
				case 1:
					result = 1.7;
					break;
				case 2:
					result = 1.3;
					break;
				case 3:
					result = 0.8;
					break;
				case 4:
					result = 1.3;
					break;
				default:
					result = 1.0;
					break;
				}
				break;
			default:
				result = 1.0;
				break;
			}
			return result;
		}
		public int GetDamageSkillInt(int TTSkill, int TTAttack)
		{
			int result;
			switch (TTSkill)
			{
			case 1:
				switch (TTAttack)
				{
				case 1:
					result = 18;
					break;
				case 2:
					result = 27;
					break;
				case 3:
					result = 21;
					break;
				case 4:
					result = 13;
					break;
				default:
					result = 18;
					break;
				}
				break;
			case 2:
				switch (TTAttack)
				{
				case 1:
					result = 10;
					break;
				case 2:
					result = 19;
					break;
				case 3:
					result = 29;
					break;
				case 4:
					result = 19;
					break;
				default:
					result = 19;
					break;
				}
				break;
			case 3:
				switch (TTAttack)
				{
				case 1:
					result = 26;
					break;
				case 2:
					result = 15;
					break;
				case 3:
					result = 27;
					break;
				case 4:
					result = 34;
					break;
				default:
					result = 27;
					break;
				}
				break;
			case 4:
				switch (TTAttack)
				{
				case 1:
					result = 54;
					break;
				case 2:
					result = 42;
					break;
				case 3:
					result = 29;
					break;
				case 4:
					result = 42;
					break;
				default:
					result = 42;
					break;
				}
				break;
			default:
				result = 10;
				break;
			}
			return result;
		}
		public Point GetPosRandom_honLoan(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			Point result = default(Point);
			result.X = 99;
			result.Y = 99;
			DataStructure.WarInfo warInfo = this.ListWar[Class5.smethod_3(checked(new byte[]
			{
				(byte)rowAttack,
				(byte)columnAttack
			}))];
			int id = warInfo._Id;
			int hp = warInfo._Hp;
			int team = warInfo._Team;
			if (id > 0 & hp > 0 & team == myteam)
			{
				result.X = rowAttack;
				result.Y = columnAttack;
			}
			else
			{
				try
				{
					Dictionary<string, DataStructure.WarInfo>.ValueCollection.Enumerator enumerator = this.ListWar.Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataStructure.WarInfo current = enumerator.Current;
						int id2 = current._Id;
						int hp2 = current._Hp;
						int row = current._Row;
						int column = current._Column;
						int team2 = current._Team;
						if (id2 > 0 & hp2 > 0 & team2 == myteam)
						{
							result.X = row;
							result.Y = column;
							break;
						}
					}
				}
				finally
				{
					
				}
			}
			return result;
		}
		public ArrayList GetPosAttack_honLoan(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			ArrayList arrayList = new ArrayList();
			Point posRandom_honLoan = this.GetPosRandom_honLoan(_IdBattle, myteam, rowAttack, columnAttack);
			checked
			{
				if (posRandom_honLoan.X >= 0 & posRandom_honLoan.X < 4)
				{
					switch (SLDanh)
					{
					case 1:
						arrayList.Add(posRandom_honLoan);
						break;
					case 2:
						arrayList.Add(posRandom_honLoan);
						switch (posRandom_honLoan.X)
						{
						case 0:
							posRandom_honLoan.X = 1;
							break;
						case 1:
							posRandom_honLoan.X = 0;
							break;
						case 2:
							posRandom_honLoan.X = 3;
							break;
						case 3:
							posRandom_honLoan.X = 2;
							break;
						}
						if (this.ListWar[posRandom_honLoan.X.ToString("X2") + posRandom_honLoan.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_honLoan.X.ToString("X2") + posRandom_honLoan.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom_honLoan);
						}
						break;
					case 3:
					{
						arrayList.Add(posRandom_honLoan);
						Point point = posRandom_honLoan;
						point.Y = posRandom_honLoan.Y - 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						point.Y = posRandom_honLoan.Y + 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						break;
					}
					case 4:
					{
						arrayList.Add(posRandom_honLoan);
						Point point2 = posRandom_honLoan;
						point2.Y = posRandom_honLoan.Y - 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandom_honLoan.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandom_honLoan.Y;
							arrayList.Add(point2);
						}
						point2.Y = posRandom_honLoan.Y + 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandom_honLoan.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandom_honLoan.Y;
							arrayList.Add(point2);
						}
						break;
					}
					case 5:
					{
						arrayList.Add(posRandom_honLoan);
						Point point3 = posRandom_honLoan;
						point3.Y = posRandom_honLoan.Y - 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						point3.Y = posRandom_honLoan.Y + 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						switch (posRandom_honLoan.X)
						{
						case 0:
							posRandom_honLoan.X = 1;
							break;
						case 1:
							posRandom_honLoan.X = 0;
							break;
						case 2:
							posRandom_honLoan.X = 3;
							break;
						case 3:
							posRandom_honLoan.X = 2;
							break;
						}
						if (this.ListWar[posRandom_honLoan.X.ToString("X2") + posRandom_honLoan.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_honLoan.X.ToString("X2") + posRandom_honLoan.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom_honLoan);
						}
						break;
					}
					case 6:
					{
						arrayList.Add(posRandom_honLoan);
						Point point4 = posRandom_honLoan;
						point4.Y = posRandom_honLoan.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandom_honLoan.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						switch (posRandom_honLoan.X)
						{
						case 0:
							posRandom_honLoan.X = 1;
							break;
						case 1:
							posRandom_honLoan.X = 0;
							break;
						case 2:
							posRandom_honLoan.X = 3;
							break;
						case 3:
							posRandom_honLoan.X = 2;
							break;
						}
						if (this.ListWar[posRandom_honLoan.X.ToString("X2") + posRandom_honLoan.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_honLoan.X.ToString("X2") + posRandom_honLoan.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom_honLoan);
						}
						point4 = posRandom_honLoan;
						point4.Y = posRandom_honLoan.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandom_honLoan.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						break;
					}
					case 7:
					{
						int num = 0;
						do
						{
							posRandom_honLoan.Y = num;
							if (this.ListWar[posRandom_honLoan.X.ToString("X2") + posRandom_honLoan.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_honLoan.X.ToString("X2") + posRandom_honLoan.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom_honLoan);
							}
							num++;
						}
						while (num <= 4);
						break;
					}
					case 8:
					{
						int num2 = 0;
						do
						{
							posRandom_honLoan.Y = num2;
							if (this.ListWar[posRandom_honLoan.X.ToString("X2") + posRandom_honLoan.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_honLoan.X.ToString("X2") + posRandom_honLoan.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom_honLoan);
							}
							num2++;
						}
						while (num2 <= 4);
						switch (posRandom_honLoan.X)
						{
						case 0:
							posRandom_honLoan.X = 1;
							break;
						case 1:
							posRandom_honLoan.X = 0;
							break;
						case 2:
							posRandom_honLoan.X = 3;
							break;
						case 3:
							posRandom_honLoan.X = 2;
							break;
						}
						int num3 = 0;
						do
						{
							posRandom_honLoan.Y = num3;
							if (this.ListWar[posRandom_honLoan.X.ToString("X2") + posRandom_honLoan.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_honLoan.X.ToString("X2") + posRandom_honLoan.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom_honLoan);
							}
							num3++;
						}
						while (num3 <= 4);
						break;
					}
					}
				}
				return arrayList;
			}
		}
		public Point GetPosRandom(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			Point result = default(Point);
			result.X = 99;
			result.Y = 99;
			DataStructure.WarInfo warInfo = this.ListWar[Class5.smethod_3(checked(new byte[]
			{
				(byte)rowAttack,
				(byte)columnAttack
			}))];
			int id = warInfo._Id;
			int hp = warInfo._Hp;
			int type4_Id = warInfo._Type4_Id;
			int team = warInfo._Team;
			if (id > 0 & hp > 0 & team != myteam & type4_Id != 13005 & type4_Id != 13025)
			{
				result.X = rowAttack;
				result.Y = columnAttack;
			}
			else
			{
				try
				{
					Dictionary<string, DataStructure.WarInfo>.ValueCollection.Enumerator enumerator = this.ListWar.Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataStructure.WarInfo current = enumerator.Current;
						int id2 = current._Id;
						int hp2 = current._Hp;
						int type4_Id2 = current._Type4_Id;
						int row = current._Row;
						int column = current._Column;
						int team2 = current._Team;
						if (id2 > 0 & hp2 > 0 & team2 != myteam & type4_Id2 != 13005 & type4_Id2 != 13025)
						{
							result.X = row;
							result.Y = column;
							break;
						}
					}
				}
				finally
				{
					
				}
			}
			return result;
		}
		public ArrayList GetPosAttack(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			ArrayList arrayList = new ArrayList();
			Point posRandom = this.GetPosRandom(_IdBattle, myteam, rowAttack, columnAttack);
			checked
			{
				if (posRandom.X >= 0 & posRandom.X < 4)
				{
					switch (SLDanh)
					{
					case 1:
						arrayList.Add(posRandom);
						break;
					case 2:
						arrayList.Add(posRandom);
						switch (posRandom.X)
						{
						case 0:
							posRandom.X = 1;
							break;
						case 1:
							posRandom.X = 0;
							break;
						case 2:
							posRandom.X = 3;
							break;
						case 3:
							posRandom.X = 2;
							break;
						}
						if (this.ListWar[posRandom.X.ToString("X2") + posRandom.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom.X.ToString("X2") + posRandom.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom);
						}
						break;
					case 3:
					{
						arrayList.Add(posRandom);
						Point point = posRandom;
						point.Y = posRandom.Y - 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						point.Y = posRandom.Y + 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						break;
					}
					case 4:
					{
						arrayList.Add(posRandom);
						Point point2 = posRandom;
						point2.Y = posRandom.Y - 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandom.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandom.Y;
							arrayList.Add(point2);
						}
						point2.Y = posRandom.Y + 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandom.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandom.Y;
							arrayList.Add(point2);
						}
						break;
					}
					case 5:
					{
						arrayList.Add(posRandom);
						Point point3 = posRandom;
						point3.Y = posRandom.Y - 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						point3.Y = posRandom.Y + 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						switch (posRandom.X)
						{
						case 0:
							posRandom.X = 1;
							break;
						case 1:
							posRandom.X = 0;
							break;
						case 2:
							posRandom.X = 3;
							break;
						case 3:
							posRandom.X = 2;
							break;
						}
						if (this.ListWar[posRandom.X.ToString("X2") + posRandom.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom.X.ToString("X2") + posRandom.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom);
						}
						break;
					}
					case 6:
					{
						arrayList.Add(posRandom);
						Point point4 = posRandom;
						point4.Y = posRandom.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandom.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						switch (posRandom.X)
						{
						case 0:
							posRandom.X = 1;
							break;
						case 1:
							posRandom.X = 0;
							break;
						case 2:
							posRandom.X = 3;
							break;
						case 3:
							posRandom.X = 2;
							break;
						}
						if (this.ListWar[posRandom.X.ToString("X2") + posRandom.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom.X.ToString("X2") + posRandom.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom);
						}
						point4 = posRandom;
						point4.Y = posRandom.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandom.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						break;
					}
					case 7:
					{
						int num = 0;
						do
						{
							posRandom.Y = num;
							if (this.ListWar[posRandom.X.ToString("X2") + posRandom.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom.X.ToString("X2") + posRandom.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom);
							}
							num++;
						}
						while (num <= 4);
						break;
					}
					case 8:
					{
						int num2 = 0;
						do
						{
							posRandom.Y = num2;
							if (this.ListWar[posRandom.X.ToString("X2") + posRandom.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom.X.ToString("X2") + posRandom.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom);
							}
							num2++;
						}
						while (num2 <= 4);
						switch (posRandom.X)
						{
						case 0:
							posRandom.X = 1;
							break;
						case 1:
							posRandom.X = 0;
							break;
						case 2:
							posRandom.X = 3;
							break;
						case 3:
							posRandom.X = 2;
							break;
						}
						int num3 = 0;
						do
						{
							posRandom.Y = num3;
							if (this.ListWar[posRandom.X.ToString("X2") + posRandom.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom.X.ToString("X2") + posRandom.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom);
							}
							num3++;
						}
						while (num3 <= 4);
						break;
					}
					}
				}
				return arrayList;
			}
		}
		public Point GetPosRandomCombo(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			Point result = default(Point);
			result.X = 99;
			result.Y = 99;
			DataStructure.WarInfo warInfo = this.ListWar[Class5.smethod_3(checked(new byte[]
			{
				(byte)rowAttack,
				(byte)columnAttack
			}))];
			int id = warInfo._Id;
			int type4_Id = warInfo._Type4_Id;
			int team = warInfo._Team;
			if (id > 0 & team != myteam & type4_Id != 13005 & type4_Id != 13025)
			{
				result.X = rowAttack;
				result.Y = columnAttack;
			}
			else
			{
				try
				{
					Dictionary<string, DataStructure.WarInfo>.ValueCollection.Enumerator enumerator = this.ListWar.Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataStructure.WarInfo current = enumerator.Current;
						int id2 = current._Id;
						int hp = current._Hp;
						int type4_Id2 = current._Type4_Id;
						int row = current._Row;
						int column = current._Column;
						int team2 = current._Team;
						if (id2 > 0 & hp > 0 & team2 != myteam & type4_Id2 != 13005 & type4_Id2 != 13025)
						{
							result.X = row;
							result.Y = column;
							break;
						}
					}
				}
				finally
				{
					
				}
			}
			return result;
		}
		public ArrayList GetPosAttackCombo(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			ArrayList arrayList = new ArrayList();
			Point posRandomCombo = this.GetPosRandomCombo(_IdBattle, myteam, rowAttack, columnAttack);
			checked
			{
				if (posRandomCombo.X >= 0 & posRandomCombo.X < 4)
				{
					switch (SLDanh)
					{
					case 1:
						arrayList.Add(posRandomCombo);
						break;
					case 2:
						arrayList.Add(posRandomCombo);
						switch (posRandomCombo.X)
						{
						case 0:
							posRandomCombo.X = 1;
							break;
						case 1:
							posRandomCombo.X = 0;
							break;
						case 2:
							posRandomCombo.X = 3;
							break;
						case 3:
							posRandomCombo.X = 2;
							break;
						}
						if (this.ListWar[posRandomCombo.X.ToString("X2") + posRandomCombo.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandomCombo.X.ToString("X2") + posRandomCombo.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandomCombo);
						}
						break;
					case 3:
					{
						arrayList.Add(posRandomCombo);
						Point point = posRandomCombo;
						point.Y = posRandomCombo.Y - 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						point.Y = posRandomCombo.Y + 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						break;
					}
					case 4:
					{
						arrayList.Add(posRandomCombo);
						Point point2 = posRandomCombo;
						point2.Y = posRandomCombo.Y - 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandomCombo.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandomCombo.Y;
							arrayList.Add(point2);
						}
						point2.Y = posRandomCombo.Y + 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandomCombo.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandomCombo.Y;
							arrayList.Add(point2);
						}
						break;
					}
					case 5:
					{
						arrayList.Add(posRandomCombo);
						Point point3 = posRandomCombo;
						point3.Y = posRandomCombo.Y - 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						point3.Y = posRandomCombo.Y + 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						switch (posRandomCombo.X)
						{
						case 0:
							posRandomCombo.X = 1;
							break;
						case 1:
							posRandomCombo.X = 0;
							break;
						case 2:
							posRandomCombo.X = 3;
							break;
						case 3:
							posRandomCombo.X = 2;
							break;
						}
						if (this.ListWar[posRandomCombo.X.ToString("X2") + posRandomCombo.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandomCombo.X.ToString("X2") + posRandomCombo.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandomCombo);
						}
						break;
					}
					case 6:
					{
						arrayList.Add(posRandomCombo);
						Point point4 = posRandomCombo;
						point4.Y = posRandomCombo.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandomCombo.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						switch (posRandomCombo.X)
						{
						case 0:
							posRandomCombo.X = 1;
							break;
						case 1:
							posRandomCombo.X = 0;
							break;
						case 2:
							posRandomCombo.X = 3;
							break;
						case 3:
							posRandomCombo.X = 2;
							break;
						}
						if (this.ListWar[posRandomCombo.X.ToString("X2") + posRandomCombo.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandomCombo.X.ToString("X2") + posRandomCombo.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandomCombo);
						}
						point4 = posRandomCombo;
						point4.Y = posRandomCombo.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandomCombo.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						break;
					}
					case 7:
					{
						int num = 0;
						do
						{
							posRandomCombo.Y = num;
							if (this.ListWar[posRandomCombo.X.ToString("X2") + posRandomCombo.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandomCombo.X.ToString("X2") + posRandomCombo.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandomCombo);
							}
							num++;
						}
						while (num <= 4);
						break;
					}
					case 8:
					{
						int num2 = 0;
						do
						{
							posRandomCombo.Y = num2;
							if (this.ListWar[posRandomCombo.X.ToString("X2") + posRandomCombo.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandomCombo.X.ToString("X2") + posRandomCombo.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandomCombo);
							}
							num2++;
						}
						while (num2 <= 4);
						switch (posRandomCombo.X)
						{
						case 0:
							posRandomCombo.X = 1;
							break;
						case 1:
							posRandomCombo.X = 0;
							break;
						case 2:
							posRandomCombo.X = 3;
							break;
						case 3:
							posRandomCombo.X = 2;
							break;
						}
						int num3 = 0;
						do
						{
							posRandomCombo.Y = num3;
							if (this.ListWar[posRandomCombo.X.ToString("X2") + posRandomCombo.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandomCombo.X.ToString("X2") + posRandomCombo.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandomCombo);
							}
							num3++;
						}
						while (num3 <= 4);
						break;
					}
					}
				}
				return arrayList;
			}
		}
		public Point GetPosRandomTG(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			Point result = default(Point);
			result.X = 99;
			result.Y = 99;
			DataStructure.WarInfo warInfo = this.ListWar[Class5.smethod_3(checked(new byte[]
			{
				(byte)rowAttack,
				(byte)columnAttack
			}))];
			int id = warInfo._Id;
			int hp = warInfo._Hp;
			int team = warInfo._Team;
			if (id > 0 & hp > 0 & team != myteam)
			{
				result.X = rowAttack;
				result.Y = columnAttack;
			}
			else
			{
				try
				{
					Dictionary<string, DataStructure.WarInfo>.ValueCollection.Enumerator enumerator = this.ListWar.Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataStructure.WarInfo current = enumerator.Current;
						int id2 = current._Id;
						int hp2 = current._Hp;
						int row = current._Row;
						int column = current._Column;
						int team2 = current._Team;
						if (id2 > 0 & hp2 > 0 & team2 != myteam)
						{
							result.X = row;
							result.Y = column;
							break;
						}
					}
				}
				finally
				{
					
				}
			}
			return result;
		}
		public ArrayList GetPosAttackTG(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			ArrayList arrayList = new ArrayList();
			Point posRandomTG = this.GetPosRandomTG(_IdBattle, myteam, rowAttack, columnAttack);
			checked
			{
				if (posRandomTG.X >= 0 & posRandomTG.X < 4)
				{
					switch (SLDanh)
					{
					case 1:
						arrayList.Add(posRandomTG);
						break;
					case 2:
						arrayList.Add(posRandomTG);
						switch (posRandomTG.X)
						{
						case 0:
							posRandomTG.X = 1;
							break;
						case 1:
							posRandomTG.X = 0;
							break;
						case 2:
							posRandomTG.X = 3;
							break;
						case 3:
							posRandomTG.X = 2;
							break;
						}
						if (this.ListWar[posRandomTG.X.ToString("X2") + posRandomTG.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandomTG.X.ToString("X2") + posRandomTG.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandomTG);
						}
						break;
					case 3:
					{
						arrayList.Add(posRandomTG);
						Point point = posRandomTG;
						point.Y = posRandomTG.Y - 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						point.Y = posRandomTG.Y + 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						break;
					}
					case 4:
					{
						arrayList.Add(posRandomTG);
						Point point2 = posRandomTG;
						point2.Y = posRandomTG.Y - 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandomTG.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandomTG.Y;
							arrayList.Add(point2);
						}
						point2.Y = posRandomTG.Y + 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandomTG.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandomTG.Y;
							arrayList.Add(point2);
						}
						break;
					}
					case 5:
					{
						arrayList.Add(posRandomTG);
						Point point3 = posRandomTG;
						point3.Y = posRandomTG.Y - 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						point3.Y = posRandomTG.Y + 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						switch (posRandomTG.X)
						{
						case 0:
							posRandomTG.X = 1;
							break;
						case 1:
							posRandomTG.X = 0;
							break;
						case 2:
							posRandomTG.X = 3;
							break;
						case 3:
							posRandomTG.X = 2;
							break;
						}
						if (this.ListWar[posRandomTG.X.ToString("X2") + posRandomTG.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandomTG.X.ToString("X2") + posRandomTG.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandomTG);
						}
						break;
					}
					case 6:
					{
						arrayList.Add(posRandomTG);
						Point point4 = posRandomTG;
						point4.Y = posRandomTG.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandomTG.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						switch (posRandomTG.X)
						{
						case 0:
							posRandomTG.X = 1;
							break;
						case 1:
							posRandomTG.X = 0;
							break;
						case 2:
							posRandomTG.X = 3;
							break;
						case 3:
							posRandomTG.X = 2;
							break;
						}
						if (this.ListWar[posRandomTG.X.ToString("X2") + posRandomTG.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandomTG.X.ToString("X2") + posRandomTG.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandomTG);
						}
						point4 = posRandomTG;
						point4.Y = posRandomTG.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandomTG.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						break;
					}
					case 7:
					{
						int num = 0;
						do
						{
							posRandomTG.Y = num;
							if (this.ListWar[posRandomTG.X.ToString("X2") + posRandomTG.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandomTG.X.ToString("X2") + posRandomTG.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandomTG);
							}
							num++;
						}
						while (num <= 4);
						break;
					}
					case 8:
					{
						int num2 = 0;
						do
						{
							posRandomTG.Y = num2;
							if (this.ListWar[posRandomTG.X.ToString("X2") + posRandomTG.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandomTG.X.ToString("X2") + posRandomTG.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandomTG);
							}
							num2++;
						}
						while (num2 <= 4);
						switch (posRandomTG.X)
						{
						case 0:
							posRandomTG.X = 1;
							break;
						case 1:
							posRandomTG.X = 0;
							break;
						case 2:
							posRandomTG.X = 3;
							break;
						case 3:
							posRandomTG.X = 2;
							break;
						}
						int num3 = 0;
						do
						{
							posRandomTG.Y = num3;
							if (this.ListWar[posRandomTG.X.ToString("X2") + posRandomTG.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandomTG.X.ToString("X2") + posRandomTG.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandomTG);
							}
							num3++;
						}
						while (num3 <= 4);
						break;
					}
					}
				}
				return arrayList;
			}
		}
		public Point GetPosRandom3_15(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			Point result = default(Point);
			result.X = 99;
			result.Y = 99;
			DataStructure.WarInfo warInfo = this.ListWar[Class5.smethod_3(checked(new byte[]
			{
				(byte)rowAttack,
				(byte)columnAttack
			}))];
			int id = warInfo._Id;
			int hp = warInfo._Hp;
			int type4_Id = warInfo._Type4_Id;
			int team = warInfo._Team;
			if (id > 0 & hp > 0 & team != myteam & type4_Id != 13005 & type4_Id != 13025)
			{
				result.X = rowAttack;
				result.Y = columnAttack;
			}
			else
			{
				try
				{
					Dictionary<string, DataStructure.WarInfo>.ValueCollection.Enumerator enumerator = this.ListWar.Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataStructure.WarInfo current = enumerator.Current;
						int id2 = current._Id;
						int hp2 = current._Hp;
						int type4_Id2 = current._Type4_Id;
						int row = current._Row;
						int column = current._Column;
						int team2 = current._Team;
						if (id2 > 0 & hp2 > 0 & team2 != myteam & type4_Id2 != 13005 & type4_Id2 != 13025)
						{
							result.X = row;
							result.Y = column;
							break;
						}
					}
				}
				finally
				{
					
				}
			}
			return result;
		}
		public ArrayList GetPosAttack3_15(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			ArrayList arrayList = new ArrayList();
			Point posRandom3_ = this.GetPosRandom3_15(_IdBattle, myteam, rowAttack, columnAttack);
			checked
			{
				if (posRandom3_.X >= 0 & posRandom3_.X < 4)
				{
					switch (SLDanh)
					{
					case 1:
						arrayList.Add(posRandom3_);
						break;
					case 2:
						arrayList.Add(posRandom3_);
						switch (posRandom3_.X)
						{
						case 0:
							posRandom3_.X = 1;
							break;
						case 1:
							posRandom3_.X = 0;
							break;
						case 2:
							posRandom3_.X = 3;
							break;
						case 3:
							posRandom3_.X = 2;
							break;
						}
						if (this.ListWar[posRandom3_.X.ToString("X2") + posRandom3_.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom3_.X.ToString("X2") + posRandom3_.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom3_);
						}
						break;
					case 3:
					{
						arrayList.Add(posRandom3_);
						Point point = posRandom3_;
						point.Y = posRandom3_.Y - 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						point.Y = posRandom3_.Y + 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						break;
					}
					case 4:
					{
						arrayList.Add(posRandom3_);
						Point point2 = posRandom3_;
						point2.Y = posRandom3_.Y - 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandom3_.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandom3_.Y;
							arrayList.Add(point2);
						}
						point2.Y = posRandom3_.Y + 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandom3_.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandom3_.Y;
							arrayList.Add(point2);
						}
						break;
					}
					case 5:
					{
						arrayList.Add(posRandom3_);
						Point point3 = posRandom3_;
						point3.Y = posRandom3_.Y - 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						point3.Y = posRandom3_.Y + 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						switch (posRandom3_.X)
						{
						case 0:
							posRandom3_.X = 1;
							break;
						case 1:
							posRandom3_.X = 0;
							break;
						case 2:
							posRandom3_.X = 3;
							break;
						case 3:
							posRandom3_.X = 2;
							break;
						}
						if (this.ListWar[posRandom3_.X.ToString("X2") + posRandom3_.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom3_.X.ToString("X2") + posRandom3_.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom3_);
						}
						break;
					}
					case 6:
					{
						arrayList.Add(posRandom3_);
						Point point4 = posRandom3_;
						point4.Y = posRandom3_.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandom3_.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						switch (posRandom3_.X)
						{
						case 0:
							posRandom3_.X = 1;
							break;
						case 1:
							posRandom3_.X = 0;
							break;
						case 2:
							posRandom3_.X = 3;
							break;
						case 3:
							posRandom3_.X = 2;
							break;
						}
						if (this.ListWar[posRandom3_.X.ToString("X2") + posRandom3_.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom3_.X.ToString("X2") + posRandom3_.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom3_);
						}
						point4 = posRandom3_;
						point4.Y = posRandom3_.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandom3_.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						break;
					}
					case 7:
					{
						int num = 0;
						do
						{
							posRandom3_.Y = num;
							if (this.ListWar[posRandom3_.X.ToString("X2") + posRandom3_.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom3_.X.ToString("X2") + posRandom3_.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom3_);
							}
							num++;
						}
						while (num <= 4);
						break;
					}
					case 8:
					{
						int num2 = 0;
						do
						{
							posRandom3_.Y = num2;
							if (this.ListWar[posRandom3_.X.ToString("X2") + posRandom3_.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom3_.X.ToString("X2") + posRandom3_.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom3_);
							}
							num2++;
						}
						while (num2 <= 4);
						switch (posRandom3_.X)
						{
						case 0:
							posRandom3_.X = 1;
							break;
						case 1:
							posRandom3_.X = 0;
							break;
						case 2:
							posRandom3_.X = 3;
							break;
						case 3:
							posRandom3_.X = 2;
							break;
						}
						int num3 = 0;
						do
						{
							posRandom3_.Y = num3;
							if (this.ListWar[posRandom3_.X.ToString("X2") + posRandom3_.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom3_.X.ToString("X2") + posRandom3_.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom3_);
							}
							num3++;
						}
						while (num3 <= 4);
						break;
					}
					}
				}
				return arrayList;
			}
		}
		public Point GetPosRandom_GiaiTru(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			Point result = default(Point);
			result.X = 99;
			result.Y = 99;
			int id = this.ListWar[Class5.smethod_3(checked(new byte[]
			{
				(byte)rowAttack,
				(byte)columnAttack
			}))]._Id;
			if (id > 0)
			{
				result.X = rowAttack;
				result.Y = columnAttack;
			}
			else
			{
				try
				{
					Dictionary<string, DataStructure.WarInfo>.ValueCollection.Enumerator enumerator = this.ListWar.Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataStructure.WarInfo current = enumerator.Current;
						int id2 = current._Id;
						int row = current._Row;
						int column = current._Column;
						if (id2 > 0)
						{
							result.X = row;
							result.Y = column;
							break;
						}
					}
				}
				finally
				{
					
				}
			}
			return result;
		}
		public ArrayList GetPosAttack_GiaiTru(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			ArrayList arrayList = new ArrayList();
			Point posRandom_GiaiTru = this.GetPosRandom_GiaiTru(_IdBattle, myteam, rowAttack, columnAttack);
			checked
			{
				if (posRandom_GiaiTru.X >= 0 & posRandom_GiaiTru.X < 4)
				{
					switch (SLDanh)
					{
					case 1:
						arrayList.Add(posRandom_GiaiTru);
						break;
					case 2:
						arrayList.Add(posRandom_GiaiTru);
						switch (posRandom_GiaiTru.X)
						{
						case 0:
							posRandom_GiaiTru.X = 1;
							break;
						case 1:
							posRandom_GiaiTru.X = 0;
							break;
						case 2:
							posRandom_GiaiTru.X = 3;
							break;
						case 3:
							posRandom_GiaiTru.X = 2;
							break;
						}
						if (this.ListWar[posRandom_GiaiTru.X.ToString("X2") + posRandom_GiaiTru.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_GiaiTru.X.ToString("X2") + posRandom_GiaiTru.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom_GiaiTru);
						}
						break;
					case 3:
					{
						arrayList.Add(posRandom_GiaiTru);
						Point point = posRandom_GiaiTru;
						point.Y = posRandom_GiaiTru.Y - 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						point.Y = posRandom_GiaiTru.Y + 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						break;
					}
					case 4:
					{
						arrayList.Add(posRandom_GiaiTru);
						Point point2 = posRandom_GiaiTru;
						point2.Y = posRandom_GiaiTru.Y - 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandom_GiaiTru.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandom_GiaiTru.Y;
							arrayList.Add(point2);
						}
						point2.Y = posRandom_GiaiTru.Y + 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandom_GiaiTru.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandom_GiaiTru.Y;
							arrayList.Add(point2);
						}
						break;
					}
					case 5:
					{
						arrayList.Add(posRandom_GiaiTru);
						Point point3 = posRandom_GiaiTru;
						point3.Y = posRandom_GiaiTru.Y - 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						point3.Y = posRandom_GiaiTru.Y + 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						switch (posRandom_GiaiTru.X)
						{
						case 0:
							posRandom_GiaiTru.X = 1;
							break;
						case 1:
							posRandom_GiaiTru.X = 0;
							break;
						case 2:
							posRandom_GiaiTru.X = 3;
							break;
						case 3:
							posRandom_GiaiTru.X = 2;
							break;
						}
						if (this.ListWar[posRandom_GiaiTru.X.ToString("X2") + posRandom_GiaiTru.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_GiaiTru.X.ToString("X2") + posRandom_GiaiTru.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom_GiaiTru);
						}
						break;
					}
					case 6:
					{
						arrayList.Add(posRandom_GiaiTru);
						Point point4 = posRandom_GiaiTru;
						point4.Y = posRandom_GiaiTru.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandom_GiaiTru.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						switch (posRandom_GiaiTru.X)
						{
						case 0:
							posRandom_GiaiTru.X = 1;
							break;
						case 1:
							posRandom_GiaiTru.X = 0;
							break;
						case 2:
							posRandom_GiaiTru.X = 3;
							break;
						case 3:
							posRandom_GiaiTru.X = 2;
							break;
						}
						if (this.ListWar[posRandom_GiaiTru.X.ToString("X2") + posRandom_GiaiTru.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_GiaiTru.X.ToString("X2") + posRandom_GiaiTru.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom_GiaiTru);
						}
						point4 = posRandom_GiaiTru;
						point4.Y = posRandom_GiaiTru.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandom_GiaiTru.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						break;
					}
					case 7:
					{
						int num = 0;
						do
						{
							posRandom_GiaiTru.Y = num;
							if (this.ListWar[posRandom_GiaiTru.X.ToString("X2") + posRandom_GiaiTru.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_GiaiTru.X.ToString("X2") + posRandom_GiaiTru.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom_GiaiTru);
							}
							num++;
						}
						while (num <= 4);
						break;
					}
					case 8:
					{
						int num2 = 0;
						do
						{
							posRandom_GiaiTru.Y = num2;
							if (this.ListWar[posRandom_GiaiTru.X.ToString("X2") + posRandom_GiaiTru.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_GiaiTru.X.ToString("X2") + posRandom_GiaiTru.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom_GiaiTru);
							}
							num2++;
						}
						while (num2 <= 4);
						switch (posRandom_GiaiTru.X)
						{
						case 0:
							posRandom_GiaiTru.X = 1;
							break;
						case 1:
							posRandom_GiaiTru.X = 0;
							break;
						case 2:
							posRandom_GiaiTru.X = 3;
							break;
						case 3:
							posRandom_GiaiTru.X = 2;
							break;
						}
						int num3 = 0;
						do
						{
							posRandom_GiaiTru.Y = num3;
							if (this.ListWar[posRandom_GiaiTru.X.ToString("X2") + posRandom_GiaiTru.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_GiaiTru.X.ToString("X2") + posRandom_GiaiTru.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom_GiaiTru);
							}
							num3++;
						}
						while (num3 <= 4);
						break;
					}
					}
				}
				return arrayList;
			}
		}
		public Point GetPosRandom_Type4(int _IdBattle, int myteam, int rowAttack, int columnAttack)
		{
			Point result = default(Point);
			result.X = 99;
			result.Y = 99;
			DataStructure.WarInfo warInfo = this.ListWar[Class5.smethod_3(checked(new byte[]
			{
				(byte)rowAttack,
				(byte)columnAttack
			}))];
			int id = warInfo._Id;
			int hp = warInfo._Hp;
			int team = warInfo._Team;
			if (id > 0 & hp > 0 & team == myteam)
			{
				result.X = rowAttack;
				result.Y = columnAttack;
			}
			else
			{
				try
				{
					Dictionary<string, DataStructure.WarInfo>.ValueCollection.Enumerator enumerator = this.ListWar.Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataStructure.WarInfo current = enumerator.Current;
						int id2 = current._Id;
						int hp2 = current._Hp;
						int row = current._Row;
						int column = current._Column;
						int team2 = current._Team;
						if (id2 > 0 & hp2 > 0 & team2 == myteam)
						{
							result.X = row;
							result.Y = column;
							break;
						}
					}
				}
				finally
				{
					
				}
			}
			return result;
		}
		public ArrayList GetPosAttack_Type4(int _IdBattle, int myteam, int rowAttack, int columnAttack, int SLDanh)
		{
			ArrayList arrayList = new ArrayList();
			Point posRandom_Type = this.GetPosRandom_Type4(_IdBattle, myteam, rowAttack, columnAttack);
			checked
			{
				if (posRandom_Type.X >= 0 & posRandom_Type.X < 4)
				{
					switch (SLDanh)
					{
					case 1:
						arrayList.Add(posRandom_Type);
						break;
					case 2:
						arrayList.Add(posRandom_Type);
						switch (posRandom_Type.X)
						{
						case 0:
							posRandom_Type.X = 1;
							break;
						case 1:
							posRandom_Type.X = 0;
							break;
						case 2:
							posRandom_Type.X = 3;
							break;
						case 3:
							posRandom_Type.X = 2;
							break;
						}
						if (this.ListWar[posRandom_Type.X.ToString("X2") + posRandom_Type.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_Type.X.ToString("X2") + posRandom_Type.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom_Type);
						}
						break;
					case 3:
					{
						arrayList.Add(posRandom_Type);
						Point point = posRandom_Type;
						point.Y = posRandom_Type.Y - 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						point.Y = posRandom_Type.Y + 1;
						if (this.ListWar.ContainsKey(point.X.ToString("X2") + point.Y.ToString("X2")) && (this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Id > 0 & this.ListWar[point.X.ToString("X2") + point.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point);
						}
						break;
					}
					case 4:
					{
						arrayList.Add(posRandom_Type);
						Point point2 = posRandom_Type;
						point2.Y = posRandom_Type.Y - 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandom_Type.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandom_Type.Y;
							arrayList.Add(point2);
						}
						point2.Y = posRandom_Type.Y + 1;
						if (this.ListWar.ContainsKey(point2.X.ToString("X2") + point2.Y.ToString("X2")))
						{
							if (this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Id > 0 & this.ListWar[point2.X.ToString("X2") + point2.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(point2);
							}
							else
							{
								point2.Y = posRandom_Type.Y;
								arrayList.Add(point2);
							}
						}
						else
						{
							point2.Y = posRandom_Type.Y;
							arrayList.Add(point2);
						}
						break;
					}
					case 5:
					{
						arrayList.Add(posRandom_Type);
						Point point3 = posRandom_Type;
						point3.Y = posRandom_Type.Y - 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						point3.Y = posRandom_Type.Y + 1;
						if (this.ListWar.ContainsKey(point3.X.ToString("X2") + point3.Y.ToString("X2")) && (this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Id > 0 & this.ListWar[point3.X.ToString("X2") + point3.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point3);
						}
						switch (posRandom_Type.X)
						{
						case 0:
							posRandom_Type.X = 1;
							break;
						case 1:
							posRandom_Type.X = 0;
							break;
						case 2:
							posRandom_Type.X = 3;
							break;
						case 3:
							posRandom_Type.X = 2;
							break;
						}
						if (this.ListWar[posRandom_Type.X.ToString("X2") + posRandom_Type.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_Type.X.ToString("X2") + posRandom_Type.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom_Type);
						}
						break;
					}
					case 6:
					{
						arrayList.Add(posRandom_Type);
						Point point4 = posRandom_Type;
						point4.Y = posRandom_Type.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandom_Type.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						switch (posRandom_Type.X)
						{
						case 0:
							posRandom_Type.X = 1;
							break;
						case 1:
							posRandom_Type.X = 0;
							break;
						case 2:
							posRandom_Type.X = 3;
							break;
						case 3:
							posRandom_Type.X = 2;
							break;
						}
						if (this.ListWar[posRandom_Type.X.ToString("X2") + posRandom_Type.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_Type.X.ToString("X2") + posRandom_Type.Y.ToString("X2")]._Hp > 0)
						{
							arrayList.Add(posRandom_Type);
						}
						point4 = posRandom_Type;
						point4.Y = posRandom_Type.Y - 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						point4.Y = posRandom_Type.Y + 1;
						if (this.ListWar.ContainsKey(point4.X.ToString("X2") + point4.Y.ToString("X2")) && (this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Id > 0 & this.ListWar[point4.X.ToString("X2") + point4.Y.ToString("X2")]._Hp > 0))
						{
							arrayList.Add(point4);
						}
						break;
					}
					case 7:
					{
						int num = 0;
						do
						{
							posRandom_Type.Y = num;
							if (this.ListWar[posRandom_Type.X.ToString("X2") + posRandom_Type.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_Type.X.ToString("X2") + posRandom_Type.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom_Type);
							}
							num++;
						}
						while (num <= 4);
						break;
					}
					case 8:
					{
						int num2 = 0;
						do
						{
							posRandom_Type.Y = num2;
							if (this.ListWar[posRandom_Type.X.ToString("X2") + posRandom_Type.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_Type.X.ToString("X2") + posRandom_Type.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom_Type);
							}
							num2++;
						}
						while (num2 <= 4);
						switch (posRandom_Type.X)
						{
						case 0:
							posRandom_Type.X = 1;
							break;
						case 1:
							posRandom_Type.X = 0;
							break;
						case 2:
							posRandom_Type.X = 3;
							break;
						case 3:
							posRandom_Type.X = 2;
							break;
						}
						int num3 = 0;
						do
						{
							posRandom_Type.Y = num3;
							if (this.ListWar[posRandom_Type.X.ToString("X2") + posRandom_Type.Y.ToString("X2")]._Id > 0 & this.ListWar[posRandom_Type.X.ToString("X2") + posRandom_Type.Y.ToString("X2")]._Hp > 0)
							{
								arrayList.Add(posRandom_Type);
							}
							num3++;
						}
						while (num3 <= 4);
						break;
					}
					}
				}
				return arrayList;
			}
		}
		public int GetTurn(int IdSkill, int LvSKill)
		{
			int result = 3;
			if (IdSkill != 13002 && IdSkill != 14008 && IdSkill != 13003 && IdSkill != 13005)
			{
				if (IdSkill != 13012)
				{
					if (IdSkill != 10033 && IdSkill != 10015 && IdSkill != 10026 && IdSkill != 13021 && IdSkill != 13025 && IdSkill != 10025 && IdSkill != 14020 && IdSkill != 12025 && IdSkill != 14040 && IdSkill != 14044 && IdSkill != 14046)
					{
						if (IdSkill != 14053)
						{
							if (IdSkill != 10004 && IdSkill != 11002 && IdSkill != 12024 && IdSkill != 13011 && IdSkill != 13030 && IdSkill != 14015 && IdSkill != 14029 && IdSkill != 20018 && IdSkill != 11024 && IdSkill != 11032)
							{
								if (IdSkill != 13020)
								{
									if (IdSkill != 13015 && IdSkill != 13016 && IdSkill != 13017 && IdSkill != 13018 && IdSkill != 10016 && IdSkill != 10017 && IdSkill != 10018)
									{
										if (IdSkill != 10019)
										{
											if (IdSkill != 11014 && IdSkill != 20014 && IdSkill != 20022)
											{
												if (IdSkill != 20023)
												{
													if (IdSkill != 20025 && IdSkill != 20026 && IdSkill != 20027 && IdSkill != 10010 && IdSkill != 10031 && IdSkill != 13014 && IdSkill != 20024 && IdSkill != 14012)
													{
														if (IdSkill != 14013)
														{
															if (IdSkill != 14021)
															{
																return result;
															}
															switch (LvSKill)
															{
															case 1:
																result = 2;
																return result;
															case 2:
																result = 3;
																return result;
															case 3:
																result = 4;
																return result;
															case 4:
																result = 5;
																return result;
															case 5:
																result = 6;
																return result;
															default:
																return result;
															}
														}
													}
													switch (LvSKill)
													{
													case 1:
													case 2:
													case 3:
														result = 2;
														return result;
													case 4:
													case 5:
													case 6:
														result = 3;
														return result;
													case 7:
													case 8:
													case 9:
														result = 4;
														return result;
													case 10:
														result = 5;
														return result;
													default:
														return result;
													}
												}
											}
											result = 5;
											return result;
										}
									}
									result = 4;
									return result;
								}
							}
							result = 3;
							return result;
						}
					}
					switch (LvSKill)
					{
					case 1:
					case 2:
						result = 2;
						return result;
					case 3:
					case 4:
						result = 3;
						return result;
					case 5:
						result = 4;
						return result;
					default:
						return result;
					}
				}
			}
			switch (LvSKill)
			{
			case 1:
			case 2:
				result = 2;
				break;
			case 3:
			case 4:
			case 5:
				result = 3;
				break;
			}
			return result;
		}
		public string Skilling(int Row, int column, int idskill, int Rowattack, int columnattack, int Type_StatusAttackMiss, int Attack_Def_Lantranh, int CountHieuUng, int TroiBuffHpSp, int Damage, int StatusBuffHpSP)
		{
			return string.Concat(new string[]
			{
				"0F00",
				Row.ToString("X2"),
				column.ToString("X2"),
				Class5.smethod_11(idskill),
				Data.GetDataSkill(idskill, DataStructure.Type_Skill._SLdanh).ToString("X2"),
				Data.GetDataSkill(idskill, DataStructure.Type_Skill._Type).ToString("X2"),
				Rowattack.ToString("X2"),
				columnattack.ToString("X2"),
				Type_StatusAttackMiss.ToString("X2"),
				Attack_Def_Lantranh.ToString("X2"),
				CountHieuUng.ToString("X2"),
				TroiBuffHpSp.ToString("X2"),
				Class5.smethod_11(Damage),
				StatusBuffHpSP.ToString("X2")
			});
		}
		public string SkillingInt(int Rowattack, int columnattack, int Type_StatusAttackMiss, int Attack_Def_Lantranh, int CountHieuUng, int TroiBuffHpSp, int Damage, int StatusBuffHpSP)
		{
			return string.Concat(new string[]
			{
				Rowattack.ToString("X2"),
				columnattack.ToString("X2"),
				Type_StatusAttackMiss.ToString("X2"),
				Attack_Def_Lantranh.ToString("X2"),
				CountHieuUng.ToString("X2"),
				TroiBuffHpSp.ToString("X2"),
				Class5.smethod_11(Damage),
				StatusBuffHpSP.ToString("X2")
			});
		}
		public string Skilling(int Rowattack, int columnattack, int Type_StatusAttackMiss, int Attack_Def_Lantranh)
		{
			return Rowattack.ToString("X2") + columnattack.ToString("X2") + Type_StatusAttackMiss.ToString("X2") + Attack_Def_Lantranh.ToString("X2");
		}
		public string SkillingHieuUng(int TroiBuffHpSp, int Damage, int StatusBuffHpSP)
		{
			return TroiBuffHpSp.ToString("X2") + Class5.smethod_11(Damage) + StatusBuffHpSP.ToString("X2");
		}
		public void TroiEnd(int _IdBattle, int Row, int column, int troiend)
		{
			this.SendSKillingToParty(string.Concat(new string[]
			{
				"F44407003501",
				Row.ToString("X2"),
				column.ToString("X2"),
				troiend.ToString("X2"),
				"0000"
			}));
		}
		public string TroiStart(int Row, int column, int troiend, int idskill)
		{
			return string.Concat(new string[]
			{
				"F44407003501",
				Row.ToString("X2"),
				column.ToString("X2"),
				troiend.ToString("X2"),
				Class5.smethod_11(idskill)
			});
		}
		public int GetRandomMissCombo(int lvtb1, int lvtb2)
		{
			checked
			{
				int num = lvtb1 - lvtb2;
				int percentvalue = 100;
				if (num < 40)
				{
					percentvalue = 60 + num;
				}
				return this.RandomizeArrayWithPercent(1, 0, percentvalue);
			}
		}
		public int GetRandomMissDrop(int Idnpc)
		{
			int result = 0;
			int dataNpc = Data.GetDataNpc(Idnpc, DataStructure.Type_Npc._Item1);
			int dataNpc2 = Data.GetDataNpc(Idnpc, DataStructure.Type_Npc._Item2);
			int dataNpc3 = Data.GetDataNpc(Idnpc, DataStructure.Type_Npc._Item3);
			int dataNpc4 = Data.GetDataNpc(Idnpc, DataStructure.Type_Npc._Item4);
			int dataNpc5 = Data.GetDataNpc(Idnpc, DataStructure.Type_Npc._Item5);
			int dataNpc6 = Data.GetDataNpc(Idnpc, DataStructure.Type_Npc._Item6);
			int num = this.random_0.Next(1, 1000);
			checked
			{
				if (num >= 0 & num <= Server.percent_item1)
				{
					result = dataNpc;
				}
				else
				{
					if (num > Server.percent_item1 & num <= Server.percent_item1 + Server.percent_item2)
					{
						result = dataNpc2;
					}
					else
					{
						if (num > Server.percent_item1 + Server.percent_item2 & num <= Server.percent_item1 + Server.percent_item2 + Server.percent_item3)
						{
							result = dataNpc3;
						}
						else
						{
							if (num > Server.percent_item1 + Server.percent_item2 + Server.percent_item3 & num <= Server.percent_item1 + Server.percent_item2 + Server.percent_item3 + Server.percent_item4)
							{
								result = dataNpc4;
							}
							else
							{
								if (num > Server.percent_item1 + Server.percent_item2 + Server.percent_item3 + Server.percent_item4 & num <= Server.percent_item1 + Server.percent_item2 + Server.percent_item3 + Server.percent_item4 + Server.percent_item5)
								{
									result = dataNpc5;
								}
								else
								{
									if (num > Server.percent_item1 + Server.percent_item2 + Server.percent_item3 + Server.percent_item4 + Server.percent_item5 & num <= Server.percent_item1 + Server.percent_item2 + Server.percent_item3 + Server.percent_item4 + Server.percent_item5 + Server.percent_item6)
									{
										result = dataNpc6;
									}
								}
							}
						}
					}
				}
				return result;
			}
		}
		public int GetRandomSkillNPC(int lv, int reborn, int skill1, int skill2, int skill3)
		{
			if (skill1 == 0)
			{
				skill1 = 10000;
			}
			if (skill2 == 0)
			{
				skill2 = 10000;
			}
			if (skill3 == 0)
			{
				skill3 = 10000;
			}
			checked
			{
				int result;
				if (this.random_0.Next(1, 100) <= 5 * (reborn + 1) & this.random_0.Next(1, 100) >= 0)
				{
					result = skill3;
				}
				else
				{
					if (this.random_0.Next(1, 100) <= 15 * (reborn + 1) & this.random_0.Next(1, 100) > 5 * reborn)
					{
						result = skill2;
					}
					else
					{
						if (this.random_0.Next(1, 100) <= 30 * (reborn + 1) & this.random_0.Next(1, 100) > 15 * reborn)
						{
							result = skill2;
						}
						else
						{
							result = 10000;
						}
					}
				}
				return result;
			}
		}
		public int GetRandomMissAttack(int lv1, int lv2, int lvtb1, int lvtb2)
		{
			checked
			{
				int num = (int)Math.Round((double)(lv1 - lv2) / 10.0);
				int num2 = (int)Math.Round((double)(lvtb1 - lvtb2) / 10.0);
				int num3 = 100 + num;
				num3 += num2;
				return this.RandomizeArrayWithPercent(1, 0, num3);
			}
		}
		public int GetRandomMissChayTron(int lv1, int lv2, int lvtb1, int lvtb2)
		{
			checked
			{
				int num = lv1 - lv2;
				int num2 = lvtb1 - lvtb2;
				int num3 = 60 + num;
				num3 += num2;
				return this.RandomizeArrayWithPercent(1, 0, num3);
			}
		}
		public int GetRandomMissTroi(int lv1, int lv2, int lvtb1, int lvtb2, int int1, int int2, int reborn1, int reborn2)
		{
			checked
			{
				int num = (int)Math.Round((double)(lv1 - lv2) / 20.0);
				int num2 = (int)Math.Round((double)(lvtb1 - lvtb2) / 20.0);
				int num3 = 30 + int1 / 30;
				num3 -= int2 / 30;
				num3 += num;
				num3 += num2;
				num3 += reborn1 * 5;
				num3 -= reborn2 * 5;
				return this.RandomizeArrayWithPercent(1, 0, num3);
			}
		}
		public int RandomizeArray(ArrayList items)
		{
			int num = 0;
			checked
			{
				if (items.Count > 0)
				{
					num = Conversions.ToInteger(items[0]);
					int arg_22_0 = 0;
					int num2 = items.Count - 1;
					for (int i = arg_22_0; i <= num2; i++)
					{
						num = this.RandomizeArrayWithPercent(num, Conversions.ToInteger(items[i]), 50);
					}
				}
				return num;
			}
		}
		public int RandomizeArrayWithPercent(int value1, int value2, int percentvalue1 = 100)
		{
			if (percentvalue1 > 100)
			{
				percentvalue1 = 100;
			}
			int result;
			if (this.random_0.Next(1, 1000) <= checked(percentvalue1 * 10))
			{
				result = value1;
			}
			else
			{
				result = value2;
			}
			return result;
		}
		public int GetThuoctinhKhac(int thuoctinh1, int thuoctinh2)
		{
			int result = 0;
			switch (thuoctinh1)
			{
			case 1:
				if (thuoctinh2 == 4)
				{
					result = 2;
				}
				if (thuoctinh2 == 2)
				{
					result = 1;
				}
				break;
			case 2:
				if (thuoctinh2 == 1)
				{
					result = 2;
				}
				if (thuoctinh2 == 3)
				{
					result = 1;
				}
				break;
			case 3:
				if (thuoctinh2 == 2)
				{
					result = 2;
				}
				if (thuoctinh2 == 4)
				{
					result = 1;
				}
				break;
			case 4:
				if (thuoctinh2 == 3)
				{
					result = 2;
				}
				if (thuoctinh2 == 1)
				{
					result = 1;
				}
				break;
			default:
				result = 0;
				break;
			}
			return result;
		}
		[DebuggerStepThrough, CompilerGenerated]
		private void varLambda__2(object a0)
		{
			this.BattlePkPlayer(Conversions.ToInteger(a0));
		}
		[DebuggerStepThrough, CompilerGenerated]
		private void varLambda__3(object a0)
		{
			this.BattleNpc(Conversions.ToInteger(a0));
		}
		[DebuggerStepThrough, CompilerGenerated]
		private void varLambda__4(object a0)
		{
			this.BattleNpc(Conversions.ToInteger(a0));
		}
	}
}
