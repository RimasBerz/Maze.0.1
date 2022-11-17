using System;
using System.Windows.Forms;
using System.Drawing;

namespace Maze
{
    class Labirint
    {
        public int height;
        public int width; 

        public MazeObject[,] maze;
        public PictureBox[,] images;

        public static Random r = new Random();
        public Form parent;

        public Labirint(Form parent, int width, int height)
        {
            this.width = width;
            this.height = height;
            this.parent = parent;

            maze = new MazeObject[height, width];
            images = new PictureBox[height, width];

            Generate();
        }
        int smileX = 0;
        int smileY = 2;

        private void Generate()
        {
            
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    MazeObject.MazeObjectType current = MazeObject.MazeObjectType.HALL;

              
                    if (r.Next(4) == 0)
                    {
                        current = MazeObject.MazeObjectType.WALL;
                    }


                    if (r.Next(250) == 0)
                    {
                        current = MazeObject.MazeObjectType.MEDAL;
                    }

                    
                    if (r.Next(250) == 0)
                    {
                        current = MazeObject.MazeObjectType.ENEMY;
                    }

                   
                    if (y == 0 || x == 0 || y == height - 1 | x == width - 1)
                    {
                        current = MazeObject.MazeObjectType.WALL;
                    }

                   
                    if (x == smileX && y == smileY)
                    {
                        current = MazeObject.MazeObjectType.CHAR;
                    }
                    

                    if (x == smileX + 1 && y == smileY || x == width - 1 && y == height - 3)
                    {
                        current = MazeObject.MazeObjectType.HALL;
                    }
                    maze[y, x] = new MazeObject(current);
                    images[y, x] = new PictureBox();
                    images[y, x].Location = new Point(x * maze[y, x].width, y * maze[y, x].height);
                    images[y, x].Parent = parent;
                    images[y, x].Width = maze[y, x].width;
                    images[y, x].Height = maze[y, x].height;
                    images[y, x].BackgroundImage = maze[y, x].texture;
                    images[y, x].Visible = false;
                }
            }
        }
        private void Down_Click(object sender, System.EventArgs e)
        {
           //MazeObject.MazeObjectType position1 = MazeObject.MazeObjectType.CHAR;
            
            images[smileX, smileY].Location = new Point(smileX - 1,smileY);
        }
        private void Up_Click(object sender, System.EventArgs e)
        {
            //MazeObject.MazeObjectType position1 = MazeObject.MazeObjectType.CHAR;
           
            images[smileX, smileY].Location = new Point(smileX + 1, smileY);
        }
        private void Right_Click(object sender, System.EventArgs e)
        {
            //MazeObject.MazeObjectType position1 = MazeObject.MazeObjectType.CHAR;

            images[smileX, smileY].Location = new Point(smileX, smileY + 1);
        }
        private void Left_Click(object sender, System.EventArgs e)
        {
            //MazeObject.MazeObjectType position1 = MazeObject.MazeObjectType.CHAR;

            images[smileX, smileY].Location = new Point(smileX, smileY - 1);
        }
        public void Show()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    images[y, x].Visible = true;
                    
                }
            }
        }
    }
}