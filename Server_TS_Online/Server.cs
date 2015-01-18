using JuneNameSpace1;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Server()
		{
			JuneClass02.UUCbAVAAM();
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
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Server()
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ServerSend_PlayerOffline(int _id)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ServerSend_PlayerOnline(int ID, int sex, int Thuoctinh, int lv, int ghost, int god, int mapid, int mapx, int mapy, int gocnhin, int hair, string color, int mu, int ao, int vukhi, int tay, int chan, int dacthu, int reborn, int job, string name, int IdPetXuatChien, int Pk, int ThamChien)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ServerSend_PlayerGotoMap(int _id, int MapidTo, int x, int y, int gocnhin)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ServerSend_EquitItem(int _id, int iditem)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ServerSend_UnEquitItem(int _id, int iditem)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SendPalyerOnline(int _id)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SendPlayerOnMap(int _id)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SendAllParty(int _id)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SendToServer(string packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SendToClient(int _Id, string packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SendToAllClient(int _id, string packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SendToAllClientMapid(int _Id, string packet)
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SendToAllMapid(int _MapId, string packet)
		{
		}
	}
}
