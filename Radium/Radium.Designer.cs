namespace Radium
{
    partial class Radium
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
            this.Executor = new Guna.UI2.WinForms.Guna2Panel();
            this.TabPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SettingButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ScriptHubButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.EditorButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Icon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Title = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Editor = new System.Windows.Forms.WebBrowser();
            this.Executor.SuspendLayout();
            this.TabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Executor
            // 
            this.Executor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Executor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Executor.BorderRadius = 10;
            this.Executor.BorderThickness = 2;
            this.Executor.Controls.Add(this.Editor);
            this.Executor.Location = new System.Drawing.Point(12, 82);
            this.Executor.Name = "Executor";
            this.Executor.Size = new System.Drawing.Size(756, 321);
            this.Executor.TabIndex = 0;
            // 
            // TabPanel
            // 
            this.TabPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TabPanel.BorderRadius = 10;
            this.TabPanel.BorderThickness = 2;
            this.TabPanel.Controls.Add(this.SettingButton);
            this.TabPanel.Controls.Add(this.ScriptHubButton);
            this.TabPanel.Controls.Add(this.EditorButton);
            this.TabPanel.Location = new System.Drawing.Point(285, 8);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.Size = new System.Drawing.Size(219, 64);
            this.TabPanel.TabIndex = 1;
            // 
            // SettingButton
            // 
            this.SettingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SettingButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SettingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingButton.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.SettingButton.Image = global::Radium.Properties.Resources.Radium_Icon;
            this.SettingButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.SettingButton.ImageRotate = 0F;
            this.SettingButton.ImageSize = new System.Drawing.Size(30, 30);
            this.SettingButton.Location = new System.Drawing.Point(149, 2);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.SettingButton.Size = new System.Drawing.Size(60, 60);
            this.SettingButton.TabIndex = 2;
            // 
            // ScriptHubButton
            // 
            this.ScriptHubButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScriptHubButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ScriptHubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScriptHubButton.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.ScriptHubButton.Image = global::Radium.Properties.Resources.ScriptHub;
            this.ScriptHubButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.ScriptHubButton.ImageRotate = 0F;
            this.ScriptHubButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ScriptHubButton.Location = new System.Drawing.Point(79, 2);
            this.ScriptHubButton.Name = "ScriptHubButton";
            this.ScriptHubButton.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.ScriptHubButton.Size = new System.Drawing.Size(60, 60);
            this.ScriptHubButton.TabIndex = 1;
            // 
            // EditorButton
            // 
            this.EditorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditorButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.EditorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditorButton.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.EditorButton.Image = global::Radium.Properties.Resources.EDITOR;
            this.EditorButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.EditorButton.ImageRotate = 0F;
            this.EditorButton.ImageSize = new System.Drawing.Size(30, 30);
            this.EditorButton.Location = new System.Drawing.Point(9, 2);
            this.EditorButton.Name = "EditorButton";
            this.EditorButton.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.EditorButton.Size = new System.Drawing.Size(60, 60);
            this.EditorButton.TabIndex = 0;
            // 
            // Icon
            // 
            this.Icon.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Icon.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.Icon.Image = global::Radium.Properties.Resources.Radium_Icon;
            this.Icon.ImageOffset = new System.Drawing.Point(0, 0);
            this.Icon.ImageRotate = 0F;
            this.Icon.ImageSize = new System.Drawing.Size(45, 45);
            this.Icon.Location = new System.Drawing.Point(12, 8);
            this.Icon.Name = "Icon";
            this.Icon.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.Icon.Size = new System.Drawing.Size(68, 68);
            this.Icon.TabIndex = 3;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(75, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(91, 30);
            this.Title.TabIndex = 0;
            this.Title.Text = "Radium";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 20;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.Executor;
            // 
            // Editor
            // 
            this.Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editor.Location = new System.Drawing.Point(0, 0);
            this.Editor.MinimumSize = new System.Drawing.Size(20, 20);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(756, 321);
            this.Editor.TabIndex = 0;
            // 
            // Radium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 479);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.TabPanel);
            this.Controls.Add(this.Executor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Radium";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Radium_Load);
            this.Executor.ResumeLayout(false);
            this.TabPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Executor;
        private Guna.UI2.WinForms.Guna2Panel TabPanel;
        private Guna.UI2.WinForms.Guna2ImageButton SettingButton;
        private Guna.UI2.WinForms.Guna2ImageButton ScriptHubButton;
        private Guna.UI2.WinForms.Guna2ImageButton EditorButton;
        private Guna.UI2.WinForms.Guna2ImageButton Icon;
        private System.Windows.Forms.Label Title;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.WebBrowser Editor;
    }
}

