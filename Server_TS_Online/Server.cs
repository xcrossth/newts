using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Net.Sockets;
using System.Windows.Forms;
namespace Server_TS_Online
{
	public class Server
	{
		public static ListView ListView_Client;
		public static int PerEXP;
		public static int percent_item1;
		public static int percent_item2;
		public static int percent_item3;
		public static int percent_item4;
		public static int percent_item5;
		public static int percent_item6;
		public static Dictionary<int, Client> Clients;
		public static int IdBattleCount;
		public static Dictionary<int, TheBattle> TheBattles;
		static Server()
		{
			Server.ListView_Client = new ListView();
			Server.PerEXP = 1;
			Server.percent_item1 = 200;
			Server.percent_item2 = 150;
			Server.percent_item3 = 100;
			Server.percent_item4 = 9;
			Server.percent_item5 = 6;
			Server.percent_item6 = 3;
			Server.Clients = new Dictionary<int, Client>();
			Server.IdBattleCount = 1;
			Server.TheBattles = new Dictionary<int, TheBattle>();
		}
		public static void ServerSend_PlayerOffline(int _id)
		{
			Server.SendToAllClient(_id, "F44406000D04" + Class5.smethod_12(_id));
			Server.SendToAllClient(_id, "F44406000101" + Class5.smethod_12(_id));
		}
		public static void ServerSend_PlayerOnline(int ID, int sex, int Thuoctinh, int lv, int ghost, int god, int mapid, int mapx, int mapy, int gocnhin, int hair, string color, int mu, int ao, int vukhi, int tay, int chan, int dacthu, int reborn, int job, string name, int IdPetXuatChien, int Pk, int ThamChien)
		{
			string text = "";
			if (mu > 0)
			{
				text += Class5.smethod_11(mu);
			}
			if (ao > 0)
			{
				text += Class5.smethod_11(ao);
			}
			if (vukhi > 0)
			{
				text += Class5.smethod_11(vukhi);
			}
			if (tay > 0)
			{
				text += Class5.smethod_11(tay);
			}
			if (chan > 0)
			{
				text += Class5.smethod_11(chan);
			}
			if (dacthu > 0)
			{
				text += Class5.smethod_11(dacthu);
			}
			Server.SendToAllClient(ID, string.Concat(checked(new string[]
			{
				"F444",
				Class5.smethod_11(36 + (int)Math.Round((double)text.Length / 2.0) + name.Length),
				"03",
				Class5.smethod_12(ID),
				sex.ToString("X2"),
				Thuoctinh.ToString("X2"),
				lv.ToString("X2"),
				ghost.ToString("X2"),
				god.ToString("X2"),
				Class5.smethod_11(mapid),
				Class5.smethod_11(mapx),
				Class5.smethod_11(mapy),
				gocnhin.ToString("X2"),
				Class5.smethod_11(hair),
				color,
				((int)Math.Round((double)text.Length / 4.0)).ToString("X2"),
				text,
				"000000000006",
				reborn.ToString("X2"),
				job.ToString("X2"),
				Class5.smethod_13(name)
			})));
		}
		public static void ServerSend_PlayerGotoMap(int _id, int MapidTo, int x, int y, int gocnhin)
		{
			Server.SendToAllClientMapid(_id, string.Concat(new string[]
			{
				"F4440D000C",
				Class5.smethod_12(_id),
				Class5.smethod_11(MapidTo),
				Class5.smethod_11(x),
				Class5.smethod_11(y),
				Class5.smethod_11(gocnhin)
			}));
		}
		public static void ServerSend_EquitItem(int _id, int iditem)
		{
			Server.SendToAllClient(_id, "F44408000502" + Class5.smethod_12(_id) + Class5.smethod_11(iditem));
		}
		public static void ServerSend_UnEquitItem(int _id, int iditem)
		{
			Server.SendToAllClient(_id, "F44408000501" + Class5.smethod_12(_id) + Class5.smethod_11(iditem));
		}
		public static void SendPalyerOnline(int _id)
		{
			if (!Server.Clients.ContainsKey(_id))
			{
				return;
			}
			OleDbConnection arg_1E_0 = Server.Clients[_id].conn;
			int my_MapId = Server.Clients[_id]._My_MapId;
			string text = "";
			checked
			{
				try
				{
					IEnumerator enumerator = Server.ListView_Client.Items.GetEnumerator();
					while (enumerator.MoveNext())
					{
						ListViewItem listViewItem = (ListViewItem)enumerator.Current;
						try
						{
							Client client = (Client)listViewItem.Tag;
							int my_Id = client._My_Id;
							if (my_Id != _id & client._socket.Connected)
							{
								string text2 = "";
								int num = Data.TrangbiGetDataItem(client.conn, 1, DataStructure.Type_Homdo._ID);
								int num2 = Data.TrangbiGetDataItem(client.conn, 2, DataStructure.Type_Homdo._ID);
								int num3 = Data.TrangbiGetDataItem(client.conn, 3, DataStructure.Type_Homdo._ID);
								int num4 = Data.TrangbiGetDataItem(client.conn, 4, DataStructure.Type_Homdo._ID);
								int num5 = Data.TrangbiGetDataItem(client.conn, 5, DataStructure.Type_Homdo._ID);
								int num6 = Data.TrangbiGetDataItem(client.conn, 6, DataStructure.Type_Homdo._ID);
								if (num > 0)
								{
									text2 += Class5.smethod_11(num);
								}
								if (num2 > 0)
								{
									text2 += Class5.smethod_11(num2);
								}
								if (num3 > 0)
								{
									text2 += Class5.smethod_11(num3);
								}
								if (num4 > 0)
								{
									text2 += Class5.smethod_11(num4);
								}
								if (num5 > 0)
								{
									text2 += Class5.smethod_11(num5);
								}
								if (num6 > 0)
								{
									text2 += Class5.smethod_11(num6);
								}
								int my_Dongtac = client._My_Dongtac;
								int my_Horse = client._My_Horse;
								text = string.Concat(new string[]
								{
									text,
									"F444",
									Class5.smethod_11(36 + (int)Math.Round((double)text2.Length / 2.0) + client._My_Name.Length),
									"04",
									Class5.smethod_12(my_Id),
									client._My_Sex.ToString("X2"),
									client._My_Thuoctinh.ToString("X2"),
									client._My_Lv.ToString("X2"),
									client._My_Ghost.ToString("X2"),
									client._My_God.ToString("X2"),
									Class5.smethod_11(client._My_MapId),
									Class5.smethod_11(client._My_MapX),
									Class5.smethod_11(client._My_MapY),
									client._My_Gocnhin.ToString("X2"),
									Class5.smethod_11(client._My_Hair),
									client._My_Color,
									((int)Math.Round((double)text2.Length / 4.0)).ToString("X2"),
									text2,
									"000000000006",
									client._My_Reborn.ToString("X2"),
									client._My_Job.ToString("X2"),
									Class5.smethod_13(client._My_Name)
								});
								if (client._My_MapId == my_MapId)
								{
									string text3 = "";
									int num7 = 1;
									do
									{
										if (Server.Clients.ContainsKey(my_Id) && Server.Clients[my_Id].ListPet.ContainsKey(num7))
										{
											DataStructure._MyPet myPet = Server.Clients[my_Id].ListPet[num7];
											int id = myPet._Id;
											if (id > 0)
											{
												string name = myPet._Name;
												int quest = myPet._Quest;
												if (id == my_Horse)
												{
													text3 = string.Concat(new string[]
													{
														text3,
														num7.ToString("X2"),
														Class5.smethod_12(id),
														"0000000001",
														quest.ToString("X2"),
														name.Length.ToString("X2"),
														Class5.smethod_13(name)
													});
												}
												else
												{
													text3 = string.Concat(new string[]
													{
														text3,
														num7.ToString("X2"),
														Class5.smethod_12(id),
														"0000000000",
														quest.ToString("X2"),
														name.Length.ToString("X2"),
														Class5.smethod_13(name)
													});
												}
											}
										}
										num7++;
									}
									while (num7 <= 4);
									if (text3.Length > 0)
									{
										text3 = string.Concat(new string[]
										{
											"F444",
											Class5.smethod_11(6 + (int)Math.Round((double)text3.Length / 2.0)),
											"0F07",
											Class5.smethod_12(my_Id),
											text3
										});
										text += text3;
									}
								}
								if (client._My_IdBattle > 0)
								{
									text = text + "F4440A000B0402" + Class5.smethod_12(my_Id) + "000003";
								}
								if (my_Horse == 0)
								{
									if (my_Dongtac > 0)
									{
										text = text + "F44407002002" + Class5.smethod_12(my_Id) + my_Dongtac.ToString("X2");
									}
								}
								else
								{
									if (my_Horse > 0)
									{
										text = string.Concat(new string[]
										{
											text,
											"F4440E000F05",
											Class5.smethod_12(my_Id),
											Class5.smethod_12(my_Horse),
											"00000000"
										});
									}
								}
							}
							else
							{
								if (my_Id == _id && client._My_MapId == my_MapId)
								{
									string text4 = "";
									int my_Horse2 = client._My_Horse;
									int num8 = 1;
									do
									{
										int num9 = Data.PetGetData(client.conn, num8, DataStructure.Type_Pet._ID);
										if (num9 > 0)
										{
											string text5 = Data.PetGetDataName(client.conn, num8, DataStructure.Type_Pet._Name);
											int num10 = Data.PetGetData(client.conn, num8, DataStructure.Type_Pet._Quest);
											if (num9 == my_Horse2)
											{
												text4 = string.Concat(new string[]
												{
													text4,
													num8.ToString("X2"),
													Class5.smethod_12(num9),
													"0000000001",
													num10.ToString("X2"),
													text5.Length.ToString("X2"),
													Class5.smethod_13(text5)
												});
											}
											else
											{
												text4 = string.Concat(new string[]
												{
													text4,
													num8.ToString("X2"),
													Class5.smethod_12(num9),
													"0000000000",
													num10.ToString("X2"),
													text5.Length.ToString("X2"),
													Class5.smethod_13(text5)
												});
											}
										}
										num8++;
									}
									while (num8 <= 4);
									if (text4.Length > 0)
									{
										text4 = string.Concat(new string[]
										{
											"F444",
											Class5.smethod_11(6 + (int)Math.Round((double)text4.Length / 2.0)),
											"0F07",
											Class5.smethod_12(_id),
											text4
										});
										Server.SendToAllClientMapid(_id, text4);
									}
								}
							}
						}
						catch (Exception expr_7B2)
						{
							ProjectData.SetProjectError(expr_7B2);
							ProjectData.ClearProjectError();
						}
					}
				}
				finally
				{
					
				}
				if (text.Length > 0)
				{
					Server.SendToClient(_id, text);
				}
			}
		}
		public static void SendPlayerOnMap(int _id)
		{
			if (!Server.Clients.ContainsKey(_id))
			{
				return;
			}
			OleDbConnection arg_1E_0 = Server.Clients[_id].conn;
			int my_MapId = Server.Clients[_id]._My_MapId;
			string text = "";
			checked
			{
				try
				{
					IEnumerator enumerator = Server.ListView_Client.Items.GetEnumerator();
					while (enumerator.MoveNext())
					{
						ListViewItem listViewItem = (ListViewItem)enumerator.Current;
						try
						{
							Client client = (Client)listViewItem.Tag;
							int my_Id = client._My_Id;
							int my_MapId2 = client._My_MapId;
							if (my_Id != _id & my_MapId2 == my_MapId & client._socket.Connected)
							{
								int my_MapX = client._My_MapX;
								int my_MapY = client._My_MapY;
								text = string.Concat(new string[]
								{
									text,
									"F4440B0007",
									Class5.smethod_12(my_Id),
									Class5.smethod_11(my_MapId2),
									Class5.smethod_11(my_MapX),
									Class5.smethod_11(my_MapY)
								});
								string text2 = "";
								int num = Data.TrangbiGetDataItem(client.conn, 1, DataStructure.Type_Homdo._ID);
								int num2 = Data.TrangbiGetDataItem(client.conn, 2, DataStructure.Type_Homdo._ID);
								int num3 = Data.TrangbiGetDataItem(client.conn, 3, DataStructure.Type_Homdo._ID);
								int num4 = Data.TrangbiGetDataItem(client.conn, 4, DataStructure.Type_Homdo._ID);
								int num5 = Data.TrangbiGetDataItem(client.conn, 5, DataStructure.Type_Homdo._ID);
								int num6 = Data.TrangbiGetDataItem(client.conn, 6, DataStructure.Type_Homdo._ID);
								if (client._My_IdBattle > 0)
								{
									text = text + "F4440A000B0402" + Class5.smethod_12(my_Id) + "000003";
								}
								if (num > 0)
								{
									text2 += Class5.smethod_11(num);
								}
								if (num2 > 0)
								{
									text2 += Class5.smethod_11(num2);
								}
								if (num3 > 0)
								{
									text2 += Class5.smethod_11(num3);
								}
								if (num4 > 0)
								{
									text2 += Class5.smethod_11(num4);
								}
								if (num5 > 0)
								{
									text2 += Class5.smethod_11(num5);
								}
								if (num6 > 0)
								{
									text2 += Class5.smethod_11(num6);
								}
								text = string.Concat(new string[]
								{
									text,
									"F444",
									Class5.smethod_11((int)Math.Round(unchecked(6.0 + (double)text2.Length / 2.0))),
									"0500",
									Class5.smethod_12(my_Id),
									text2
								});
								int my_Dongtac = client._My_Dongtac;
								int my_Horse = client._My_Horse;
								string text3 = "";
								int num7 = 1;
								do
								{
									if (Server.Clients.ContainsKey(my_Id) && Server.Clients[my_Id].ListPet.ContainsKey(num7))
									{
										DataStructure._MyPet myPet = Server.Clients[my_Id].ListPet[num7];
										int id = myPet._Id;
										if (id > 0)
										{
											string name = myPet._Name;
											int quest = myPet._Quest;
											if (id == my_Horse)
											{
												text3 = string.Concat(new string[]
												{
													text3,
													num7.ToString("X2"),
													Class5.smethod_12(id),
													"0000000001",
													quest.ToString("X2"),
													name.Length.ToString("X2"),
													Class5.smethod_13(name)
												});
											}
											else
											{
												text3 = string.Concat(new string[]
												{
													text3,
													num7.ToString("X2"),
													Class5.smethod_12(id),
													"0000000000",
													quest.ToString("X2"),
													name.Length.ToString("X2"),
													Class5.smethod_13(name)
												});
											}
										}
									}
									num7++;
								}
								while (num7 <= 4);
								if (text3.Length > 0)
								{
									text3 = string.Concat(new string[]
									{
										"F444",
										Class5.smethod_11(6 + (int)Math.Round((double)text3.Length / 2.0)),
										"0F07",
										Class5.smethod_12(my_Id),
										text3
									});
									text += text3;
								}
								if (my_Horse == 0)
								{
									if (my_Dongtac > 0)
									{
										text = text + "F44407002002" + Class5.smethod_12(my_Id) + my_Dongtac.ToString("X2");
									}
								}
								else
								{
									if (my_Horse > 0)
									{
										text = string.Concat(new string[]
										{
											text,
											"F4440E000F05",
											Class5.smethod_12(my_Id),
											Class5.smethod_12(my_Horse),
											"00000000"
										});
									}
								}
							}
							else
							{
								if (my_Id == _id & my_MapId2 == my_MapId)
								{
									string text4 = "";
									int my_Horse2 = client._My_Horse;
									int num8 = 1;
									do
									{
										int num9 = Data.PetGetData(client.conn, num8, DataStructure.Type_Pet._ID);
										if (num9 > 0)
										{
											string text5 = Data.PetGetDataName(client.conn, num8, DataStructure.Type_Pet._Name);
											int num10 = Data.PetGetData(client.conn, num8, DataStructure.Type_Pet._Quest);
											if (num9 == my_Horse2)
											{
												text4 = string.Concat(new string[]
												{
													text4,
													num8.ToString("X2"),
													Class5.smethod_12(num9),
													"0000000001",
													num10.ToString("X2"),
													text5.Length.ToString("X2"),
													Class5.smethod_13(text5)
												});
											}
											else
											{
												text4 = string.Concat(new string[]
												{
													text4,
													num8.ToString("X2"),
													Class5.smethod_12(num9),
													"0000000000",
													num10.ToString("X2"),
													text5.Length.ToString("X2"),
													Class5.smethod_13(text5)
												});
											}
										}
										num8++;
									}
									while (num8 <= 4);
									if (text4.Length > 0)
									{
										text4 = string.Concat(new string[]
										{
											"F444",
											Class5.smethod_11(6 + (int)Math.Round((double)text4.Length / 2.0)),
											"0F07",
											Class5.smethod_12(_id),
											text4
										});
										Server.SendToAllClientMapid(_id, text4);
									}
								}
							}
						}
						catch (Exception expr_6C1)
						{
							ProjectData.SetProjectError(expr_6C1);
							ProjectData.ClearProjectError();
						}
					}
				}
				finally
				{
					
				}
				if (text.Length > 0)
				{
					Server.SendToClient(_id, text);
				}
			}
		}
		public static void SendAllParty(int _id)
		{
			if (!Server.Clients.ContainsKey(_id))
			{
				return;
			}
			OleDbConnection arg_1E_0 = Server.Clients[_id].conn;
			int my_MapId = Server.Clients[_id]._My_MapId;
			int my_IdLeader = Server.Clients[_id]._My_IdLeader;
			checked
			{
				try
				{
					IEnumerator enumerator = Server.ListView_Client.Items.GetEnumerator();
					while (enumerator.MoveNext())
					{
						ListViewItem listViewItem = (ListViewItem)enumerator.Current;
						try
						{
							Client client = (Client)listViewItem.Tag;
							int my_Id = client._My_Id;
							int my_MapId2 = client._My_MapId;
							int my_IdLeader2 = client._My_IdLeader;
							if ((my_MapId2 == my_MapId & client._socket.Connected) && (my_IdLeader2 > 0 & my_IdLeader2 == my_Id))
							{
								int my_IdMem = client._My_IdMem1;
								int my_IdMem2 = client._My_IdMem2;
								int my_IdMem3 = client._My_IdMem3;
								int my_IdMem4 = client._My_IdMem4;
								int my_IdQS = client._My_IdQS;
								if (my_IdQS > 0)
								{
									Server.SendToClient(_id, "F44406000D07" + Class5.smethod_12(my_IdQS));
									Server.SendToAllClientMapid(_id, "F44406000D07" + Class5.smethod_12(my_IdQS));
									Server.SendToClient(_id, "F44406000D0B" + Class5.smethod_12(my_IdQS));
									Server.SendToAllClientMapid(_id, "F44406000D0B" + Class5.smethod_12(my_IdQS));
								}
								string text = "";
								if (my_IdMem > 0)
								{
									text += Class5.smethod_12(my_IdMem);
								}
								if (my_IdMem2 > 0)
								{
									text += Class5.smethod_12(my_IdMem2);
								}
								if (my_IdMem3 > 0)
								{
									text += Class5.smethod_12(my_IdMem3);
								}
								if (my_IdMem4 > 0)
								{
									text += Class5.smethod_12(my_IdMem4);
								}
								if (text.Length > 0)
								{
									string text2 = "0D06" + Class5.smethod_12(my_IdLeader2) + ((int)Math.Round((double)text.Length / 8.0)).ToString("X2") + text;
									text2 = "F444" + Class5.smethod_11((int)Math.Round((double)text2.Length / 2.0)) + text2;
									Server.SendToClient(_id, text2);
									if (my_IdLeader2 == my_IdLeader)
									{
										Server.SendToAllClientMapid(_id, text2);
									}
								}
							}
						}
						catch (Exception expr_222)
						{
							ProjectData.SetProjectError(expr_222);
							ProjectData.ClearProjectError();
						}
					}
				}
				finally
				{
					
				}
			}
		}
		public static void SendToServer(string packet)
		{
			try
			{
				IEnumerator enumerator = Server.ListView_Client.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem listViewItem = (ListViewItem)enumerator.Current;
					try
					{
						Client client = (Client)listViewItem.Tag;
						if (client._socket.Connected)
						{
							byte[] array = Class5.smethod_5(Class5.smethod_4(packet));
							if (client._socket.Connected)
							{
								client._socket.Send(array, 0, array.Length, SocketFlags.None);
							}
						}
					}
					catch (Exception expr_65)
					{
						ProjectData.SetProjectError(expr_65);
						ProjectData.ClearProjectError();
					}
				}
			}
			finally
			{
				
			}
		}
		public static void SendToClient(int _Id, string packet)
		{
			try
			{
				if (Server.ListView_Client.Items.ContainsKey(_Id.ToString()))
				{
					Client client = (Client)Server.ListView_Client.Items[_Id.ToString()].Tag;
					byte[] array = Class5.smethod_5(Class5.smethod_4(packet));
					if (client._socket.Connected)
					{
						client._socket.Send(array, 0, array.Length, SocketFlags.None);
					}
				}
			}
			catch (Exception expr_67)
			{
				ProjectData.SetProjectError(expr_67);
				ProjectData.ClearProjectError();
			}
		}
		public static void SendToAllClient(int _id, string packet)
		{
			try
			{
				IEnumerator enumerator = Server.ListView_Client.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem listViewItem = (ListViewItem)enumerator.Current;
					try
					{
						Client client = (Client)listViewItem.Tag;
						if (client._My_Id != _id & client._socket.Connected)
						{
							byte[] array = Class5.smethod_5(Class5.smethod_4(packet));
							if (client._socket.Connected)
							{
								client._socket.Send(array, 0, array.Length, SocketFlags.None);
							}
						}
					}
					catch (Exception expr_72)
					{
						ProjectData.SetProjectError(expr_72);
						ProjectData.ClearProjectError();
					}
				}
			}
			finally
			{
				
			}
		}
		public static void SendToAllClientMapid(int _Id, string packet)
		{
			try
			{
				IEnumerator enumerator = Server.ListView_Client.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem listViewItem = (ListViewItem)enumerator.Current;
					try
					{
						Client client = (Client)listViewItem.Tag;
						if (client._socket.Connected && Conversions.ToBoolean(Operators.AndObject(client._My_Id != _Id, Operators.CompareObjectEqual(client._My_MapId, NewLateBinding.LateGet(Server.ListView_Client.Items[_Id.ToString()].Tag, null, "_My_MapId", new object[0], null, null, null), false))))
						{
							byte[] array = Class5.smethod_5(Class5.smethod_4(packet));
							if (client._socket.Connected)
							{
								client._socket.Send(array, 0, array.Length, SocketFlags.None);
							}
						}
					}
					catch (Exception expr_C8)
					{
						ProjectData.SetProjectError(expr_C8);
						ProjectData.ClearProjectError();
					}
				}
			}
			finally
			{
				
			}
		}
		public static void SendToAllMapid(int _MapId, string packet)
		{
			try
			{
				IEnumerator enumerator = Server.ListView_Client.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem listViewItem = (ListViewItem)enumerator.Current;
					try
					{
						Client client = (Client)listViewItem.Tag;
						if (client._My_MapId == _MapId & client._socket.Connected)
						{
							byte[] array = Class5.smethod_5(Class5.smethod_4(packet));
							if (client._socket.Connected)
							{
								client._socket.Send(array, 0, array.Length, SocketFlags.None);
							}
						}
					}
					catch (Exception expr_6F)
					{
						ProjectData.SetProjectError(expr_6F);
						ProjectData.ClearProjectError();
					}
				}
			}
			finally
			{
				
			}
		}
	}
}
