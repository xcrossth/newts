using System;
namespace Server_TS_Online
{
	public class FWalk
	{
		public static void H1(Client _client, byte[] packet)
		{
			if (_client._My_IdBattle > 0)
			{
				return;
			}
			if (_client._My_IdLeader > 0)
			{
				if (_client._My_IdLeader == _client._My_Id)
				{
					int gocnhin = (int)packet[6];
					int x = Class5.smethod_9(new byte[]
					{
						packet[7],
						packet[8]
					});
					int y = Class5.smethod_9(new byte[]
					{
						packet[9],
						packet[10]
					});
					Class5.smethod_3(new byte[]
					{
						packet[11],
						packet[12]
					});
					_client.Walked(_client._My_IdLeader, x, y, gocnhin);
					if (_client._My_IdMem1 > 0)
					{
						_client.Walked(_client._My_IdMem1, x, y, gocnhin);
					}
					if (_client._My_IdMem2 > 0)
					{
						_client.Walked(_client._My_IdMem2, x, y, gocnhin);
					}
					if (_client._My_IdMem3 > 0)
					{
						_client.Walked(_client._My_IdMem3, x, y, gocnhin);
					}
					if (_client._My_IdMem4 > 0)
					{
						_client.Walked(_client._My_IdMem4, x, y, gocnhin);
					}
				}
			}
			else
			{
				int gocnhin2 = (int)packet[6];
				int x2 = Class5.smethod_9(new byte[]
				{
					packet[7],
					packet[8]
				});
				int y2 = Class5.smethod_9(new byte[]
				{
					packet[9],
					packet[10]
				});
				Class5.smethod_3(new byte[]
				{
					packet[11],
					packet[12]
				});
				_client.Walked(_client._My_Id, x2, y2, gocnhin2);
			}
		}
	}
}
