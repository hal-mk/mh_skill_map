
namespace mh_skill_map.App
{
    partial class MainPanel
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
            this.weapon = new System.Windows.Forms.Label();
            this.head = new System.Windows.Forms.Label();
            this.chest = new System.Windows.Forms.Label();
            this.arm = new System.Windows.Forms.Label();
            this.hip = new System.Windows.Forms.Label();
            this.leg = new System.Windows.Forms.Label();
            this.weaponBox = new System.Windows.Forms.ComboBox();
            this.headBox = new System.Windows.Forms.ComboBox();
            this.chestBox = new System.Windows.Forms.ComboBox();
            this.armBox = new System.Windows.Forms.ComboBox();
            this.hipBox = new System.Windows.Forms.ComboBox();
            this.legBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.statusListLeft = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // weapon
            // 
            this.weapon.AutoSize = true;
            this.weapon.Location = new System.Drawing.Point(20, 20);
            this.weapon.Name = "weapon";
            this.weapon.Size = new System.Drawing.Size(37, 15);
            this.weapon.TabIndex = 0;
            this.weapon.Text = "武器";
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Location = new System.Drawing.Point(20, 55);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(22, 15);
            this.head.TabIndex = 7;
            this.head.Text = "頭";
            // 
            // chest
            // 
            this.chest.AutoSize = true;
            this.chest.Location = new System.Drawing.Point(20, 90);
            this.chest.Name = "chest";
            this.chest.Size = new System.Drawing.Size(22, 15);
            this.chest.TabIndex = 11;
            this.chest.Text = "胸";
            // 
            // arm
            // 
            this.arm.AutoSize = true;
            this.arm.Location = new System.Drawing.Point(20, 125);
            this.arm.Name = "arm";
            this.arm.Size = new System.Drawing.Size(22, 15);
            this.arm.TabIndex = 10;
            this.arm.Text = "腕";
            // 
            // hip
            // 
            this.hip.AutoSize = true;
            this.hip.Location = new System.Drawing.Point(20, 160);
            this.hip.Name = "hip";
            this.hip.Size = new System.Drawing.Size(22, 15);
            this.hip.TabIndex = 9;
            this.hip.Text = "腰";
            // 
            // leg
            // 
            this.leg.AutoSize = true;
            this.leg.Location = new System.Drawing.Point(20, 195);
            this.leg.Name = "leg";
            this.leg.Size = new System.Drawing.Size(22, 15);
            this.leg.TabIndex = 12;
            this.leg.Text = "脚";
            // 
            // weaponBox
            // 
            this.weaponBox.FormattingEnabled = true;
            this.weaponBox.Items.AddRange(new object[] {
            "a"});
            this.weaponBox.Location = new System.Drawing.Point(74, 17);
            this.weaponBox.Name = "weaponBox";
            this.weaponBox.Size = new System.Drawing.Size(150, 23);
            this.weaponBox.TabIndex = 13;
            this.weaponBox.Text = "装備名";
            this.weaponBox.SelectedIndexChanged += new System.EventHandler(this.weaponBox_SelectedIndexChanged);
            // 
            // headBox
            // 
            this.headBox.FormattingEnabled = true;
            this.headBox.Location = new System.Drawing.Point(74, 52);
            this.headBox.Name = "headBox";
            this.headBox.Size = new System.Drawing.Size(150, 23);
            this.headBox.TabIndex = 18;
            this.headBox.Text = "装備名";
            // 
            // chestBox
            // 
            this.chestBox.FormattingEnabled = true;
            this.chestBox.Location = new System.Drawing.Point(74, 87);
            this.chestBox.Name = "chestBox";
            this.chestBox.Size = new System.Drawing.Size(150, 23);
            this.chestBox.TabIndex = 17;
            this.chestBox.Text = "装備名";
            // 
            // armBox
            // 
            this.armBox.FormattingEnabled = true;
            this.armBox.Location = new System.Drawing.Point(74, 122);
            this.armBox.Name = "armBox";
            this.armBox.Size = new System.Drawing.Size(150, 23);
            this.armBox.TabIndex = 16;
            this.armBox.Text = "装備名";
            // 
            // hipBox
            // 
            this.hipBox.FormattingEnabled = true;
            this.hipBox.Location = new System.Drawing.Point(74, 157);
            this.hipBox.Name = "hipBox";
            this.hipBox.Size = new System.Drawing.Size(150, 23);
            this.hipBox.TabIndex = 15;
            this.hipBox.Text = "装備名";
            // 
            // legBox
            // 
            this.legBox.FormattingEnabled = true;
            this.legBox.Location = new System.Drawing.Point(74, 192);
            this.legBox.Name = "legBox";
            this.legBox.Size = new System.Drawing.Size(150, 23);
            this.legBox.TabIndex = 14;
            this.legBox.Text = "装備名";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(120, 227);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 50);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // statusListLeft
            // 
            this.statusListLeft.HideSelection = false;
            this.statusListLeft.Location = new System.Drawing.Point(248, 17);
            this.statusListLeft.Name = "statusListLeft";
            this.statusListLeft.Size = new System.Drawing.Size(455, 735);
            this.statusListLeft.TabIndex = 20;
            this.statusListLeft.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(703, 17);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(0, 0);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(730, 17);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(455, 735);
            this.listView2.TabIndex = 23;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 769);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.weapon);
            this.Controls.Add(this.head);
            this.Controls.Add(this.chest);
            this.Controls.Add(this.arm);
            this.Controls.Add(this.hip);
            this.Controls.Add(this.leg);
            this.Controls.Add(this.weaponBox);
            this.Controls.Add(this.headBox);
            this.Controls.Add(this.chestBox);
            this.Controls.Add(this.armBox);
            this.Controls.Add(this.hipBox);
            this.Controls.Add(this.legBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.statusListLeft);
            this.Name = "MainPanel";
            this.Text = "MONSTER HUNTER RISE 装備スキルシミュレーター";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weapon;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Label chest;
        private System.Windows.Forms.Label arm;
        private System.Windows.Forms.Label hip;
        private System.Windows.Forms.Label leg;
        private System.Windows.Forms.ComboBox weaponBox;
        private System.Windows.Forms.ComboBox headBox;
        private System.Windows.Forms.ComboBox chestBox;
        private System.Windows.Forms.ComboBox armBox;
        private System.Windows.Forms.ComboBox hipBox;
        private System.Windows.Forms.ComboBox legBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView statusListLeft;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
    }
}