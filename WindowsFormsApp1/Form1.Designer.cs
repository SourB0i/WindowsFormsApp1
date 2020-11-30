namespace WindowsFormsApp1
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
            this.BTN_Right = new System.Windows.Forms.Button();
            this.BTN_Left = new System.Windows.Forms.Button();
            this.BTN_Down = new System.Windows.Forms.Button();
            this.BTN_Up = new System.Windows.Forms.Button();
            this.LBL_map = new System.Windows.Forms.Label();
            this.lbl_Hero = new System.Windows.Forms.Label();
            this.lbl_Goblin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_BuyWeapon2 = new System.Windows.Forms.Button();
            this.lbl_Mage = new System.Windows.Forms.Label();
            this.lbl_Leader = new System.Windows.Forms.Label();
            this.lbl_Shop = new System.Windows.Forms.Label();
            this.BTN_BuyWeapon3 = new System.Windows.Forms.Button();
            this.lbl_weapon1 = new System.Windows.Forms.Label();
            this.lbl_weapon2 = new System.Windows.Forms.Label();
            this.lbl_weapon3 = new System.Windows.Forms.Label();
            this.lbl_shopStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Right
            // 
            this.BTN_Right.Location = new System.Drawing.Point(199, 411);
            this.BTN_Right.Name = "BTN_Right";
            this.BTN_Right.Size = new System.Drawing.Size(93, 57);
            this.BTN_Right.TabIndex = 0;
            this.BTN_Right.Text = "Right";
            this.BTN_Right.UseVisualStyleBackColor = true;
            this.BTN_Right.Click += new System.EventHandler(this.BTN_Right_Click);
            // 
            // BTN_Left
            // 
            this.BTN_Left.Location = new System.Drawing.Point(4, 411);
            this.BTN_Left.Name = "BTN_Left";
            this.BTN_Left.Size = new System.Drawing.Size(92, 57);
            this.BTN_Left.TabIndex = 1;
            this.BTN_Left.Text = "Left";
            this.BTN_Left.UseVisualStyleBackColor = true;
            this.BTN_Left.Click += new System.EventHandler(this.BTN_Left_Click);
            // 
            // BTN_Down
            // 
            this.BTN_Down.Location = new System.Drawing.Point(102, 445);
            this.BTN_Down.Name = "BTN_Down";
            this.BTN_Down.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN_Down.Size = new System.Drawing.Size(91, 57);
            this.BTN_Down.TabIndex = 2;
            this.BTN_Down.Text = "Down";
            this.BTN_Down.UseVisualStyleBackColor = true;
            this.BTN_Down.Click += new System.EventHandler(this.BTN_Down_Click);
            // 
            // BTN_Up
            // 
            this.BTN_Up.Location = new System.Drawing.Point(102, 381);
            this.BTN_Up.Name = "BTN_Up";
            this.BTN_Up.Size = new System.Drawing.Size(91, 58);
            this.BTN_Up.TabIndex = 3;
            this.BTN_Up.Text = "UP";
            this.BTN_Up.UseVisualStyleBackColor = true;
            this.BTN_Up.Click += new System.EventHandler(this.BTN_Up_Click);
            // 
            // LBL_map
            // 
            this.LBL_map.AutoSize = true;
            this.LBL_map.Location = new System.Drawing.Point(183, 68);
            this.LBL_map.Name = "LBL_map";
            this.LBL_map.Size = new System.Drawing.Size(0, 17);
            this.LBL_map.TabIndex = 5;
            this.LBL_map.Click += new System.EventHandler(this.LBL_map_Click);
            // 
            // lbl_Hero
            // 
            this.lbl_Hero.AutoSize = true;
            this.lbl_Hero.Location = new System.Drawing.Point(695, 54);
            this.lbl_Hero.Name = "lbl_Hero";
            this.lbl_Hero.Size = new System.Drawing.Size(75, 17);
            this.lbl_Hero.TabIndex = 7;
            this.lbl_Hero.Text = "Hero Stats";
            this.lbl_Hero.Click += new System.EventHandler(this.lbl_Hero_Click);
            // 
            // lbl_Goblin
            // 
            this.lbl_Goblin.AutoSize = true;
            this.lbl_Goblin.Location = new System.Drawing.Point(889, 54);
            this.lbl_Goblin.Name = "lbl_Goblin";
            this.lbl_Goblin.Size = new System.Drawing.Size(85, 17);
            this.lbl_Goblin.TabIndex = 8;
            this.lbl_Goblin.Text = "Goblin Stats";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_BuyWeapon2
            // 
            this.BTN_BuyWeapon2.Location = new System.Drawing.Point(726, 396);
            this.BTN_BuyWeapon2.Name = "BTN_BuyWeapon2";
            this.BTN_BuyWeapon2.Size = new System.Drawing.Size(107, 57);
            this.BTN_BuyWeapon2.TabIndex = 10;
            this.BTN_BuyWeapon2.Text = "button2";
            this.BTN_BuyWeapon2.UseVisualStyleBackColor = true;
            this.BTN_BuyWeapon2.Click += new System.EventHandler(this.BTN_BuyWeapon2_Click);
            // 
            // lbl_Mage
            // 
            this.lbl_Mage.AutoSize = true;
            this.lbl_Mage.Location = new System.Drawing.Point(695, 178);
            this.lbl_Mage.Name = "lbl_Mage";
            this.lbl_Mage.Size = new System.Drawing.Size(87, 17);
            this.lbl_Mage.TabIndex = 11;
            this.lbl_Mage.Text = "Mage States";
            // 
            // lbl_Leader
            // 
            this.lbl_Leader.AutoSize = true;
            this.lbl_Leader.Location = new System.Drawing.Point(889, 178);
            this.lbl_Leader.Name = "lbl_Leader";
            this.lbl_Leader.Size = new System.Drawing.Size(53, 17);
            this.lbl_Leader.TabIndex = 12;
            this.lbl_Leader.Text = "Leader";
            // 
            // lbl_Shop
            // 
            this.lbl_Shop.AutoSize = true;
            this.lbl_Shop.Location = new System.Drawing.Point(794, 291);
            this.lbl_Shop.Name = "lbl_Shop";
            this.lbl_Shop.Size = new System.Drawing.Size(39, 17);
            this.lbl_Shop.TabIndex = 13;
            this.lbl_Shop.Text = "shop";
            // 
            // BTN_BuyWeapon3
            // 
            this.BTN_BuyWeapon3.Location = new System.Drawing.Point(870, 396);
            this.BTN_BuyWeapon3.Name = "BTN_BuyWeapon3";
            this.BTN_BuyWeapon3.Size = new System.Drawing.Size(104, 57);
            this.BTN_BuyWeapon3.TabIndex = 14;
            this.BTN_BuyWeapon3.Text = "button3";
            this.BTN_BuyWeapon3.UseVisualStyleBackColor = true;
            this.BTN_BuyWeapon3.Click += new System.EventHandler(this.BTN_BuyWeapon3_Click);
            // 
            // lbl_weapon1
            // 
            this.lbl_weapon1.AutoSize = true;
            this.lbl_weapon1.Location = new System.Drawing.Point(579, 376);
            this.lbl_weapon1.Name = "lbl_weapon1";
            this.lbl_weapon1.Size = new System.Drawing.Size(46, 17);
            this.lbl_weapon1.TabIndex = 15;
            this.lbl_weapon1.Text = "label1";
            // 
            // lbl_weapon2
            // 
            this.lbl_weapon2.AutoSize = true;
            this.lbl_weapon2.Location = new System.Drawing.Point(755, 376);
            this.lbl_weapon2.Name = "lbl_weapon2";
            this.lbl_weapon2.Size = new System.Drawing.Size(46, 17);
            this.lbl_weapon2.TabIndex = 16;
            this.lbl_weapon2.Text = "label2";
            // 
            // lbl_weapon3
            // 
            this.lbl_weapon3.AutoSize = true;
            this.lbl_weapon3.Location = new System.Drawing.Point(901, 376);
            this.lbl_weapon3.Name = "lbl_weapon3";
            this.lbl_weapon3.Size = new System.Drawing.Size(46, 17);
            this.lbl_weapon3.TabIndex = 17;
            this.lbl_weapon3.Text = "label3";
            // 
            // lbl_shopStats
            // 
            this.lbl_shopStats.AutoSize = true;
            this.lbl_shopStats.Location = new System.Drawing.Point(768, 485);
            this.lbl_shopStats.Name = "lbl_shopStats";
            this.lbl_shopStats.Size = new System.Drawing.Size(77, 17);
            this.lbl_shopStats.TabIndex = 18;
            this.lbl_shopStats.Text = "Shop Stats";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 623);
            this.Controls.Add(this.lbl_shopStats);
            this.Controls.Add(this.lbl_weapon3);
            this.Controls.Add(this.lbl_weapon2);
            this.Controls.Add(this.lbl_weapon1);
            this.Controls.Add(this.BTN_BuyWeapon3);
            this.Controls.Add(this.lbl_Shop);
            this.Controls.Add(this.lbl_Leader);
            this.Controls.Add(this.lbl_Mage);
            this.Controls.Add(this.BTN_BuyWeapon2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Goblin);
            this.Controls.Add(this.lbl_Hero);
            this.Controls.Add(this.LBL_map);
            this.Controls.Add(this.BTN_Up);
            this.Controls.Add(this.BTN_Down);
            this.Controls.Add(this.BTN_Left);
            this.Controls.Add(this.BTN_Right);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Right;
        private System.Windows.Forms.Button BTN_Left;
        private System.Windows.Forms.Button BTN_Down;
        private System.Windows.Forms.Button BTN_Up;
        private System.Windows.Forms.Label LBL_map;
        private System.Windows.Forms.Label lbl_Hero;
        private System.Windows.Forms.Label lbl_Goblin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_BuyWeapon2;
        private System.Windows.Forms.Label lbl_Mage;
        private System.Windows.Forms.Label lbl_Leader;
        private System.Windows.Forms.Label lbl_Shop;
        private System.Windows.Forms.Button BTN_BuyWeapon3;
        private System.Windows.Forms.Label lbl_weapon1;
        private System.Windows.Forms.Label lbl_weapon2;
        private System.Windows.Forms.Label lbl_weapon3;
        private System.Windows.Forms.Label lbl_shopStats;
    }
}

