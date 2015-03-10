using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Windows.Forms;
namespace Server_TS_Online
{
	public class clsListviewSorter : IComparer
	{
		private int int_0;
		private SortOrder sortOrder_0;
		public clsListviewSorter(int column_number, SortOrder sort_order)
		{
			this.int_0 = column_number;
			this.sortOrder_0 = sort_order;
		}
		public int Compare(object x, object y)
		{
			ListViewItem listViewItem = (ListViewItem)x;
			ListViewItem listViewItem2 = (ListViewItem)y;
			string text;
			if (listViewItem.SubItems.Count <= this.int_0)
			{
				text = "";
			}
			else
			{
				text = listViewItem.SubItems[this.int_0].Text;
			}
			string text2;
			if (listViewItem2.SubItems.Count <= this.int_0)
			{
				text2 = "";
			}
			else
			{
				text2 = listViewItem2.SubItems[this.int_0].Text;
			}
			if (this.sortOrder_0 == SortOrder.Ascending)
			{
				if (Versioned.IsNumeric(text) & Versioned.IsNumeric(text2))
				{
					return Conversion.Val(text).CompareTo(Conversion.Val(text2));
				}
				if (Information.IsDate(text) & Information.IsDate(text2))
				{
					return DateTime.Parse(text).CompareTo(DateTime.Parse(text2));
				}
				return string.Compare(text, text2);
			}
			else
			{
				if (Versioned.IsNumeric(text) & Versioned.IsNumeric(text2))
				{
					return Conversion.Val(text2).CompareTo(Conversion.Val(text));
				}
				if (Information.IsDate(text) & Information.IsDate(text2))
				{
					return DateTime.Parse(text2).CompareTo(DateTime.Parse(text));
				}
				return string.Compare(text2, text);
			}
		}
	}
}
