using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
namespace Server_TS_Online
{
	public class Data
	{
		private static Random random_0;
		private static Random random_1;
		private static string string_0;
		public static OleDbConnection conn_Account;
		private static Random random_2;
		public static string _Status;
		public static bool LoadedData;
		public static Dictionary<int, DataStructure.Npcs> Data_Npcs;
		public static Dictionary<int, DataStructure.Items> Data_Items;
		public static Dictionary<int, DataStructure.Skills> Data_Skills;
		public static Dictionary<DataStructure.Key_Warps, DataStructure.Warps> Data_Warps;
		public static Dictionary<DataStructure.Key_Talk, DataStructure._Talk> Data_Talks;
		public static Dictionary<int, DataStructure._Texp> Texps;
		public static Dictionary<DataStructure.BattleGates_key, DataStructure.BattleGates> Data_BattleGates;
		private static Random random_3;
		public static Dictionary<DataStructure.Key_NpcOnMap, DataStructure._NpcOnMap> NpcOnMap;
		public static ArrayList _ListKeysNpcOnMap;
		public static ArrayList _ListKeysItemOnMap;
		public static ArrayList _ListKeysItemDropOnMap;
		public static Dictionary<DataStructure.Key_ItemOnMap, DataStructure._ItemOnMap> ItemOnMap;
		public static Dictionary<DataStructure.Key_ItemDropOnMap, DataStructure._ItemDropOnMap> ItemDropOnMap;
		public static Dictionary<int, string[]> FormulaHP;
		public static Dictionary<int, string[]> dictionary_0;
		public static Dictionary<int, string[]> FormulaSP;
		public static Dictionary<int, string[]> dictionary_1;
		[MethodImpl(MethodImplOptions.NoOptimization)]
		static Data()
		{
			Data.random_0 = new Random();
			Data.random_1 = new Random();
			Data.string_0 = Class1.Form0_0.Info.DirectoryPath + "\\CSDL\\Account.accdb";
			Data.conn_Account = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Data.string_0 + ";Persist Security Info=False;");
			Data.random_2 = new Random();
			Data._Status = "";
			Data.LoadedData = false;
			Data.Data_Npcs = new Dictionary<int, DataStructure.Npcs>();
			Data.Data_Items = new Dictionary<int, DataStructure.Items>();
			Data.Data_Skills = new Dictionary<int, DataStructure.Skills>();
			Data.Data_Warps = new Dictionary<DataStructure.Key_Warps, DataStructure.Warps>();
			Data.Data_Talks = new Dictionary<DataStructure.Key_Talk, DataStructure._Talk>();
			Data.Texps = new Dictionary<int, DataStructure._Texp>();
			Data.Data_BattleGates = new Dictionary<DataStructure.BattleGates_key, DataStructure.BattleGates>();
			Data.random_3 = new Random();
			Data.NpcOnMap = new Dictionary<DataStructure.Key_NpcOnMap, DataStructure._NpcOnMap>();
			Data._ListKeysNpcOnMap = new ArrayList();
			Data._ListKeysItemOnMap = new ArrayList();
			Data._ListKeysItemDropOnMap = new ArrayList();
			Data.ItemOnMap = new Dictionary<DataStructure.Key_ItemOnMap, DataStructure._ItemOnMap>();
			Data.ItemDropOnMap = new Dictionary<DataStructure.Key_ItemDropOnMap, DataStructure._ItemDropOnMap>();
			Data.FormulaHP = new Dictionary<int, string[]>();
			Data.dictionary_0 = new Dictionary<int, string[]>();
			Data.FormulaSP = new Dictionary<int, string[]>();
			Data.dictionary_1 = new Dictionary<int, string[]>();
		}
		public static string GetRandomPointPet(int IdPet)
		{
			string result = "Atk";
			int dataNpc = Data.GetDataNpc(IdPet, DataStructure.Type_Npc._Int);
			int dataNpc2 = Data.GetDataNpc(IdPet, DataStructure.Type_Npc._Atk);
			int dataNpc3 = Data.GetDataNpc(IdPet, DataStructure.Type_Npc._Def);
			int dataNpc4 = Data.GetDataNpc(IdPet, DataStructure.Type_Npc._Hpx);
			int dataNpc5 = Data.GetDataNpc(IdPet, DataStructure.Type_Npc._Spx);
			int dataNpc6 = Data.GetDataNpc(IdPet, DataStructure.Type_Npc._Agi);
			checked
			{
				int num = dataNpc + dataNpc2 + dataNpc3 + dataNpc4 + dataNpc5 + dataNpc6;
				DataSet dataSet = new DataSet();
				dataSet.Tables.Add("Table").Columns.Add("Point").DataType = Type.GetType("System.Int32");
				dataSet.Tables["Table"].Columns.Add("Random").DataType = Type.GetType("System.Int32");
				dataSet.Tables["Table"].Columns.Add("Type").DataType = Type.GetType("System.String");
				DataTable dataTable = dataSet.Tables["Table"];
				dataTable.Rows.Add(new object[]
				{
					(int)Math.Round(unchecked((double)dataNpc / (double)num * 1000.0)),
					Data.random_0.Next(1, 999),
					DataStructure.Type_Npc._Int
				});
				dataTable.Rows.Add(new object[]
				{
					(int)Math.Round(unchecked((double)dataNpc2 / (double)num * 1000.0)),
					Data.random_0.Next(1, 999),
					DataStructure.Type_Npc._Atk
				});
				dataTable.Rows.Add(new object[]
				{
					(int)Math.Round(unchecked((double)dataNpc3 / (double)num * 1000.0)),
					Data.random_0.Next(1, 999),
					DataStructure.Type_Npc._Def
				});
				dataTable.Rows.Add(new object[]
				{
					(int)Math.Round(unchecked((double)dataNpc4 / (double)num * 1000.0)),
					Data.random_0.Next(1, 999),
					DataStructure.Type_Npc._Hpx
				});
				dataTable.Rows.Add(new object[]
				{
					(int)Math.Round(unchecked((double)dataNpc5 / (double)num * 1000.0)),
					Data.random_0.Next(1, 999),
					DataStructure.Type_Npc._Spx
				});
				dataTable.Rows.Add(new object[]
				{
					(int)Math.Round(unchecked((double)dataNpc6 / (double)num * 1000.0)),
					Data.random_0.Next(1, 999),
					DataStructure.Type_Npc._Agi
				});
				DataView dataView = new DataView(dataTable);
				dataView.Sort = "Point ASC, Random DESC";
				Conversions.ToInteger(dataView[5].Row[0]);
				int num2 = Conversions.ToInteger(dataView[4].Row[0]);
				int num3 = Conversions.ToInteger(dataView[3].Row[0]);
				int num4 = Conversions.ToInteger(dataView[2].Row[0]);
				int num5 = Conversions.ToInteger(dataView[1].Row[0]);
				int num6 = Conversions.ToInteger(dataView[0].Row[0]);
				int num7 = Data.random_0.Next(1, 1000);
				if (num7 >= 0 & num7 <= num6)
				{
					result = Conversions.ToString(dataView[0].Row["Type"]);
				}
				else
				{
					if (num7 > num6 & num7 <= num6 + num5)
					{
						result = Conversions.ToString(dataView[1].Row["Type"]);
					}
					else
					{
						if (num7 > num6 + num5 & num7 <= num6 + num5 + num4)
						{
							result = Conversions.ToString(dataView[2].Row["Type"]);
						}
						else
						{
							if (num7 > num6 + num5 + num4 & num7 <= num6 + num5 + num4 + num3)
							{
								result = Conversions.ToString(dataView[3].Row["Type"]);
							}
							else
							{
								if (num7 > num6 + num5 + num4 + num3 & num7 <= num6 + num5 + num4 + num3 + num2)
								{
									result = Conversions.ToString(dataView[4].Row["Type"]);
								}
								else
								{
									if (num7 > num6 + num5 + num4 + num3 + num2)
									{
										result = Conversions.ToString(dataView[5].Row["Type"]);
									}
								}
							}
						}
					}
				}
				return result;
			}
		}
		public static bool PlayerGetIdExits(int _id)
		{
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Player Where Id=" + Conversions.ToString(_id), Data.conn_Account);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			return oleDbDataReader.Read();
		}
		public static void PlayerUpdateDataId(int _id, string type, int value)
		{
			string cmdText = string.Concat(new string[]
			{
				"UPDATE Player SET [",
				type,
				"] = ",
				Conversions.ToString(value),
				" WHERE Id = ",
				Conversions.ToString(_id)
			});
			OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Data.conn_Account);
			oleDbCommand.ExecuteNonQuery();
			checked
			{
				if (Server.ListView_Client.Items.ContainsKey(_id.ToString()))
				{
					Client client = (Client)Server.ListView_Client.Items[_id.ToString()].Tag;
					if (client._socket.Connected)
					{
						string text;
						if (value >= 0)
						{
							text = "01";
						}
						else
						{
							text = "02";
							value *= -1;
						}
						if (Operators.CompareString(type, DataStructure.Type_Player._Id, false) == 0)
						{
							client._My_Id = value;
						}
						else
						{
							if (Operators.CompareString(type, DataStructure.Type_Player._Name, false) == 0)
							{
								client._My_Name = Conversions.ToString(value);
							}
							else
							{
								if (Operators.CompareString(type, DataStructure.Type_Player._Lv, false) == 0)
								{
									client._My_Lv = value;
									client.Sendpacket(string.Concat(new string[]
									{
										"F4440C000801",
										DataStructure.Type_Status._lv,
										text,
										Class5.smethod_12(value),
										"00000000"
									}));
									Data.UpdateStatusSendtoParty(_id, DataStructure.Type_Status._lv, value);
								}
								else
								{
									if (Operators.CompareString(type, DataStructure.Type_Player._Hp, false) == 0)
									{
										client._My_Hp = value;
										client.Sendpacket(string.Concat(new string[]
										{
											"F4440C000801",
											DataStructure.Type_Status._Hp,
											text,
											Class5.smethod_12(value),
											"00000000"
										}));
										Data.UpdateStatusSendtoParty(_id, DataStructure.Type_Status._Hp, value);
									}
									else
									{
										if (Operators.CompareString(type, DataStructure.Type_Player._Hpmax, false) == 0)
										{
											client._My_HpMax = value;
										}
										else
										{
											if (Operators.CompareString(type, DataStructure.Type_Player._Sp, false) == 0)
											{
												client._My_Sp = value;
												client.Sendpacket(string.Concat(new string[]
												{
													"F4440C000801",
													DataStructure.Type_Status._Sp,
													text,
													Class5.smethod_12(value),
													"00000000"
												}));
											}
											else
											{
												if (Operators.CompareString(type, DataStructure.Type_Player._Spmax, false) == 0)
												{
													client._My_SpMax = value;
												}
												else
												{
													if (Operators.CompareString(type, DataStructure.Type_Player._Point, false) == 0)
													{
														client._My_Point = value;
														client.Sendpacket(string.Concat(new string[]
														{
															"F4440C000801",
															DataStructure.Type_Status._Point,
															text,
															Class5.smethod_12(value),
															"00000000"
														}));
													}
													else
													{
														if (Operators.CompareString(type, DataStructure.Type_Player._SkillPoint, false) == 0)
														{
															client._My_SkillPoint = value;
															client.Sendpacket(string.Concat(new string[]
															{
																"F4440C000801",
																DataStructure.Type_Status._SkillPoint,
																text,
																Class5.smethod_12(value),
																"00000000"
															}));
														}
														else
														{
															if (Operators.CompareString(type, DataStructure.Type_Player._Int, false) == 0)
															{
																client._My_Int = value;
																client.Sendpacket(string.Concat(new string[]
																{
																	"F4440C000801",
																	DataStructure.Type_Status._Int,
																	text,
																	Class5.smethod_12(value),
																	"00000000"
																}));
															}
															else
															{
																if (Operators.CompareString(type, DataStructure.Type_Player._Atk, false) == 0)
																{
																	client._My_Atk = value;
																	client.Sendpacket(string.Concat(new string[]
																	{
																		"F4440C000801",
																		DataStructure.Type_Status._atk,
																		text,
																		Class5.smethod_12(value),
																		"00000000"
																	}));
																}
																else
																{
																	if (Operators.CompareString(type, DataStructure.Type_Player._Def, false) == 0)
																	{
																		client._My_Def = value;
																		client.Sendpacket(string.Concat(new string[]
																		{
																			"F4440C000801",
																			DataStructure.Type_Status._def,
																			text,
																			Class5.smethod_12(value),
																			"00000000"
																		}));
																	}
																	else
																	{
																		if (Operators.CompareString(type, DataStructure.Type_Player._Hpx, false) == 0)
																		{
																			client._My_Hpx = value;
																			client.Sendpacket(string.Concat(new string[]
																			{
																				"F4440C000801",
																				DataStructure.Type_Status._hpx,
																				text,
																				Class5.smethod_12(value),
																				"00000000"
																			}));
																			Data.UpdateStatusSendtoParty(_id, DataStructure.Type_Status._hpx, value);
																		}
																		else
																		{
																			if (Operators.CompareString(type, DataStructure.Type_Player._Spx, false) == 0)
																			{
																				client._My_Spx = value;
																				client.Sendpacket(string.Concat(new string[]
																				{
																					"F4440C000801",
																					DataStructure.Type_Status._spx,
																					text,
																					Class5.smethod_12(value),
																					"00000000"
																				}));
																			}
																			else
																			{
																				if (Operators.CompareString(type, DataStructure.Type_Player._Agi, false) == 0)
																				{
																					client._My_Agi = value;
																					client.Sendpacket(string.Concat(new string[]
																					{
																						"F4440C000801",
																						DataStructure.Type_Status._agi,
																						text,
																						Class5.smethod_12(value),
																						"00000000"
																					}));
																				}
																				else
																				{
																					if (Operators.CompareString(type, DataStructure.Type_Player._Int2, false) == 0)
																					{
																						client._My_Int2 = value;
																						client.Sendpacket(string.Concat(new string[]
																						{
																							"F4440C000801",
																							DataStructure.Type_Status._Int2,
																							text,
																							Class5.smethod_12(value),
																							"00000000"
																						}));
																					}
																					else
																					{
																						if (Operators.CompareString(type, DataStructure.Type_Player._Atk2, false) == 0)
																						{
																							client._My_Atk2 = value;
																							client.Sendpacket(string.Concat(new string[]
																							{
																								"F4440C000801",
																								DataStructure.Type_Status._Atk2,
																								text,
																								Class5.smethod_12(value),
																								"00000000"
																							}));
																						}
																						else
																						{
																							if (Operators.CompareString(type, DataStructure.Type_Player._Def2, false) == 0)
																							{
																								client._My_Def2 = value;
																								client.Sendpacket(string.Concat(new string[]
																								{
																									"F4440C000801",
																									DataStructure.Type_Status._Def2,
																									text,
																									Class5.smethod_12(value),
																									"00000000"
																								}));
																							}
																							else
																							{
																								if (Operators.CompareString(type, DataStructure.Type_Player._Hpx2, false) == 0)
																								{
																									client._My_Hpx2 = value;
																									client.Sendpacket(string.Concat(new string[]
																									{
																										"F4440C000801",
																										DataStructure.Type_Status._Hpx2,
																										text,
																										Class5.smethod_12(value),
																										"00000000"
																									}));
																									Data.UpdateStatusSendtoParty(_id, DataStructure.Type_Status._Hpx2, value);
																								}
																								else
																								{
																									if (Operators.CompareString(type, DataStructure.Type_Player._Spx2, false) == 0)
																									{
																										client._My_Spx2 = value;
																										client.Sendpacket(string.Concat(new string[]
																										{
																											"F4440C000801",
																											DataStructure.Type_Status._Spx2,
																											text,
																											Class5.smethod_12(value),
																											"00000000"
																										}));
																									}
																									else
																									{
																										if (Operators.CompareString(type, DataStructure.Type_Player._Agi2, false) == 0)
																										{
																											client._My_Agi2 = value;
																											client.Sendpacket(string.Concat(new string[]
																											{
																												"F4440C000801",
																												DataStructure.Type_Status._Agi2,
																												text,
																												Class5.smethod_12(value),
																												"00000000"
																											}));
																										}
																										else
																										{
																											if (Operators.CompareString(type, DataStructure.Type_Player._TExp, false) == 0)
																											{
																												client._My_Texp = value;
																												client.Sendpacket(string.Concat(new string[]
																												{
																													"F4440C000801",
																													DataStructure.Type_Status._TExp,
																													text,
																													Class5.smethod_12(value),
																													"00000000"
																												}));
																											}
																											else
																											{
																												if (Operators.CompareString(type, DataStructure.Type_Player._MapId, false) == 0)
																												{
																													client._My_MapId = value;
																												}
																												else
																												{
																													if (Operators.CompareString(type, DataStructure.Type_Player._MapX, false) == 0)
																													{
																														client._My_MapX = value;
																													}
																													else
																													{
																														if (Operators.CompareString(type, DataStructure.Type_Player._MapY, false) == 0)
																														{
																															client._My_MapY = value;
																														}
																														else
																														{
																															if (Operators.CompareString(type, DataStructure.Type_Player._Reborn, false) == 0)
																															{
																																client._My_Reborn = value;
																															}
																															else
																															{
																																if (Operators.CompareString(type, DataStructure.Type_Player._Job, false) == 0)
																																{
																																	client._My_Job = value;
																																}
																																else
																																{
																																	if (Operators.CompareString(type, DataStructure.Type_Player._Sex, false) == 0)
																																	{
																																		client._My_Sex = value;
																																	}
																																	else
																																	{
																																		if (Operators.CompareString(type, DataStructure.Type_Player._Hair, false) == 0)
																																		{
																																			client._My_Hair = value;
																																		}
																																		else
																																		{
																																			if (Operators.CompareString(type, DataStructure.Type_Player._Thuoctinh, false) == 0)
																																			{
																																				client._My_Thuoctinh = value;
																																			}
																																			else
																																			{
																																				if (Operators.CompareString(type, DataStructure.Type_Player._Ghost, false) == 0)
																																				{
																																					client._My_Ghost = value;
																																				}
																																				else
																																				{
																																					if (Operators.CompareString(type, DataStructure.Type_Player._God, false) == 0)
																																					{
																																						client._My_God = value;
																																					}
																																					else
																																					{
																																						if (Operators.CompareString(type, DataStructure.Type_Player._Color, false) == 0)
																																						{
																																							client._My_Color = Conversions.ToString(value);
																																						}
																																						else
																																						{
																																							if (Operators.CompareString(type, DataStructure.Type_Player._GOld, false) == 0)
																																							{
																																								client._My_Gold = value;
																																							}
																																							else
																																							{
																																								if (Operators.CompareString(type, DataStructure.Type_Player._Tiengtam, false) == 0)
																																								{
																																									client._My_Tiengtam = value;
																																									client.Sendpacket(string.Concat(new string[]
																																									{
																																										"F4440C000801",
																																										DataStructure.Type_Status._TiengTam,
																																										text,
																																										Class5.smethod_12(value),
																																										"00000000"
																																									}));
																																								}
																																								else
																																								{
																																									if (Operators.CompareString(type, DataStructure.Type_Player._Gocnhin, false) == 0)
																																									{
																																										client._My_Gocnhin = value;
																																									}
																																									else
																																									{
																																										if (Operators.CompareString(type, DataStructure.Type_Player._SttPetXuatChien, false) == 0)
																																										{
																																											client._My_SttPetXuatChien = value;
																																										}
																																										else
																																										{
																																											if (Operators.CompareString(type, DataStructure.Type_Player._Pk, false) == 0)
																																											{
																																												client._My_Pk = value;
																																											}
																																											else
																																											{
																																												if (Operators.CompareString(type, DataStructure.Type_Player._ThamChien, false) == 0)
																																												{
																																													client._My_ThamChien = value;
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
		public static int PlayerGetDataSkillId(OleDbConnection conn, int Id, string type)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Skill Where Id = " + Conversions.ToString(Id), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader[type]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static bool PlayerGetDataSkillExits(OleDbConnection conn, int Id)
		{
			bool result = false;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Skill Where Id=" + Conversions.ToString(Id), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = true;
			}
			oleDbDataReader.Close();
			return result;
		}
		public static void UpdateStatusSendtoParty(int _Id, string type, int value)
		{
			checked
			{
				string text;
				if (value >= 0)
				{
					text = "01";
				}
				else
				{
					text = "02";
					value *= -1;
				}
				Client client = (Client)Server.ListView_Client.Items[_Id.ToString()].Tag;
				if (client._My_IdLeader > 0 && (Operators.CompareString(type, DataStructure.Type_Status._lv, false) == 0 | Operators.CompareString(type, DataStructure.Type_Status._Hp, false) == 0 | Operators.CompareString(type, DataStructure.Type_Status._hpx, false) == 0 | Operators.CompareString(type, DataStructure.Type_Status._Hpx2, false) == 0))
				{
					if (client._My_IdLeader != _Id)
					{
						Server.SendToClient(client._My_IdLeader, string.Concat(new string[]
						{
							"F44410000803",
							Class5.smethod_12(_Id),
							type,
							text,
							Class5.smethod_12(value),
							"00000000"
						}));
					}
					if (client._My_IdMem1 != _Id)
					{
						Server.SendToClient(client._My_IdMem1, string.Concat(new string[]
						{
							"F44410000803",
							Class5.smethod_12(_Id),
							type,
							text,
							Class5.smethod_12(value),
							"00000000"
						}));
					}
					if (client._My_IdMem2 != _Id)
					{
						Server.SendToClient(client._My_IdMem2, string.Concat(new string[]
						{
							"F44410000803",
							Class5.smethod_12(_Id),
							type,
							text,
							Class5.smethod_12(value),
							"00000000"
						}));
					}
					if (client._My_IdMem3 != _Id)
					{
						Server.SendToClient(client._My_IdMem3, string.Concat(new string[]
						{
							"F44410000803",
							Class5.smethod_12(_Id),
							type,
							text,
							Class5.smethod_12(value),
							"00000000"
						}));
					}
					if (client._My_IdMem4 != _Id)
					{
						Server.SendToClient(client._My_IdMem4, string.Concat(new string[]
						{
							"F44410000803",
							Class5.smethod_12(_Id),
							type,
							text,
							Class5.smethod_12(value),
							"00000000"
						}));
					}
				}
			}
		}
		public static void PlayerUpdateStatus(int _Id, string type, int value)
		{
			checked
			{
				string text;
				if (value >= 0)
				{
					text = "01";
				}
				else
				{
					text = "02";
					value *= -1;
				}
				Server.SendToClient(_Id, string.Concat(new string[]
				{
					"F4440C000801",
					type,
					text,
					Class5.smethod_12(value),
					"00000000"
				}));
			}
		}
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static string MemberGetData(int _id, string type)
		{
			string result = "";
			string text = Class1.Form0_0.Info.DirectoryPath + "\\Data\\Member.ini";
			string[] array = Class6.smethod_1(text, "TaiKhoan", _id.ToString(), "").Split(new char[]
			{
				'\t'
			});
			string left = Strings.LCase(type);
			if (Operators.CompareString(left, "pass1", false) == 0)
			{
				result = array[0];
			}
			else
			{
				if (Operators.CompareString(left, "pass2", false) == 0)
				{
					result = array[1];
				}
			}
			return result;
		}
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static bool MemberGetIdExits(int _Id)
		{
			bool result = false;
			string text = Class1.Form0_0.Info.DirectoryPath + "\\Data\\Member.ini";
			if (Operators.CompareString(Class6.smethod_1(text, "TaiKhoan", _Id.ToString(), ""), "nothing", false) != 0)
			{
				result = true;
			}
			return result;
		}
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static void MemberChangedPass(int _Id, string pass1, string pass2)
		{
			string text = Class1.Form0_0.Info.DirectoryPath + "\\Data\\Member.ini";
			Class6.smethod_0(text, "TaiKhoan", _Id.ToString(), pass1 + "\t" + pass2);
		}
		public static int GetDataTalkCount(int _MapId, string _typenpcwarp, int _Id, int _Step)
		{
			int count = 0;
			try
			{
				DataStructure.Key_Talk key = default(DataStructure.Key_Talk);
				key._MapId = _MapId;
				key._Type = _typenpcwarp;
				key._Id = _Id;
				key._Step = _Step;
				count = Data.Data_Talks[key]._Count;
			}
			catch (Exception expr_3F)
			{
				ProjectData.SetProjectError(expr_3F);
				ProjectData.ClearProjectError();
			}
			return count;
		}
		public static string GetDataTalkString(int _MapId, string _typenpcwarp, int _Id, int _Step, int talk)
		{
			string result = "";
			DataStructure.Key_Talk key = default(DataStructure.Key_Talk);
			key._MapId = _MapId;
			key._Type = _typenpcwarp;
			key._Id = _Id;
			key._Step = _Step;
			switch (talk)
			{
			case 1:
				result = Data.Data_Talks[key]._1;
				break;
			case 2:
				result = Data.Data_Talks[key]._2;
				break;
			case 3:
				result = Data.Data_Talks[key]._3;
				break;
			case 4:
				result = Data.Data_Talks[key]._4;
				break;
			case 5:
				result = Data.Data_Talks[key]._5;
				break;
			case 6:
				result = Data.Data_Talks[key]._6;
				break;
			case 7:
				result = Data.Data_Talks[key]._7;
				break;
			case 8:
				result = Data.Data_Talks[key]._8;
				break;
			case 9:
				result = Data.Data_Talks[key]._9;
				break;
			case 10:
				result = Data.Data_Talks[key]._10;
				break;
			}
			return result;
		}
		public static bool GetDataTalkExits(int _MapId, string _typenpcwarp, int _Id, int _Step)
		{
			DataStructure.Key_Talk key = default(DataStructure.Key_Talk);
			key._MapId = _MapId;
			key._Type = _typenpcwarp;
			key._Id = _Id;
			key._Step = _Step;
			return Data.Data_Talks.ContainsKey(key);
		}
		public static int GetHP(string type, int lv, int Hpx)
		{
			int result = 0;
			if (Operators.CompareString(type, DataStructure.Type_GetHp._Hp, false) == 0)
			{
				result = Conversions.ToInteger(Data.FormulaHP[Hpx][lv]);
			}
			else
			{
				if (Operators.CompareString(type, DataStructure.Type_GetHp._HpCs, false) == 0)
				{
					result = Conversions.ToInteger(Data.dictionary_0[Hpx][lv]);
				}
			}
			return result;
		}
		public static int GetSP(string type, int lv, int Spx)
		{
			int result = 0;
			if (Operators.CompareString(type, DataStructure.Type_GetSp._Sp, false) == 0)
			{
				result = Conversions.ToInteger(Data.FormulaSP[Spx][lv]);
			}
			else
			{
				if (Operators.CompareString(type, DataStructure.Type_GetSp._SPCS, false) == 0)
				{
					result = Conversions.ToInteger(Data.dictionary_1[Spx][lv]);
				}
			}
			return result;
		}
		public static void PetUpdateStatus(int _Id, int Stt, string Type, int value)
		{
			checked
			{
				string text;
				if (value >= 0)
				{
					text = "01";
				}
				else
				{
					text = "02";
					value *= -1;
				}
				Server.SendToClient(_Id, string.Concat(new string[]
				{
					"F4440F00080204",
					Class5.smethod_11(Stt),
					Type,
					text,
					Class5.smethod_12(value),
					"00000000"
				}));
			}
		}
		public static void UpdateStatusPetWhenUseItemLogin(int _IdPlayer)
		{
			OleDbConnection conn = Server.Clients[_IdPlayer].conn;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Pet Where Stt <= 4 And ID > 0 ", conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			checked
			{
				while (oleDbDataReader.Read())
				{
					int num = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Stt]);
					DataStructure._MyPet value = default(DataStructure._MyPet);
					value._Id = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._ID]);
					value._Name = Conversions.ToString(oleDbDataReader[DataStructure.Type_Pet._Name]);
					value._Quest = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Quest]);
					if (Server.Clients.ContainsKey(_IdPlayer))
					{
						Server.Clients[_IdPlayer].ListPet[num] = value;
					}
					int reborn = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Reborn]);
					int lv = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Lv]);
					int num2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Hp]);
					int num3 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Sp]);
					int hPX = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Hpx]);
					int sPX = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Spx]);
					int num4 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Thuoctinh]);
					DataStructure.HomdoInfo homdoInfo = Data.TrangbiGetDataItem(conn, num * 10 + 1);
					DataStructure.HomdoInfo homdoInfo2 = Data.TrangbiGetDataItem(conn, num * 10 + 2);
					DataStructure.HomdoInfo homdoInfo3 = Data.TrangbiGetDataItem(conn, num * 10 + 3);
					DataStructure.HomdoInfo homdoInfo4 = Data.TrangbiGetDataItem(conn, num * 10 + 4);
					DataStructure.HomdoInfo homdoInfo5 = Data.TrangbiGetDataItem(conn, num * 10 + 5);
					DataStructure.HomdoInfo homdoInfo6 = Data.TrangbiGetDataItem(conn, num * 10 + 6);
					int num5 = homdoInfo._Int1;
					int num6 = homdoInfo._Int2;
					int num7 = homdoInfo._Atk1;
					int num8 = homdoInfo._Atk2;
					int num9 = homdoInfo._Def1;
					int num10 = homdoInfo._Def2;
					int num11 = homdoInfo._Hpx1;
					int num12 = homdoInfo._Hpx2;
					int num13 = homdoInfo._Spx1;
					int num14 = homdoInfo._Spx2;
					int num15 = homdoInfo._Agi1;
					int num16 = homdoInfo._Agi2;
					int num17 = homdoInfo2._Int1;
					int num18 = homdoInfo2._Int2;
					int num19 = homdoInfo2._Atk1;
					int num20 = homdoInfo2._Atk2;
					int num21 = homdoInfo2._Def1;
					int num22 = homdoInfo2._Def2;
					int num23 = homdoInfo2._Hpx1;
					int num24 = homdoInfo2._Hpx2;
					int num25 = homdoInfo2._Spx1;
					int num26 = homdoInfo2._Spx2;
					int num27 = homdoInfo2._Agi1;
					int num28 = homdoInfo2._Agi2;
					int num29 = homdoInfo3._Int1;
					int num30 = homdoInfo3._Int2;
					int num31 = homdoInfo3._Atk1;
					int num32 = homdoInfo3._Atk2;
					int num33 = homdoInfo3._Def1;
					int num34 = homdoInfo3._Def2;
					int num35 = homdoInfo3._Hpx1;
					int num36 = homdoInfo3._Hpx2;
					int num37 = homdoInfo3._Spx1;
					int num38 = homdoInfo3._Spx2;
					int num39 = homdoInfo3._Agi1;
					int num40 = homdoInfo3._Agi2;
					int num41 = homdoInfo4._Int1;
					int num42 = homdoInfo4._Int2;
					int num43 = homdoInfo4._Atk1;
					int num44 = homdoInfo4._Atk2;
					int num45 = homdoInfo4._Def1;
					int num46 = homdoInfo4._Def2;
					int num47 = homdoInfo4._Hpx1;
					int num48 = homdoInfo4._Hpx2;
					int num49 = homdoInfo4._Spx1;
					int num50 = homdoInfo4._Spx2;
					int num51 = homdoInfo4._Agi1;
					int num52 = homdoInfo4._Agi2;
					int num53 = homdoInfo5._Int1;
					int num54 = homdoInfo5._Int2;
					int num55 = homdoInfo5._Atk1;
					int num56 = homdoInfo5._Atk2;
					int num57 = homdoInfo5._Def1;
					int num58 = homdoInfo5._Def2;
					int num59 = homdoInfo5._Hpx1;
					int num60 = homdoInfo5._Hpx2;
					int num61 = homdoInfo5._Spx1;
					int num62 = homdoInfo5._Spx2;
					int num63 = homdoInfo5._Agi1;
					int num64 = homdoInfo5._Agi2;
					int num65 = homdoInfo6._Int1;
					int num66 = homdoInfo6._Int2;
					int num67 = homdoInfo6._Atk1;
					int num68 = homdoInfo6._Atk2;
					int num69 = homdoInfo6._Def1;
					int num70 = homdoInfo6._Def2;
					int num71 = homdoInfo6._Hpx1;
					int num72 = homdoInfo6._Hpx2;
					int num73 = homdoInfo6._Spx1;
					int num74 = homdoInfo6._Spx2;
					int num75 = homdoInfo6._Agi1;
					int num76 = homdoInfo6._Agi2;
					if (homdoInfo._Thuoctinh == num4 | homdoInfo._Thuoctinh == 5)
					{
						if (num5 > 0)
						{
							num5 += homdoInfo._GiatriThuoctinh;
						}
						if (num6 > 0)
						{
							num6 += homdoInfo._GiatriThuoctinh;
						}
						if (num7 > 0)
						{
							num7 += homdoInfo._GiatriThuoctinh;
						}
						if (num8 > 0)
						{
							num8 += homdoInfo._GiatriThuoctinh;
						}
						if (num9 > 0)
						{
							num9 += homdoInfo._GiatriThuoctinh;
						}
						if (num10 > 0)
						{
							num10 += homdoInfo._GiatriThuoctinh;
						}
						if (num11 > 0)
						{
							num11 += homdoInfo._GiatriThuoctinh;
						}
						if (num12 > 0)
						{
							num12 += homdoInfo._GiatriThuoctinh;
						}
						if (num13 > 0)
						{
							num13 += homdoInfo._GiatriThuoctinh;
						}
						if (num14 > 0)
						{
							num14 += homdoInfo._GiatriThuoctinh;
						}
						if (num15 > 0)
						{
							num15 += homdoInfo._GiatriThuoctinh;
						}
						if (num16 > 0)
						{
							num16 += homdoInfo._GiatriThuoctinh;
						}
					}
					if (homdoInfo._Long == num4 | homdoInfo._Long == 5)
					{
						if (num5 > 0)
						{
							num5 += homdoInfo._GiatriLong;
						}
						if (num6 > 0)
						{
							num6 += homdoInfo._GiatriLong;
						}
						if (num7 > 0)
						{
							num7 += homdoInfo._GiatriLong;
						}
						if (num8 > 0)
						{
							num8 += homdoInfo._GiatriLong;
						}
						if (num9 > 0)
						{
							num9 += homdoInfo._GiatriLong;
						}
						if (num10 > 0)
						{
							num10 += homdoInfo._GiatriLong;
						}
						if (num11 > 0)
						{
							num11 += homdoInfo._GiatriLong;
						}
						if (num12 > 0)
						{
							num12 += homdoInfo._GiatriLong;
						}
						if (num13 > 0)
						{
							num13 += homdoInfo._GiatriLong;
						}
						if (num14 > 0)
						{
							num14 += homdoInfo._GiatriLong;
						}
						if (num15 > 0)
						{
							num15 += homdoInfo._GiatriLong;
						}
						if (num16 > 0)
						{
							num16 += homdoInfo._GiatriLong;
						}
					}
					if (homdoInfo2._Thuoctinh == num4 | homdoInfo2._Thuoctinh == 5)
					{
						if (num17 > 0)
						{
							num17 += homdoInfo2._GiatriThuoctinh;
						}
						if (num18 > 0)
						{
							num18 += homdoInfo2._GiatriThuoctinh;
						}
						if (num19 > 0)
						{
							num19 += homdoInfo2._GiatriThuoctinh;
						}
						if (num20 > 0)
						{
							num20 += homdoInfo2._GiatriThuoctinh;
						}
						if (num21 > 0)
						{
							num21 += homdoInfo2._GiatriThuoctinh;
						}
						if (num22 > 0)
						{
							num22 += homdoInfo2._GiatriThuoctinh;
						}
						if (num23 > 0)
						{
							num23 += homdoInfo2._GiatriThuoctinh;
						}
						if (num24 > 0)
						{
							num24 += homdoInfo2._GiatriThuoctinh;
						}
						if (num25 > 0)
						{
							num25 += homdoInfo2._GiatriThuoctinh;
						}
						if (num26 > 0)
						{
							num26 += homdoInfo2._GiatriThuoctinh;
						}
						if (num27 > 0)
						{
							num27 += homdoInfo2._GiatriThuoctinh;
						}
						if (num28 > 0)
						{
							num28 += homdoInfo2._GiatriThuoctinh;
						}
					}
					if (homdoInfo2._Long == num4 | homdoInfo2._Long == 5)
					{
						if (num17 > 0)
						{
							num17 += homdoInfo2._GiatriLong;
						}
						if (num18 > 0)
						{
							num18 += homdoInfo2._GiatriLong;
						}
						if (num19 > 0)
						{
							num19 += homdoInfo2._GiatriLong;
						}
						if (num20 > 0)
						{
							num20 += homdoInfo2._GiatriLong;
						}
						if (num21 > 0)
						{
							num21 += homdoInfo2._GiatriLong;
						}
						if (num22 > 0)
						{
							num22 += homdoInfo2._GiatriLong;
						}
						if (num23 > 0)
						{
							num23 += homdoInfo2._GiatriLong;
						}
						if (num24 > 0)
						{
							num24 += homdoInfo2._GiatriLong;
						}
						if (num25 > 0)
						{
							num25 += homdoInfo2._GiatriLong;
						}
						if (num26 > 0)
						{
							num26 += homdoInfo2._GiatriLong;
						}
						if (num27 > 0)
						{
							num27 += homdoInfo2._GiatriLong;
						}
						if (num28 > 0)
						{
							num28 += homdoInfo2._GiatriLong;
						}
					}
					if (homdoInfo3._Thuoctinh == num4 | homdoInfo3._Thuoctinh == 5)
					{
						if (num29 > 0)
						{
							num29 += homdoInfo3._GiatriThuoctinh;
						}
						if (num30 > 0)
						{
							num30 += homdoInfo3._GiatriThuoctinh;
						}
						if (num31 > 0)
						{
							num31 += homdoInfo3._GiatriThuoctinh;
						}
						if (num32 > 0)
						{
							num32 += homdoInfo3._GiatriThuoctinh;
						}
						if (num33 > 0)
						{
							num33 += homdoInfo3._GiatriThuoctinh;
						}
						if (num34 > 0)
						{
							num34 += homdoInfo3._GiatriThuoctinh;
						}
						if (num35 > 0)
						{
							num35 += homdoInfo3._GiatriThuoctinh;
						}
						if (num36 > 0)
						{
							num36 += homdoInfo3._GiatriThuoctinh;
						}
						if (num37 > 0)
						{
							num37 += homdoInfo3._GiatriThuoctinh;
						}
						if (num38 > 0)
						{
							num38 += homdoInfo3._GiatriThuoctinh;
						}
						if (num39 > 0)
						{
							num39 += homdoInfo3._GiatriThuoctinh;
						}
						if (num40 > 0)
						{
							num40 += homdoInfo3._GiatriThuoctinh;
						}
					}
					if (homdoInfo3._Long == num4 | homdoInfo3._Long == 5)
					{
						if (num29 > 0)
						{
							num29 += homdoInfo3._GiatriLong;
						}
						if (num30 > 0)
						{
							num30 += homdoInfo3._GiatriLong;
						}
						if (num31 > 0)
						{
							num31 += homdoInfo3._GiatriLong;
						}
						if (num32 > 0)
						{
							num32 += homdoInfo3._GiatriLong;
						}
						if (num33 > 0)
						{
							num33 += homdoInfo3._GiatriLong;
						}
						if (num34 > 0)
						{
							num34 += homdoInfo3._GiatriLong;
						}
						if (num35 > 0)
						{
							num35 += homdoInfo3._GiatriLong;
						}
						if (num36 > 0)
						{
							num36 += homdoInfo3._GiatriLong;
						}
						if (num37 > 0)
						{
							num37 += homdoInfo3._GiatriLong;
						}
						if (num38 > 0)
						{
							num38 += homdoInfo3._GiatriLong;
						}
						if (num39 > 0)
						{
							num39 += homdoInfo3._GiatriLong;
						}
						if (num40 > 0)
						{
							num40 += homdoInfo3._GiatriLong;
						}
					}
					if (homdoInfo4._Thuoctinh == num4 | homdoInfo4._Thuoctinh == 5)
					{
						if (num41 > 0)
						{
							num41 += homdoInfo4._GiatriThuoctinh;
						}
						if (num42 > 0)
						{
							num42 += homdoInfo4._GiatriThuoctinh;
						}
						if (num43 > 0)
						{
							num43 += homdoInfo4._GiatriThuoctinh;
						}
						if (num44 > 0)
						{
							num44 += homdoInfo4._GiatriThuoctinh;
						}
						if (num45 > 0)
						{
							num45 += homdoInfo4._GiatriThuoctinh;
						}
						if (num46 > 0)
						{
							num46 += homdoInfo4._GiatriThuoctinh;
						}
						if (num47 > 0)
						{
							num47 += homdoInfo4._GiatriThuoctinh;
						}
						if (num48 > 0)
						{
							num48 += homdoInfo4._GiatriThuoctinh;
						}
						if (num49 > 0)
						{
							num49 += homdoInfo4._GiatriThuoctinh;
						}
						if (num50 > 0)
						{
							num50 += homdoInfo4._GiatriThuoctinh;
						}
						if (num51 > 0)
						{
							num51 += homdoInfo4._GiatriThuoctinh;
						}
						if (num52 > 0)
						{
							num52 += homdoInfo4._GiatriThuoctinh;
						}
					}
					if (homdoInfo4._Long == num4 | homdoInfo4._Long == 5)
					{
						if (num41 > 0)
						{
							num41 += homdoInfo4._GiatriLong;
						}
						if (num42 > 0)
						{
							num42 += homdoInfo4._GiatriLong;
						}
						if (num43 > 0)
						{
							num43 += homdoInfo4._GiatriLong;
						}
						if (num44 > 0)
						{
							num44 += homdoInfo4._GiatriLong;
						}
						if (num45 > 0)
						{
							num45 += homdoInfo4._GiatriLong;
						}
						if (num46 > 0)
						{
							num46 += homdoInfo4._GiatriLong;
						}
						if (num47 > 0)
						{
							num47 += homdoInfo4._GiatriLong;
						}
						if (num48 > 0)
						{
							num48 += homdoInfo4._GiatriLong;
						}
						if (num49 > 0)
						{
							num49 += homdoInfo4._GiatriLong;
						}
						if (num50 > 0)
						{
							num50 += homdoInfo4._GiatriLong;
						}
						if (num51 > 0)
						{
							num51 += homdoInfo4._GiatriLong;
						}
						if (num52 > 0)
						{
							num52 += homdoInfo4._GiatriLong;
						}
					}
					if (homdoInfo5._Thuoctinh == num4 | homdoInfo5._Thuoctinh == 5)
					{
						if (num53 > 0)
						{
							num53 += homdoInfo5._GiatriThuoctinh;
						}
						if (num54 > 0)
						{
							num54 += homdoInfo5._GiatriThuoctinh;
						}
						if (num55 > 0)
						{
							num55 += homdoInfo5._GiatriThuoctinh;
						}
						if (num56 > 0)
						{
							num56 += homdoInfo5._GiatriThuoctinh;
						}
						if (num57 > 0)
						{
							num57 += homdoInfo5._GiatriThuoctinh;
						}
						if (num58 > 0)
						{
							num58 += homdoInfo5._GiatriThuoctinh;
						}
						if (num59 > 0)
						{
							num59 += homdoInfo5._GiatriThuoctinh;
						}
						if (num60 > 0)
						{
							num60 += homdoInfo5._GiatriThuoctinh;
						}
						if (num61 > 0)
						{
							num61 += homdoInfo5._GiatriThuoctinh;
						}
						if (num62 > 0)
						{
							num62 += homdoInfo5._GiatriThuoctinh;
						}
						if (num63 > 0)
						{
							num63 += homdoInfo5._GiatriThuoctinh;
						}
						if (num64 > 0)
						{
							num64 += homdoInfo5._GiatriThuoctinh;
						}
					}
					if (homdoInfo5._Long == num4 | homdoInfo5._Long == 5)
					{
						if (num53 > 0)
						{
							num53 += homdoInfo5._GiatriLong;
						}
						if (num54 > 0)
						{
							num54 += homdoInfo5._GiatriLong;
						}
						if (num55 > 0)
						{
							num55 += homdoInfo5._GiatriLong;
						}
						if (num56 > 0)
						{
							num56 += homdoInfo5._GiatriLong;
						}
						if (num57 > 0)
						{
							num57 += homdoInfo5._GiatriLong;
						}
						if (num58 > 0)
						{
							num58 += homdoInfo5._GiatriLong;
						}
						if (num59 > 0)
						{
							num59 += homdoInfo5._GiatriLong;
						}
						if (num60 > 0)
						{
							num60 += homdoInfo5._GiatriLong;
						}
						if (num61 > 0)
						{
							num61 += homdoInfo5._GiatriLong;
						}
						if (num62 > 0)
						{
							num62 += homdoInfo5._GiatriLong;
						}
						if (num63 > 0)
						{
							num63 += homdoInfo5._GiatriLong;
						}
						if (num64 > 0)
						{
							num64 += homdoInfo5._GiatriLong;
						}
					}
					if (homdoInfo6._Thuoctinh == num4 | homdoInfo6._Thuoctinh == 5)
					{
						if (num65 > 0)
						{
							num65 += homdoInfo6._GiatriThuoctinh;
						}
						if (num66 > 0)
						{
							num66 += homdoInfo6._GiatriThuoctinh;
						}
						if (num67 > 0)
						{
							num67 += homdoInfo6._GiatriThuoctinh;
						}
						if (num68 > 0)
						{
							num68 += homdoInfo6._GiatriThuoctinh;
						}
						if (num69 > 0)
						{
							num69 += homdoInfo6._GiatriThuoctinh;
						}
						if (num70 > 0)
						{
							num70 += homdoInfo6._GiatriThuoctinh;
						}
						if (num71 > 0)
						{
							num71 += homdoInfo6._GiatriThuoctinh;
						}
						if (num72 > 0)
						{
							num72 += homdoInfo6._GiatriThuoctinh;
						}
						if (num73 > 0)
						{
							num73 += homdoInfo6._GiatriThuoctinh;
						}
						if (num74 > 0)
						{
							num74 += homdoInfo6._GiatriThuoctinh;
						}
						if (num75 > 0)
						{
							num75 += homdoInfo6._GiatriThuoctinh;
						}
						if (num76 > 0)
						{
							num76 += homdoInfo6._GiatriThuoctinh;
						}
					}
					if (homdoInfo6._Long == num4 | homdoInfo6._Long == 5)
					{
						if (num65 > 0)
						{
							num65 += homdoInfo6._GiatriLong;
						}
						if (num66 > 0)
						{
							num66 += homdoInfo6._GiatriLong;
						}
						if (num67 > 0)
						{
							num67 += homdoInfo6._GiatriLong;
						}
						if (num68 > 0)
						{
							num68 += homdoInfo6._GiatriLong;
						}
						if (num69 > 0)
						{
							num69 += homdoInfo6._GiatriLong;
						}
						if (num70 > 0)
						{
							num70 += homdoInfo6._GiatriLong;
						}
						if (num71 > 0)
						{
							num71 += homdoInfo6._GiatriLong;
						}
						if (num72 > 0)
						{
							num72 += homdoInfo6._GiatriLong;
						}
						if (num73 > 0)
						{
							num73 += homdoInfo6._GiatriLong;
						}
						if (num74 > 0)
						{
							num74 += homdoInfo6._GiatriLong;
						}
						if (num75 > 0)
						{
							num75 += homdoInfo6._GiatriLong;
						}
						if (num76 > 0)
						{
							num76 += homdoInfo6._GiatriLong;
						}
					}
					int value2 = num5 + num6 + num17 + num18 + num29 + num30 + num41 + num42 + num53 + num54 + num65 + num66;
					int value3 = num7 + num8 + num19 + num20 + num31 + num32 + num43 + num44 + num55 + num56 + num67 + num68;
					int value4 = num9 + num10 + num21 + num22 + num33 + num34 + num45 + num46 + num57 + num58 + num69 + num70;
					int num77 = num11 + num12 + num23 + num24 + num35 + num36 + num47 + num48 + num59 + num60 + num71 + num72;
					int num78 = num13 + num14 + num25 + num26 + num37 + num38 + num49 + num50 + num61 + num62 + num73 + num74;
					int value5 = num15 + num16 + num27 + num28 + num39 + num40 + num51 + num52 + num63 + num64 + num75 + num76;
					Data.PetUpdateData(_IdPlayer, num, DataStructure.Type_Pet._Int2, value2);
					Data.PetUpdateData(_IdPlayer, num, DataStructure.Type_Pet._Atk2, value3);
					Data.PetUpdateData(_IdPlayer, num, DataStructure.Type_Pet._Def2, value4);
					Data.PetUpdateData(_IdPlayer, num, DataStructure.Type_Pet._Hpx2, num77);
					Data.PetUpdateData(_IdPlayer, num, DataStructure.Type_Pet._Spx2, num78);
					Data.PetUpdateData(_IdPlayer, num, DataStructure.Type_Pet._Agi2, value5);
					int num79 = Data.CongthucHPPet(reborn, lv, hPX) + num77;
					if (num2 >= num79)
					{
						Data.PetUpdateData(_IdPlayer, num, DataStructure.Type_Pet._Hp, num79);
					}
					int num80 = Data.CongthucSPPet(reborn, lv, sPX) + num78;
					if (num3 >= num80)
					{
						Data.PetUpdateData(_IdPlayer, num, DataStructure.Type_Pet._Sp, num80);
					}
				}
				oleDbDataReader.Close();
			}
		}
		public static void UpdateStatusPetWhenUseItem(int _IdPlayer, int stt)
		{
			if (!Server.Clients.ContainsKey(_IdPlayer))
			{
				return;
			}
			OleDbConnection conn = Server.Clients[_IdPlayer].conn;
			int num = Data.PetGetData(conn, stt, DataStructure.Type_Pet._ID);
			if (num == 0)
			{
				return;
			}
			string name = Data.PetGetDataName(conn, stt, DataStructure.Type_Pet._Name);
			int quest = Data.PetGetData(conn, stt, DataStructure.Type_Pet._Quest);
			if (stt > 0 & stt < 5)
			{
				DataStructure._MyPet value = default(DataStructure._MyPet);
				value._Id = num;
				value._Name = name;
				value._Quest = quest;
				if (Server.Clients.ContainsKey(_IdPlayer))
				{
					Server.Clients[_IdPlayer].ListPet[stt] = value;
				}
			}
			int reborn = Data.PetGetData(conn, stt, DataStructure.Type_Pet._Reborn);
			int lv = Data.PetGetData(conn, stt, DataStructure.Type_Pet._Lv);
			int num2 = Data.PetGetData(conn, stt, DataStructure.Type_Pet._Hp);
			int num3 = Data.PetGetData(conn, stt, DataStructure.Type_Pet._Sp);
			int hPX = Data.PetGetData(conn, stt, DataStructure.Type_Pet._Hpx);
			int sPX = Data.PetGetData(conn, stt, DataStructure.Type_Pet._Spx);
			int num4 = Data.PetGetData(conn, stt, DataStructure.Type_Pet._Thuoctinh);
			checked
			{
				DataStructure.HomdoInfo homdoInfo = Data.TrangbiGetDataItem(conn, stt * 10 + 1);
				DataStructure.HomdoInfo homdoInfo2 = Data.TrangbiGetDataItem(conn, stt * 10 + 2);
				DataStructure.HomdoInfo homdoInfo3 = Data.TrangbiGetDataItem(conn, stt * 10 + 3);
				DataStructure.HomdoInfo homdoInfo4 = Data.TrangbiGetDataItem(conn, stt * 10 + 4);
				DataStructure.HomdoInfo homdoInfo5 = Data.TrangbiGetDataItem(conn, stt * 10 + 5);
				DataStructure.HomdoInfo homdoInfo6 = Data.TrangbiGetDataItem(conn, stt * 10 + 6);
				int num5 = homdoInfo._Int1;
				int num6 = homdoInfo._Int2;
				int num7 = homdoInfo._Atk1;
				int num8 = homdoInfo._Atk2;
				int num9 = homdoInfo._Def1;
				int num10 = homdoInfo._Def2;
				int num11 = homdoInfo._Hpx1;
				int num12 = homdoInfo._Hpx2;
				int num13 = homdoInfo._Spx1;
				int num14 = homdoInfo._Spx2;
				int num15 = homdoInfo._Agi1;
				int num16 = homdoInfo._Agi2;
				int num17 = homdoInfo2._Int1;
				int num18 = homdoInfo2._Int2;
				int num19 = homdoInfo2._Atk1;
				int num20 = homdoInfo2._Atk2;
				int num21 = homdoInfo2._Def1;
				int num22 = homdoInfo2._Def2;
				int num23 = homdoInfo2._Hpx1;
				int num24 = homdoInfo2._Hpx2;
				int num25 = homdoInfo2._Spx1;
				int num26 = homdoInfo2._Spx2;
				int num27 = homdoInfo2._Agi1;
				int num28 = homdoInfo2._Agi2;
				int num29 = homdoInfo3._Int1;
				int num30 = homdoInfo3._Int2;
				int num31 = homdoInfo3._Atk1;
				int num32 = homdoInfo3._Atk2;
				int num33 = homdoInfo3._Def1;
				int num34 = homdoInfo3._Def2;
				int num35 = homdoInfo3._Hpx1;
				int num36 = homdoInfo3._Hpx2;
				int num37 = homdoInfo3._Spx1;
				int num38 = homdoInfo3._Spx2;
				int num39 = homdoInfo3._Agi1;
				int num40 = homdoInfo3._Agi2;
				int num41 = homdoInfo4._Int1;
				int num42 = homdoInfo4._Int2;
				int num43 = homdoInfo4._Atk1;
				int num44 = homdoInfo4._Atk2;
				int num45 = homdoInfo4._Def1;
				int num46 = homdoInfo4._Def2;
				int num47 = homdoInfo4._Hpx1;
				int num48 = homdoInfo4._Hpx2;
				int num49 = homdoInfo4._Spx1;
				int num50 = homdoInfo4._Spx2;
				int num51 = homdoInfo4._Agi1;
				int num52 = homdoInfo4._Agi2;
				int num53 = homdoInfo5._Int1;
				int num54 = homdoInfo5._Int2;
				int num55 = homdoInfo5._Atk1;
				int num56 = homdoInfo5._Atk2;
				int num57 = homdoInfo5._Def1;
				int num58 = homdoInfo5._Def2;
				int num59 = homdoInfo5._Hpx1;
				int num60 = homdoInfo5._Hpx2;
				int num61 = homdoInfo5._Spx1;
				int num62 = homdoInfo5._Spx2;
				int num63 = homdoInfo5._Agi1;
				int num64 = homdoInfo5._Agi2;
				int num65 = homdoInfo6._Int1;
				int num66 = homdoInfo6._Int2;
				int num67 = homdoInfo6._Atk1;
				int num68 = homdoInfo6._Atk2;
				int num69 = homdoInfo6._Def1;
				int num70 = homdoInfo6._Def2;
				int num71 = homdoInfo6._Hpx1;
				int num72 = homdoInfo6._Hpx2;
				int num73 = homdoInfo6._Spx1;
				int num74 = homdoInfo6._Spx2;
				int num75 = homdoInfo6._Agi1;
				int num76 = homdoInfo6._Agi2;
				if (homdoInfo._Thuoctinh == num4 | homdoInfo._Thuoctinh == 5)
				{
					if (num5 > 0)
					{
						num5 += homdoInfo._GiatriThuoctinh;
					}
					if (num6 > 0)
					{
						num6 += homdoInfo._GiatriThuoctinh;
					}
					if (num7 > 0)
					{
						num7 += homdoInfo._GiatriThuoctinh;
					}
					if (num8 > 0)
					{
						num8 += homdoInfo._GiatriThuoctinh;
					}
					if (num9 > 0)
					{
						num9 += homdoInfo._GiatriThuoctinh;
					}
					if (num10 > 0)
					{
						num10 += homdoInfo._GiatriThuoctinh;
					}
					if (num11 > 0)
					{
						num11 += homdoInfo._GiatriThuoctinh;
					}
					if (num12 > 0)
					{
						num12 += homdoInfo._GiatriThuoctinh;
					}
					if (num13 > 0)
					{
						num13 += homdoInfo._GiatriThuoctinh;
					}
					if (num14 > 0)
					{
						num14 += homdoInfo._GiatriThuoctinh;
					}
					if (num15 > 0)
					{
						num15 += homdoInfo._GiatriThuoctinh;
					}
					if (num16 > 0)
					{
						num16 += homdoInfo._GiatriThuoctinh;
					}
				}
				if (homdoInfo._Long == num4 | homdoInfo._Long == 5)
				{
					if (num5 > 0)
					{
						num5 += homdoInfo._GiatriLong;
					}
					if (num6 > 0)
					{
						num6 += homdoInfo._GiatriLong;
					}
					if (num7 > 0)
					{
						num7 += homdoInfo._GiatriLong;
					}
					if (num8 > 0)
					{
						num8 += homdoInfo._GiatriLong;
					}
					if (num9 > 0)
					{
						num9 += homdoInfo._GiatriLong;
					}
					if (num10 > 0)
					{
						num10 += homdoInfo._GiatriLong;
					}
					if (num11 > 0)
					{
						num11 += homdoInfo._GiatriLong;
					}
					if (num12 > 0)
					{
						num12 += homdoInfo._GiatriLong;
					}
					if (num13 > 0)
					{
						num13 += homdoInfo._GiatriLong;
					}
					if (num14 > 0)
					{
						num14 += homdoInfo._GiatriLong;
					}
					if (num15 > 0)
					{
						num15 += homdoInfo._GiatriLong;
					}
					if (num16 > 0)
					{
						num16 += homdoInfo._GiatriLong;
					}
				}
				if (homdoInfo2._Thuoctinh == num4 | homdoInfo2._Thuoctinh == 5)
				{
					if (num17 > 0)
					{
						num17 += homdoInfo2._GiatriThuoctinh;
					}
					if (num18 > 0)
					{
						num18 += homdoInfo2._GiatriThuoctinh;
					}
					if (num19 > 0)
					{
						num19 += homdoInfo2._GiatriThuoctinh;
					}
					if (num20 > 0)
					{
						num20 += homdoInfo2._GiatriThuoctinh;
					}
					if (num21 > 0)
					{
						num21 += homdoInfo2._GiatriThuoctinh;
					}
					if (num22 > 0)
					{
						num22 += homdoInfo2._GiatriThuoctinh;
					}
					if (num23 > 0)
					{
						num23 += homdoInfo2._GiatriThuoctinh;
					}
					if (num24 > 0)
					{
						num24 += homdoInfo2._GiatriThuoctinh;
					}
					if (num25 > 0)
					{
						num25 += homdoInfo2._GiatriThuoctinh;
					}
					if (num26 > 0)
					{
						num26 += homdoInfo2._GiatriThuoctinh;
					}
					if (num27 > 0)
					{
						num27 += homdoInfo2._GiatriThuoctinh;
					}
					if (num28 > 0)
					{
						num28 += homdoInfo2._GiatriThuoctinh;
					}
				}
				if (homdoInfo2._Long == num4 | homdoInfo2._Long == 5)
				{
					if (num17 > 0)
					{
						num17 += homdoInfo2._GiatriLong;
					}
					if (num18 > 0)
					{
						num18 += homdoInfo2._GiatriLong;
					}
					if (num19 > 0)
					{
						num19 += homdoInfo2._GiatriLong;
					}
					if (num20 > 0)
					{
						num20 += homdoInfo2._GiatriLong;
					}
					if (num21 > 0)
					{
						num21 += homdoInfo2._GiatriLong;
					}
					if (num22 > 0)
					{
						num22 += homdoInfo2._GiatriLong;
					}
					if (num23 > 0)
					{
						num23 += homdoInfo2._GiatriLong;
					}
					if (num24 > 0)
					{
						num24 += homdoInfo2._GiatriLong;
					}
					if (num25 > 0)
					{
						num25 += homdoInfo2._GiatriLong;
					}
					if (num26 > 0)
					{
						num26 += homdoInfo2._GiatriLong;
					}
					if (num27 > 0)
					{
						num27 += homdoInfo2._GiatriLong;
					}
					if (num28 > 0)
					{
						num28 += homdoInfo2._GiatriLong;
					}
				}
				if (homdoInfo3._Thuoctinh == num4 | homdoInfo3._Thuoctinh == 5)
				{
					if (num29 > 0)
					{
						num29 += homdoInfo3._GiatriThuoctinh;
					}
					if (num30 > 0)
					{
						num30 += homdoInfo3._GiatriThuoctinh;
					}
					if (num31 > 0)
					{
						num31 += homdoInfo3._GiatriThuoctinh;
					}
					if (num32 > 0)
					{
						num32 += homdoInfo3._GiatriThuoctinh;
					}
					if (num33 > 0)
					{
						num33 += homdoInfo3._GiatriThuoctinh;
					}
					if (num34 > 0)
					{
						num34 += homdoInfo3._GiatriThuoctinh;
					}
					if (num35 > 0)
					{
						num35 += homdoInfo3._GiatriThuoctinh;
					}
					if (num36 > 0)
					{
						num36 += homdoInfo3._GiatriThuoctinh;
					}
					if (num37 > 0)
					{
						num37 += homdoInfo3._GiatriThuoctinh;
					}
					if (num38 > 0)
					{
						num38 += homdoInfo3._GiatriThuoctinh;
					}
					if (num39 > 0)
					{
						num39 += homdoInfo3._GiatriThuoctinh;
					}
					if (num40 > 0)
					{
						num40 += homdoInfo3._GiatriThuoctinh;
					}
				}
				if (homdoInfo3._Long == num4 | homdoInfo3._Long == 5)
				{
					if (num29 > 0)
					{
						num29 += homdoInfo3._GiatriLong;
					}
					if (num30 > 0)
					{
						num30 += homdoInfo3._GiatriLong;
					}
					if (num31 > 0)
					{
						num31 += homdoInfo3._GiatriLong;
					}
					if (num32 > 0)
					{
						num32 += homdoInfo3._GiatriLong;
					}
					if (num33 > 0)
					{
						num33 += homdoInfo3._GiatriLong;
					}
					if (num34 > 0)
					{
						num34 += homdoInfo3._GiatriLong;
					}
					if (num35 > 0)
					{
						num35 += homdoInfo3._GiatriLong;
					}
					if (num36 > 0)
					{
						num36 += homdoInfo3._GiatriLong;
					}
					if (num37 > 0)
					{
						num37 += homdoInfo3._GiatriLong;
					}
					if (num38 > 0)
					{
						num38 += homdoInfo3._GiatriLong;
					}
					if (num39 > 0)
					{
						num39 += homdoInfo3._GiatriLong;
					}
					if (num40 > 0)
					{
						num40 += homdoInfo3._GiatriLong;
					}
				}
				if (homdoInfo4._Thuoctinh == num4 | homdoInfo4._Thuoctinh == 5)
				{
					if (num41 > 0)
					{
						num41 += homdoInfo4._GiatriThuoctinh;
					}
					if (num42 > 0)
					{
						num42 += homdoInfo4._GiatriThuoctinh;
					}
					if (num43 > 0)
					{
						num43 += homdoInfo4._GiatriThuoctinh;
					}
					if (num44 > 0)
					{
						num44 += homdoInfo4._GiatriThuoctinh;
					}
					if (num45 > 0)
					{
						num45 += homdoInfo4._GiatriThuoctinh;
					}
					if (num46 > 0)
					{
						num46 += homdoInfo4._GiatriThuoctinh;
					}
					if (num47 > 0)
					{
						num47 += homdoInfo4._GiatriThuoctinh;
					}
					if (num48 > 0)
					{
						num48 += homdoInfo4._GiatriThuoctinh;
					}
					if (num49 > 0)
					{
						num49 += homdoInfo4._GiatriThuoctinh;
					}
					if (num50 > 0)
					{
						num50 += homdoInfo4._GiatriThuoctinh;
					}
					if (num51 > 0)
					{
						num51 += homdoInfo4._GiatriThuoctinh;
					}
					if (num52 > 0)
					{
						num52 += homdoInfo4._GiatriThuoctinh;
					}
				}
				if (homdoInfo4._Long == num4 | homdoInfo4._Long == 5)
				{
					if (num41 > 0)
					{
						num41 += homdoInfo4._GiatriLong;
					}
					if (num42 > 0)
					{
						num42 += homdoInfo4._GiatriLong;
					}
					if (num43 > 0)
					{
						num43 += homdoInfo4._GiatriLong;
					}
					if (num44 > 0)
					{
						num44 += homdoInfo4._GiatriLong;
					}
					if (num45 > 0)
					{
						num45 += homdoInfo4._GiatriLong;
					}
					if (num46 > 0)
					{
						num46 += homdoInfo4._GiatriLong;
					}
					if (num47 > 0)
					{
						num47 += homdoInfo4._GiatriLong;
					}
					if (num48 > 0)
					{
						num48 += homdoInfo4._GiatriLong;
					}
					if (num49 > 0)
					{
						num49 += homdoInfo4._GiatriLong;
					}
					if (num50 > 0)
					{
						num50 += homdoInfo4._GiatriLong;
					}
					if (num51 > 0)
					{
						num51 += homdoInfo4._GiatriLong;
					}
					if (num52 > 0)
					{
						num52 += homdoInfo4._GiatriLong;
					}
				}
				if (homdoInfo5._Thuoctinh == num4 | homdoInfo5._Thuoctinh == 5)
				{
					if (num53 > 0)
					{
						num53 += homdoInfo5._GiatriThuoctinh;
					}
					if (num54 > 0)
					{
						num54 += homdoInfo5._GiatriThuoctinh;
					}
					if (num55 > 0)
					{
						num55 += homdoInfo5._GiatriThuoctinh;
					}
					if (num56 > 0)
					{
						num56 += homdoInfo5._GiatriThuoctinh;
					}
					if (num57 > 0)
					{
						num57 += homdoInfo5._GiatriThuoctinh;
					}
					if (num58 > 0)
					{
						num58 += homdoInfo5._GiatriThuoctinh;
					}
					if (num59 > 0)
					{
						num59 += homdoInfo5._GiatriThuoctinh;
					}
					if (num60 > 0)
					{
						num60 += homdoInfo5._GiatriThuoctinh;
					}
					if (num61 > 0)
					{
						num61 += homdoInfo5._GiatriThuoctinh;
					}
					if (num62 > 0)
					{
						num62 += homdoInfo5._GiatriThuoctinh;
					}
					if (num63 > 0)
					{
						num63 += homdoInfo5._GiatriThuoctinh;
					}
					if (num64 > 0)
					{
						num64 += homdoInfo5._GiatriThuoctinh;
					}
				}
				if (homdoInfo5._Long == num4 | homdoInfo5._Long == 5)
				{
					if (num53 > 0)
					{
						num53 += homdoInfo5._GiatriLong;
					}
					if (num54 > 0)
					{
						num54 += homdoInfo5._GiatriLong;
					}
					if (num55 > 0)
					{
						num55 += homdoInfo5._GiatriLong;
					}
					if (num56 > 0)
					{
						num56 += homdoInfo5._GiatriLong;
					}
					if (num57 > 0)
					{
						num57 += homdoInfo5._GiatriLong;
					}
					if (num58 > 0)
					{
						num58 += homdoInfo5._GiatriLong;
					}
					if (num59 > 0)
					{
						num59 += homdoInfo5._GiatriLong;
					}
					if (num60 > 0)
					{
						num60 += homdoInfo5._GiatriLong;
					}
					if (num61 > 0)
					{
						num61 += homdoInfo5._GiatriLong;
					}
					if (num62 > 0)
					{
						num62 += homdoInfo5._GiatriLong;
					}
					if (num63 > 0)
					{
						num63 += homdoInfo5._GiatriLong;
					}
					if (num64 > 0)
					{
						num64 += homdoInfo5._GiatriLong;
					}
				}
				if (homdoInfo6._Thuoctinh == num4 | homdoInfo6._Thuoctinh == 5)
				{
					if (num65 > 0)
					{
						num65 += homdoInfo6._GiatriThuoctinh;
					}
					if (num66 > 0)
					{
						num66 += homdoInfo6._GiatriThuoctinh;
					}
					if (num67 > 0)
					{
						num67 += homdoInfo6._GiatriThuoctinh;
					}
					if (num68 > 0)
					{
						num68 += homdoInfo6._GiatriThuoctinh;
					}
					if (num69 > 0)
					{
						num69 += homdoInfo6._GiatriThuoctinh;
					}
					if (num70 > 0)
					{
						num70 += homdoInfo6._GiatriThuoctinh;
					}
					if (num71 > 0)
					{
						num71 += homdoInfo6._GiatriThuoctinh;
					}
					if (num72 > 0)
					{
						num72 += homdoInfo6._GiatriThuoctinh;
					}
					if (num73 > 0)
					{
						num73 += homdoInfo6._GiatriThuoctinh;
					}
					if (num74 > 0)
					{
						num74 += homdoInfo6._GiatriThuoctinh;
					}
					if (num75 > 0)
					{
						num75 += homdoInfo6._GiatriThuoctinh;
					}
					if (num76 > 0)
					{
						num76 += homdoInfo6._GiatriThuoctinh;
					}
				}
				if (homdoInfo6._Long == num4 | homdoInfo6._Long == 5)
				{
					if (num65 > 0)
					{
						num65 += homdoInfo6._GiatriLong;
					}
					if (num66 > 0)
					{
						num66 += homdoInfo6._GiatriLong;
					}
					if (num67 > 0)
					{
						num67 += homdoInfo6._GiatriLong;
					}
					if (num68 > 0)
					{
						num68 += homdoInfo6._GiatriLong;
					}
					if (num69 > 0)
					{
						num69 += homdoInfo6._GiatriLong;
					}
					if (num70 > 0)
					{
						num70 += homdoInfo6._GiatriLong;
					}
					if (num71 > 0)
					{
						num71 += homdoInfo6._GiatriLong;
					}
					if (num72 > 0)
					{
						num72 += homdoInfo6._GiatriLong;
					}
					if (num73 > 0)
					{
						num73 += homdoInfo6._GiatriLong;
					}
					if (num74 > 0)
					{
						num74 += homdoInfo6._GiatriLong;
					}
					if (num75 > 0)
					{
						num75 += homdoInfo6._GiatriLong;
					}
					if (num76 > 0)
					{
						num76 += homdoInfo6._GiatriLong;
					}
				}
				int value2 = num5 + num6 + num17 + num18 + num29 + num30 + num41 + num42 + num53 + num54 + num65 + num66;
				int value3 = num7 + num8 + num19 + num20 + num31 + num32 + num43 + num44 + num55 + num56 + num67 + num68;
				int value4 = num9 + num10 + num21 + num22 + num33 + num34 + num45 + num46 + num57 + num58 + num69 + num70;
				int num77 = num11 + num12 + num23 + num24 + num35 + num36 + num47 + num48 + num59 + num60 + num71 + num72;
				int num78 = num13 + num14 + num25 + num26 + num37 + num38 + num49 + num50 + num61 + num62 + num73 + num74;
				int value5 = num15 + num16 + num27 + num28 + num39 + num40 + num51 + num52 + num63 + num64 + num75 + num76;
				Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Int2, value2);
				Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Atk2, value3);
				Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Def2, value4);
				Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Hpx2, num77);
				Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Spx2, num78);
				Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Agi2, value5);
				int num79 = Data.CongthucHPPet(reborn, lv, hPX) + num77;
				if (num2 > num79)
				{
					Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Hpmax, num79);
				}
				else
				{
					Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Hpmax, num79);
				}
				int num80 = Data.CongthucSPPet(reborn, lv, sPX) + num78;
				if (num3 > num80)
				{
					Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Spmax, num80);
				}
				else
				{
					Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Spmax, num80);
				}
			}
		}
		public static void SendStatusAllPet(int _IdPlayer)
		{
			checked
			{
				if (Server.Clients.ContainsKey(_IdPlayer))
				{
					Client client = Server.Clients[_IdPlayer];
					string text = "";
					string text2 = "";
					int num = 1;
					do
					{
						OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Pet Where Stt = " + Conversions.ToString(num), client.conn);
						OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
						if (oleDbDataReader.Read())
						{
							int num2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._ID]);
							if (num2 > 0)
							{
								int num3 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Lv]);
								string text3 = Data.PetGetDataName(client.conn, num, DataStructure.Type_Pet._Name);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Thuoctinh]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Reborn]);
								int int_ = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Int]);
								int int_2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Atk]);
								int int_3 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Def]);
								int int_4 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Hpx]);
								int int_5 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Spx]);
								int int_6 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Agi]);
								int num4 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Fai]);
								int int_7 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Texp]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Int2]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Atk2]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Def2]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Hpx2]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Spx2]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Agi2]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Thd]);
								int int_8 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Hp]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Hpmax]);
								int int_9 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Sp]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Spmax]);
								int int_10 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._SkillPoint]);
								int num5 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._Quest]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._IdSkill1]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._IdSkill2]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._IdSkill3]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._IdSkill4]);
								int num6 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._LvSkill1]);
								int num7 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._LvSkill2]);
								int num8 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._LvSkill3]);
								Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Pet._LvSkill4]);
								int int_11 = Data.TrangbiGetDataItem(client.conn, num * 10 + 1, DataStructure.Type_Homdo._ID);
								int int_12 = Data.TrangbiGetDataItem(client.conn, num * 10 + 2, DataStructure.Type_Homdo._ID);
								int int_13 = Data.TrangbiGetDataItem(client.conn, num * 10 + 3, DataStructure.Type_Homdo._ID);
								int int_14 = Data.TrangbiGetDataItem(client.conn, num * 10 + 4, DataStructure.Type_Homdo._ID);
								int int_15 = Data.TrangbiGetDataItem(client.conn, num * 10 + 5, DataStructure.Type_Homdo._ID);
								int int_16 = Data.TrangbiGetDataItem(client.conn, num * 10 + 6, DataStructure.Type_Homdo._ID);
								text = string.Concat(new string[]
								{
									text,
									num.ToString("X2"),
									Class5.smethod_11(num2),
									Class5.smethod_12(int_7),
									num3.ToString("X2"),
									Class5.smethod_11(int_8),
									Class5.smethod_11(int_9),
									Class5.smethod_11(int_),
									Class5.smethod_11(int_2),
									Class5.smethod_11(int_3),
									Class5.smethod_11(int_6),
									Class5.smethod_11(int_4),
									Class5.smethod_11(int_5),
									"00",
									num4.ToString("X2"),
									num5.ToString("X2"),
									Class5.smethod_11(int_10),
									text3.Length.ToString("X2"),
									Class5.smethod_13(text3),
									num6.ToString("X2"),
									num7.ToString("X2"),
									num8.ToString("X2"),
									Class5.smethod_12(int_11),
									"000000000000",
									Class5.smethod_12(int_12),
									"000000000000",
									Class5.smethod_12(int_13),
									"000000000000",
									Class5.smethod_12(int_14),
									"000000000000",
									Class5.smethod_12(int_15),
									"000000000000",
									Class5.smethod_12(int_16),
									"000000000000000000000000"
								});
								text2 = text2 + num.ToString("X2") + "0000";
							}
						}
						oleDbDataReader.Close();
						num++;
					}
					while (num <= 4);
					if (text.Length > 0)
					{
						Server.SendToClient(_IdPlayer, string.Concat(new string[]
						{
							"F444",
							Class5.smethod_11((int)Math.Round((double)text.Length / 2.0) + 2),
							"0F08",
							text,
							"F444",
							Class5.smethod_11((int)Math.Round((double)text2.Length / 2.0) + 2),
							"0F14",
							text2,
							"F44402000F0AF44405000F12010000F44405000F12020000F44405000F12030000F44405000F12040000F44404000F130100"
						}));
					}
				}
			}
		}
		public static void SendStatusPet(OleDbConnection conn, int _IdPlayer, int Stt)
		{
			int num = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._ID);
			checked
			{
				if (num > 0)
				{
					int lv = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Lv);
					string text = Data.PetGetDataName(conn, Stt, DataStructure.Type_Pet._Name);
					Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Thuoctinh);
					int reborn = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Reborn);
					int int_ = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Int);
					int int_2 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Atk);
					int int_3 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Def);
					int num2 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Hpx);
					int num3 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Spx);
					int int_4 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Agi);
					int num4 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Fai);
					int int_5 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Texp);
					Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Int2);
					Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Atk2);
					Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Def2);
					int num5 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Hpx2);
					int num6 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Spx2);
					Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Agi2);
					Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Thd);
					int int_6 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Hp);
					int arg_130_0 = Data.CongthucHP(reborn, 1, lv, num2) + num5;
					int int_7 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Sp);
					int arg_14C_0 = Data.CongthucSP(reborn, 1, lv, num3) + num6;
					int int_8 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._SkillPoint);
					int num7 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._Quest);
					Data.PetGetData(conn, Stt, DataStructure.Type_Pet._IdSkill1);
					Data.PetGetData(conn, Stt, DataStructure.Type_Pet._IdSkill2);
					Data.PetGetData(conn, Stt, DataStructure.Type_Pet._IdSkill3);
					Data.PetGetData(conn, Stt, DataStructure.Type_Pet._IdSkill4);
					int num8 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._LvSkill1);
					int num9 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._LvSkill2);
					int num10 = Data.PetGetData(conn, Stt, DataStructure.Type_Pet._LvSkill3);
					Data.PetGetData(conn, Stt, DataStructure.Type_Pet._LvSkill4);
					string text2 = string.Concat(new string[]
					{
						Stt.ToString("X2"),
						Class5.smethod_11(num),
						Class5.smethod_12(int_5),
						lv.ToString("X2"),
						Class5.smethod_11(int_6),
						Class5.smethod_11(int_7),
						Class5.smethod_11(int_),
						Class5.smethod_11(int_2),
						Class5.smethod_11(int_3),
						Class5.smethod_11(int_4),
						Class5.smethod_11(num2),
						Class5.smethod_11(num3),
						"00",
						num4.ToString("X2"),
						num7.ToString("X2"),
						Class5.smethod_11(int_8),
						text.Length.ToString("X2"),
						Class5.smethod_13(text),
						num8.ToString("X2"),
						num9.ToString("X2"),
						num10.ToString("X2"),
						"000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"
					});
					Server.SendToClient(_IdPlayer, "F444" + Class5.smethod_11(text2.Length + 2) + "0F08" + text2);
				}
			}
		}
		public static void ChangeNamePet(int _IdPlayer, int _stt, string _name)
		{
			if (Server.Clients.ContainsKey(_IdPlayer))
			{
				Client client = Server.Clients[_IdPlayer];
				int num = Data.PetGetData(client.conn, _stt, DataStructure.Type_Pet._ID);
				if (num > 0)
				{
					Data.PetUpdateDataName(client.conn, _stt, DataStructure.Type_Pet._Name, _name);
					DataStructure._MyPet value = Server.Clients[_IdPlayer].ListPet[_stt];
					value._Name = _name;
					Server.Clients[_IdPlayer].ListPet[_stt] = value;
					string text = "0F09" + Class5.smethod_12(_IdPlayer) + _stt.ToString("X2") + Class5.smethod_13(_name);
					Server.SendToAllMapid(client._My_MapId, "F444" + Class5.smethod_11(checked((int)Math.Round((double)text.Length / 2.0))) + text);
				}
			}
		}
		public static void Removepet(int _IdPlayer, int _stt)
		{
			if (Server.Clients.ContainsKey(_IdPlayer))
			{
				Client client = Server.Clients[_IdPlayer];
				int num = Data.PetGetData(client.conn, _stt, DataStructure.Type_Pet._ID);
				if (num > 0)
				{
					Data.PetUpdateAllData(client.conn, _stt, 0, 0, " ", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
					DataStructure._MyPet value = default(DataStructure._MyPet);
					Server.Clients[_IdPlayer].ListPet[_stt] = value;
					Server.SendToAllMapid(client._My_MapId, "F44407000F02" + Class5.smethod_12(_IdPlayer) + _stt.ToString("X2"));
				}
			}
		}
		public static void Addpet(int _IdPlayer, int _id)
		{
			if (Server.Clients.ContainsKey(_IdPlayer))
			{
				Client client = Server.Clients[_IdPlayer];
				if (Data.PetExits(client.conn, _id))
				{
					return;
				}
				int num = 0;
				int num2 = Data.PetGetData(client.conn, 1, DataStructure.Type_Pet._ID);
				int num3 = Data.PetGetData(client.conn, 2, DataStructure.Type_Pet._ID);
				int num4 = Data.PetGetData(client.conn, 3, DataStructure.Type_Pet._ID);
				int num5 = Data.PetGetData(client.conn, 4, DataStructure.Type_Pet._ID);
				if (num2 == 0 & true)
				{
					num = 1;
				}
				else
				{
					if (num3 == 0 & num == 0)
					{
						num = 2;
					}
					else
					{
						if (num4 == 0 & num == 0)
						{
							num = 3;
						}
						else
						{
							if (num5 == 0 & num == 0)
							{
								num = 4;
							}
						}
					}
				}
				if (num > 0 && Data.GetDataNpcExits(_id))
				{
					int lv = 1;
					string dataNpcName = Data.GetDataNpcName(_id, DataStructure.Type_Npc._Name);
					int dataNpc = Data.GetDataNpc(_id, DataStructure.Type_Npc._Thuoctinh);
					int dataNpc2 = Data.GetDataNpc(_id, DataStructure.Type_Npc._Reborn);
					int dataNpc3 = Data.GetDataNpc(_id, DataStructure.Type_Npc._Int);
					int dataNpc4 = Data.GetDataNpc(_id, DataStructure.Type_Npc._Atk);
					int dataNpc5 = Data.GetDataNpc(_id, DataStructure.Type_Npc._Def);
					int dataNpc6 = Data.GetDataNpc(_id, DataStructure.Type_Npc._Hpx);
					int dataNpc7 = Data.GetDataNpc(_id, DataStructure.Type_Npc._Spx);
					int dataNpc8 = Data.GetDataNpc(_id, DataStructure.Type_Npc._Agi);
					int fai = 60;
					int texp = 6;
					int dataNpc9 = Data.GetDataNpc(_id, DataStructure.Type_Npc._Skill1);
					int dataNpc10 = Data.GetDataNpc(_id, DataStructure.Type_Npc._Skill2);
					int dataNpc11 = Data.GetDataNpc(_id, DataStructure.Type_Npc._Skill3);
					int idSkill = 0;
					int lvSkill = 0;
					int lvSkill2 = 0;
					int lvSkill3 = 0;
					int lvSkill4 = 0;
					if (dataNpc9 > 0)
					{
						lvSkill = 1;
					}
					if (dataNpc10 > 0)
					{
						lvSkill2 = 1;
					}
					if (dataNpc11 > 0)
					{
						lvSkill3 = 1;
					}
					int num6 = Data.CongthucHPPet(dataNpc2, lv, dataNpc6);
					int hpMax = Data.CongthucHPPet(dataNpc2, lv, dataNpc6);
					int num7 = Data.CongthucSPPet(dataNpc2, lv, dataNpc7);
					int spMax = Data.CongthucSPPet(dataNpc2, lv, dataNpc7);
					int num8 = 1;
					Data.PetUpdateAllData(client.conn, num, _id, lv, dataNpcName, dataNpc, dataNpc2, num6, hpMax, num7, spMax, dataNpc3, dataNpc4, dataNpc5, dataNpc6, dataNpc7, dataNpc8, fai, texp, 0, 0, 0, 0, 0, 0, 0, 0, 1, dataNpc9, lvSkill, dataNpc10, lvSkill2, dataNpc11, lvSkill3, idSkill, lvSkill4);
					DataStructure._MyPet value = Server.Clients[_IdPlayer].ListPet[num];
					value._Id = _id;
					value._Name = dataNpcName;
					value._Quest = 1;
					Server.Clients[_IdPlayer].ListPet[num] = value;
					Data.PetUpdateStatus(_IdPlayer, num, DataStructure.Type_Status._Hp, num6);
					Data.PetUpdateStatus(_IdPlayer, num, DataStructure.Type_Status._Sp, num7);
					Server.SendToAllMapid(client._My_MapId, string.Concat(new string[]
					{
						"F4440C000F01",
						Class5.smethod_12(_IdPlayer),
						num.ToString("X2"),
						Class5.smethod_12(_id),
						num8.ToString("X2")
					}));
					string text = string.Concat(new string[]
					{
						num.ToString("X2"),
						Class5.smethod_12(_id),
						"0000000000",
						num8.ToString("X2"),
						dataNpcName.Length.ToString("X2"),
						Class5.smethod_13(dataNpcName)
					});
					if (text.Length > 0)
					{
						text = string.Concat(new string[]
						{
							"F444",
							Class5.smethod_11(checked(6 + (int)Math.Round((double)text.Length / 2.0))),
							"0F07",
							Class5.smethod_12(_id),
							text
						});
						Server.SendToAllMapid(client._My_MapId, text);
					}
				}
			}
		}
		public static void PetUpdateAllData(OleDbConnection conn, int Stt, int _id, int _Lv, string _Name, int _Thuoctinh, int _Reborn, int _Hp, int _HpMax, int _Sp, int _SpMax, int _Int, int _Atk, int _Def, int _Hpx, int _Spx, int _Agi, int _Fai, int _Texp, int _Int2, int _Atk2, int _Def2, int _Hpx2, int _Spx2, int _Agi2, int _Thd, int _SkillPoint, int _Quest, int _IdSkill1, int _LvSkill1, int _IdSkill2, int _LvSkill2, int _IdSkill3, int _LvSkill3, int _IdSkill4, int _LvSkill4)
		{
			string cmdText = string.Concat(new string[]
			{
				"UPDATE Pet SET Id = ",
				Conversions.ToString(_id),
				", [Name] = '",
				_Name,
				"', Lv = ",
				Conversions.ToString(_Lv),
				", Thuoctinh = ",
				Conversions.ToString(_Thuoctinh),
				", Reborn = ",
				Conversions.ToString(_Reborn),
				", Hp = ",
				Conversions.ToString(_Hp),
				", HpMax = ",
				Conversions.ToString(_HpMax),
				", Sp = ",
				Conversions.ToString(_Sp),
				", SpMax = ",
				Conversions.ToString(_SpMax),
				", [Int] = ",
				Conversions.ToString(_Int),
				", Atk = ",
				Conversions.ToString(_Atk),
				", Def = ",
				Conversions.ToString(_Def),
				", Hpx = ",
				Conversions.ToString(_Hpx),
				", Spx = ",
				Conversions.ToString(_Spx),
				", Agi = ",
				Conversions.ToString(_Agi),
				", Fai = ",
				Conversions.ToString(_Fai),
				", Texp = ",
				Conversions.ToString(_Texp),
				", Int2 = ",
				Conversions.ToString(_Int2),
				", Atk2 = ",
				Conversions.ToString(_Atk2),
				", Def2 = ",
				Conversions.ToString(_Def2),
				", Hpx2 = ",
				Conversions.ToString(_Hpx2),
				", Spx2 = ",
				Conversions.ToString(_Spx2),
				", Agi2 = ",
				Conversions.ToString(_Agi2),
				", Thd = ",
				Conversions.ToString(_Thd),
				", SkillPoint = ",
				Conversions.ToString(_SkillPoint),
				", Quest = ",
				Conversions.ToString(_Quest),
				", IdSkill1 = ",
				Conversions.ToString(_IdSkill1),
				", LvSkill1 = ",
				Conversions.ToString(_LvSkill1),
				", IdSkill2 = ",
				Conversions.ToString(_IdSkill2),
				", LvSkill2 = ",
				Conversions.ToString(_LvSkill2),
				", IdSkill3 = ",
				Conversions.ToString(_IdSkill3),
				", LvSkill3 = ",
				Conversions.ToString(_LvSkill3),
				", IdSkill4 = ",
				Conversions.ToString(_IdSkill4),
				", LvSkill4 = ",
				Conversions.ToString(_LvSkill4),
				" WHERE Stt = ",
				Conversions.ToString(Stt)
			});
			OleDbCommand oleDbCommand = new OleDbCommand(cmdText, conn);
			oleDbCommand.ExecuteNonQuery();
		}
		public static bool PetExits(OleDbConnection conn, int Id)
		{
			bool result = false;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Pet Where Id=" + Conversions.ToString(Id), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = true;
			}
			oleDbDataReader.Close();
			return result;
		}
		public static bool PetExitsMangtheo(OleDbConnection conn, int Id)
		{
			bool result = false;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Pet Where Id=" + Conversions.ToString(Id) + " And Stt <= 4", conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = true;
			}
			oleDbDataReader.Close();
			return result;
		}
		public static bool PetExitsNhatro(OleDbConnection conn, int Id)
		{
			bool result = false;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Pet Where Id=" + Conversions.ToString(Id) + " And Stt > 4", conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = true;
			}
			oleDbDataReader.Close();
			return result;
		}
		public static int PetGetStt(OleDbConnection conn, int Id)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Pet Where Id=" + Conversions.ToString(Id), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader["Stt"]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static int PetGetData(OleDbConnection conn, int Stt, string type)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Pet Where Stt = " + Conversions.ToString(Stt), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader[type]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static string PetGetDataName(OleDbConnection conn, int Stt, string type)
		{
			string result = "";
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Pet Where Stt = " + Conversions.ToString(Stt), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToString(oleDbDataReader[type]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static void PetUpdateData(int _Idplayer, int Stt, string type, int value)
		{
			checked
			{
				if (Server.ListView_Client.Items.ContainsKey(_Idplayer.ToString()))
				{
					Client client = (Client)Server.ListView_Client.Items[_Idplayer.ToString()].Tag;
					string cmdText = string.Concat(new string[]
					{
						"UPDATE Pet SET [",
						type,
						"] = ",
						Conversions.ToString(value),
						" WHERE Stt = ",
						Conversions.ToString(Stt)
					});
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, client.conn);
					oleDbCommand.ExecuteNonQuery();
					string text;
					if (value >= 0)
					{
						text = "01";
					}
					else
					{
						text = "02";
						value *= -1;
					}
					string text2 = "";
					if (Operators.CompareString(type, DataStructure.Type_Pet._Hp, false) == 0)
					{
						text2 = DataStructure.Type_Status._Hp;
					}
					else
					{
						if (Operators.CompareString(type, DataStructure.Type_Pet._Sp, false) == 0)
						{
							text2 = DataStructure.Type_Status._Sp;
						}
						else
						{
							if (Operators.CompareString(type, DataStructure.Type_Pet._Int, false) == 0)
							{
								text2 = DataStructure.Type_Status._Int;
							}
							else
							{
								if (Operators.CompareString(type, DataStructure.Type_Pet._Atk, false) == 0)
								{
									text2 = DataStructure.Type_Status._atk;
								}
								else
								{
									if (Operators.CompareString(type, DataStructure.Type_Pet._Def, false) == 0)
									{
										text2 = DataStructure.Type_Status._def;
									}
									else
									{
										if (Operators.CompareString(type, DataStructure.Type_Pet._Agi, false) == 0)
										{
											text2 = DataStructure.Type_Status._agi;
										}
										else
										{
											if (Operators.CompareString(type, DataStructure.Type_Pet._Hpx, false) == 0)
											{
												text2 = DataStructure.Type_Status._hpx;
											}
											else
											{
												if (Operators.CompareString(type, DataStructure.Type_Pet._Spx, false) == 0)
												{
													text2 = DataStructure.Type_Status._spx;
												}
												else
												{
													if (Operators.CompareString(type, DataStructure.Type_Pet._Lv, false) == 0)
													{
														text2 = DataStructure.Type_Status._lv;
													}
													else
													{
														if (Operators.CompareString(type, DataStructure.Type_Pet._Texp, false) == 0)
														{
															text2 = DataStructure.Type_Status._TExp;
														}
														else
														{
															if (Operators.CompareString(type, DataStructure.Type_Pet._SkillPoint, false) == 0)
															{
																text2 = DataStructure.Type_Status._SkillPoint;
															}
															else
															{
																if (Operators.CompareString(type, DataStructure.Type_Pet._Int2, false) == 0)
																{
																	text2 = DataStructure.Type_Status._Int2;
																}
																else
																{
																	if (Operators.CompareString(type, DataStructure.Type_Pet._Atk2, false) == 0)
																	{
																		text2 = DataStructure.Type_Status._Atk2;
																	}
																	else
																	{
																		if (Operators.CompareString(type, DataStructure.Type_Pet._Def2, false) == 0)
																		{
																			text2 = DataStructure.Type_Status._Def2;
																		}
																		else
																		{
																			if (Operators.CompareString(type, DataStructure.Type_Pet._Agi2, false) == 0)
																			{
																				text2 = DataStructure.Type_Status._Agi2;
																			}
																			else
																			{
																				if (Operators.CompareString(type, DataStructure.Type_Pet._Hpx2, false) == 0)
																				{
																					text2 = DataStructure.Type_Status._Hpx2;
																				}
																				else
																				{
																					if (Operators.CompareString(type, DataStructure.Type_Pet._Spx2, false) == 0)
																					{
																						text2 = DataStructure.Type_Status._Spx2;
																					}
																					else
																					{
																						if (Operators.CompareString(type, DataStructure.Type_Pet._Fai, false) == 0)
																						{
																							text2 = DataStructure.Type_Status._Fai;
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
					if (text2.Length > 0)
					{
						client.Sendpacket(string.Concat(new string[]
						{
							"F4440F00080204",
							Class5.smethod_11(Stt),
							text2,
							text,
							Class5.smethod_12(value),
							"00000000"
						}));
					}
				}
			}
		}
		public static void PetUpdateDataName(OleDbConnection conn, int Stt, string type, string value)
		{
			string cmdText = string.Concat(new string[]
			{
				"UPDATE Pet SET ",
				type,
				" = '",
				value,
				"' WHERE Stt = ",
				Conversions.ToString(Stt)
			});
			OleDbCommand oleDbCommand = new OleDbCommand(cmdText, conn);
			oleDbCommand.ExecuteNonQuery();
		}
		public static DataStructure.HomdoInfo TrangbiGetDataItem(OleDbConnection conn, int Slot)
		{
			DataStructure.HomdoInfo result = default(DataStructure.HomdoInfo);
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Trangbi Where Slot=" + Conversions.ToString(Slot), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result._ID = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._ID]);
				result._Lv = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Lv]);
				result._Count = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Count]);
				result._Doben = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Doben]);
				result._Int1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Int1]);
				result._Atk1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Atk1]);
				result._Def1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Def1]);
				result._Hpx1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hpx1]);
				result._Spx1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Spx1]);
				result._Agi1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Agi1]);
				result._Fai1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Fai1]);
				result._Int2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Int2]);
				result._Atk2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Atk2]);
				result._Def2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Def2]);
				result._Hpx2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hpx2]);
				result._Spx2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Spx2]);
				result._Agi2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Agi2]);
				result._Fai2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Fai2]);
				result._Hp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hp]);
				result._Sp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Sp]);
				result._Long = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Long]);
				result._GiatriLong = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._GiatriLong]);
				result._Khang = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Khang]);
				result._Thuoctinh = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Thuoctinh]);
				result._GiatriThuoctinh = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._GiatriThuoctinh]);
				result._Loai = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Loai]);
				result._TExp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._TExp]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static int TrangbiGetDataItem(OleDbConnection conn, int Slot, string Type)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Trangbi Where Slot=" + Conversions.ToString(Slot), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader[Type]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static void TrangbiUpdateItem(OleDbConnection conn, int Slot, string type, int value)
		{
			string cmdText = string.Concat(new string[]
			{
				"UPDATE Trangbi SET ",
				type,
				" = ",
				Conversions.ToString(value),
				" WHERE Slot = ",
				Conversions.ToString(Slot)
			});
			OleDbCommand oleDbCommand = new OleDbCommand(cmdText, conn);
			oleDbCommand.ExecuteNonQuery();
		}
		public static void TrangbiRemoveItem(int _IdPlayer, int tbslot, int hdslot)
		{
			if (Server.Clients.ContainsKey(_IdPlayer))
			{
				Data.MoveItem(Server.Clients[_IdPlayer].conn, DataStructure.Type_Thung._Trangbi, tbslot, DataStructure.Type_Thung._Homdo, hdslot);
			}
		}
		public static void TrangbiRemoveItem_Pet(int _IdPlayer, int stt, int tbslot, int hdslot)
		{
			if (Server.Clients.ContainsKey(_IdPlayer))
			{
				Client client = Server.Clients[_IdPlayer];
				Data.MoveItem(client.conn, DataStructure.Type_Thung._Trangbi, tbslot, DataStructure.Type_Thung._Homdo, hdslot);
			}
		}
		public static void TienTrangUpdateMoney(OleDbConnection conn, int _money)
		{
			string cmdText = "UPDATE TienTrang SET Id = 0 , [Count] = " + Conversions.ToString(_money) + " , Lv = 0 , Doben = 0 , Int1 = 0 , Atk1 = 0 , Def1 = 0 , Hpx1 = 0 , Spx1 = 0 , Agi1 = 0 , Fai1 = 0 , Int2 = 0 , Atk2 = 0 , Def2 = 0 , Hpx2 = 0 , Spx2 = 0 , Agi2 = 0 , Fai2 = 0 , Hp = 0 , Sp = 0 , [Long] = 0 , GiatriLong = 0 , Khang = 0 , Thuoctinh = 0 , GiatriThuoctinh = 0 , Loai = 0 , Texp = 0 WHERE Slot = 0";
			OleDbCommand oleDbCommand = new OleDbCommand(cmdText, conn);
			oleDbCommand.ExecuteNonQuery();
		}
		public static int TienTrangGetDataMoney(OleDbConnection conn)
		{
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM TienTrang Where Slot=0", conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			int result = 0;
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Count]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static void MoveItem(OleDbConnection conn, string thung1, int slot1, string thung2, int slot2)
		{
			int value = 0;
			int value2 = 0;
			int value3 = 0;
			int value4 = 0;
			int value5 = 0;
			int value6 = 0;
			int value7 = 0;
			int value8 = 0;
			int value9 = 0;
			int value10 = 0;
			int value11 = 0;
			int value12 = 0;
			int value13 = 0;
			int value14 = 0;
			int value15 = 0;
			int value16 = 0;
			int value17 = 0;
			int value18 = 0;
			int value19 = 0;
			int value20 = 0;
			int value21 = 0;
			int value22 = 0;
			int value23 = 0;
			int value24 = 0;
			int value25 = 0;
			int value26 = 0;
			int value27 = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM " + thung1 + " Where Slot=" + Conversions.ToString(slot1), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				value = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._ID]);
				value3 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Count]);
				value2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Lv]);
				value4 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Doben]);
				value5 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Int1]);
				value6 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Atk1]);
				value7 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Def1]);
				value8 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hpx1]);
				value9 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Spx1]);
				value10 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Agi1]);
				value11 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Fai1]);
				value12 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Int2]);
				value13 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Atk2]);
				value14 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Def2]);
				value15 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hpx2]);
				value16 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Spx2]);
				value17 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Agi2]);
				value18 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Fai2]);
				value19 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hp]);
				value20 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Sp]);
				value21 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Long]);
				value22 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._GiatriLong]);
				value23 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Khang]);
				value24 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Thuoctinh]);
				value25 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._GiatriThuoctinh]);
				value26 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Loai]);
				value27 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._TExp]);
			}
			oleDbDataReader.Close();
			int value28 = 0;
			int value29 = 0;
			int value30 = 0;
			int value31 = 0;
			int value32 = 0;
			int value33 = 0;
			int value34 = 0;
			int value35 = 0;
			int value36 = 0;
			int value37 = 0;
			int value38 = 0;
			int value39 = 0;
			int value40 = 0;
			int value41 = 0;
			int value42 = 0;
			int value43 = 0;
			int value44 = 0;
			int value45 = 0;
			int value46 = 0;
			int value47 = 0;
			int value48 = 0;
			int value49 = 0;
			int value50 = 0;
			int value51 = 0;
			int value52 = 0;
			int value53 = 0;
			int value54 = 0;
			OleDbCommand oleDbCommand2 = new OleDbCommand("SELECT * FROM " + thung2 + " Where Slot=" + Conversions.ToString(slot2), conn);
			OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
			if (oleDbDataReader2.Read())
			{
				value28 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._ID]);
				value30 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Count]);
				value29 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Lv]);
				value31 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Doben]);
				value32 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Int1]);
				value33 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Atk1]);
				value34 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Def1]);
				value35 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Hpx1]);
				value36 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Spx1]);
				value37 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Agi1]);
				value38 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Fai1]);
				value39 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Int2]);
				value40 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Atk2]);
				value41 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Def2]);
				value42 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Hpx2]);
				value43 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Spx2]);
				value44 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Agi2]);
				value45 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Fai2]);
				value46 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Hp]);
				value47 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Sp]);
				value48 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Long]);
				value49 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._GiatriLong]);
				value50 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Khang]);
				value51 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Thuoctinh]);
				value52 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._GiatriThuoctinh]);
				value53 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Loai]);
				value54 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._TExp]);
			}
			oleDbDataReader2.Close();
			string cmdText = string.Concat(new string[]
			{
				"UPDATE ",
				thung1,
				" SET Id = ",
				Conversions.ToString(value28),
				" , [Count] = ",
				Conversions.ToString(value30),
				" , Lv = ",
				Conversions.ToString(value29),
				" , Doben = ",
				Conversions.ToString(value31),
				" , Int1 = ",
				Conversions.ToString(value32),
				" , Atk1 = ",
				Conversions.ToString(value33),
				" , Def1 = ",
				Conversions.ToString(value34),
				" , Hpx1 = ",
				Conversions.ToString(value35),
				" , Spx1 = ",
				Conversions.ToString(value36),
				" , Agi1 = ",
				Conversions.ToString(value37),
				" , Fai1 = ",
				Conversions.ToString(value38),
				" , Int2 = ",
				Conversions.ToString(value39),
				" , Atk2 = ",
				Conversions.ToString(value40),
				" , Def2 = ",
				Conversions.ToString(value41),
				" , Hpx2 = ",
				Conversions.ToString(value42),
				" , Spx2 = ",
				Conversions.ToString(value43),
				" , Agi2 = ",
				Conversions.ToString(value44),
				" , Fai2 = ",
				Conversions.ToString(value45),
				" , Hp = ",
				Conversions.ToString(value46),
				" , Sp = ",
				Conversions.ToString(value47),
				" , [Long] = ",
				Conversions.ToString(value48),
				" , GiatriLong = ",
				Conversions.ToString(value49),
				" , Khang = ",
				Conversions.ToString(value50),
				" , Thuoctinh = ",
				Conversions.ToString(value51),
				" , GiatriThuoctinh = ",
				Conversions.ToString(value52),
				" , Loai = ",
				Conversions.ToString(value53),
				" , Texp = ",
				Conversions.ToString(value54),
				" WHERE Slot = ",
				Conversions.ToString(slot1)
			});
			oleDbCommand = new OleDbCommand(cmdText, conn);
			oleDbCommand.ExecuteNonQuery();
			string cmdText2 = string.Concat(new string[]
			{
				"UPDATE ",
				thung2,
				" SET Id = ",
				Conversions.ToString(value),
				" , [Count] = ",
				Conversions.ToString(value3),
				" , Lv = ",
				Conversions.ToString(value2),
				" , Doben = ",
				Conversions.ToString(value4),
				" , Int1 = ",
				Conversions.ToString(value5),
				" , Atk1 = ",
				Conversions.ToString(value6),
				" , Def1 = ",
				Conversions.ToString(value7),
				" , Hpx1 = ",
				Conversions.ToString(value8),
				" , Spx1 = ",
				Conversions.ToString(value9),
				" , Agi1 = ",
				Conversions.ToString(value10),
				" , Fai1 = ",
				Conversions.ToString(value11),
				" , Int2 = ",
				Conversions.ToString(value12),
				" , Atk2 = ",
				Conversions.ToString(value13),
				" , Def2 = ",
				Conversions.ToString(value14),
				" , Hpx2 = ",
				Conversions.ToString(value15),
				" , Spx2 = ",
				Conversions.ToString(value16),
				" , Agi2 = ",
				Conversions.ToString(value17),
				" , Fai2 = ",
				Conversions.ToString(value18),
				" , Hp = ",
				Conversions.ToString(value19),
				" , Sp = ",
				Conversions.ToString(value20),
				" , [Long] = ",
				Conversions.ToString(value21),
				" , GiatriLong = ",
				Conversions.ToString(value22),
				" , Khang = ",
				Conversions.ToString(value23),
				" , Thuoctinh = ",
				Conversions.ToString(value24),
				" , GiatriThuoctinh = ",
				Conversions.ToString(value25),
				" , Loai = ",
				Conversions.ToString(value26),
				" , Texp = ",
				Conversions.ToString(value27),
				" WHERE Slot = ",
				Conversions.ToString(slot2)
			});
			oleDbCommand2 = new OleDbCommand(cmdText2, conn);
			oleDbCommand2.ExecuteNonQuery();
		}
		public static int GetDataItemThung(OleDbConnection conn, string thung, int Slot, string Type)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM " + thung + " Where Slot=" + Conversions.ToString(Slot), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader[Type]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static DataStructure.HomdoInfo TuideoGetDataItem(OleDbConnection conn, int Slot)
		{
			DataStructure.HomdoInfo result = default(DataStructure.HomdoInfo);
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Tuideo Where Slot=" + Conversions.ToString(Slot), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result._ID = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._ID]);
				result._Lv = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Lv]);
				result._Count = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Count]);
				result._Doben = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Doben]);
				result._Int1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Int1]);
				result._Atk1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Atk1]);
				result._Def1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Def1]);
				result._Hpx1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hpx1]);
				result._Spx1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Spx1]);
				result._Agi1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Agi1]);
				result._Fai1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Fai1]);
				result._Int2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Int2]);
				result._Atk2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Atk2]);
				result._Def2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Def2]);
				result._Hpx2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hpx2]);
				result._Spx2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Spx2]);
				result._Agi2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Agi2]);
				result._Fai2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Fai2]);
				result._Hp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hp]);
				result._Sp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Sp]);
				result._Long = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Long]);
				result._GiatriLong = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._GiatriLong]);
				result._Khang = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Khang]);
				result._Thuoctinh = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Thuoctinh]);
				result._GiatriThuoctinh = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._GiatriThuoctinh]);
				result._Loai = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Loai]);
				result._TExp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._TExp]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static int TuideoGetSlotNothing(OleDbConnection conn)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Tuideo Where Id=0", conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader["Slot"]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static DataStructure.HomdoInfo LuulangGetDataItem(OleDbConnection conn, int Slot)
		{
			DataStructure.HomdoInfo result = default(DataStructure.HomdoInfo);
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM LuuLang Where Slot=" + Conversions.ToString(Slot), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result._ID = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._ID]);
				result._Lv = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Lv]);
				result._Count = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Count]);
				result._Doben = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Doben]);
				result._Int1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Int1]);
				result._Atk1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Atk1]);
				result._Def1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Def1]);
				result._Hpx1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hpx1]);
				result._Spx1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Spx1]);
				result._Agi1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Agi1]);
				result._Fai1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Fai1]);
				result._Int2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Int2]);
				result._Atk2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Atk2]);
				result._Def2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Def2]);
				result._Hpx2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hpx2]);
				result._Spx2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Spx2]);
				result._Agi2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Agi2]);
				result._Fai2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Fai2]);
				result._Hp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hp]);
				result._Sp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Sp]);
				result._Long = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Long]);
				result._GiatriLong = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._GiatriLong]);
				result._Khang = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Khang]);
				result._Thuoctinh = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Thuoctinh]);
				result._GiatriThuoctinh = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._GiatriThuoctinh]);
				result._Loai = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Loai]);
				result._TExp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._TExp]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static int LuulangGetSlotNothing(OleDbConnection conn)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Luulang Where Id=0", conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader["Slot"]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static int HomdoGetSlotNothing(OleDbConnection conn)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Homdo Where Id=0", conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader["Slot"]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static int HomdoGetSlotExits(OleDbConnection conn, int Id)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Homdo Where ID = " + Conversions.ToString(Id), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader["Slot"]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static int HomdoGetSlotConstainId50(OleDbConnection conn, int Id)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Homdo Where ID = " + Conversions.ToString(Id) + " AND Count <> 50", conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader["Slot"]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static DataStructure.HomdoInfo HomdoGetDataItem(OleDbConnection conn, int Slot)
		{
			DataStructure.HomdoInfo result = default(DataStructure.HomdoInfo);
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Homdo Where Slot=" + Conversions.ToString(Slot), conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result._ID = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._ID]);
				result._Lv = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Lv]);
				result._Count = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Count]);
				result._Doben = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Doben]);
				result._Int1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Int1]);
				result._Atk1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Atk1]);
				result._Def1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Def1]);
				result._Hpx1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hpx1]);
				result._Spx1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Spx1]);
				result._Agi1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Agi1]);
				result._Fai1 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Fai1]);
				result._Int2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Int2]);
				result._Atk2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Atk2]);
				result._Def2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Def2]);
				result._Hpx2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hpx2]);
				result._Spx2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Spx2]);
				result._Agi2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Agi2]);
				result._Fai2 = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Fai2]);
				result._Hp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Hp]);
				result._Sp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Sp]);
				result._Long = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Long]);
				result._GiatriLong = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._GiatriLong]);
				result._Khang = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Khang]);
				result._Thuoctinh = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Thuoctinh]);
				result._GiatriThuoctinh = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._GiatriThuoctinh]);
				result._Loai = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._Loai]);
				result._TExp = Conversions.ToInteger(oleDbDataReader[DataStructure.Type_Homdo._TExp]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public static void HomdoAddItem(int _IdPlayer, int ID, int Count)
		{
			checked
			{
				if (Server.Clients.ContainsKey(_IdPlayer))
				{
					Client client = Server.Clients[_IdPlayer];
					int num = 0;
					if (Data.GetDataItemExits(ID))
					{
						int dataItem = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Loai);
						if (dataItem >= 1 & dataItem <= 6)
						{
							int num2 = Data.HomdoGetSlotNothing(client.conn);
							if (num2 != 0)
							{
								DataStructure.HomdoInfo homdo = default(DataStructure.HomdoInfo);
								homdo._ID = ID;
								homdo._Count = 1;
								homdo._Lv = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Lv);
								homdo._Int1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Int1);
								homdo._Atk1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Atk1);
								homdo._Def1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Def1);
								homdo._Hpx1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Hpx1);
								homdo._Spx1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Spx1);
								homdo._Agi1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Agi1);
								homdo._Fai1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Fai1);
								homdo._Int2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Int2);
								homdo._Atk2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Atk2);
								homdo._Def2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Def2);
								homdo._Hpx2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Hpx2);
								homdo._Spx2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Spx2);
								homdo._Agi2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Agi2);
								homdo._Fai2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Fai2);
								homdo._Hp = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Hp);
								homdo._Sp = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Sp);
								homdo._Thuoctinh = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Thuoctinh);
								homdo._GiatriThuoctinh = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._GiatriThuoctinh);
								homdo._Loai = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Loai);
								Data.HomdoUpdateSlot(client.conn, num2, homdo);
								Server.SendToClient(_IdPlayer, "F4440E001706" + Class5.smethod_11(ID) + "01000000000000000000");
								return;
							}
							Server.SendToClient(_IdPlayer, "F44403001B0102");
							return;
						}
						else
						{
							if (Data.HomdoGetSlotConstainId50(client.conn, ID) == 0)
							{
								if (Data.HomdoGetSlotNothing(client.conn) == 0)
								{
									Server.SendToClient(_IdPlayer, "F44403001B0102");
									return;
								}
								if (Data.HomdoGetSlotNothing(client.conn) != 0)
								{
									int num3 = Data.HomdoGetSlotNothing(client.conn);
									if (num3 != 0)
									{
										DataStructure.HomdoInfo homdo2 = default(DataStructure.HomdoInfo);
										homdo2._ID = ID;
										homdo2._Count = Count;
										homdo2._Lv = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Lv);
										homdo2._Int1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Int1);
										homdo2._Atk1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Atk1);
										homdo2._Def1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Def1);
										homdo2._Hpx1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Hpx1);
										homdo2._Spx1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Spx1);
										homdo2._Agi1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Agi1);
										homdo2._Fai1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Fai1);
										homdo2._Int2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Int2);
										homdo2._Atk2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Atk2);
										homdo2._Def2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Def2);
										homdo2._Hpx2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Hpx2);
										homdo2._Spx2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Spx2);
										homdo2._Agi2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Agi2);
										homdo2._Fai2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Fai2);
										homdo2._Hp = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Hp);
										homdo2._Sp = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Sp);
										homdo2._Thuoctinh = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Thuoctinh);
										homdo2._GiatriThuoctinh = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._GiatriThuoctinh);
										homdo2._Loai = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Loai);
										Data.HomdoUpdateSlot(client.conn, num3, homdo2);
										Server.SendToClient(_IdPlayer, "F4440E001706" + Class5.smethod_11(ID) + Count.ToString("X2") + "000000000000000000");
									}
									return;
								}
								return;
							}
						}
					}
					while (true)
					{
						int num4 = Data.HomdoGetSlotConstainId50(client.conn, ID);
						if (Count == 0)
						{
							goto Block_11;
						}
						if (num4 == 0)
						{
							break;
						}
						int count = Data.HomdoGetDataItem(client.conn, num4)._Count;
						if (count + Count <= 50)
						{
							Data.HomdoUpdateItem(client.conn, num4, DataStructure.Type_Homdo._Count, Conversions.ToInteger((count + Count).ToString()));
							num += Count;
							Count = 0;
						}
						else
						{
							Data.HomdoUpdateItem(client.conn, num4, DataStructure.Type_Homdo._Count, 50);
							num += 50 - count;
							Count -= 50 - count;
						}
					}
					int num5 = Data.HomdoGetSlotNothing(client.conn);
					if (num5 == 0)
					{
						Server.SendToClient(_IdPlayer, "F4440E001706" + Class5.smethod_11(ID) + num.ToString("X2") + "000000000000000000");
						return;
					}
					num += Count;
					DataStructure.HomdoInfo homdo3 = default(DataStructure.HomdoInfo);
					homdo3._ID = ID;
					homdo3._Count = Count;
					homdo3._Lv = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Lv);
					homdo3._Int1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Int1);
					homdo3._Atk1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Atk1);
					homdo3._Def1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Def1);
					homdo3._Hpx1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Hpx1);
					homdo3._Spx1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Spx1);
					homdo3._Agi1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Agi1);
					homdo3._Fai1 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Fai1);
					homdo3._Int2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Int2);
					homdo3._Atk2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Atk2);
					homdo3._Def2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Def2);
					homdo3._Hpx2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Hpx2);
					homdo3._Spx2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Spx2);
					homdo3._Agi2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Agi2);
					homdo3._Fai2 = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Fai2);
					homdo3._Hp = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Hp);
					homdo3._Sp = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Sp);
					homdo3._Thuoctinh = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Thuoctinh);
					homdo3._GiatriThuoctinh = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._GiatriThuoctinh);
					homdo3._Loai = Data.GetDataItem(Conversions.ToInteger(ID.ToString()), DataStructure.Type_Item._Loai);
					Data.HomdoUpdateSlot(client.conn, num5, homdo3);
					Server.SendToClient(_IdPlayer, "F4440E001706" + Class5.smethod_11(ID) + num.ToString("X2") + "000000000000000000");
					return;
					Block_11:
					Server.SendToClient(_IdPlayer, "F4440E001706" + Class5.smethod_11(ID) + num.ToString("X2") + "000000000000000000");
					return;
				}
			}
		}
		public static void HomdoRemoveItem(int _IdPlayer, int ID, int Count)
		{
			checked
			{
				if (Server.Clients.ContainsKey(_IdPlayer))
				{
					Client client = Server.Clients[_IdPlayer];
					int num = 0;
					int num2 = Data.HomdoGetSlotExits(client.conn, ID);
					int count = Data.HomdoGetDataItem(client.conn, num2)._Count;
					if (num2 != 0)
					{
						if (count == Count)
						{
							DataStructure.HomdoInfo homdo = default(DataStructure.HomdoInfo);
							Data.HomdoUpdateSlot(client.conn, num2, homdo);
							Server.SendToClient(_IdPlayer, "F44405001707" + Class5.smethod_11(ID) + Count.ToString("X2"));
							return;
						}
						if (count > Count)
						{
							Data.HomdoUpdateItem(client.conn, num2, DataStructure.Type_Homdo._Count, Conversions.ToInteger((count - Count).ToString()));
							Server.SendToClient(_IdPlayer, "F44405001707" + Class5.smethod_11(ID) + Count.ToString("X2"));
							return;
						}
						while (true)
						{
							num2 = Data.HomdoGetSlotExits(client.conn, ID);
							if (Count == 0 | num2 == 0)
							{
								goto Block_8;
							}
							count = Data.HomdoGetDataItem(client.conn, num2)._Count;
							if (count == Count)
							{
								break;
							}
							if (count > Count)
							{
								goto IL_195;
							}
							if (count >= Count)
							{
								return;
							}
							DataStructure.HomdoInfo homdo2 = default(DataStructure.HomdoInfo);
							Data.HomdoUpdateSlot(client.conn, num2, homdo2);
							num += count;
							Count -= count;
						}
						DataStructure.HomdoInfo homdo3 = default(DataStructure.HomdoInfo);
						Data.HomdoUpdateSlot(client.conn, num2, homdo3);
						num += Count;
						Count = 0;
						Server.SendToClient(_IdPlayer, "F44405001707" + Class5.smethod_11(ID) + num.ToString("X2"));
						return;
						Block_8:
						Server.SendToClient(_IdPlayer, "F44405001707" + Class5.smethod_11(ID) + num.ToString("X2"));
						return;
						IL_195:
						Data.HomdoUpdateItem(Server.Clients[_IdPlayer].conn, num2, DataStructure.Type_Homdo._Count, Data.HomdoGetDataItem(client.conn, num2)._Count - Count);
						num += Count;
						Count = 0;
						Server.SendToClient(_IdPlayer, "F44405001707" + Class5.smethod_11(ID) + num.ToString("X2"));
						return;
					}
				}
			}
		}
		public static void HomdoRemoveItemSlot(int _IdPlayer, int Slot)
		{
			if (Server.Clients.ContainsKey(_IdPlayer))
			{
				DataStructure.HomdoInfo homdo = default(DataStructure.HomdoInfo);
				Data.HomdoUpdateSlot(Server.Clients[_IdPlayer].conn, Slot, homdo);
				DataStructure.HomdoInfo homdoInfo = Data.HomdoGetDataItem(Server.Clients[_IdPlayer].conn, Slot);
				int count = homdoInfo._Count;
				int iD = homdoInfo._ID;
				Server.SendToClient(_IdPlayer, "F44405001707" + Class5.smethod_11(iD) + count.ToString("X2"));
			}
		}
		public static void HomdoUpdateSlot(OleDbConnection conn, int _slot, DataStructure.HomdoInfo _homdo)
		{
			string cmdText = string.Concat(new string[]
			{
				"UPDATE Homdo SET Id = ",
				Conversions.ToString(_homdo._ID),
				" , [Count] = ",
				Conversions.ToString(_homdo._Count),
				" , Lv = ",
				Conversions.ToString(_homdo._Lv),
				" , Doben = ",
				Conversions.ToString(_homdo._Doben),
				" , Int1 = ",
				Conversions.ToString(_homdo._Int1),
				" , Atk1 = ",
				Conversions.ToString(_homdo._Atk1),
				" , Def1 = ",
				Conversions.ToString(_homdo._Def1),
				" , Hpx1 = ",
				Conversions.ToString(_homdo._Hpx1),
				" , Spx1 = ",
				Conversions.ToString(_homdo._Spx1),
				" , Agi1 = ",
				Conversions.ToString(_homdo._Agi1),
				" , Fai1 = ",
				Conversions.ToString(_homdo._Fai1),
				" , Int2 = ",
				Conversions.ToString(_homdo._Int2),
				" , Atk2 = ",
				Conversions.ToString(_homdo._Atk2),
				" , Def2 = ",
				Conversions.ToString(_homdo._Def2),
				" , Hpx2 = ",
				Conversions.ToString(_homdo._Hpx2),
				" , Spx2 = ",
				Conversions.ToString(_homdo._Spx2),
				" , Agi2 = ",
				Conversions.ToString(_homdo._Agi2),
				" , Fai2 = ",
				Conversions.ToString(_homdo._Fai2),
				" , Hp = ",
				Conversions.ToString(_homdo._Hp),
				" , Sp = ",
				Conversions.ToString(_homdo._Sp),
				" , [Long] = ",
				Conversions.ToString(_homdo._Long),
				" , GiatriLong = ",
				Conversions.ToString(_homdo._GiatriLong),
				" , Khang = ",
				Conversions.ToString(_homdo._Khang),
				" , Thuoctinh = ",
				Conversions.ToString(_homdo._Thuoctinh),
				" , GiatriThuoctinh = ",
				Conversions.ToString(_homdo._GiatriThuoctinh),
				" , Loai = ",
				Conversions.ToString(_homdo._Loai),
				" , Texp = ",
				Conversions.ToString(_homdo._TExp),
				" WHERE Slot = ",
				Conversions.ToString(_slot)
			});
			OleDbCommand oleDbCommand = new OleDbCommand(cmdText, conn);
			oleDbCommand.ExecuteNonQuery();
		}
		public static void HomdoUpdateItem(OleDbConnection conn, int Slot, string type, int value)
		{
			string cmdText = string.Concat(new string[]
			{
				"UPDATE Homdo SET [",
				type,
				"] = ",
				Conversions.ToString(value),
				" WHERE Slot = ",
				Conversions.ToString(Slot)
			});
			OleDbCommand oleDbCommand = new OleDbCommand(cmdText, conn);
			oleDbCommand.ExecuteNonQuery();
		}
		public static void HomdoDropItem(int _IdPlayer, int _hdslot, int count, int Delay)
		{
			checked
			{
				if (Server.Clients.ContainsKey(_IdPlayer))
				{
					Client client = Server.Clients[_IdPlayer];
					int my_MapId = client._My_MapId;
					int num = count;
					string text = "";
					string text2 = "";
					DataStructure.HomdoInfo homdoInfo = Data.HomdoGetDataItem(client.conn, _hdslot);
					int count2 = homdoInfo._Count;
					if (count2 >= num & count2 > 0)
					{
						int iD = homdoInfo._ID;
						int lv = homdoInfo._Lv;
						int doben = homdoInfo._Doben;
						int @int = homdoInfo._Int1;
						int atk = homdoInfo._Atk1;
						int def = homdoInfo._Def1;
						int hpx = homdoInfo._Hpx1;
						int spx = homdoInfo._Spx1;
						int agi = homdoInfo._Agi1;
						int fai = homdoInfo._Fai1;
						int int2 = homdoInfo._Int2;
						int atk2 = homdoInfo._Atk2;
						int def2 = homdoInfo._Def2;
						int hpx2 = homdoInfo._Hpx2;
						int spx2 = homdoInfo._Spx2;
						int agi2 = homdoInfo._Agi2;
						int fai2 = homdoInfo._Fai2;
						int hp = homdoInfo._Hp;
						int sp = homdoInfo._Sp;
						int @long = homdoInfo._Long;
						int giatriLong = homdoInfo._GiatriLong;
						int khang = homdoInfo._Khang;
						int thuoctinh = homdoInfo._Thuoctinh;
						int giatriThuoctinh = homdoInfo._GiatriThuoctinh;
						int loai = homdoInfo._Loai;
						int tExp = homdoInfo._TExp;
						int my_MapX = client._My_MapX;
						int my_MapY = client._My_MapY;
						if (count2 > num)
						{
							Data.HomdoUpdateItem(client.conn, _hdslot, DataStructure.Type_Homdo._Count, count2 - num);
						}
						else
						{
							if (count2 == num)
							{
								DataStructure.HomdoInfo homdo = default(DataStructure.HomdoInfo);
								Data.HomdoUpdateSlot(client.conn, _hdslot, homdo);
							}
						}
						int num2 = 1;
						do
						{
							DataStructure.Key_ItemDropOnMap key_ItemDropOnMap = Data.GetKey_ItemDropOnMap(my_MapId, num2);
							DataStructure._ItemDropOnMap value = Data.ItemDropOnMap[key_ItemDropOnMap];
							int id = value._Id;
							if (id == 0)
							{
								count--;
								int randomMapX = Data.GetRandomMapX(my_MapX);
								int randomMapY = Data.GetRandomMapY(my_MapY);
								value._Id = iD;
								value._Count = 1;
								value._Lv = lv;
								value._Doben = doben;
								value._Int1 = @int;
								value._Atk1 = atk;
								value._Def1 = def;
								value._Hpx1 = hpx;
								value._Spx1 = spx;
								value._Agi1 = agi;
								value._Fai1 = fai;
								value._Int2 = int2;
								value._Atk2 = atk2;
								value._Def2 = def2;
								value._Hpx2 = hpx2;
								value._Spx2 = spx2;
								value._Agi2 = agi2;
								value._Fai2 = fai2;
								value._Hp = hp;
								value._Sp = sp;
								value._Long = @long;
								value._GiatriLong = giatriLong;
								value._Khang = khang;
								value._Thuoctinh = thuoctinh;
								value._GiatriThuoctinh = giatriThuoctinh;
								value._Loai = loai;
								value._TExp = tExp;
								value._MapX = randomMapX;
								value._MapY = randomMapY;
								value._Gold = 1;
								value._Delay = Delay;
								Data.ItemDropOnMap[key_ItemDropOnMap] = value;
								text = string.Concat(new string[]
								{
									text,
									"F44409001703",
									Class5.smethod_11(iD),
									Class5.smethod_11(randomMapX),
									Class5.smethod_11(randomMapY),
									"01"
								});
								text2 = string.Concat(new string[]
								{
									text2,
									"F44408001703",
									Class5.smethod_11(iD),
									Class5.smethod_11(randomMapX),
									Class5.smethod_11(randomMapY)
								});
								if (count == 0)
								{
									break;
								}
							}
							num2++;
						}
						while (num2 <= 255);
						if (text.Length > 0)
						{
							Server.SendToClient(_IdPlayer, text + "F44404001709" + _hdslot.ToString("X2") + num.ToString("X2"));
						}
						if (text2.Length > 0)
						{
							Server.SendToAllClientMapid(_IdPlayer, text2);
						}
					}
				}
			}
		}
		public static void HomdoMoveItem(int _IdPlayer, int oldslot, int count, int newslot, byte[] packet)
		{
			checked
			{
				if (Server.Clients.ContainsKey(_IdPlayer))
				{
					Client client = Server.Clients[_IdPlayer];
					DataStructure.HomdoInfo homdo = Data.HomdoGetDataItem(client.conn, oldslot);
					int iD = homdo._ID;
					int count2 = homdo._Count;
					int loai = homdo._Loai;
					DataStructure.HomdoInfo homdoInfo = Data.HomdoGetDataItem(client.conn, newslot);
					int iD2 = homdoInfo._ID;
					int count3 = homdoInfo._Count;
					if (iD > 0 & count2 > 0)
					{
						if (loai >= 1 & loai <= 6)
						{
							if (iD2 == 0)
							{
								Data.MoveItem(client.conn, DataStructure.Type_Thung._Homdo, oldslot, DataStructure.Type_Thung._Homdo, newslot);
								Server.SendToClient(_IdPlayer, Class5.smethod_3(packet));
							}
						}
						else
						{
							if ((iD2 == 0 | iD == iD2) && count3 < 50 && count + count3 <= 50)
							{
								if (count2 - count == 0)
								{
									Data.MoveItem(client.conn, DataStructure.Type_Thung._Homdo, oldslot, DataStructure.Type_Thung._Homdo, newslot);
									Server.SendToClient(_IdPlayer, Class5.smethod_3(packet));
								}
								else
								{
									if (count2 - count > 0)
									{
										homdo._Count = count + count3;
										Data.HomdoUpdateSlot(client.conn, newslot, homdo);
										Data.HomdoUpdateItem(client.conn, oldslot, DataStructure.Type_Homdo._Count, count2 - count);
										Server.SendToClient(_IdPlayer, Class5.smethod_3(packet));
									}
								}
							}
						}
					}
				}
			}
		}
		public static void HomdoUseItemTB(int _IdPlayer, int hdslot, int tbslot)
		{
			if (Server.Clients.ContainsKey(_IdPlayer))
			{
				OleDbConnection conn = Server.Clients[_IdPlayer].conn;
				Data.MoveItem(conn, DataStructure.Type_Thung._Trangbi, tbslot, DataStructure.Type_Thung._Homdo, hdslot);
			}
		}
		public static void HomdoUseItemTB_Pet(int _IdPlayer, int stt, int hdslot, int tbslot)
		{
			if (Server.Clients.ContainsKey(_IdPlayer))
			{
				OleDbConnection conn = Server.Clients[_IdPlayer].conn;
				Data.MoveItem(conn, DataStructure.Type_Thung._Trangbi, tbslot, DataStructure.Type_Thung._Homdo, hdslot);
			}
		}
		public static void HomdoUseHPSPFAI(int _IdPlayer, int _slot, int _CountUse)
		{
			if (Server.Clients.ContainsKey(_IdPlayer))
			{
				DataStructure.HomdoInfo homdoInfo = Data.HomdoGetDataItem(Server.Clients[_IdPlayer].conn, _slot);
				int iD = homdoInfo._ID;
				if (iD > 0)
				{
					int count = homdoInfo._Count;
					int num = checked(count - _CountUse);
					if (num > 0)
					{
						Data.HomdoUpdateItem(Server.Clients[_IdPlayer].conn, _slot, DataStructure.Type_Homdo._Count, num);
						Server.SendToClient(_IdPlayer, "F44404001709" + _slot.ToString("X2") + _CountUse.ToString("X2") + "F4440200170F");
					}
					else
					{
						DataStructure.HomdoInfo homdo = default(DataStructure.HomdoInfo);
						Data.HomdoUpdateSlot(Server.Clients[_IdPlayer].conn, _slot, homdo);
						Server.SendToClient(_IdPlayer, "F44404001709" + _slot.ToString("X2") + _CountUse.ToString("X2") + "F4440200170F");
					}
				}
			}
		}
		public static void PickupItemOnMap(int _IdPlayer, int _Slot)
		{
			checked
			{
				if (Server.Clients.ContainsKey(_IdPlayer))
				{
					int my_MapId = Server.Clients[_IdPlayer]._My_MapId;
					DataStructure.Key_ItemDropOnMap key_ItemDropOnMap = Data.GetKey_ItemDropOnMap(my_MapId, _Slot);
					DataStructure._ItemDropOnMap itemDropOnMap = Data.ItemDropOnMap[key_ItemDropOnMap];
					int id = itemDropOnMap._Id;
					if (id == 0)
					{
						return;
					}
					int count = itemDropOnMap._Count;
					int lv = itemDropOnMap._Lv;
					int doben = itemDropOnMap._Doben;
					int @int = itemDropOnMap._Int1;
					int atk = itemDropOnMap._Atk1;
					int def = itemDropOnMap._Def1;
					int hpx = itemDropOnMap._Hpx1;
					int spx = itemDropOnMap._Spx1;
					int agi = itemDropOnMap._Agi1;
					int fai = itemDropOnMap._Fai1;
					int int2 = itemDropOnMap._Int2;
					int atk2 = itemDropOnMap._Atk2;
					int def2 = itemDropOnMap._Def2;
					int hpx2 = itemDropOnMap._Hpx2;
					int spx2 = itemDropOnMap._Spx2;
					int agi2 = itemDropOnMap._Agi2;
					int fai2 = itemDropOnMap._Fai2;
					int hp = itemDropOnMap._Hp;
					int sp = itemDropOnMap._Sp;
					int @long = itemDropOnMap._Long;
					int giatriLong = itemDropOnMap._GiatriLong;
					int khang = itemDropOnMap._Khang;
					int thuoctinh = itemDropOnMap._Thuoctinh;
					int giatriThuoctinh = itemDropOnMap._GiatriThuoctinh;
					int loai = itemDropOnMap._Loai;
					int tExp = itemDropOnMap._TExp;
					if (1 <= loai & loai <= 6)
					{
						int num = Data.HomdoGetSlotNothing(Server.Clients[_IdPlayer].conn);
						if (num > 0)
						{
							DataStructure.HomdoInfo homdo = default(DataStructure.HomdoInfo);
							homdo._ID = id;
							homdo._Count = count;
							homdo._Lv = lv;
							homdo._Doben = doben;
							homdo._Int1 = @int;
							homdo._Atk1 = atk;
							homdo._Def1 = def;
							homdo._Hpx1 = hpx;
							homdo._Spx1 = spx;
							homdo._Agi1 = agi;
							homdo._Fai1 = fai;
							homdo._Int2 = int2;
							homdo._Atk2 = atk2;
							homdo._Def2 = def2;
							homdo._Hpx2 = hpx2;
							homdo._Spx2 = spx2;
							homdo._Agi2 = agi2;
							homdo._Fai2 = fai2;
							homdo._Hp = hp;
							homdo._Sp = sp;
							homdo._Long = @long;
							homdo._GiatriLong = giatriLong;
							homdo._Khang = khang;
							homdo._Thuoctinh = thuoctinh;
							homdo._GiatriThuoctinh = giatriThuoctinh;
							homdo._Loai = loai;
							homdo._TExp = tExp;
							Data.HomdoUpdateSlot(Server.Clients[_IdPlayer].conn, num, homdo);
							DataStructure._ItemDropOnMap value = default(DataStructure._ItemDropOnMap);
							value._MapId = itemDropOnMap._MapId;
							value._Slot = itemDropOnMap._Slot;
							Data.ItemDropOnMap[key_ItemDropOnMap] = value;
							Server.SendToClient(_IdPlayer, "F44405001702" + Class5.smethod_11(_Slot) + "01");
							Server.SendToClient(_IdPlayer, string.Concat(new string[]
							{
								"F4440E001706",
								Class5.smethod_11(id),
								count.ToString("X2"),
								"00",
								doben.ToString("X2"),
								@long.ToString("X2"),
								(giatriLong + 100).ToString("X2"),
								khang.ToString("X2"),
								Class5.smethod_12(tExp)
							}));
							Server.SendToAllClientMapid(_IdPlayer, "F44404001702" + Class5.smethod_11(_Slot));
						}
					}
					else
					{
						if (Data.HomdoGetSlotConstainId50(Server.Clients[_IdPlayer].conn, id) == 0)
						{
							if (Data.HomdoGetSlotNothing(Server.Clients[_IdPlayer].conn) > 0)
							{
								int num2 = Data.HomdoGetSlotNothing(Server.Clients[_IdPlayer].conn);
								if (num2 > 0)
								{
									DataStructure.HomdoInfo homdo2 = default(DataStructure.HomdoInfo);
									homdo2._ID = id;
									homdo2._Count = count;
									homdo2._Lv = lv;
									homdo2._Doben = doben;
									homdo2._Int1 = @int;
									homdo2._Atk1 = atk;
									homdo2._Def1 = def;
									homdo2._Hpx1 = hpx;
									homdo2._Spx1 = spx;
									homdo2._Agi1 = agi;
									homdo2._Fai1 = fai;
									homdo2._Int2 = int2;
									homdo2._Atk2 = atk2;
									homdo2._Def2 = def2;
									homdo2._Hpx2 = hpx2;
									homdo2._Spx2 = spx2;
									homdo2._Agi2 = agi2;
									homdo2._Fai2 = fai2;
									homdo2._Hp = hp;
									homdo2._Sp = sp;
									homdo2._Long = @long;
									homdo2._GiatriLong = giatriLong;
									homdo2._Khang = khang;
									homdo2._Thuoctinh = thuoctinh;
									homdo2._GiatriThuoctinh = giatriThuoctinh;
									homdo2._Loai = loai;
									homdo2._TExp = tExp;
									Data.HomdoUpdateSlot(Server.Clients[_IdPlayer].conn, num2, homdo2);
									DataStructure._ItemDropOnMap value2 = default(DataStructure._ItemDropOnMap);
									value2._MapId = itemDropOnMap._MapId;
									value2._Slot = itemDropOnMap._Slot;
									Data.ItemDropOnMap[key_ItemDropOnMap] = value2;
									Server.SendToClient(_IdPlayer, "F44405001702" + Class5.smethod_11(_Slot) + "01");
									Server.SendToClient(_IdPlayer, string.Concat(new string[]
									{
										"F4440E001706",
										Class5.smethod_11(id),
										count.ToString("X2"),
										"00",
										doben.ToString("X2"),
										@long.ToString("X2"),
										(giatriLong + 100).ToString("X2"),
										khang.ToString("X2"),
										Class5.smethod_12(tExp)
									}));
									Server.SendToAllClientMapid(_IdPlayer, "F44404001702" + Class5.smethod_11(_Slot));
								}
							}
						}
						else
						{
							int slot = Data.HomdoGetSlotConstainId50(Server.Clients[_IdPlayer].conn, id);
							int count2 = Data.HomdoGetDataItem(Server.Clients[_IdPlayer].conn, slot)._Count;
							Data.HomdoUpdateItem(Server.Clients[_IdPlayer].conn, slot, DataStructure.Type_Homdo._Count, count2 + count);
							DataStructure._ItemDropOnMap value3 = default(DataStructure._ItemDropOnMap);
							value3._MapId = itemDropOnMap._MapId;
							value3._Slot = itemDropOnMap._Slot;
							Data.ItemDropOnMap[key_ItemDropOnMap] = value3;
							Server.SendToClient(_IdPlayer, "F44405001702" + Class5.smethod_11(_Slot) + "01");
							Server.SendToClient(_IdPlayer, string.Concat(new string[]
							{
								"F4440E001706",
								Class5.smethod_11(id),
								count.ToString("X2"),
								"00",
								doben.ToString("X2"),
								@long.ToString("X2"),
								(giatriLong + 100).ToString("X2"),
								khang.ToString("X2"),
								Class5.smethod_12(tExp)
							}));
							Server.SendToAllClientMapid(_IdPlayer, "F44404001702" + Class5.smethod_11(_Slot));
						}
					}
				}
			}
		}
		public static int CongthucHP(int reborn, int job, int lv, int HPX)
		{
			int hP = 0;
			switch (reborn)
			{
			case 0:
				hP = Data.GetHP(DataStructure.Type_GetHp._Hp, lv, HPX);
				break;
			case 1:
				hP = Data.GetHP(DataStructure.Type_GetHp._HpCs, lv, HPX);
				break;
			case 2:
				switch (job)
				{
				case 1:
					hP = Data.GetHP(DataStructure.Type_GetHp._HpCs, lv, HPX);
					break;
				case 2:
					hP = Data.GetHP(DataStructure.Type_GetHp._HpCs, lv, HPX);
					break;
				case 3:
					hP = Data.GetHP(DataStructure.Type_GetHp._HpCs, lv, HPX);
					break;
				case 4:
					hP = Data.GetHP(DataStructure.Type_GetHp._HpCs, lv, HPX);
					break;
				}
				break;
			}
			return hP;
		}
		public static int CongthucSP(int reborn, int job, int lv, int SPX)
		{
			int result = 0;
			switch (reborn)
			{
			case 0:
				result = Data.GetSP(DataStructure.Type_GetSp._Sp, lv, SPX);
				break;
			case 1:
				result = checked(Data.GetSP(DataStructure.Type_GetSp._SPCS, lv, SPX) + 50);
				break;
			case 2:
				switch (job)
				{
				case 1:
					result = Data.GetSP(DataStructure.Type_GetSp._SPCS, lv, SPX);
					break;
				case 2:
					result = Data.GetSP(DataStructure.Type_GetSp._SPCS, lv, SPX);
					break;
				case 3:
					result = Data.GetSP(DataStructure.Type_GetSp._SPCS, lv, SPX);
					break;
				case 4:
					result = Data.GetSP(DataStructure.Type_GetSp._SPCS, lv, SPX);
					break;
				}
				break;
			}
			return result;
		}
		public static int CongthucHPPet(int reborn, int lv, int HPX)
		{
			int hP = 0;
			switch (reborn)
			{
			case 0:
				hP = Data.GetHP(DataStructure.Type_GetHp._Hp, lv, HPX);
				break;
			case 1:
				hP = Data.GetHP(DataStructure.Type_GetHp._Hp, lv, HPX);
				break;
			case 2:
				hP = Data.GetHP(DataStructure.Type_GetHp._HpCs, lv, HPX);
				break;
			}
			return hP;
		}
		public static int CongthucSPPet(int reborn, int lv, int SPX)
		{
			int result = 0;
			switch (reborn)
			{
			case 0:
				result = Data.GetSP(DataStructure.Type_GetSp._Sp, lv, SPX);
				break;
			case 1:
				result = Data.GetSP(DataStructure.Type_GetSp._Sp, lv, SPX);
				break;
			case 2:
				result = checked(Data.GetSP(DataStructure.Type_GetSp._SPCS, lv, SPX) + 50);
				break;
			}
			return result;
		}
		public static int GetRandomMapY(int _Y)
		{
			int[] items = checked(new int[]
			{
				_Y,
				_Y + 4,
				_Y + 8,
				_Y + 12,
				_Y + 16,
				_Y + 20,
				_Y + 24,
				_Y + 28,
				_Y + 32,
				_Y + 36,
				_Y + 40,
				_Y + 44,
				_Y + 48,
				_Y + 52
			});
			return Data.RandomizeArray(items);
		}
		public static int GetRandomMapX(int _X)
		{
			int[] items = checked(new int[]
			{
				_X - 52,
				_X - 48,
				_X - 44,
				_X - 40,
				_X - 36,
				_X - 32,
				_X - 28,
				_X - 24,
				_X - 20,
				_X - 16,
				_X - 12,
				_X - 8,
				_X - 4,
				_X,
				_X + 4,
				_X + 8,
				_X + 12,
				_X + 16,
				_X + 20,
				_X + 24,
				_X + 28,
				_X + 32,
				_X + 36,
				_X + 40,
				_X + 44,
				_X + 48,
				_X + 52
			});
			return Data.RandomizeArray(items);
		}
		public static int RandomizeArray(int[] items)
		{
			int maxValue = checked(items.Length - 1);
			return items[Data.random_2.Next(0, maxValue)];
		}
		public static void Warped(int _Id, int _Mapid1, int _Mapid2, int _x, int _y, int _gocnhin)
		{
			Server.SendToClient(_Id, "F44402001407");
			Server.ServerSend_PlayerGotoMap(_Id, _Mapid2, _x, _y, _gocnhin);
			Data.PlayerUpdateDataId(_Id, DataStructure.Type_Player._MapId, _Mapid2);
			Data.PlayerUpdateDataId(_Id, DataStructure.Type_Player._MapX, _x);
			Data.PlayerUpdateDataId(_Id, DataStructure.Type_Player._MapY, _y);
			Data.PlayerUpdateDataId(_Id, DataStructure.Type_Player._Gocnhin, Conversions.ToInteger(_gocnhin.ToString()));
			Server.ServerSend_PlayerGotoMap(_Id, _Mapid2, _x, _y, _gocnhin);
			Data.SendWarpFinish(_Id, _Mapid2, _x, _y, _gocnhin);
			Server.SendPlayerOnMap(_Id);
			Data.GetDataItemOnMap(_Id);
			Server.SendAllParty(_Id);
		}
		public static void SendMemWarp(int _id, int _MapId, int _X, int _Y, int _Gocnhin, int _idleader, int _idmem1, int _idmem2, int _idmem3, int _idmem4)
		{
			Server.SendToClient(_id, "F4440700142C" + Class5.smethod_12(_idleader) + "01");
			Server.SendToClient(_id, string.Concat(new string[]
			{
				"F4440D000C",
				Class5.smethod_12(_idleader),
				Class5.smethod_11(_MapId),
				Class5.smethod_11(_X),
				Class5.smethod_11(_Y),
				Class5.smethod_11(_Gocnhin)
			}));
			if (_idmem1 > 0)
			{
				Server.SendToClient(_id, string.Concat(new string[]
				{
					"F4440D000C",
					Class5.smethod_12(_idmem1),
					Class5.smethod_11(_MapId),
					Class5.smethod_11(_X),
					Class5.smethod_11(_Y),
					"0000"
				}));
				Server.ServerSend_PlayerGotoMap(_idmem1, _MapId, _X, _Y, _Gocnhin);
			}
			if (_idmem2 > 0)
			{
				Server.SendToClient(_id, string.Concat(new string[]
				{
					"F4440D000C",
					Class5.smethod_12(_idmem2),
					Class5.smethod_11(_MapId),
					Class5.smethod_11(_X),
					Class5.smethod_11(_Y),
					"0000"
				}));
				Server.ServerSend_PlayerGotoMap(_idmem1, _MapId, _X, _Y, _Gocnhin);
			}
			if (_idmem3 > 0)
			{
				Server.SendToClient(_id, string.Concat(new string[]
				{
					"F4440D000C",
					Class5.smethod_12(_idmem3),
					Class5.smethod_11(_MapId),
					Class5.smethod_11(_X),
					Class5.smethod_11(_Y),
					"0000"
				}));
				Server.ServerSend_PlayerGotoMap(_idmem1, _MapId, _X, _Y, _Gocnhin);
			}
			if (_idmem4 > 0)
			{
				Server.SendToClient(_id, string.Concat(new string[]
				{
					"F4440D000C",
					Class5.smethod_12(_idmem4),
					Class5.smethod_11(_MapId),
					Class5.smethod_11(_X),
					Class5.smethod_11(_Y),
					"0000"
				}));
				Server.ServerSend_PlayerGotoMap(_idmem1, _MapId, _X, _Y, _Gocnhin);
			}
			Server.SendToClient(_id, string.Concat(new string[]
			{
				"F4440B000C",
				Class5.smethod_12(_idleader),
				Class5.smethod_11(_MapId),
				Class5.smethod_11(_X),
				Class5.smethod_11(_Y)
			}));
			Server.SendToClient(_id, "F44408000500" + Class5.smethod_12(_idleader) + "F628");
			Data.PlayerUpdateDataId(_id, DataStructure.Type_Player._MapId, _MapId);
			Data.PlayerUpdateDataId(_id, DataStructure.Type_Player._MapX, Conversions.ToInteger(_X.ToString()));
			Data.PlayerUpdateDataId(_id, DataStructure.Type_Player._MapY, Conversions.ToInteger(_Y.ToString()));
			Data.PlayerUpdateDataId(_id, DataStructure.Type_Player._Gocnhin, Conversions.ToInteger(_Gocnhin.ToString()));
		}
		public static void SendWarpFinish(int ID, int mapid, int mapx, int mapy, int gocnhin)
		{
			Server.SendToClient(ID, string.Concat(new string[]
			{
				"F4440D000C",
				Class5.smethod_12(ID),
				Class5.smethod_11(mapid),
				Class5.smethod_11(mapx),
				Class5.smethod_11(mapy),
				Class5.smethod_11(gocnhin)
			}));
		}
		public static void PetUp(int _IdPlayer, int stt)
		{
			checked
			{
				if (Server.Clients.ContainsKey(_IdPlayer))
				{
					OleDbConnection conn = Server.Clients[_IdPlayer].conn;
					int num = Data.PetGetData(conn, stt, DataStructure.Type_Pet._ID);
					int num2 = Data.PetGetData(conn, stt, DataStructure.Type_Pet._Lv);
					if (num > 0 & num2 < 200)
					{
						string randomPointPet = Data.GetRandomPointPet(num);
						int num3 = Data.PetGetData(conn, stt, randomPointPet);
						Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Lv, num2 + 1);
						Data.PetUpdateData(_IdPlayer, stt, randomPointPet, num3 + 1);
						int id = Data.PetGetData(conn, stt, DataStructure.Type_Pet._IdSkill1);
						int id2 = Data.PetGetData(conn, stt, DataStructure.Type_Pet._IdSkill2);
						int id3 = Data.PetGetData(conn, stt, DataStructure.Type_Pet._IdSkill3);
						int id4 = Data.PetGetData(conn, stt, DataStructure.Type_Pet._IdSkill4);
						int num4 = Data.PetGetData(conn, stt, DataStructure.Type_Pet._LvSkill1);
						int num5 = Data.PetGetData(conn, stt, DataStructure.Type_Pet._LvSkill2);
						int num6 = Data.PetGetData(conn, stt, DataStructure.Type_Pet._LvSkill3);
						int num7 = Data.PetGetData(conn, stt, DataStructure.Type_Pet._LvSkill4);
						int num8 = Data.PetGetData(conn, stt, DataStructure.Type_Pet._SkillPoint);
						int num9 = Data.GetDataSkill(id, DataStructure.Type_Skill._LvMax) + Data.GetDataSkill(id2, DataStructure.Type_Skill._LvMax) + Data.GetDataSkill(id3, DataStructure.Type_Skill._LvMax) + Data.GetDataSkill(id4, DataStructure.Type_Skill._LvMax);
						if (num4 + num5 + num6 + num7 + num8 < num9)
						{
							Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._SkillPoint, num8 + 1);
						}
						int lv = Data.PetGetData(conn, stt, DataStructure.Type_Pet._Lv);
						int reborn = Data.PetGetData(conn, stt, DataStructure.Type_Npc._Reborn);
						Data.PetGetData(conn, stt, DataStructure.Type_Npc._Int);
						Data.PetGetData(conn, stt, DataStructure.Type_Npc._Atk);
						Data.PetGetData(conn, stt, DataStructure.Type_Npc._Def);
						int hPX = Data.PetGetData(conn, stt, DataStructure.Type_Npc._Hpx);
						int sPX = Data.PetGetData(conn, stt, DataStructure.Type_Npc._Spx);
						Data.PetGetData(conn, stt, DataStructure.Type_Npc._Agi);
						int value = Data.CongthucHPPet(reborn, lv, hPX);
						int value2 = Data.CongthucSPPet(reborn, lv, sPX);
						Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Hp, value);
						Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Hpmax, value);
						Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Sp, value2);
						Data.PetUpdateData(_IdPlayer, stt, DataStructure.Type_Pet._Spmax, value2);
					}
				}
			}
		}
		public static void Loaded()
		{
			Data._Status = "Open";
			Data.LoadedData = true;
		}
		public static void LoadDataNpcs()
		{
			string[] array = Class7.PvxUcloLc().Split(new char[]
			{
				'\r',
				'\r'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length <= 0)
					{
						break;
					}
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (!array2[0].StartsWith("//"))
					{
						DataStructure.Npcs value = default(DataStructure.Npcs);
						value._Id = Conversions.ToInteger(array2[0]);
						value._Name = array2[1];
						value._Lv = Conversions.ToInteger(array2[2]);
						value._Thuoctinh = Conversions.ToInteger(array2[3]);
						value._Hp = Conversions.ToInteger(array2[4]);
						value._Sp = Conversions.ToInteger(array2[5]);
						value._Hpx = Conversions.ToInteger(array2[6]);
						value._Spx = Conversions.ToInteger(array2[7]);
						value._Int = Conversions.ToInteger(array2[8]);
						value._Atk = Conversions.ToInteger(array2[9]);
						value._Def = Conversions.ToInteger(array2[10]);
						value._Agi = Conversions.ToInteger(array2[11]);
						value._Skill1 = Conversions.ToInteger(array2[12]);
						value._Skill2 = Conversions.ToInteger(array2[13]);
						value._Skill3 = Conversions.ToInteger(array2[14]);
						value._Item1 = Conversions.ToInteger(array2[15]);
						value._Item2 = Conversions.ToInteger(array2[16]);
						value._Item3 = Conversions.ToInteger(array2[17]);
						value._Item4 = Conversions.ToInteger(array2[18]);
						value._Item5 = Conversions.ToInteger(array2[19]);
						value._Item6 = Conversions.ToInteger(array2[20]);
						value._Bat = Conversions.ToInteger(array2[21]);
						value._Reborn = Conversions.ToInteger(array2[22]);
						Data.Data_Npcs.Add(value._Id, value);
					}
				}
				new Thread(new ThreadStart(Data.CreatMapNpc))
				{
					IsBackground = true
				}.Start();
				new Thread(new ThreadStart(Data.LoadDataSkills))
				{
					IsBackground = true
				}.Start();
				new Thread(new ThreadStart(Data.LoadDataFormulaHP))
				{
					IsBackground = true
				}.Start();
			}
		}
		public static int GetDataNpc(int _id, string type)
		{
			int result = 0;
			if (_id > 0 && Data.Data_Npcs.ContainsKey(_id))
			{
				DataStructure.Npcs npcs = Data.Data_Npcs[_id];
				if (Operators.CompareString(type, "Id", false) == 0)
				{
					result = npcs._Id;
				}
				else
				{
					if (Operators.CompareString(type, "Lv", false) == 0)
					{
						result = npcs._Lv;
					}
					else
					{
						if (Operators.CompareString(type, "Thuoctinh", false) == 0)
						{
							result = npcs._Thuoctinh;
						}
						else
						{
							if (Operators.CompareString(type, "Hp", false) == 0)
							{
								result = npcs._Hp;
							}
							else
							{
								if (Operators.CompareString(type, "Sp", false) == 0)
								{
									result = npcs._Sp;
								}
								else
								{
									if (Operators.CompareString(type, "Hpx", false) == 0)
									{
										result = npcs._Hpx;
									}
									else
									{
										if (Operators.CompareString(type, "Spx", false) == 0)
										{
											result = npcs._Spx;
										}
										else
										{
											if (Operators.CompareString(type, "Int", false) == 0)
											{
												result = npcs._Int;
											}
											else
											{
												if (Operators.CompareString(type, "Atk", false) == 0)
												{
													result = npcs._Atk;
												}
												else
												{
													if (Operators.CompareString(type, "Def", false) == 0)
													{
														result = npcs._Def;
													}
													else
													{
														if (Operators.CompareString(type, "Agi", false) == 0)
														{
															result = npcs._Agi;
														}
														else
														{
															if (Operators.CompareString(type, "Skill1", false) == 0)
															{
																result = npcs._Skill1;
															}
															else
															{
																if (Operators.CompareString(type, "Skill2", false) == 0)
																{
																	result = npcs._Skill2;
																}
																else
																{
																	if (Operators.CompareString(type, "Skill3", false) == 0)
																	{
																		result = npcs._Skill3;
																	}
																	else
																	{
																		if (Operators.CompareString(type, "Item1", false) == 0)
																		{
																			result = npcs._Item1;
																		}
																		else
																		{
																			if (Operators.CompareString(type, "Item2", false) == 0)
																			{
																				result = npcs._Item2;
																			}
																			else
																			{
																				if (Operators.CompareString(type, "Item3", false) == 0)
																				{
																					result = npcs._Item3;
																				}
																				else
																				{
																					if (Operators.CompareString(type, "Item4", false) == 0)
																					{
																						result = npcs._Item4;
																					}
																					else
																					{
																						if (Operators.CompareString(type, "Item5", false) == 0)
																						{
																							result = npcs._Item5;
																						}
																						else
																						{
																							if (Operators.CompareString(type, "Item6", false) == 0)
																							{
																								result = npcs._Item6;
																							}
																							else
																							{
																								if (Operators.CompareString(type, "Bat", false) == 0)
																								{
																									result = npcs._Bat;
																								}
																								else
																								{
																									if (Operators.CompareString(type, "Reborn", false) == 0)
																									{
																										result = npcs._Reborn;
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
			}
			return result;
		}
		public static string GetDataNpcName(int _id, string type)
		{
			string result = "";
			if (_id > 0 && Data.Data_Npcs.ContainsKey(_id))
			{
				DataStructure.Npcs npcs = Data.Data_Npcs[_id];
				if (Operators.CompareString(type, "Name", false) == 0)
				{
					result = npcs._Name;
				}
			}
			return result;
		}
		public static bool GetDataNpcExits(int _Id)
		{
			return Data.Data_Npcs.ContainsKey(_Id);
		}
		public static void LoadDataItems()
		{
			string[] array = Class7.smethod_4().Split(new char[]
			{
				'\r',
				'\r'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length <= 0)
					{
						break;
					}
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (!array2[0].StartsWith("//"))
					{
						DataStructure.Items value = default(DataStructure.Items);
						value._id = Conversions.ToInteger(array2[0]);
						value._Name = array2[1];
						value._Lv = Conversions.ToInteger(array2[2]);
						value._Hp = Conversions.ToInteger(array2[3]);
						value._Sp = Conversions.ToInteger(array2[4]);
						value._Int1 = Conversions.ToInteger(array2[5]);
						value._Atk1 = Conversions.ToInteger(array2[6]);
						value._Def1 = Conversions.ToInteger(array2[7]);
						value._Hpx1 = Conversions.ToInteger(array2[8]);
						value._Spx1 = Conversions.ToInteger(array2[9]);
						value._Agi1 = Conversions.ToInteger(array2[10]);
						value._Fai1 = Conversions.ToInteger(array2[11]);
						value._Int2 = Conversions.ToInteger(array2[12]);
						value._Atk2 = Conversions.ToInteger(array2[13]);
						value._Def2 = Conversions.ToInteger(array2[14]);
						value._Hpx2 = Conversions.ToInteger(array2[15]);
						value._Spx2 = Conversions.ToInteger(array2[16]);
						value._Agi2 = Conversions.ToInteger(array2[17]);
						value._Fai2 = Conversions.ToInteger(array2[18]);
						value._Thuoctinh = Conversions.ToInteger(array2[19]);
						value._GiatriThuoctinh = Conversions.ToInteger(array2[20]);
						value._Loai = Conversions.ToInteger(array2[21]);
						Data.Data_Items.Add(value._id, value);
					}
				}
				new Thread(new ThreadStart(Data.CreatMapItem))
				{
					IsBackground = true
				}.Start();
				new Thread(new ThreadStart(Data.LoadDataNpcs))
				{
					IsBackground = true
				}.Start();
			}
		}
		public static int GetDataItem(int _id, string type)
		{
			int result = 0;
			if (_id > 0 && Data.Data_Items.ContainsKey(_id))
			{
				DataStructure.Items items = Data.Data_Items[_id];
				if (Operators.CompareString(type, "id", false) == 0)
				{
					result = items._id;
				}
				else
				{
					if (Operators.CompareString(type, "Name", false) == 0)
					{
						result = Conversions.ToInteger(items._Name);
					}
					else
					{
						if (Operators.CompareString(type, "Lv", false) == 0)
						{
							result = items._Lv;
						}
						else
						{
							if (Operators.CompareString(type, "Hp", false) == 0)
							{
								result = items._Hp;
							}
							else
							{
								if (Operators.CompareString(type, "Sp", false) == 0)
								{
									result = items._Sp;
								}
								else
								{
									if (Operators.CompareString(type, "Int1", false) == 0)
									{
										result = items._Int1;
									}
									else
									{
										if (Operators.CompareString(type, "Atk1", false) == 0)
										{
											result = items._Atk1;
										}
										else
										{
											if (Operators.CompareString(type, "Def1", false) == 0)
											{
												result = items._Def1;
											}
											else
											{
												if (Operators.CompareString(type, "Hpx1", false) == 0)
												{
													result = items._Hpx1;
												}
												else
												{
													if (Operators.CompareString(type, "Spx1", false) == 0)
													{
														result = items._Spx1;
													}
													else
													{
														if (Operators.CompareString(type, "Agi1", false) == 0)
														{
															result = items._Agi1;
														}
														else
														{
															if (Operators.CompareString(type, "Fai1", false) == 0)
															{
																result = items._Fai1;
															}
															else
															{
																if (Operators.CompareString(type, "Int2", false) == 0)
																{
																	result = items._Int2;
																}
																else
																{
																	if (Operators.CompareString(type, "Atk2", false) == 0)
																	{
																		result = items._Atk2;
																	}
																	else
																	{
																		if (Operators.CompareString(type, "Def2", false) == 0)
																		{
																			result = items._Def2;
																		}
																		else
																		{
																			if (Operators.CompareString(type, "Hpx2", false) == 0)
																			{
																				result = items._Hpx2;
																			}
																			else
																			{
																				if (Operators.CompareString(type, "Spx2", false) == 0)
																				{
																					result = items._Spx2;
																				}
																				else
																				{
																					if (Operators.CompareString(type, "Agi2", false) == 0)
																					{
																						result = items._Agi2;
																					}
																					else
																					{
																						if (Operators.CompareString(type, "Fai2", false) == 0)
																						{
																							result = items._Fai2;
																						}
																						else
																						{
																							if (Operators.CompareString(type, "Thuoctinh", false) == 0)
																							{
																								result = items._Thuoctinh;
																							}
																							else
																							{
																								if (Operators.CompareString(type, "GiatriThuoctinh", false) == 0)
																								{
																									result = items._GiatriThuoctinh;
																								}
																								else
																								{
																									if (Operators.CompareString(type, "Loai", false) == 0)
																									{
																										result = items._Loai;
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
			}
			return result;
		}
		public static DataStructure.HomdoInfo GetDataItem(int _id)
		{
			DataStructure.HomdoInfo result = default(DataStructure.HomdoInfo);
			if (_id > 0 && Data.Data_Items.ContainsKey(_id))
			{
				DataStructure.Items items = Data.Data_Items[_id];
				result._ID = items._id;
				result._Lv = items._Lv;
				result._Count = 1;
				result._Doben = 0;
				result._Int1 = items._Int1;
				result._Atk1 = items._Atk1;
				result._Def1 = items._Def1;
				result._Hpx1 = items._Hpx1;
				result._Spx1 = items._Spx1;
				result._Agi1 = items._Agi1;
				result._Fai1 = items._Fai1;
				result._Int2 = items._Int2;
				result._Atk2 = items._Atk2;
				result._Def2 = items._Def2;
				result._Hpx2 = items._Hpx2;
				result._Spx2 = items._Spx2;
				result._Agi2 = items._Agi2;
				result._Fai2 = items._Fai2;
				result._Hp = items._Hp;
				result._Sp = items._Sp;
				result._Long = 0;
				result._GiatriLong = 0;
				result._Khang = 0;
				result._Thuoctinh = items._Thuoctinh;
				result._GiatriThuoctinh = items._GiatriThuoctinh;
				result._Loai = items._Loai;
				result._TExp = 0;
			}
			return result;
		}
		public static bool GetDataItemExits(int _Id)
		{
			return Data.Data_Items.ContainsKey(_Id);
		}
		public static void LoadDataSkills()
		{
			string[] array = Class7.smethod_6().Split(new char[]
			{
				'\r',
				'\r'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length <= 0)
					{
						break;
					}
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (!array2[0].StartsWith("//"))
					{
						DataStructure.Skills value = default(DataStructure.Skills);
						value._ID = Conversions.ToInteger(array2[0]);
						value._Sp = Conversions.ToInteger(array2[2]);
						value._Point = Conversions.ToInteger(array2[3]);
						value._Thuoctinh = Conversions.ToInteger(array2[4]);
						value._IdDK1 = Conversions.ToInteger(array2[5]);
						value._IdDK2 = Conversions.ToInteger(array2[6]);
						value._IdDK3 = Conversions.ToInteger(array2[7]);
						value._IdDK4 = Conversions.ToInteger(array2[8]);
						value._IdDK5 = Conversions.ToInteger(array2[9]);
						value._IdDK6 = Conversions.ToInteger(array2[10]);
						value._LvMax = Conversions.ToInteger(array2[11]);
						value._Type = Conversions.ToInteger(array2[12]);
						value._DoManh = Conversions.ToInteger(array2[13]);
						value._SLdanh = Conversions.ToInteger(array2[14]);
						value._Reborn = Conversions.ToInteger(array2[15]);
						value._Combo = Conversions.ToInteger(array2[16]);
						value._Delay = Conversions.ToInteger(array2[17]);
						value._TroiBuff = Conversions.ToInteger(array2[18]);
						Data.Data_Skills.Add(value._ID, value);
					}
				}
				new Thread(new ThreadStart(Data.LoadDataWarps))
				{
					IsBackground = true
				}.Start();
			}
		}
		public static int GetDataSkill(int _id, string type)
		{
			int result = 0;
			if (_id > 0 && Data.Data_Skills.ContainsKey(_id))
			{
				DataStructure.Skills skills = Data.Data_Skills[_id];
				if (Operators.CompareString(type, "Id", false) == 0)
				{
					result = skills._ID;
				}
				else
				{
					if (Operators.CompareString(type, "Sp", false) == 0)
					{
						result = skills._Sp;
					}
					else
					{
						if (Operators.CompareString(type, "Point", false) == 0)
						{
							result = skills._Point;
						}
						else
						{
							if (Operators.CompareString(type, "Thuoctinh", false) == 0)
							{
								result = skills._Thuoctinh;
							}
							else
							{
								if (Operators.CompareString(type, "IdDK1", false) == 0)
								{
									result = skills._IdDK1;
								}
								else
								{
									if (Operators.CompareString(type, "IdDK2", false) == 0)
									{
										result = skills._IdDK2;
									}
									else
									{
										if (Operators.CompareString(type, "IdDK3", false) == 0)
										{
											result = skills._IdDK3;
										}
										else
										{
											if (Operators.CompareString(type, "IdDK4", false) == 0)
											{
												result = skills._IdDK4;
											}
											else
											{
												if (Operators.CompareString(type, "IdDK5", false) == 0)
												{
													result = skills._IdDK5;
												}
												else
												{
													if (Operators.CompareString(type, "LvMax", false) == 0)
													{
														result = skills._LvMax;
													}
													else
													{
														if (Operators.CompareString(type, "Type", false) == 0)
														{
															result = skills._Type;
														}
														else
														{
															if (Operators.CompareString(type, "DoManh", false) == 0)
															{
																result = skills._DoManh;
															}
															else
															{
																if (Operators.CompareString(type, "SLdanh", false) == 0)
																{
																	result = skills._SLdanh;
																}
																else
																{
																	if (Operators.CompareString(type, "Reborn", false) == 0)
																	{
																		result = skills._Reborn;
																	}
																	else
																	{
																		if (Operators.CompareString(type, "Combo", false) == 0)
																		{
																			result = skills._Combo;
																		}
																		else
																		{
																			if (Operators.CompareString(type, "Delay", false) == 0)
																			{
																				result = skills._Delay;
																			}
																			else
																			{
																				if (Operators.CompareString(type, "TroiBuff", false) == 0)
																				{
																					result = skills._TroiBuff;
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
			return result;
		}
		public static bool GetDataSkillExits(int _Id)
		{
			return Data.Data_Skills.ContainsKey(_Id);
		}
		public static DataStructure.Key_Warps GetKey_Warps(int _Mapid1, int _WarpId)
		{
			return new DataStructure.Key_Warps
			{
				_MapId1 = _Mapid1,
				_WarpId = _WarpId
			};
		}
		public static void LoadDataWarps()
		{
			string[] array = Class7.smethod_11().Split(new char[]
			{
				'\r',
				'\r'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length < 5)
					{
						break;
					}
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (!array2[0].StartsWith("//") && array2[2].Length > 0)
					{
						DataStructure.Warps value = default(DataStructure.Warps);
						value._MapId1 = Conversions.ToInteger(array2[0]);
						value._WarpId = Conversions.ToInteger(array2[1]);
						value._MapId2 = Conversions.ToInteger(array2[2]);
						value._X = Conversions.ToInteger(array2[3]);
						value._Y = Conversions.ToInteger(array2[4]);
						value._Battle = Conversions.ToInteger(array2[5]);
						DataStructure.Key_Warps key_Warps = Data.GetKey_Warps(value._MapId1, value._WarpId);
						if (!Data.Data_Warps.ContainsKey(key_Warps))
						{
							try
							{
								Data.Data_Warps.Add(key_Warps, value);
							}
							catch (Exception expr_10A)
							{
								ProjectData.SetProjectError(expr_10A);
								Interaction.MsgBox(Conversions.ToString(key_Warps._MapId1) + " - " + Conversions.ToString(key_Warps._WarpId), MsgBoxStyle.OkOnly, null);
								ProjectData.ClearProjectError();
							}
						}
					}
				}
				new Thread(new ThreadStart(Data.LoadDataTalks))
				{
					IsBackground = true
				}.Start();
			}
		}
		public static bool GetDataWarpExits(int _MapId1, int _WarpId)
		{
			DataStructure.Key_Warps key_Warps = Data.GetKey_Warps(_MapId1, _WarpId);
			return Data.Data_Warps.ContainsKey(key_Warps);
		}
		public static int GetDataWarp(int _MapId1, int _WarpId, string type)
		{
			int result = 0;
			DataStructure.Key_Warps key_Warps = Data.GetKey_Warps(_MapId1, _WarpId);
			if (Data.Data_Warps.ContainsKey(key_Warps))
			{
				DataStructure.Warps warps = Data.Data_Warps[key_Warps];
				if (Operators.CompareString(type, "MapId1", false) == 0)
				{
					result = warps._MapId1;
				}
				else
				{
					if (Operators.CompareString(type, "WarpId", false) == 0)
					{
						result = warps._WarpId;
					}
					else
					{
						if (Operators.CompareString(type, "MapId2", false) == 0)
						{
							result = warps._MapId2;
						}
						else
						{
							if (Operators.CompareString(type, "X", false) == 0)
							{
								result = warps._X;
							}
							else
							{
								if (Operators.CompareString(type, "Y", false) == 0)
								{
									result = warps._Y;
								}
								else
								{
									if (Operators.CompareString(type, "Battle", false) == 0)
									{
										result = warps._Battle;
									}
								}
							}
						}
					}
				}
			}
			return result;
		}
		public static void LoadDataTalks()
		{
			string[] array = Class7.smethod_9().Split(new char[]
			{
				'\r',
				'\r'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length <= 0)
					{
						break;
					}
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (!array2[0].StartsWith("//"))
					{
						DataStructure._Talk value = default(DataStructure._Talk);
						value._MapId = Conversions.ToInteger(array2[0]);
						value._Type = array2[1];
						value._Id = Conversions.ToInteger(array2[2]);
						value._Count = Conversions.ToInteger(array2[3]);
						value._Step = Conversions.ToInteger(array2[4]);
						value._1 = array2[5];
						value._2 = array2[6];
						value._3 = array2[7];
						value._4 = array2[8];
						value._5 = array2[9];
						value._6 = array2[10];
						value._7 = array2[11];
						value._8 = array2[12];
						value._9 = array2[13];
						value._10 = array2[14];
						DataStructure.Key_Talk key = default(DataStructure.Key_Talk);
						key._MapId = value._MapId;
						key._Type = value._Type;
						key._Id = value._Id;
						key._Step = value._Step;
						Data.Data_Talks.Add(key, value);
					}
				}
				new Thread(new ThreadStart(Data.LoadDataTexps))
				{
					IsBackground = true
				}.Start();
			}
		}
		public static void LoadDataTexps()
		{
			string[] array = Class7.smethod_10().Split(new char[]
			{
				'\r',
				'\r'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length <= 0)
					{
						break;
					}
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (!array2[0].StartsWith("//"))
					{
						DataStructure._Texp value = default(DataStructure._Texp);
						value._Lv = Conversions.ToInteger(array2[0]);
						value._0 = Conversions.ToInteger(array2[1]);
						value._1 = Conversions.ToInteger(array2[2]);
						value._2 = Conversions.ToInteger(array2[3]);
						Data.Texps.Add(value._Lv, value);
					}
				}
				new Thread(new ThreadStart(Data.LoadDataBattleGates))
				{
					IsBackground = true
				}.Start();
			}
		}
		public static int TexpGetLvUp(int _Lv, int _Reborn, int _Texp)
		{
			int result = 0;
			checked
			{
				if (_Lv < 200)
				{
					for (int i = _Lv; i <= 199; i++)
					{
						switch (_Reborn)
						{
						case 0:
							if (_Texp < Data.Texps[i]._0)
							{
								return result;
							}
							if (_Texp >= Data.Texps[i]._0)
							{
								result = i - _Lv + 1;
							}
							break;
						case 1:
							if (_Texp < Data.Texps[i]._1)
							{
								return result;
							}
							if (_Texp >= Data.Texps[i]._1)
							{
								result = i - _Lv + 1;
							}
							break;
						case 2:
							if (_Texp < Data.Texps[i]._2)
							{
								return result;
							}
							if (_Texp >= Data.Texps[i]._2)
							{
								result = i - _Lv + 1;
							}
							break;
						}
					}
				}
				return result;
			}
		}
		public static void LoadDataBattleGates()
		{
			string[] array = Class7.smethod_0().Split(new char[]
			{
				'\r',
				'\r'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length < 5)
					{
						break;
					}
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (!array2[0].StartsWith("//"))
					{
						DataStructure.BattleGates value = default(DataStructure.BattleGates);
						value._MapId = Conversions.ToInteger(array2[0]);
						value._WarpId = Conversions.ToInteger(array2[1]);
						value._Diahinh = Conversions.ToInteger(array2[2]);
						value._1 = Conversions.ToInteger(array2[3]);
						value._2 = Conversions.ToInteger(array2[4]);
						value._3 = Conversions.ToInteger(array2[5]);
						value._4 = Conversions.ToInteger(array2[6]);
						value._5 = Conversions.ToInteger(array2[7]);
						value._6 = Conversions.ToInteger(array2[8]);
						value._7 = Conversions.ToInteger(array2[9]);
						value._8 = Conversions.ToInteger(array2[10]);
						value._9 = Conversions.ToInteger(array2[11]);
						value._10 = Conversions.ToInteger(array2[12]);
						DataStructure.BattleGates_key key = default(DataStructure.BattleGates_key);
						key._MapId = value._MapId;
						key._WarpId = value._WarpId;
						Data.Data_BattleGates.Add(key, value);
					}
				}
				Data.Loaded();
			}
		}
		public static int GetDataBattleGate(DataStructure.BattleGates_key _key, string type)
		{
			int result = 0;
			DataStructure.BattleGates battleGates = Data.Data_BattleGates[_key];
			if (Operators.CompareString(type, "MapId", false) == 0)
			{
				result = battleGates._MapId;
			}
			else
			{
				if (Operators.CompareString(type, "WarpId", false) == 0)
				{
					result = battleGates._WarpId;
				}
				else
				{
					if (Operators.CompareString(type, "Diahinh", false) == 0)
					{
						result = battleGates._Diahinh;
					}
					else
					{
						if (Operators.CompareString(type, "1", false) == 0)
						{
							result = battleGates._1;
						}
						else
						{
							if (Operators.CompareString(type, "2", false) == 0)
							{
								result = battleGates._2;
							}
							else
							{
								if (Operators.CompareString(type, "3", false) == 0)
								{
									result = battleGates._3;
								}
								else
								{
									if (Operators.CompareString(type, "4", false) == 0)
									{
										result = battleGates._4;
									}
									else
									{
										if (Operators.CompareString(type, "5", false) == 0)
										{
											result = battleGates._5;
										}
										else
										{
											if (Operators.CompareString(type, "6", false) == 0)
											{
												result = battleGates._6;
											}
											else
											{
												if (Operators.CompareString(type, "7", false) == 0)
												{
													result = battleGates._7;
												}
												else
												{
													if (Operators.CompareString(type, "8", false) == 0)
													{
														result = battleGates._8;
													}
													else
													{
														if (Operators.CompareString(type, "9", false) == 0)
														{
															result = battleGates._9;
														}
														else
														{
															if (Operators.CompareString(type, "10", false) == 0)
															{
																result = battleGates._10;
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
			return result;
		}
		public static DataStructure.Key_NpcOnMap GetKey_NpcOnMap(int _Mapid, int _Id)
		{
			return new DataStructure.Key_NpcOnMap
			{
				_MapId = _Mapid,
				_Id = _Id
			};
		}
		public static void CreatMapNpc()
		{
			string[] array = Class7.smethod_5().Split(new char[]
			{
				'\r',
				'\r'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length <= 0)
					{
						break;
					}
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (!array2[0].StartsWith("//"))
					{
						int num = Conversions.ToInteger(array2[0]);
						int id = Conversions.ToInteger(array2[1]);
						int npcId = Conversions.ToInteger(array2[2]);
						int num2 = Conversions.ToInteger(array2[3]);
						int num3 = Conversions.ToInteger(array2[4]);
						int coord = Conversions.ToInteger(array2[5]);
						int num4 = Conversions.ToInteger(array2[6]);
						DataStructure.Key_NpcOnMap key_NpcOnMap = Data.GetKey_NpcOnMap(num, id);
						if (!Data.NpcOnMap.ContainsKey(key_NpcOnMap))
						{
							if (num4 > 0)
							{
								Data._ListKeysNpcOnMap.Add(key_NpcOnMap);
							}
							DataStructure._NpcOnMap value = default(DataStructure._NpcOnMap);
							value._MapId = num;
							value._Id = id;
							value._NpcId = npcId;
							value._X_First = num2;
							value._Y_First = num3;
							value._Coord = coord;
							value._Delay = 0;
							value._X = num2;
							value._Y = num3;
							value._SoLuong = num4;
							value._IdBattle = 0;
							Data.NpcOnMap.Add(key_NpcOnMap, value);
						}
					}
				}
				new Thread(new ThreadStart(Data.NpcOnMapWalk))
				{
					IsBackground = true
				}.Start();
			}
		}
		public static void NpcOnMapWalk()
		{
			int num = 0;
			checked
			{
				while (true)
				{
					Thread.Sleep(1000);
					num++;
					try
					{
						IEnumerator enumerator = Data._ListKeysNpcOnMap.GetEnumerator();
						while (enumerator.MoveNext())
						{
							object expr_23 = enumerator.Current;
							DataStructure.Key_NpcOnMap key_NpcOnMap = new DataStructure.Key_NpcOnMap();
							DataStructure.Key_NpcOnMap key = (expr_23 != null) ? ((DataStructure.Key_NpcOnMap)expr_23) : key_NpcOnMap;
							DataStructure._NpcOnMap value = Data.NpcOnMap[key];
							int delay = value._Delay;
							int idBattle = value._IdBattle;
							int mapId = value._MapId;
							int id = value._Id;
							if (!(delay == 0 & idBattle == 0))
							{
								goto IL_401;
							}
							int coord = value._Coord;
							int x_First = value._X_First;
							int y_First = value._Y_First;
							int x = value._X;
							int y = value._Y;
							int num2 = x_First - coord;
							int maxValue = x_First + coord;
							if (num2 < 0)
							{
								num2 = x_First;
							}
							int num3 = y_First - coord;
							int maxValue2 = y_First + coord;
							if (num3 < 0)
							{
								num3 = y_First;
							}
							string text = "";
							if (num >= 3)
							{
								try
								{
									try
									{
										IEnumerator enumerator2 = Server.ListView_Client.Items.GetEnumerator();
										while (enumerator2.MoveNext())
										{
											ListViewItem listViewItem = (ListViewItem)enumerator2.Current;
											try
											{
												Client client = (Client)listViewItem.Tag;
												if (client._socket.Connected)
												{
													int my_Id = client._My_Id;
													int my_MapId = client._My_MapId;
													int my_MapX = client._My_MapX;
													int my_MapY = client._My_MapY;
													int my_IdBattle = client._My_IdBattle;
													int my_IdLeader = client._My_IdLeader;
													if (my_MapId == mapId & my_IdBattle == 0 & (my_IdLeader == 0 | my_IdLeader == my_Id) & client._My_Logined == 1)
													{
														int num4 = (int)Math.Round(Math.Sqrt(unchecked(Math.Pow((double)checked(my_MapX - x_First), 2.0) + Math.Pow((double)checked(my_MapY - y_First), 2.0))));
														if (num4 <= coord)
														{
															int arg_1F4_0 = (int)Math.Round(Math.Sqrt(unchecked(Math.Pow((double)checked(my_MapX - x), 2.0) + Math.Pow((double)checked(my_MapY - y), 2.0))));
															value._X = my_MapX;
															value._Y = my_MapY;
															text = "F44408001602" + Class5.smethod_11(id) + Class5.smethod_11(my_MapX) + Class5.smethod_11(my_MapY);
															Server.SendToAllMapid(mapId, text);
															int soLuong = value._SoLuong;
															int npcId = value._NpcId;
															switch (soLuong)
															{
															case 1:
															{
																DataStructure.TeamDeffender teamdef = default(DataStructure.TeamDeffender);
																teamdef._id3 = npcId;
																Server.Clients[my_Id]._My_TalkingBattle = id;
																value._IdBattle = 1;
																new TheBattle(my_Id, teamdef, 4712);
																break;
															}
															case 3:
															{
																DataStructure.TeamDeffender teamdef2 = default(DataStructure.TeamDeffender);
																teamdef2._id2 = npcId;
																teamdef2._id3 = npcId;
																teamdef2._id4 = npcId;
																Server.Clients[my_Id]._My_TalkingBattle = id;
																value._IdBattle = 1;
																new TheBattle(my_Id, teamdef2, 4712);
																break;
															}
															case 5:
															{
																DataStructure.TeamDeffender teamdef3 = default(DataStructure.TeamDeffender);
																teamdef3._id1 = npcId;
																teamdef3._id2 = npcId;
																teamdef3._id3 = npcId;
																teamdef3._id4 = npcId;
																teamdef3._id5 = npcId;
																Server.Clients[my_Id]._My_TalkingBattle = id;
																value._IdBattle = 1;
																new TheBattle(my_Id, teamdef3, 4712);
																break;
															}
															}
														}
													}
													if (my_MapId == mapId)
													{
														int num5 = Data.random_3.Next(num2, maxValue);
														int num6 = Data.random_3.Next(num3, maxValue2);
														value._X = num5;
														value._Y = num6;
														if (text.Length == 0)
														{
															text = "F44408001602" + Class5.smethod_11(id) + Class5.smethod_11(num5) + Class5.smethod_11(num6);
														}
														client.Sendpacket(text);
													}
												}
											}
											catch (Exception expr_3C1)
											{
												ProjectData.SetProjectError(expr_3C1);
												ProjectData.ClearProjectError();
											}
										}
										goto IL_41E;
									}
									finally
									{
										
									}
								}
								catch (Exception expr_3F3)
								{
									ProjectData.SetProjectError(expr_3F3);
									ProjectData.ClearProjectError();
									goto IL_41E;
								}
								//goto IL_401;
							}
							IL_41E:
							Data.NpcOnMap[key] = value;
							continue;
							IL_401:
							if (delay >= 1)
							{
								value._IdBattle = 0;
								value._Delay--;
								goto IL_41E;
							}
							goto IL_41E;
						}
					}
					finally
					{
						
					}
					if (num >= 3)
					{
						num = 0;
					}
				}
			}
		}
		public static int GetDataNpcOnMap(int _Mapid, int _Id, string type)
		{
			int result = 0;
			if (_Id > 0)
			{
				DataStructure.Key_NpcOnMap key_NpcOnMap = Data.GetKey_NpcOnMap(_Mapid, _Id);
				if (Data.NpcOnMap.ContainsKey(key_NpcOnMap))
				{
					DataStructure._NpcOnMap npcOnMap = Data.NpcOnMap[key_NpcOnMap];
					if (Operators.CompareString(type, "MapId", false) == 0)
					{
						result = npcOnMap._MapId;
					}
					else
					{
						if (Operators.CompareString(type, "Id", false) == 0)
						{
							result = npcOnMap._Id;
						}
						else
						{
							if (Operators.CompareString(type, "NpcId", false) == 0)
							{
								result = npcOnMap._NpcId;
							}
							else
							{
								if (Operators.CompareString(type, "X_First", false) == 0)
								{
									result = npcOnMap._X_First;
								}
								else
								{
									if (Operators.CompareString(type, "Y_First", false) == 0)
									{
										result = npcOnMap._Y_First;
									}
									else
									{
										if (Operators.CompareString(type, "Coord", false) == 0)
										{
											result = npcOnMap._Coord;
										}
										else
										{
											if (Operators.CompareString(type, "SoLuong", false) == 0)
											{
												result = npcOnMap._SoLuong;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}
		public static DataStructure.Key_ItemOnMap GetKey_ItemOnMap(int _Mapid, int _ItemId, int _X, int _Y)
		{
			return new DataStructure.Key_ItemOnMap
			{
				_MapId = _Mapid,
				_ItemId = _ItemId,
				_X = _X,
				_Y = _Y
			};
		}
		public static DataStructure.Key_ItemDropOnMap GetKey_ItemDropOnMap(int _Mapid, int _Slot)
		{
			return new DataStructure.Key_ItemDropOnMap
			{
				_MapId = _Mapid,
				_Slot = _Slot
			};
		}
		public static void SystemDropItem(int _mapid, int _mapx, int _mapy, int _ItemId, int Delay)
		{
			DataStructure.HomdoInfo dataItem = Data.GetDataItem(_ItemId);
			_mapid.ToString();
			string text = "";
			int iD = dataItem._ID;
			int lv = dataItem._Lv;
			int doben = dataItem._Doben;
			int @int = dataItem._Int1;
			int atk = dataItem._Atk1;
			int def = dataItem._Def1;
			int hpx = dataItem._Hpx1;
			int spx = dataItem._Spx1;
			int agi = dataItem._Agi1;
			int fai = dataItem._Fai1;
			int int2 = dataItem._Int2;
			int atk2 = dataItem._Atk2;
			int def2 = dataItem._Def2;
			int hpx2 = dataItem._Hpx2;
			int spx2 = dataItem._Spx2;
			int agi2 = dataItem._Agi2;
			int fai2 = dataItem._Fai2;
			int hp = dataItem._Hp;
			int sp = dataItem._Sp;
			int @long = dataItem._Long;
			int giatriLong = dataItem._GiatriLong;
			int khang = dataItem._Khang;
			int thuoctinh = dataItem._Thuoctinh;
			int giatriThuoctinh = dataItem._GiatriThuoctinh;
			int loai = dataItem._Loai;
			int tExp = dataItem._TExp;
			int num = 1;
			checked
			{
				DataStructure.Key_ItemDropOnMap key_ItemDropOnMap;
				DataStructure._ItemDropOnMap value;
				while (true)
				{
					key_ItemDropOnMap = Data.GetKey_ItemDropOnMap(_mapid, num);
					value = Data.ItemDropOnMap[key_ItemDropOnMap];
					int id = value._Id;
					if (id == 0)
					{
						break;
					}
					num++;
					if (num > 255)
					{
						return;
					}
				}
				value._MapX = _mapx;
				value._MapY = _mapy;
				value._Delay = Delay;
				value._Id = iD;
				value._Count = 1;
				value._Lv = lv;
				value._Doben = doben;
				value._Int1 = @int;
				value._Atk1 = atk;
				value._Def1 = def;
				value._Hpx1 = hpx;
				value._Spx1 = spx;
				value._Agi1 = agi;
				value._Fai1 = fai;
				value._Int2 = int2;
				value._Atk2 = atk2;
				value._Def2 = def2;
				value._Hpx2 = hpx2;
				value._Spx2 = spx2;
				value._Agi2 = agi2;
				value._Fai2 = fai2;
				value._Hp = hp;
				value._Sp = sp;
				value._Long = @long;
				value._GiatriLong = giatriLong;
				value._Khang = khang;
				value._Thuoctinh = thuoctinh;
				value._GiatriThuoctinh = giatriThuoctinh;
				value._Loai = loai;
				value._TExp = tExp;
				value._Gold = 3;
				Data.ItemDropOnMap[key_ItemDropOnMap] = value;
				text = string.Concat(new string[]
				{
					text,
					"F44408001703",
					Class5.smethod_11(iD),
					Class5.smethod_11(_mapx),
					Class5.smethod_11(_mapy)
				});
				Server.SendToAllMapid(_mapid, text);
			}
		}
		public static void SystemDropItem(int _mapid, int _Slot, int _mapx, int _mapy, int _ItemId, int Delay)
		{
			DataStructure.Items items = Data.Data_Items[_ItemId];
			int id = items._id;
			int lv = items._Lv;
			int doben = 0;
			int @int = items._Int1;
			int atk = items._Atk1;
			int def = items._Def1;
			int hpx = items._Hpx1;
			int spx = items._Spx1;
			int agi = items._Agi1;
			int fai = items._Fai1;
			int int2 = items._Int2;
			int atk2 = items._Atk2;
			int def2 = items._Def2;
			int hpx2 = items._Hpx2;
			int spx2 = items._Spx2;
			int agi2 = items._Agi2;
			int fai2 = items._Fai2;
			int hp = items._Hp;
			int sp = items._Sp;
			int @long = 0;
			int giatriLong = 0;
			int khang = 0;
			int thuoctinh = items._Thuoctinh;
			int giatriThuoctinh = items._GiatriThuoctinh;
			int loai = items._Loai;
			int tExp = 0;
			DataStructure.Key_ItemDropOnMap key_ItemDropOnMap = Data.GetKey_ItemDropOnMap(_mapid, _Slot);
			DataStructure._ItemDropOnMap value = Data.ItemDropOnMap[key_ItemDropOnMap];
			int id2 = value._Id;
			if (id2 == 0)
			{
				value._MapX = _mapx;
				value._MapY = _mapy;
				value._Delay = Delay;
				value._Id = id;
				value._Count = 1;
				value._Lv = lv;
				value._Doben = doben;
				value._Int1 = @int;
				value._Atk1 = atk;
				value._Def1 = def;
				value._Hpx1 = hpx;
				value._Spx1 = spx;
				value._Agi1 = agi;
				value._Fai1 = fai;
				value._Int2 = int2;
				value._Atk2 = atk2;
				value._Def2 = def2;
				value._Hpx2 = hpx2;
				value._Spx2 = spx2;
				value._Agi2 = agi2;
				value._Fai2 = fai2;
				value._Hp = hp;
				value._Sp = sp;
				value._Long = @long;
				value._GiatriLong = giatriLong;
				value._Khang = khang;
				value._Thuoctinh = thuoctinh;
				value._GiatriThuoctinh = giatriThuoctinh;
				value._Loai = loai;
				value._TExp = tExp;
				value._Gold = 3;
				Data.ItemDropOnMap[key_ItemDropOnMap] = value;
				Server.SendToAllMapid(_mapid, "F44408001703" + Class5.smethod_11(id) + Class5.smethod_11(_mapx) + Class5.smethod_11(_mapy));
			}
		}
		public static void CreatMapItem()
		{
			string[] array = Class7.smethod_3().Split(new char[]
			{
				'\r',
				'\r'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length <= 0)
					{
						break;
					}
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (!array2[0].StartsWith("//"))
					{
						int num = Conversions.ToInteger(array2[0]);
						DataStructure.Key_ItemDropOnMap key_ItemDropOnMap = default(DataStructure.Key_ItemDropOnMap);
						key_ItemDropOnMap._MapId = num;
						key_ItemDropOnMap._Slot = 1;
						if (!Data.ItemDropOnMap.ContainsKey(key_ItemDropOnMap))
						{
							int num2 = 1;
							do
							{
								DataStructure._ItemDropOnMap value = default(DataStructure._ItemDropOnMap);
								value._MapId = num;
								value._Slot = num2;
								key_ItemDropOnMap._Slot = num2;
								Data._ListKeysItemDropOnMap.Add(key_ItemDropOnMap);
								Data.ItemDropOnMap.Add(key_ItemDropOnMap, value);
								num2++;
							}
							while (num2 <= 255);
						}
						int slot = Conversions.ToInteger(array2[1]);
						int itemId = Conversions.ToInteger(array2[2]);
						int num3 = Conversions.ToInteger(array2[3]);
						int num4 = Conversions.ToInteger(array2[4]);
						int delay = Conversions.ToInteger(array2[5]);
						DataStructure.Key_ItemOnMap key_ItemOnMap = Data.GetKey_ItemOnMap(num, itemId, num3, num4);
						if (!Data.ItemOnMap.ContainsKey(key_ItemOnMap))
						{
							Data._ListKeysItemOnMap.Add(key_ItemOnMap);
							DataStructure._ItemOnMap value2 = default(DataStructure._ItemOnMap);
							value2._MapId = num;
							value2._ItemId = itemId;
							value2._X = num3;
							value2._Y = num4;
							value2._Delay = delay;
							value2._DelayDec = 0;
							Data.ItemOnMap.Add(key_ItemOnMap, value2);
							Data.SystemDropItem(num, slot, num3, num4, itemId, 999999);
						}
					}
				}
				new Thread(new ThreadStart(Data._RemoveItemOnMap))
				{
					IsBackground = true
				}.Start();
				new Thread(new ThreadStart(Data.ItemOnMapShow))
				{
					IsBackground = true
				}.Start();
			}
		}
		public static void _RemoveItemOnMap()
		{
			checked
			{
				while (true)
				{
					Thread.Sleep(1000);
					int num = Data._ListKeysItemDropOnMap.Count - 1;
					int arg_110_0 = 0;
					int num2 = num;
					for (int i = arg_110_0; i <= num2; i++)
					{
						if (i <= Data._ListKeysItemDropOnMap.Count - 1)
						{
							object expr_23 = Data._ListKeysItemDropOnMap[i];
							DataStructure.Key_ItemDropOnMap key_ItemDropOnMap = new DataStructure.Key_ItemDropOnMap();
							DataStructure.Key_ItemDropOnMap key = (expr_23 != null) ? ((DataStructure.Key_ItemDropOnMap)expr_23) : key_ItemDropOnMap;
							DataStructure._ItemDropOnMap value = Data.ItemDropOnMap[key];
							int id = value._Id;
							if (id > 0)
							{
								int delay = value._Delay;
								if (delay > 0 & delay != 999999)
								{
									value._Delay--;
									Data.ItemDropOnMap[key] = value;
								}
								else
								{
									if (delay == 0)
									{
										Server.SendToAllMapid(key._MapId, "F44404001702" + Class5.smethod_11(key._Slot));
										DataStructure._ItemDropOnMap value2 = default(DataStructure._ItemDropOnMap);
										value2._MapId = value._MapId;
										value2._Slot = value._Slot;
										Data.ItemDropOnMap[key] = value2;
									}
								}
							}
						}
					}
				}
			}
		}
		public static void ItemOnMapShow()
		{
			checked
			{
				while (true)
				{
					Thread.Sleep(1000);
					try
					{
						IEnumerator enumerator = Data._ListKeysItemOnMap.GetEnumerator();
						while (enumerator.MoveNext())
						{
							object expr_1C = enumerator.Current;
							DataStructure.Key_ItemOnMap key_ItemOnMap = new DataStructure.Key_ItemOnMap();
							DataStructure.Key_ItemOnMap key = (expr_1C != null) ? ((DataStructure.Key_ItemOnMap)expr_1C) : key_ItemOnMap;
							DataStructure._ItemOnMap value = Data.ItemOnMap[key];
							int delayDec = value._DelayDec;
							if (delayDec > 1)
							{
								value._DelayDec--;
							}
							else
							{
								if (delayDec == 1)
								{
									int mapId = value._MapId;
									int itemId = value._ItemId;
									int x = value._X;
									int y = value._Y;
									Data.SystemDropItem(mapId, x, y, itemId, 999999);
									value._DelayDec = 0;
								}
							}
							Data.ItemOnMap[key] = value;
						}
					}
					finally
					{
						
					}
				}
			}
		}
		public static void GetDataItemOnMap(int _id)
		{
			checked
			{
				if (Server.Clients.ContainsKey(_id))
				{
					int my_MapId = Server.Clients[_id]._My_MapId;
					string text = "";
					int num = 1;
					do
					{
						DataStructure.Key_ItemDropOnMap key_ItemDropOnMap = Data.GetKey_ItemDropOnMap(my_MapId, num);
						if (Data.ItemDropOnMap.ContainsKey(key_ItemDropOnMap))
						{
							DataStructure._ItemDropOnMap itemDropOnMap = Data.ItemDropOnMap[key_ItemDropOnMap];
							int id = itemDropOnMap._Id;
							if (id > 0)
							{
								int mapX = itemDropOnMap._MapX;
								int mapY = itemDropOnMap._MapY;
								int slot = itemDropOnMap._Slot;
								int gold = itemDropOnMap._Gold;
								text = string.Concat(new string[]
								{
									text,
									gold.ToString("X2"),
									Class5.smethod_11(slot),
									Class5.smethod_12(id),
									Class5.smethod_11(mapX),
									Class5.smethod_11(mapY)
								});
							}
						}
						num++;
					}
					while (num <= 255);
					if (text.Length > 0)
					{
						text = "F444" + Class5.smethod_11((int)Math.Round(unchecked((double)text.Length / 2.0 + 2.0))) + "1704" + text;
						Server.SendToClient(_id, text);
					}
				}
			}
		}
		public static void LoadDataFormulaHP()
		{
			string[] array = Class7.smethod_1().Split(new char[]
			{
				'\r',
				'\r'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length <= 0)
					{
						break;
					}
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (!array2[0].StartsWith("//"))
					{
						Data.FormulaHP.Add(Conversions.ToInteger(array2[0]), array2);
					}
				}
				new Thread(new ThreadStart(Data.LoadDataFormulaHPCS))
				{
					IsBackground = true
				}.Start();
			}
		}
		public static void LoadDataFormulaHPCS()
		{
			string[] array = Class7.smethod_2().Split(new char[]
			{
				'\r',
				'\r'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length <= 0)
					{
						break;
					}
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (!array2[0].StartsWith("//"))
					{
						Data.dictionary_0.Add(Conversions.ToInteger(array2[0]), array2);
					}
				}
				new Thread(new ThreadStart(Data.LoadDataFormulaSP))
				{
					IsBackground = true
				}.Start();
			}
		}
		public static void LoadDataFormulaSP()
		{
			string[] array = Class7.smethod_7().Split(new char[]
			{
				'\r',
				'\r'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length <= 0)
					{
						break;
					}
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (!array2[0].StartsWith("//"))
					{
						Data.FormulaSP.Add(Conversions.ToInteger(array2[0]), array2);
					}
				}
				new Thread(new ThreadStart(Data.LoadDataFormulaSPCS))
				{
					IsBackground = true
				}.Start();
			}
		}
		public static void LoadDataFormulaSPCS()
		{
			string[] array = Class7.smethod_8().Split(new char[]
			{
				'\r',
				'\r'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length <= 0)
					{
						break;
					}
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (!array2[0].StartsWith("//"))
					{
						Data.dictionary_1.Add(Conversions.ToInteger(array2[0]), array2);
					}
				}
			}
		}
	}
}
