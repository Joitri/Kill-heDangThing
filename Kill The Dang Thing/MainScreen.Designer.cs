namespace Kill_The_Dang_Thing
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.pbxMonster = new System.Windows.Forms.PictureBox();
            this.lblCharacterInformation = new System.Windows.Forms.Label();
            this.lblPlayerHealthPrompt = new System.Windows.Forms.Label();
            this.lblEnergyPrompt = new System.Windows.Forms.Label();
            this.lblPlayerEnergyDisplay = new System.Windows.Forms.Label();
            this.lblAttackPrompt = new System.Windows.Forms.Label();
            this.lblPlayerAttackDisplay = new System.Windows.Forms.Label();
            this.lblDefensePrompt = new System.Windows.Forms.Label();
            this.lblPlayerDefenseDisplay = new System.Windows.Forms.Label();
            this.lblExperiencePrompt = new System.Windows.Forms.Label();
            this.lblExperienceDisplay = new System.Windows.Forms.Label();
            this.lblSoulsPrompt = new System.Windows.Forms.Label();
            this.lblSoulsDisplay = new System.Windows.Forms.Label();
            this.pbxEnergyIncrease = new System.Windows.Forms.PictureBox();
            this.pbxAttackIncrease = new System.Windows.Forms.PictureBox();
            this.pbxDefenseIncrease = new System.Windows.Forms.PictureBox();
            this.lblExperienceRatePrompt = new System.Windows.Forms.Label();
            this.lblExperienceRateDisplay = new System.Windows.Forms.Label();
            this.pbxExperienceIncrease = new System.Windows.Forms.PictureBox();
            this.lblSoulRatePrompt = new System.Windows.Forms.Label();
            this.lblSoulRateDisplay = new System.Windows.Forms.Label();
            this.pbxSoulIncrease = new System.Windows.Forms.PictureBox();
            this.lblEnemyHealthPrompt = new System.Windows.Forms.Label();
            this.lblEnemyHealthDisplay = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Label();
            this.btnRebirth = new System.Windows.Forms.Label();
            this.lblRecoverPrompt = new System.Windows.Forms.Label();
            this.pbxHealthIncrease = new System.Windows.Forms.PictureBox();
            this.lblPlayerHealthDisplay = new System.Windows.Forms.Label();
            this.lblAchievements = new System.Windows.Forms.Label();
            this.pbxRecover = new System.Windows.Forms.PictureBox();
            this.lblMonsterRankPrompt = new System.Windows.Forms.Label();
            this.lblWorldRankPrompt = new System.Windows.Forms.Label();
            this.lblMonsterRankDisplay = new System.Windows.Forms.Label();
            this.lblWorldRankDisplay = new System.Windows.Forms.Label();
            this.lblEnemyAttackDisplay = new System.Windows.Forms.Label();
            this.lblEnemyAttackPrompt = new System.Windows.Forms.Label();
            this.lblEnemyDefenseDisplay = new System.Windows.Forms.Label();
            this.lblEnemyDefensePrompt = new System.Windows.Forms.Label();
            this.imgMisc = new System.Windows.Forms.ImageList(this.components);
            this.timeTicker = new System.Windows.Forms.Timer(this.components);
            this.lblDeathsPrompt = new System.Windows.Forms.Label();
            this.lblTotalKillsPrompt = new System.Windows.Forms.Label();
            this.lblCurrentKillsPrompt = new System.Windows.Forms.Label();
            this.lblRecoversPrompt = new System.Windows.Forms.Label();
            this.lblRebirthsPrompt = new System.Windows.Forms.Label();
            this.lblBattleText = new System.Windows.Forms.Label();
            this.lblPlayerDeathsDisplay = new System.Windows.Forms.Label();
            this.lblCurrentKillsDisplay = new System.Windows.Forms.Label();
            this.lblTotalKillsDisplay = new System.Windows.Forms.Label();
            this.lblRecoveryUsedDisplay = new System.Windows.Forms.Label();
            this.lblRebirthsDisplay = new System.Windows.Forms.Label();
            this.imgEnemy = new System.Windows.Forms.ImageList(this.components);
            this.btnAutoAttack = new System.Windows.Forms.Label();
            this.lblAutoSavePrompt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMonster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnergyIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAttackIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDefenseIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExperienceIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSoulIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHealthIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecover)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMonster
            // 
            this.pbxMonster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxMonster.Location = new System.Drawing.Point(241, 222);
            this.pbxMonster.Name = "pbxMonster";
            this.pbxMonster.Size = new System.Drawing.Size(256, 256);
            this.pbxMonster.TabIndex = 0;
            this.pbxMonster.TabStop = false;
            this.pbxMonster.Click += new System.EventHandler(this.pbxMonster_Click);
            // 
            // lblCharacterInformation
            // 
            this.lblCharacterInformation.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCharacterInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCharacterInformation.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterInformation.Location = new System.Drawing.Point(560, 14);
            this.lblCharacterInformation.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblCharacterInformation.Name = "lblCharacterInformation";
            this.lblCharacterInformation.Size = new System.Drawing.Size(450, 324);
            this.lblCharacterInformation.TabIndex = 1;
            this.lblCharacterInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayerHealthPrompt
            // 
            this.lblPlayerHealthPrompt.BackColor = System.Drawing.Color.Red;
            this.lblPlayerHealthPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerHealthPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthPrompt.Location = new System.Drawing.Point(560, 14);
            this.lblPlayerHealthPrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblPlayerHealthPrompt.Name = "lblPlayerHealthPrompt";
            this.lblPlayerHealthPrompt.Size = new System.Drawing.Size(95, 32);
            this.lblPlayerHealthPrompt.TabIndex = 10;
            this.lblPlayerHealthPrompt.Text = "Health";
            this.lblPlayerHealthPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnergyPrompt
            // 
            this.lblEnergyPrompt.BackColor = System.Drawing.Color.Yellow;
            this.lblEnergyPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnergyPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergyPrompt.Location = new System.Drawing.Point(560, 56);
            this.lblEnergyPrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblEnergyPrompt.Name = "lblEnergyPrompt";
            this.lblEnergyPrompt.Size = new System.Drawing.Size(95, 32);
            this.lblEnergyPrompt.TabIndex = 12;
            this.lblEnergyPrompt.Text = "Energy";
            this.lblEnergyPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerEnergyDisplay
            // 
            this.lblPlayerEnergyDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerEnergyDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerEnergyDisplay.Location = new System.Drawing.Point(655, 56);
            this.lblPlayerEnergyDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblPlayerEnergyDisplay.Name = "lblPlayerEnergyDisplay";
            this.lblPlayerEnergyDisplay.Size = new System.Drawing.Size(355, 32);
            this.lblPlayerEnergyDisplay.TabIndex = 11;
            this.lblPlayerEnergyDisplay.Text = "9,999,999,999/9,999,999,999";
            this.lblPlayerEnergyDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAttackPrompt
            // 
            this.lblAttackPrompt.BackColor = System.Drawing.Color.Aqua;
            this.lblAttackPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAttackPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttackPrompt.Location = new System.Drawing.Point(560, 98);
            this.lblAttackPrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblAttackPrompt.Name = "lblAttackPrompt";
            this.lblAttackPrompt.Size = new System.Drawing.Size(95, 32);
            this.lblAttackPrompt.TabIndex = 14;
            this.lblAttackPrompt.Text = "Attack";
            this.lblAttackPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerAttackDisplay
            // 
            this.lblPlayerAttackDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerAttackDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerAttackDisplay.Location = new System.Drawing.Point(655, 98);
            this.lblPlayerAttackDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblPlayerAttackDisplay.Name = "lblPlayerAttackDisplay";
            this.lblPlayerAttackDisplay.Size = new System.Drawing.Size(355, 32);
            this.lblPlayerAttackDisplay.TabIndex = 13;
            this.lblPlayerAttackDisplay.Text = "9,999,999,999/9,999,999,999";
            this.lblPlayerAttackDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDefensePrompt
            // 
            this.lblDefensePrompt.BackColor = System.Drawing.Color.Aqua;
            this.lblDefensePrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDefensePrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefensePrompt.Location = new System.Drawing.Point(560, 140);
            this.lblDefensePrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblDefensePrompt.Name = "lblDefensePrompt";
            this.lblDefensePrompt.Size = new System.Drawing.Size(95, 32);
            this.lblDefensePrompt.TabIndex = 16;
            this.lblDefensePrompt.Text = "Defense";
            this.lblDefensePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerDefenseDisplay
            // 
            this.lblPlayerDefenseDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerDefenseDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerDefenseDisplay.Location = new System.Drawing.Point(655, 140);
            this.lblPlayerDefenseDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblPlayerDefenseDisplay.Name = "lblPlayerDefenseDisplay";
            this.lblPlayerDefenseDisplay.Size = new System.Drawing.Size(355, 32);
            this.lblPlayerDefenseDisplay.TabIndex = 15;
            this.lblPlayerDefenseDisplay.Text = "9,999,999,999/9,999,999,999";
            this.lblPlayerDefenseDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExperiencePrompt
            // 
            this.lblExperiencePrompt.BackColor = System.Drawing.Color.Violet;
            this.lblExperiencePrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExperiencePrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperiencePrompt.Location = new System.Drawing.Point(560, 182);
            this.lblExperiencePrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblExperiencePrompt.Name = "lblExperiencePrompt";
            this.lblExperiencePrompt.Size = new System.Drawing.Size(100, 32);
            this.lblExperiencePrompt.TabIndex = 18;
            this.lblExperiencePrompt.Text = "Experience";
            this.lblExperiencePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExperienceDisplay
            // 
            this.lblExperienceDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExperienceDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperienceDisplay.Location = new System.Drawing.Point(660, 182);
            this.lblExperienceDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblExperienceDisplay.Name = "lblExperienceDisplay";
            this.lblExperienceDisplay.Size = new System.Drawing.Size(212, 32);
            this.lblExperienceDisplay.TabIndex = 17;
            this.lblExperienceDisplay.Text = "9,999,999,999";
            this.lblExperienceDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoulsPrompt
            // 
            this.lblSoulsPrompt.BackColor = System.Drawing.Color.Violet;
            this.lblSoulsPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoulsPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoulsPrompt.Location = new System.Drawing.Point(560, 224);
            this.lblSoulsPrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblSoulsPrompt.Name = "lblSoulsPrompt";
            this.lblSoulsPrompt.Size = new System.Drawing.Size(100, 32);
            this.lblSoulsPrompt.TabIndex = 20;
            this.lblSoulsPrompt.Text = "Souls";
            this.lblSoulsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoulsDisplay
            // 
            this.lblSoulsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoulsDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoulsDisplay.Location = new System.Drawing.Point(660, 224);
            this.lblSoulsDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblSoulsDisplay.Name = "lblSoulsDisplay";
            this.lblSoulsDisplay.Size = new System.Drawing.Size(212, 32);
            this.lblSoulsDisplay.TabIndex = 19;
            this.lblSoulsDisplay.Text = "9,999,999,999";
            this.lblSoulsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxEnergyIncrease
            // 
            this.pbxEnergyIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxEnergyIncrease.Location = new System.Drawing.Point(978, 56);
            this.pbxEnergyIncrease.Name = "pbxEnergyIncrease";
            this.pbxEnergyIncrease.Size = new System.Drawing.Size(32, 32);
            this.pbxEnergyIncrease.TabIndex = 22;
            this.pbxEnergyIncrease.TabStop = false;
            this.pbxEnergyIncrease.Click += new System.EventHandler(this.pbxEnergyIncrease_Click);
            // 
            // pbxAttackIncrease
            // 
            this.pbxAttackIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAttackIncrease.Location = new System.Drawing.Point(978, 98);
            this.pbxAttackIncrease.Name = "pbxAttackIncrease";
            this.pbxAttackIncrease.Size = new System.Drawing.Size(32, 32);
            this.pbxAttackIncrease.TabIndex = 23;
            this.pbxAttackIncrease.TabStop = false;
            this.pbxAttackIncrease.Click += new System.EventHandler(this.pbxAttackIncrease_Click);
            // 
            // pbxDefenseIncrease
            // 
            this.pbxDefenseIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxDefenseIncrease.Location = new System.Drawing.Point(978, 140);
            this.pbxDefenseIncrease.Name = "pbxDefenseIncrease";
            this.pbxDefenseIncrease.Size = new System.Drawing.Size(32, 32);
            this.pbxDefenseIncrease.TabIndex = 24;
            this.pbxDefenseIncrease.TabStop = false;
            this.pbxDefenseIncrease.Click += new System.EventHandler(this.pbxDefenseIncrease_Click);
            // 
            // lblExperienceRatePrompt
            // 
            this.lblExperienceRatePrompt.BackColor = System.Drawing.Color.Violet;
            this.lblExperienceRatePrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExperienceRatePrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperienceRatePrompt.Location = new System.Drawing.Point(870, 182);
            this.lblExperienceRatePrompt.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblExperienceRatePrompt.Name = "lblExperienceRatePrompt";
            this.lblExperienceRatePrompt.Size = new System.Drawing.Size(75, 32);
            this.lblExperienceRatePrompt.TabIndex = 26;
            this.lblExperienceRatePrompt.Text = "Exp. Rate";
            this.lblExperienceRatePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExperienceRateDisplay
            // 
            this.lblExperienceRateDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExperienceRateDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperienceRateDisplay.Location = new System.Drawing.Point(945, 182);
            this.lblExperienceRateDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblExperienceRateDisplay.Name = "lblExperienceRateDisplay";
            this.lblExperienceRateDisplay.Size = new System.Drawing.Size(65, 32);
            this.lblExperienceRateDisplay.TabIndex = 25;
            this.lblExperienceRateDisplay.Text = "x10";
            this.lblExperienceRateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxExperienceIncrease
            // 
            this.pbxExperienceIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxExperienceIncrease.Location = new System.Drawing.Point(978, 182);
            this.pbxExperienceIncrease.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pbxExperienceIncrease.Name = "pbxExperienceIncrease";
            this.pbxExperienceIncrease.Size = new System.Drawing.Size(32, 32);
            this.pbxExperienceIncrease.TabIndex = 27;
            this.pbxExperienceIncrease.TabStop = false;
            this.pbxExperienceIncrease.Click += new System.EventHandler(this.pbxExperienceIncrease_Click);
            // 
            // lblSoulRatePrompt
            // 
            this.lblSoulRatePrompt.BackColor = System.Drawing.Color.Violet;
            this.lblSoulRatePrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoulRatePrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoulRatePrompt.Location = new System.Drawing.Point(870, 224);
            this.lblSoulRatePrompt.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblSoulRatePrompt.Name = "lblSoulRatePrompt";
            this.lblSoulRatePrompt.Size = new System.Drawing.Size(75, 32);
            this.lblSoulRatePrompt.TabIndex = 29;
            this.lblSoulRatePrompt.Text = "Soul Rate";
            this.lblSoulRatePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoulRateDisplay
            // 
            this.lblSoulRateDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoulRateDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoulRateDisplay.Location = new System.Drawing.Point(945, 224);
            this.lblSoulRateDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblSoulRateDisplay.Name = "lblSoulRateDisplay";
            this.lblSoulRateDisplay.Size = new System.Drawing.Size(65, 32);
            this.lblSoulRateDisplay.TabIndex = 28;
            this.lblSoulRateDisplay.Text = "x1";
            this.lblSoulRateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxSoulIncrease
            // 
            this.pbxSoulIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxSoulIncrease.Location = new System.Drawing.Point(978, 224);
            this.pbxSoulIncrease.Name = "pbxSoulIncrease";
            this.pbxSoulIncrease.Size = new System.Drawing.Size(32, 32);
            this.pbxSoulIncrease.TabIndex = 30;
            this.pbxSoulIncrease.TabStop = false;
            this.pbxSoulIncrease.Click += new System.EventHandler(this.pbxSoulIncrease_Click);
            // 
            // lblEnemyHealthPrompt
            // 
            this.lblEnemyHealthPrompt.BackColor = System.Drawing.Color.Red;
            this.lblEnemyHealthPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnemyHealthPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealthPrompt.Location = new System.Drawing.Point(65, 236);
            this.lblEnemyHealthPrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblEnemyHealthPrompt.Name = "lblEnemyHealthPrompt";
            this.lblEnemyHealthPrompt.Size = new System.Drawing.Size(110, 32);
            this.lblEnemyHealthPrompt.TabIndex = 32;
            this.lblEnemyHealthPrompt.Text = "Enemy Health";
            this.lblEnemyHealthPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyHealthDisplay
            // 
            this.lblEnemyHealthDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnemyHealthDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealthDisplay.Location = new System.Drawing.Point(14, 278);
            this.lblEnemyHealthDisplay.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblEnemyHealthDisplay.Name = "lblEnemyHealthDisplay";
            this.lblEnemyHealthDisplay.Size = new System.Drawing.Size(215, 32);
            this.lblEnemyHealthDisplay.TabIndex = 33;
            this.lblEnemyHealthDisplay.Text = "9,999,999,999";
            this.lblEnemyHealthDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(900, 667);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 32);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnNewGame.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(900, 566);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(110, 32);
            this.btnNewGame.TabIndex = 35;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnRebirth
            // 
            this.btnRebirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRebirth.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRebirth.Location = new System.Drawing.Point(780, 306);
            this.btnRebirth.Margin = new System.Windows.Forms.Padding(5);
            this.btnRebirth.Name = "btnRebirth";
            this.btnRebirth.Size = new System.Drawing.Size(110, 32);
            this.btnRebirth.TabIndex = 37;
            this.btnRebirth.Text = "Rebirth";
            this.btnRebirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRebirth.Click += new System.EventHandler(this.btnRebirth_Click);
            // 
            // lblRecoverPrompt
            // 
            this.lblRecoverPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecoverPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecoverPrompt.Location = new System.Drawing.Point(910, 264);
            this.lblRecoverPrompt.Margin = new System.Windows.Forms.Padding(5);
            this.lblRecoverPrompt.Name = "lblRecoverPrompt";
            this.lblRecoverPrompt.Size = new System.Drawing.Size(100, 32);
            this.lblRecoverPrompt.TabIndex = 38;
            this.lblRecoverPrompt.Text = "Recover";
            this.lblRecoverPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxHealthIncrease
            // 
            this.pbxHealthIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxHealthIncrease.Location = new System.Drawing.Point(978, 14);
            this.pbxHealthIncrease.Name = "pbxHealthIncrease";
            this.pbxHealthIncrease.Size = new System.Drawing.Size(32, 32);
            this.pbxHealthIncrease.TabIndex = 40;
            this.pbxHealthIncrease.TabStop = false;
            this.pbxHealthIncrease.Click += new System.EventHandler(this.pbxHealthIncrease_Click);
            // 
            // lblPlayerHealthDisplay
            // 
            this.lblPlayerHealthDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerHealthDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthDisplay.Location = new System.Drawing.Point(655, 14);
            this.lblPlayerHealthDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblPlayerHealthDisplay.Name = "lblPlayerHealthDisplay";
            this.lblPlayerHealthDisplay.Size = new System.Drawing.Size(355, 32);
            this.lblPlayerHealthDisplay.TabIndex = 39;
            this.lblPlayerHealthDisplay.Text = "9,999,999,999 / 9,999,999,999";
            this.lblPlayerHealthDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAchievements
            // 
            this.lblAchievements.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblAchievements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAchievements.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchievements.Location = new System.Drawing.Point(9, 14);
            this.lblAchievements.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblAchievements.Name = "lblAchievements";
            this.lblAchievements.Size = new System.Drawing.Size(488, 200);
            this.lblAchievements.TabIndex = 1;
            this.lblAchievements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxRecover
            // 
            this.pbxRecover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxRecover.Location = new System.Drawing.Point(978, 264);
            this.pbxRecover.Name = "pbxRecover";
            this.pbxRecover.Size = new System.Drawing.Size(32, 32);
            this.pbxRecover.TabIndex = 41;
            this.pbxRecover.TabStop = false;
            this.pbxRecover.Click += new System.EventHandler(this.pbxRecover_Click);
            // 
            // lblMonsterRankPrompt
            // 
            this.lblMonsterRankPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonsterRankPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonsterRankPrompt.Location = new System.Drawing.Point(660, 264);
            this.lblMonsterRankPrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblMonsterRankPrompt.Name = "lblMonsterRankPrompt";
            this.lblMonsterRankPrompt.Size = new System.Drawing.Size(132, 32);
            this.lblMonsterRankPrompt.TabIndex = 42;
            this.lblMonsterRankPrompt.Text = "Monster Rank";
            this.lblMonsterRankPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWorldRankPrompt
            // 
            this.lblWorldRankPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWorldRankPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorldRankPrompt.Location = new System.Drawing.Point(792, 264);
            this.lblWorldRankPrompt.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblWorldRankPrompt.Name = "lblWorldRankPrompt";
            this.lblWorldRankPrompt.Size = new System.Drawing.Size(118, 32);
            this.lblWorldRankPrompt.TabIndex = 43;
            this.lblWorldRankPrompt.Text = "World Rank";
            this.lblWorldRankPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMonsterRankDisplay
            // 
            this.lblMonsterRankDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonsterRankDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonsterRankDisplay.Location = new System.Drawing.Point(760, 264);
            this.lblMonsterRankDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblMonsterRankDisplay.Name = "lblMonsterRankDisplay";
            this.lblMonsterRankDisplay.Size = new System.Drawing.Size(32, 32);
            this.lblMonsterRankDisplay.TabIndex = 44;
            this.lblMonsterRankDisplay.Text = "x1";
            this.lblMonsterRankDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWorldRankDisplay
            // 
            this.lblWorldRankDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWorldRankDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorldRankDisplay.Location = new System.Drawing.Point(878, 264);
            this.lblWorldRankDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblWorldRankDisplay.Name = "lblWorldRankDisplay";
            this.lblWorldRankDisplay.Size = new System.Drawing.Size(32, 32);
            this.lblWorldRankDisplay.TabIndex = 45;
            this.lblWorldRankDisplay.Text = "x1";
            this.lblWorldRankDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnemyAttackDisplay
            // 
            this.lblEnemyAttackDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnemyAttackDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyAttackDisplay.Location = new System.Drawing.Point(14, 362);
            this.lblEnemyAttackDisplay.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblEnemyAttackDisplay.Name = "lblEnemyAttackDisplay";
            this.lblEnemyAttackDisplay.Size = new System.Drawing.Size(215, 32);
            this.lblEnemyAttackDisplay.TabIndex = 47;
            this.lblEnemyAttackDisplay.Text = "9,999,999,999";
            this.lblEnemyAttackDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyAttackPrompt
            // 
            this.lblEnemyAttackPrompt.BackColor = System.Drawing.Color.Aqua;
            this.lblEnemyAttackPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnemyAttackPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyAttackPrompt.Location = new System.Drawing.Point(65, 320);
            this.lblEnemyAttackPrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblEnemyAttackPrompt.Name = "lblEnemyAttackPrompt";
            this.lblEnemyAttackPrompt.Size = new System.Drawing.Size(110, 32);
            this.lblEnemyAttackPrompt.TabIndex = 46;
            this.lblEnemyAttackPrompt.Text = "Enemy Attack";
            this.lblEnemyAttackPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyDefenseDisplay
            // 
            this.lblEnemyDefenseDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnemyDefenseDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyDefenseDisplay.Location = new System.Drawing.Point(14, 446);
            this.lblEnemyDefenseDisplay.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblEnemyDefenseDisplay.Name = "lblEnemyDefenseDisplay";
            this.lblEnemyDefenseDisplay.Size = new System.Drawing.Size(215, 32);
            this.lblEnemyDefenseDisplay.TabIndex = 49;
            this.lblEnemyDefenseDisplay.Text = "9,999,999,999";
            this.lblEnemyDefenseDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyDefensePrompt
            // 
            this.lblEnemyDefensePrompt.BackColor = System.Drawing.Color.Aqua;
            this.lblEnemyDefensePrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnemyDefensePrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyDefensePrompt.Location = new System.Drawing.Point(65, 404);
            this.lblEnemyDefensePrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblEnemyDefensePrompt.Name = "lblEnemyDefensePrompt";
            this.lblEnemyDefensePrompt.Size = new System.Drawing.Size(110, 32);
            this.lblEnemyDefensePrompt.TabIndex = 48;
            this.lblEnemyDefensePrompt.Text = "Enemy Defense";
            this.lblEnemyDefensePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgMisc
            // 
            this.imgMisc.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMisc.ImageStream")));
            this.imgMisc.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMisc.Images.SetKeyName(0, "thumbnail_image1.png");
            this.imgMisc.Images.SetKeyName(1, "thumbnail_image2.jpg");
            // 
            // timeTicker
            // 
            this.timeTicker.Enabled = true;
            this.timeTicker.Tick += new System.EventHandler(this.timeTicker_Tick);
            // 
            // lblDeathsPrompt
            // 
            this.lblDeathsPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeathsPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeathsPrompt.Location = new System.Drawing.Point(9, 14);
            this.lblDeathsPrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblDeathsPrompt.Name = "lblDeathsPrompt";
            this.lblDeathsPrompt.Size = new System.Drawing.Size(110, 32);
            this.lblDeathsPrompt.TabIndex = 50;
            this.lblDeathsPrompt.Text = "Deaths";
            this.lblDeathsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalKillsPrompt
            // 
            this.lblTotalKillsPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalKillsPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKillsPrompt.Location = new System.Drawing.Point(9, 98);
            this.lblTotalKillsPrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblTotalKillsPrompt.Name = "lblTotalKillsPrompt";
            this.lblTotalKillsPrompt.Size = new System.Drawing.Size(110, 32);
            this.lblTotalKillsPrompt.TabIndex = 51;
            this.lblTotalKillsPrompt.Text = "Total Kills";
            this.lblTotalKillsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentKillsPrompt
            // 
            this.lblCurrentKillsPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentKillsPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentKillsPrompt.Location = new System.Drawing.Point(9, 56);
            this.lblCurrentKillsPrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblCurrentKillsPrompt.Name = "lblCurrentKillsPrompt";
            this.lblCurrentKillsPrompt.Size = new System.Drawing.Size(110, 32);
            this.lblCurrentKillsPrompt.TabIndex = 52;
            this.lblCurrentKillsPrompt.Text = "Current Kills";
            this.lblCurrentKillsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecoversPrompt
            // 
            this.lblRecoversPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecoversPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecoversPrompt.Location = new System.Drawing.Point(9, 140);
            this.lblRecoversPrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblRecoversPrompt.Name = "lblRecoversPrompt";
            this.lblRecoversPrompt.Size = new System.Drawing.Size(110, 32);
            this.lblRecoversPrompt.TabIndex = 53;
            this.lblRecoversPrompt.Text = "Recover Used";
            this.lblRecoversPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRebirthsPrompt
            // 
            this.lblRebirthsPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRebirthsPrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRebirthsPrompt.Location = new System.Drawing.Point(9, 182);
            this.lblRebirthsPrompt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.lblRebirthsPrompt.Name = "lblRebirthsPrompt";
            this.lblRebirthsPrompt.Size = new System.Drawing.Size(110, 32);
            this.lblRebirthsPrompt.TabIndex = 54;
            this.lblRebirthsPrompt.Text = "Rebirths";
            this.lblRebirthsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBattleText
            // 
            this.lblBattleText.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblBattleText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattleText.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattleText.Location = new System.Drawing.Point(9, 488);
            this.lblBattleText.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblBattleText.Name = "lblBattleText";
            this.lblBattleText.Size = new System.Drawing.Size(369, 127);
            this.lblBattleText.TabIndex = 55;
            this.lblBattleText.Text = "Click the monster.";
            this.lblBattleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerDeathsDisplay
            // 
            this.lblPlayerDeathsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerDeathsDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerDeathsDisplay.Location = new System.Drawing.Point(119, 14);
            this.lblPlayerDeathsDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblPlayerDeathsDisplay.Name = "lblPlayerDeathsDisplay";
            this.lblPlayerDeathsDisplay.Size = new System.Drawing.Size(378, 32);
            this.lblPlayerDeathsDisplay.TabIndex = 56;
            this.lblPlayerDeathsDisplay.Text = "9,999,999,999 / 9,999,999,999";
            this.lblPlayerDeathsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentKillsDisplay
            // 
            this.lblCurrentKillsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentKillsDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentKillsDisplay.Location = new System.Drawing.Point(119, 56);
            this.lblCurrentKillsDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblCurrentKillsDisplay.Name = "lblCurrentKillsDisplay";
            this.lblCurrentKillsDisplay.Size = new System.Drawing.Size(378, 32);
            this.lblCurrentKillsDisplay.TabIndex = 57;
            this.lblCurrentKillsDisplay.Text = "9,999,999,999 / 9,999,999,999";
            this.lblCurrentKillsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalKillsDisplay
            // 
            this.lblTotalKillsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalKillsDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKillsDisplay.Location = new System.Drawing.Point(119, 98);
            this.lblTotalKillsDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblTotalKillsDisplay.Name = "lblTotalKillsDisplay";
            this.lblTotalKillsDisplay.Size = new System.Drawing.Size(378, 32);
            this.lblTotalKillsDisplay.TabIndex = 58;
            this.lblTotalKillsDisplay.Text = "9,999,999,999 / 9,999,999,999";
            this.lblTotalKillsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecoveryUsedDisplay
            // 
            this.lblRecoveryUsedDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecoveryUsedDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecoveryUsedDisplay.Location = new System.Drawing.Point(119, 140);
            this.lblRecoveryUsedDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblRecoveryUsedDisplay.Name = "lblRecoveryUsedDisplay";
            this.lblRecoveryUsedDisplay.Size = new System.Drawing.Size(378, 32);
            this.lblRecoveryUsedDisplay.TabIndex = 59;
            this.lblRecoveryUsedDisplay.Text = "9,999,999,999 / 9,999,999,999";
            this.lblRecoveryUsedDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRebirthsDisplay
            // 
            this.lblRebirthsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRebirthsDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRebirthsDisplay.Location = new System.Drawing.Point(119, 182);
            this.lblRebirthsDisplay.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblRebirthsDisplay.Name = "lblRebirthsDisplay";
            this.lblRebirthsDisplay.Size = new System.Drawing.Size(378, 32);
            this.lblRebirthsDisplay.TabIndex = 60;
            this.lblRebirthsDisplay.Text = "9,999,999,999 / 9,999,999,999";
            this.lblRebirthsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgEnemy
            // 
            this.imgEnemy.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgEnemy.ImageStream")));
            this.imgEnemy.TransparentColor = System.Drawing.Color.Transparent;
            this.imgEnemy.Images.SetKeyName(0, "GiantRat_Walk_01.png");
            this.imgEnemy.Images.SetKeyName(1, "GiantRat_Walk_02.png");
            this.imgEnemy.Images.SetKeyName(2, "GiantRat_Walk_03.png");
            this.imgEnemy.Images.SetKeyName(3, "GiantRat_Walk_04.png");
            this.imgEnemy.Images.SetKeyName(4, "GiantRat_Walk_05.png");
            this.imgEnemy.Images.SetKeyName(5, "GiantRat_Walk_06.png");
            this.imgEnemy.Images.SetKeyName(6, "GiantRat_Walk_07.png");
            this.imgEnemy.Images.SetKeyName(7, "GiantRat_Walk_08.png");
            this.imgEnemy.Images.SetKeyName(8, "GiantRat_Get Hit_01.png");
            this.imgEnemy.Images.SetKeyName(9, "GiantRat_Get Hit_02.png");
            this.imgEnemy.Images.SetKeyName(10, "GiantRat_Get Hit_03.png");
            this.imgEnemy.Images.SetKeyName(11, "GiantRatDark_Walk_01.png");
            this.imgEnemy.Images.SetKeyName(12, "GiantRatDark_Walk_02.png");
            this.imgEnemy.Images.SetKeyName(13, "GiantRatDark_Walk_03.png");
            this.imgEnemy.Images.SetKeyName(14, "GiantRatDark_Walk_04.png");
            this.imgEnemy.Images.SetKeyName(15, "GiantRatDark_Walk_05.png");
            this.imgEnemy.Images.SetKeyName(16, "GiantRatDark_Walk_06.png");
            this.imgEnemy.Images.SetKeyName(17, "GiantRatDark_Walk_07.png");
            this.imgEnemy.Images.SetKeyName(18, "GiantRatDark_Walk_08.png");
            this.imgEnemy.Images.SetKeyName(19, "GiantRatDark_Get Hit_01.png");
            this.imgEnemy.Images.SetKeyName(20, "GiantRatDark_Get Hit_02.png");
            this.imgEnemy.Images.SetKeyName(21, "GiantRatDark_Get Hit_03.png");
            this.imgEnemy.Images.SetKeyName(22, "Skeleton_walking_01.png");
            this.imgEnemy.Images.SetKeyName(23, "Skeleton_walking_02.png");
            this.imgEnemy.Images.SetKeyName(24, "Skeleton_walking_03.png");
            this.imgEnemy.Images.SetKeyName(25, "Skeleton_walking_04.png");
            this.imgEnemy.Images.SetKeyName(26, "Skeleton_walking_05.png");
            this.imgEnemy.Images.SetKeyName(27, "Skeleton_walking_06.png");
            this.imgEnemy.Images.SetKeyName(28, "Skeleton_walking_07.png");
            this.imgEnemy.Images.SetKeyName(29, "Skeleton_walking_08.png");
            this.imgEnemy.Images.SetKeyName(30, "Skeleton_ko_01.png");
            this.imgEnemy.Images.SetKeyName(31, "Skeleton_ko_02.png");
            this.imgEnemy.Images.SetKeyName(32, "Skeleton_ko_03.png");
            this.imgEnemy.Images.SetKeyName(33, "Monsters_Walk_01.png");
            this.imgEnemy.Images.SetKeyName(34, "Monsters_Walk_02.png");
            this.imgEnemy.Images.SetKeyName(35, "Monsters_Walk_03.png");
            this.imgEnemy.Images.SetKeyName(36, "Monsters_Walk_04.png");
            this.imgEnemy.Images.SetKeyName(37, "Monsters_Walk_05.png");
            this.imgEnemy.Images.SetKeyName(38, "Monsters_Walk_06.png");
            this.imgEnemy.Images.SetKeyName(39, "Monsters_Walk_07.png");
            this.imgEnemy.Images.SetKeyName(40, "Monsters_Walk_08.png");
            this.imgEnemy.Images.SetKeyName(41, "Monsters_Get Hit_01.png");
            this.imgEnemy.Images.SetKeyName(42, "Monsters_Get Hit_02.png");
            this.imgEnemy.Images.SetKeyName(43, "Monsters_Get Hit_03.png");
            this.imgEnemy.Images.SetKeyName(44, "Skeleton_Prince_walking_01.png");
            this.imgEnemy.Images.SetKeyName(45, "Skeleton_Prince_walking_02.png");
            this.imgEnemy.Images.SetKeyName(46, "Skeleton_Prince_walking_03.png");
            this.imgEnemy.Images.SetKeyName(47, "Skeleton_Prince_walking_04.png");
            this.imgEnemy.Images.SetKeyName(48, "Skeleton_Prince_walking_05.png");
            this.imgEnemy.Images.SetKeyName(49, "Skeleton_Prince_walking_06.png");
            this.imgEnemy.Images.SetKeyName(50, "Skeleton_Prince_walking_07.png");
            this.imgEnemy.Images.SetKeyName(51, "Skeleton_Prince_walking_08.png");
            this.imgEnemy.Images.SetKeyName(52, "Skeleton_Prince_ko_01.png");
            this.imgEnemy.Images.SetKeyName(53, "Skeleton_Prince_ko_02.png");
            this.imgEnemy.Images.SetKeyName(54, "Skeleton_Prince_ko_03.png");
            // 
            // btnAutoAttack
            // 
            this.btnAutoAttack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAutoAttack.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoAttack.Location = new System.Drawing.Point(660, 306);
            this.btnAutoAttack.Margin = new System.Windows.Forms.Padding(5);
            this.btnAutoAttack.Name = "btnAutoAttack";
            this.btnAutoAttack.Size = new System.Drawing.Size(110, 32);
            this.btnAutoAttack.TabIndex = 61;
            this.btnAutoAttack.Text = "Auto Attack";
            this.btnAutoAttack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAutoAttack.Click += new System.EventHandler(this.btnAutoAttack_Click);
            // 
            // lblAutoSavePrompt
            // 
            this.lblAutoSavePrompt.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblAutoSavePrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAutoSavePrompt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoSavePrompt.Location = new System.Drawing.Point(641, 608);
            this.lblAutoSavePrompt.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lblAutoSavePrompt.Name = "lblAutoSavePrompt";
            this.lblAutoSavePrompt.Size = new System.Drawing.Size(369, 49);
            this.lblAutoSavePrompt.TabIndex = 63;
            this.lblAutoSavePrompt.Text = "It is safe to close if the image is green. Red means it is saving data. Closing d" +
    "uring red can mean lost data.";
            this.lblAutoSavePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.lblAutoSavePrompt);
            this.Controls.Add(this.btnAutoAttack);
            this.Controls.Add(this.lblRebirthsDisplay);
            this.Controls.Add(this.lblRecoveryUsedDisplay);
            this.Controls.Add(this.lblTotalKillsDisplay);
            this.Controls.Add(this.lblCurrentKillsDisplay);
            this.Controls.Add(this.lblPlayerDeathsDisplay);
            this.Controls.Add(this.lblBattleText);
            this.Controls.Add(this.lblRebirthsPrompt);
            this.Controls.Add(this.lblRecoversPrompt);
            this.Controls.Add(this.lblCurrentKillsPrompt);
            this.Controls.Add(this.lblTotalKillsPrompt);
            this.Controls.Add(this.lblDeathsPrompt);
            this.Controls.Add(this.lblEnemyDefenseDisplay);
            this.Controls.Add(this.lblEnemyDefensePrompt);
            this.Controls.Add(this.lblEnemyAttackDisplay);
            this.Controls.Add(this.lblEnemyAttackPrompt);
            this.Controls.Add(this.lblWorldRankDisplay);
            this.Controls.Add(this.lblMonsterRankDisplay);
            this.Controls.Add(this.lblWorldRankPrompt);
            this.Controls.Add(this.lblMonsterRankPrompt);
            this.Controls.Add(this.pbxRecover);
            this.Controls.Add(this.pbxHealthIncrease);
            this.Controls.Add(this.lblPlayerHealthDisplay);
            this.Controls.Add(this.lblRecoverPrompt);
            this.Controls.Add(this.btnRebirth);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblEnemyHealthDisplay);
            this.Controls.Add(this.lblEnemyHealthPrompt);
            this.Controls.Add(this.pbxSoulIncrease);
            this.Controls.Add(this.lblSoulRatePrompt);
            this.Controls.Add(this.lblSoulRateDisplay);
            this.Controls.Add(this.pbxExperienceIncrease);
            this.Controls.Add(this.lblExperienceRatePrompt);
            this.Controls.Add(this.lblExperienceRateDisplay);
            this.Controls.Add(this.pbxDefenseIncrease);
            this.Controls.Add(this.pbxAttackIncrease);
            this.Controls.Add(this.pbxEnergyIncrease);
            this.Controls.Add(this.lblSoulsPrompt);
            this.Controls.Add(this.lblSoulsDisplay);
            this.Controls.Add(this.lblExperiencePrompt);
            this.Controls.Add(this.lblExperienceDisplay);
            this.Controls.Add(this.lblDefensePrompt);
            this.Controls.Add(this.lblPlayerDefenseDisplay);
            this.Controls.Add(this.lblAttackPrompt);
            this.Controls.Add(this.lblPlayerAttackDisplay);
            this.Controls.Add(this.lblEnergyPrompt);
            this.Controls.Add(this.lblPlayerEnergyDisplay);
            this.Controls.Add(this.lblPlayerHealthPrompt);
            this.Controls.Add(this.lblCharacterInformation);
            this.Controls.Add(this.pbxMonster);
            this.Controls.Add(this.lblAchievements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMonster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnergyIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAttackIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDefenseIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExperienceIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSoulIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHealthIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMonster;
        private System.Windows.Forms.Label lblCharacterInformation;
        private System.Windows.Forms.Label lblPlayerHealthPrompt;
        private System.Windows.Forms.Label lblEnergyPrompt;
        private System.Windows.Forms.Label lblPlayerEnergyDisplay;
        private System.Windows.Forms.Label lblAttackPrompt;
        private System.Windows.Forms.Label lblPlayerAttackDisplay;
        private System.Windows.Forms.Label lblDefensePrompt;
        private System.Windows.Forms.Label lblPlayerDefenseDisplay;
        private System.Windows.Forms.Label lblExperiencePrompt;
        private System.Windows.Forms.Label lblExperienceDisplay;
        private System.Windows.Forms.Label lblSoulsPrompt;
        private System.Windows.Forms.Label lblSoulsDisplay;
        private System.Windows.Forms.PictureBox pbxEnergyIncrease;
        private System.Windows.Forms.PictureBox pbxAttackIncrease;
        private System.Windows.Forms.PictureBox pbxDefenseIncrease;
        private System.Windows.Forms.Label lblExperienceRatePrompt;
        private System.Windows.Forms.Label lblExperienceRateDisplay;
        private System.Windows.Forms.PictureBox pbxExperienceIncrease;
        private System.Windows.Forms.Label lblSoulRatePrompt;
        private System.Windows.Forms.Label lblSoulRateDisplay;
        private System.Windows.Forms.PictureBox pbxSoulIncrease;
        private System.Windows.Forms.Label lblEnemyHealthPrompt;
        private System.Windows.Forms.Label lblEnemyHealthDisplay;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label btnNewGame;
        private System.Windows.Forms.Label btnRebirth;
        private System.Windows.Forms.Label lblRecoverPrompt;
        private System.Windows.Forms.PictureBox pbxHealthIncrease;
        private System.Windows.Forms.Label lblPlayerHealthDisplay;
        private System.Windows.Forms.Label lblAchievements;
        private System.Windows.Forms.PictureBox pbxRecover;
        private System.Windows.Forms.Label lblMonsterRankPrompt;
        private System.Windows.Forms.Label lblWorldRankPrompt;
        private System.Windows.Forms.Label lblMonsterRankDisplay;
        private System.Windows.Forms.Label lblWorldRankDisplay;
        private System.Windows.Forms.Label lblEnemyAttackDisplay;
        private System.Windows.Forms.Label lblEnemyAttackPrompt;
        private System.Windows.Forms.Label lblEnemyDefenseDisplay;
        private System.Windows.Forms.Label lblEnemyDefensePrompt;
        private System.Windows.Forms.ImageList imgMisc;
        private System.Windows.Forms.Timer timeTicker;
        private System.Windows.Forms.Label lblDeathsPrompt;
        private System.Windows.Forms.Label lblTotalKillsPrompt;
        private System.Windows.Forms.Label lblCurrentKillsPrompt;
        private System.Windows.Forms.Label lblRecoversPrompt;
        private System.Windows.Forms.Label lblRebirthsPrompt;
        private System.Windows.Forms.Label lblBattleText;
        private System.Windows.Forms.Label lblPlayerDeathsDisplay;
        private System.Windows.Forms.Label lblCurrentKillsDisplay;
        private System.Windows.Forms.Label lblTotalKillsDisplay;
        private System.Windows.Forms.Label lblRecoveryUsedDisplay;
        private System.Windows.Forms.Label lblRebirthsDisplay;
        private System.Windows.Forms.ImageList imgEnemy;
        private System.Windows.Forms.Label btnAutoAttack;
        private System.Windows.Forms.Label lblAutoSavePrompt;
    }
}

