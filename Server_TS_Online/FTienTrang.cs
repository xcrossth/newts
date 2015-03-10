using System;
namespace Server_TS_Online
{
	public class FTienTrang
	{
		public static void H1(Client _client, byte[] packet)
		{
			int num = Class5.smethod_10(new byte[]
			{
				packet[6],
				packet[7],
				packet[8],
				packet[9]
			});
			int my_Gold = _client._My_Gold;
			int num2 = Data.TienTrangGetDataMoney(_client.conn);
			checked
			{
				if (num2 >= num && my_Gold + num <= 9999999)
				{
					Data.PlayerUpdateDataId(_client._My_Id, DataStructure.Type_Player._GOld, my_Gold + num);
					Data.TienTrangUpdateMoney(_client.conn, num2 - num);
					_client.Sendpacket("F44406001D02" + Class5.smethod_12(num));
					_client.Sendpacket("F44406001A01" + Class5.smethod_12(num));
				}
			}
		}
		public static void H2(Client _client, byte[] packet)
		{
			int num = Class5.smethod_10(new byte[]
			{
				packet[6],
				packet[7],
				packet[8],
				packet[9]
			});
			int my_Gold = _client._My_Gold;
			int num2 = Data.TienTrangGetDataMoney(_client.conn);
			checked
			{
				if (my_Gold >= num && num2 + num <= 9999999)
				{
					Data.PlayerUpdateDataId(_client._My_Id, DataStructure.Type_Player._GOld, my_Gold - num);
					Data.TienTrangUpdateMoney(_client.conn, num2 + num);
					_client.Sendpacket("F44406001D01" + Class5.smethod_12(num));
					_client.Sendpacket("F44406001A02" + Class5.smethod_12(num));
				}
			}
		}
	}
}
