using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
namespace Server_TS_Online
{
	public class Client
	{
		private string string_0;
		public OleDbConnection conn;
		private int int_0;
		private string string_1;
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
		public int idnpctalking;
		public string Typetalk;
		public int SelectMenu;
		private int[] int_1;
		public Socket _socket;
		public byte[] _buffer;
		private string string_2;
		private Random random_0;
		public Client(Socket _c)
		{
			this.int_0 = 186;
			this._my_DiaHinh = 0;
			this._My_Logined = 0;
			this._My_Id = 0;
			this._My_Name = "";
			this._My_Lv = 0;
			this._My_Hp = 0;
			this._My_HpMax = 0;
			this._My_Sp = 0;
			this._My_SpMax = 0;
			this._My_Point = 0;
			this._My_SkillPoint = 0;
			this._My_Int = 0;
			this._My_Atk = 0;
			this._My_Def = 0;
			this._My_Hpx = 0;
			this._My_Spx = 0;
			this._My_Agi = 0;
			this._My_Int2 = 0;
			this._My_Atk2 = 0;
			this._My_Def2 = 0;
			this._My_Hpx2 = 0;
			this._My_Spx2 = 0;
			this._My_Agi2 = 0;
			this._My_Texp = 0;
			this._My_MapId = 0;
			this._My_MapX = 0;
			this._My_MapY = 0;
			this._My_Reborn = 0;
			this._My_Job = 0;
			this._My_Sex = 0;
			this._My_Hair = 0;
			this._My_Thuoctinh = 0;
			this._My_Ghost = 0;
			this._My_God = 0;
			this._My_Color = "";
			this._My_Gold = 0;
			this._My_Tiengtam = 0;
			this._My_Gocnhin = 0;
			this._My_SttPetXuatChien = 0;
			this._My_Pk = 0;
			this._My_ThamChien = 0;
			this._My_IdLeader = 0;
			this._My_IdMem1 = 0;
			this._My_IdMem2 = 0;
			this._My_IdMem3 = 0;
			this._My_IdMem4 = 0;
			this._My_IdQS = 0;
			this._My_IdXinVaoNhom = 0;
			this._My_IdMoiVaoNhom = 0;
			this._My_IdBattle = 0;
			this._My_Dongtac = 0;
			this._My_Horse = 0;
			this._My_WarpingId = 0;
			this._My_TalkingBattle = 0;
			this.ListPet = new Dictionary<int, DataStructure._MyPet>();
			this.warpfinish = false;
			this.talkcount = 0;
			this.idtalking = 0;
			this.idnpctalking = 0;
			this.Typetalk = "NPC";
			this.SelectMenu = 0;
			this.int_1 = new int[]
			{
				22002,
				22003,
				22004,
				22005,
				22028,
				22029,
				22032,
				22033,
				22034,
				22035,
				22039,
				22053,
				22054,
				22055,
				22056,
				41187
			};
			this._buffer = new byte[8192];
			this.string_2 = "";
			this.random_0 = new Random();
			this._socket = _c;
			this.SetupRecieveCallback(_c);
			int num = 1;
			checked
			{
				do
				{
					DataStructure._MyPet value = default(DataStructure._MyPet);
					this.ListPet.Add(num, value);
					num++;
				}
				while (num <= 4);
			}
		}
		protected void shutdown()
		{
			checked
			{
				if (this._My_IdBattle > 0 & Server.TheBattles.ContainsKey(this._My_IdBattle))
				{
					TheBattle theBattle = Server.TheBattles[this._My_IdBattle];
					try
					{
						try
						{
							IEnumerator enumerator = Server.TheBattles[this._My_IdBattle]._keys.GetEnumerator();
							while (enumerator.MoveNext())
							{
								string key = Conversions.ToString(enumerator.Current);
								DataStructure.WarInfo value = Server.TheBattles[this._My_IdBattle].ListWar[key];
								int id = value._Id;
								int type = value._Type;
								if (type == 2)
								{
									if (id == this._My_Id)
									{
										string text = "";
										int row = value._Row;
										int column = value._Column;
										theBattle.ChangedWar(Class5.smethod_3(new byte[]
										{
											(byte)row,
											(byte)column
										}), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
										text = text + "F44404000B01" + (row ^ 1).ToString("X2") + column.ToString("X2");
										theBattle.ChangedWar(Class5.smethod_3(new byte[]
										{
											(byte)(row ^ 1),
											(byte)column
										}), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
										text = string.Concat(new string[]
										{
											text,
											"F44408000B00",
											Class5.smethod_12(id),
											"0000F44405000B01",
											row.ToString("X2"),
											column.ToString("X2"),
											"00"
										});
										theBattle.SendSKillingToParty(text);
										Server.SendToAllClientMapid(id, "F44408000B00" + Class5.smethod_12(id) + "0000");
										this._My_IdBattle = 0;
									}
									if (this._My_IdLeader == this._My_Id && (id == this._My_IdMem1 | id == this._My_IdMem2 | id == this._My_IdMem3 | id == this._My_IdMem4) && Server.Clients.ContainsKey(id))
									{
										Client arg_257_0 = Server.Clients[id];
										string text2 = "";
										int row2 = value._Row;
										int column2 = value._Column;
										text2 = text2 + "F44404000B01" + (row2 ^ 1).ToString("X2") + column2.ToString("X2");
										text2 = string.Concat(new string[]
										{
											text2,
											"F44408000B00",
											Class5.smethod_12(id),
											"0000F44405000B01",
											row2.ToString("X2"),
											column2.ToString("X2"),
											"00"
										});
										theBattle.SendSKillingToParty(text2);
										Server.SendToAllClientMapid(id, "F44408000B00" + Class5.smethod_12(id) + "0000");
										theBattle.ChangedWar(Class5.smethod_3(new byte[]
										{
											(byte)(row2 ^ 1),
											(byte)column2
										}), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
										theBattle.ChangedWar(Class5.smethod_3(new byte[]
										{
											(byte)row2,
											(byte)column2
										}), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
										Server.Clients[id]._My_IdBattle = 0;
									}
								}
								if (Server.TheBattles[this._My_IdBattle].ListWar.ContainsKey(key))
								{
									Server.TheBattles[this._My_IdBattle].ListWar[key] = value;
								}
							}
						}
						finally
						{
                            /*
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
                             * */
						}
					}
					catch (Exception expr_417)
					{
						ProjectData.SetProjectError(expr_417);
						ProjectData.ClearProjectError();
					}
				}
				this.GiaiTanParty(this._My_Id);
				Server.ServerSend_PlayerOffline(this._My_Id);
				try
				{
					this._socket.Close();
				}
				catch (Exception expr_449)
				{
					ProjectData.SetProjectError(expr_449);
					ProjectData.ClearProjectError();
				}
				Server.Clients.Remove(this._My_Id);
			}
		}
		public void SetupRecieveCallback(Socket sock)
		{
			try
			{
				AsyncCallback callback = new AsyncCallback(this.OnRecievedData);
				sock.BeginReceive(this._buffer, 0, this._buffer.Length, SocketFlags.None, callback, sock);
			}
			catch (Exception expr_2A)
			{
				ProjectData.SetProjectError(expr_2A);
				this.shutdown();
				ProjectData.ClearProjectError();
			}
		}
		public void OnRecievedData(IAsyncResult ar)
		{
			Socket socket = (Socket)ar.AsyncState;
			try
			{
				int num = socket.EndReceive(ar);
				if (num > 0)
				{
					Array.Resize<byte>(ref this._buffer, num);
					this.UpdateMainGrid(this._buffer);
					Array.Resize<byte>(ref this._buffer, 8192);
					this.SetupRecieveCallback(socket);
				}
				else
				{
					this.shutdown();
				}
			}
			catch (Exception expr_51)
			{
				ProjectData.SetProjectError(expr_51);
				this.shutdown();
				ProjectData.ClearProjectError();
			}
		}
		public void UpdateMainGrid(byte[] _buffer)
		{
			string text = this.string_2 + Class5.smethod_3(Class5.smethod_5(_buffer));
			this.string_2 = "";
			checked
			{
				while (text.Length != 0)
				{
					if (text.Length >= 8)
					{
						int num = Class5.smethod_14(text.Substring(4, 4));
						if (text.Length >= 8 + num * 2)
						{
							string text2 = text.Substring(0, 8 + num * 2);
							new Thread(delegate(object a0)
							{
								this.UpdateMainGrid_Recv((byte[])a0);
							})
							{
								IsBackground = true
							}.Start(Class5.smethod_4(text2));
							text = text.Substring(8 + num * 2);
							continue;
						}
						this.string_2 = text;
					}
					else
					{
						this.string_2 = text;
					}
					return;
				}
			}
		}
		public void Sleep()
		{
			if (this._My_IdBattle > 0)
			{
				return;
			}
			this.Sendpacket("F44402001F0A");
			if (this._My_Hp < this._My_HpMax)
			{
				Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Hp, this._My_HpMax);
			}
			if (this._My_Sp < this._My_SpMax)
			{
				Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Sp, this._My_SpMax);
			}
			int num = 1;
			checked
			{
				do
				{
					int num2 = Data.PetGetData(this.conn, num, DataStructure.Type_Pet._ID);
					int num3 = Data.PetGetData(this.conn, num, DataStructure.Type_Pet._Hp);
					int num4 = Data.PetGetData(this.conn, num, DataStructure.Type_Pet._Sp);
					int num5 = Data.PetGetData(this.conn, num, DataStructure.Type_Pet._Hpmax);
					int num6 = Data.PetGetData(this.conn, num, DataStructure.Type_Pet._Spmax);
					if (num2 > 0)
					{
						if (num3 < num5)
						{
							Data.PetUpdateData(this._My_Id, num, DataStructure.Type_Pet._Hp, num5);
						}
						if (num4 < num6)
						{
							Data.PetUpdateData(this._My_Id, num, DataStructure.Type_Pet._Sp, num6);
						}
					}
					num++;
				}
				while (num <= 4);
				this.Sendpacket("F44403001F0100");
				if (this._My_Id == this._My_IdLeader)
				{
					if (this._My_IdMem1 > 0 & Server.Clients.ContainsKey(this._My_IdMem1))
					{
						Server.SendToClient(this._My_IdMem1, "F44402001F0A");
						Client client = Server.Clients[this._My_IdMem1];
						int my_Hp = client._My_Hp;
						int my_Sp = client._My_Sp;
						int my_HpMax = client._My_HpMax;
						int my_SpMax = client._My_SpMax;
						if (my_Hp < my_HpMax)
						{
							Data.PlayerUpdateDataId(this._My_IdMem1, DataStructure.Type_Player._Hp, my_HpMax);
						}
						if (my_Sp < my_SpMax)
						{
							Data.PlayerUpdateDataId(this._My_IdMem1, DataStructure.Type_Player._Sp, my_SpMax);
						}
						int num7 = 1;
						do
						{
							int num8 = Data.PetGetData(client.conn, num7, DataStructure.Type_Pet._ID);
							int num9 = Data.PetGetData(client.conn, num7, DataStructure.Type_Pet._Hp);
							int num10 = Data.PetGetData(client.conn, num7, DataStructure.Type_Pet._Sp);
							int num11 = Data.PetGetData(client.conn, num7, DataStructure.Type_Pet._Hpmax);
							int num12 = Data.PetGetData(client.conn, num7, DataStructure.Type_Pet._Spmax);
							if (num8 > 0)
							{
								if (num9 < num11)
								{
									Data.PetUpdateData(this._My_IdMem1, num7, DataStructure.Type_Pet._Hp, num11);
								}
								if (num10 < num12)
								{
									Data.PetUpdateData(this._My_IdMem1, num7, DataStructure.Type_Pet._Sp, num12);
								}
							}
							num7++;
						}
						while (num7 <= 4);
						Server.SendToClient(this._My_IdMem1, "F44403001F0100");
					}
					if (this._My_IdMem2 > 0 & Server.Clients.ContainsKey(this._My_IdMem2))
					{
						Server.SendToClient(this._My_IdMem2, "F44402001F0A");
						Client client2 = Server.Clients[this._My_IdMem2];
						int my_Hp2 = client2._My_Hp;
						int my_Sp2 = client2._My_Sp;
						int my_HpMax2 = client2._My_HpMax;
						int my_SpMax2 = client2._My_SpMax;
						if (my_Hp2 < my_HpMax2)
						{
							Data.PlayerUpdateDataId(this._My_IdMem2, DataStructure.Type_Player._Hp, my_HpMax2);
						}
						if (my_Sp2 < my_SpMax2)
						{
							Data.PlayerUpdateDataId(this._My_IdMem2, DataStructure.Type_Player._Sp, my_SpMax2);
						}
						int num13 = 1;
						do
						{
							int num14 = Data.PetGetData(client2.conn, num13, DataStructure.Type_Pet._ID);
							int num15 = Data.PetGetData(client2.conn, num13, DataStructure.Type_Pet._Hp);
							int num16 = Data.PetGetData(client2.conn, num13, DataStructure.Type_Pet._Sp);
							int num17 = Data.PetGetData(client2.conn, num13, DataStructure.Type_Pet._Hpmax);
							int num18 = Data.PetGetData(client2.conn, num13, DataStructure.Type_Pet._Spmax);
							if (num14 > 0)
							{
								if (num15 < num17)
								{
									Data.PetUpdateData(this._My_IdMem2, num13, DataStructure.Type_Pet._Hp, num17);
								}
								if (num16 < num18)
								{
									Data.PetUpdateData(this._My_IdMem2, num13, DataStructure.Type_Pet._Sp, num18);
								}
							}
							num13++;
						}
						while (num13 <= 4);
						Server.SendToClient(this._My_IdMem2, "F44403001F0100");
					}
					if (this._My_IdMem3 > 0 & Server.Clients.ContainsKey(this._My_IdMem3))
					{
						Server.SendToClient(this._My_IdMem3, "F44402001F0A");
						Client client3 = Server.Clients[this._My_IdMem3];
						int my_Hp3 = client3._My_Hp;
						int my_Sp3 = client3._My_Sp;
						int my_HpMax3 = client3._My_HpMax;
						int my_SpMax3 = client3._My_SpMax;
						if (my_Hp3 < my_HpMax3)
						{
							Data.PlayerUpdateDataId(this._My_IdMem3, DataStructure.Type_Player._Hp, my_HpMax3);
						}
						if (my_Sp3 < my_SpMax3)
						{
							Data.PlayerUpdateDataId(this._My_IdMem3, DataStructure.Type_Player._Sp, my_SpMax3);
						}
						int num19 = 1;
						do
						{
							int num20 = Data.PetGetData(client3.conn, num19, DataStructure.Type_Pet._ID);
							int num21 = Data.PetGetData(client3.conn, num19, DataStructure.Type_Pet._Hp);
							int num22 = Data.PetGetData(client3.conn, num19, DataStructure.Type_Pet._Sp);
							int num23 = Data.PetGetData(client3.conn, num19, DataStructure.Type_Pet._Hpmax);
							int num24 = Data.PetGetData(client3.conn, num19, DataStructure.Type_Pet._Spmax);
							if (num20 > 0)
							{
								if (num21 < num23)
								{
									Data.PetUpdateData(this._My_IdMem3, num19, DataStructure.Type_Pet._Hp, num23);
								}
								if (num22 < num24)
								{
									Data.PetUpdateData(this._My_IdMem3, num19, DataStructure.Type_Pet._Sp, num24);
								}
							}
							num19++;
						}
						while (num19 <= 4);
						Server.SendToClient(this._My_IdMem3, "F44403001F0100");
					}
					if (this._My_IdMem4 > 0 & Server.Clients.ContainsKey(this._My_IdMem4))
					{
						Server.SendToClient(this._My_IdMem4, "F44402001F0A");
						Client client4 = Server.Clients[this._My_IdMem4];
						int my_Hp4 = client4._My_Hp;
						int my_Sp4 = client4._My_Sp;
						int my_HpMax4 = client4._My_HpMax;
						int my_SpMax4 = client4._My_SpMax;
						if (my_Hp4 < my_HpMax4)
						{
							Data.PlayerUpdateDataId(this._My_IdMem4, DataStructure.Type_Player._Hp, my_HpMax4);
						}
						if (my_Sp4 < my_SpMax4)
						{
							Data.PlayerUpdateDataId(this._My_IdMem4, DataStructure.Type_Player._Sp, my_SpMax4);
						}
						int num25 = 1;
						do
						{
							int num26 = Data.PetGetData(client4.conn, num25, DataStructure.Type_Pet._ID);
							int num27 = Data.PetGetData(client4.conn, num25, DataStructure.Type_Pet._Hp);
							int num28 = Data.PetGetData(client4.conn, num25, DataStructure.Type_Pet._Sp);
							int num29 = Data.PetGetData(client4.conn, num25, DataStructure.Type_Pet._Hpmax);
							int num30 = Data.PetGetData(client4.conn, num25, DataStructure.Type_Pet._Spmax);
							if (num26 > 0)
							{
								if (num27 < num29)
								{
									Data.PetUpdateData(this._My_IdMem4, num25, DataStructure.Type_Pet._Hp, num29);
								}
								if (num28 < num30)
								{
									Data.PetUpdateData(this._My_IdMem4, num25, DataStructure.Type_Pet._Sp, num30);
								}
							}
							num25++;
						}
						while (num25 <= 4);
						Server.SendToClient(this._My_IdMem4, "F44403001F0100");
					}
				}
			}
		}
		public void UpdateMainGrid_Recv(byte[] packet)
		{
			switch (packet[4])
			{
			case 0:
				this.Update_H0(packet);
				break;
			case 1:
				this.Update_H1(packet);
				break;
			case 2:
				this.Update_H2(packet);
				break;
			case 3:
				this.Update_H3(packet);
				break;
			case 6:
				this.Update_H6(packet);
				break;
			case 8:
				this.Update_H8(packet);
				break;
			case 9:
				this.Update_H9(packet);
				break;
			case 11:
				this.Update_HB(packet);
				break;
			case 12:
				this.Update_HC(packet);
				break;
			case 13:
				this.Update_HD(packet);
				break;
			case 15:
				this.Update_HF(packet);
				break;
			case 19:
				this.Update_H13(packet);
				break;
			case 20:
				this.Update_H14(packet);
				break;
			case 23:
				this.Update_H17(packet);
				break;
			case 28:
				this.Update_H1C(packet);
				break;
			case 29:
				this.Update_H1D(packet);
				break;
			case 30:
				this.Update_H1E(packet);
				break;
			case 32:
				this.Update_H20(packet);
				break;
			case 33:
				this.Update_H21(packet);
				break;
			case 34:
				this.Update_H22(packet);
				break;
			case 35:
				this.Update_H23(packet);
				break;
			case 40:
				this.Update_H28(packet);
				break;
			case 50:
				this.Update_H32(packet);
				break;
			}
		}
		public void Update_H0(byte[] packet)
		{
			if (Operators.CompareString(Class5.smethod_3(packet), "F444010000", false) == 0)
			{
				this.Sendpacket("F4440300010901");
			}
		}
		public void Update_H1(byte[] packet)
		{
			int num = Class5.smethod_10(new byte[]
			{
				packet[6],
				packet[7],
				packet[8],
				packet[9]
			});
			string text = "";
			int arg_3C_0 = 14;
			checked
			{
				int num2 = packet.Length - 1;
				for (int i = arg_3C_0; i <= num2; i++)
				{
					text += Conversions.ToString(Strings.Chr((int)packet[i]));
				}
				string value = Conversions.ToString(Class5.smethod_9(new byte[]
				{
					packet[12],
					packet[13]
				}));
				string value2 = Conversions.ToString(Strings.Chr((int)packet[10])) + Conversions.ToString(Strings.Chr((int)packet[11]));
				if (Operators.CompareString(Strings.LCase(value2), "vn", false) == 0)
				{
					if (Conversions.ToDouble(value) == (double)this.int_0)
					{
						if (Data.MemberGetIdExits(num))
						{
							if (Operators.CompareString(Data.MemberGetData(num, "pass1"), text, false) == 0)
							{
								if (!Server.Clients.ContainsKey(num))
								{
									this._My_Id = num;
									this.Logined();
								}
								else
								{
									this.shutdown();
								}
							}
							else
							{
								this.WrongPass();
							}
						}
						else
						{
							this.shutdown();
						}
					}
					else
					{
						this.shutdown();
					}
				}
			}
		}
		public void Update_H2(byte[] packet)
		{
			switch (packet[5])
			{
			case 2:
				FChat.H2(this._My_Id, packet);
				break;
			case 3:
				FChat.H3(this._My_Id, packet);
				break;
			case 5:
				FChat.H5(this._My_Id, packet);
				break;
			}
		}
		public void Update_H3(byte[] packet)
		{
			if (Operators.CompareString(Class5.smethod_3(packet), "F44402000301", false) == 0)
			{
				this.Logined();
			}
		}
		public void Update_H6(byte[] packet)
		{
			byte b = packet[5];
			if (b == 1)
			{
				FWalk.H1(this, packet);
			}
		}
		public void Update_H8(byte[] packet)
		{
			byte b = packet[5];
			checked
			{
				if (b == 1)
				{
					if (this._My_IdBattle > 0)
					{
						return;
					}
					int num = (int)packet[8];
					int num2 = (int)packet[9];
					if (this._My_Point > 0 & this._My_Point >= num2)
					{
						switch (num)
						{
						case 25:
						{
							int value = Data.CongthucHP(this._My_Reborn, this._My_Job, this._My_Lv, this._My_Hpx + num2) + this._My_Hpx2;
							Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Hp, value);
							break;
						}
						case 26:
						{
							int value2 = Data.CongthucSP(this._My_Reborn, this._My_Job, this._My_Lv, this._My_Spx + num2) + this._My_Spx2;
							Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Sp, value2);
							break;
						}
						case 27:
							if (this._My_Int < 400)
							{
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Point, this._My_Point - num2);
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Int, this._My_Int + num2);
							}
							break;
						case 28:
							if (this._My_Atk < 400)
							{
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Point, this._My_Point - num2);
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Atk, this._My_Atk + num2);
							}
							break;
						case 29:
							if (this._My_Def < 400)
							{
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Point, this._My_Point - num2);
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Def, this._My_Def + num2);
							}
							break;
						case 30:
							if (this._My_Agi < 400)
							{
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Point, this._My_Point - num2);
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Agi, this._My_Agi + num2);
							}
							break;
						case 31:
							if (this._My_Hpx < 400)
							{
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Point, this._My_Point - num2);
								int value3 = Data.CongthucHP(this._My_Reborn, this._My_Job, this._My_Lv, this._My_Hpx + num2) + this._My_Hpx2;
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Hpmax, value3);
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Hpx, this._My_Hpx + num2);
							}
							break;
						case 32:
							if (this._My_Spx < 400)
							{
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Point, this._My_Point - num2);
								int value4 = Data.CongthucSP(this._My_Reborn, this._My_Job, this._My_Lv, this._My_Spx + num2) + this._My_Spx2;
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Spmax, value4);
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Spx, this._My_Spx + num2);
							}
							break;
						}
					}
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void Update_H9(byte[] packet)
		{
			checked
			{
				switch (packet[5])
				{
				case 1:
					try
					{
						this.string_0 = Class1.Form0_0.Info.DirectoryPath + "\\member\\vn" + this._My_Id.ToString() + ".accdb";
						File.Copy("CSDL\\NewChar.accdb", this.string_0, true);
						int value = (int)packet[6];
						int num = 1;
						int num2 = 0;
						int value2 = (int)packet[8];
						string text = Class5.smethod_3(new byte[]
						{
							packet[10],
							packet[11],
							packet[12],
							packet[13],
							packet[14],
							packet[15],
							packet[16],
							packet[17]
						});
						int value3 = (int)packet[18];
						int value4 = (int)packet[19];
						int value5 = (int)packet[20];
						int value6 = (int)packet[21];
						int num3 = (int)packet[22];
						int num4 = (int)packet[23];
						int value7 = (int)packet[24];
						int value8 = 0;
						int value9 = 0;
						int value10 = 0;
						int num5 = 0;
						int num6 = 0;
						int value11 = 1;
						int num7 = (int)packet[25];
						string text2 = "";
						int arg_108_0 = 26;
						int num8 = 26 + num7 - 1;
						for (int i = arg_108_0; i <= num8; i++)
						{
							text2 += Conversions.ToString(Strings.Chr((int)packet[i]));
						}
						string text3 = "";
						int arg_144_0 = 26 + num7 + 1;
						int num9 = packet.Length - 1;
						for (int j = arg_144_0; j <= num9; j++)
						{
							text3 += Conversions.ToString(Strings.Chr((int)packet[j]));
						}
						int value12 = Data.CongthucHP(num, num2, 1, num3) + num5;
						int value13 = Data.CongthucSP(num, num2, 1, num4) + num6;
						string cmdText = string.Concat(new string[]
						{
							"Insert Into Player(Id, Name, Lv, Hp, HpMax, Sp, SpMax, Point, SkillPoint, [Int], Atk, Def, Hpx, Spx, Agi, Int2, Atk2, Def2, Hpx2, Spx2, Agi2, Texp, MapId, MapX, MapY, Reborn, Job, Sex, Hair, Thuoctinh, Ghost, God, Color, Gold, Tiengtam, Gocnhin, SttPetXuatchien, Pk, ThamChien) Values(",
							Conversions.ToString(this._My_Id),
							", '",
							this.string_1,
							"', ",
							Conversions.ToString(1),
							", ",
							Conversions.ToString(value12),
							", ",
							Conversions.ToString(value12),
							", ",
							Conversions.ToString(value13),
							", ",
							Conversions.ToString(value13),
							", ",
							Conversions.ToString(0),
							", ",
							Conversions.ToString(0),
							", ",
							Conversions.ToString(value4),
							", ",
							Conversions.ToString(value5),
							", ",
							Conversions.ToString(value6),
							", ",
							Conversions.ToString(num3),
							", ",
							Conversions.ToString(num4),
							", ",
							Conversions.ToString(value7),
							", ",
							Conversions.ToString(value8),
							", ",
							Conversions.ToString(value9),
							", ",
							Conversions.ToString(value10),
							", ",
							Conversions.ToString(num5),
							", ",
							Conversions.ToString(num6),
							", ",
							Conversions.ToString(value11),
							", ",
							Conversions.ToString(6),
							", ",
							Conversions.ToString(10817),
							", ",
							Conversions.ToString(442),
							", ",
							Conversions.ToString(758),
							", ",
							Conversions.ToString(num),
							", ",
							Conversions.ToString(num2),
							", ",
							Conversions.ToString(value),
							", ",
							Conversions.ToString(value2),
							", ",
							Conversions.ToString(value3),
							", ",
							Conversions.ToString(0),
							", ",
							Conversions.ToString(0),
							", '",
							text,
							"', ",
							Conversions.ToString(999999),
							", ",
							Conversions.ToString(999999999),
							", ",
							Conversions.ToString(0),
							", ",
							Conversions.ToString(0),
							", ",
							Conversions.ToString(0),
							", ",
							Conversions.ToString(1),
							")"
						});
						OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Data.conn_Account);
						oleDbCommand.ExecuteNonQuery();
						Data.MemberChangedPass(this._My_Id, text2, text3);
						this.CreatedCharacter();
						return;
					}
					catch (Exception expr_525)
					{
						ProjectData.SetProjectError(expr_525);
						this.shutdown();
						ProjectData.ClearProjectError();
						return;
					}
					//break;
				case 2:
					break;
				default:
					return;
				}
				string text4 = "";
				int arg_54B_0 = 6;
				int num10 = packet.Length - 1;
				for (int k = arg_54B_0; k <= num10; k++)
				{
					text4 += Conversions.ToString(Strings.Chr((int)packet[k]));
				}
				OleDbCommand oleDbCommand2 = new OleDbCommand("SELECT * FROM Player Where Name='" + text4 + "'", Data.conn_Account);
				OleDbDataReader oleDbDataReader = oleDbCommand2.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					this.CreatChar_NameUsed();
				}
				else
				{
					this.CreatedCharName();
					this.string_1 = text4;
				}
				oleDbDataReader.Close();
			}
		}
		public void Update_HB(byte[] packet)
		{
			switch (packet[5])
			{
			case 1:
			{
				byte b = packet[6];
				if (b == 3)
				{
					if (Server.TheBattles.ContainsKey(this._My_IdBattle))
					{
						try
						{
							Dictionary<int, int>.KeyCollection.Enumerator enumerator = Server.TheBattles[this._My_IdBattle].ListQS.Keys.GetEnumerator();
							while (enumerator.MoveNext())
							{
								int current = enumerator.Current;
								if (Server.TheBattles[this._My_IdBattle].ListQS[current] > 0 && Server.TheBattles[this._My_IdBattle].ListQS[current] == this._My_Id)
								{
									Server.TheBattles[this._My_IdBattle].ListQS[current] = 0;
									break;
								}
							}
						}
						finally
						{
							
						}
					}
					this._My_IdBattle = 0;
					this.Sendpacket("F44408000B00" + Class5.smethod_12(this._My_Id) + "0000");
					return;
				}
				return;
			}
			case 2:
				switch (packet[6])
				{
				case 2:
				{
					int num = Class5.smethod_10(new byte[]
					{
						packet[7],
						packet[8],
						packet[9],
						packet[10]
					});
					if (!Server.Clients.ContainsKey(num))
					{
						return;
					}
					int my_Pk = Server.Clients[num]._My_Pk;
					if (!(this._My_IdBattle == 0 & this._My_Pk == 1 & Server.Clients[num]._My_IdBattle == 0))
					{
						return;
					}
					if (my_Pk == 0)
					{
						this.Sendpacket("F4440300210101");
						return;
					}
					if (my_Pk == 1)
					{
						new TheBattle(this._My_Id, num, 112);
						return;
					}
					return;
				}
				case 3:
				{
					if (this._My_IdBattle != 0)
					{
						return;
					}
					int num2 = Class5.smethod_10(new byte[]
					{
						packet[7],
						packet[8],
						packet[9],
						packet[10]
					});
					if ((num2 >= 20000 & num2 < 22000) | (num2 >= 23000 & num2 < 25000) | (num2 >= 26000 & num2 < 27000))
					{
						return;
					}
					int idNpcOnMap = Class5.smethod_9(new byte[]
					{
						packet[11],
						packet[12]
					});
					new TheBattle(this._My_Id, num2, idNpcOnMap, 112);
					return;
				}
				case 4:
				{
					int key = Class5.smethod_10(new byte[]
					{
						packet[7],
						packet[8],
						packet[9],
						packet[10]
					});
					if (!Server.Clients.ContainsKey(key))
					{
						return;
					}
					int my_IdBattle = Server.Clients[key]._My_IdBattle;
					if (!(my_IdBattle > 0 & this._My_IdBattle == 0))
					{
						return;
					}
					try
					{
						Dictionary<int, int>.KeyCollection.Enumerator enumerator2 = Server.TheBattles[my_IdBattle].ListQS.Keys.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							int current2 = enumerator2.Current;
							if (Server.TheBattles[my_IdBattle].ListQS[current2] == 0)
							{
								Server.TheBattles[my_IdBattle].ListQS[current2] = this._My_Id;
								this._My_IdBattle = my_IdBattle;
								string text = string.Concat(new string[]
								{
									"0402",
									Class5.smethod_12(this._My_Id),
									"000000000000FFFF",
									Class5.smethod_11(this._My_HpMax),
									Class5.smethod_11(this._My_SpMax),
									Class5.smethod_11(this._My_Hp),
									Class5.smethod_11(this._My_Sp),
									this._My_Lv.ToString("X2"),
									this._My_Thuoctinh.ToString("X2")
								});
								try
								{
									IEnumerator enumerator3 = Server.TheBattles[this._My_IdBattle]._keys.GetEnumerator();
									while (enumerator3.MoveNext())
									{
										string key2 = Conversions.ToString(enumerator3.Current);
										DataStructure.WarInfo value = Server.TheBattles[this._My_IdBattle].ListWar[key2];
										int type = value._Type;
										int id = value._Id;
										if (id > 0)
										{
											int int_ = value._IdNpcOnMap;
											int idChar = value._IdChar;
											int row = value._Row;
											int column = value._Column;
											int hpMax = value._HpMax;
											int spMax = value._SpMax;
											int num3 = value._Hp;
											int num4 = value._Sp;
											int lv = value._Lv;
											int thuoctinh = value._Thuoctinh;
											if (num3 < 0)
											{
												num3 = 0;
											}
											if (num4 < 0)
											{
												num4 = 0;
											}
											int leaderId = value._LeaderId;
											int num5 = 100;
											if (id == leaderId | idChar == leaderId)
											{
												num5 = 3;
											}
											if (type != 3 & type != 7)
											{
												int_ = 0;
											}
											text = string.Concat(new string[]
											{
												text,
												num5.ToString("X2"),
												type.ToString("X2"),
												Class5.smethod_12(id),
												Class5.smethod_11(int_),
												Class5.smethod_12(idChar),
												row.ToString("X2"),
												column.ToString("X2"),
												Class5.smethod_11(hpMax),
												Class5.smethod_11(spMax),
												Class5.smethod_11(num3),
												Class5.smethod_11(num4),
												lv.ToString("X2"),
												thuoctinh.ToString("X2")
											});
										}
										Server.TheBattles[this._My_IdBattle].ListWar[key2] = value;
									}
								}
								finally
								{
                                    /*
									IEnumerator enumerator3;
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
									}
                                     * */
								}
								this.Sendpacket(string.Concat(new string[]
								{
									"F444",
									Class5.smethod_11(checked((int)Math.Round((double)text.Length / 2.0) + 4)),
									"0BFA",
									Class5.smethod_11(Server.Clients[key]._my_DiaHinh),
									text,
									"F44403000B0A01"
								}));
								break;
							}
						}
						return;
					}
					finally
					{
						
					}
					//break;
				}
				default:
					return;
				}
				//break;
			case 3:
			case 4:
			case 5:
				return;
			case 6:
				break;
			default:
				return;
			}
			Server.SendToAllClientMapid(this._My_Id, "F44406000B06" + Class5.smethod_12(this._My_Id));
		}
		public void Update_HC(byte[] packet)
		{
			byte b = packet[5];
			if (b == 1)
			{
				if (this._My_IdLeader > 0 & this._My_IdLeader != this._My_Id)
				{
					this.Sendpacket("F44402000504");
					this.Sendpacket("F44402001408");
				}
				else
				{
					this.warpfinish = true;
					this.Sendpacket("F44402000504");
					this.Sendpacket("F44402001408");
					this.talkcount = 0;
					this.idtalking = 0;
				}
			}
		}
		public void Update_HD(byte[] packet)
		{
			switch (packet[5])
			{
			case 1:
			{
				int num = Class5.smethod_10(new byte[]
				{
					packet[6],
					packet[7],
					packet[8],
					packet[9]
				});
				if (num == this._My_Id)
				{
					return;
				}
				if (Server.Clients.ContainsKey(num))
				{
					string packet2 = "F44406000D09" + Class5.smethod_12(this._My_Id);
					Server.Clients[num]._My_IdXinVaoNhom = this._My_Id;
					this._My_IdMoiVaoNhom = num;
					Server.SendToClient(num, packet2);
				}
				break;
			}
			case 3:
			{
				int num2 = (int)packet[6];
				int num3 = Class5.smethod_10(new byte[]
				{
					packet[7],
					packet[8],
					packet[9],
					packet[10]
				});
				if (num3 == this._My_Id)
				{
					return;
				}
				int my_IdMoiVaoNhom = this._My_IdMoiVaoNhom;
				if (num2 == 1 & num3 == my_IdMoiVaoNhom)
				{
					this.Walked(num3, this._My_MapX, this._My_MapY, this._My_Gocnhin);
					if (this._My_IdLeader > 0)
					{
						return;
					}
					if (Server.Clients.ContainsKey(num3))
					{
						Client client = Server.Clients[num3];
						if (client._My_IdMem1 == 0 | client._My_IdMem2 == 0 | client._My_IdMem3 == 0 | client._My_IdMem4 == 0)
						{
							if (client._My_IdMem1 == 0)
							{
								Server.Clients[num3]._My_IdMem1 = this._My_Id;
							}
							else
							{
								if (client._My_IdMem2 == 0)
								{
									Server.Clients[num3]._My_IdMem2 = this._My_Id;
								}
								else
								{
									if (client._My_IdMem3 == 0)
									{
										Server.Clients[num3]._My_IdMem3 = this._My_Id;
									}
									else
									{
										if (client._My_IdMem4 == 0)
										{
											Server.Clients[num3]._My_IdMem4 = this._My_Id;
										}
									}
								}
							}
							Server.SendToAllClientMapid(this._My_Id, "F4440A000D05" + Class5.smethod_12(num3) + Class5.smethod_12(this._My_Id));
							this.Sendpacket("F44407000D0301" + Class5.smethod_12(num3));
							this.Sendpacket("F4440A000D05" + Class5.smethod_12(num3) + Class5.smethod_12(this._My_Id));
							this.PartySendStatus(this._My_Id, num3);
							this.PartySendStatus(num3, this._My_Id);
							this._My_IdLeader = Server.Clients[num3]._My_IdLeader;
							this._My_IdMem1 = Server.Clients[num3]._My_IdMem1;
							this._My_IdMem2 = Server.Clients[num3]._My_IdMem2;
							this._My_IdMem3 = Server.Clients[num3]._My_IdMem3;
							this._My_IdMem4 = Server.Clients[num3]._My_IdMem4;
							if (this._My_IdMem1 > 0 & this._My_IdMem1 != this._My_Id)
							{
								Server.Clients[this._My_IdMem1]._My_IdLeader = this._My_IdLeader;
								Server.Clients[this._My_IdMem1]._My_IdMem1 = this._My_IdMem1;
								Server.Clients[this._My_IdMem1]._My_IdMem2 = this._My_IdMem2;
								Server.Clients[this._My_IdMem1]._My_IdMem3 = this._My_IdMem3;
								Server.Clients[this._My_IdMem1]._My_IdMem4 = this._My_IdMem4;
								this.PartySendStatus(this._My_IdMem1, this._My_Id);
								this.PartySendStatus(this._My_Id, this._My_IdMem1);
							}
							if (this._My_IdMem2 > 0 & this._My_IdMem2 != this._My_Id)
							{
								Server.Clients[this._My_IdMem2]._My_IdLeader = this._My_IdLeader;
								Server.Clients[this._My_IdMem2]._My_IdMem1 = this._My_IdMem1;
								Server.Clients[this._My_IdMem2]._My_IdMem2 = this._My_IdMem2;
								Server.Clients[this._My_IdMem2]._My_IdMem3 = this._My_IdMem3;
								Server.Clients[this._My_IdMem2]._My_IdMem4 = this._My_IdMem4;
								this.PartySendStatus(this._My_IdMem2, this._My_Id);
								this.PartySendStatus(this._My_Id, this._My_IdMem2);
							}
							if (this._My_IdMem3 > 0 & this._My_IdMem3 != this._My_Id)
							{
								Server.Clients[this._My_IdMem3]._My_IdLeader = this._My_IdLeader;
								Server.Clients[this._My_IdMem3]._My_IdMem1 = this._My_IdMem1;
								Server.Clients[this._My_IdMem3]._My_IdMem2 = this._My_IdMem2;
								Server.Clients[this._My_IdMem3]._My_IdMem3 = this._My_IdMem3;
								Server.Clients[this._My_IdMem3]._My_IdMem4 = this._My_IdMem4;
								this.PartySendStatus(this._My_IdMem3, this._My_Id);
								this.PartySendStatus(this._My_Id, this._My_IdMem3);
							}
							if (this._My_IdMem4 > 0 & this._My_IdMem4 != this._My_Id)
							{
								Server.Clients[this._My_IdMem4]._My_IdLeader = this._My_IdLeader;
								Server.Clients[this._My_IdMem4]._My_IdMem1 = this._My_IdMem1;
								Server.Clients[this._My_IdMem4]._My_IdMem2 = this._My_IdMem2;
								Server.Clients[this._My_IdMem4]._My_IdMem3 = this._My_IdMem3;
								Server.Clients[this._My_IdMem4]._My_IdMem4 = this._My_IdMem4;
								this.PartySendStatus(this._My_IdMem4, this._My_Id);
								this.PartySendStatus(this._My_Id, this._My_IdMem4);
							}
						}
					}
				}
				else
				{
					if (num2 == 0)
					{
					}
				}
				break;
			}
			case 4:
			{
				int idout = Class5.smethod_10(new byte[]
				{
					packet[6],
					packet[7],
					packet[8],
					packet[9]
				});
				this.GiaiTanParty(idout);
				break;
			}
			case 5:
			{
				int num4 = Class5.smethod_10(new byte[]
				{
					packet[6],
					packet[7],
					packet[8],
					packet[9]
				});
				if (this._My_Id == this._My_IdLeader)
				{
					if (this._My_IdMem1 == num4)
					{
						this._My_IdQS = this._My_IdMem1;
						this.Sendpacket("F44406000D08" + Class5.smethod_12(num4));
						this.Sendpacket("F44406000D07" + Class5.smethod_12(num4));
						this.Sendpacket("F44406000D0B" + Class5.smethod_12(num4));
						Server.SendToAllClientMapid(this._My_Id, "F44406000D07" + Class5.smethod_12(num4));
						Server.SendToAllClientMapid(this._My_Id, "F44406000D0B" + Class5.smethod_12(num4));
					}
					else
					{
						if (this._My_IdMem2 == num4)
						{
							this._My_IdQS = this._My_IdMem2;
							this.Sendpacket("F44406000D08" + Class5.smethod_12(num4));
							this.Sendpacket("F44406000D07" + Class5.smethod_12(num4));
							this.Sendpacket("F44406000D0B" + Class5.smethod_12(num4));
							Server.SendToAllClientMapid(this._My_Id, "F44406000D07" + Class5.smethod_12(num4));
							Server.SendToAllClientMapid(this._My_Id, "F44406000D0B" + Class5.smethod_12(num4));
						}
						else
						{
							if (this._My_IdMem3 == num4)
							{
								this._My_IdQS = this._My_IdMem3;
								this.Sendpacket("F44406000D08" + Class5.smethod_12(num4));
								this.Sendpacket("F44406000D07" + Class5.smethod_12(num4));
								this.Sendpacket("F44406000D0B" + Class5.smethod_12(num4));
								Server.SendToAllClientMapid(this._My_Id, "F44406000D07" + Class5.smethod_12(num4));
								Server.SendToAllClientMapid(this._My_Id, "F44406000D0B" + Class5.smethod_12(num4));
							}
							else
							{
								if (this._My_IdMem4 == num4)
								{
									this._My_IdQS = this._My_IdMem4;
									this.Sendpacket("F44406000D08" + Class5.smethod_12(num4));
									this.Sendpacket("F44406000D07" + Class5.smethod_12(num4));
									this.Sendpacket("F44406000D0B" + Class5.smethod_12(num4));
									Server.SendToAllClientMapid(this._My_Id, "F44406000D07" + Class5.smethod_12(num4));
									Server.SendToAllClientMapid(this._My_Id, "F44406000D0B" + Class5.smethod_12(num4));
								}
							}
						}
					}
				}
				break;
			}
			case 6:
				if (this._My_IdQS > 0)
				{
					this.Sendpacket("F44406000D08" + Class5.smethod_12(this._My_IdQS));
					this.Sendpacket("F44406000D0C" + Class5.smethod_12(this._My_IdQS));
					Server.SendToAllClientMapid(this._My_Id, "F44406000D08" + Class5.smethod_12(this._My_IdQS));
					Server.SendToAllClientMapid(this._My_Id, "F44406000D0C" + Class5.smethod_12(this._My_IdQS));
					this._My_IdQS = 0;
				}
				break;
			case 7:
			{
				int num5 = Class5.smethod_10(new byte[]
				{
					packet[6],
					packet[7],
					packet[8],
					packet[9]
				});
				if (num5 == this._My_Id)
				{
					return;
				}
				if (Server.Clients.ContainsKey(num5))
				{
					string packet3 = "F44406000D01" + Class5.smethod_12(this._My_Id);
					this._My_IdXinVaoNhom = num5;
					Server.Clients[num5]._My_IdMoiVaoNhom = this._My_Id;
					Server.SendToClient(num5, packet3);
				}
				break;
			}
			case 8:
			{
				int num6 = (int)packet[6];
				int num7 = Class5.smethod_10(new byte[]
				{
					packet[7],
					packet[8],
					packet[9],
					packet[10]
				});
				if (num7 == this._My_Id)
				{
					return;
				}
				int my_IdXinVaoNhom = this._My_IdXinVaoNhom;
				if (num6 == 1 & num7 == my_IdXinVaoNhom)
				{
					this.Walked(num7, this._My_MapX, this._My_MapY, this._My_Gocnhin);
					if (this._My_IdLeader > 0 & this._My_IdLeader != this._My_Id)
					{
						return;
					}
					if (this._My_IdMem1 == 0 | this._My_IdMem2 == 0 | this._My_IdMem3 == 0 | this._My_IdMem4 == 0)
					{
						if (Server.Clients.ContainsKey(num7))
						{
							if (this._My_IdLeader == 0)
							{
								this._My_IdLeader = this._My_Id;
								Server.Clients[num7]._My_IdLeader = this._My_Id;
							}
							if (this._My_IdMem1 == 0)
							{
								this._My_IdMem1 = num7;
								Server.Clients[num7]._My_IdMem1 = num7;
							}
							else
							{
								if (this._My_IdMem2 == 0)
								{
									this._My_IdMem2 = num7;
									Server.Clients[num7]._My_IdMem2 = num7;
								}
								else
								{
									if (this._My_IdMem3 == 0)
									{
										this._My_IdMem3 = num7;
										Server.Clients[num7]._My_IdMem3 = num7;
									}
									else
									{
										if (this._My_IdMem4 == 0)
										{
											this._My_IdMem4 = num7;
											Server.Clients[num7]._My_IdMem4 = num7;
										}
									}
								}
							}
							this.Sendpacket("F4440A000D05" + Class5.smethod_12(this._My_Id) + Class5.smethod_12(num7));
							this.PartySendStatus(this._My_Id, num7);
							Server.SendToClient(num7, "F44407000D0301" + Class5.smethod_12(this._My_Id));
							Server.SendToAllClientMapid(this._My_Id, "F4440A000D05" + Class5.smethod_12(this._My_Id) + Class5.smethod_12(num7));
							this.PartySendStatus(num7, this._My_Id);
						}
						if (this._My_IdMem1 > 0 & Server.Clients.ContainsKey(this._My_IdMem1))
						{
							Server.Clients[this._My_IdMem1]._My_IdLeader = this._My_IdLeader;
							Server.Clients[this._My_IdMem1]._My_IdMem1 = this._My_IdMem1;
							Server.Clients[this._My_IdMem1]._My_IdMem2 = this._My_IdMem2;
							Server.Clients[this._My_IdMem1]._My_IdMem3 = this._My_IdMem3;
							Server.Clients[this._My_IdMem1]._My_IdMem4 = this._My_IdMem4;
							this.PartySendStatus(this._My_IdMem1, num7);
							this.PartySendStatus(num7, this._My_IdMem1);
						}
						if (this._My_IdMem2 > 0 & Server.Clients.ContainsKey(this._My_IdMem2))
						{
							Server.Clients[this._My_IdMem2]._My_IdLeader = this._My_IdLeader;
							Server.Clients[this._My_IdMem2]._My_IdMem1 = this._My_IdMem1;
							Server.Clients[this._My_IdMem2]._My_IdMem2 = this._My_IdMem2;
							Server.Clients[this._My_IdMem2]._My_IdMem3 = this._My_IdMem3;
							Server.Clients[this._My_IdMem2]._My_IdMem4 = this._My_IdMem4;
							this.PartySendStatus(this._My_IdMem2, num7);
							this.PartySendStatus(num7, this._My_IdMem2);
						}
						if (this._My_IdMem3 > 0 & Server.Clients.ContainsKey(this._My_IdMem3))
						{
							Server.Clients[this._My_IdMem3]._My_IdLeader = this._My_IdLeader;
							Server.Clients[this._My_IdMem3]._My_IdMem1 = this._My_IdMem1;
							Server.Clients[this._My_IdMem3]._My_IdMem2 = this._My_IdMem2;
							Server.Clients[this._My_IdMem3]._My_IdMem3 = this._My_IdMem3;
							Server.Clients[this._My_IdMem3]._My_IdMem4 = this._My_IdMem4;
							this.PartySendStatus(this._My_IdMem3, num7);
							this.PartySendStatus(num7, this._My_IdMem3);
						}
						if (this._My_IdMem4 > 0 & Server.Clients.ContainsKey(this._My_IdMem4))
						{
							Server.Clients[this._My_IdMem4]._My_IdLeader = this._My_IdLeader;
							Server.Clients[this._My_IdMem4]._My_IdMem1 = this._My_IdMem1;
							Server.Clients[this._My_IdMem4]._My_IdMem2 = this._My_IdMem2;
							Server.Clients[this._My_IdMem4]._My_IdMem3 = this._My_IdMem3;
							Server.Clients[this._My_IdMem4]._My_IdMem4 = this._My_IdMem4;
							this.PartySendStatus(this._My_IdMem4, num7);
							this.PartySendStatus(num7, this._My_IdMem4);
						}
					}
				}
				else
				{
					if (num6 == 0)
					{
					}
				}
				break;
			}
			}
		}
		public void Update_HF(byte[] packet)
		{
			checked
			{
				switch (packet[5])
				{
				case 2:
				{
					int num = (int)packet[6];
					if (num == this._My_SttPetXuatChien)
					{
						Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._SttPetXuatChien, 0);
					}
					Data.Removepet(this._My_Id, num);
					break;
				}
				case 4:
				{
					int num2 = Class5.smethod_10(new byte[]
					{
						packet[6],
						packet[7],
						packet[8],
						packet[9]
					});
					int my_SttPetXuatChien = this._My_SttPetXuatChien;
					int num3 = Data.PetGetData(this.conn, my_SttPetXuatChien, DataStructure.Type_Pet._ID);
					if ((num3 != num2 & num2 > 18000 & num2 < 19000) && Data.PetExitsMangtheo(this.conn, num2))
					{
						this._My_Horse = num2;
						this.Sendpacket("F4440E000F05" + Class5.smethod_12(this._My_Id) + Class5.smethod_12(num2) + "00000000");
						Server.SendToAllClient(this._My_Id, "F4440E000F05" + Class5.smethod_12(this._My_Id) + Class5.smethod_12(num2) + "00000000");
					}
					break;
				}
				case 5:
					if (this._My_Horse > 0)
					{
						this._My_Horse = 0;
						this.Sendpacket("F44406000F06" + Class5.smethod_12(this._My_Id));
						Server.SendToAllClient(this._My_Id, "F44406000F06" + Class5.smethod_12(this._My_Id));
					}
					break;
				case 6:
				{
					int stt = (int)packet[6];
					string text = "";
					for (int i = packet.Length - 1; i >= 7; i += -1)
					{
						text = Conversions.ToString(Strings.ChrW((int)packet[i])) + text;
					}
					if (text.Length > 0)
					{
						Data.ChangeNamePet(this._My_Id, stt, text);
					}
					break;
				}
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void Update_H13(byte[] packet)
		{
			checked
			{
				if (this._My_IdBattle == 0)
				{
					switch (packet[5])
					{
					case 1:
					{
						int num = Class5.smethod_10(new byte[]
						{
							packet[6],
							packet[7],
							packet[8],
							packet[9]
						});
						if (this._My_Horse != num)
						{
							int num2 = Data.PetGetStt(this.conn, num);
							if (num2 <= 4)
							{
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._SttPetXuatChien, num2);
								this.Sendpacket("F44406001301" + Class5.smethod_12(num));
							}
						}
						break;
					}
					case 2:
					{
						int my_SttPetXuatChien = this._My_SttPetXuatChien;
						int num3 = Data.PetGetData(this.conn, my_SttPetXuatChien, DataStructure.Type_Pet._ID);
						if (num3 > 0)
						{
							Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._SttPetXuatChien, 0);
							this.Sendpacket("F44402001302");
						}
						break;
					}
					}
				}
				else
				{
					TheBattle theBattle = Server.TheBattles[this._My_IdBattle];
					try
					{
						IEnumerator enumerator = Server.TheBattles[this._My_IdBattle]._keys.GetEnumerator();
						while (enumerator.MoveNext())
						{
							string key = Conversions.ToString(enumerator.Current);
							DataStructure.WarInfo value = Server.TheBattles[this._My_IdBattle].ListWar[key];
							int row = value._Row;
							int column = value._Column;
							int team = value._Team;
							int leaderId = value._LeaderId;
							if (value._Attacked == 0 & value._Id == this._My_Id)
							{
								switch (packet[5])
								{
								case 1:
								{
									int num4 = Class5.smethod_10(new byte[]
									{
										packet[6],
										packet[7],
										packet[8],
										packet[9]
									});
									int num5 = Data.PetGetStt(this.conn, num4);
									if (num5 <= 4)
									{
										string str = Class1.Form0_0.Info.DirectoryPath + "\\member\\vn" + this._My_Id.ToString() + ".accdb";
										OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + str + ";Persist Security Info=False;");
										OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Pet Where Stt = " + Conversions.ToString(num5), oleDbConnection);
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
											theBattle.SendSKillingToParty("F44404003505" + row.ToString("X2") + column.ToString("X2"));
											theBattle.SendSKillingToParty("F44404000B01" + (row ^ 1).ToString("X2") + column.ToString("X2"));
											theBattle.ChangedWar(Class5.smethod_3(new byte[]
											{
												(byte)(row ^ 1),
												(byte)column
											}), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
											theBattle.ChangedWar(Class5.smethod_3(new byte[]
											{
												(byte)(row ^ 1),
												(byte)column
											}), 4, id, num5, this._My_Id, hpMax, spMax, hp, sp, lv, thuoctinh, leaderId, 0, 0, 0, team, @int, atk, def, agi, reborn, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
											string packet2 = theBattle.ListWar[Class5.smethod_3(new byte[]
											{
												(byte)(row ^ 1),
												(byte)column
											})]._Packet;
											value._Attacked = 1;
											theBattle.SendSKillingToParty("F4441A000B0505" + packet2);
											Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._SttPetXuatChien, num5);
											this.Sendpacket("F44406001301" + Class5.smethod_12(num4));
										}
										oleDbDataReader.Close();
									}
									break;
								}
								case 2:
								{
									int my_SttPetXuatChien2 = this._My_SttPetXuatChien;
									int num6 = Data.PetGetData(this.conn, my_SttPetXuatChien2, DataStructure.Type_Pet._ID);
									if (num6 > 0)
									{
										theBattle.SendSKillingToParty("F44404003505" + value._Row.ToString("X2") + column.ToString("X2"));
										theBattle.SendSKillingToParty("F44404000B01" + (row ^ 1).ToString("X2") + column.ToString("X2"));
										theBattle.ChangedWar(Class5.smethod_3(new byte[]
										{
											(byte)(row ^ 1),
											(byte)column
										}), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
										value._Attacked = 1;
										Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._SttPetXuatChien, 0);
										this.Sendpacket("F44402001302");
									}
									break;
								}
								}
								Server.TheBattles[this._My_IdBattle].ListWar[key] = value;
								break;
							}
						}
					}
					finally
					{

					}
				}
			}
		}
		public void Update_H14(byte[] packet)
		{
			switch (packet[5])
			{
			case 1:
				FTalk.H1(this, packet);
				return;
			case 4:
				FTalk.H4(this, packet);
				return;
			case 6:
				FTalk.H6(this, packet);
				return;
			case 8:
				FTalk.H8(this, packet);
				return;
			case 9:
				FTalk.H9(this, packet);
				return;
			}
			this.EndTalk();
		}
		public void Update_H17(byte[] packet)
		{
			checked
			{
				switch (packet[5])
				{
				case 2:
				{
					if (this._My_IdBattle > 0)
					{
						return;
					}
					int slot = (int)packet[6];
					DataStructure.Key_ItemDropOnMap key_ItemDropOnMap = Data.GetKey_ItemDropOnMap(this._My_MapId, slot);
					DataStructure._ItemDropOnMap itemDropOnMap = Data.ItemDropOnMap[key_ItemDropOnMap];
					int id = itemDropOnMap._Id;
					if (id > 0)
					{
						int num = this._My_MapX - itemDropOnMap._MapX;
						int num2 = this._My_MapY - itemDropOnMap._MapY;
						int delay = itemDropOnMap._Delay;
						if (-150 <= num & num <= 150 & -150 <= num2 & num2 <= 150)
						{
							Data.PickupItemOnMap(this._My_Id, slot);
						}
						if (delay == 999999)
						{
							DataStructure.Key_ItemOnMap key_ItemOnMap = Data.GetKey_ItemOnMap(this._My_MapId, id, itemDropOnMap._MapX, itemDropOnMap._MapY);
							DataStructure._ItemOnMap value = Data.ItemOnMap[key_ItemOnMap];
							value._DelayDec = value._Delay * 333;
							Data.ItemOnMap[key_ItemOnMap] = value;
						}
					}
					break;
				}
				case 3:
				{
					if (this._My_IdBattle > 0)
					{
						return;
					}
					int num3 = (int)packet[6];
					int count = (int)packet[7];
					int iD = Data.HomdoGetDataItem(this.conn, num3)._ID;
					if (iD > 0)
					{
						int delay2 = 333;
						DataStructure.Key_ItemDropOnMap key_ItemDropOnMap2 = default(DataStructure.Key_ItemDropOnMap);
						key_ItemDropOnMap2._MapId = this._My_MapId;
						key_ItemDropOnMap2._Slot = 1;
						if (!Data.ItemDropOnMap.ContainsKey(key_ItemDropOnMap2))
						{
							int num4 = 1;
							do
							{
								DataStructure._ItemDropOnMap value2 = default(DataStructure._ItemDropOnMap);
								value2._MapId = this._My_MapId;
								value2._Slot = num4;
								key_ItemDropOnMap2._Slot = num4;
								Data._ListKeysItemDropOnMap.Add(key_ItemDropOnMap2);
								Data.ItemDropOnMap.Add(key_ItemDropOnMap2, value2);
								num4++;
							}
							while (num4 <= 255);
							Data.HomdoDropItem(this._My_Id, num3, count, delay2);
						}
						else
						{
							Data.HomdoDropItem(this._My_Id, num3, count, delay2);
						}
					}
					break;
				}
				case 10:
				{
					int num5 = (int)packet[6];
					int num6 = (int)packet[7];
					int num7 = (int)packet[8];
					Data.HomdoMoveItem(this._My_Id, Conversions.ToInteger(num5.ToString()), Conversions.ToInteger(num6.ToString()), Conversions.ToInteger(num7.ToString()), packet);
					break;
				}
				case 11:
				{
					if (this._My_IdBattle > 0)
					{
						return;
					}
					int num8 = (int)packet[6];
					DataStructure.HomdoInfo homdoInfo = Data.HomdoGetDataItem(this.conn, num8);
					int loai = homdoInfo._Loai;
					int iD2 = homdoInfo._ID;
					int lv = homdoInfo._Lv;
					int loai2 = homdoInfo._Loai;
					if (iD2 > 0 & loai2 >= 1 & loai2 <= 6 & this._My_Lv >= lv)
					{
						this.Sendpacket("F44403001711" + packet[6].ToString("X2"));
						Data.HomdoUseItemTB(this._My_Id, num8, loai);
						this.UpdateStatusWhenUseItem();
						Server.ServerSend_EquitItem(this._My_Id, iD2);
					}
					break;
				}
				case 12:
				{
					if (this._My_IdBattle > 0)
					{
						return;
					}
					int num9 = (int)packet[6];
					int num10 = (int)packet[7];
					Data.TrangbiGetDataItem(this.conn, num9, DataStructure.Type_Homdo._Loai);
					int iD3 = Data.HomdoGetDataItem(this.conn, num10)._ID;
					if (iD3 == 0)
					{
						this.Sendpacket("F44404001710" + packet[6].ToString("X2") + packet[7].ToString("X2"));
						Server.ServerSend_UnEquitItem(this._My_Id, Data.TrangbiGetDataItem(this.conn, num9, DataStructure.Type_Homdo._ID));
						Data.TrangbiRemoveItem(this._My_Id, num9, num10);
						this.UpdateStatusWhenUseItem();
					}
					break;
				}
				case 14:
				{
					int num11 = (int)packet[6];
					int num12 = (int)packet[7];
					DataStructure.HomdoInfo homdoInfo2 = Data.HomdoGetDataItem(this.conn, num11);
					int iD4 = homdoInfo2._ID;
					int loai3 = homdoInfo2._Loai;
					int num13 = homdoInfo2._Thuoctinh;
					int giatriThuoctinh = homdoInfo2._GiatriThuoctinh;
					int @long = homdoInfo2._Long;
					int num14 = (int)packet[8];
					int num15 = (int)packet[9];
					DataStructure.HomdoInfo homdoInfo3 = Data.HomdoGetDataItem(this.conn, num14);
					int iD5 = homdoInfo3._ID;
					int loai4 = homdoInfo3._Loai;
					int num16 = homdoInfo3._Thuoctinh;
					int giatriThuoctinh2 = homdoInfo3._GiatriThuoctinh;
					int long2 = homdoInfo3._Long;
					int slot2 = (int)packet[10];
					int iD6 = Data.HomdoGetDataItem(this.conn, slot2)._ID;
					if (iD4 > 0 & iD5 > 0)
					{
						int num17 = iD6;
						if (num17 == 0)
						{
							if (loai3 == 0 & num13 > 0)
							{
								if (loai4 > 0 & (long2 == 0 | num13 == 6))
								{
									if (num13 == 6)
									{
										num13 = this._My_Thuoctinh;
									}
									this.Sendpacket("F44404001709" + num11.ToString("X2") + num12.ToString("X2"));
									this.Sendpacket("F44404001709" + num14.ToString("X2") + num15.ToString("X2"));
									Thread.Sleep(100);
									Data.HomdoUpdateItem(this.conn, num14, DataStructure.Type_Homdo._Long, num13);
									Data.HomdoUpdateItem(this.conn, num14, DataStructure.Type_Homdo._GiatriLong, giatriThuoctinh);
									Data.HomdoRemoveItemSlot(this._My_Id, num11);
									Data.MoveItem(this.conn, DataStructure.Type_Thung._Homdo, num14, DataStructure.Type_Thung._Homdo, num11);
									DataStructure.HomdoInfo homdoInfo4 = Data.HomdoGetDataItem(this.conn, num11);
									int doben = homdoInfo4._Doben;
									int long3 = homdoInfo4._Long;
									int giatriLong = homdoInfo4._GiatriLong;
									int khang = homdoInfo4._Khang;
									int tExp = homdoInfo4._TExp;
									this.Sendpacket(string.Concat(new string[]
									{
										"F4440E001708",
										num11.ToString("X2"),
										Class5.smethod_11(iD5),
										num15.ToString("X2"),
										doben.ToString("X2"),
										long3.ToString("X2"),
										(giatriLong + 100).ToString("X2"),
										khang.ToString("X2"),
										Class5.smethod_12(tExp)
									}));
									this.Sendpacket("F4440600170D" + Class5.smethod_11(iD5) + num15.ToString("X2") + num11.ToString("X2"));
								}
							}
							else
							{
								if ((loai3 > 0 & (@long == 0 | num16 == 6)) && (loai4 == 0 & num16 > 0))
								{
									if (num16 == 6)
									{
										num16 = this._My_Thuoctinh;
									}
									this.Sendpacket("F44404001709" + num11.ToString("X2") + num12.ToString("X2"));
									this.Sendpacket("F44404001709" + num14.ToString("X2") + num15.ToString("X2"));
									Thread.Sleep(100);
									Data.HomdoUpdateItem(this.conn, num11, DataStructure.Type_Homdo._Long, num16);
									Data.HomdoUpdateItem(this.conn, num11, DataStructure.Type_Homdo._GiatriLong, giatriThuoctinh2);
									Data.HomdoRemoveItemSlot(this._My_Id, num14);
									DataStructure.HomdoInfo homdoInfo5 = Data.HomdoGetDataItem(this.conn, num11);
									int doben2 = homdoInfo5._Doben;
									int long4 = homdoInfo5._Long;
									int giatriLong2 = homdoInfo5._GiatriLong;
									int khang2 = homdoInfo5._Khang;
									int tExp2 = homdoInfo5._TExp;
									this.Sendpacket(string.Concat(new string[]
									{
										"F4440E001708",
										num11.ToString("X2"),
										Class5.smethod_11(iD4),
										num12.ToString("X2"),
										doben2.ToString("X2"),
										long4.ToString("X2"),
										(giatriLong2 + 100).ToString("X2"),
										khang2.ToString("X2"),
										Class5.smethod_12(tExp2)
									}));
									this.Sendpacket("F4440600170D" + Class5.smethod_11(iD4) + num12.ToString("X2") + num11.ToString("X2"));
								}
							}
						}
					}
					break;
				}
				case 15:
				{
					int slot3 = (int)packet[6];
					int num18 = (int)packet[7];
					int stt = (int)packet[8];
					DataStructure.HomdoInfo homdoInfo6 = Data.HomdoGetDataItem(this.conn, slot3);
					int iD7 = homdoInfo6._ID;
					if (iD7 > 0 & num18 > 0)
					{
						int num19 = iD7;
						if (num19 == 46027)
						{
							int num20 = homdoInfo6._Count - num18;
							if (num20 > 0)
							{
								Data.HomdoUpdateItem(this.conn, slot3, DataStructure.Type_Homdo._Count, num20);
							}
							else
							{
								DataStructure.HomdoInfo homdo = default(DataStructure.HomdoInfo);
								Data.HomdoUpdateSlot(this.conn, slot3, homdo);
							}
							int my_MapId = this._My_MapId;
							Data.Warped(this._My_Id, my_MapId, 12003, 530, 510, 4);
						}
						else
						{
							if (num19 != 46091 && num19 != 46013 && num19 != 46014 && num19 != 46015)
							{
								if (num19 != 46042)
								{
									if (num19 == 46092)
									{
										int num21 = homdoInfo6._Count - num18;
										if (num21 > 0)
										{
											Data.HomdoUpdateItem(this.conn, slot3, DataStructure.Type_Homdo._Count, num21);
										}
										else
										{
											DataStructure.HomdoInfo homdo2 = default(DataStructure.HomdoInfo);
											Data.HomdoUpdateSlot(this.conn, slot3, homdo2);
										}
										string text = "F44404000B0702FF";
										text = text + "F44404001709" + slot3.ToString("X2") + num18.ToString("X2");
										text += "F4440200170F";
										this.Sendpacket(text);
										break;
									}
									if (num19 != 46093)
									{
										if (num19 != 46041)
										{
											if (this._My_IdBattle != 0)
											{
												break;
											}
											int num22 = homdoInfo6._Hp * num18;
											int num23 = homdoInfo6._Sp * num18;
											int num24 = homdoInfo6._Fai1 * num18;
											switch (stt)
											{
											case 0:
												if (num22 > 0)
												{
													if (this._My_Hp == this._My_HpMax)
													{
														Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Hp, this._My_Hp);
													}
													else
													{
														if (this._My_Hp < this._My_HpMax)
														{
															int num25 = this._My_Hp + num22;
															if (num25 >= this._My_HpMax)
															{
																Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Hp, this._My_HpMax);
															}
															else
															{
																Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Hp, num25);
															}
														}
													}
												}
												if (num23 > 0)
												{
													if (this._My_Sp == this._My_SpMax)
													{
														Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Sp, this._My_Sp);
													}
													else
													{
														if (this._My_Sp < this._My_SpMax)
														{
															int num26 = this._My_Sp + num23;
															if (num26 >= this._My_SpMax)
															{
																Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Sp, this._My_SpMax);
															}
															else
															{
																Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Sp, num26);
															}
														}
													}
												}
												if (num22 > 0 | num23 > 0)
												{
													Data.HomdoUseHPSPFAI(this._My_Id, slot3, num18);
													return;
												}
												return;
											case 1:
											case 2:
											case 3:
											case 4:
												if (Data.PetGetData(this.conn, stt, DataStructure.Type_Pet._ID) <= 0)
												{
													return;
												}
												if (num22 > 0)
												{
													int num27 = Data.PetGetData(this.conn, stt, DataStructure.Type_Pet._Hp);
													int num28 = Data.PetGetData(this.conn, stt, DataStructure.Type_Pet._Hpmax);
													if (num27 == num28)
													{
														Data.PetUpdateData(this._My_Id, stt, DataStructure.Type_Pet._Hp, num28);
													}
													else
													{
														if (num27 < num28)
														{
															int num29 = num27 + num22;
															if (num29 >= num28)
															{
																Data.PetUpdateData(this._My_Id, stt, DataStructure.Type_Pet._Hp, num28);
															}
															else
															{
																Data.PetUpdateData(this._My_Id, stt, DataStructure.Type_Pet._Hp, num29);
															}
														}
													}
												}
												if (num23 > 0)
												{
													int num30 = Data.PetGetData(this.conn, stt, DataStructure.Type_Pet._Sp);
													int num31 = Data.PetGetData(this.conn, stt, DataStructure.Type_Pet._Spmax);
													if (num30 == num31)
													{
														Data.PetUpdateData(this._My_Id, stt, DataStructure.Type_Pet._Sp, num31);
													}
													else
													{
														if (num30 < num31)
														{
															int num32 = num30 + num23;
															if (num32 >= num31)
															{
																Data.PetUpdateData(this._My_Id, stt, DataStructure.Type_Pet._Sp, num31);
															}
															else
															{
																Data.PetUpdateData(this._My_Id, stt, DataStructure.Type_Pet._Sp, num32);
															}
														}
													}
												}
												if (num24 > 0)
												{
													int num33 = Data.PetGetData(this.conn, stt, DataStructure.Type_Pet._Fai);
													int num34 = 100;
													if (num33 == 100)
													{
														Data.PetUpdateData(this._My_Id, stt, DataStructure.Type_Pet._Fai, num34);
													}
													else
													{
														if (num33 < num34)
														{
															int num35 = num33 + num24;
															if (num35 >= num34)
															{
																Data.PetUpdateData(this._My_Id, stt, DataStructure.Type_Pet._Fai, num34);
															}
															else
															{
																Data.PetUpdateData(this._My_Id, stt, DataStructure.Type_Pet._Fai, num35);
															}
														}
													}
												}
												if (num22 > 0 | num23 > 0 | num24 > 0)
												{
													Data.HomdoUseHPSPFAI(this._My_Id, slot3, num18);
													return;
												}
												return;
											default:
												return;
											}
										}
									}
									int num36 = homdoInfo6._Count - num18;
									if (num36 > 0)
									{
										Data.HomdoUpdateItem(this.conn, slot3, DataStructure.Type_Homdo._Count, num36);
									}
									else
									{
										DataStructure.HomdoInfo homdo3 = default(DataStructure.HomdoInfo);
										Data.HomdoUpdateSlot(this.conn, slot3, homdo3);
									}
									string text2 = "F44404000B09FF01";
									text2 = text2 + "F44404001709" + slot3.ToString("X2") + num18.ToString("X2");
									text2 += "F4440200170F";
									this.Sendpacket(text2);
									break;
								}
							}
							int num37 = homdoInfo6._Count - num18;
							if (num37 > 0)
							{
								Data.HomdoUpdateItem(this.conn, slot3, DataStructure.Type_Homdo._Count, num37);
							}
							else
							{
								DataStructure.HomdoInfo homdo4 = default(DataStructure.HomdoInfo);
								Data.HomdoUpdateSlot(this.conn, slot3, homdo4);
							}
							string text3 = "F44404000B0701FF";
							text3 = text3 + "F44404001709" + slot3.ToString("X2") + num18.ToString("X2");
							text3 += "F4440200170F";
							this.Sendpacket(text3);
						}
					}
					break;
				}
				case 17:
				{
					int num38 = (int)packet[6];
					if (this._My_IdBattle > 0 & this._My_SttPetXuatChien == num38)
					{
						return;
					}
					int num39 = (int)packet[7];
					DataStructure.HomdoInfo homdoInfo7 = Data.HomdoGetDataItem(this.conn, num39);
					int tbslot = homdoInfo7._Loai + num38 * 10;
					int iD8 = homdoInfo7._ID;
					int lv2 = homdoInfo7._Lv;
					int loai5 = homdoInfo7._Loai;
					if (iD8 > 0 & loai5 >= 1 & loai5 <= 6 & Data.PetGetData(this.conn, num38, DataStructure.Type_Pet._Lv) >= lv2)
					{
						this.Sendpacket("F44404001717" + packet[6].ToString("X2") + packet[7].ToString("X2"));
						Data.HomdoUseItemTB_Pet(this._My_Id, num38, num39, tbslot);
						Data.UpdateStatusPetWhenUseItem(this._My_Id, num38);
					}
					break;
				}
				case 18:
				{
					int num40 = (int)packet[6];
					if (this._My_IdBattle > 0 & this._My_SttPetXuatChien == num40)
					{
						return;
					}
					int num41 = (int)packet[7] + num40 * 10;
					int num42 = (int)packet[8];
					Data.TrangbiGetDataItem(this.conn, num41, DataStructure.Type_Homdo._Loai);
					int iD9 = Data.HomdoGetDataItem(this.conn, num42)._ID;
					if (iD9 == 0)
					{
						this.Sendpacket("F44405001716" + num40.ToString("X2") + packet[7].ToString("X2") + packet[8].ToString("X2"));
						Data.TrangbiRemoveItem_Pet(this._My_Id, num40, num41, num42);
						Data.UpdateStatusPetWhenUseItem(this._My_Id, num40);
					}
					break;
				}
				case 36:
				{
					if (!Data.PetExitsMangtheo(this.conn, 22029))
					{
						return;
					}
					ArrayList arrayList = new ArrayList();
					int arg_1078_0 = 0;
					int num43 = (int)(packet[2] - 3);
					for (int i = arg_1078_0; i <= num43; i++)
					{
						arrayList.Add((int)packet[i + 6]);
					}
					string text4 = "";
					string text5 = "";
					try
					{
						IEnumerator enumerator = arrayList.GetEnumerator();
						while (enumerator.MoveNext())
						{
							int num44 = Conversions.ToInteger(enumerator.Current);
							if (Data.HomdoGetDataItem(this.conn, num44)._ID > 0)
							{
								int num45 = Data.TuideoGetSlotNothing(this.conn);
								if (num45 > 0)
								{
									Data.MoveItem(this.conn, DataStructure.Type_Thung._Homdo, num44, DataStructure.Type_Thung._Tuideo, num45);
									DataStructure.HomdoInfo homdoInfo8 = Data.TuideoGetDataItem(this.conn, num45);
									int iD10 = homdoInfo8._ID;
									int count2 = homdoInfo8._Count;
									int doben3 = homdoInfo8._Doben;
									int long5 = homdoInfo8._Long;
									int giatriLong3 = homdoInfo8._GiatriLong;
									int khang3 = homdoInfo8._Khang;
									int tExp3 = homdoInfo8._TExp;
									text5 = string.Concat(new string[]
									{
										text5,
										num45.ToString("X2"),
										Class5.smethod_11(iD10),
										count2.ToString("X2"),
										doben3.ToString("X2"),
										long5.ToString("X2"),
										(giatriLong3 + 100).ToString("X2"),
										khang3.ToString("X2"),
										Class5.smethod_12(tExp3)
									});
									text4 = text4 + "F44404001709" + num44.ToString("X2") + "32";
								}
							}
						}
					}
					finally
					{

					}
					if (text4.Length > 0)
					{
						this.Sendpacket(text4);
					}
					if (text5.Length > 0)
					{
						this.Sendpacket("F444" + Class5.smethod_11(2 + (int)Math.Round((double)text5.Length / 2.0)) + "172F" + text5);
					}
					break;
				}
				case 37:
				{
					if (!Data.PetExitsMangtheo(this.conn, 22029))
					{
						return;
					}
					ArrayList arrayList2 = new ArrayList();
					int arg_12B1_0 = 0;
					int num46 = (int)(packet[2] - 3);
					for (int j = arg_12B1_0; j <= num46; j++)
					{
						arrayList2.Add((int)packet[j + 6]);
					}
					string text6 = "";
					string text7 = "";
					try
					{
						IEnumerator enumerator2 = arrayList2.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							int slot4 = Conversions.ToInteger(enumerator2.Current);
							if (Data.TuideoGetDataItem(this.conn, Conversions.ToInteger(slot4.ToString()))._ID > 0)
							{
								int num47 = Data.HomdoGetSlotNothing(this.conn);
								if (num47 > 0)
								{
									Data.MoveItem(this.conn, DataStructure.Type_Thung._Tuideo, slot4, DataStructure.Type_Thung._Homdo, num47);
									DataStructure.HomdoInfo homdoInfo9 = Data.HomdoGetDataItem(this.conn, num47);
									int iD11 = homdoInfo9._ID;
									int count3 = homdoInfo9._Count;
									if (iD11 > 0)
									{
										int doben4 = homdoInfo9._Doben;
										int long6 = homdoInfo9._Long;
										int giatriLong4 = homdoInfo9._GiatriLong;
										int khang4 = homdoInfo9._Khang;
										int tExp4 = homdoInfo9._TExp;
										text7 = string.Concat(new string[]
										{
											text7,
											num47.ToString("X2"),
											Class5.smethod_11(iD11),
											count3.ToString("X2"),
											doben4.ToString("X2"),
											long6.ToString("X2"),
											(giatriLong4 + 100).ToString("X2"),
											khang4.ToString("X2"),
											Class5.smethod_12(tExp4)
										});
										if (text7.Length > 0)
										{
											this.Sendpacket("F4440E001708" + text7);
										}
									}
									text6 = text6 + "F44404001731" + slot4.ToString("X2") + "32";
								}
							}
						}
					}
					finally
					{

					}
					if (text6.Length > 0)
					{
						this.Sendpacket(text6 + "F44402001732");
					}
					break;
				}
				case 51:
				{
					if (!Data.PetExitsMangtheo(this.conn, 41187))
					{
						return;
					}
					ArrayList arrayList3 = new ArrayList();
					int arg_14E2_0 = 0;
					int num48 = (int)(packet[2] - 3);
					for (int k = arg_14E2_0; k <= num48; k++)
					{
						arrayList3.Add((int)packet[k + 6]);
					}
					string text8 = "";
					string text9 = "";
					try
					{
						IEnumerator enumerator3 = arrayList3.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							int num49 = Conversions.ToInteger(enumerator3.Current);
							if (Data.HomdoGetDataItem(this.conn, num49)._ID > 0)
							{
								int num50 = Data.LuulangGetSlotNothing(this.conn);
								if (num50 > 0)
								{
									Data.MoveItem(this.conn, DataStructure.Type_Thung._Homdo, num49, DataStructure.Type_Thung._Luulang, num50);
									DataStructure.HomdoInfo homdoInfo10 = Data.LuulangGetDataItem(this.conn, num50);
									int iD12 = homdoInfo10._ID;
									int count4 = homdoInfo10._Count;
									int doben5 = homdoInfo10._Doben;
									int long7 = homdoInfo10._Long;
									int giatriLong5 = homdoInfo10._GiatriLong;
									int khang5 = homdoInfo10._Khang;
									int tExp5 = homdoInfo10._TExp;
									text9 = string.Concat(new string[]
									{
										text9,
										num50.ToString("X2"),
										Class5.smethod_11(iD12),
										count4.ToString("X2"),
										doben5.ToString("X2"),
										long7.ToString("X2"),
										(giatriLong5 + 100).ToString("X2"),
										khang5.ToString("X2"),
										Class5.smethod_12(tExp5)
									});
									text8 = text8 + "F44404001709" + num49.ToString("X2") + "32";
								}
							}
						}
					}
					finally
					{

					}
					if (text8.Length > 0)
					{
						this.Sendpacket(text8);
					}
					if (text9.Length > 0)
					{
						this.Sendpacket("F444" + Class5.smethod_11(2 + (int)Math.Round((double)text9.Length / 2.0)) + "1766" + text9);
					}
					break;
				}
				case 52:
				{
					if (!Data.PetExitsMangtheo(this.conn, 41187))
					{
						return;
					}
					ArrayList arrayList4 = new ArrayList();
					int arg_171B_0 = 0;
					int num51 = (int)(packet[2] - 3);
					for (int l = arg_171B_0; l <= num51; l++)
					{
						arrayList4.Add((int)packet[l + 6]);
					}
					string text10 = "";
					string text11 = "";
					try
					{
						IEnumerator enumerator4 = arrayList4.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							int slot5 = Conversions.ToInteger(enumerator4.Current);
							if (Data.LuulangGetDataItem(this.conn, Conversions.ToInteger(slot5.ToString()))._ID > 0)
							{
								int num52 = Data.HomdoGetSlotNothing(this.conn);
								if (num52 > 0)
								{
									Data.MoveItem(this.conn, DataStructure.Type_Thung._Luulang, slot5, DataStructure.Type_Thung._Homdo, num52);
									DataStructure.HomdoInfo homdoInfo11 = Data.HomdoGetDataItem(this.conn, num52);
									int iD13 = homdoInfo11._ID;
									int count5 = homdoInfo11._Count;
									if (iD13 > 0)
									{
										int doben6 = homdoInfo11._Doben;
										int long8 = homdoInfo11._Long;
										int giatriLong6 = homdoInfo11._GiatriLong;
										int khang6 = homdoInfo11._Khang;
										int tExp6 = homdoInfo11._TExp;
										text11 = string.Concat(new string[]
										{
											text11,
											num52.ToString("X2"),
											Class5.smethod_11(iD13),
											count5.ToString("X2"),
											doben6.ToString("X2"),
											long8.ToString("X2"),
											(giatriLong6 + 100).ToString("X2"),
											khang6.ToString("X2"),
											Class5.smethod_12(tExp6)
										});
										if (text11.Length > 0)
										{
											this.Sendpacket("F4440E001708" + text11);
										}
									}
									text10 = text10 + "F44404001768" + slot5.ToString("X2") + "32";
								}
							}
						}
					}
					finally
					{

					}
					if (text10.Length > 0)
					{
						this.Sendpacket(text10 + "F44402001732");
					}
					break;
				}
				}
			}
		}
		public void Update_H1E(byte[] packet)
		{
			byte b = packet[5];
			if (b == 8)
			{
				this.SelectMenu = 40;
			}
		}
		public void Update_H1C(byte[] packet)
		{
			checked
			{
				switch (packet[5])
				{
				case 1:
				{
					string text = "";
					int count = 0;
					int arg_26_0 = 6;
					int num = packet.Length - 1;
					for (int i = arg_26_0; i <= num; i += 3)
					{
						int num2 = Class5.smethod_9(new byte[]
						{
							packet[i],
							packet[i + 1]
						});
						int num3 = (int)packet[i + 2];
						if (Data.GetDataSkill(num2, DataStructure.Type_Skill._LvMax) >= num3 & Data.GetDataSkill(num2, DataStructure.Type_Skill._Reborn) <= this._My_Reborn)
						{
							if (num3 == 1)
							{
								if (this.SkillExits(num2) || !Data.GetDataSkillExits(num2))
								{
									break;
								}
								int dataSkill = Data.GetDataSkill(num2, DataStructure.Type_Skill._Thuoctinh);
								if (!this.GetDKThuoctinh(dataSkill))
								{
									break;
								}
								int pointSkillAdd = this.GetPointSkillAdd(dataSkill, Data.GetDataSkill(num2, DataStructure.Type_Skill._Point));
								if (!(this._My_SkillPoint >= pointSkillAdd & Data.GetDataSkill(num2, DataStructure.Type_Skill._Point) > 0))
								{
									break;
								}
								int dataSkill2 = Data.GetDataSkill(num2, DataStructure.Type_Skill._IdDK1);
								int dataSkill3 = Data.GetDataSkill(num2, DataStructure.Type_Skill._IdDK2);
								int dataSkill4 = Data.GetDataSkill(num2, DataStructure.Type_Skill._IdDK3);
								int dataSkill5 = Data.GetDataSkill(num2, DataStructure.Type_Skill._IdDK4);
								int dataSkill6 = Data.GetDataSkill(num2, DataStructure.Type_Skill._IdDK5);
								int dataSkill7 = Data.GetDataSkill(num2, DataStructure.Type_Skill._IdDK6);
								if (!((dataSkill2 == 0 & dataSkill3 == 0 & dataSkill4 == 0 & dataSkill5 == 0 & dataSkill6 == 0 & dataSkill7 == 0) | this.SkillExits(dataSkill2) | this.SkillExits(dataSkill3) | this.SkillExits(dataSkill4) | this.SkillExits(dataSkill5) | this.SkillExits(dataSkill6) | this.SkillExits(dataSkill7)))
								{
									break;
								}
								int num4 = this._My_SkillPoint - pointSkillAdd;
								Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._SkillPoint, num4);
								this.SkillAdd(num2, num3, Data.GetDataSkill(num2, DataStructure.Type_Skill._Sp), 0);
								text = text + "F4440C0008016E01" + Class5.smethod_12(num3) + Class5.smethod_12(num2);
								count = num4;
							}
							else
							{
								if (num3 <= Data.GetDataSkill(num2, DataStructure.Type_Skill._LvMax))
								{
									if (this.SkillExits(num2))
									{
										if (this._My_SkillPoint < num3 - this.SkillGet(num2, DataStructure.Type_MySkill._Lv))
										{
											break;
										}
										int num5 = this._My_SkillPoint - (num3 - this.SkillGet(num2, DataStructure.Type_MySkill._Lv));
										Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._SkillPoint, num5);
										this.SkillUpdate(num2, DataStructure.Type_MySkill._Lv, num3);
										text = text + "F4440C0008016E01" + Class5.smethod_12(num3) + Class5.smethod_12(num2);
										count = num5;
									}
									else
									{
										if (!Data.GetDataSkillExits(num2))
										{
											break;
										}
										int dataSkill8 = Data.GetDataSkill(num2, DataStructure.Type_Skill._Thuoctinh);
										if (!this.GetDKThuoctinh(dataSkill8))
										{
											break;
										}
										int pointSkillAdd2 = this.GetPointSkillAdd(dataSkill8, Data.GetDataSkill(num2, DataStructure.Type_Skill._Point));
										if (!(this._My_SkillPoint >= pointSkillAdd2 + num3 - 1 & Data.GetDataSkill(num2, DataStructure.Type_Skill._Point) > 0))
										{
											break;
										}
										int dataSkill9 = Data.GetDataSkill(num2, DataStructure.Type_Skill._IdDK1);
										int dataSkill10 = Data.GetDataSkill(num2, DataStructure.Type_Skill._IdDK2);
										int dataSkill11 = Data.GetDataSkill(num2, DataStructure.Type_Skill._IdDK3);
										int dataSkill12 = Data.GetDataSkill(num2, DataStructure.Type_Skill._IdDK4);
										int dataSkill13 = Data.GetDataSkill(num2, DataStructure.Type_Skill._IdDK5);
										int dataSkill14 = Data.GetDataSkill(num2, DataStructure.Type_Skill._IdDK6);
										if (!((dataSkill9 == 0 & dataSkill10 == 0 & dataSkill11 == 0 & dataSkill12 == 0 & dataSkill13 == 0 & dataSkill14 == 0) | this.SkillExits(dataSkill9) | this.SkillExits(dataSkill10) | this.SkillExits(dataSkill11) | this.SkillExits(dataSkill12) | this.SkillExits(dataSkill13) | this.SkillExits(dataSkill14)))
										{
											break;
										}
										int num6 = this._My_SkillPoint - (pointSkillAdd2 + num3 - 1);
										Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._SkillPoint, num6);
										this.SkillAdd(num2, num3, Data.GetDataSkill(num2, DataStructure.Type_Skill._Sp), 0);
										text = text + "F4440C0008016E01" + Class5.smethod_12(num3) + Class5.smethod_12(num2);
										count = num6;
									}
								}
							}
						}
					}
					if (text.Length > 0)
					{
						this.SendSkillPointtoClient(count);
						this.Sendpacket(text);
					}
					break;
				}
				case 2:
				{
					int num7 = (int)packet[6];
					int num8 = Class5.smethod_9(new byte[]
					{
						packet[7],
						packet[8]
					});
					int num9 = (int)packet[9];
					if (num9 <= Data.GetDataSkill(num8, DataStructure.Type_Skill._LvMax))
					{
						int num10 = Data.PetGetData(this.conn, num7, DataStructure.Type_Pet._IdSkill1);
						int num11 = Data.PetGetData(this.conn, num7, DataStructure.Type_Pet._IdSkill2);
						int num12 = Data.PetGetData(this.conn, num7, DataStructure.Type_Pet._IdSkill3);
						int num13 = Data.PetGetData(this.conn, num7, DataStructure.Type_Pet._IdSkill4);
						int num14 = Data.PetGetData(this.conn, num7, DataStructure.Type_Pet._LvSkill1);
						int num15 = Data.PetGetData(this.conn, num7, DataStructure.Type_Pet._LvSkill2);
						int num16 = Data.PetGetData(this.conn, num7, DataStructure.Type_Pet._LvSkill3);
						int num17 = Data.PetGetData(this.conn, num7, DataStructure.Type_Pet._LvSkill4);
						int num18 = Data.PetGetData(this.conn, num7, DataStructure.Type_Pet._SkillPoint);
						int num19 = num8;
						if (num19 == num10)
						{
							int num20 = num9 - num14;
							if (num9 > num14 & num18 >= num20)
							{
								Data.PetUpdateData(this._My_Id, num7, DataStructure.Type_Pet._SkillPoint, num18 - num20);
								Data.PetUpdateData(this._My_Id, num7, DataStructure.Type_Pet._LvSkill1, num9);
								this.Sendpacket(string.Concat(new string[]
								{
									"F4440F00080204",
									Class5.smethod_11(num7),
									"6E01",
									Class5.smethod_12(num9),
									Class5.smethod_12(num8)
								}));
							}
						}
						else
						{
							if (num19 == num11)
							{
								int num21 = num9 - num15;
								if (num9 > num15 & num18 >= num21)
								{
									Data.PetUpdateData(this._My_Id, num7, DataStructure.Type_Pet._SkillPoint, num18 - num21);
									Data.PetUpdateData(this._My_Id, num7, DataStructure.Type_Pet._LvSkill2, num9);
									this.Sendpacket(string.Concat(new string[]
									{
										"F4440F00080204",
										Class5.smethod_11(num7),
										"6E01",
										Class5.smethod_12(num9),
										Class5.smethod_12(num8)
									}));
								}
							}
							else
							{
								if (num19 == num12)
								{
									int num22 = num9 - num16;
									if (num9 > num16 & num18 >= num22)
									{
										Data.PetUpdateData(this._My_Id, num7, DataStructure.Type_Pet._SkillPoint, num18 - num22);
										Data.PetUpdateData(this._My_Id, num7, DataStructure.Type_Pet._LvSkill3, num9);
										this.Sendpacket(string.Concat(new string[]
										{
											"F4440F00080204",
											Class5.smethod_11(num7),
											"6E01",
											Class5.smethod_12(num9),
											Class5.smethod_12(num8)
										}));
									}
								}
								else
								{
									if (num19 == num13)
									{
										int num23 = num9 - num17;
										if (num9 > num17 & num18 >= num23)
										{
											Data.PetUpdateData(this._My_Id, num7, DataStructure.Type_Pet._SkillPoint, num18 - num23);
											Data.PetUpdateData(this._My_Id, num7, DataStructure.Type_Pet._LvSkill4, num9);
											this.Sendpacket(string.Concat(new string[]
											{
												"F4440F00080204",
												Class5.smethod_11(num7),
												"6E01",
												Class5.smethod_12(num9),
												Class5.smethod_12(num8)
											}));
										}
									}
								}
							}
						}
					}
					break;
				}
				}
			}
		}
		public void Update_H1D(byte[] packet)
		{
			switch (packet[5])
			{
			case 1:
				FTienTrang.H1(this, packet);
				break;
			case 2:
				FTienTrang.H2(this, packet);
				break;
			}
		}
		public void Update_H20(byte[] packet)
		{
			switch (packet[5])
			{
			case 1:
			{
				int num = (int)packet[6];
				Server.SendToAllClientMapid(this._My_Id, "F44407002001" + Class5.smethod_12(this._My_Id) + num.ToString("X2"));
				break;
			}
			case 2:
			{
				int my_Dongtac = (int)packet[6];
				this._My_Dongtac = my_Dongtac;
				Server.SendToAllClientMapid(this._My_Id, "F44407002002" + Class5.smethod_12(this._My_Id) + my_Dongtac.ToString("X2"));
				break;
			}
			case 3:
				this._My_Dongtac = 0;
				break;
			}
		}
		public void Update_H21(byte[] packet)
		{
			switch (packet[5])
			{
			case 1:
				switch (packet[6])
				{
				case 0:
					this.Sendpacket("F4440400210200" + this._My_ThamChien.ToString("X2"));
					Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Pk, 0);
					break;
				case 1:
					this.Sendpacket("F4440400210201" + this._My_ThamChien.ToString("X2"));
					Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Pk, 1);
					break;
				}
				break;
			case 2:
				switch (packet[6])
				{
				case 0:
					this.Sendpacket("F44404002102" + this._My_Pk.ToString("X2") + "00");
					Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._ThamChien, 0);
					break;
				case 1:
					this.Sendpacket("F44404002102" + this._My_Pk.ToString("X2") + "01");
					Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._ThamChien, 1);
					break;
				}
				break;
			}
		}
		public void Update_H22(byte[] packet)
		{
			byte b = packet[5];
			if (b == 1)
			{
				this.method_0(9999999);
			}
		}
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void Update_H23(byte[] packet)
		{
			checked
			{
				switch (packet[5])
				{
				case 1:
				{
					string text = "";
					int num = (int)packet[6];
					string text2 = "";
					int num2 = (int)packet[6 + num + 1];
					string text3 = "";
					int num3 = (int)packet[6 + num + num2 + 2];
					string text4 = "";
					int num4 = (int)packet[6 + num + num2 + num3 + 3];
					int arg_5C_0 = 7;
					int num5 = 6 + num;
					for (int i = arg_5C_0; i <= num5; i++)
					{
						text += Conversions.ToString(Strings.Chr((int)packet[i]));
					}
					int arg_8D_0 = 7 + num + 1;
					int num6 = 7 + num + num2;
					for (int j = arg_8D_0; j <= num6; j++)
					{
						text2 += Conversions.ToString(Strings.Chr((int)packet[j]));
					}
					int arg_C5_0 = 7 + num + num2 + 2;
					int num7 = 7 + num + num2 + num3 + 1;
					for (int k = arg_C5_0; k <= num7; k++)
					{
						text3 += Conversions.ToString(Strings.Chr((int)packet[k]));
					}
					int arg_105_0 = 7 + num + num2 + num3 + 3;
					int num8 = 7 + num + num2 + num3 + num4 + 2;
					for (int l = arg_105_0; l <= num8; l++)
					{
						text4 += Conversions.ToString(Strings.Chr((int)packet[l]));
					}
					if (Operators.CompareString(text, Data.MemberGetData(this._My_Id, "pass1"), false) != 0)
					{
						this.Sendpacket("F4440300230102");
					}
					else
					{
						if (Operators.CompareString(text3, Data.MemberGetData(this._My_Id, "pass2"), false) != 0)
						{
							this.Sendpacket("F4440300230103");
						}
						else
						{
							if (Operators.CompareString(text, Data.MemberGetData(this._My_Id, "pass1"), false) == 0 & Operators.CompareString(text3, Data.MemberGetData(this._My_Id, "pass2"), false) == 0)
							{
								Data.MemberChangedPass(this._My_Id, text2, text4);
								this.Sendpacket("F4440300230101");
							}
						}
					}
					break;
				}
				case 2:
				{
					string text5 = "";
					int num9 = (int)packet[6];
					string text6 = "";
					int num10 = (int)packet[6 + num9 + 1];
					int arg_1FE_0 = 7;
					int num11 = 6 + num9;
					for (int m = arg_1FE_0; m <= num11; m++)
					{
						text5 += Conversions.ToString(Strings.Chr((int)packet[m]));
					}
					int arg_234_0 = 7 + num9 + 1;
					int num12 = 7 + num9 + num10;
					for (int n = arg_234_0; n <= num12; n++)
					{
						text6 += Conversions.ToString(Strings.Chr((int)packet[n]));
					}
					if (Operators.CompareString(text5, Data.MemberGetData(this._My_Id, "pass1"), false) != 0)
					{
						this.Sendpacket("F4440300230202");
					}
					else
					{
						if (Operators.CompareString(text6, Data.MemberGetData(this._My_Id, "pass2"), false) != 0)
						{
							this.Sendpacket("F4440300230203");
						}
						else
						{
							if (Operators.CompareString(text5, Data.MemberGetData(this._My_Id, "pass1"), false) == 0 & Operators.CompareString(text6, Data.MemberGetData(this._My_Id, "pass2"), false) == 0)
							{
								if (Server.Clients.ContainsKey(this._My_Id))
								{
									if (this._My_IdBattle > 0)
									{
										TheBattle theBattle = Server.TheBattles[this._My_IdBattle];
										try
										{
											IEnumerator enumerator = Server.TheBattles[this._My_IdBattle]._keys.GetEnumerator();
											while (enumerator.MoveNext())
											{
												string key = Conversions.ToString(enumerator.Current);
												DataStructure.WarInfo value = Server.TheBattles[this._My_IdBattle].ListWar[key];
												int id = value._Id;
												int type = value._Type;
												if (type == 2)
												{
													if (id == this._My_Id)
													{
														string text7 = "";
														int row = value._Row;
														int column = value._Column;
														theBattle.ChangedWar(Class5.smethod_3(new byte[]
														{
															(byte)row,
															(byte)column
														}), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
														text7 = text7 + "F44404000B01" + (row ^ 1).ToString("X2") + column.ToString("X2");
														theBattle.ChangedWar(Class5.smethod_3(new byte[]
														{
															(byte)(row ^ 1),
															(byte)column
														}), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
														text7 = string.Concat(new string[]
														{
															text7,
															"F44408000B00",
															Class5.smethod_12(id),
															"0000F44405000B01",
															row.ToString("X2"),
															column.ToString("X2"),
															"00"
														});
														theBattle.SendSKillingToParty(text7);
														Server.SendToAllClientMapid(id, "F44408000B00" + Class5.smethod_12(id) + "0000");
														this._My_IdBattle = 0;
													}
													if (this._My_IdLeader == this._My_Id && (id == this._My_IdMem1 | id == this._My_IdMem2 | id == this._My_IdMem3 | id == this._My_IdMem4) && Server.Clients.ContainsKey(id))
													{
														Client arg_54F_0 = Server.Clients[id];
														string text8 = "";
														int row2 = value._Row;
														int column2 = value._Column;
														text8 = text8 + "F44404000B01" + (row2 ^ 1).ToString("X2") + column2.ToString("X2");
														text8 = string.Concat(new string[]
														{
															text8,
															"F44408000B00",
															Class5.smethod_12(id),
															"0000F44405000B01",
															row2.ToString("X2"),
															column2.ToString("X2"),
															"00"
														});
														theBattle.SendSKillingToParty(text8);
														Server.SendToAllClientMapid(id, "F44408000B00" + Class5.smethod_12(id) + "0000");
														theBattle.ChangedWar(Class5.smethod_3(new byte[]
														{
															(byte)(row2 ^ 1),
															(byte)column2
														}), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
														theBattle.ChangedWar(Class5.smethod_3(new byte[]
														{
															(byte)row2,
															(byte)column2
														}), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
														Server.Clients[id]._My_IdBattle = 0;
													}
												}
												Server.TheBattles[this._My_IdBattle].ListWar[key] = value;
											}
										}
										finally
										{

										}
									}
									this.GiaiTanParty(this._My_Id);
									Server.ServerSend_PlayerOffline(this._My_Id);
									Server.SendToAllClientMapid(this._My_Id, "F44406000D04" + Class5.smethod_12(this._My_Id));
								}
								this.conn.Dispose();
								this.conn.Close();
								this._socket.Close();
								this.PlayerDeleteDataId(this._My_Id);
								try
								{
									this.string_0 = Class1.Form0_0.Info.DirectoryPath + "\\member\\vn" + this._My_Id.ToString() + ".accdb";
									if (File.Exists(this.string_0))
									{
										File.Delete(this.string_0);
									}
								}
								catch (Exception expr_7A7)
								{
									ProjectData.SetProjectError(expr_7A7);
									ProjectData.ClearProjectError();
								}
								Server.Clients.Remove(this._My_Id);
							}
						}
					}
					break;
				}
				}
			}
		}
		public void Update_H28(byte[] packet)
		{
			byte b = packet[5];
			if (b == 1)
			{
				int idSkill = Class5.smethod_9(new byte[]
				{
					packet[7],
					packet[8]
				});
				int num = (int)packet[9];
				if (num > 0)
				{
					this.SkillSaveUpdateId(num, idSkill);
				}
				else
				{
					if (num == 0)
					{
						this.SkillSaveUpdateId(num, 0);
					}
				}
			}
		}
		public void Update_H32(byte[] packet)
		{
			byte b = packet[5];
			checked
			{
				if (b == 1 && packet.Length >= 12)
				{
					int num = (int)packet[6];
					int num2 = (int)packet[7];
					int num3 = (int)packet[8];
					int num4 = (int)packet[9];
					int num5 = Class5.smethod_9(new byte[]
					{
						packet[10],
						packet[11]
					});
					if ((num >= 0 & num <= 3 & num2 >= 0 & num2 <= 4 & num3 >= 0 & num3 <= 3 & num4 >= 0 & num4 <= 4) && Server.TheBattles.ContainsKey(this._My_IdBattle))
					{
						TheBattle theBattle = Server.TheBattles[this._My_IdBattle];
						if (theBattle.ListWar.ContainsKey(Class5.smethod_3(new byte[]
						{
							(byte)num,
							(byte)num2
						})))
						{
							DataStructure.WarInfo value = theBattle.ListWar[Class5.smethod_3(new byte[]
							{
								(byte)num,
								(byte)num2
							})];
							if (value._Id > 0)
							{
								int type = value._Type;
								if (value._Attacked == 0)
								{
									if (type == 2)
									{
										value._LvSKill = this.SkillGet(num5, DataStructure.Type_MySkill._Lv);
									}
									else
									{
										int my_SttPetXuatChien = this._My_SttPetXuatChien;
										int num6 = Data.PetGetData(this.conn, my_SttPetXuatChien, DataStructure.Type_Pet._IdSkill1);
										int num7 = Data.PetGetData(this.conn, my_SttPetXuatChien, DataStructure.Type_Pet._IdSkill2);
										int num8 = Data.PetGetData(this.conn, my_SttPetXuatChien, DataStructure.Type_Pet._IdSkill3);
										int num9 = Data.PetGetData(this.conn, my_SttPetXuatChien, DataStructure.Type_Pet._IdSkill4);
										int lvSKill = Data.PetGetData(this.conn, my_SttPetXuatChien, DataStructure.Type_Pet._LvSkill1);
										int lvSKill2 = Data.PetGetData(this.conn, my_SttPetXuatChien, DataStructure.Type_Pet._LvSkill2);
										int lvSKill3 = Data.PetGetData(this.conn, my_SttPetXuatChien, DataStructure.Type_Pet._LvSkill3);
										int lvSKill4 = Data.PetGetData(this.conn, my_SttPetXuatChien, DataStructure.Type_Pet._LvSkill4);
										int num10 = num5;
										if (num10 == num6)
										{
											value._LvSKill = lvSKill;
										}
										else
										{
											if (num10 == num7)
											{
												value._LvSKill = lvSKill2;
											}
											else
											{
												if (num10 == num8)
												{
													value._LvSKill = lvSKill3;
												}
												else
												{
													if (num10 == num9)
													{
														value._LvSKill = lvSKill4;
													}
												}
											}
										}
									}
									value._RowAttack = num3;
									value._ColumnAttack = num4;
									value._IdSkill = num5;
									value._Attacked = 1;
									if (Server.TheBattles.ContainsKey(this._My_IdBattle))
									{
										Server.TheBattles[this._My_IdBattle].SendSKillingToParty("F44404003505" + num.ToString("X2") + num2.ToString("X2"));
									}
								}
							}
							theBattle.ListWar[Class5.smethod_3(new byte[]
							{
								(byte)num,
								(byte)num2
							})] = value;
						}
					}
				}
			}
		}
		public void EndTalk()
		{
			this.Sendpacket("F44402001408");
			this.talkcount = 0;
			this.idtalking = 0;
		}
		public void Logined1()
		{
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Player Where Id=" + Conversions.ToString(this._My_Id), Data.conn_Account);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				this._My_Name = Conversions.ToString(oleDbDataReader["Name"]);
				this._My_Lv = Conversions.ToInteger(oleDbDataReader["Lv"]);
				this._My_Hp = Conversions.ToInteger(oleDbDataReader["Hp"]);
				this._My_HpMax = Conversions.ToInteger(oleDbDataReader["Hpmax"]);
				this._My_Sp = Conversions.ToInteger(oleDbDataReader["Sp"]);
				this._My_SpMax = Conversions.ToInteger(oleDbDataReader["Spmax"]);
				this._My_Point = Conversions.ToInteger(oleDbDataReader["Point"]);
				this._My_SkillPoint = Conversions.ToInteger(oleDbDataReader["SkillPoint"]);
				this._My_Int = Conversions.ToInteger(oleDbDataReader["Int"]);
				this._My_Atk = Conversions.ToInteger(oleDbDataReader["Atk"]);
				this._My_Def = Conversions.ToInteger(oleDbDataReader["Def"]);
				this._My_Hpx = Conversions.ToInteger(oleDbDataReader["Hpx"]);
				this._My_Spx = Conversions.ToInteger(oleDbDataReader["Spx"]);
				this._My_Agi = Conversions.ToInteger(oleDbDataReader["Agi"]);
				this._My_Int2 = Conversions.ToInteger(oleDbDataReader["Int2"]);
				this._My_Atk2 = Conversions.ToInteger(oleDbDataReader["Atk2"]);
				this._My_Def2 = Conversions.ToInteger(oleDbDataReader["Def2"]);
				this._My_Hpx2 = Conversions.ToInteger(oleDbDataReader["Hpx2"]);
				this._My_Spx2 = Conversions.ToInteger(oleDbDataReader["Spx2"]);
				this._My_Agi2 = Conversions.ToInteger(oleDbDataReader["Agi2"]);
				this._My_Texp = Conversions.ToInteger(oleDbDataReader["TExp"]);
				this._My_MapId = Conversions.ToInteger(oleDbDataReader["MapId"]);
				this._My_MapX = Conversions.ToInteger(oleDbDataReader["MapX"]);
				this._My_MapY = Conversions.ToInteger(oleDbDataReader["MapY"]);
				this._My_Reborn = Conversions.ToInteger(oleDbDataReader["Reborn"]);
				this._My_Job = Conversions.ToInteger(oleDbDataReader["Job"]);
				this._My_Sex = Conversions.ToInteger(oleDbDataReader["Sex"]);
				this._My_Hair = Conversions.ToInteger(oleDbDataReader["Hair"]);
				this._My_Thuoctinh = Conversions.ToInteger(oleDbDataReader["Thuoctinh"]);
				this._My_Ghost = Conversions.ToInteger(oleDbDataReader["Ghost"]);
				this._My_God = Conversions.ToInteger(oleDbDataReader["God"]);
				this._My_Color = Conversions.ToString(oleDbDataReader["Color"]);
				this._My_Gold = Conversions.ToInteger(oleDbDataReader["Gold"]);
				this._My_Tiengtam = Conversions.ToInteger(oleDbDataReader["Tiengtam"]);
				this._My_Gocnhin = Conversions.ToInteger(oleDbDataReader["Gocnhin"]);
				this._My_SttPetXuatChien = Conversions.ToInteger(oleDbDataReader["SttPetXuatChien"]);
				this._My_Pk = Conversions.ToInteger(oleDbDataReader["Pk"]);
				this._My_ThamChien = Conversions.ToInteger(oleDbDataReader["ThamChien"]);
			}
			oleDbDataReader.Close();
			Data.PlayerUpdateStatus(this._My_Id, DataStructure.Type_Status._hpx, this._My_Hpx);
			Data.PlayerUpdateStatus(this._My_Id, DataStructure.Type_Status._spx, this._My_Spx);
			Data.PlayerUpdateStatus(this._My_Id, DataStructure.Type_Status._atk, this._My_Atk);
			Data.PlayerUpdateStatus(this._My_Id, DataStructure.Type_Status._def, this._My_Def);
			Data.PlayerUpdateStatus(this._My_Id, DataStructure.Type_Status._Int, this._My_Int);
			Data.PlayerUpdateStatus(this._My_Id, DataStructure.Type_Status._agi, this._My_Agi);
			Data.PlayerUpdateStatus(this._My_Id, DataStructure.Type_Status._Hp, this._My_Hp);
			Data.PlayerUpdateStatus(this._My_Id, DataStructure.Type_Status._Sp, this._My_Sp);
			string text = "";
			string text2 = "";
			DataStructure.HomdoInfo homdoInfo = Data.TrangbiGetDataItem(this.conn, 1);
			DataStructure.HomdoInfo homdoInfo2 = Data.TrangbiGetDataItem(this.conn, 2);
			DataStructure.HomdoInfo homdoInfo3 = Data.TrangbiGetDataItem(this.conn, 3);
			DataStructure.HomdoInfo homdoInfo4 = Data.TrangbiGetDataItem(this.conn, 4);
			DataStructure.HomdoInfo homdoInfo5 = Data.TrangbiGetDataItem(this.conn, 5);
			DataStructure.HomdoInfo homdoInfo6 = Data.TrangbiGetDataItem(this.conn, 6);
			int iD = homdoInfo._ID;
			int iD2 = homdoInfo2._ID;
			int iD3 = homdoInfo3._ID;
			int iD4 = homdoInfo4._ID;
			int iD5 = homdoInfo5._ID;
			int iD6 = homdoInfo6._ID;
			int doben = homdoInfo._Doben;
			int doben2 = homdoInfo2._Doben;
			int doben3 = homdoInfo3._Doben;
			int doben4 = homdoInfo4._Doben;
			int doben5 = homdoInfo5._Doben;
			int doben6 = homdoInfo6._Doben;
			int @long = homdoInfo._Long;
			int long2 = homdoInfo2._Long;
			int long3 = homdoInfo3._Long;
			int long4 = homdoInfo4._Long;
			int long5 = homdoInfo5._Long;
			int long6 = homdoInfo6._Long;
			int giatriLong = homdoInfo._GiatriLong;
			int giatriLong2 = homdoInfo2._GiatriLong;
			int giatriLong3 = homdoInfo3._GiatriLong;
			int giatriLong4 = homdoInfo4._GiatriLong;
			int giatriLong5 = homdoInfo5._GiatriLong;
			int giatriLong6 = homdoInfo6._GiatriLong;
			int khang = homdoInfo._Khang;
			int khang2 = homdoInfo2._Khang;
			int khang3 = homdoInfo3._Khang;
			int khang4 = homdoInfo4._Khang;
			int khang5 = homdoInfo5._Khang;
			int khang6 = homdoInfo6._Khang;
			int tExp = homdoInfo._TExp;
			int tExp2 = homdoInfo2._TExp;
			int tExp3 = homdoInfo3._TExp;
			int tExp4 = homdoInfo4._TExp;
			int tExp5 = homdoInfo5._TExp;
			int tExp6 = homdoInfo6._TExp;
			checked
			{
				if (iD > 0)
				{
					text += Class5.smethod_11(iD);
					text2 = string.Concat(new string[]
					{
						text2,
						Class5.smethod_11(iD),
						doben.ToString("X2"),
						@long.ToString("X2"),
						(giatriLong + 100).ToString("X2"),
						khang.ToString("X2"),
						Class5.smethod_12(tExp)
					});
				}
				if (iD2 > 0)
				{
					text += Class5.smethod_11(iD2);
					text2 = string.Concat(new string[]
					{
						text2,
						Class5.smethod_11(iD2),
						doben2.ToString("X2"),
						long2.ToString("X2"),
						(giatriLong2 + 100).ToString("X2"),
						khang2.ToString("X2"),
						Class5.smethod_12(tExp2)
					});
				}
				if (iD3 > 0)
				{
					text += Class5.smethod_11(iD3);
					text2 = string.Concat(new string[]
					{
						text2,
						Class5.smethod_11(iD3),
						doben3.ToString("X2"),
						long3.ToString("X2"),
						(giatriLong3 + 100).ToString("X2"),
						khang3.ToString("X2"),
						Class5.smethod_12(tExp3)
					});
				}
				if (iD4 > 0)
				{
					text += Class5.smethod_11(iD4);
					text2 = string.Concat(new string[]
					{
						text2,
						Class5.smethod_11(iD4),
						doben4.ToString("X2"),
						long4.ToString("X2"),
						(giatriLong4 + 100).ToString("X2"),
						khang4.ToString("X2"),
						Class5.smethod_12(tExp4)
					});
				}
				if (iD5 > 0)
				{
					text += Class5.smethod_11(iD5);
					text2 = string.Concat(new string[]
					{
						text2,
						Class5.smethod_11(iD5),
						doben5.ToString("X2"),
						long5.ToString("X2"),
						(giatriLong5 + 100).ToString("X2"),
						khang5.ToString("X2"),
						Class5.smethod_12(tExp5)
					});
				}
				if (iD6 > 0)
				{
					text += Class5.smethod_11(iD6);
					text2 = string.Concat(new string[]
					{
						text2,
						Class5.smethod_11(iD6),
						doben6.ToString("X2"),
						long6.ToString("X2"),
						(giatriLong6 + 100).ToString("X2"),
						khang6.ToString("X2"),
						Class5.smethod_12(tExp6)
					});
				}
				this.UpdateStatusWhenUseItem();
				this.Sendpacket("F44402001408F4440300142100");
				this.Sendpacket(string.Concat(new string[]
				{
					"F444",
					Class5.smethod_11(33 + (int)Math.Round((double)text.Length / 2.0) + this._My_Name.Length),
					"03",
					Class5.smethod_12(this._My_Id),
					this._My_Sex.ToString("X2"),
					this._My_Ghost.ToString("X2"),
					this._My_God.ToString("X2"),
					Class5.smethod_11(this._My_MapId),
					Class5.smethod_11(this._My_MapX),
					Class5.smethod_11(this._My_MapY),
					this._My_Gocnhin.ToString("X2"),
					Class5.smethod_11(this._My_Hair),
					this._My_Color,
					((int)Math.Round((double)text.Length / 4.0)).ToString("X2"),
					text,
					"0000000005",
					this._My_Reborn.ToString("X2"),
					this._My_Job.ToString("X2"),
					Class5.smethod_13(this._My_Name)
				}));
				this.Sendpacket(string.Concat(new string[]
				{
					"F444",
					Class5.smethod_11((int)Math.Round((double)this.GetlistSkill().Length / 2.0) + 113),
					"0503",
					this._My_Thuoctinh.ToString("X2"),
					Class5.smethod_11(this._My_Hp),
					Class5.smethod_11(this._My_Sp),
					Class5.smethod_11(this._My_Int),
					Class5.smethod_11(this._My_Atk),
					Class5.smethod_11(this._My_Def),
					Class5.smethod_11(this._My_Agi),
					Class5.smethod_11(this._My_Hpx),
					Class5.smethod_11(this._My_Spx),
					this._My_Lv.ToString("X2"),
					Class5.smethod_12(this._My_Texp),
					Class5.smethod_11(this._My_SkillPoint),
					Class5.smethod_11(this._My_Point),
					Class5.smethod_12(this._My_Tiengtam),
					Class5.smethod_11(this._My_HpMax),
					Class5.smethod_11(this._My_SpMax),
					Class5.smethod_12(this._My_Atk2),
					Class5.smethod_12(this._My_Def2),
					Class5.smethod_12(this._My_Int2),
					Class5.smethod_12(this._My_Agi2),
					Class5.smethod_12(this._My_Hpx2),
					Class5.smethod_12(this._My_Spx2),
					"F401F401F401F401F40100000000000000000000000000000000000000000000000000000000000000000000000000000000000000",
					this.GetlistSkill()
				}));
				Server.ServerSend_PlayerOnline(this._My_Id, this._My_Sex, this._My_Thuoctinh, this._My_Lv, this._My_Ghost, this._My_God, this._My_MapId, this._My_MapX, this._My_MapY, this._My_Gocnhin, this._My_Hair, this._My_Color, Conversions.ToInteger(iD.ToString()), Conversions.ToInteger(iD2.ToString()), Conversions.ToInteger(iD3.ToString()), Conversions.ToInteger(iD4.ToString()), Conversions.ToInteger(iD5.ToString()), Conversions.ToInteger(iD6.ToString()), this._My_Reborn, this._My_Job, this._My_Name, this._My_SttPetXuatChien, this._My_Pk, this._My_ThamChien);
				Server.SendPalyerOnline(this._My_Id);
				Data.SendStatusAllPet(this._My_Id);
				Server.SendAllParty(this._My_Id);
				if (this._My_SttPetXuatChien > 0 & this._My_SttPetXuatChien <= 4)
				{
					Server.SendToClient(this._My_Id, "F44406001301" + Class5.smethod_12(Data.PetGetData(this.conn, this._My_SttPetXuatChien, DataStructure.Type_Pet._ID)));
				}
				Data.UpdateStatusPetWhenUseItemLogin(this._My_Id);
				this.Sendpacket("F44404002102" + this._My_Pk.ToString("X2") + this._My_ThamChien.ToString("X2"));
				string text3 = "";
				string text4 = "";
				string text5 = "";
				OleDbDataReader oleDbDataReader2 = new OleDbCommand("SELECT * FROM Homdo Where Id > 0", this.conn).ExecuteReader();
				while (oleDbDataReader2.Read())
				{
					int num = Conversions.ToInteger(oleDbDataReader2["Slot"]);
					int int_ = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._ID]);
					int num2 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Count]);
					int num3 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Doben]);
					Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Thuoctinh]);
					Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._GiatriThuoctinh]);
					int num4 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Long]);
					int num5 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._GiatriLong]);
					int num6 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Khang]);
					int int_2 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._TExp]);
					text3 = string.Concat(new string[]
					{
						text3,
						num.ToString("X2"),
						Class5.smethod_11(int_),
						num2.ToString("X2"),
						num3.ToString("X2"),
						num4.ToString("X2"),
						(num5 + 100).ToString("X2"),
						num6.ToString("X2"),
						Class5.smethod_12(int_2)
					});
				}
				oleDbDataReader2.Close();
				oleDbDataReader2 = new OleDbCommand("SELECT * FROM Tuideo Where Id > 0", this.conn).ExecuteReader();
				while (oleDbDataReader2.Read())
				{
					int num7 = Conversions.ToInteger(oleDbDataReader2["Slot"]);
					int int_3 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._ID]);
					int num8 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Count]);
					int num9 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Doben]);
					Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Thuoctinh]);
					Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._GiatriThuoctinh]);
					int num10 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Long]);
					int num11 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._GiatriLong]);
					int num12 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Khang]);
					int int_4 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._TExp]);
					text4 = string.Concat(new string[]
					{
						text4,
						num7.ToString("X2"),
						Class5.smethod_11(int_3),
						num8.ToString("X2"),
						num9.ToString("X2"),
						num10.ToString("X2"),
						(num11 + 100).ToString("X2"),
						num12.ToString("X2"),
						Class5.smethod_12(int_4)
					});
				}
				oleDbDataReader2.Close();
				oleDbDataReader2 = new OleDbCommand("SELECT * FROM Luulang Where Id > 0", this.conn).ExecuteReader();
				while (oleDbDataReader2.Read())
				{
					int num13 = Conversions.ToInteger(oleDbDataReader2["Slot"]);
					int int_5 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._ID]);
					int num14 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Count]);
					int num15 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Doben]);
					Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Thuoctinh]);
					Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._GiatriThuoctinh]);
					int num16 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Long]);
					int num17 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._GiatriLong]);
					int num18 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._Khang]);
					int int_6 = Conversions.ToInteger(oleDbDataReader2[DataStructure.Type_Homdo._TExp]);
					text5 = string.Concat(new string[]
					{
						text5,
						num13.ToString("X2"),
						Class5.smethod_11(int_5),
						num14.ToString("X2"),
						num15.ToString("X2"),
						num16.ToString("X2"),
						(num17 + 100).ToString("X2"),
						num18.ToString("X2"),
						Class5.smethod_12(int_6)
					});
				}
				oleDbDataReader2.Close();
				string text6 = "";
				if (text3.Length > 0)
				{
					text6 = "F444" + Class5.smethod_11(2 + (int)Math.Round((double)text3.Length / 2.0)) + "1705" + text3;
				}
				if (text4.Length > 0)
				{
					text6 = string.Concat(new string[]
					{
						text6,
						"F444",
						Class5.smethod_11(2 + (int)Math.Round((double)text4.Length / 2.0)),
						"172F",
						text4
					});
				}
				if (text5.Length > 0)
				{
					text6 = string.Concat(new string[]
					{
						text6,
						"F444",
						Class5.smethod_11(2 + (int)Math.Round((double)text5.Length / 2.0)),
						"1766",
						text5
					});
				}
				if (text6.Length > 0)
				{
					this.Sendpacket(text6);
				}
				this.Sendpacket("F444" + Class5.smethod_11(2 + (int)Math.Round((double)text2.Length / 2.0)) + "170B" + text2);
				this.Sendpacket("F4440A001A04" + Class5.smethod_12(this._My_Gold) + "00000000");
				string text7 = Class5.smethod_17("TSVN");
				this.Sendpacket(string.Concat(new string[]
				{
					"F444",
					Class5.smethod_11(text7.Length + 11),
					"2709",
					Class5.smethod_12(this._My_Id),
					"C4000000",
					text7.Length.ToString("X2"),
					Class5.smethod_13(text7)
				}));
				this.Sendpacket("F44402000504F44402000F0A");
				this.Sendpacket("F4441000020B00000000323031322F30382F3136");
				string text8 = Class5.smethod_17("http://tsonline.ns01.us");
				this.Sendpacket("F444" + Class5.smethod_11(text8.Length + 6) + "020B00000000" + Class5.smethod_13(text8));
				text8 = Class5.smethod_17("Chúc các bạn vui vẻ!");
				this.Sendpacket("F444" + Class5.smethod_11(text8.Length + 6) + "020B00000000" + Class5.smethod_13(text8));
				string text9 = "";
				int num19 = 1;
				do
				{
					int num20 = this.SkillSaveGetId(num19);
					if (num20 > 0)
					{
						text9 = text9 + "02" + Class5.smethod_11(num20) + num19.ToString("X2");
					}
					num19++;
				}
				while (num19 <= 10);
				if (text9.Length > 0)
				{
					text9 = "2801" + text9;
					this.Sendpacket("F444" + Class5.smethod_11((int)Math.Round((double)text9.Length / 2.0)) + text9);
				}
				Data.GetDataItemOnMap(this._My_Id);
				this.method_0(9999999);
				if (this._My_Hp <= 0)
				{
					Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Hp, 1);
				}
				int num21 = 1;
				do
				{
					if (Data.PetGetData(this.conn, num21, DataStructure.Type_Pet._ID) > 0 && Data.PetGetData(this.conn, num21, DataStructure.Type_Pet._Hp) <= 0)
					{
						Data.PetUpdateData(this._My_Id, num21, DataStructure.Type_Pet._Hp, 1);
					}
					num21++;
				}
				while (num21 <= 4);
				this._My_Logined = 1;
			}
		}
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public void Logined()
		{
			this.string_0 = Class1.Form0_0.Info.DirectoryPath + "\\member\\vn" + this._My_Id.ToString() + ".accdb";
			if (this._My_Id > 0 & Data.PlayerGetIdExits(this._My_Id))
			{
				this.conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + this.string_0 + ";Persist Security Info=False;");
				if (this.conn.State == ConnectionState.Closed)
				{
					this.conn.Open();
				}
				Server.Clients.Add(Conversions.ToInteger(this._My_Id.ToString()), this);
				if (Server.ListView_Client.Items.ContainsKey(this._My_Id.ToString()))
				{
					Server.ListView_Client.Items[this._My_Id.ToString()].Tag = this;
					Server.ListView_Client.Items[this._My_Id.ToString()].SubItems[1].Text = "";
					Server.ListView_Client.Items[this._My_Id.ToString()].SubItems[2].Text = ((IPEndPoint)this._socket.RemoteEndPoint).Address.ToString();
				}
				else
				{
					ListViewItem listViewItem = new ListViewItem(this._My_Id.ToString());
					listViewItem.SubItems.Add("");
					listViewItem.SubItems.Add(((IPEndPoint)this._socket.RemoteEndPoint).Address.ToString());
					listViewItem.Name = this._My_Id.ToString();
					listViewItem.Tag = this;
					Server.ListView_Client.Items.Add(listViewItem);
				}
				this.Logined1();
			}
			else
			{
				this.CreatChar();
			}
		}
		public void method_0(int _point)
		{
			this.Sendpacket("F44412002304" + Class5.smethod_12(_point) + "000000000000000000000000");
		}
		public void Sendpacket(string packet)
		{
			try
			{
				byte[] array = Class5.smethod_5(Class5.smethod_4(packet));
				if (this._socket.Connected)
				{
					this._socket.Send(array, 0, array.Length, SocketFlags.None);
				}
			}
			catch (Exception expr_2E)
			{
				ProjectData.SetProjectError(expr_2E);
				ProjectData.ClearProjectError();
			}
		}
		public string GetlistSkill()
		{
			string text = "";
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Skill", this.conn);
			if (this.conn.State == ConnectionState.Closed)
			{
				this.conn.Open();
			}
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				text = text + Class5.smethod_11(Conversions.ToInteger(oleDbDataReader["Id"])) + Conversions.ToInteger(oleDbDataReader["Lv"]).ToString("X2");
			}
			oleDbDataReader.Close();
			return text;
		}
		public bool SkillExits(int Id)
		{
			bool result = false;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Skill Where Id=" + Conversions.ToString(Id), this.conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = true;
			}
			oleDbDataReader.Close();
			return result;
		}
		public int SkillGet(int Id, string Type)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Skill Where Id=" + Conversions.ToString(Id), this.conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader[Type]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public void SkillAdd(int Id, int Lv, int Sp, int Dk)
		{
			try
			{
				OleDbCommand oleDbCommand = new OleDbCommand(string.Concat(new string[]
				{
					"Insert Into Skill(ID, LV, SP, Save) Values(",
					Conversions.ToString(Id),
					", ",
					Conversions.ToString(Lv),
					", ",
					Conversions.ToString(Sp),
					", ",
					Conversions.ToString(Dk),
					")"
				}), this.conn);
				oleDbCommand.ExecuteNonQuery();
			}
			catch (Exception expr_71)
			{
				ProjectData.SetProjectError(expr_71);
				ProjectData.ClearProjectError();
			}
		}
		public void SkillUpdate(int Id, string type, int value)
		{
			string cmdText = string.Concat(new string[]
			{
				"UPDATE Skill SET ",
				type,
				" = ",
				Conversions.ToString(value),
				" WHERE Id = ",
				Conversions.ToString(Id)
			});
			OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.conn);
			oleDbCommand.ExecuteNonQuery();
		}
		public int SkillSaveGetId(int _Id)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM SkillSave Where Id =" + Conversions.ToString(_Id), this.conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader["IdSkill"]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public void SkillSaveUpdateId(int _Id, int _IdSkill)
		{
			string cmdText = "UPDATE SkillSave SET IdSkill = " + Conversions.ToString(_IdSkill) + " WHERE Id = " + Conversions.ToString(_Id);
			OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.conn);
			oleDbCommand.ExecuteNonQuery();
		}
		public void QuestInsertData(int _Mapid, int _Npcid, int _Warpid, int _Step)
		{
			OleDbCommand oleDbCommand = new OleDbCommand(string.Concat(new string[]
			{
				"Insert Into Quest(MapId, NpcId, WarpId, Step) Values(",
				Conversions.ToString(_Mapid),
				", ",
				Conversions.ToString(_Npcid),
				", ",
				Conversions.ToString(_Warpid),
				", ",
				Conversions.ToString(_Step),
				")"
			}), this.conn);
			oleDbCommand.ExecuteNonQuery();
		}
		public int QuestGetDataNpc(int _Mapid, int _Npcid)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Quest Where MapId=" + Conversions.ToString(_Mapid) + " and NpcId =" + Conversions.ToString(_Npcid), this.conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader["Step"]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public void QuestUpdateDataNpc(int _Mapid, int _Npcid, int _Step)
		{
			if (this.QuestGetDataNpc(_Mapid, _Npcid) == 0)
			{
				this.QuestInsertData(_Mapid, _Npcid, 0, _Step);
			}
			else
			{
				string cmdText = string.Concat(new string[]
				{
					"UPDATE Quest SET Step = ",
					Conversions.ToString(_Step),
					" Where MapId=",
					Conversions.ToString(_Mapid),
					" and NpcId =",
					Conversions.ToString(_Npcid)
				});
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.conn);
				oleDbCommand.ExecuteNonQuery();
			}
		}
		public int QuestGetDataWarp(int _Mapid, int _Warpid)
		{
			int result = 0;
			OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM Quest Where MapId=" + Conversions.ToString(_Mapid) + " and NpcId =" + Conversions.ToString(_Warpid), this.conn);
			OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
			if (oleDbDataReader.Read())
			{
				result = Conversions.ToInteger(oleDbDataReader["Step"]);
			}
			oleDbDataReader.Close();
			return result;
		}
		public void QuestUpdateDataWarp(int _Mapid, int _Warpid, int _Step)
		{
			if (this.QuestGetDataWarp(_Mapid, _Warpid) == 0)
			{
				this.QuestInsertData(_Mapid, _Warpid, 0, _Step);
			}
			else
			{
				string cmdText = string.Concat(new string[]
				{
					"UPDATE Quest SET Step = ",
					Conversions.ToString(_Step),
					" Where MapId=",
					Conversions.ToString(_Mapid),
					" and NpcId =",
					Conversions.ToString(_Warpid)
				});
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.conn);
				oleDbCommand.ExecuteNonQuery();
			}
		}
		public void PlayerDeleteDataId(int _id)
		{
			OleDbCommand oleDbCommand = new OleDbCommand("DELETE FROM Player Where Id = " + Conversions.ToString(_id), Data.conn_Account);
			oleDbCommand.ExecuteNonQuery();
		}
		public void UpdateStatusWhenUseItem()
		{
			DataStructure.HomdoInfo homdoInfo = Data.TrangbiGetDataItem(this.conn, 1);
			DataStructure.HomdoInfo homdoInfo2 = Data.TrangbiGetDataItem(this.conn, 2);
			DataStructure.HomdoInfo homdoInfo3 = Data.TrangbiGetDataItem(this.conn, 3);
			DataStructure.HomdoInfo homdoInfo4 = Data.TrangbiGetDataItem(this.conn, 4);
			DataStructure.HomdoInfo homdoInfo5 = Data.TrangbiGetDataItem(this.conn, 5);
			DataStructure.HomdoInfo homdoInfo6 = Data.TrangbiGetDataItem(this.conn, 6);
			int num = homdoInfo._Int1;
			int num2 = homdoInfo._Int2;
			int num3 = homdoInfo._Atk1;
			int num4 = homdoInfo._Atk2;
			int num5 = homdoInfo._Def1;
			int num6 = homdoInfo._Def2;
			int num7 = homdoInfo._Hpx1;
			int num8 = homdoInfo._Hpx2;
			int num9 = homdoInfo._Spx1;
			int num10 = homdoInfo._Spx2;
			int num11 = homdoInfo._Agi1;
			int num12 = homdoInfo._Agi2;
			int num13 = homdoInfo2._Int1;
			int num14 = homdoInfo2._Int2;
			int num15 = homdoInfo2._Atk1;
			int num16 = homdoInfo2._Atk2;
			int num17 = homdoInfo2._Def1;
			int num18 = homdoInfo2._Def2;
			int num19 = homdoInfo2._Hpx1;
			int num20 = homdoInfo2._Hpx2;
			int num21 = homdoInfo2._Spx1;
			int num22 = homdoInfo2._Spx2;
			int num23 = homdoInfo2._Agi1;
			int num24 = homdoInfo2._Agi2;
			int num25 = homdoInfo3._Int1;
			int num26 = homdoInfo3._Int2;
			int num27 = homdoInfo3._Atk1;
			int num28 = homdoInfo3._Atk2;
			int num29 = homdoInfo3._Def1;
			int num30 = homdoInfo3._Def2;
			int num31 = homdoInfo3._Hpx1;
			int num32 = homdoInfo3._Hpx2;
			int num33 = homdoInfo3._Spx1;
			int num34 = homdoInfo3._Spx2;
			int num35 = homdoInfo3._Agi1;
			int num36 = homdoInfo3._Agi2;
			int num37 = homdoInfo4._Int1;
			int num38 = homdoInfo4._Int2;
			int num39 = homdoInfo4._Atk1;
			int num40 = homdoInfo4._Atk2;
			int num41 = homdoInfo4._Def1;
			int num42 = homdoInfo4._Def2;
			int num43 = homdoInfo4._Hpx1;
			int num44 = homdoInfo4._Hpx2;
			int num45 = homdoInfo4._Spx1;
			int num46 = homdoInfo4._Spx2;
			int num47 = homdoInfo4._Agi1;
			int num48 = homdoInfo4._Agi2;
			int num49 = homdoInfo5._Int1;
			int num50 = homdoInfo5._Int2;
			int num51 = homdoInfo5._Atk1;
			int num52 = homdoInfo5._Atk2;
			int num53 = homdoInfo5._Def1;
			int num54 = homdoInfo5._Def2;
			int num55 = homdoInfo5._Hpx1;
			int num56 = homdoInfo5._Hpx2;
			int num57 = homdoInfo5._Spx1;
			int num58 = homdoInfo5._Spx2;
			int num59 = homdoInfo5._Agi1;
			int num60 = homdoInfo5._Agi2;
			int num61 = homdoInfo6._Int1;
			int num62 = homdoInfo6._Int2;
			int num63 = homdoInfo6._Atk1;
			int num64 = homdoInfo6._Atk2;
			int num65 = homdoInfo6._Def1;
			int num66 = homdoInfo6._Def2;
			int num67 = homdoInfo6._Hpx1;
			int num68 = homdoInfo6._Hpx2;
			int num69 = homdoInfo6._Spx1;
			int num70 = homdoInfo6._Spx2;
			int num71 = homdoInfo6._Agi1;
			int num72 = homdoInfo6._Agi2;
			checked
			{
				if (homdoInfo._Thuoctinh == this._My_Thuoctinh | homdoInfo._Thuoctinh == 5)
				{
					if (num > 0)
					{
						num += homdoInfo._GiatriThuoctinh;
					}
					if (num2 > 0)
					{
						num2 += homdoInfo._GiatriThuoctinh;
					}
					if (num3 > 0)
					{
						num3 += homdoInfo._GiatriThuoctinh;
					}
					if (num4 > 0)
					{
						num4 += homdoInfo._GiatriThuoctinh;
					}
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
				}
				if (homdoInfo._Long == this._My_Thuoctinh | homdoInfo._Long == 5)
				{
					if (num > 0)
					{
						num += homdoInfo._GiatriLong;
					}
					if (num2 > 0)
					{
						num2 += homdoInfo._GiatriLong;
					}
					if (num3 > 0)
					{
						num3 += homdoInfo._GiatriLong;
					}
					if (num4 > 0)
					{
						num4 += homdoInfo._GiatriLong;
					}
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
				}
				if (homdoInfo2._Thuoctinh == this._My_Thuoctinh | homdoInfo2._Thuoctinh == 5)
				{
					if (num13 > 0)
					{
						num13 += homdoInfo2._GiatriThuoctinh;
					}
					if (num14 > 0)
					{
						num14 += homdoInfo2._GiatriThuoctinh;
					}
					if (num15 > 0)
					{
						num15 += homdoInfo2._GiatriThuoctinh;
					}
					if (num16 > 0)
					{
						num16 += homdoInfo2._GiatriThuoctinh;
					}
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
				}
				if (homdoInfo2._Long == this._My_Thuoctinh | homdoInfo2._Long == 5)
				{
					if (num13 > 0)
					{
						num13 += homdoInfo2._GiatriLong;
					}
					if (num14 > 0)
					{
						num14 += homdoInfo2._GiatriLong;
					}
					if (num15 > 0)
					{
						num15 += homdoInfo2._GiatriLong;
					}
					if (num16 > 0)
					{
						num16 += homdoInfo2._GiatriLong;
					}
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
				}
				if (homdoInfo3._Thuoctinh == this._My_Thuoctinh | homdoInfo3._Thuoctinh == 5)
				{
					if (num25 > 0)
					{
						num25 += homdoInfo3._GiatriThuoctinh;
					}
					if (num26 > 0)
					{
						num26 += homdoInfo3._GiatriThuoctinh;
					}
					if (num27 > 0)
					{
						num27 += homdoInfo3._GiatriThuoctinh;
					}
					if (num28 > 0)
					{
						num28 += homdoInfo3._GiatriThuoctinh;
					}
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
				}
				if (homdoInfo3._Long == this._My_Thuoctinh | homdoInfo3._Long == 5)
				{
					if (num25 > 0)
					{
						num25 += homdoInfo3._GiatriLong;
					}
					if (num26 > 0)
					{
						num26 += homdoInfo3._GiatriLong;
					}
					if (num27 > 0)
					{
						num27 += homdoInfo3._GiatriLong;
					}
					if (num28 > 0)
					{
						num28 += homdoInfo3._GiatriLong;
					}
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
				}
				if (homdoInfo4._Thuoctinh == this._My_Thuoctinh | homdoInfo4._Thuoctinh == 5)
				{
					if (num37 > 0)
					{
						num37 += homdoInfo4._GiatriThuoctinh;
					}
					if (num38 > 0)
					{
						num38 += homdoInfo4._GiatriThuoctinh;
					}
					if (num39 > 0)
					{
						num39 += homdoInfo4._GiatriThuoctinh;
					}
					if (num40 > 0)
					{
						num40 += homdoInfo4._GiatriThuoctinh;
					}
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
				}
				if (homdoInfo4._Long == this._My_Thuoctinh | homdoInfo4._Long == 5)
				{
					if (num37 > 0)
					{
						num37 += homdoInfo4._GiatriLong;
					}
					if (num38 > 0)
					{
						num38 += homdoInfo4._GiatriLong;
					}
					if (num39 > 0)
					{
						num39 += homdoInfo4._GiatriLong;
					}
					if (num40 > 0)
					{
						num40 += homdoInfo4._GiatriLong;
					}
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
				}
				if (homdoInfo5._Thuoctinh == this._My_Thuoctinh | homdoInfo5._Thuoctinh == 5)
				{
					if (num49 > 0)
					{
						num49 += homdoInfo5._GiatriThuoctinh;
					}
					if (num50 > 0)
					{
						num50 += homdoInfo5._GiatriThuoctinh;
					}
					if (num51 > 0)
					{
						num51 += homdoInfo5._GiatriThuoctinh;
					}
					if (num52 > 0)
					{
						num52 += homdoInfo5._GiatriThuoctinh;
					}
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
				}
				if (homdoInfo5._Long == this._My_Thuoctinh | homdoInfo5._Long == 5)
				{
					if (num49 > 0)
					{
						num49 += homdoInfo5._GiatriLong;
					}
					if (num50 > 0)
					{
						num50 += homdoInfo5._GiatriLong;
					}
					if (num51 > 0)
					{
						num51 += homdoInfo5._GiatriLong;
					}
					if (num52 > 0)
					{
						num52 += homdoInfo5._GiatriLong;
					}
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
				}
				if (homdoInfo6._Thuoctinh == this._My_Thuoctinh | homdoInfo6._Thuoctinh == 5)
				{
					if (num61 > 0)
					{
						num61 += homdoInfo6._GiatriThuoctinh;
					}
					if (num62 > 0)
					{
						num62 += homdoInfo6._GiatriThuoctinh;
					}
					if (num63 > 0)
					{
						num63 += homdoInfo6._GiatriThuoctinh;
					}
					if (num64 > 0)
					{
						num64 += homdoInfo6._GiatriThuoctinh;
					}
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
				}
				if (homdoInfo6._Long == this._My_Thuoctinh | homdoInfo6._Long == 5)
				{
					if (num61 > 0)
					{
						num61 += homdoInfo6._GiatriLong;
					}
					if (num62 > 0)
					{
						num62 += homdoInfo6._GiatriLong;
					}
					if (num63 > 0)
					{
						num63 += homdoInfo6._GiatriLong;
					}
					if (num64 > 0)
					{
						num64 += homdoInfo6._GiatriLong;
					}
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
				}
				int value = num + num2 + num13 + num14 + num25 + num26 + num37 + num38 + num49 + num50 + num61 + num62;
				int value2 = num3 + num4 + num15 + num16 + num27 + num28 + num39 + num40 + num51 + num52 + num63 + num64;
				int value3 = num5 + num6 + num17 + num18 + num29 + num30 + num41 + num42 + num53 + num54 + num65 + num66;
				int value4 = num7 + num8 + num19 + num20 + num31 + num32 + num43 + num44 + num55 + num56 + num67 + num68;
				int value5 = num9 + num10 + num21 + num22 + num33 + num34 + num45 + num46 + num57 + num58 + num69 + num70;
				int value6 = num11 + num12 + num23 + num24 + num35 + num36 + num47 + num48 + num59 + num60 + num71 + num72;
				Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Int2, value);
				Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Atk2, value2);
				Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Def2, value3);
				Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Hpx2, value4);
				Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Spx2, value5);
				Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Agi2, value6);
				int num73 = Data.CongthucHP(this._My_Reborn, this._My_Job, this._My_Lv, this._My_Hpx) + this._My_Hpx2;
				if (this._My_Hp > num73)
				{
					Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Hp, num73);
				}
				Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Hpmax, num73);
				int num74 = Data.CongthucSP(this._My_Reborn, this._My_Job, this._My_Lv, this._My_Spx) + this._My_Spx2;
				if (this._My_Sp > num74)
				{
					Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Sp, num74);
				}
				Data.PlayerUpdateDataId(this._My_Id, DataStructure.Type_Player._Spmax, num74);
			}
		}
		public bool GetDKThuoctinh(int tt)
		{
			bool result = true;
			switch (this._My_Thuoctinh)
			{
			case 1:
				if (tt == 3)
				{
					result = false;
				}
				break;
			case 2:
				if (tt == 4)
				{
					result = false;
				}
				break;
			case 3:
				if (tt == 1)
				{
					result = false;
				}
				break;
			case 4:
				if (tt == 2)
				{
					result = false;
				}
				break;
			}
			return result;
		}
		public int GetPointSkillAdd(int tt_skill, int point)
		{
			int num = point;
			checked
			{
				switch (this._My_Thuoctinh)
				{
				case 1:
					if (tt_skill == 2 | tt_skill == 4)
					{
						num *= 2;
					}
					break;
				case 2:
					if (tt_skill == 1 | tt_skill == 3)
					{
						num *= 2;
					}
					break;
				case 3:
					if (tt_skill == 2 | tt_skill == 4)
					{
						num *= 2;
					}
					break;
				case 4:
					if (tt_skill == 1 | tt_skill == 3)
					{
						num *= 2;
					}
					break;
				}
				return num;
			}
		}
		public void SendSkillPointtoClient(int _count)
		{
			this.Sendpacket("F4440C0008012501" + Class5.smethod_12(_count) + "00000000");
		}
		public string GetNameSlot(int loai)
		{
			string result = "";
			switch (loai)
			{
			case 1:
				result = "Mu";
				break;
			case 2:
				result = "Ao";
				break;
			case 3:
				result = "Vukhi";
				break;
			case 4:
				result = "Tay";
				break;
			case 5:
				result = "Chan";
				break;
			case 6:
				result = "Dacthu";
				break;
			}
			return result;
		}
		public void SendMyParty()
		{
			if (this._My_IdLeader > 0 & this._My_IdLeader == this._My_Id)
			{
				if (this._My_IdMem1 > 0)
				{
					Server.SendToAllClientMapid(this._My_Id, "F4440A000D05" + Class5.smethod_12(this._My_Id) + Class5.smethod_12(this._My_IdMem1));
				}
				if (this._My_IdMem2 > 0)
				{
					Server.SendToAllClientMapid(this._My_Id, "F4440A000D05" + Class5.smethod_12(this._My_Id) + Class5.smethod_12(this._My_IdMem2));
				}
				if (this._My_IdMem3 > 0)
				{
					Server.SendToAllClientMapid(this._My_Id, "F4440A000D05" + Class5.smethod_12(this._My_Id) + Class5.smethod_12(this._My_IdMem3));
				}
				if (this._My_IdMem4 > 0)
				{
					Server.SendToAllClientMapid(this._My_Id, "F4440A000D05" + Class5.smethod_12(this._My_Id) + Class5.smethod_12(this._My_IdMem4));
				}
			}
		}
		public void GiaiTanParty(int _Idout)
		{
			if (this._My_IdLeader == 0)
			{
				return;
			}
			if (this._My_IdLeader == this._My_Id)
			{
				this.Sendpacket("F44406000D08" + Class5.smethod_12(this._My_IdQS));
				this.Sendpacket("F44406000D0C" + Class5.smethod_12(this._My_IdQS));
				Server.SendToAllClientMapid(this._My_Id, "F44406000D08" + Class5.smethod_12(this._My_IdQS));
				Server.SendToAllClientMapid(this._My_Id, "F44406000D0C" + Class5.smethod_12(this._My_IdQS));
				this._My_IdQS = 0;
				this.Sendpacket("F44405001805020000");
				this.Sendpacket("F44405001805620100");
				this.Sendpacket("F44405001805910100");
				this.Sendpacket("F44406000D04" + Class5.smethod_12(_Idout));
				if (this._My_IdBattle > 0)
				{
					try
					{
						IEnumerator enumerator = Server.TheBattles[this._My_IdBattle]._keys.GetEnumerator();
						while (enumerator.MoveNext())
						{
							string key = Conversions.ToString(enumerator.Current);
							DataStructure.WarInfo value = Server.TheBattles[this._My_IdBattle].ListWar[key];
							int id = value._Id;
							int idChar = value._IdChar;
							if (id == this._My_IdMem1 | id == this._My_IdMem2 | id == this._My_IdMem3 | id == this._My_IdMem4 | id == this._My_Id)
							{
								value._LeaderId = 0;
							}
							if (idChar == this._My_IdMem1 | idChar == this._My_IdMem2 | idChar == this._My_IdMem3 | idChar == this._My_IdMem4 | idChar == this._My_Id)
							{
								value._LeaderId = 0;
							}
							Server.TheBattles[this._My_IdBattle].ListWar[key] = value;
						}
					}
					finally
					{

					}
				}
				if (this._My_IdMem1 > 0 & Server.Clients.ContainsKey(this._My_IdMem1))
				{
					Server.Clients[this._My_IdMem1]._My_IdLeader = 0;
					Server.Clients[this._My_IdMem1]._My_IdMem1 = 0;
					Server.Clients[this._My_IdMem1]._My_IdMem2 = 0;
					Server.Clients[this._My_IdMem1]._My_IdMem3 = 0;
					Server.Clients[this._My_IdMem1]._My_IdMem4 = 0;
				}
				if (this._My_IdMem2 > 0 & Server.Clients.ContainsKey(this._My_IdMem2))
				{
					Server.Clients[this._My_IdMem2]._My_IdLeader = 0;
					Server.Clients[this._My_IdMem2]._My_IdMem1 = 0;
					Server.Clients[this._My_IdMem2]._My_IdMem2 = 0;
					Server.Clients[this._My_IdMem2]._My_IdMem3 = 0;
					Server.Clients[this._My_IdMem2]._My_IdMem4 = 0;
				}
				if (this._My_IdMem3 > 0 & Server.Clients.ContainsKey(this._My_IdMem3))
				{
					Server.Clients[this._My_IdMem3]._My_IdLeader = 0;
					Server.Clients[this._My_IdMem3]._My_IdMem1 = 0;
					Server.Clients[this._My_IdMem3]._My_IdMem2 = 0;
					Server.Clients[this._My_IdMem3]._My_IdMem3 = 0;
					Server.Clients[this._My_IdMem3]._My_IdMem4 = 0;
				}
				if (this._My_IdMem4 > 0 & Server.Clients.ContainsKey(this._My_IdMem4))
				{
					Server.Clients[this._My_IdMem4]._My_IdLeader = 0;
					Server.Clients[this._My_IdMem4]._My_IdMem1 = 0;
					Server.Clients[this._My_IdMem4]._My_IdMem2 = 0;
					Server.Clients[this._My_IdMem4]._My_IdMem3 = 0;
					Server.Clients[this._My_IdMem4]._My_IdMem4 = 0;
				}
			}
			else
			{
				if (Server.Clients.ContainsKey(this._My_IdLeader))
				{
					int my_IdMem = Server.Clients[this._My_IdLeader]._My_IdMem1;
					int my_IdMem2 = Server.Clients[this._My_IdLeader]._My_IdMem2;
					int my_IdMem3 = Server.Clients[this._My_IdLeader]._My_IdMem3;
					int my_IdMem4 = Server.Clients[this._My_IdLeader]._My_IdMem4;
					if (my_IdMem == this._My_Id)
					{
						Server.Clients[this._My_IdLeader]._My_IdMem1 = 0;
					}
					if (my_IdMem2 == this._My_Id)
					{
						Server.Clients[this._My_IdLeader]._My_IdMem2 = 0;
					}
					if (my_IdMem3 == this._My_Id)
					{
						Server.Clients[this._My_IdLeader]._My_IdMem3 = 0;
					}
					if (my_IdMem4 == this._My_Id)
					{
						Server.Clients[this._My_IdLeader]._My_IdMem4 = 0;
					}
					my_IdMem = Server.Clients[this._My_IdLeader]._My_IdMem1;
					my_IdMem2 = Server.Clients[this._My_IdLeader]._My_IdMem2;
					my_IdMem3 = Server.Clients[this._My_IdLeader]._My_IdMem3;
					my_IdMem4 = Server.Clients[this._My_IdLeader]._My_IdMem4;
					if (my_IdMem == 0 & my_IdMem2 == 0 & my_IdMem3 == 0 & my_IdMem4 == 0)
					{
						Server.SendToClient(this._My_IdLeader, "F44406000D08" + Class5.smethod_12(this._My_IdQS));
						Server.SendToClient(this._My_IdLeader, "F44406000D0C" + Class5.smethod_12(this._My_IdQS));
						Server.SendToAllClientMapid(this._My_IdLeader, "F44406000D08" + Class5.smethod_12(this._My_IdQS));
						Server.SendToAllClientMapid(this._My_IdLeader, "F44406000D0C" + Class5.smethod_12(this._My_IdQS));
						Server.Clients[this._My_IdLeader]._My_IdQS = 0;
						Server.Clients[this._My_IdLeader]._My_IdLeader = 0;
						Server.SendToClient(this._My_IdLeader, "F44405001805020000");
						Server.SendToClient(this._My_IdLeader, "F44405001805620100");
						Server.SendToClient(this._My_IdLeader, "F44405001805910100");
						Server.SendToClient(this._My_IdLeader, "F44406000D04" + Class5.smethod_12(this._My_IdLeader));
						this.Sendpacket("F44406000D04" + Class5.smethod_12(this._My_IdLeader));
						Server.SendToAllClientMapid(this._My_Id, "F44406000D04" + Class5.smethod_12(this._My_IdLeader));
					}
					if (this._My_IdMem1 != this._My_Id & this._My_IdMem1 > 0 & Server.Clients.ContainsKey(this._My_IdMem1))
					{
						Client client = Server.Clients[this._My_IdMem1];
						if (client._My_IdMem1 == this._My_Id)
						{
							Server.Clients[this._My_IdMem1]._My_IdMem1 = 0;
						}
						if (client._My_IdMem2 == this._My_Id)
						{
							Server.Clients[this._My_IdMem1]._My_IdMem2 = 0;
						}
						if (client._My_IdMem3 == this._My_Id)
						{
							Server.Clients[this._My_IdMem1]._My_IdMem3 = 0;
						}
						if (client._My_IdMem4 == this._My_Id)
						{
							Server.Clients[this._My_IdMem1]._My_IdMem4 = 0;
						}
					}
					if (this._My_IdMem2 != this._My_Id & this._My_IdMem2 > 0 & Server.Clients.ContainsKey(this._My_IdMem2))
					{
						Client client2 = Server.Clients[this._My_IdMem2];
						if (client2._My_IdMem1 == this._My_Id)
						{
							Server.Clients[this._My_IdMem2]._My_IdMem1 = 0;
						}
						if (client2._My_IdMem2 == this._My_Id)
						{
							Server.Clients[this._My_IdMem2]._My_IdMem2 = 0;
						}
						if (client2._My_IdMem3 == this._My_Id)
						{
							Server.Clients[this._My_IdMem2]._My_IdMem3 = 0;
						}
						if (client2._My_IdMem4 == this._My_Id)
						{
							Server.Clients[this._My_IdMem2]._My_IdMem4 = 0;
						}
					}
					if (this._My_IdMem3 != this._My_Id & this._My_IdMem3 > 0 & Server.Clients.ContainsKey(this._My_IdMem3))
					{
						Client client3 = Server.Clients[this._My_IdMem3];
						if (client3._My_IdMem1 == this._My_Id)
						{
							Server.Clients[this._My_IdMem3]._My_IdMem1 = 0;
						}
						if (client3._My_IdMem2 == this._My_Id)
						{
							Server.Clients[this._My_IdMem3]._My_IdMem2 = 0;
						}
						if (client3._My_IdMem3 == this._My_Id)
						{
							Server.Clients[this._My_IdMem3]._My_IdMem3 = 0;
						}
						if (client3._My_IdMem4 == this._My_Id)
						{
							Server.Clients[this._My_IdMem3]._My_IdMem4 = 0;
						}
					}
					if (this._My_IdMem4 != this._My_Id & this._My_IdMem4 > 0 & Server.Clients.ContainsKey(this._My_IdMem4))
					{
						Client client4 = Server.Clients[this._My_IdMem4];
						if (client4._My_IdMem1 == this._My_Id)
						{
							Server.Clients[this._My_IdMem4]._My_IdMem1 = 0;
						}
						if (client4._My_IdMem2 == this._My_Id)
						{
							Server.Clients[this._My_IdMem4]._My_IdMem2 = 0;
						}
						if (client4._My_IdMem3 == this._My_Id)
						{
							Server.Clients[this._My_IdMem4]._My_IdMem3 = 0;
						}
						if (client4._My_IdMem4 == this._My_Id)
						{
							Server.Clients[this._My_IdMem4]._My_IdMem4 = 0;
						}
					}
					this.Sendpacket("F44406000D08" + Class5.smethod_12(this._My_IdQS));
					this.Sendpacket("F44406000D0C" + Class5.smethod_12(this._My_IdQS));
					Server.SendToAllClientMapid(this._My_Id, "F44406000D08" + Class5.smethod_12(this._My_IdQS));
					Server.SendToAllClientMapid(this._My_Id, "F44406000D0C" + Class5.smethod_12(this._My_IdQS));
					this._My_IdQS = 0;
					this.Sendpacket("F44405001805020000");
					this.Sendpacket("F44405001805620100");
					this.Sendpacket("F44405001805910100");
					this.Sendpacket("F44406000D04" + Class5.smethod_12(this._My_Id));
				}
			}
			Server.SendToAllClientMapid(this._My_Id, "F44406000D04" + Class5.smethod_12(this._My_Id));
			this._My_IdLeader = 0;
			this._My_IdMem1 = 0;
			this._My_IdMem2 = 0;
			this._My_IdMem3 = 0;
			this._My_IdMem4 = 0;
		}
		public void PartySendStatus(int _IdSend, int _Id)
		{
			Server.SendToClient(_IdSend, string.Concat(new string[]
			{
				"F44410000803",
				Class5.smethod_12(_Id),
				"1901",
				Class5.smethod_12(this._My_Hp),
				"00000000"
			}));
			Server.SendToClient(_IdSend, string.Concat(new string[]
			{
				"F44410000803",
				Class5.smethod_12(_Id),
				"1F01",
				Class5.smethod_12(this._My_Hpx),
				"00000000"
			}));
			Server.SendToClient(_IdSend, "F44410000803" + Class5.smethod_12(_Id) + "D7010000000000000000");
			Server.SendToClient(_IdSend, string.Concat(new string[]
			{
				"F44410000803",
				Class5.smethod_12(_Id),
				"CF01",
				Class5.smethod_12(this._My_Hpx2),
				"00000000"
			}));
		}
		public void Walked(int _Id, int _x, int _y, int _gocnhin)
		{
			Data.PlayerUpdateDataId(_Id, DataStructure.Type_Player._Gocnhin, _gocnhin);
			Data.PlayerUpdateDataId(_Id, DataStructure.Type_Player._MapX, _x);
			Data.PlayerUpdateDataId(_Id, DataStructure.Type_Player._MapY, _y);
			Server.SendToAllClientMapid(_Id, string.Concat(new string[]
			{
				"F4440B000601",
				Class5.smethod_12(_Id),
				_gocnhin.ToString("X2"),
				Class5.smethod_11(_x),
				Class5.smethod_11(_y)
			}));
		}
		public void WrongPass()
		{
			this.Sendpacket("F44402000106");
		}
		public void CreatChar()
		{
			this.Sendpacket("F4440300010300");
		}
		public void CreatedCharName()
		{
			this.Sendpacket("F4440300090300");
		}
		public void CreatChar_NameUsed()
		{
			this.Sendpacket("F4440300090301");
		}
		public void CreatedCharacter()
		{
			this.Sendpacket("F44402000901");
		}
		public int GetRandomMapY(int _Y)
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
			return this.RandomizeArray(items);
		}
		public int GetRandomMapX(int _X)
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
			return this.RandomizeArray(items);
		}
		public int RandomizeArray(int[] items)
		{
			int maxValue = checked(items.Length - 1);
			return items[this.random_0.Next(0, maxValue)];
		}
		[DebuggerStepThrough, CompilerGenerated]
		private void varLambda__1(object a0)
		{
			this.UpdateMainGrid_Recv((byte[])a0);
		}
	}
}
