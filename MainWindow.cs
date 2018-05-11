using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateNumbers
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private List<int> numsList = new List<int>();
		private string showNums = "";

		private void AddButton_Click(object sender, EventArgs e)
		{
			int num = 0;
			bool isNum = int.TryParse(InputTextBox.Text, out num);
			int total = 0;
			float avg = 0.0f;
			if (!isNum)
			{
				MessageBox.Show("請輸入合法數字");
			}
			else
			{
				numsList.Add(num);
				for (int i = numsList.Count - 1; i < numsList.Count; i++)
				{
					showNums += numsList[i].ToString() + "+";
				}
				for (int j = 0; j < numsList.Count; j++)
				{
					total += numsList[j];
					avg = (float)total / numsList.Count;
				}
				InputTextBox.Text = "";
				ShowNumsLabel.Text = showNums.Substring(0, showNums.Length - 1) + "=" + total.ToString();
				TotalLabel.Text = total.ToString();
				AvgLabel.Text = avg.ToString();
			}
		}

		private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) AddButton_Click(this, null);
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			showNums = "";
			ShowNumsLabel.Text = showNums;
			TotalLabel.Text = "";
			AvgLabel.Text = "";
			numsList.Clear();
		}
	}
}