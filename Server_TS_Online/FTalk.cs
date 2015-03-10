using Microsoft.VisualBasic.CompilerServices;
using System;
namespace Server_TS_Online
{
	public class FTalk
	{
		public static void H1(Client _client, byte[] packet)
		{
			_client.idtalking = Class5.smethod_9(new byte[]
			{
				packet[6],
				packet[7]
			});
			int my_MapId = _client._My_MapId;
			_client.idnpctalking = Data.GetDataNpcOnMap(my_MapId, _client.idtalking, DataStructure.Type_NpcOnMap._NpcId);
			int dataNpcOnMap = Data.GetDataNpcOnMap(my_MapId, _client.idtalking, DataStructure.Type_NpcOnMap._SoLuong);
			checked
			{
				int num = _client._My_MapX - Data.GetDataNpcOnMap(my_MapId, _client.idtalking, DataStructure.Type_NpcOnMap._X_First);
				int num2 = _client._My_MapY - Data.GetDataNpcOnMap(my_MapId, _client.idtalking, DataStructure.Type_NpcOnMap._Y_First);
				int idnpctalking = _client.idnpctalking;
				if (idnpctalking != 16080 && idnpctalking != 16004 && idnpctalking != 16011)
				{
					if (idnpctalking != 16012)
					{
						if (!(-150 <= num & num <= 150 & -150 <= num2 & num2 <= 150))
						{
							_client.EndTalk();
							return;
						}
						if (dataNpcOnMap == 0)
						{
							_client.Typetalk = "NPC";
							int step = _client.QuestGetDataNpc(my_MapId, _client.idtalking);
							if (!Data.GetDataTalkExits(my_MapId, _client.Typetalk, _client.idtalking, step))
							{
								_client.Sendpacket("F44402000602");
								_client.Sendpacket("F44411001401000000010103" + _client.idtalking.ToString("X2") + "000000000000C830");
								return;
							}
							if (Data.GetDataTalkCount(my_MapId, _client.Typetalk, _client.idtalking, step) == 0)
							{
								_client.EndTalk();
								return;
							}
							_client.Sendpacket("F44402000602");
							_client.Sendpacket(Data.GetDataTalkString(my_MapId, _client.Typetalk, _client.idtalking, step, _client.talkcount + 1));
							if ((double)my_MapId == Conversions.ToDouble("10817"))
							{
								FTalk.M18017(_client);
								return;
							}
							return;
						}
						else
						{
							if (dataNpcOnMap <= 0)
							{
								return;
							}
							DataStructure.Key_NpcOnMap key_NpcOnMap = Data.GetKey_NpcOnMap(my_MapId, _client.idtalking);
							if (!Data.NpcOnMap.ContainsKey(key_NpcOnMap))
							{
								_client.EndTalk();
								return;
							}
							DataStructure._NpcOnMap npcOnMap = Data.NpcOnMap[key_NpcOnMap];
							if (_client._My_IdBattle > 0)
							{
								return;
							}
							int npcId = npcOnMap._NpcId;
							int delay = npcOnMap._Delay;
							if (delay != 0)
							{
								return;
							}
							switch (dataNpcOnMap)
							{
							case 1:
							{
								DataStructure.TeamDeffender teamdef = default(DataStructure.TeamDeffender);
								teamdef._id3 = npcId;
								_client._My_TalkingBattle = _client.idtalking;
								new TheBattle(_client._My_Id, teamdef, 4712);
								return;
							}
							case 2:
							case 4:
								return;
							case 3:
							{
								DataStructure.TeamDeffender teamdef2 = default(DataStructure.TeamDeffender);
								teamdef2._id2 = npcId;
								teamdef2._id3 = npcId;
								teamdef2._id4 = npcId;
								_client._My_TalkingBattle = _client.idtalking;
								new TheBattle(_client._My_Id, teamdef2, 4712);
								return;
							}
							case 5:
							{
								DataStructure.TeamDeffender teamdef3 = default(DataStructure.TeamDeffender);
								teamdef3._id1 = npcId;
								teamdef3._id2 = npcId;
								teamdef3._id3 = npcId;
								teamdef3._id4 = npcId;
								teamdef3._id5 = npcId;
								_client._My_TalkingBattle = _client.idtalking;
								new TheBattle(_client._My_Id, teamdef3, 4712);
								return;
							}
							default:
								return;
							}
						}
					}
				}
				if (-150 <= num & num <= 150 & -150 <= num2 & num2 <= 150)
				{
					_client.Typetalk = "NPC";
					_client.Sendpacket("F44402000602");
					_client.Sendpacket("F44411001401000000010603" + _client.idtalking.ToString("X2") + "0000000000000100");
				}
				else
				{
					_client.EndTalk();
				}
			}
		}
		public static void H4(Client _client, byte[] packet)
		{
			_client.EndTalk();
		}
		public static void H6(Client _client, byte[] packet)
		{
			if (_client.warpfinish)
			{
				_client.Sendpacket("F44402000504");
				_client.Sendpacket("F44402001408");
				_client.warpfinish = false;
				_client.talkcount = 0;
				_client.idtalking = 0;
				return;
			}
			checked
			{
				if (_client.idtalking > 0)
				{
					int my_MapId = _client._My_MapId;
					string typetalk = _client.Typetalk;
					if (Operators.CompareString(typetalk, "NPC", false) == 0)
					{
						int idnpctalking = _client.idnpctalking;
						if (idnpctalking != 16080 && idnpctalking != 16004 && idnpctalking != 16011)
						{
							if (idnpctalking != 16012)
							{
								int num = my_MapId;
								if (num == 10851)
								{
									int idtalking = _client.idtalking;
									if (idtalking == 2 && _client.SelectMenu == 31)
									{
										_client.EndTalk();
										return;
									}
								}
								if (_client.SelectMenu == 40)
								{
									_client.EndTalk();
									return;
								}
								int step = _client.QuestGetDataNpc(my_MapId, _client.idtalking);
								if (!Data.GetDataTalkExits(my_MapId, _client.Typetalk, _client.idtalking, step))
								{
									_client.EndTalk();
									return;
								}
								int dataTalkCount = Data.GetDataTalkCount(my_MapId, _client.Typetalk, _client.idtalking, step);
								_client.talkcount++;
								if (_client.talkcount < dataTalkCount)
								{
									_client.Sendpacket(Data.GetDataTalkString(my_MapId, _client.Typetalk, _client.idtalking, step, _client.talkcount + 1));
									return;
								}
								int num2 = my_MapId;
								if (num2 != 10851)
								{
									_client.EndTalk();
									return;
								}
								int idtalking2 = _client.idtalking;
								if (idtalking2 == 2)
								{
									if (_client.QuestGetDataNpc(my_MapId, _client.idtalking) == 0)
									{
										Data.HomdoAddItem(_client._My_Id, 31007, 1);
										Data.HomdoAddItem(_client._My_Id, 19001, 1);
										int num3 = Data.HomdoGetSlotExits(_client.conn, 19001);
										int loai = Data.HomdoGetDataItem(_client.conn, num3)._Loai;
										Data.HomdoUseItemTB(_client._My_Id, num3, loai);
										Server.ServerSend_EquitItem(_client._My_Id, 19001);
										_client.UpdateStatusWhenUseItem();
										_client.Sendpacket("F44403001711" + num3.ToString("X2"));
										_client.QuestUpdateDataNpc(my_MapId, _client.idtalking, 1);
									}
									_client.EndTalk();
									return;
								}
								_client.EndTalk();
								return;
							}
						}
						switch (_client.SelectMenu)
						{
						case 30:
						{
							int int_ = Data.TienTrangGetDataMoney(_client.conn);
							_client.Sendpacket("F44403001D0900");
							_client.Sendpacket("F44406001D04" + Class5.smethod_12(int_));
							_client.Sendpacket("F44402001D05");
							_client.Sendpacket("F44402001409");
							break;
						}
						case 31:
						{
							_client.Sendpacket("F44402001D06");
							int num4 = 1;
							do
							{
								num4++;
							}
							while (num4 <= 50);
							_client.Sendpacket("F44402001409");
							break;
						}
						case 40:
							_client.EndTalk();
							return;
						}
					}
					else
					{
						if (Operators.CompareString(typetalk, "WARP", false) == 0)
						{
							int num5 = my_MapId;
							if (num5 == 10851)
							{
								int idtalking3 = _client.idtalking;
								if (idtalking3 == 2)
								{
									if (_client.SelectMenu == 31)
									{
										_client.EndTalk();
										return;
									}
									if (_client.SelectMenu == 30)
									{
									}
								}
							}
							if (_client.SelectMenu == 40)
							{
								_client.EndTalk();
								return;
							}
							int step2 = _client.QuestGetDataNpc(my_MapId, _client.idtalking);
							int dataTalkCount2 = Data.GetDataTalkCount(my_MapId, _client.Typetalk, _client.idtalking, step2);
							_client.talkcount++;
							if (_client.talkcount < dataTalkCount2)
							{
								_client.Sendpacket(Data.GetDataTalkString(my_MapId, _client.Typetalk, _client.idtalking, step2, _client.talkcount + 1));
							}
							else
							{
								int num6 = my_MapId;
								if (num6 == 10851)
								{
									if (_client.QuestGetDataNpc(my_MapId, _client.idtalking) == 1 & _client.idtalking == 2)
									{
										int mapid = my_MapId;
										Data.Warped(_client._My_Id, mapid, 12003, 530, 510, 4);
										_client.talkcount = 0;
										_client.idtalking = 0;
									}
									else
									{
										_client.EndTalk();
									}
								}
								else
								{
									if (num6 == 10817)
									{
										if (_client.idtalking == 1)
										{
											int mapid2 = my_MapId;
											Data.Warped(_client._My_Id, mapid2, 10851, 890, 510, 4);
											_client.talkcount = 0;
											_client.idtalking = 0;
										}
										else
										{
											_client.EndTalk();
										}
									}
									else
									{
										_client.EndTalk();
									}
								}
							}
						}
					}
				}
			}
		}
		public static void H8(Client _client, byte[] packet)
		{
			_client.Typetalk = "WARP";
			_client.idtalking = Class5.smethod_9(new byte[]
			{
				packet[6],
				packet[7]
			});
			int num = (int)packet[6];
			int my_MapId = _client._My_MapId;
			int step = _client.QuestGetDataNpc(my_MapId, _client.idtalking);
			if (Data.GetDataTalkExits(my_MapId, _client.Typetalk, _client.idtalking, step))
			{
				if (Data.GetDataTalkCount(my_MapId, _client.Typetalk, _client.idtalking, step) == 0)
				{
					_client.EndTalk();
					return;
				}
				_client.Sendpacket("F44402000602");
				_client.Sendpacket(Data.GetDataTalkString(my_MapId, _client.Typetalk, _client.idtalking, step, checked(_client.talkcount + 1)));
			}
			else
			{
				if (Data.GetDataWarpExits(my_MapId, num))
				{
					int dataWarp = Data.GetDataWarp(my_MapId, num, DataStructure.Type_Warp._MapId2);
					int dataWarp2 = Data.GetDataWarp(my_MapId, num, DataStructure.Type_Warp._X);
					int dataWarp3 = Data.GetDataWarp(my_MapId, num, DataStructure.Type_Warp._Y);
					int gocnhin = 0;
					DataStructure.BattleGates_key key = default(DataStructure.BattleGates_key);
					key._MapId = my_MapId;
					key._WarpId = num;
					bool flag;
					if (!(flag = Data.Data_BattleGates.ContainsKey(key)))
					{
						if (_client._My_IdLeader == 0 | _client._My_IdLeader == _client._My_Id)
						{
							Data.Warped(_client._My_Id, my_MapId, dataWarp, dataWarp2, dataWarp3, gocnhin);
						}
						if (_client._My_IdLeader > 0 & _client._My_IdLeader == _client._My_Id)
						{
							if (_client._My_IdMem1 > 0)
							{
								Data.Warped(_client._My_IdMem1, my_MapId, dataWarp, dataWarp2, dataWarp3, gocnhin);
							}
							if (_client._My_IdMem2 > 0)
							{
								Data.Warped(_client._My_IdMem2, my_MapId, dataWarp, dataWarp2, dataWarp3, gocnhin);
							}
							if (_client._My_IdMem3 > 0)
							{
								Data.Warped(_client._My_IdMem3, my_MapId, dataWarp, dataWarp2, dataWarp3, gocnhin);
							}
							if (_client._My_IdMem4 > 0)
							{
								Data.Warped(_client._My_IdMem4, my_MapId, dataWarp, dataWarp2, dataWarp3, gocnhin);
							}
						}
					}
					else
					{
						if (flag)
						{
							DataStructure.BattleGates battleGates = Data.Data_BattleGates[key];
							int diahinh = battleGates._Diahinh;
							DataStructure.TeamDeffender teamdef = default(DataStructure.TeamDeffender);
							teamdef._id1 = battleGates._1;
							teamdef._id2 = battleGates._2;
							teamdef._id3 = battleGates._3;
							teamdef._id4 = battleGates._4;
							teamdef._id5 = battleGates._5;
							teamdef._id6 = battleGates._6;
							teamdef._id7 = battleGates._7;
							teamdef._id8 = battleGates._8;
							teamdef._id9 = battleGates._9;
							teamdef._id10 = battleGates._10;
							_client._My_WarpingId = num;
							new TheBattle(_client._My_Id, teamdef, diahinh);
						}
					}
				}
				else
				{
					_client.EndTalk();
				}
			}
		}
		public static void H9(Client _client, byte[] packet)
		{
			_client.SelectMenu = (int)packet[6];
		}
		public static void M18017(Client _client)
		{
			if ((_client.idtalking == 2 | _client.idtalking == 3 | _client.idtalking == 5 | _client.idtalking == 6) && Data.HomdoGetSlotExits(_client.conn, 32012) != 0)
			{
				Data.HomdoRemoveItem(_client._My_Id, 32012, 1);
				if (_client.idtalking == 2 | _client.idtalking == 3)
				{
					Data.HomdoAddItem(_client._My_Id, 26012, 1);
				}
				else
				{
					Data.HomdoAddItem(_client._My_Id, 26031, 1);
				}
			}
		}
	}
}
