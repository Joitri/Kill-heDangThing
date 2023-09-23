using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kill_The_Dang_Thing
{
    public partial class MainScreen : Form
    {
        // Create a random object
        Random random = new Random();

        // Fields for character============================
        // Health
        long playerHealthLevel = 1;
        long playerMaxHealth = 50;
        long playerCurrentHealth = 50;
        long expNeededHealth;

        // Energy
        long playerEnergyLevel = 1;
        long playerMaxEnergy = 25;
        long playerCurrentEnergy = 25;
        long expNeededEnergy;

        // Combat
        long playerAttackLevel = 1;
        long playerAttack = 25;
        long expNeededAttack;
        long playerDefenseLevel = 1;
        long playerDefense = 25;
        long expNeededDefense;

        // Currencies
        byte playerExperienceRate = 1;
        long playerCurrentExperience;
        long soulsNeededExpRate;
        byte playerSoulsRate = 1;
        long playerSouls;
        long soulsNeededSoulsRate;
        long soulsNeededToRecover;

        // bools for upgrading stats
        bool canUpgradeHealth = false;
        bool canUpgradeEnergy = false;
        bool canUpgradeAttack = false;
        bool canUpgradeDefense = false;
        bool canUpgradeExpRate = false;
        bool canUpgradeSoulRate = false;
        bool canRecover = false;

        // Fields for enemy on screen ===============================
        int monsterRank = 1;
        int worldRank = 1;
        long monsterHealth = 1;
        long monsterAttack = 1;
        long monsterDefense = 1;
        long monsterExpReward;
        long monsterSoulReward;

        // Auto Attack Bools
        bool autoAttack = false;
        bool autoAttackClicked = false;

        // Fields to adjust monster and world rank and "Achievements"
        byte monsterKill;
        long currentMonsterKill;
        long totalMonsterKill;
        long recoveryUsedTotal;
        long playerDeaths;
        long playerRebirths;

        // Recovery
        byte recoverTime;

        // Save and Load fields
        StreamReader inputFile;
        StreamWriter outputFile;
        byte autoSaveTimer = 0;
        bool autoSave = false;

        public MainScreen()
        {
            InitializeComponent();
            
            // Load players previous game
            AutoLoad();

            // Update information from previous game
            UpdateDisplay();
        }

        // Represents the number of images to step through        
        int currentImage;                              // Current image
        int whichEnemy;                                // Which enemy
        int imgLength;                                 // Length of images
        bool boolAttack = false;                       // **Bools left out of timer,
        bool enemyDead = false;                        // If not then each tick would
                                                       // declare the bool which would
                                                       // prevent animation.**

        private void timeTicker_Tick(object sender, EventArgs e)
        {
            // Animation =================================================

            // Starting Image
            int startImage = whichEnemy * 11;

            // Fields for animation
            const int enemyCount = 5;
            int[] intEnemy = new int[enemyCount];

            // For establishing where the images should start
            intEnemy[0] = 0;
            intEnemy[1] = 11;
            intEnemy[2] = 22;
            intEnemy[3] = 33;
            intEnemy[4] = 44;

            // Get Hit
            if (boolAttack == true)
            {
                // Establishes the length of the images to step through
                imgLength = 10 + intEnemy[whichEnemy];

                // Displays the current image
                pbxMonster.Image = imgEnemy.Images[currentImage];

                // Steps to the next image to display
                currentImage++;

                // Resets based on image length
                if (currentImage >= imgLength)
                {
                    currentImage = startImage + 8;
                    boolAttack = false;
                }
            }

            // Walking 
            else
            {
                // Establishes the length of the images to step through
                imgLength = 7 + intEnemy[whichEnemy];

                // Displays the current image
                pbxMonster.Image = imgEnemy.Images[currentImage];

                // Steps to the next image to display
                currentImage++;

                // Resets based on image length
                if (currentImage >= imgLength)
                {
                    currentImage = startImage;
                }
            }


            // Game Features ======================================================

            // Recovery

            // Timer for recovery;
            recoverTime++;

            // Recovers health and energy, and resets timer
            if (recoverTime == 200)
            {
                // Recover Health
                playerCurrentHealth = playerCurrentHealth + (playerMaxHealth / 5);

                // Prevents current health surpassing max health
                if (playerCurrentHealth > playerMaxHealth)
                {
                    playerCurrentHealth = playerMaxHealth;
                }

                // Recover energy
                playerCurrentEnergy = playerCurrentEnergy + (playerMaxEnergy / 5);

                // Prevents current energy surpassing max energy
                if (playerCurrentEnergy > playerMaxEnergy)
                {
                    playerCurrentEnergy = playerMaxEnergy;
                }

                // Reset timer
                recoverTime = 0;
            }

            // Auto Attack
            if (autoAttack == true)
            {
                AttackEnemy();
            }

            // Checks if the enemy has 0 or less health
            if (monsterHealth < 1)
            {
                // Declares enemy dead
                enemyDead = true;

                // Increase kill counts
                monsterKill++;
                currentMonsterKill++;
                totalMonsterKill++;

                // Update monster rank
                if (monsterRank <= 214748647)
                {
                    if (monsterKill == 25 || monsterKill == 50 || monsterKill == 75 ||
                        monsterKill == 100 || monsterKill == 125 || monsterKill == 150 ||
                        monsterKill == 175 || monsterKill == 200 || monsterKill == 225 ||
                        monsterKill == 250)
                    {
                        monsterRank++;
                    }
                }

                // Upgrade world rank Reset Count
                if (worldRank <= 214748647)
                {
                    if (monsterKill == 255)
                    {
                        worldRank++;
                        monsterKill = 0;
                    }
                }
            }

            // If enemy is dead reward and respawn
            if (enemyDead == true)
            {
                // Reward the player
                RewardPlayer();

                // Randomly chooses which enemy set to take from
                whichEnemy = random.Next(enemyCount);

                // Spawn a new monster
                SpawnMonster();

                // Resets bool
                enemyDead = false;
            }

            // Game Over
            if (playerCurrentHealth <= 0)
            {
                GameOver();
            }

            // Prevents numbers from reaching negatives
            // By establishing maximums

            /* Extremely EXTREMELY rare for a person or monster to reach
             * these levels. If they do, well it's a stale mate and they need to rebirth. */


            // Player=============

            // Health
            if (playerHealthLevel >= 2000000000)
            {
                canUpgradeHealth = false;
            }

            // Energy
            if (playerEnergyLevel >= 4000000000)
            {
                canUpgradeEnergy = false;
            }

            // Attack
            if (playerAttackLevel >= 4000000000)
            {
                canUpgradeAttack = false;
            }

            // Defense
            if (playerDefenseLevel >= 4000000000)
            {
                canUpgradeDefense = false;
            }

            // Experience
            if (playerCurrentExperience >= 999999999999999999)
            {
                playerCurrentExperience = 999999999999999999;
            }

            // Souls
            if (playerSouls >= 999999999999999999)
            {
                playerSouls = 999999999999999999;
            }

            // Enemy=============

            // Health
            if (monsterHealth > 999999999999)
            {
                monsterHealth = 999999999999;
            }

            if (monsterAttack > 999999999999)
            {
                monsterAttack = 999999999999;
            }

            if (monsterDefense > 999999999999)
            {
                monsterDefense = 999999999999;
            }

            // Auto save clock =============

            // Increments clock timer
            autoSaveTimer++;

            // Every 25.5 seconds auto saves
            if (autoSaveTimer == 255)
            {
                AutoSave();
                autoSaveTimer = 0;
            }

            UpdateDisplay();

        }

        private void GameOver()
        {
            // Stop the clock
            timeTicker.Stop();

            // Give option on what to do
            long soulCost = (worldRank * monsterRank) * 10;
            const string caption = "You Died";
            var result = MessageBox.Show("You have died. Would you like spend " + 
                soulCost + "souls to recover fully?",
                caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                playerCurrentHealth = playerMaxHealth;
                playerCurrentExperience = playerCurrentExperience - 100;
                playerSouls = playerSouls - soulCost;
                playerDeaths++;
            }
            else
            {
                playerCurrentExperience = playerCurrentExperience - 1000;
                playerCurrentHealth = playerMaxHealth / 2;
                playerDeaths++;
            }

            // Set auto-attack to false
            autoAttack = false;
            autoAttackClicked = false;

            // Start the clock
            timeTicker.Start();
        }

        private void SpawnMonster()
        {
            // Create new enemy
            monsterHealth = ((random.Next(5) + 1) * monsterRank + 5) *
                ((random.Next(5) +1) * worldRank);

            monsterAttack = ((random.Next(5) + 1) * monsterRank + 5) + 
                ((random.Next(5) + 1) * worldRank);

            monsterDefense = ((random.Next(5) + 1) * monsterRank + 5) + 
                ((random.Next(5) + 1) * worldRank);

            monsterExpReward = playerExperienceRate * 
                random.Next(monsterRank * worldRank + 1) + 1;

            monsterSoulReward = playerSoulsRate * 
                random.Next(monsterRank * worldRank + 1) + 1;
        }

        private void RewardPlayer()
        {
            // Update experience and souls
            playerCurrentExperience = playerCurrentExperience + monsterExpReward;
            playerSouls = playerSouls + monsterSoulReward;
        }

        private void UpdateDisplay()
        {

            // Declares formula for player information
            playerMaxHealth = playerHealthLevel * 50;
            playerMaxEnergy = playerEnergyLevel * 50;
            playerAttack = playerAttackLevel * 25;
            playerDefense = playerDefenseLevel * 25;

            // Display Player Infomation
            lblPlayerHealthDisplay.Text = playerCurrentHealth.ToString("n0") +
                " / " + playerMaxHealth.ToString("n0");
            lblPlayerEnergyDisplay.Text = playerCurrentEnergy.ToString("n0") +
                " / " + playerMaxEnergy.ToString("n0");
            lblPlayerAttackDisplay.Text = playerAttack.ToString("n0");
            lblPlayerDefenseDisplay.Text = playerDefense.ToString("n0");
            lblExperienceDisplay.Text = playerCurrentExperience.ToString("n0");
            lblExperienceRateDisplay.Text = playerExperienceRate.ToString("n0");
            lblSoulsDisplay.Text = playerSouls.ToString("n0");
            lblSoulRateDisplay.Text = playerSoulsRate.ToString("n0");

            // Display Monster Information
            lblEnemyHealthDisplay.Text = monsterHealth.ToString("n0");
            lblEnemyAttackDisplay.Text = monsterAttack.ToString("n0");
            lblEnemyDefenseDisplay.Text = monsterDefense.ToString("n0");

            // Update "Achievement" display
            lblPlayerDeathsDisplay.Text = playerDeaths.ToString("n0");
            lblCurrentKillsDisplay.Text = currentMonsterKill.ToString("n0");
            lblTotalKillsDisplay.Text = totalMonsterKill.ToString("n0");
            lblRecoveryUsedDisplay.Text = recoveryUsedTotal.ToString("n0");
            lblRebirthsDisplay.Text = playerRebirths.ToString("n0");

            // Update world rank display
            if (worldRank < 1000)
            {
                lblWorldRankDisplay.Text = "F";
            }
            else if (worldRank > 1000 && worldRank < 2500)
            {
                lblWorldRankDisplay.Text = "E";
            }
            else if (worldRank > 2500 && worldRank < 5000)
            {
                lblWorldRankDisplay.Text = "D";
            }
            else if (worldRank > 5000 && worldRank < 10000)
            {
                lblWorldRankDisplay.Text = "C";
            }
            else if (worldRank > 10000 && worldRank < 25000)
            {
                lblWorldRankDisplay.Text = "B";
            }
            else if (worldRank > 25000 && worldRank < 50000)
            {
                lblWorldRankDisplay.Text = "A";
            }
            else if (worldRank > 50000 && worldRank < 200000)
            {
                lblWorldRankDisplay.Text = "S";
            }
            else
            {
                // Not as bad, but good luck none-the-less
                lblWorldRankDisplay.Text = "SS";
            }

            // Updates monster rank display
            if (monsterRank < 10000)
            {
                lblMonsterRankDisplay.Text = "F";
            }
            else if (monsterRank > 10000 && monsterRank < 25000)
            {
                lblMonsterRankDisplay.Text = "E";
            }
            else if (monsterRank > 25000 && monsterRank < 100000)
            {
                lblMonsterRankDisplay.Text = "D";
            }
            else if (monsterRank > 100000 && monsterRank < 1000000)
            {
                lblMonsterRankDisplay.Text = "C";
            }
            else if (monsterRank > 1000000 && monsterRank < 10000000)
            {
                lblMonsterRankDisplay.Text = "B";
            }
            else if (monsterRank > 10000000 && monsterRank < 25000000)
            {
                lblMonsterRankDisplay.Text = "A";
            }
            else if (monsterRank > 25000000 && monsterRank < 100000000)
            {
                lblMonsterRankDisplay.Text = "S";
            }
            else
            {
                // Good luck
                lblMonsterRankDisplay.Text = "SS";
            }

            // Auto save
            if (autoSave == false)
            {
                btnClose.BackColor = Color.Green;
            }
            else
            {
                btnClose.BackColor = Color.Red;
            }

            CanUpgrade();
        }

        private void AttackEnemy()
        {
            if (playerCurrentEnergy > 0)
            {
                // Field for damage TO player
                long playerDamage = (monsterAttack - playerDefense);

                // Field for damage TO monster
                long monsterDamage = (playerAttack - monsterDefense);

                // Player Vs Enemy
                if (playerAttack > monsterDefense)
                {
                    monsterHealth = monsterHealth - monsterDamage;
                }
                else
                {
                    monsterDamage = 0;
                }

                // Enemy Vs Player
                if (monsterAttack > playerDefense)
                {
                    playerCurrentHealth = playerCurrentHealth - playerDamage;
                }
                else
                {
                    playerDamage = 0;
                }

                // Energy cost of an attack
                playerCurrentEnergy--;

                // Display combat
                lblBattleText.Text = "You hit for " + monsterDamage.ToString() +
                    ", and the monster hit you for " + playerDamage.ToString() + "." + 
                    Environment.NewLine + "You received " + monsterExpReward + " experience and " +
                    monsterSoulReward + " souls.";
            }
        }

        private void CanUpgrade()
        {
            // Determine required currency for upgrades
            expNeededHealth = playerHealthLevel * 100;
            expNeededEnergy = playerEnergyLevel * 100;
            expNeededAttack = playerAttackLevel * 50;
            expNeededDefense = playerDefenseLevel * 50;
            soulsNeededExpRate = playerExperienceRate * 1000;
            soulsNeededSoulsRate = playerSoulsRate * 1000;
            soulsNeededToRecover = ((playerMaxEnergy - playerCurrentEnergy) * 2) +
                ((playerMaxHealth - playerCurrentHealth) * 2);

            // Check if can be upgraded

            // Health
            if (playerCurrentExperience >= expNeededHealth)
            {
                if (playerHealthLevel == 4000000000)
                {
                    canUpgradeHealth = false;
                    pbxHealthIncrease.Image = imgMisc.Images[0];
                }
                else
                {
                    canUpgradeHealth = true;
                    pbxHealthIncrease.Image = imgMisc.Images[1];
                }
            }
            else
            {
                canUpgradeHealth = false;
                pbxHealthIncrease.Image = imgMisc.Images[0];
            }

            // Energy
            if (playerCurrentExperience >= expNeededEnergy)
            {
                if (playerEnergyLevel == 4000000000)
                {
                    canUpgradeEnergy = false;
                    pbxEnergyIncrease.Image = imgMisc.Images[0];
                }
                else
                {
                    canUpgradeEnergy = true;
                    pbxEnergyIncrease.Image = imgMisc.Images[1];
                }
            }
            else
            {
                canUpgradeEnergy = false;
                pbxEnergyIncrease.Image = imgMisc.Images[0];
            }

            // Attack
            if (playerCurrentExperience >= expNeededAttack)
            {
                if (playerAttackLevel == 4000000000)
                {

                    canUpgradeAttack = false;
                    pbxAttackIncrease.Image = imgMisc.Images[0];
                }
                else
                {
                    canUpgradeAttack = true;
                    pbxAttackIncrease.Image = imgMisc.Images[1];
                }
            }
            else
            {
                canUpgradeAttack = false;
                pbxAttackIncrease.Image = imgMisc.Images[0];
            }

            // Defense
            if (playerCurrentExperience >= expNeededDefense)
            {
                if (playerDefenseLevel == 4000000000)
                {
                    canUpgradeDefense = false;
                    pbxDefenseIncrease.Image = imgMisc.Images[0];
                }
                else
                {
                    canUpgradeDefense = true;
                    pbxDefenseIncrease.Image = imgMisc.Images[1];
                }
            }
            else
            {
                canUpgradeDefense = false;
                pbxDefenseIncrease.Image = imgMisc.Images[0];
            }

            // Experience Rate
            if (playerSouls >= soulsNeededExpRate)
            {
                if (playerExperienceRate < 10)
                {
                    canUpgradeExpRate = true;
                    pbxExperienceIncrease.Image = imgMisc.Images[1];
                }
                else
                {
                    canUpgradeExpRate = false;
                    pbxExperienceIncrease.Image = imgMisc.Images[0];
                }
            }
            else
            {
                canUpgradeExpRate = false;
                pbxExperienceIncrease.Image = imgMisc.Images[0];
            }


            // Soul Rate
            if (playerSouls >= soulsNeededSoulsRate)
            {
                if (playerSoulsRate < 10)
                {
                    canUpgradeSoulRate = true;
                    pbxSoulIncrease.Image = imgMisc.Images[1];
                }
                else
                {
                    canUpgradeSoulRate = false;
                    pbxSoulIncrease.Image = imgMisc.Images[0];
                }
            }
            else
            {
                canUpgradeSoulRate = false;
                pbxSoulIncrease.Image = imgMisc.Images[0];
            }

            // Recovery // The added && prevents the image from access at the start of the game
            if (playerSouls >= soulsNeededToRecover && playerSouls != 0)
            {
                canRecover = true;
                pbxRecover.Image = imgMisc.Images[1];
            }
            else
            {
                canRecover = false;
                pbxRecover.Image = imgMisc.Images[0];
            }
        }

        private void AutoSave()
        {
            timeTicker.Stop();
            autoSave = true;
            outputFile = File.CreateText("SaveFile.txt");
            try
            {
                outputFile.WriteLine(playerHealthLevel);
                outputFile.WriteLine(playerCurrentHealth);
                outputFile.WriteLine(playerEnergyLevel);
                outputFile.WriteLine(playerCurrentEnergy);
                outputFile.WriteLine(playerAttackLevel);
                outputFile.WriteLine(playerDefenseLevel);
                outputFile.WriteLine(playerCurrentExperience);
                outputFile.WriteLine(playerExperienceRate);
                outputFile.WriteLine(playerSouls);
                outputFile.WriteLine(playerSoulsRate);

                outputFile.WriteLine(monsterHealth);
                outputFile.WriteLine(monsterAttack);
                outputFile.WriteLine(monsterDefense);
                outputFile.WriteLine(monsterExpReward);
                outputFile.WriteLine(monsterSoulReward);
                outputFile.WriteLine(monsterKill);
                outputFile.WriteLine(currentMonsterKill);
                outputFile.WriteLine(totalMonsterKill);
                outputFile.WriteLine(recoveryUsedTotal);
                outputFile.WriteLine(playerDeaths);
                outputFile.WriteLine(playerRebirths);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            outputFile.Close();
            autoSave = false;
            timeTicker.Start();
        }

        private void AutoLoad()
        {
            inputFile = File.OpenText("SaveFile.txt");
            try
            {
                playerHealthLevel = long.Parse(inputFile.ReadLine());
                playerCurrentHealth = long.Parse(inputFile.ReadLine());
                playerEnergyLevel = long.Parse(inputFile.ReadLine());
                playerCurrentEnergy = long.Parse(inputFile.ReadLine());

                playerAttackLevel = long.Parse(inputFile.ReadLine());
                playerDefenseLevel = long.Parse(inputFile.ReadLine());
                playerCurrentExperience = long.Parse(inputFile.ReadLine());
                playerExperienceRate = byte.Parse(inputFile.ReadLine());
                playerSouls = long.Parse(inputFile.ReadLine());
                playerSoulsRate = byte.Parse(inputFile.ReadLine());

                monsterHealth = long.Parse(inputFile.ReadLine());
                monsterAttack = long.Parse(inputFile.ReadLine());
                monsterDefense = long.Parse(inputFile.ReadLine());
                monsterExpReward = long.Parse(inputFile.ReadLine());
                monsterSoulReward = long.Parse(inputFile.ReadLine());

                monsterKill = byte.Parse(inputFile.ReadLine());
                currentMonsterKill = long.Parse(inputFile.ReadLine());
                totalMonsterKill = long.Parse(inputFile.ReadLine());
                recoveryUsedTotal = long.Parse(inputFile.ReadLine());
                playerDeaths = long.Parse(inputFile.ReadLine());

                playerRebirths = long.Parse(inputFile.ReadLine());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            inputFile.Close();
        }

        private void pbxMonster_Click(object sender, EventArgs e)
        {
            // Dictates you are attacking
            boolAttack = true;

            // Calls AttackEnemy method
            AttackEnemy();
        }

        private void pbxHealthIncrease_Click(object sender, EventArgs e)
        {
            // Checks if you CAN upgrade
            if (canUpgradeHealth == true)
            {
                playerHealthLevel++;
                playerCurrentExperience = playerCurrentExperience - expNeededHealth;
            }
        }

        private void pbxEnergyIncrease_Click(object sender, EventArgs e)
        {
            // Checks if you CAN upgrade
            if (canUpgradeEnergy == true)
            {
                playerEnergyLevel++;
                playerCurrentExperience = playerCurrentExperience - expNeededEnergy;
            }
        }

        private void pbxAttackIncrease_Click(object sender, EventArgs e)
        {
            // Checks if you CAN upgrade
            if (canUpgradeAttack == true)
            {
                playerAttackLevel++;
                playerCurrentExperience = playerCurrentExperience - expNeededAttack;
            }
        }

        private void pbxDefenseIncrease_Click(object sender, EventArgs e)
        {
            // Checks if you CAN upgrade
            if (canUpgradeDefense == true)
            {
                playerDefenseLevel++;
                playerCurrentExperience = playerCurrentExperience - expNeededDefense;
            }
        }

        private void pbxExperienceIncrease_Click(object sender, EventArgs e)
        {
            // Checks if you CAN upgrade
            if (canUpgradeExpRate == true)
            {
                playerExperienceRate++;
                playerSouls = playerSouls - soulsNeededExpRate;
            }
        }

        private void pbxSoulIncrease_Click(object sender, EventArgs e)
        {
            // Checks if you CAN upgrade
            if (canUpgradeSoulRate == true)
            {
                playerSoulsRate++;
                playerSouls = playerSouls - soulsNeededSoulsRate;
            }
        }

        private void btnAutoAttack_Click(object sender, EventArgs e)
        {
            // Checks if you are NOT auto attacking already
            if (autoAttackClicked == false)
            {
                autoAttack = true;
                autoAttackClicked = true;
            }

            // If you are already auto attacking turns it off
            else
            {
                autoAttack = false;
                autoAttackClicked = false;
            }
        }

        private void pbxRecover_Click(object sender, EventArgs e)
        {
            long soulCost = ((playerMaxEnergy - playerCurrentEnergy) * 2) + 
                ((playerMaxHealth - playerCurrentHealth) * 2);
            if (canRecover == true)
            {
                const string caption = "Recovery";
                var result = MessageBox.Show("Would you like spend " + soulCost + " souls to recover fully?",
                    caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (playerSouls - soulCost >= 0)
                {
                    if (result == DialogResult.Yes)
                    {
                        playerCurrentHealth = playerMaxHealth;
                        playerCurrentEnergy = playerMaxEnergy;
                        playerSouls = playerSouls - soulCost;
                        recoveryUsedTotal++;
                    }
                }
            }
        }

        private void btnRebirth_Click(object sender, EventArgs e)
        {
            const string caption = "Rebirth";
            var result = MessageBox.Show("Would you like to rebirth? Your world and monster rank will be reset " +
                "but you will get to keep your current stats, experience, and souls.",
                caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                currentMonsterKill = 0;
                monsterRank = 1;
                worldRank = 1;
                playerRebirths++;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            const string caption = "New Game";
            var result = MessageBox.Show("Would you like to start a new game? Everything will reset.",
                caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Fields for character
                // Health
                playerHealthLevel = 1;
                playerCurrentHealth = 50;

                // Energy
                playerEnergyLevel = 1;
                playerCurrentEnergy = 50;

                // Combat
                playerAttackLevel = 1;
                playerDefenseLevel = 1;

                // Currencies
                playerExperienceRate = 1;
                playerCurrentExperience = 0;
                playerSoulsRate = 1;
                playerSouls = 0;

                // bools for upgrading stats
                canUpgradeHealth = false;
                canUpgradeEnergy = false;
                canUpgradeAttack = false;
                canUpgradeDefense = false;
                canUpgradeExpRate = false;
                canUpgradeSoulRate = false;
                canRecover = false;

                // Fields for enemy on screen
                monsterRank = 1;
                worldRank = 1;
                monsterHealth = 1;
                monsterAttack = 1;
                monsterDefense = 1;
                monsterExpReward = 1;
                monsterSoulReward = 1;

                // Auto Attack Bools
                autoAttack = false;
                autoAttackClicked = false;

                // Fields to adjust monster and world rank and "Achievements"
                monsterKill = 0;
                currentMonsterKill = 0;
                totalMonsterKill = 0;
                recoveryUsedTotal = 0;
                playerDeaths = 0;
                playerRebirths = 0;

                lblBattleText.Text = "Click the monster.";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.BackColor == Color.Green)
            {
                // Close program
                this.Close();
            }
            else
            {
                /* If -by some weird reason they have the slowest computer in the world
                 * and/or their processing is insanely bogged down- display a message. */
                MessageBox.Show("The game is currently saving your data, please wait one moment.");
            }
        }
    }
}
