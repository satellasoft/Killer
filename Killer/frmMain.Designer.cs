namespace Killer
{
	partial class frmMain
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.panelBottom = new System.Windows.Forms.Panel();
			this.panelLeft = new System.Windows.Forms.Panel();
			this.panelRight = new System.Windows.Forms.Panel();
			this.listWindowsProcess = new System.Windows.Forms.ListBox();
			this.listKillProcess = new System.Windows.Forms.ListBox();
			this.btnScan = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnKill = new System.Windows.Forms.Button();
			this.panelBottom.SuspendLayout();
			this.panelLeft.SuspendLayout();
			this.panelRight.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelBottom
			// 
			this.panelBottom.Controls.Add(this.btnKill);
			this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBottom.Location = new System.Drawing.Point(0, 453);
			this.panelBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size(782, 100);
			this.panelBottom.TabIndex = 0;
			// 
			// panelLeft
			// 
			this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panelLeft.Controls.Add(this.btnAdd);
			this.panelLeft.Controls.Add(this.btnScan);
			this.panelLeft.Controls.Add(this.listWindowsProcess);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Location = new System.Drawing.Point(0, 0);
			this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(385, 453);
			this.panelLeft.TabIndex = 1;
			// 
			// panelRight
			// 
			this.panelRight.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panelRight.Controls.Add(this.button1);
			this.panelRight.Controls.Add(this.btnRemove);
			this.panelRight.Controls.Add(this.listKillProcess);
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelRight.Location = new System.Drawing.Point(397, 0);
			this.panelRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(385, 453);
			this.panelRight.TabIndex = 3;
			// 
			// listWindowsProcess
			// 
			this.listWindowsProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listWindowsProcess.Dock = System.Windows.Forms.DockStyle.Top;
			this.listWindowsProcess.FormattingEnabled = true;
			this.listWindowsProcess.HorizontalScrollbar = true;
			this.listWindowsProcess.ItemHeight = 20;
			this.listWindowsProcess.Location = new System.Drawing.Point(0, 0);
			this.listWindowsProcess.Name = "listWindowsProcess";
			this.listWindowsProcess.Size = new System.Drawing.Size(385, 382);
			this.listWindowsProcess.TabIndex = 0;
			// 
			// listKillProcess
			// 
			this.listKillProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listKillProcess.Dock = System.Windows.Forms.DockStyle.Top;
			this.listKillProcess.FormattingEnabled = true;
			this.listKillProcess.HorizontalScrollbar = true;
			this.listKillProcess.ItemHeight = 20;
			this.listKillProcess.Location = new System.Drawing.Point(0, 0);
			this.listKillProcess.Name = "listKillProcess";
			this.listKillProcess.Size = new System.Drawing.Size(385, 382);
			this.listKillProcess.TabIndex = 0;
			// 
			// btnScan
			// 
			this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnScan.Location = new System.Drawing.Point(3, 388);
			this.btnScan.Name = "btnScan";
			this.btnScan.Size = new System.Drawing.Size(180, 60);
			this.btnScan.TabIndex = 1;
			this.btnScan.Text = "SCAN";
			this.btnScan.UseVisualStyleBackColor = false;
			this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnAdd.Location = new System.Drawing.Point(201, 388);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(180, 60);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(201, 386);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(180, 60);
			this.button1.TabIndex = 4;
			this.button1.Text = "ADD";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// btnRemove
			// 
			this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnRemove.Location = new System.Drawing.Point(3, 386);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(180, 60);
			this.btnRemove.TabIndex = 3;
			this.btnRemove.Text = "REMOVE";
			this.btnRemove.UseVisualStyleBackColor = false;
			// 
			// btnKill
			// 
			this.btnKill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnKill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnKill.Enabled = false;
			this.btnKill.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKill.ForeColor = System.Drawing.Color.White;
			this.btnKill.Location = new System.Drawing.Point(0, 0);
			this.btnKill.Name = "btnKill";
			this.btnKill.Size = new System.Drawing.Size(782, 100);
			this.btnKill.TabIndex = 2;
			this.btnKill.Text = "KILL";
			this.btnKill.UseVisualStyleBackColor = false;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(782, 553);
			this.Controls.Add(this.panelRight);
			this.Controls.Add(this.panelLeft);
			this.Controls.Add(this.panelBottom);
			this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kill";
			this.panelBottom.ResumeLayout(false);
			this.panelLeft.ResumeLayout(false);
			this.panelRight.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBottom;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.Panel panelRight;
		private System.Windows.Forms.ListBox listWindowsProcess;
		private System.Windows.Forms.ListBox listKillProcess;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnScan;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnKill;
	}
}

