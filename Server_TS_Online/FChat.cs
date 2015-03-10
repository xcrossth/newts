using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Text;
namespace Server_TS_Online
{
	public class FChat
	{
		public static void H2(int _id, byte[] packet)
		{
			checked
			{
				byte[] array = new byte[packet.Length - 7 + 1];
				Array.Copy(packet, 6, array, 0, packet.Length - 6);
				string text = Strings.LCase(Encoding.ASCII.GetString(array));
				if (text.Length <= 60)
				{
					if (text.StartsWith("/additem"))
					{
						if (text.Length >= 13)
						{
							try
							{
								int iD = Conversions.ToInteger(text.Substring(9, 5));
								if (text.Contains(","))
								{
									if (text.Length >= 15)
									{
										if (Operators.CompareString(text.Substring(14, 1), ",", false) == 0)
										{
											int num = Conversions.ToInteger(text.Substring(15));
											if (num <= 50)
											{
												Data.HomdoAddItem(_id, iD, num);
											}
										}
									}
								}
								else
								{
									Data.HomdoAddItem(_id, iD, 1);
								}
							}
							catch (Exception expr_BC)
							{
								ProjectData.SetProjectError(expr_BC);
								ProjectData.ClearProjectError();
							}
							return;
						}
					}
					else
					{
						if (text.StartsWith("/addpet"))
						{
							try
							{
								if (text.Length >= 12)
								{
									int id = Conversions.ToInteger(text.Substring(8, 5));
									Data.Addpet(_id, id);
								}
								return;
							}
							catch (Exception expr_FB)
							{
								ProjectData.SetProjectError(expr_FB);
								ProjectData.ClearProjectError();
								return;
							}
						}
						if (text.StartsWith("/sleep"))
						{
							try
							{
								Server.Clients[_id].Sleep();
								return;
							}
							catch (Exception expr_128)
							{
								ProjectData.SetProjectError(expr_128);
								ProjectData.ClearProjectError();
								return;
							}
						}
						if (Data.TrangbiGetDataItem(Server.Clients[_id].conn, 6, DataStructure.Type_Homdo._ID) == 23100)
						{
							FChat.Toan(_id, array);
						}
						else
						{
							FChat.Gan(_id, array);
						}
					}
				}
			}
		}
		public static void H3(int _id, byte[] packet)
		{
			int idFrom = Class5.smethod_10(new byte[]
			{
				packet[6],
				packet[7],
				packet[8],
				packet[9]
			});
			byte[] array = new byte[checked(packet.Length - 11 + 1)];
			Array.Copy(packet, 10, array, 0, array.Length);
			string @string = Encoding.ASCII.GetString(array);
			if (@string.Length <= 60)
			{
				FChat.ThiTham(_id, idFrom, array);
			}
		}
		public static void H5(int _id, byte[] packet)
		{
			Class5.smethod_10(new byte[]
			{
				packet[6],
				packet[7],
				packet[8],
				packet[9]
			});
			byte[] array = new byte[checked(packet.Length - 7 + 1)];
			Array.Copy(packet, 6, array, 0, array.Length);
			string @string = Encoding.ASCII.GetString(array);
			if (@string.Length <= 60)
			{
				FChat.Doi(_id, array);
			}
		}
		public static void Toan(int _id, byte[] chat)
		{
			Server.SendToAllClient(_id, string.Concat(new string[]
			{
				DataStructure.Packet._Header,
				Class5.smethod_11(checked(6 + chat.Length)),
				"0201",
				Class5.smethod_12(_id),
				Class5.smethod_3(chat)
			}));
		}
		public static void Gan(int _id, byte[] chat)
		{
			Server.SendToAllClientMapid(_id, string.Concat(new string[]
			{
				DataStructure.Packet._Header,
				Class5.smethod_11(checked(6 + chat.Length)),
				"0202",
				Class5.smethod_12(_id),
				Class5.smethod_3(chat)
			}));
		}
		public static void ThiTham(int _idTo, int _idFrom, byte[] chat)
		{
			checked
			{
				Server.SendToClient(_idTo, string.Concat(new string[]
				{
					DataStructure.Packet._Header,
					Class5.smethod_11(6 + chat.Length),
					"0203",
					Class5.smethod_12(_idTo),
					Class5.smethod_3(chat)
				}));
				Server.SendToClient(_idFrom, string.Concat(new string[]
				{
					DataStructure.Packet._Header,
					Class5.smethod_11(6 + chat.Length),
					"0203",
					Class5.smethod_12(_idTo),
					Class5.smethod_3(chat)
				}));
			}
		}
		public static void Doi(int _id, byte[] chat)
		{
			string packet = string.Concat(new string[]
			{
				"F444",
				Class5.smethod_11(checked(6 + chat.Length)),
				"0205",
				Class5.smethod_12(_id),
				Class5.smethod_3(chat)
			});
			int my_IdLeader = Server.Clients[_id]._My_IdLeader;
			int my_IdMem = Server.Clients[_id]._My_IdMem1;
			int my_IdMem2 = Server.Clients[_id]._My_IdMem2;
			int my_IdMem3 = Server.Clients[_id]._My_IdMem3;
			int my_IdMem4 = Server.Clients[_id]._My_IdMem4;
			if (my_IdLeader > 0)
			{
				Server.SendToClient(my_IdLeader, packet);
			}
			if (my_IdMem > 0)
			{
				Server.SendToClient(my_IdMem, packet);
			}
			if (my_IdMem2 > 0)
			{
				Server.SendToClient(my_IdMem2, packet);
			}
			if (my_IdMem3 > 0)
			{
				Server.SendToClient(my_IdMem3, packet);
			}
			if (my_IdMem4 > 0)
			{
				Server.SendToClient(my_IdMem4, packet);
			}
		}
	}
}
