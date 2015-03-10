using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
namespace Server_TS_Online
{
	[DesignerGenerated]
	public class FormServer : Form
	{
		public delegate void _AddClient(Socket client);
		private delegate void Delegate0(ListView listView_0);
		private IContainer icontainer_0;
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;
		[AccessedThroughProperty("IDDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
		[AccessedThroughProperty("NameDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
		[AccessedThroughProperty("LVDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
		[AccessedThroughProperty("HPDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
		[AccessedThroughProperty("HPMaxDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
		[AccessedThroughProperty("SPDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
		[AccessedThroughProperty("SPMaxDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
		[AccessedThroughProperty("EXPDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
		[AccessedThroughProperty("EXPMaxDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
		[AccessedThroughProperty("SkillPointDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
		[AccessedThroughProperty("SkillDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
		[AccessedThroughProperty("IntDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
		[AccessedThroughProperty("AtkDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
		[AccessedThroughProperty("DefDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
		[AccessedThroughProperty("HpxDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;
		[AccessedThroughProperty("SpxDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;
		[AccessedThroughProperty("AgiDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;
		[AccessedThroughProperty("MapIdDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;
		[AccessedThroughProperty("MapXDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;
		[AccessedThroughProperty("MapYDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn FiNajqvdU;
		[AccessedThroughProperty("RebornDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;
		[AccessedThroughProperty("TExpDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;
		[AccessedThroughProperty("SexDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;
		[AccessedThroughProperty("HairDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;
		[AccessedThroughProperty("ThuoctinhDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;
		[AccessedThroughProperty("GhostDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;
		[AccessedThroughProperty("GodDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;
		[AccessedThroughProperty("ColorDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;
		[AccessedThroughProperty("GoldDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;
		[AccessedThroughProperty("PointDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;
		[AccessedThroughProperty("TiengtamDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;
		[AccessedThroughProperty("Int2DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;
		[AccessedThroughProperty("Atk2DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;
		[AccessedThroughProperty("Def2DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn aygulJulA;
		[AccessedThroughProperty("Hpx2DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;
		[AccessedThroughProperty("Spx2DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;
		[AccessedThroughProperty("Agi2DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;
		[AccessedThroughProperty("GocNhinDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;
		[AccessedThroughProperty("JobDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;
		[AccessedThroughProperty("Hp2DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;
		[AccessedThroughProperty("Sp2DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;
		[AccessedThroughProperty("Button_CreatAccount")]
		private Button _Button_CreatAccount;
		[AccessedThroughProperty("MapId1DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;
		[AccessedThroughProperty("WarpIdDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;
		[AccessedThroughProperty("MapId2DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;
		[AccessedThroughProperty("XDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;
		[AccessedThroughProperty("YDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;
		[AccessedThroughProperty("TabControl1")]
		private TabControl _TabControl1;
		[AccessedThroughProperty("TabPage_Main")]
		private TabPage _TabPage_Main;
		[AccessedThroughProperty("TabPage_Data")]
		private TabPage _TabPage_Data;
		[AccessedThroughProperty("TabControl_Data")]
		private TabControl _TabControl_Data;
		[AccessedThroughProperty("TabPage_Npc")]
		private TabPage _TabPage_Npc;
		[AccessedThroughProperty("TabPage_Item")]
		private TabPage _TabPage_Item;
		[AccessedThroughProperty("TabPage_Skill")]
		private TabPage _TabPage_Skill;
		[AccessedThroughProperty("TabPage_Warp")]
		private TabPage _TabPage_Warp;
		[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;
		[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;
		[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;
		[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;
		[AccessedThroughProperty("DataGridViewTextBoxColumn5")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;
		[AccessedThroughProperty("IdDK1DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;
		[AccessedThroughProperty("IdDK2DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;
		[AccessedThroughProperty("IdDK3DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;
		[AccessedThroughProperty("IdDK4DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;
		[AccessedThroughProperty("IdDK5DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;
		[AccessedThroughProperty("LvMaxDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;
		[AccessedThroughProperty("TypeDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;
		[AccessedThroughProperty("DoManhDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;
		[AccessedThroughProperty("SLDanhDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;
		[AccessedThroughProperty("DataGridViewTextBoxColumn6")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;
		[AccessedThroughProperty("ComboDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;
		[AccessedThroughProperty("DelayDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;
		[AccessedThroughProperty("TroiBuffDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;
		[AccessedThroughProperty("Button_ServerChat")]
		private Button _Button_ServerChat;
		[AccessedThroughProperty("RichTextBox1")]
		private RichTextBox _RichTextBox1;
		[AccessedThroughProperty("TabControl2")]
		private TabControl _TabControl2;
		[AccessedThroughProperty("TabPage_Account")]
		private TabPage _TabPage_Account;
		[AccessedThroughProperty("TabPage_Online")]
		private TabPage _TabPage_Online;
		[AccessedThroughProperty("Button_ServerOff")]
		private Button _Button_ServerOff;
		[AccessedThroughProperty("GroupBox_SettingServer")]
		private GroupBox _GroupBox_SettingServer;
		[AccessedThroughProperty("Button_PerExp")]
		private Button ockKnLaIrn;
		[AccessedThroughProperty("NumericUpDown_PerExp")]
		private NumericUpDown _NumericUpDown_PerExp;
		[AccessedThroughProperty("Label5")]
		private Label _Label5;
		[AccessedThroughProperty("Label_Online")]
		private Label _Label_Online;
		[AccessedThroughProperty("StatusStrip1")]
		private StatusStrip _StatusStrip1;
		[AccessedThroughProperty("ToolStripStatusLabel3")]
		private ToolStripStatusLabel _ToolStripStatusLabel3;
		[AccessedThroughProperty("ListView_Client")]
		private ListView _ListView_Client;
		[AccessedThroughProperty("ID")]
		private ColumnHeader columnHeader_0;
		[AccessedThroughProperty("IP")]
		private ColumnHeader columnHeader_1;
		[AccessedThroughProperty("PlayerName")]
		private ColumnHeader columnHeader_2;
		[AccessedThroughProperty("Timer1")]
		private System.Windows.Forms.Timer timer_0;
		[AccessedThroughProperty("DataGridViewTextBoxColumn7")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;
		[AccessedThroughProperty("Pass1DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;
		[AccessedThroughProperty("Pass2DataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;
		[AccessedThroughProperty("ToolStripStatusLabel1")]
		private ToolStripStatusLabel _ToolStripStatusLabel1;
		[AccessedThroughProperty("ListView_Account")]
		private ListView _ListView_Account;
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader columnHeader_3;
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader columnHeader_4;
		[AccessedThroughProperty("ColumnHeader3")]
		private ColumnHeader columnHeader_5;
		[AccessedThroughProperty("RichTextBox2")]
		private RichTextBox _RichTextBox2;
		[AccessedThroughProperty("ListView_Npc")]
		private ListView _ListView_Npc;
		[AccessedThroughProperty("ColumnHeader4")]
		private ColumnHeader columnHeader_6;
		[AccessedThroughProperty("ColumnHeader5")]
		private ColumnHeader columnHeader_7;
		[AccessedThroughProperty("ColumnHeader6")]
		private ColumnHeader columnHeader_8;
		[AccessedThroughProperty("ColumnHeader7")]
		private ColumnHeader columnHeader_9;
		[AccessedThroughProperty("ColumnHeader8")]
		private ColumnHeader columnHeader_10;
		[AccessedThroughProperty("ColumnHeader9")]
		private ColumnHeader columnHeader_11;
		[AccessedThroughProperty("ColumnHeader10")]
		private ColumnHeader columnHeader_12;
		[AccessedThroughProperty("ColumnHeader11")]
		private ColumnHeader columnHeader_13;
		[AccessedThroughProperty("ColumnHeader12")]
		private ColumnHeader columnHeader_14;
		[AccessedThroughProperty("ColumnHeader13")]
		private ColumnHeader columnHeader_15;
		[AccessedThroughProperty("ColumnHeader14")]
		private ColumnHeader columnHeader_16;
		[AccessedThroughProperty("ColumnHeader15")]
		private ColumnHeader columnHeader_17;
		[AccessedThroughProperty("ColumnHeader16")]
		private ColumnHeader columnHeader_18;
		[AccessedThroughProperty("ColumnHeader17")]
		private ColumnHeader columnHeader_19;
		[AccessedThroughProperty("ColumnHeader18")]
		private ColumnHeader columnHeader_20;
		[AccessedThroughProperty("ColumnHeader19")]
		private ColumnHeader columnHeader_21;
		[AccessedThroughProperty("Button_LoadNpc")]
		private Button _Button_LoadNpc;
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;
		[AccessedThroughProperty("ListView_Item")]
		private ListView _ListView_Item;
		[AccessedThroughProperty("ColumnHeader20")]
		private ColumnHeader columnHeader_22;
		[AccessedThroughProperty("ColumnHeader21")]
		private ColumnHeader columnHeader_23;
		[AccessedThroughProperty("ColumnHeader22")]
		private ColumnHeader columnHeader_24;
		[AccessedThroughProperty("ColumnHeader23")]
		private ColumnHeader columnHeader_25;
		[AccessedThroughProperty("ColumnHeader24")]
		private ColumnHeader columnHeader_26;
		[AccessedThroughProperty("ColumnHeader25")]
		private ColumnHeader columnHeader_27;
		[AccessedThroughProperty("ColumnHeader26")]
		private ColumnHeader columnHeader_28;
		[AccessedThroughProperty("ColumnHeader27")]
		private ColumnHeader columnHeader_29;
		[AccessedThroughProperty("ColumnHeader28")]
		private ColumnHeader columnHeader_30;
		[AccessedThroughProperty("ColumnHeader29")]
		private ColumnHeader columnHeader_31;
		[AccessedThroughProperty("ColumnHeader30")]
		private ColumnHeader columnHeader_32;
		[AccessedThroughProperty("ColumnHeader31")]
		private ColumnHeader columnHeader_33;
		[AccessedThroughProperty("ColumnHeader32")]
		private ColumnHeader columnHeader_34;
		[AccessedThroughProperty("ColumnHeader33")]
		private ColumnHeader columnHeader_35;
		[AccessedThroughProperty("ColumnHeader34")]
		private ColumnHeader columnHeader_36;
		[AccessedThroughProperty("ColumnHeader35")]
		private ColumnHeader columnHeader_37;
		[AccessedThroughProperty("Button__LoadItem")]
		private Button _Button__LoadItem;
		[AccessedThroughProperty("ColumnHeader37")]
		private ColumnHeader columnHeader_38;
		[AccessedThroughProperty("ColumnHeader36")]
		private ColumnHeader columnHeader_39;
		[AccessedThroughProperty("ColumnHeader38")]
		private ColumnHeader columnHeader_40;
		[AccessedThroughProperty("ColumnHeader39")]
		private ColumnHeader columnHeader_41;
		[AccessedThroughProperty("ColumnHeader40")]
		private ColumnHeader columnHeader_42;
		[AccessedThroughProperty("ColumnHeader41")]
		private ColumnHeader columnHeader_43;
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;
		[AccessedThroughProperty("RichTextBox3")]
		private RichTextBox _RichTextBox3;
		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser _WebBrowser1;
		private Socket socket_0;
		private Delegate delegate_0;
		private ColumnHeader columnHeader_44;
		private Delegate delegate_1;
		internal virtual Panel Panel1
		{
			get
			{
				return this._Panel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}
		internal virtual GroupBox GroupBox1
		{
			get
			{
				return this._GroupBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_0 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn NameDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_1 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn LVDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_2 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn HPDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_3 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn HPMaxDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_4 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn SPDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_5 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn SPMaxDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_6 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn EXPDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_7 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn EXPMaxDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_8 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn SkillPointDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_9 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn SkillDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_10 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn IntDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_11 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn AtkDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_12 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn DefDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_13 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn HpxDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_14 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn SpxDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_15;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_15 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn AgiDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_16;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_16 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn MapIdDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_17;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_17 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn MapXDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_18;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_18 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn MapYDataGridViewTextBoxColumn
		{
			get
			{
				return this.FiNajqvdU;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.FiNajqvdU = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn RebornDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_19;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_19 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn TExpDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_20;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_20 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn SexDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_21;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_21 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn HairDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_22;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_22 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn ThuoctinhDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_23;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_23 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn GhostDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_24;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_24 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn GodDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_25;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_25 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn ColorDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_26;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_26 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn GoldDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_27;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_27 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn PointDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_28;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_28 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn TiengtamDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_29;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_29 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn Int2DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_30;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_30 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn Atk2DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_31;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_31 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn Def2DataGridViewTextBoxColumn
		{
			get
			{
				return this.aygulJulA;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.aygulJulA = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn Hpx2DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_32;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_32 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn Spx2DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_33;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_33 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn Agi2DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_34;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_34 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn GocNhinDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_35;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_35 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn JobDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_36;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_36 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn Hp2DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_37;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_37 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn Sp2DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_38;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_38 = value;
			}
		}
		internal virtual Button Button_CreatAccount
		{
			get
			{
				return this._Button_CreatAccount;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button_CreatAccount_Click);
				if (this._Button_CreatAccount != null)
				{
					this._Button_CreatAccount.Click -= value2;
				}
				this._Button_CreatAccount = value;
				if (this._Button_CreatAccount != null)
				{
					this._Button_CreatAccount.Click += value2;
				}
			}
		}
		internal virtual DataGridViewTextBoxColumn MapId1DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_39;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_39 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn WarpIdDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_40;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_40 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn MapId2DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_41;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_41 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn XDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_42;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_42 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn YDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_43;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_43 = value;
			}
		}
		internal virtual TabControl TabControl1
		{
			get
			{
				return this._TabControl1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabControl1 = value;
			}
		}
		internal virtual TabPage TabPage_Main
		{
			get
			{
				return this._TabPage_Main;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage_Main = value;
			}
		}
		internal virtual TabPage TabPage_Data
		{
			get
			{
				return this._TabPage_Data;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage_Data = value;
			}
		}
		internal virtual TabControl TabControl_Data
		{
			get
			{
				return this._TabControl_Data;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabControl_Data = value;
			}
		}
		internal virtual TabPage TabPage_Npc
		{
			get
			{
				return this._TabPage_Npc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage_Npc = value;
			}
		}
		internal virtual TabPage TabPage_Item
		{
			get
			{
				return this._TabPage_Item;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage_Item = value;
			}
		}
		internal virtual TabPage TabPage_Skill
		{
			get
			{
				return this._TabPage_Skill;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage_Skill = value;
			}
		}
		internal virtual TabPage TabPage_Warp
		{
			get
			{
				return this._TabPage_Warp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage_Warp = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
		{
			get
			{
				return this.dataGridViewTextBoxColumn_44;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_44 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
		{
			get
			{
				return this.dataGridViewTextBoxColumn_45;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_45 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
		{
			get
			{
				return this.dataGridViewTextBoxColumn_46;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_46 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
		{
			get
			{
				return this.dataGridViewTextBoxColumn_47;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_47 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
		{
			get
			{
				return this.dataGridViewTextBoxColumn_48;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_48 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn IdDK1DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_49;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_49 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn IdDK2DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_50;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_50 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn IdDK3DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_51;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_51 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn IdDK4DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_52;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_52 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn IdDK5DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_53;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_53 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn LvMaxDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_54;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_54 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn TypeDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_55;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_55 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn DoManhDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_56;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_56 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn SLDanhDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_57;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_57 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
		{
			get
			{
				return this.dataGridViewTextBoxColumn_58;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_58 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn ComboDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_59;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_59 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn DelayDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_60;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_60 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn TroiBuffDataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_61;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_61 = value;
			}
		}
		internal virtual Button Button_ServerChat
		{
			get
			{
				return this._Button_ServerChat;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button_ServerChat_Click);
				if (this._Button_ServerChat != null)
				{
					this._Button_ServerChat.Click -= value2;
				}
				this._Button_ServerChat = value;
				if (this._Button_ServerChat != null)
				{
					this._Button_ServerChat.Click += value2;
				}
			}
		}
		internal virtual RichTextBox RichTextBox1
		{
			get
			{
				return this._RichTextBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RichTextBox1 = value;
			}
		}
		internal virtual TabControl TabControl2
		{
			get
			{
				return this._TabControl2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TabControl2_SelectedIndexChanged);
				if (this._TabControl2 != null)
				{
					this._TabControl2.SelectedIndexChanged -= value2;
				}
				this._TabControl2 = value;
				if (this._TabControl2 != null)
				{
					this._TabControl2.SelectedIndexChanged += value2;
				}
			}
		}
		internal virtual TabPage TabPage_Account
		{
			get
			{
				return this._TabPage_Account;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage_Account = value;
			}
		}
		internal virtual TabPage TabPage_Online
		{
			get
			{
				return this._TabPage_Online;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage_Online = value;
			}
		}
		internal virtual Button Button_ServerOff
		{
			get
			{
				return this._Button_ServerOff;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button_ServerOff_Click);
				if (this._Button_ServerOff != null)
				{
					this._Button_ServerOff.Click -= value2;
				}
				this._Button_ServerOff = value;
				if (this._Button_ServerOff != null)
				{
					this._Button_ServerOff.Click += value2;
				}
			}
		}
		internal virtual GroupBox GroupBox_SettingServer
		{
			get
			{
				return this._GroupBox_SettingServer;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox_SettingServer = value;
			}
		}
		internal virtual Button Button_PerExp
		{
			get
			{
				return this.ockKnLaIrn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cvkmaHgvB);
				if (this.ockKnLaIrn != null)
				{
					this.ockKnLaIrn.Click -= value2;
				}
				this.ockKnLaIrn = value;
				if (this.ockKnLaIrn != null)
				{
					this.ockKnLaIrn.Click += value2;
				}
			}
		}
		internal virtual NumericUpDown NumericUpDown_PerExp
		{
			get
			{
				return this._NumericUpDown_PerExp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown_PerExp = value;
			}
		}
		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}
		internal virtual Label Label_Online
		{
			get
			{
				return this._Label_Online;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_Online = value;
			}
		}
		internal virtual StatusStrip StatusStrip1
		{
			get
			{
				return this._StatusStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StatusStrip1 = value;
			}
		}
		internal virtual ToolStripStatusLabel ToolStripStatusLabel3
		{
			get
			{
				return this._ToolStripStatusLabel3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripStatusLabel3 = value;
			}
		}
		internal virtual ListView ListView_Client
		{
			get
			{
				return this._ListView_Client;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ListView_Client = value;
			}
		}
		internal virtual ColumnHeader ID
		{
			get
			{
				return this.columnHeader_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_0 = value;
			}
		}
		internal virtual ColumnHeader IP
		{
			get
			{
				return this.columnHeader_1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_1 = value;
			}
		}
		internal virtual ColumnHeader PlayerName
		{
			get
			{
				return this.columnHeader_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_2 = value;
			}
		}
		internal virtual System.Windows.Forms.Timer Timer1
		{
			get
			{
				return this.timer_0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				if (this.timer_0 != null)
				{
					this.timer_0.Tick -= value2;
				}
				this.timer_0 = value;
				if (this.timer_0 != null)
				{
					this.timer_0.Tick += value2;
				}
			}
		}
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
		{
			get
			{
				return this._DataGridViewTextBoxColumn7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridViewTextBoxColumn7 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn Pass1DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_62;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_62 = value;
			}
		}
		internal virtual DataGridViewTextBoxColumn Pass2DataGridViewTextBoxColumn
		{
			get
			{
				return this.dataGridViewTextBoxColumn_63;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.dataGridViewTextBoxColumn_63 = value;
			}
		}
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1
		{
			get
			{
				return this._ToolStripStatusLabel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripStatusLabel1 = value;
			}
		}
		internal virtual ListView ListView_Account
		{
			get
			{
				return this._ListView_Account;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ListView_Account = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader1
		{
			get
			{
				return this.columnHeader_3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_3 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader2
		{
			get
			{
				return this.columnHeader_4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_4 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader3
		{
			get
			{
				return this.columnHeader_5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_5 = value;
			}
		}
		internal virtual RichTextBox RichTextBox2
		{
			get
			{
				return this._RichTextBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RichTextBox2 = value;
			}
		}
		internal virtual ListView ListView_Npc
		{
			get
			{
				return this._ListView_Npc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ColumnClickEventHandler value2 = new ColumnClickEventHandler(this.ListView_Item_ColumnClick);
				if (this._ListView_Npc != null)
				{
					this._ListView_Npc.ColumnClick -= value2;
				}
				this._ListView_Npc = value;
				if (this._ListView_Npc != null)
				{
					this._ListView_Npc.ColumnClick += value2;
				}
			}
		}
		internal virtual ColumnHeader ColumnHeader4
		{
			get
			{
				return this.columnHeader_6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_6 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader5
		{
			get
			{
				return this.columnHeader_7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_7 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader6
		{
			get
			{
				return this.columnHeader_8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_8 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader7
		{
			get
			{
				return this.columnHeader_9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_9 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader8
		{
			get
			{
				return this.columnHeader_10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_10 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader9
		{
			get
			{
				return this.columnHeader_11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_11 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader10
		{
			get
			{
				return this.columnHeader_12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_12 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader11
		{
			get
			{
				return this.columnHeader_13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_13 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader12
		{
			get
			{
				return this.columnHeader_14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_14 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader13
		{
			get
			{
				return this.columnHeader_15;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_15 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader14
		{
			get
			{
				return this.columnHeader_16;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_16 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader15
		{
			get
			{
				return this.columnHeader_17;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_17 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader16
		{
			get
			{
				return this.columnHeader_18;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_18 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader17
		{
			get
			{
				return this.columnHeader_19;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_19 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader18
		{
			get
			{
				return this.columnHeader_20;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_20 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader19
		{
			get
			{
				return this.columnHeader_21;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_21 = value;
			}
		}
		internal virtual Button Button_LoadNpc
		{
			get
			{
				return this._Button_LoadNpc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button_LoadNpc_Click);
				if (this._Button_LoadNpc != null)
				{
					this._Button_LoadNpc.Click -= value2;
				}
				this._Button_LoadNpc = value;
				if (this._Button_LoadNpc != null)
				{
					this._Button_LoadNpc.Click += value2;
				}
			}
		}
		internal virtual ProgressBar ProgressBar1
		{
			get
			{
				return this._ProgressBar1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ProgressBar1 = value;
			}
		}
		internal virtual ListView ListView_Item
		{
			get
			{
				return this._ListView_Item;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ColumnClickEventHandler value2 = new ColumnClickEventHandler(this.ListView_Item_ColumnClick);
				if (this._ListView_Item != null)
				{
					this._ListView_Item.ColumnClick -= value2;
				}
				this._ListView_Item = value;
				if (this._ListView_Item != null)
				{
					this._ListView_Item.ColumnClick += value2;
				}
			}
		}
		internal virtual ColumnHeader ColumnHeader20
		{
			get
			{
				return this.columnHeader_22;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_22 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader21
		{
			get
			{
				return this.columnHeader_23;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_23 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader22
		{
			get
			{
				return this.columnHeader_24;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_24 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader23
		{
			get
			{
				return this.columnHeader_25;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_25 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader24
		{
			get
			{
				return this.columnHeader_26;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_26 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader25
		{
			get
			{
				return this.columnHeader_27;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_27 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader26
		{
			get
			{
				return this.columnHeader_28;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_28 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader27
		{
			get
			{
				return this.columnHeader_29;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_29 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader28
		{
			get
			{
				return this.columnHeader_30;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_30 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader29
		{
			get
			{
				return this.columnHeader_31;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_31 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader30
		{
			get
			{
				return this.columnHeader_32;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_32 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader31
		{
			get
			{
				return this.columnHeader_33;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_33 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader32
		{
			get
			{
				return this.columnHeader_34;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_34 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader33
		{
			get
			{
				return this.columnHeader_35;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_35 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader34
		{
			get
			{
				return this.columnHeader_36;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_36 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader35
		{
			get
			{
				return this.columnHeader_37;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_37 = value;
			}
		}
		internal virtual Button Button__LoadItem
		{
			get
			{
				return this._Button__LoadItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button__LoadItem_Click);
				if (this._Button__LoadItem != null)
				{
					this._Button__LoadItem.Click -= value2;
				}
				this._Button__LoadItem = value;
				if (this._Button__LoadItem != null)
				{
					this._Button__LoadItem.Click += value2;
				}
			}
		}
		internal virtual ColumnHeader ColumnHeader37
		{
			get
			{
				return this.columnHeader_38;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_38 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader36
		{
			get
			{
				return this.columnHeader_39;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_39 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader38
		{
			get
			{
				return this.columnHeader_40;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_40 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader39
		{
			get
			{
				return this.columnHeader_41;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_41 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader40
		{
			get
			{
				return this.columnHeader_42;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_42 = value;
			}
		}
		internal virtual ColumnHeader ColumnHeader41
		{
			get
			{
				return this.columnHeader_43;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.columnHeader_43 = value;
			}
		}
		internal virtual TabPage TabPage1
		{
			get
			{
				return this._TabPage1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage1 = value;
			}
		}
		internal virtual RichTextBox RichTextBox3
		{
			get
			{
				return this._RichTextBox3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RichTextBox3 = value;
			}
		}
		internal virtual WebBrowser WebBrowser1
		{
			get
			{
				return this._WebBrowser1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._WebBrowser1 = value;
			}
		}
		public FormServer()
		{
			base.Load += new EventHandler(this.FormServer_Load);
			base.FormClosing += new FormClosingEventHandler(this.FormServer_FormClosing);
			this.delegate_0 = new FormServer.Delegate0(this.method_4);
			this.delegate_1 = new FormServer.Delegate0(this.PvxUcloLc);
			this.InitializeComponent();
		}
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormServer));
			this.Panel1 = new Panel();
			this.TabControl1 = new TabControl();
			this.TabPage_Main = new TabPage();
			this.WebBrowser1 = new WebBrowser();
			this.RichTextBox2 = new RichTextBox();
			this.GroupBox_SettingServer = new GroupBox();
			this.Button_PerExp = new Button();
			this.Button_ServerOff = new Button();
			this.NumericUpDown_PerExp = new NumericUpDown();
			this.Label5 = new Label();
			this.TabControl2 = new TabControl();
			this.TabPage_Online = new TabPage();
			this.ListView_Client = new ListView();
			this.ID = new ColumnHeader();
			this.PlayerName = new ColumnHeader();
			this.IP = new ColumnHeader();
			this.Label_Online = new Label();
			this.TabPage_Account = new TabPage();
			this.ListView_Account = new ListView();
			this.ColumnHeader1 = new ColumnHeader();
			this.ColumnHeader2 = new ColumnHeader();
			this.ColumnHeader3 = new ColumnHeader();
			this.Button_ServerChat = new Button();
			this.RichTextBox1 = new RichTextBox();
			this.GroupBox1 = new GroupBox();
			this.Button_CreatAccount = new Button();
			this.TabPage_Data = new TabPage();
			this.TabControl_Data = new TabControl();
			this.TabPage_Npc = new TabPage();
			this.ListView_Npc = new ListView();
			this.ColumnHeader4 = new ColumnHeader();
			this.ColumnHeader5 = new ColumnHeader();
			this.ColumnHeader6 = new ColumnHeader();
			this.ColumnHeader7 = new ColumnHeader();
			this.ColumnHeader8 = new ColumnHeader();
			this.ColumnHeader9 = new ColumnHeader();
			this.ColumnHeader10 = new ColumnHeader();
			this.ColumnHeader11 = new ColumnHeader();
			this.ColumnHeader12 = new ColumnHeader();
			this.ColumnHeader13 = new ColumnHeader();
			this.ColumnHeader14 = new ColumnHeader();
			this.ColumnHeader15 = new ColumnHeader();
			this.ColumnHeader16 = new ColumnHeader();
			this.ColumnHeader17 = new ColumnHeader();
			this.ColumnHeader18 = new ColumnHeader();
			this.ColumnHeader19 = new ColumnHeader();
			this.Button_LoadNpc = new Button();
			this.TabPage_Item = new TabPage();
			this.ListView_Item = new ListView();
			this.ColumnHeader20 = new ColumnHeader();
			this.ColumnHeader21 = new ColumnHeader();
			this.ColumnHeader22 = new ColumnHeader();
			this.ColumnHeader23 = new ColumnHeader();
			this.ColumnHeader24 = new ColumnHeader();
			this.ColumnHeader25 = new ColumnHeader();
			this.ColumnHeader26 = new ColumnHeader();
			this.ColumnHeader27 = new ColumnHeader();
			this.ColumnHeader28 = new ColumnHeader();
			this.ColumnHeader29 = new ColumnHeader();
			this.ColumnHeader30 = new ColumnHeader();
			this.ColumnHeader37 = new ColumnHeader();
			this.ColumnHeader31 = new ColumnHeader();
			this.ColumnHeader32 = new ColumnHeader();
			this.ColumnHeader33 = new ColumnHeader();
			this.ColumnHeader34 = new ColumnHeader();
			this.ColumnHeader35 = new ColumnHeader();
			this.ColumnHeader36 = new ColumnHeader();
			this.ColumnHeader38 = new ColumnHeader();
			this.ColumnHeader39 = new ColumnHeader();
			this.ColumnHeader40 = new ColumnHeader();
			this.ColumnHeader41 = new ColumnHeader();
			this.Button__LoadItem = new Button();
			this.TabPage_Skill = new TabPage();
			this.TabPage_Warp = new TabPage();
			this.ProgressBar1 = new ProgressBar();
			this.TabPage1 = new TabPage();
			this.RichTextBox3 = new RichTextBox();
			this.DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
			this.Timer1 = new System.Windows.Forms.Timer(this.icontainer_0);
			this.StatusStrip1 = new StatusStrip();
			this.ToolStripStatusLabel3 = new ToolStripStatusLabel();
			this.ToolStripStatusLabel1 = new ToolStripStatusLabel();
			this.Panel1.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPage_Main.SuspendLayout();
			this.GroupBox_SettingServer.SuspendLayout();
			((ISupportInitialize)this.NumericUpDown_PerExp).BeginInit();
			this.TabControl2.SuspendLayout();
			this.TabPage_Online.SuspendLayout();
			this.TabPage_Account.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.TabPage_Data.SuspendLayout();
			this.TabControl_Data.SuspendLayout();
			this.TabPage_Npc.SuspendLayout();
			this.TabPage_Item.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.StatusStrip1.SuspendLayout();
			this.SuspendLayout();
			this.Panel1.Controls.Add(this.TabControl1);
			this.Panel1.Dock = DockStyle.Fill;
			Control arg_484_0 = this.Panel1;
			Point location = new Point(0, 0);
			arg_484_0.Location = location;
			Control arg_49B_0 = this.Panel1;
			Padding padding = new Padding(3, 2, 3, 2);
			arg_49B_0.Margin = padding;
			this.Panel1.Name = "Panel1";
			Control arg_4C8_0 = this.Panel1;
			Size size = new Size(982, 530);
			arg_4C8_0.Size = size;
			this.Panel1.TabIndex = 9;
			this.TabControl1.Controls.Add(this.TabPage_Main);
			this.TabControl1.Controls.Add(this.TabPage_Data);
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Dock = DockStyle.Fill;
			Control arg_538_0 = this.TabControl1;
			location = new Point(0, 0);
			arg_538_0.Location = location;
			Control arg_54C_0 = this.TabControl1;
			padding = new Padding(4);
			arg_54C_0.Margin = padding;
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			Control arg_585_0 = this.TabControl1;
			size = new Size(982, 530);
			arg_585_0.Size = size;
			this.TabControl1.TabIndex = 29;
			this.TabPage_Main.Controls.Add(this.WebBrowser1);
			this.TabPage_Main.Controls.Add(this.RichTextBox2);
			this.TabPage_Main.Controls.Add(this.GroupBox_SettingServer);
			this.TabPage_Main.Controls.Add(this.TabControl2);
			this.TabPage_Main.Controls.Add(this.Button_ServerChat);
			this.TabPage_Main.Controls.Add(this.RichTextBox1);
			this.TabPage_Main.Controls.Add(this.GroupBox1);
			TabPage arg_642_0 = this.TabPage_Main;
			location = new Point(4, 24);
			arg_642_0.Location = location;
			Control arg_656_0 = this.TabPage_Main;
			padding = new Padding(4);
			arg_656_0.Margin = padding;
			this.TabPage_Main.Name = "TabPage_Main";
			Control arg_67A_0 = this.TabPage_Main;
			padding = new Padding(4);
			arg_67A_0.Padding = padding;
			Control arg_697_0 = this.TabPage_Main;
			size = new Size(974, 502);
			arg_697_0.Size = size;
			this.TabPage_Main.TabIndex = 0;
			this.TabPage_Main.Text = "Main";
			this.TabPage_Main.UseVisualStyleBackColor = true;
			Control arg_6D9_0 = this.WebBrowser1;
			location = new Point(297, 88);
			arg_6D9_0.Location = location;
			Control arg_6F0_0 = this.WebBrowser1;
			size = new Size(20, 20);
			arg_6F0_0.MinimumSize = size;
			this.WebBrowser1.Name = "WebBrowser1";
			this.WebBrowser1.ScriptErrorsSuppressed = true;
			this.WebBrowser1.ScrollBarsEnabled = false;
			Control arg_735_0 = this.WebBrowser1;
			size = new Size(668, 150);
			arg_735_0.Size = size;
			this.WebBrowser1.TabIndex = 33;
			this.WebBrowser1.Url = new Uri("http://haoky.99k.org/news.htm", UriKind.Absolute);
			this.RichTextBox2.BackColor = SystemColors.WindowText;
			this.RichTextBox2.ForeColor = SystemColors.Window;
			Control arg_795_0 = this.RichTextBox2;
			location = new Point(295, 245);
			arg_795_0.Location = location;
			Control arg_7A9_0 = this.RichTextBox2;
			padding = new Padding(4);
			arg_7A9_0.Margin = padding;
			this.RichTextBox2.Name = "RichTextBox2";
			Control arg_7D6_0 = this.RichTextBox2;
			size = new Size(671, 214);
			arg_7D6_0.Size = size;
			this.RichTextBox2.TabIndex = 32;
			this.RichTextBox2.Text = "";
			this.GroupBox_SettingServer.Controls.Add(this.Button_PerExp);
			this.GroupBox_SettingServer.Controls.Add(this.Button_ServerOff);
			this.GroupBox_SettingServer.Controls.Add(this.NumericUpDown_PerExp);
			this.GroupBox_SettingServer.Controls.Add(this.Label5);
			Control arg_864_0 = this.GroupBox_SettingServer;
			location = new Point(297, 8);
			arg_864_0.Location = location;
			Control arg_878_0 = this.GroupBox_SettingServer;
			padding = new Padding(4);
			arg_878_0.Margin = padding;
			this.GroupBox_SettingServer.Name = "GroupBox_SettingServer";
			Control arg_89C_0 = this.GroupBox_SettingServer;
			padding = new Padding(4);
			arg_89C_0.Padding = padding;
			Control arg_8B6_0 = this.GroupBox_SettingServer;
			size = new Size(668, 73);
			arg_8B6_0.Size = size;
			this.GroupBox_SettingServer.TabIndex = 31;
			this.GroupBox_SettingServer.TabStop = false;
			Control arg_8E9_0 = this.Button_PerExp;
			location = new Point(154, 14);
			arg_8E9_0.Location = location;
			Control arg_900_0 = this.Button_PerExp;
			padding = new Padding(3, 2, 3, 2);
			arg_900_0.Margin = padding;
			this.Button_PerExp.Name = "Button_PerExp";
			Control arg_927_0 = this.Button_PerExp;
			size = new Size(72, 50);
			arg_927_0.Size = size;
			this.Button_PerExp.TabIndex = 31;
			this.Button_PerExp.Text = "Áp dụng";
			this.Button_PerExp.UseVisualStyleBackColor = true;
			Control arg_96A_0 = this.Button_ServerOff;
			location = new Point(562, 14);
			arg_96A_0.Location = location;
			Control arg_981_0 = this.Button_ServerOff;
			padding = new Padding(3, 2, 3, 2);
			arg_981_0.Margin = padding;
			this.Button_ServerOff.Name = "Button_ServerOff";
			Control arg_9A8_0 = this.Button_ServerOff;
			size = new Size(99, 53);
			arg_9A8_0.Size = size;
			this.Button_ServerOff.TabIndex = 30;
			this.Button_ServerOff.Text = "Tắt máy chủ";
			this.Button_ServerOff.UseVisualStyleBackColor = true;
			this.NumericUpDown_PerExp.DecimalPlaces = 1;
			NumericUpDown arg_A13_0 = this.NumericUpDown_PerExp;
			decimal num = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			arg_A13_0.Increment = num;
			Control arg_A29_0 = this.NumericUpDown_PerExp;
			location = new Point(8, 43);
			arg_A29_0.Location = location;
			Control arg_A3D_0 = this.NumericUpDown_PerExp;
			padding = new Padding(4);
			arg_A3D_0.Margin = padding;
			NumericUpDown arg_A73_0 = this.NumericUpDown_PerExp;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			arg_A73_0.Maximum = num;
			NumericUpDown arg_AA5_0 = this.NumericUpDown_PerExp;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			arg_AA5_0.Minimum = num;
			this.NumericUpDown_PerExp.Name = "NumericUpDown_PerExp";
			Control arg_ACF_0 = this.NumericUpDown_PerExp;
			size = new Size(140, 22);
			arg_ACF_0.Size = size;
			this.NumericUpDown_PerExp.TabIndex = 5;
			NumericUpDown arg_B0D_0 = this.NumericUpDown_PerExp;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			arg_B0D_0.Value = num;
			this.Label5.AutoSize = true;
			Control arg_B2F_0 = this.Label5;
			location = new Point(7, 14);
			arg_B2F_0.Location = location;
			this.Label5.Name = "Label5";
			Control arg_B59_0 = this.Label5;
			size = new Size(141, 16);
			arg_B59_0.Size = size;
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Kinh nghiệm đạt được :";
			this.TabControl2.Controls.Add(this.TabPage_Online);
			this.TabControl2.Controls.Add(this.TabPage_Account);
			Control arg_BB7_0 = this.TabControl2;
			location = new Point(7, 87);
			arg_BB7_0.Location = location;
			Control arg_BCB_0 = this.TabControl2;
			padding = new Padding(4);
			arg_BCB_0.Margin = padding;
			this.TabControl2.Name = "TabControl2";
			this.TabControl2.SelectedIndex = 0;
			Control arg_C04_0 = this.TabControl2;
			size = new Size(283, 406);
			arg_C04_0.Size = size;
			this.TabControl2.TabIndex = 29;
			this.TabPage_Online.Controls.Add(this.ListView_Client);
			this.TabPage_Online.Controls.Add(this.Label_Online);
			TabPage arg_C53_0 = this.TabPage_Online;
			location = new Point(4, 24);
			arg_C53_0.Location = location;
			Control arg_C67_0 = this.TabPage_Online;
			padding = new Padding(4);
			arg_C67_0.Margin = padding;
			this.TabPage_Online.Name = "TabPage_Online";
			Control arg_C8B_0 = this.TabPage_Online;
			padding = new Padding(4);
			arg_C8B_0.Padding = padding;
			Control arg_CA8_0 = this.TabPage_Online;
			size = new Size(275, 378);
			arg_CA8_0.Size = size;
			this.TabPage_Online.TabIndex = 0;
			this.TabPage_Online.Text = "Online";
			this.TabPage_Online.UseVisualStyleBackColor = true;
			this.ListView_Client.Columns.AddRange(new ColumnHeader[]
			{
				this.ID,
				this.PlayerName,
				this.IP
			});
			this.ListView_Client.Dock = DockStyle.Fill;
			this.ListView_Client.Font = new Font("Times New Roman", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ListView_Client.FullRowSelect = true;
			this.ListView_Client.GridLines = true;
			Control arg_D5E_0 = this.ListView_Client;
			location = new Point(4, 4);
			arg_D5E_0.Location = location;
			Control arg_D72_0 = this.ListView_Client;
			padding = new Padding(4);
			arg_D72_0.Margin = padding;
			this.ListView_Client.Name = "ListView_Client";
			Control arg_D9F_0 = this.ListView_Client;
			size = new Size(267, 350);
			arg_D9F_0.Size = size;
			this.ListView_Client.TabIndex = 37;
			this.ListView_Client.UseCompatibleStateImageBehavior = false;
			this.ListView_Client.View = View.Details;
			this.ID.Text = "ID";
			this.PlayerName.Text = "Tên";
			this.PlayerName.Width = 100;
			this.IP.Text = "IP";
			this.IP.Width = 75;
			this.Label_Online.Dock = DockStyle.Bottom;
			Control arg_E33_0 = this.Label_Online;
			location = new Point(4, 354);
			arg_E33_0.Location = location;
			this.Label_Online.Name = "Label_Online";
			Control arg_E5D_0 = this.Label_Online;
			size = new Size(267, 20);
			arg_E5D_0.Size = size;
			this.Label_Online.TabIndex = 36;
			this.Label_Online.Text = "0";
			this.Label_Online.TextAlign = ContentAlignment.MiddleRight;
			this.TabPage_Account.Controls.Add(this.ListView_Account);
			TabPage arg_EB3_0 = this.TabPage_Account;
			location = new Point(4, 25);
			arg_EB3_0.Location = location;
			Control arg_EC7_0 = this.TabPage_Account;
			padding = new Padding(4);
			arg_EC7_0.Margin = padding;
			this.TabPage_Account.Name = "TabPage_Account";
			Control arg_EEB_0 = this.TabPage_Account;
			padding = new Padding(4);
			arg_EEB_0.Padding = padding;
			Control arg_F08_0 = this.TabPage_Account;
			size = new Size(275, 377);
			arg_F08_0.Size = size;
			this.TabPage_Account.TabIndex = 1;
			this.TabPage_Account.Text = "Account";
			this.TabPage_Account.UseVisualStyleBackColor = true;
			this.ListView_Account.Columns.AddRange(new ColumnHeader[]
			{
				this.ColumnHeader1,
				this.ColumnHeader2,
				this.ColumnHeader3
			});
			this.ListView_Account.Dock = DockStyle.Fill;
			this.ListView_Account.Font = new Font("Times New Roman", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ListView_Account.FullRowSelect = true;
			this.ListView_Account.GridLines = true;
			Control arg_FBE_0 = this.ListView_Account;
			location = new Point(4, 4);
			arg_FBE_0.Location = location;
			Control arg_FD2_0 = this.ListView_Account;
			padding = new Padding(4);
			arg_FD2_0.Margin = padding;
			this.ListView_Account.Name = "ListView_Account";
			Control arg_FFF_0 = this.ListView_Account;
			size = new Size(267, 369);
			arg_FFF_0.Size = size;
			this.ListView_Account.TabIndex = 38;
			this.ListView_Account.UseCompatibleStateImageBehavior = false;
			this.ListView_Account.View = View.Details;
			this.ColumnHeader1.Text = "ID";
			this.ColumnHeader1.Width = 70;
			this.ColumnHeader2.Text = "Mật khẩu";
			this.ColumnHeader2.Width = 80;
			this.ColumnHeader3.Text = "Ám mã";
			this.ColumnHeader3.Width = 80;
			Control arg_1098_0 = this.Button_ServerChat;
			location = new Point(807, 465);
			arg_1098_0.Location = location;
			Control arg_10AF_0 = this.Button_ServerChat;
			padding = new Padding(3, 2, 3, 2);
			arg_10AF_0.Margin = padding;
			this.Button_ServerChat.Name = "Button_ServerChat";
			Control arg_10D9_0 = this.Button_ServerChat;
			size = new Size(159, 30);
			arg_10D9_0.Size = size;
			this.Button_ServerChat.TabIndex = 28;
			this.Button_ServerChat.Text = "Công Bố Hệ Thống";
			this.Button_ServerChat.UseVisualStyleBackColor = true;
			Control arg_111F_0 = this.RichTextBox1;
			location = new Point(295, 467);
			arg_111F_0.Location = location;
			Control arg_1133_0 = this.RichTextBox1;
			padding = new Padding(4);
			arg_1133_0.Margin = padding;
			this.RichTextBox1.Name = "RichTextBox1";
			Control arg_115D_0 = this.RichTextBox1;
			size = new Size(505, 28);
			arg_115D_0.Size = size;
			this.RichTextBox1.TabIndex = 27;
			this.RichTextBox1.Text = "";
			this.GroupBox1.Controls.Add(this.Button_CreatAccount);
			Control arg_11A5_0 = this.GroupBox1;
			location = new Point(7, 6);
			arg_11A5_0.Location = location;
			Control arg_11BC_0 = this.GroupBox1;
			padding = new Padding(3, 2, 3, 2);
			arg_11BC_0.Margin = padding;
			this.GroupBox1.Name = "GroupBox1";
			Control arg_11E3_0 = this.GroupBox1;
			padding = new Padding(3, 2, 3, 2);
			arg_11E3_0.Padding = padding;
			Control arg_11FD_0 = this.GroupBox1;
			size = new Size(283, 75);
			arg_11FD_0.Size = size;
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			Control arg_122B_0 = this.Button_CreatAccount;
			location = new Point(6, 15);
			arg_122B_0.Location = location;
			Control arg_1242_0 = this.Button_CreatAccount;
			padding = new Padding(3, 2, 3, 2);
			arg_1242_0.Margin = padding;
			this.Button_CreatAccount.Name = "Button_CreatAccount";
			Control arg_126C_0 = this.Button_CreatAccount;
			size = new Size(270, 50);
			arg_126C_0.Size = size;
			this.Button_CreatAccount.TabIndex = 5;
			this.Button_CreatAccount.Text = "Tạo tài khoản";
			this.Button_CreatAccount.UseVisualStyleBackColor = true;
			this.TabPage_Data.Controls.Add(this.TabControl_Data);
			this.TabPage_Data.Controls.Add(this.ProgressBar1);
			TabPage arg_12D6_0 = this.TabPage_Data;
			location = new Point(4, 25);
			arg_12D6_0.Location = location;
			Control arg_12EA_0 = this.TabPage_Data;
			padding = new Padding(4);
			arg_12EA_0.Margin = padding;
			this.TabPage_Data.Name = "TabPage_Data";
			Control arg_130E_0 = this.TabPage_Data;
			padding = new Padding(4);
			arg_130E_0.Padding = padding;
			Control arg_132B_0 = this.TabPage_Data;
			size = new Size(974, 501);
			arg_132B_0.Size = size;
			this.TabPage_Data.TabIndex = 1;
			this.TabPage_Data.Text = "Data";
			this.TabPage_Data.UseVisualStyleBackColor = true;
			this.TabControl_Data.Controls.Add(this.TabPage_Npc);
			this.TabControl_Data.Controls.Add(this.TabPage_Item);
			this.TabControl_Data.Controls.Add(this.TabPage_Skill);
			this.TabControl_Data.Controls.Add(this.TabPage_Warp);
			this.TabControl_Data.Dock = DockStyle.Fill;
			Control arg_13CC_0 = this.TabControl_Data;
			location = new Point(4, 4);
			arg_13CC_0.Location = location;
			Control arg_13E0_0 = this.TabControl_Data;
			padding = new Padding(4);
			arg_13E0_0.Margin = padding;
			this.TabControl_Data.Name = "TabControl_Data";
			this.TabControl_Data.SelectedIndex = 0;
			Control arg_1419_0 = this.TabControl_Data;
			size = new Size(966, 480);
			arg_1419_0.Size = size;
			this.TabControl_Data.TabIndex = 29;
			this.TabPage_Npc.Controls.Add(this.ListView_Npc);
			this.TabPage_Npc.Controls.Add(this.Button_LoadNpc);
			TabPage arg_1468_0 = this.TabPage_Npc;
			location = new Point(4, 24);
			arg_1468_0.Location = location;
			Control arg_147C_0 = this.TabPage_Npc;
			padding = new Padding(4);
			arg_147C_0.Margin = padding;
			this.TabPage_Npc.Name = "TabPage_Npc";
			Control arg_14A0_0 = this.TabPage_Npc;
			padding = new Padding(4);
			arg_14A0_0.Padding = padding;
			Control arg_14BD_0 = this.TabPage_Npc;
			size = new Size(958, 452);
			arg_14BD_0.Size = size;
			this.TabPage_Npc.TabIndex = 0;
			this.TabPage_Npc.Text = "Npc";
			this.TabPage_Npc.UseVisualStyleBackColor = true;
			this.ListView_Npc.Columns.AddRange(new ColumnHeader[]
			{
				this.ColumnHeader4,
				this.ColumnHeader5,
				this.ColumnHeader6,
				this.ColumnHeader7,
				this.ColumnHeader8,
				this.ColumnHeader9,
				this.ColumnHeader10,
				this.ColumnHeader11,
				this.ColumnHeader12,
				this.ColumnHeader13,
				this.ColumnHeader14,
				this.ColumnHeader15,
				this.ColumnHeader16,
				this.ColumnHeader17,
				this.ColumnHeader18,
				this.ColumnHeader19
			});
			this.ListView_Npc.Dock = DockStyle.Fill;
			this.ListView_Npc.Font = new Font("Times New Roman", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ListView_Npc.FullRowSelect = true;
			this.ListView_Npc.GridLines = true;
			Control arg_15FD_0 = this.ListView_Npc;
			location = new Point(4, 4);
			arg_15FD_0.Location = location;
			Control arg_1611_0 = this.ListView_Npc;
			padding = new Padding(4);
			arg_1611_0.Margin = padding;
			this.ListView_Npc.Name = "ListView_Npc";
			Control arg_163E_0 = this.ListView_Npc;
			size = new Size(950, 421);
			arg_163E_0.Size = size;
			this.ListView_Npc.TabIndex = 38;
			this.ListView_Npc.UseCompatibleStateImageBehavior = false;
			this.ListView_Npc.View = View.Details;
			this.ColumnHeader4.Text = "Id";
			this.ColumnHeader4.Width = 50;
			this.ColumnHeader5.Text = "Tên";
			this.ColumnHeader5.Width = 100;
			this.ColumnHeader6.Text = "Cấp";
			this.ColumnHeader6.Width = 40;
			this.ColumnHeader7.Text = "Thuộc tính";
			this.ColumnHeader7.Width = 80;
			this.ColumnHeader8.Text = "Hp";
			this.ColumnHeader8.Width = 40;
			this.ColumnHeader9.Text = "Sp";
			this.ColumnHeader9.Width = 40;
			this.ColumnHeader10.Text = "Hpx";
			this.ColumnHeader10.Width = 40;
			this.ColumnHeader11.Text = "Spx";
			this.ColumnHeader11.Width = 40;
			this.ColumnHeader12.Text = "Int";
			this.ColumnHeader12.Width = 40;
			this.ColumnHeader13.Text = "Atk";
			this.ColumnHeader13.Width = 40;
			this.ColumnHeader14.Text = "Def";
			this.ColumnHeader14.Width = 40;
			this.ColumnHeader15.Text = "Agi";
			this.ColumnHeader15.Width = 40;
			this.ColumnHeader16.Text = "Skill";
			this.ColumnHeader16.Width = 100;
			this.ColumnHeader17.Text = "Vật phẩm rớt";
			this.ColumnHeader17.Width = 130;
			this.ColumnHeader18.Text = "Bắt";
			this.ColumnHeader18.Width = 40;
			this.ColumnHeader19.Text = "Reborn";
			this.ColumnHeader19.Width = 40;
			this.Button_LoadNpc.Dock = DockStyle.Bottom;
			Control arg_185B_0 = this.Button_LoadNpc;
			location = new Point(4, 425);
			arg_185B_0.Location = location;
			this.Button_LoadNpc.Name = "Button_LoadNpc";
			Control arg_1885_0 = this.Button_LoadNpc;
			size = new Size(950, 23);
			arg_1885_0.Size = size;
			this.Button_LoadNpc.TabIndex = 39;
			this.Button_LoadNpc.Text = "Tải dữ liệu";
			this.Button_LoadNpc.UseVisualStyleBackColor = true;
			this.TabPage_Item.Controls.Add(this.ListView_Item);
			this.TabPage_Item.Controls.Add(this.Button__LoadItem);
			TabPage arg_18F0_0 = this.TabPage_Item;
			location = new Point(4, 25);
			arg_18F0_0.Location = location;
			Control arg_1904_0 = this.TabPage_Item;
			padding = new Padding(4);
			arg_1904_0.Margin = padding;
			this.TabPage_Item.Name = "TabPage_Item";
			Control arg_1928_0 = this.TabPage_Item;
			padding = new Padding(4);
			arg_1928_0.Padding = padding;
			Control arg_1945_0 = this.TabPage_Item;
			size = new Size(958, 451);
			arg_1945_0.Size = size;
			this.TabPage_Item.TabIndex = 1;
			this.TabPage_Item.Text = "Item";
			this.TabPage_Item.UseVisualStyleBackColor = true;
			this.ListView_Item.Columns.AddRange(new ColumnHeader[]
			{
				this.ColumnHeader20,
				this.ColumnHeader21,
				this.ColumnHeader22,
				this.ColumnHeader23,
				this.ColumnHeader24,
				this.ColumnHeader25,
				this.ColumnHeader26,
				this.ColumnHeader27,
				this.ColumnHeader28,
				this.ColumnHeader29,
				this.ColumnHeader30,
				this.ColumnHeader37,
				this.ColumnHeader31,
				this.ColumnHeader32,
				this.ColumnHeader33,
				this.ColumnHeader34,
				this.ColumnHeader35,
				this.ColumnHeader36,
				this.ColumnHeader38,
				this.ColumnHeader39,
				this.ColumnHeader40,
				this.ColumnHeader41
			});
			this.ListView_Item.Dock = DockStyle.Fill;
			this.ListView_Item.Font = new Font("Times New Roman", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ListView_Item.FullRowSelect = true;
			this.ListView_Item.GridLines = true;
			Control arg_1AC7_0 = this.ListView_Item;
			location = new Point(4, 4);
			arg_1AC7_0.Location = location;
			Control arg_1ADB_0 = this.ListView_Item;
			padding = new Padding(4);
			arg_1ADB_0.Margin = padding;
			this.ListView_Item.Name = "ListView_Item";
			Control arg_1B08_0 = this.ListView_Item;
			size = new Size(950, 420);
			arg_1B08_0.Size = size;
			this.ListView_Item.TabIndex = 40;
			this.ListView_Item.UseCompatibleStateImageBehavior = false;
			this.ListView_Item.View = View.Details;
			this.ColumnHeader20.Text = "Id";
			this.ColumnHeader20.Width = 50;
			this.ColumnHeader21.Text = "Tên";
			this.ColumnHeader21.Width = 100;
			this.ColumnHeader22.Text = "Cấp";
			this.ColumnHeader22.Width = 40;
			this.ColumnHeader23.Text = "Hp";
			this.ColumnHeader23.Width = 40;
			this.ColumnHeader24.Text = "Sp";
			this.ColumnHeader24.Width = 40;
			this.ColumnHeader25.Text = "Int";
			this.ColumnHeader25.Width = 40;
			this.ColumnHeader26.Text = "Atk";
			this.ColumnHeader26.Width = 40;
			this.ColumnHeader27.Text = "Def";
			this.ColumnHeader27.Width = 40;
			this.ColumnHeader28.Text = "Spx";
			this.ColumnHeader28.Width = 40;
			this.ColumnHeader29.Text = "Hpx";
			this.ColumnHeader29.Width = 40;
			this.ColumnHeader30.Text = "Agi";
			this.ColumnHeader30.Width = 40;
			this.ColumnHeader37.Text = "Fai";
			this.ColumnHeader37.Width = 40;
			this.ColumnHeader31.Text = "Int+";
			this.ColumnHeader31.Width = 40;
			this.ColumnHeader32.Text = "Atk+";
			this.ColumnHeader32.Width = 40;
			this.ColumnHeader33.Text = "Def+";
			this.ColumnHeader33.Width = 40;
			this.ColumnHeader34.Text = "Hpx+";
			this.ColumnHeader34.Width = 40;
			this.ColumnHeader35.Text = "Spx+";
			this.ColumnHeader35.Width = 40;
			this.ColumnHeader36.Text = "Agi+";
			this.ColumnHeader36.Width = 40;
			this.ColumnHeader38.Text = "Fai+";
			this.ColumnHeader38.Width = 40;
			this.ColumnHeader39.Text = "Thuộc tính";
			this.ColumnHeader39.Width = 80;
			this.ColumnHeader40.Text = "TT+";
			this.ColumnHeader40.Width = 40;
			this.ColumnHeader41.Text = "Loại";
			this.Button__LoadItem.Dock = DockStyle.Bottom;
			Control arg_1DC3_0 = this.Button__LoadItem;
			location = new Point(4, 424);
			arg_1DC3_0.Location = location;
			this.Button__LoadItem.Name = "Button__LoadItem";
			Control arg_1DED_0 = this.Button__LoadItem;
			size = new Size(950, 23);
			arg_1DED_0.Size = size;
			this.Button__LoadItem.TabIndex = 41;
			this.Button__LoadItem.Text = "Tải dữ liệu";
			this.Button__LoadItem.UseVisualStyleBackColor = true;
			TabPage arg_1E2C_0 = this.TabPage_Skill;
			location = new Point(4, 25);
			arg_1E2C_0.Location = location;
			Control arg_1E40_0 = this.TabPage_Skill;
			padding = new Padding(4);
			arg_1E40_0.Margin = padding;
			this.TabPage_Skill.Name = "TabPage_Skill";
			Control arg_1E64_0 = this.TabPage_Skill;
			padding = new Padding(4);
			arg_1E64_0.Padding = padding;
			Control arg_1E81_0 = this.TabPage_Skill;
			size = new Size(958, 451);
			arg_1E81_0.Size = size;
			this.TabPage_Skill.TabIndex = 2;
			this.TabPage_Skill.Text = "Skill";
			this.TabPage_Skill.UseVisualStyleBackColor = true;
			TabPage arg_1EBF_0 = this.TabPage_Warp;
			location = new Point(4, 25);
			arg_1EBF_0.Location = location;
			Control arg_1ED3_0 = this.TabPage_Warp;
			padding = new Padding(4);
			arg_1ED3_0.Margin = padding;
			this.TabPage_Warp.Name = "TabPage_Warp";
			Control arg_1EF7_0 = this.TabPage_Warp;
			padding = new Padding(4);
			arg_1EF7_0.Padding = padding;
			Control arg_1F14_0 = this.TabPage_Warp;
			size = new Size(958, 451);
			arg_1F14_0.Size = size;
			this.TabPage_Warp.TabIndex = 3;
			this.TabPage_Warp.Text = "Warp";
			this.TabPage_Warp.UseVisualStyleBackColor = true;
			this.ProgressBar1.Dock = DockStyle.Bottom;
			Control arg_1F61_0 = this.ProgressBar1;
			location = new Point(4, 484);
			arg_1F61_0.Location = location;
			this.ProgressBar1.Name = "ProgressBar1";
			Control arg_1F8B_0 = this.ProgressBar1;
			size = new Size(966, 13);
			arg_1F8B_0.Size = size;
			this.ProgressBar1.TabIndex = 30;
			this.TabPage1.Controls.Add(this.RichTextBox3);
			TabPage arg_1FC4_0 = this.TabPage1;
			location = new Point(4, 25);
			arg_1FC4_0.Location = location;
			this.TabPage1.Name = "TabPage1";
			Control arg_1FE8_0 = this.TabPage1;
			padding = new Padding(3);
			arg_1FE8_0.Padding = padding;
			Control arg_2005_0 = this.TabPage1;
			size = new Size(974, 501);
			arg_2005_0.Size = size;
			this.TabPage1.TabIndex = 2;
			this.TabPage1.Text = "Thông tin";
			this.TabPage1.UseVisualStyleBackColor = true;
			this.RichTextBox3.Dock = DockStyle.Fill;
			Control arg_204E_0 = this.RichTextBox3;
			location = new Point(3, 3);
			arg_204E_0.Location = location;
			this.RichTextBox3.Name = "RichTextBox3";
			this.RichTextBox3.ReadOnly = true;
			Control arg_2087_0 = this.RichTextBox3;
			size = new Size(968, 495);
			arg_2087_0.Size = size;
			this.RichTextBox3.TabIndex = 0;
			this.RichTextBox3.Text = componentResourceManager.GetString("RichTextBox3.Text");
			this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 500;
			this.StatusStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.ToolStripStatusLabel3,
				this.ToolStripStatusLabel1
			});
			Control arg_211C_0 = this.StatusStrip1;
			location = new Point(0, 530);
			arg_211C_0.Location = location;
			this.StatusStrip1.Name = "StatusStrip1";
			StatusStrip arg_2144_0 = this.StatusStrip1;
			padding = new Padding(1, 0, 19, 0);
			arg_2144_0.Padding = padding;
			Control arg_215E_0 = this.StatusStrip1;
			size = new Size(982, 25);
			arg_215E_0.Size = size;
			this.StatusStrip1.TabIndex = 10;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
			ToolStripItem arg_21A2_0 = this.ToolStripStatusLabel3;
			size = new Size(56, 20);
			arg_21A2_0.Size = size;
			this.ToolStripStatusLabel3.Text = "Status :";
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			ToolStripItem arg_21D9_0 = this.ToolStripStatusLabel1;
			size = new Size(72, 20);
			arg_21D9_0.Size = size;
			this.ToolStripStatusLabel1.Text = "Loading...";
			this.AutoScaleMode = AutoScaleMode.Inherit;
			size = new Size(982, 555);
			this.ClientSize = size;
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.StatusStrip1);
			this.Font = new Font("Microsoft Sans Serif", 7.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
			padding = new Padding(3, 2, 3, 2);
			this.Margin = padding;
			this.MaximizeBox = false;
			size = new Size(1000, 600);
			this.MaximumSize = size;
			size = new Size(1000, 600);
			this.MinimumSize = size;
			this.Name = "FormServer";
			this.Text = "Server Ts Online (Development by DVT)";
			this.Panel1.ResumeLayout(false);
			this.TabControl1.ResumeLayout(false);
			this.TabPage_Main.ResumeLayout(false);
			this.GroupBox_SettingServer.ResumeLayout(false);
			this.GroupBox_SettingServer.PerformLayout();
			((ISupportInitialize)this.NumericUpDown_PerExp).EndInit();
			this.TabControl2.ResumeLayout(false);
			this.TabPage_Online.ResumeLayout(false);
			this.TabPage_Account.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.TabPage_Data.ResumeLayout(false);
			this.TabControl_Data.ResumeLayout(false);
			this.TabPage_Npc.ResumeLayout(false);
			this.TabPage_Item.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void FormServer_Load(object sender, EventArgs e)
		{
			this.Text = this.Text + " [" + Class1.Form0_0.Info.Version.ToString() + "]";
			this.ListView_Account.ListViewItemSorter = new clsListviewSorter(0, SortOrder.Ascending);
			Data.conn_Account.Open();
			try
			{
				IEnumerator enumerator = this.ListView_Client.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ColumnHeader columnHeader = (ColumnHeader)enumerator.Current;
					NewLateBinding.LateCall(Server.ListView_Client.Columns, null, "Add", new object[]
					{
						RuntimeHelpers.GetObjectValue(columnHeader.Clone())
					}, null, null, null, true);
				}
			}
            finally { }

			this.method_3();
			object obj = Class1.Form0_0.Info.DirectoryPath + "\\Member\\";
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", ""));
			object arg_127_0 = objectValue;
			Type arg_127_1 = null;
			string arg_127_2 = "FolderExists";
			object[] array = new object[]
			{
				RuntimeHelpers.GetObjectValue(obj)
			};
			object[] arg_127_3 = array;
			string[] arg_127_4 = null;
			Type[] arg_127_5 = null;
			bool[] array2 = new bool[]
			{
				true
			};
			object arg_13C_0 = NewLateBinding.LateGet(arg_127_0, arg_127_1, arg_127_2, arg_127_3, arg_127_4, arg_127_5, array2);
			if (array2[0])
			{
				obj = RuntimeHelpers.GetObjectValue(array[0]);
			}
			if (Conversions.ToBoolean(Operators.NotObject(arg_13C_0)))
			{
				object arg_179_0 = objectValue;
				Type arg_179_1 = null;
				string arg_179_2 = "CreateFolder";
				object[] array3 = new object[]
				{
					RuntimeHelpers.GetObjectValue(obj)
				};
				object[] arg_179_3 = array3;
				string[] arg_179_4 = null;
				Type[] arg_179_5 = null;
				bool[] array4 = new bool[]
				{
					true
				};
				NewLateBinding.LateCall(arg_179_0, arg_179_1, arg_179_2, arg_179_3, arg_179_4, arg_179_5, array4, true);
				if (array4[0])
				{
					obj = RuntimeHelpers.GetObjectValue(array3[0]);
				}
			}
			new Thread(new ThreadStart(Data.LoadDataItems))
			{
				IsBackground = true
			}.Start();
			this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint localEP = new IPEndPoint(IPAddress.Any, 6414);
			this.socket_0.Bind(localEP);
			this.socket_0.Listen(5);
			this.socket_0.BeginAccept(new AsyncCallback(this.method_0), null);
		}
		private void FormServer_FormClosing(object sender, FormClosingEventArgs e)
		{
			Data.conn_Account.Close();
		}
		private void method_0(IAsyncResult iasyncResult_0)
		{
			try
			{
				this.socket_0.BeginAccept(new AsyncCallback(this.method_0), null);
			}
			catch (Exception expr_1D)
			{
				ProjectData.SetProjectError(expr_1D);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Data.LoadedData)
				{
					this.method_1(this.socket_0.EndAccept(iasyncResult_0));
				}
			}
			catch (Exception expr_46)
			{
				ProjectData.SetProjectError(expr_46);
				ProjectData.ClearProjectError();
			}
		}
		private void method_1(Socket socket_1)
		{
			try
			{
				if (this.InvokeRequired)
				{
					this.Invoke(new FormServer._AddClient(this.method_1), new object[]
					{
						socket_1
					});
				}
				else
				{
					new Client(socket_1);
				}
			}
			catch (Exception expr_34)
			{
				ProjectData.SetProjectError(expr_34);
				ProjectData.ClearProjectError();
			}
		}
		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (Data._Status.Length > 0)
			{
				this.ToolStripStatusLabel1.Text = Data._Status;
				Data._Status = "";
			}
			if (Operators.CompareString(this.Label_Online.Text, this.ListView_Client.Items.Count.ToString(), false) != 0)
			{
				this.Label_Online.Text = this.ListView_Client.Items.Count.ToString();
			}
			try
			{
				IEnumerator enumerator = Server.ListView_Client.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem listViewItem = (ListViewItem)enumerator.Current;
					Client client = (Client)listViewItem.Tag;
					if (Operators.CompareString(client._My_Id.ToString(), listViewItem.Text, false) != 0)
					{
						listViewItem.Text = client._My_Id.ToString();
					}
					if (Operators.CompareString(client._My_Name, listViewItem.SubItems[1].Text, false) != 0)
					{
						listViewItem.SubItems[1].Text = client._My_Name;
					}
					if (client._socket.Connected)
					{
						if (this.ListView_Client.Items.ContainsKey(listViewItem.Name))
						{
							if (Operators.CompareString(this.ListView_Client.Items[listViewItem.Name].SubItems[1].Text, client._My_Name, false) != 0)
							{
								this.ListView_Client.Items[listViewItem.Name].SubItems[1].Text = client._My_Name;
							}
						}
						else
						{
							ListViewItem listViewItem2 = (ListViewItem)NewLateBinding.LateGet(this.ListView_Client.Items, null, "Add", new object[]
							{
								RuntimeHelpers.GetObjectValue(listViewItem.Clone())
							}, null, null, null);
							listViewItem2.Name = listViewItem.SubItems[0].Text;
						}
					}
					else
					{
						if (this.ListView_Client.Items.ContainsKey(listViewItem.Name))
						{
							this.ListView_Client.Items.RemoveByKey(listViewItem.Name);
						}
					}
				}
			}
            finally { }
		}
		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void Button_CreatAccount_Click(object sender, EventArgs e)
		{
			string string_ = Class1.Form0_0.Info.DirectoryPath + "\\Data\\Member.ini";
			int num = 10000;
			if (this.ListView_Account.Items.Count > 0)
			{
				num = checked(Conversions.ToInteger(this.ListView_Account.Items[this.ListView_Account.Items.Count - 1].SubItems[0].Text.Replace("vn", "")) + 1);
			}
			Class6.smethod_0(string_, "TaiKhoan", num.ToString(), "1111111111\t1111111111");
			Class5.smethod_0(this.RichTextBox2, "==================== Đăng ký thành công! ====================\r\nTài khoản: vn" + num.ToString() + "\r\nMật khẩu: 1111111111\r\nÁm mã: 1111111111", SystemColors.Window);
			this.method_3();
		}
		private void Button_ServerChat_Click(object sender, EventArgs e)
		{
			string text = Class5.smethod_17(":" + this.RichTextBox1.Text);
			if (text.Length > 0)
			{
				Server.SendToServer("F444" + Class5.smethod_11(checked(text.Length + 2)) + "020C" + Class5.smethod_13(text));
			}
		}
		private void Button_ServerOff_Click(object sender, EventArgs e)
		{
			new Thread(new ThreadStart(this.method_2))
			{
				IsBackground = true
			}.Start();
		}
		private void method_2()
		{
			int num = 5;
			checked
			{
				while (num != 0)
				{
					string text = Class5.smethod_17(":Máy chủ sẽ đóng trong " + num.ToString() + " giây.");
					if (text.Length > 0)
					{
						Server.SendToServer("F444" + Class5.smethod_11(text.Length + 2) + "020C" + Class5.smethod_13(text));
					}
					num--;
					Thread.Sleep(1000);
				}
				try
				{
					IEnumerator enumerator = Server.ListView_Client.Items.GetEnumerator();
					while (enumerator.MoveNext())
					{
						ListViewItem listViewItem = (ListViewItem)enumerator.Current;
						Client client = (Client)listViewItem.Tag;
						client._socket.Close();
						client.conn.Close();
					}
				}
                finally { }
				this.socket_0.Close();
			}
		}
		private void cvkmaHgvB(object sender, EventArgs e)
		{
			Server.PerEXP = Convert.ToInt32(this.NumericUpDown_PerExp.Value);
		}
		private void TabControl2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.TabControl2.SelectedIndex == 1)
			{
				this.method_3();
			}
		}
		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void method_3()
		{
			string[] array = File.ReadAllLines(Class1.Form0_0.Info.DirectoryPath + "\\Data\\Member.ini");
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.Length <= 0)
					{
						break;
					}
					if (!text.StartsWith("["))
					{
						int value = Conversions.ToInteger(text.Substring(0, text.IndexOf("=")));
						if (!this.ListView_Account.Items.ContainsKey(value.ToString()))
						{
							string[] array2 = text.Substring(text.IndexOf("=") + 1).Split(new char[]
							{
								'\t'
							});
							string text2 = array2[0];
							string text3 = array2[1];
							int index = this.ListView_Account.Items.Add("vn" + Conversions.ToString(value)).Index;
							this.ListView_Account.Items[index].Name = value.ToString();
							this.ListView_Account.Items[index].SubItems.Add(text2);
							this.ListView_Account.Items[index].SubItems.Add(text3);
						}
					}
				}
				this.ListView_Account.Sort();
			}
		}
		private void Button_LoadNpc_Click(object sender, EventArgs e)
		{
			this.ListView_Npc.Invoke(this.delegate_0, new object[]
			{
				this.ListView_Npc
			});
		}
		private void method_4(ListView listView_0)
		{
			this.ListView_Npc.BeginUpdate();
			this.ProgressBar1.Value = 0;
			this.ProgressBar1.Maximum = Data.Data_Npcs.Count;
			checked
			{
				try
				{
					Dictionary<int, DataStructure.Npcs>.ValueCollection.Enumerator enumerator = Data.Data_Npcs.Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataStructure.Npcs current = enumerator.Current;
						int index = listView_0.Items.Add(Conversions.ToString(current._Id)).Index;
						listView_0.Items[index].SubItems.Add(this.StringToString(current._Name));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Lv));
						switch (current._Thuoctinh)
						{
						case 1:
							listView_0.Items[index].BackColor = Color.Tan;
							break;
						case 2:
							listView_0.Items[index].BackColor = Color.LightBlue;
							break;
						case 3:
							listView_0.Items[index].BackColor = Color.LightCoral;
							break;
						case 4:
							listView_0.Items[index].BackColor = Color.LightGreen;
							break;
						}
						listView_0.Items[index].SubItems.Add(this.GetTTNPC(current._Thuoctinh));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Hp));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Sp));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Hpx));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Spx));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Int));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Atk));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Def));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Agi));
						string text = string.Concat(new string[]
						{
							Conversions.ToString(current._Skill1),
							", ",
							Conversions.ToString(current._Skill2),
							", ",
							Conversions.ToString(current._Skill3)
						});
						text = text.Replace("0, ", "").Replace(", 0", "");
						if (Operators.CompareString(text, "0", false) == 0)
						{
							text = "";
						}
						listView_0.Items[index].SubItems.Add(text);
						string text2 = string.Concat(new string[]
						{
							Conversions.ToString(current._Item1),
							", ",
							Conversions.ToString(current._Item2),
							", ",
							Conversions.ToString(current._Item3),
							", ",
							Conversions.ToString(current._Item4),
							", ",
							Conversions.ToString(current._Item5),
							", ",
							Conversions.ToString(current._Item6)
						});
						text2 = text2.Replace("0, ", "").Replace(", 0", "");
						if (Operators.CompareString(text2, "0", false) == 0)
						{
							text2 = "";
						}
						listView_0.Items[index].SubItems.Add(text2);
						if (current._Bat == 1)
						{
							listView_0.Items[index].SubItems.Add("");
						}
						else
						{
							listView_0.Items[index].SubItems.Add("được");
						}
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Reborn));
						ProgressBar progressBar = this.ProgressBar1;
						progressBar.Value++;
						this.ProgressBar1.Update();
					}
				}
				finally
				{
					
				}
				this.ListView_Npc.EndUpdate();
				this.Button_LoadNpc.Enabled = false;
			}
		}
		private void ListView_Item_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			ColumnHeader columnHeader = (ColumnHeader)NewLateBinding.LateGet(sender, null, "Columns", new object[]
			{
				e.Column
			}, null, null, null);
			SortOrder sortOrder;
			if (this.columnHeader_44 == null)
			{
				sortOrder = SortOrder.Ascending;
			}
			else
			{
				if (columnHeader.Equals(this.columnHeader_44))
				{
					if (this.columnHeader_44.Text.StartsWith("> "))
					{
						sortOrder = SortOrder.Descending;
					}
					else
					{
						sortOrder = SortOrder.Ascending;
					}
				}
				else
				{
					sortOrder = SortOrder.Ascending;
				}
				this.columnHeader_44.Text = this.columnHeader_44.Text.Substring(2);
			}
			this.columnHeader_44 = columnHeader;
			if (sortOrder == SortOrder.Ascending)
			{
				this.columnHeader_44.Text = "> " + this.columnHeader_44.Text;
			}
			else
			{
				this.columnHeader_44.Text = "< " + this.columnHeader_44.Text;
			}
			NewLateBinding.LateSet(sender, null, "ListViewItemSorter", new object[]
			{
				new clsListviewSorter(e.Column, sortOrder)
			}, null, null);
			NewLateBinding.LateCall(sender, null, "Sort", new object[0], null, null, null, true);
		}
		public string GetTTNPC(int id)
		{
			string result = "";
			switch (id)
			{
			case 0:
				result = "Không";
				break;
			case 1:
				result = "Địa";
				break;
			case 2:
				result = "Thuỷ";
				break;
			case 3:
				result = "Hoả";
				break;
			case 4:
				result = "Phong";
				break;
			case 5:
				result = "Tâm";
				break;
			case 6:
				result = "";
				break;
			}
			return result;
		}
		public string StringToString(string text1)
		{
			string @string = "áàäãÕå¡¢ÆÇ£â¤¥¦ç§éèë¨©êª«¬­®íìïî¸óòöõ÷ô¯°±²µ½¾¶·ÞþúùüûøßÑ×ØæñýÏÖÛÜðÁÀÄÃÁÅ\u0081‚AAƒÂ„…†\u0006‡ÉÈËˆ‰ÊŠ‹Œ\u008dÊÍÌ›Î˜ÓÒ???Ô\u008f\u0090‘’´•–—³ÚÙœ\u009dÚ¿º»¼ÿ¹ÝŸ???Ð";
			string str = "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖƠỚỜỞỠÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ";
			string text2 = "";
			object obj;
			object loopObj;
            int i = 0;
            obj = i;
            loopObj = i;
			if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 0, checked(text1.Length - 1), 1, ref loopObj, ref obj))
			{
				do
				{
					string text3 = text1.Substring(Conversions.ToInteger(obj), 1);
					if (Operators.CompareString(text3, "\r", false) == 0)
					{
						text2 += "\r";
					}
					else
					{
						if (Operators.CompareString(text3, "\n", false) == 0)
						{
							text2 += "\n";
						}
						else
						{
							object obj2 = Strings.InStr(@string, text3, CompareMethod.Binary);
							if (Operators.ConditionalCompareObjectLessEqual(obj2, 0, false))
							{
								text2 += text3;
							}
							else
							{
								text2 += Strings.Mid(str, Conversions.ToInteger(obj2), 1);
							}
						}
					}
				}
				while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, loopObj, ref obj));
			}
			return text2;
		}
		private void Button__LoadItem_Click(object sender, EventArgs e)
		{
			this.ListView_Item.Invoke(this.delegate_1, new object[]
			{
				this.ListView_Item
			});
		}
		private void PvxUcloLc(ListView listView_0)
		{
			this.ListView_Item.BeginUpdate();
			this.ProgressBar1.Value = 0;
			this.ProgressBar1.Maximum = Data.Data_Items.Count;
			checked
			{
				try
				{
					Dictionary<int, DataStructure.Items>.ValueCollection.Enumerator enumerator = Data.Data_Items.Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataStructure.Items current = enumerator.Current;
						int index = listView_0.Items.Add(Conversions.ToString(current._id)).Index;
						listView_0.Items[index].SubItems.Add(this.StringToString(current._Name));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Lv));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Hp));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Sp));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Int1));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Atk1));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Def1));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Hpx1));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Spx1));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Agi1));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Fai1));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Int2));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Atk2));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Def2));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Hpx2));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Spx2));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Agi2));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Fai2));
						switch (current._Thuoctinh)
						{
						case 1:
							listView_0.Items[index].BackColor = Color.Tan;
							break;
						case 2:
							listView_0.Items[index].BackColor = Color.LightBlue;
							break;
						case 3:
							listView_0.Items[index].BackColor = Color.LightCoral;
							break;
						case 4:
							listView_0.Items[index].BackColor = Color.LightGreen;
							break;
						}
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Thuoctinh));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._GiatriThuoctinh));
						listView_0.Items[index].SubItems.Add(Conversions.ToString(current._Loai));
						ProgressBar progressBar = this.ProgressBar1;
						progressBar.Value++;
						this.ProgressBar1.Update();
					}
				}
				finally
				{
					
				}
				this.ListView_Item.EndUpdate();
				this.Button__LoadItem.Enabled = false;
			}
		}
	}
}
