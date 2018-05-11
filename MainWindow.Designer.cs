namespace CalculateNumbers
{
	partial class MainWindow
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.TotalTitle = new System.Windows.Forms.Label();
			this.AverageTitle = new System.Windows.Forms.Label();
			this.TotalLabel = new System.Windows.Forms.Label();
			this.AvgLabel = new System.Windows.Forms.Label();
			this.ShowNumsLabel = new System.Windows.Forms.Label();
			this.ClearButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// InputTextBox
			// 
			this.InputTextBox.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.InputTextBox.Location = new System.Drawing.Point(37, 31);
			this.InputTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(458, 167);
			this.InputTextBox.TabIndex = 0;
			this.InputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextBox_KeyDown);
			// 
			// AddButton
			// 
			this.AddButton.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.AddButton.Location = new System.Drawing.Point(517, 31);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(166, 167);
			this.AddButton.TabIndex = 1;
			this.AddButton.Text = "+";
			this.AddButton.UseCompatibleTextRendering = true;
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// TotalTitle
			// 
			this.TotalTitle.AutoSize = true;
			this.TotalTitle.Location = new System.Drawing.Point(97, 362);
			this.TotalTitle.Name = "TotalTitle";
			this.TotalTitle.Size = new System.Drawing.Size(129, 48);
			this.TotalTitle.TabIndex = 2;
			this.TotalTitle.Text = "Total :";
			// 
			// AverageTitle
			// 
			this.AverageTitle.AutoSize = true;
			this.AverageTitle.Location = new System.Drawing.Point(41, 420);
			this.AverageTitle.Name = "AverageTitle";
			this.AverageTitle.Size = new System.Drawing.Size(185, 48);
			this.AverageTitle.TabIndex = 3;
			this.AverageTitle.Text = "Average :";
			// 
			// TotalLabel
			// 
			this.TotalLabel.AutoSize = true;
			this.TotalLabel.Location = new System.Drawing.Point(247, 362);
			this.TotalLabel.Name = "TotalLabel";
			this.TotalLabel.Size = new System.Drawing.Size(0, 48);
			this.TotalLabel.TabIndex = 4;
			// 
			// AvgLabel
			// 
			this.AvgLabel.AutoSize = true;
			this.AvgLabel.Location = new System.Drawing.Point(247, 420);
			this.AvgLabel.Name = "AvgLabel";
			this.AvgLabel.Size = new System.Drawing.Size(0, 48);
			this.AvgLabel.TabIndex = 5;
			// 
			// ShowNumsLabel
			// 
			this.ShowNumsLabel.AutoSize = true;
			this.ShowNumsLabel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ShowNumsLabel.Location = new System.Drawing.Point(37, 238);
			this.ShowNumsLabel.MaximumSize = new System.Drawing.Size(650, 0);
			this.ShowNumsLabel.Name = "ShowNumsLabel";
			this.ShowNumsLabel.Size = new System.Drawing.Size(0, 35);
			this.ShowNumsLabel.TabIndex = 6;
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(517, 362);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(166, 104);
			this.ClearButton.TabIndex = 7;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 47F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 525);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.ShowNumsLabel);
			this.Controls.Add(this.AvgLabel);
			this.Controls.Add(this.TotalLabel);
			this.Controls.Add(this.AverageTitle);
			this.Controls.Add(this.TotalTitle);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.InputTextBox);
			this.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.Name = "MainWindow";
			this.Text = "計算總和平均";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox InputTextBox;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Label TotalTitle;
		private System.Windows.Forms.Label AverageTitle;
		private System.Windows.Forms.Label TotalLabel;
		private System.Windows.Forms.Label AvgLabel;
		private System.Windows.Forms.Label ShowNumsLabel;
		private System.Windows.Forms.Button ClearButton;
	}
}

