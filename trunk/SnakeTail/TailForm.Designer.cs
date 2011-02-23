﻿#region License statement
/* SnakeTail is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, version 3 of the License.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
#endregion

namespace SnakeTail
{
    partial class TailForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TailForm));
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._tailTimer = new System.Windows.Forms.Timer(this.components);
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._statusTextBar = new System.Windows.Forms.ToolStripStatusLabel();
            this._statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._activeWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configBckGndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tailListView = new SnakeTail.LogFileListView();
            this.hiddenItem = new System.Windows.Forms.ColumnHeader();
            this.lineItem = new System.Windows.Forms.ColumnHeader();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._contextMenuStrip.SuspendLayout();
            this._statusStrip.SuspendLayout();
            this._menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(200, 6);
            // 
            // _contextMenuStrip
            // 
            this._contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripSeparator1});
            this._contextMenuStrip.Name = "contextMenuStrip1";
            this._contextMenuStrip.Size = new System.Drawing.Size(61, 10);
            this._contextMenuStrip.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this._contextMenuStrip_Closed);
            this._contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this._contextMenuStrip_Opening);
            // 
            // _tailTimer
            // 
            this._tailTimer.Interval = 50;
            this._tailTimer.Tick += new System.EventHandler(this._tailTimer_Tick);
            // 
            // _statusStrip
            // 
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusTextBar,
            this._statusProgressBar});
            this._statusStrip.Location = new System.Drawing.Point(0, 257);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(332, 22);
            this._statusStrip.TabIndex = 1;
            this._statusStrip.Text = "statusStrip1";
            this._statusStrip.Visible = false;
            // 
            // _statusTextBar
            // 
            this._statusTextBar.Name = "_statusTextBar";
            this._statusTextBar.Size = new System.Drawing.Size(215, 17);
            this._statusTextBar.Spring = true;
            this._statusTextBar.Text = "Ready";
            this._statusTextBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _statusProgressBar
            // 
            this._statusProgressBar.Name = "_statusProgressBar";
            this._statusProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._activeWindowMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(332, 24);
            this._menuStrip.TabIndex = 2;
            this._menuStrip.Text = "menuStrip1";
            this._menuStrip.Visible = false;
            // 
            // _activeWindowMenuItem
            // 
            this._activeWindowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._copyToolStripMenuItem,
            this.findToolStripMenuItem,
            this.findNextToolStripMenuItem,
            this.switchModeToolStripMenuItem,
            toolStripSeparator3,
            this.configTextToolStripMenuItem,
            this.configBckGndToolStripMenuItem,
            toolStripSeparator4,
            this.startServiceToolStripMenuItem,
            this.stopServiceToolStripMenuItem,
            this.pauseServiceToolStripMenuItem,
            this.resumeServiceToolStripMenuItem});
            this._activeWindowMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this._activeWindowMenuItem.MergeIndex = 1;
            this._activeWindowMenuItem.Name = "_activeWindowMenuItem";
            this._activeWindowMenuItem.Size = new System.Drawing.Size(39, 20);
            this._activeWindowMenuItem.Text = "Edit";
            this._activeWindowMenuItem.DropDownOpening += new System.EventHandler(this._contextMenuStrip_Opening);
            // 
            // _copyToolStripMenuItem
            // 
            this._copyToolStripMenuItem.Name = "_copyToolStripMenuItem";
            this._copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this._copyToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this._copyToolStripMenuItem.Text = "Copy";
            this._copyToolStripMenuItem.Click += new System.EventHandler(this._copyToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.findToolStripMenuItem.Text = "Find...";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.findNextToolStripMenuItem.Text = "Find Next";
            this.findNextToolStripMenuItem.Click += new System.EventHandler(this.findNextToolStripMenuItem_Click);
            // 
            // switchModeToolStripMenuItem
            // 
            this.switchModeToolStripMenuItem.Name = "switchModeToolStripMenuItem";
            this.switchModeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.switchModeToolStripMenuItem.Text = "Switch window mode";
            this.switchModeToolStripMenuItem.Click += new System.EventHandler(this.switchToModelessToolStripMenuItem_Click);
            // 
            // configTextToolStripMenuItem
            // 
            this.configTextToolStripMenuItem.Name = "configTextToolStripMenuItem";
            this.configTextToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.configTextToolStripMenuItem.Text = "Configure text...";
            this.configTextToolStripMenuItem.Click += new System.EventHandler(this.configureFontToolStripMenuItem_Click);
            // 
            // configBckGndToolStripMenuItem
            // 
            this.configBckGndToolStripMenuItem.Name = "configBckGndToolStripMenuItem";
            this.configBckGndToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.configBckGndToolStripMenuItem.Text = "Configure background...";
            this.configBckGndToolStripMenuItem.Click += new System.EventHandler(this.configureBackgroundColorToolStripMenuItem_Click);
            // 
            // startServiceToolStripMenuItem
            // 
            this.startServiceToolStripMenuItem.Name = "startServiceToolStripMenuItem";
            this.startServiceToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.startServiceToolStripMenuItem.Text = "Start Service...";
            this.startServiceToolStripMenuItem.Click += new System.EventHandler(this.startServiceToolStripMenuItem_Click);
            // 
            // stopServiceToolStripMenuItem
            // 
            this.stopServiceToolStripMenuItem.Name = "stopServiceToolStripMenuItem";
            this.stopServiceToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.stopServiceToolStripMenuItem.Text = "Stop Service...";
            this.stopServiceToolStripMenuItem.Click += new System.EventHandler(this.stopServiceToolStripMenuItem_Click);
            // 
            // pauseServiceToolStripMenuItem
            // 
            this.pauseServiceToolStripMenuItem.Name = "pauseServiceToolStripMenuItem";
            this.pauseServiceToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.pauseServiceToolStripMenuItem.Text = "Pause Service...";
            this.pauseServiceToolStripMenuItem.Click += new System.EventHandler(this.pauseServiceToolStripMenuItem_Click);
            // 
            // resumeServiceToolStripMenuItem
            // 
            this.resumeServiceToolStripMenuItem.Name = "resumeServiceToolStripMenuItem";
            this.resumeServiceToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.resumeServiceToolStripMenuItem.Text = "Resume Service...";
            this.resumeServiceToolStripMenuItem.Click += new System.EventHandler(this.resumeServiceToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(57, 6);
            // 
            // _tailListView
            // 
            this._tailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hiddenItem,
            this.lineItem});
            this._tailListView.ContextMenuStrip = this._contextMenuStrip;
            this._tailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tailListView.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tailListView.FullRowSelect = true;
            this._tailListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this._tailListView.HideSelection = false;
            this._tailListView.Location = new System.Drawing.Point(0, 0);
            this._tailListView.Margin = new System.Windows.Forms.Padding(0);
            this._tailListView.Name = "_tailListView";
            this._tailListView.OwnerDraw = true;
            this._tailListView.Size = new System.Drawing.Size(332, 279);
            this._tailListView.TabIndex = 0;
            this._tailListView.UseCompatibleStateImageBehavior = false;
            this._tailListView.View = System.Windows.Forms.View.Details;
            this._tailListView.VirtualMode = true;
            this._tailListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this._tailListView_DrawItem);
            this._tailListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this._tailListView_RetrieveVirtualItem);
            this._tailListView.CacheVirtualItems += new System.Windows.Forms.CacheVirtualItemsEventHandler(this._tailListView_CacheVirtualItems);
            this._tailListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this._tailListView_KeyDown);
            this._tailListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this._tailListView_DrawSubItem);
            // 
            // hiddenItem
            // 
            this.hiddenItem.Width = 0;
            // 
            // TailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 279);
            this.Controls.Add(this._statusStrip);
            this.Controls.Add(this._menuStrip);
            this.Controls.Add(this._tailListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this._menuStrip;
            this.Name = "TailForm";
            this.Text = "TailForm";
            this.Load += new System.EventHandler(this.TailForm_Load);
            this.Activated += new System.EventHandler(this.TailForm_Activated);
            this.Resize += new System.EventHandler(this.TailForm_Resize);
            this._contextMenuStrip.ResumeLayout(false);
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LogFileListView _tailListView;
        private System.Windows.Forms.Timer _tailTimer;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
        private System.Windows.Forms.ColumnHeader hiddenItem;
        private System.Windows.Forms.ColumnHeader lineItem;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.ToolStripProgressBar _statusProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel _statusTextBar;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _activeWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configBckGndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeServiceToolStripMenuItem;
    }
}