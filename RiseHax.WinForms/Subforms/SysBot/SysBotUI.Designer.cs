﻿
namespace RiseHax.WinForms
{
    partial class SysBotUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxIP = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.GroupSysBotConnection = new System.Windows.Forms.GroupBox();
            this.LabelPort = new System.Windows.Forms.Label();
            this.LabelIP = new System.Windows.Forms.Label();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.GroupSysBotStatus = new System.Windows.Forms.GroupBox();
            this.TabControlSysBot = new System.Windows.Forms.TabControl();
            this.TabSysBot1Player = new System.Windows.Forms.TabPage();
            this.TabSysBot2Items = new System.Windows.Forms.TabPage();
            this.TabSysBot3Quest = new System.Windows.Forms.TabPage();
            this.GroupSysBotConnection.SuspendLayout();
            this.TabControlSysBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxIP
            // 
            this.TextBoxIP.AccessibleName = "TextBoxIP";
            this.TextBoxIP.Location = new System.Drawing.Point(44, 28);
            this.TextBoxIP.Name = "TextBoxIP";
            this.TextBoxIP.Size = new System.Drawing.Size(96, 20);
            this.TextBoxIP.TabIndex = 0;
            this.TextBoxIP.Text = "192.168.0.1";
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.AccessibleName = "ButtonConnect";
            this.ButtonConnect.Location = new System.Drawing.Point(44, 81);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(84, 24);
            this.ButtonConnect.TabIndex = 2;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // GroupSysBotConnection
            // 
            this.GroupSysBotConnection.AccessibleName = "GroupSysBotConnection";
            this.GroupSysBotConnection.Controls.Add(this.LabelPort);
            this.GroupSysBotConnection.Controls.Add(this.LabelIP);
            this.GroupSysBotConnection.Controls.Add(this.TextBoxPort);
            this.GroupSysBotConnection.Controls.Add(this.ButtonConnect);
            this.GroupSysBotConnection.Controls.Add(this.TextBoxIP);
            this.GroupSysBotConnection.Location = new System.Drawing.Point(829, 440);
            this.GroupSysBotConnection.Name = "GroupSysBotConnection";
            this.GroupSysBotConnection.Size = new System.Drawing.Size(163, 119);
            this.GroupSysBotConnection.TabIndex = 3;
            this.GroupSysBotConnection.TabStop = false;
            this.GroupSysBotConnection.Text = "Connection";
            // 
            // LabelPort
            // 
            this.LabelPort.AccessibleName = "LabelPort";
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(9, 57);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(29, 13);
            this.LabelPort.TabIndex = 5;
            this.LabelPort.Text = "Port:";
            // 
            // LabelIP
            // 
            this.LabelIP.AccessibleName = "LabelIP";
            this.LabelIP.AutoSize = true;
            this.LabelIP.Location = new System.Drawing.Point(18, 31);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(20, 13);
            this.LabelIP.TabIndex = 4;
            this.LabelIP.Text = "IP:";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.AccessibleName = "TextBoxPort";
            this.TextBoxPort.Location = new System.Drawing.Point(44, 54);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(96, 20);
            this.TextBoxPort.TabIndex = 3;
            this.TextBoxPort.Text = "6000";
            // 
            // GroupSysBotStatus
            // 
            this.GroupSysBotStatus.AccessibleName = "GroupSysBotStatus";
            this.GroupSysBotStatus.Location = new System.Drawing.Point(6, 440);
            this.GroupSysBotStatus.Name = "GroupSysBotStatus";
            this.GroupSysBotStatus.Size = new System.Drawing.Size(817, 119);
            this.GroupSysBotStatus.TabIndex = 4;
            this.GroupSysBotStatus.TabStop = false;
            this.GroupSysBotStatus.Text = "Status";
            // 
            // TabControlSysBot
            // 
            this.TabControlSysBot.AccessibleName = "TabControlSysBot";
            this.TabControlSysBot.Controls.Add(this.TabSysBot1Player);
            this.TabControlSysBot.Controls.Add(this.TabSysBot2Items);
            this.TabControlSysBot.Controls.Add(this.TabSysBot3Quest);
            this.TabControlSysBot.Location = new System.Drawing.Point(2, 3);
            this.TabControlSysBot.Name = "TabControlSysBot";
            this.TabControlSysBot.SelectedIndex = 0;
            this.TabControlSysBot.Size = new System.Drawing.Size(990, 431);
            this.TabControlSysBot.TabIndex = 0;
            // 
            // TabSysBot1Player
            // 
            this.TabSysBot1Player.AccessibleName = "TabSysBot1Player";
            this.TabSysBot1Player.Location = new System.Drawing.Point(4, 22);
            this.TabSysBot1Player.Name = "TabSysBot1Player";
            this.TabSysBot1Player.Padding = new System.Windows.Forms.Padding(3);
            this.TabSysBot1Player.Size = new System.Drawing.Size(982, 405);
            this.TabSysBot1Player.TabIndex = 0;
            this.TabSysBot1Player.Text = "Player";
            this.TabSysBot1Player.UseVisualStyleBackColor = true;
            // 
            // TabSysBot2Items
            // 
            this.TabSysBot2Items.AccessibleName = "TabSysBot2Items";
            this.TabSysBot2Items.Location = new System.Drawing.Point(4, 22);
            this.TabSysBot2Items.Name = "TabSysBot2Items";
            this.TabSysBot2Items.Padding = new System.Windows.Forms.Padding(3);
            this.TabSysBot2Items.Size = new System.Drawing.Size(982, 405);
            this.TabSysBot2Items.TabIndex = 1;
            this.TabSysBot2Items.Text = "Items";
            this.TabSysBot2Items.UseVisualStyleBackColor = true;
            // 
            // TabSysBot3Quest
            // 
            this.TabSysBot3Quest.AccessibleName = "TabSysBot3Quest";
            this.TabSysBot3Quest.Location = new System.Drawing.Point(4, 22);
            this.TabSysBot3Quest.Name = "TabSysBot3Quest";
            this.TabSysBot3Quest.Padding = new System.Windows.Forms.Padding(3);
            this.TabSysBot3Quest.Size = new System.Drawing.Size(982, 405);
            this.TabSysBot3Quest.TabIndex = 2;
            this.TabSysBot3Quest.Text = "Quest";
            this.TabSysBot3Quest.UseVisualStyleBackColor = true;
            // 
            // SysBotUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 563);
            this.Controls.Add(this.TabControlSysBot);
            this.Controls.Add(this.GroupSysBotStatus);
            this.Controls.Add(this.GroupSysBotConnection);
            this.Icon = global::RiseHax.WinForms.Properties.Resources.icon;
            this.Name = "SysBotUI";
            this.Text = "RiseHax";
            this.Load += new System.EventHandler(this.SysBotUI_Load);
            this.GroupSysBotConnection.ResumeLayout(false);
            this.GroupSysBotConnection.PerformLayout();
            this.TabControlSysBot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxIP;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.GroupBox GroupSysBotConnection;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.Label LabelIP;
        private System.Windows.Forms.TextBox TextBoxPort;
        private System.Windows.Forms.GroupBox GroupSysBotStatus;
        private System.Windows.Forms.TabControl TabControlSysBot;
        private System.Windows.Forms.TabPage TabSysBot1Player;
        private System.Windows.Forms.TabPage TabSysBot2Items;
        private System.Windows.Forms.TabPage TabSysBot3Quest;
    }
}