using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Hero heroInMap;
        //Map MapInForm = new Map(17, 20, 17, 20, 4, 5);
        GameEngine GE = new GameEngine();
        Random r = new Random();
        int height;
        int width;

        //string[,] mapArray;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //initialiseMap();
            start();
            //Map();
        }
        public void start()
        {
            //height = 15;
            //width = 10;
            //mapArray = new string[height, width];
            GE = new GameEngine();
            displayMap();
            statsHero();
            displayShopItems();
            enemyMethod();
            leaderStats();
        }

        public void displayShopItems()
        {
            lbl_weapon1.Text = GE.ShopGE.displayWeapon(0);
            lbl_weapon2.Text = GE.ShopGE.displayWeapon(1);
            lbl_weapon3.Text = GE.ShopGE.displayWeapon(2);
        }
        public void statsHero()
        {
            lbl_Hero.Text = GE.map.MapHero.ToString();
        }
        public void leaderStats()
        {
            lbl_Leader.Text = GE.map.LeaderInMap.ToString();
        }
        public void enemyMethod()
        {
            for (int i = 0; i < GE.map.EnemyArray.Length; i++)
            {
                if (GE.map.EnemyArray[i].id == Tile.TileType.goblin)
                {
                    lbl_Goblin.Text = GE.map.EnemyArray[i].ToString();
                }
                else
                {
                    lbl_Mage.Text = GE.map.EnemyArray[i].ToString();
                }
            }
        }
        public void displayMap()
        {
            string DisMap = " ";
            for (int Y = 0; Y < GE.map.Height; Y++)
            {
                for (int X = 0; X < GE.map.Width; X++)
                {
                    DisMap += DisChar(X, Y);
                }
                DisMap += "\n";
            }
            LBL_map.Text = DisMap;
        }
        public void LeaderDirection(int direction)
        {
            if (direction == 1)
            {
                GE.map.LeaderInMap.Move(GE.map.LeaderInMap.ReturnMove(Leader.movement.Up));
            }
            else if (direction == 2)
            {
                GE.map.LeaderInMap.Move(GE.map.LeaderInMap.ReturnMove(Leader.movement.Down));
            }
            else if (direction == 3)
            {
                GE.map.LeaderInMap.Move(GE.map.LeaderInMap.ReturnMove(Leader.movement.Left));
            }
            else
            {
                GE.map.LeaderInMap.Move(GE.map.LeaderInMap.ReturnMove(Leader.movement.Right));
            }
        }

        public string DisChar(int x, int y)
        {
            if (GE.map.MapArray[y, x].id == Tile.TileType.emptyTile)
            {
                return " . ";
            }
            else if (GE.map.MapArray[y, x].id == Tile.TileType.Obstacle)
            {
                return "X";
            }
            else if (GE.map.MapArray[y, x].id == Tile.TileType.Hero)
            {
                statsHero();
                return " H ";
            }
            else if (GE.map.MapArray[y, x].id == Tile.TileType.goblin)
            {
                return " G ";
            }
            else if (GE.map.MapArray[y, x].id == Tile.TileType.leader)
            {
                return " L ";
            }
            else if (GE.map.MapArray[y, x].id == Tile.TileType.Gold)
            {
                return " 0 ";
            }
            else if (GE.map.MapArray[y, x].id == Tile.TileType.mage)
            {
                return " M ";
            }
            else if (GE.map.MapArray[y, x].id == Tile.TileType.meleeWeapon)
            {
                return "MW";
            }
            else
            {
                return " !  ";
            }
        }

        public void moveEnemies()
        {
            for (int i = 0; i < GE.map.EnemyArray.Length; i++)
            {
                int moveDirection = 0;
                bool canMove = false;

                bool left = false;
                bool right = false;
                bool up = false;
                bool down = false;

                while (canMove == false)
                {
                    moveDirection = r.Next(1, 5);
                    switch (moveDirection)
                    {
                        case 1:
                            if (GE.map.EnemyArray[i].ReturnMove(Character.movement.Up) == Character.movement.idle)
                            {
                                canMove = false;
                                up = true;
                            }
                            else
                            {
                                canMove = true;
                            }
                            break;
                        case 2:
                            if (GE.map.EnemyArray[i].ReturnMove(Character.movement.Down) == Character.movement.idle)
                            {
                                canMove = false;
                                down = true;
                            }
                            else
                            {
                                canMove = true;
                            }
                            break;
                        case 3:
                            if (GE.map.EnemyArray[i].ReturnMove(Character.movement.Left) == Character.movement.idle)
                            {
                                canMove = false;
                                left = true;
                            }
                            else
                            {
                                canMove = true;
                            }
                            break;
                        case 4:
                            if (GE.map.EnemyArray[i].ReturnMove(Character.movement.Right) == Character.movement.idle)
                            {
                                canMove = false;
                                right = true;
                            }
                            else
                            {
                                canMove = true;
                            }
                            break;
                    }

                    if (left == true && right == true && up == true && down == true)
                    {
                        canMove = false;
                        break;
                    }
                }
                if (canMove == true)
                {
                    if (moveDirection == 1)
                    {
                        GE.map.EnemyArray[i].Move(GE.map.EnemyArray[i].ReturnMove(Enemy.movement.Up));
                    }
                    else if (moveDirection == 2)
                    {
                        GE.map.EnemyArray[i].Move(GE.map.EnemyArray[i].ReturnMove(Enemy.movement.Down));
                    }
                    else if (moveDirection == 3)
                    {
                        GE.map.EnemyArray[i].Move(GE.map.EnemyArray[i].ReturnMove(Enemy.movement.Left));
                    }
                    else
                    {
                        GE.map.EnemyArray[i].Move(GE.map.EnemyArray[i].ReturnMove(Enemy.movement.Right));
                    }
                }
                else
                {
                    // Skip the move no more options.......
                }
            }
        }

        public void BTN_Up_Click(object sender, EventArgs e)
        {
            if (GE.map.MapHero.ReturnMove(Hero.movement.Up) == Character.movement.idle)
            {
                //Error invalid 
            }
            else
            {               
                GE.map.MapHero.Move(GE.map.MapHero.ReturnMove(Hero.movement.Up));
            }
            LeaderDirection(1);
            moveEnemies();
            enemyMethod();
            displayMap();

        }

        public void BTN_Right_Click(object sender, EventArgs e)
        {
            if (GE.map.MapHero.ReturnMove(Hero.movement.Right) == Character.movement.idle)
            {
                //Error invalid 
            }
            else
            {
                GE.map.MapHero.Move(GE.map.MapHero.ReturnMove(Hero.movement.Right));
            }
            LeaderDirection(4);
            moveEnemies();
            enemyMethod();
            displayMap();
        }

        public void BTN_Left_Click(object sender, EventArgs e)
        {
            if (GE.map.MapHero.ReturnMove(Hero.movement.Left) == Character.movement.idle)
            {
                //Error invalid 
            }
            else
            {
                GE.map.MapHero.Move(GE.map.MapHero.ReturnMove(Hero.movement.Left));
            }
            LeaderDirection(3);
            moveEnemies();
            enemyMethod();
            displayMap();
        }

        public void BTN_Down_Click(object sender, EventArgs e)
        {
            if (GE.map.MapHero.ReturnMove(Hero.movement.Down) == Character.movement.idle)
            {
                //Error invalid 
            }
            else
            {
                GE.map.MapHero.Move(GE.map.MapHero.ReturnMove(Hero.movement.Down));
            }
            LeaderDirection(2);
            moveEnemies();
            enemyMethod();
            displayMap();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void LBL_map_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Hero_Click(object sender, EventArgs e)
        {

        }
        // Purchase Weapons
        private void button1_Click(object sender, EventArgs e)
        {
            if (GE.ShopGE.CanBuy(0) == true)
            {
                GE.ShopGE.buy(0);
                lbl_shopStats.Text = GE.ShopGE.displayWeapon(0);
                // call method GE.shopGE.new weapon num - 0;
            }
            else
            {
                lbl_shopStats.Text = " Cannot afford Item !";
            }

            statsHero();
        }

        private void BTN_BuyWeapon2_Click(object sender, EventArgs e)
        {
            if (GE.ShopGE.CanBuy(1) == true)
            {
                GE.ShopGE.buy(1);
                lbl_shopStats.Text = GE.ShopGE.displayWeapon(1);
            }
            else
            {
                lbl_shopStats.Text = " Cannot afford Item !";
            }
            statsHero();
        }

        private void BTN_BuyWeapon3_Click(object sender, EventArgs e)
        {
            if (GE.ShopGE.CanBuy(2) == true)
            {
                GE.ShopGE.buy(2);
                lbl_shopStats.Text = GE.ShopGE.displayWeapon(2);
            }
            else
            {
                lbl_shopStats.Text = " Cannot afford Item !";
            }
            statsHero();
        }
    }
}
