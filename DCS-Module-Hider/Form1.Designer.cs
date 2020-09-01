﻿namespace DCS_Module_Hider
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_selectTheModules = new System.Windows.Forms.Label();
            this.button2_confirmAndExport = new System.Windows.Forms.Button();
            this.button1_selectLua = new System.Windows.Forms.Button();
            this.textBox1_luaLocation = new System.Windows.Forms.TextBox();
            this.checkedListBox1_modules = new System.Windows.Forms.CheckedListBox();
            this.button3_deleteLua = new System.Windows.Forms.Button();
            this.button4_helpReadmee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_selectTheModules
            // 
            this.label1_selectTheModules.AutoSize = true;
            this.label1_selectTheModules.Location = new System.Drawing.Point(12, 9);
            this.label1_selectTheModules.Name = "label1_selectTheModules";
            this.label1_selectTheModules.Size = new System.Drawing.Size(206, 13);
            this.label1_selectTheModules.TabIndex = 0;
            this.label1_selectTheModules.Text = "Select the DCS modules you want to hide:";
            this.label1_selectTheModules.Click += new System.EventHandler(this.label1_selectTheModules_Click);
            // 
            // button2_confirmAndExport
            // 
            this.button2_confirmAndExport.Location = new System.Drawing.Point(15, 409);
            this.button2_confirmAndExport.Name = "button2_confirmAndExport";
            this.button2_confirmAndExport.Size = new System.Drawing.Size(141, 23);
            this.button2_confirmAndExport.TabIndex = 1;
            this.button2_confirmAndExport.Text = "Confirm and Export";
            this.button2_confirmAndExport.UseVisualStyleBackColor = true;
            this.button2_confirmAndExport.Click += new System.EventHandler(this.button2_confirmAndExport_Click);
            // 
            // button1_selectLua
            // 
            this.button1_selectLua.Location = new System.Drawing.Point(15, 380);
            this.button1_selectLua.Name = "button1_selectLua";
            this.button1_selectLua.Size = new System.Drawing.Size(141, 23);
            this.button1_selectLua.TabIndex = 2;
            this.button1_selectLua.Text = "Select DCS Config Folder";
            this.button1_selectLua.UseVisualStyleBackColor = true;
            this.button1_selectLua.Click += new System.EventHandler(this.button1_selectLua_Click);
            // 
            // textBox1_luaLocation
            // 
            this.textBox1_luaLocation.Location = new System.Drawing.Point(15, 354);
            this.textBox1_luaLocation.Name = "textBox1_luaLocation";
            this.textBox1_luaLocation.ReadOnly = true;
            this.textBox1_luaLocation.Size = new System.Drawing.Size(267, 20);
            this.textBox1_luaLocation.TabIndex = 3;
            // 
            // checkedListBox1_modules
            // 
            this.checkedListBox1_modules.FormattingEnabled = true;
            this.checkedListBox1_modules.Location = new System.Drawing.Point(15, 25);
            this.checkedListBox1_modules.Name = "checkedListBox1_modules";
            this.checkedListBox1_modules.Size = new System.Drawing.Size(267, 319);
            this.checkedListBox1_modules.TabIndex = 4;
            // 
            // button3_deleteLua
            // 
            this.button3_deleteLua.Location = new System.Drawing.Point(162, 380);
            this.button3_deleteLua.Name = "button3_deleteLua";
            this.button3_deleteLua.Size = new System.Drawing.Size(120, 23);
            this.button3_deleteLua.TabIndex = 5;
            this.button3_deleteLua.Text = "Unhide DCS Modules";
            this.button3_deleteLua.UseVisualStyleBackColor = true;
            this.button3_deleteLua.Click += new System.EventHandler(this.button3_deleteLua_Click);
            // 
            // button4_helpReadmee
            // 
            this.button4_helpReadmee.Location = new System.Drawing.Point(162, 409);
            this.button4_helpReadmee.Name = "button4_helpReadmee";
            this.button4_helpReadmee.Size = new System.Drawing.Size(120, 23);
            this.button4_helpReadmee.TabIndex = 6;
            this.button4_helpReadmee.Text = "Help / Readmee";
            this.button4_helpReadmee.UseVisualStyleBackColor = true;
            this.button4_helpReadmee.Click += new System.EventHandler(this.button4_helpReadmee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 442);
            this.Controls.Add(this.button4_helpReadmee);
            this.Controls.Add(this.button3_deleteLua);
            this.Controls.Add(this.checkedListBox1_modules);
            this.Controls.Add(this.textBox1_luaLocation);
            this.Controls.Add(this.button1_selectLua);
            this.Controls.Add(this.button2_confirmAndExport);
            this.Controls.Add(this.label1_selectTheModules);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DMoHi v1 by Bailey";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_selectTheModules;
        private System.Windows.Forms.Button button2_confirmAndExport;
        private System.Windows.Forms.Button button1_selectLua;
        private System.Windows.Forms.TextBox textBox1_luaLocation;
        private System.Windows.Forms.CheckedListBox checkedListBox1_modules;
        private System.Windows.Forms.Button button3_deleteLua;
        private System.Windows.Forms.Button button4_helpReadmee;
    }
}

