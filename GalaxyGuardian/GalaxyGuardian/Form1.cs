using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using GalaxyGuardian.Properties;
// Arpit Luthra
//January 17, 2025
//This is a 2d-based space asteroid game called Galaxy Guardian
namespace GalaxyGuardian
{
    public enum GameStates { Menu, Instructions, Controls, Game, Pause, Gameover, }

    public partial class Form1 : Form
    {
        //global variables
        GameStates Gamestate = GameStates.Menu;
        int spaceshipSpeed = 5;
        int score = 0;
        int level = 1;
        int lives = 0;
        double baseAsteroidSpeed = 3;
        int levelTimer = 10;
        bool moveLeft = false;
        bool moveRight = false;
        bool moveUp = false;
        bool moveDown = false;
        List<Asteroid> asteroids = new List<Asteroid>();
        List<Star> stars = new List<Star>();
        List<PictureBox> explosions = new List<PictureBox>();
        List<Heart> hearts = new List<Heart>();
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            ShowMenu();


            picSpaceship.Visible = false;
            lblScore.Text = "Score: 0";
        }
        public void ShowMenu()
        {
            //make game labels non-visible
            lblLevel.Visible = false;
            lblLives.Visible = false;

            // Position lblTitle at the top center
            lblTitle.Left = (ClientSize.Width - lblTitle.Width) / 2;
            lblTitle.Top = 20;


            //setup the start
            lblStart.Text = "Press ENTER to Start";

            //setup the instructions
            lblInstructions.Text = "Press 1 for Instructions";

            //setup the controls
            lblControls.Text = "Press 2 for Controls";

            //setup the exit
            lblExit.Text = "Press ESC to Exit";

            //position the labels

            // Adjust the margin for vertical spacing 
            int verticalMargin = 35;
            int moveLabelsDown = 50;

            // Calculate total height needed for labels with spacing
            int totalHeight = lblStart.Height + lblInstructions.Height + lblControls.Height + lblExit.Height + 3 * verticalMargin;

            // Calculate starting position to vertically center the labels, then shift down by the extra offset
            int startY = (ClientSize.Height - totalHeight) / 2 + moveLabelsDown;
            int centerX = ClientSize.Width / 2;

            // Position the first label
            lblStart.Left = centerX - (lblStart.Width / 2);
            lblStart.Top = startY;

            // Position the second label
            lblInstructions.Left = centerX - (lblInstructions.Width / 2);
            lblInstructions.Top = lblStart.Top + lblStart.Height + verticalMargin;

            // Position the third label
            lblControls.Left = centerX - (lblControls.Width / 2);
            lblControls.Top = lblInstructions.Top + lblInstructions.Height + verticalMargin;

            // Position the fourth label
            lblExit.Left = centerX - (lblExit.Width / 2);
            lblExit.Top = lblControls.Top + lblControls.Height + verticalMargin;

            // show all labels
            lblStart.Visible = true;
            lblInstructions.Visible = true;
            lblControls.Visible = true;
            lblExit.Visible = true;

            //show menu items
            lblStart.Visible = true;
            lblInstructions.Visible = true;
            lblControls.Visible = true;
            lblExit.Visible = true;
            lblTitle.Visible = true;
            picJupiter.Visible = true;
            picPluto.Visible = true;
            picSaturn.Visible = true;
            picVenus.Visible = true;

            //hide game items
            picSpaceship.Visible = false;
            lblScore.Visible = false;
            lblTimer.Visible = false;
            pnlInstructions.Visible = false;
            pnlControls.Visible = false;
        }

        public void HideMenu()
        {
            //hide menu items
            lblStart.Visible = false;
            lblInstructions.Visible = false;
            lblControls.Visible = false;
            lblExit.Visible = false;
            lblTitle.Visible = false;
            picJupiter.Visible = false;
            picPluto.Visible = false;
            picSaturn.Visible = false;
            picVenus.Visible = false;

            // Reset the score
            score = 0;
            lblScore.Text = "Score: 0";

        }
        public void InitalizeGame()
        {
            HideMenu();

            //setup default position for ship
            int bottomScreen = 40;
            picSpaceship.Left = ClientSize.Width / 2 - picSpaceship.Width / 2;
            picSpaceship.Top = ClientSize.Height - picSpaceship.Height - bottomScreen;
            picSpaceship.Visible = true;

            //show game items

            lblScore.Visible = true;
            lblTimer.Visible = true;

            //enable level and lives label
            lblLevel.Visible = true;
            lblLives.Visible = true;


            //display level 1
            lblLevel.Text = $"Level: {level}";

            // Position game labels
            int bottomMargin = 10; // Space from the bottom of the screen
            int spacing = 100; // Spacing between labels

            lblScore.Left = 10;
            lblScore.Top = ClientSize.Height - lblScore.Height - bottomMargin;

            lblLives.Left = lblScore.Right + spacing;
            lblLives.Top = lblScore.Top;

            lblLevel.Left = lblLives.Right + spacing;
            lblLevel.Top = lblScore.Top;

            // Timer at the top center (without text, only numbers)
            lblTimer.Left = (ClientSize.Width - lblTimer.Width) / 2;
            lblTimer.Top = 15; // Adjust the value as needed
            lblTimer.Text = $"{levelTimer}"; // Only display the seconds

            //set game mode to game
            Gamestate = GameStates.Game;

            //enable timer
            tmrGame.Enabled = true;

            tmrTimer.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Gamestate == GameStates.Menu)
            {
                //In menu mode
                if (e.KeyCode == Keys.Return) //Check if the 'Enter' key is pressed 
                {
                    //initalize the game
                    InitalizeGame();

                }
                else if (e.KeyCode == Keys.D1) // Check if the '1' key is pressed
                {
                    // Set the text for the instructions label
                    SetInstructions();

                    //Hide menu items and game items
                    lblStart.Visible = false;
                    lblInstructions.Visible = false;
                    lblControls.Visible = false;
                    lblExit.Visible = false;
                    lblTitle.Visible = false;
                    picJupiter.Visible = false;
                    picPluto.Visible = false;
                    picSaturn.Visible = false;
                    picVenus.Visible = false;
                    picSpaceship.Visible = false;
                    lblScore.Visible = false;

                    lblTimer.Visible = false;


                    // Adjust size and position of the instructions panel
                    int margin = 65;
                    pnlInstructions.Width = ClientSize.Width - 2 * margin;
                    pnlInstructions.Height = ClientSize.Height - 2 * margin;
                    pnlInstructions.Left = (ClientSize.Width - pnlInstructions.Width) / 2;
                    pnlInstructions.Top = (ClientSize.Height - pnlInstructions.Height) / 2;

                    //show instructions panel
                    pnlInstructions.Visible = true;

                    //set gamestate to instructions
                    Gamestate = GameStates.Instructions;
                }

                else if (e.KeyCode == Keys.D2) // Check if the '2' key is pressed
                {
                    // Set the text for the controls label
                    SetControls();

                    // Hide menu items and game items
                    lblStart.Visible = false;
                    lblInstructions.Visible = false;
                    lblControls.Visible = false;
                    lblExit.Visible = false;
                    lblTitle.Visible = false;
                    picJupiter.Visible = false;
                    picPluto.Visible = false;
                    picSaturn.Visible = false;
                    picVenus.Visible = false;
                    picSpaceship.Visible = false;
                    lblScore.Visible = false;

                    lblTimer.Visible = false;


                    // Adjust size and position of the controls panel
                    int margin = 70;
                    pnlControls.Width = ClientSize.Width - 2 * margin;
                    pnlControls.Height = ClientSize.Height - 2 * margin;
                    pnlControls.Left = (ClientSize.Width - pnlControls.Width) / 2;
                    pnlControls.Top = (ClientSize.Height - pnlControls.Height) / 2;


                    // Show controls panel
                    pnlControls.Visible = true;

                    // Set the game state to controls
                    Gamestate = GameStates.Controls;
                }
                else if (e.KeyCode == Keys.Escape) // Check if the 'ESC' key is pressed
                {
                    // Exit the application
                    Application.Exit();
                }
            }
            else if (Gamestate == GameStates.Instructions && e.KeyCode == Keys.Back) // Check if the 'Backspace' key is pressed
            {

                // Go back to the menu
                ShowMenu();

                // Set the game state back to menu
                Gamestate = GameStates.Menu;
            }
            else if (Gamestate == GameStates.Controls && e.KeyCode == Keys.Back) // Check if the 'Backspace' key is pressed
            {

                // Go back to the menu
                ShowMenu();

                // Set the game state back to menu
                Gamestate = GameStates.Menu;
            }
            else if (e.KeyCode == Keys.Escape) // Check if the 'ESC' key is pressed in any game state
            {
                // Exit the application
                Application.Exit();
            }
            else if (Gamestate == GameStates.Game)
            {
                // Pause the game when 'P' is pressed
                if (e.KeyCode == Keys.P)
                {
                    PauseGame();
                }
                else
                {
                    //in game mode
                    if (e.KeyCode == Keys.Left)
                    {
                        moveLeft = true;
                    }
                    if (e.KeyCode == Keys.Right)
                    {
                        moveRight = true;
                    }
                    if (e.KeyCode == Keys.Up)
                    {
                        moveUp = true;
                    }
                    if (e.KeyCode == Keys.Down)
                    {
                        moveDown = true;
                    }
                }
            }
            else if (Gamestate == GameStates.Game && e.KeyCode == Keys.P) // Pause the game
            {
                PauseGame();
            }
            else if (Gamestate == GameStates.Pause)
            {
                if (e.KeyCode == Keys.Back) // Resume the game
                {
                    ResumeGame();
                }
                else if (e.KeyCode == Keys.R) // Restart the game
                {
                    RestartGame();
                }
            }
            else if (Gamestate == GameStates.Gameover)
            {
                if (e.KeyCode == Keys.R) // Restart
                {
                    RestartGame();
                }
                else if (e.KeyCode == Keys.Escape) // Exit
                {
                    Application.Exit();
                }

            }
            else if (Gamestate == GameStates.Gameover && e.KeyCode == Keys.Back) // Check if 'Backspace' is pressed
            {
                // Hide the game over panel
                pnlGameOver.Visible = false;

                // Go back to the menu
                ShowMenu();

                // Change the game state back to menu
                Gamestate = GameStates.Menu;
            }
        }

        private void PauseGame()
        {
            // Pause the game timers
            tmrGame.Enabled = false;
            tmrTimer.Enabled = false;


            // Display the pause panel
            pnlPause.Visible = true;

            // Adjust size and position of the controls panel
            int margin = 70;
            pnlPause.Width = ClientSize.Width - 2 * margin;
            pnlPause.Height = ClientSize.Height - 2 * margin;
            pnlPause.Left = (ClientSize.Width - pnlPause.Width) / 2;
            pnlPause.Top = (ClientSize.Height - pnlPause.Height) / 2;

            // Set up labels inside the pause panel
            lblPauseTitle.Text = "Game Paused";
            lblPauseResume.Text = "Press BACKSPACE to Resume";
            lblPauseRestart.Text = "Press R to Restart";
            lblPauseExit.Text = "Press ESC to Exit";

            // Adjust vertical spacing between labels
            int verticalMargin = 30;
            int moveLabelsDown = 20;

            // Calculate the starting Y position to vertically center labels inside the panel
            int startY = moveLabelsDown;
            int centerX = pnlPause.Width / 2;

            // Position the first label (title)
            lblPauseTitle.Left = centerX - (lblPauseTitle.Width / 2);
            lblPauseTitle.Top = startY;

            // Position the second label (resume)
            lblPauseResume.Left = centerX - (lblPauseResume.Width / 2);
            lblPauseResume.Top = lblPauseTitle.Top + lblPauseTitle.Height + verticalMargin;

            // Position the third label (restart)
            lblPauseRestart.Left = centerX - (lblPauseRestart.Width / 2);
            lblPauseRestart.Top = lblPauseResume.Top + lblPauseResume.Height + verticalMargin;

            // Position the fourth label (exit)
            lblPauseExit.Left = centerX - (lblPauseExit.Width / 2);
            lblPauseExit.Top = lblPauseRestart.Top + lblPauseRestart.Height + verticalMargin;

            // Make all labels visible within the pause panel
            lblPauseTitle.Visible = true;
            lblPauseResume.Visible = true;
            lblPauseRestart.Visible = true;
            lblPauseExit.Visible = true;


            // Change the game state
            Gamestate = GameStates.Pause;
        }

        private void ResumeGame()
        {
            // Hide the pause panel
            pnlPause.Visible = false;

            // Resume the game timers
            tmrGame.Enabled = true;
            tmrTimer.Enabled = true;

            // Change the game state back to Game
            Gamestate = GameStates.Game;
        }

        private void RestartGame()
        {
            // Reset game variables to their initial values
            score = 0;
            level = 1;
            lives = 0;  // Ensure lives is properly reset to 3
            baseAsteroidSpeed = 3;
            levelTimer = 10;

            // Reset movement flags
            moveLeft = false;
            moveRight = false;
            moveUp = false;
            moveDown = false;

            // Update UI labels with the reset values
            lblScore.Text = $"Score: {score}";
            lblLives.Text = $"Lives: {lives}";
            lblLevel.Text = $"Level: {level}";

            // Make sure the labels are visible
            lblScore.Visible = true;
            lblLives.Visible = true;
            lblLevel.Visible = true;
            lblTimer.Visible = true;

            // Hide the pause panel and the game over panel
            pnlPause.Visible = false;
            pnlGameOver.Visible = false;

            // Remove all current game elements (asteroids, stars, hearts, explosions)
            for (int i = 0; i < asteroids.Count; i++)
            {
                Controls.Remove(asteroids[i]);
            }
            asteroids.Clear();

            for (int i = 0; i < stars.Count; i++)
            {
                Controls.Remove(stars[i]);
            }
            stars.Clear();

            for (int i = 0; i < hearts.Count; i++)
            {
                Controls.Remove(hearts[i]);
            }
            hearts.Clear();

            // Reset the spaceship position and make it visible
            picSpaceship.Left = ClientSize.Width / 2 - picSpaceship.Width / 2;
            picSpaceship.Top = ClientSize.Height - picSpaceship.Height - 40; // Adjust as needed
            picSpaceship.Visible = true;

            // Reset the game state to "Game"
            Gamestate = GameStates.Game;

            // Enable the game timers again
            tmrGame.Enabled = true;
            tmrTimer.Enabled = true;
        
    
    }
            private void GameOver()
        {
            // Stop any timers
            tmrGame.Enabled = false;
            tmrTimer.Enabled = false;

            // Hide all game elements
            lblScore.Visible = false;
            lblLives.Visible = false;
            lblLevel.Visible = false;
            lblTimer.Visible = false;
            picSpaceship.Visible = false;
            pnlPause.Visible = false;
            pnlControls.Visible = false;
            pnlInstructions.Visible = false;

            // Remove asteroids from Controls
            for (int i = 0; i < asteroids.Count; i++)
            {
                Controls.Remove(asteroids[i]);
            }
            asteroids.Clear();

            // Remove stars from Controls
            for (int i = 0; i < stars.Count; i++)
            {
                Controls.Remove(stars[i]);
            }
            stars.Clear();

            // Remove hearts from Controls
            for (int i = 0; i < hearts.Count; i++)
            {
                Controls.Remove(hearts[i]);
            }
            hearts.Clear();


            // Update the score and level labels
            lblFinalScore.Text = $"Score: {score}";  // Update with current score
            lblFinalLevel.Text = $"Level: {level}";  // Update with current level
                                                     
            // Position lblFinalScore in the center of the panel
            lblFinalScore.Left = (pnlGameOver.Width / 2) - (lblFinalScore.Width / 2);
            lblFinalScore.Top = (pnlGameOver.Height / 2) - (lblFinalScore.Height / 2 - 200); // Slight adjustment for visual balance

            // Position lblFinalLevel in the center of the panel, below lblFinalScore
            lblFinalLevel.Left = (pnlGameOver.Width / 2) - (lblFinalLevel.Width / 2);
            lblFinalLevel.Top = lblFinalScore.Top + lblFinalScore.Height ; // 20px spacing below lblFinalScore


            // Make the labels visible
            lblFinalScore.Visible = true;
            lblFinalLevel.Visible = true;


            // Configure and show the "Game Over" panel
            int verticalMargin = 30;
            int moveLabelsDown = 50;

            // Set the panel size
            pnlGameOver.Width = ClientSize.Width - 50;
            pnlGameOver.Height = ClientSize.Height - 50;
            pnlGameOver.Left = (ClientSize.Width - pnlGameOver.Width) / 2;
            pnlGameOver.Top = (ClientSize.Height - pnlGameOver.Height) / 2;
            pnlGameOver.Visible = true;

            // Set up the "Game Over" label
            lblGameOverTitle.Text = "Game Over!";
            lblGameOverRestart.Text = "Press R to Restart";
            lblGameOverExit.Text = "Press ESC to Exit";
            

            // Position the labels
            int startY = moveLabelsDown;
            int centerX = pnlGameOver.Width / 2;

            lblGameOverTitle.Left = centerX - (lblGameOverTitle.Width / 2);
            lblGameOverTitle.Top = startY;

            lblGameOverRestart.Left = centerX - (lblGameOverRestart.Width / 2);
            lblGameOverRestart.Top = lblGameOverTitle.Top + lblGameOverTitle.Height + verticalMargin;

            lblGameOverExit.Left = centerX - (lblGameOverExit.Width / 2);
            lblGameOverExit.Top = lblGameOverRestart.Top + lblGameOverRestart.Height + verticalMargin;

            

            // Make all labels in the panel visible
            lblGameOverTitle.Visible = true;
            lblGameOverRestart.Visible = true;
            lblGameOverExit.Visible = true;
            

            // Change the game state
            Gamestate = GameStates.Gameover;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Gamestate == GameStates.Game)
            {
                //in game mode
                if (e.KeyCode == Keys.Left)
                {
                    moveLeft = false;
                }
                if (e.KeyCode == Keys.Right)
                {
                    moveRight = false;
                }
                if (e.KeyCode == Keys.Up)
                {
                    moveUp = false;
                }
                if (e.KeyCode == Keys.Down)
                {
                    moveDown = false;
                }
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {

            //asteroids
            SpawnAsteroids();
            MoveAsteroids();

            //stars
            SpawnStars();
            MoveStars();

            //hearts
            SpawnHeart();
            MoveHearts();

            //move the ship
            // Horizontally comes out the other side
            if (moveLeft)
            {
                picSpaceship.Left -= spaceshipSpeed;
                if (picSpaceship.Right < 0)
                {
                    picSpaceship.Left = ClientSize.Width;
                }
            }
            if (moveRight)
            {
                picSpaceship.Left += spaceshipSpeed;
                if (picSpaceship.Left > ClientSize.Width)
                {
                    picSpaceship.Left = -picSpaceship.Width;
                }
            }

            // Vertical boundaries
            if (moveUp && picSpaceship.Top > 0) // Prevent it from going above the screen
            {
                picSpaceship.Top -= spaceshipSpeed;
            }
            if (moveDown && picSpaceship.Bottom < ClientSize.Height) // Prevent it from going below the screen
            {
                picSpaceship.Top += spaceshipSpeed;
            }

           ;

            // Update the score as the player survives
            score++;
            lblScore.Text = $"Score: {score}";
        }

        private void IncreaseLevel()
        {
            level++;
            levelTimer = 10; // Reset timer
            lblLevel.Text = $"Level: {level}";



            // Make it noticeable (increase difficulty)
            IncreaseDifficulty();

        }

        private void IncreaseDifficulty()
        {
            baseAsteroidSpeed += 2; // Increase base speed for new asteroids

            for (int i = 0; i < asteroids.Count; i++)
            {
                asteroids[i].Speed += 2; // Increase speed of existing asteroids
            }

            // Increase spawn rate slightly
            if (random.Next(0, 100) < 20)
            {
                SpawnAsteroids();
            }
        }
        private void MoveAsteroids()
        {
            for (int i = asteroids.Count - 1; i >= 0; i--)
            {
                Asteroid asteroid = asteroids[i];
                asteroid.MoveTick();

                // Check for collision with spaceship
                if (asteroid.Bounds.IntersectsWith(picSpaceship.Bounds))
                {
                    //show explosion effect
                    ShowExplosion(asteroid.Left, asteroid.Top, asteroid.Width, asteroid.Height);

                    //remove the asteroid
                    Controls.Remove(asteroid);
                    asteroids.Remove(asteroid);

                    // Reduce lives
                    lives--;
                    lblLives.Text = $"Lives: {lives}";

                    if (lives < 0) // Game over only when lives run out
                    {
                        GameOver();
                        break;
                    }
                    break;

                }

                // Remove asteroids that are off the screen
                if (asteroid.Top > ClientSize.Height)
                {
                    Controls.Remove(asteroid);
                    asteroids.Remove(asteroid);
                }
            }

        }

        private void ShowExplosion(int x, int y, int Width, int Height)
        {
            PictureBox explosion = new PictureBox();
            explosion.Image = Resources.Explosion;
            explosion.SizeMode = PictureBoxSizeMode.StretchImage;

            // Make explosion larger than asteroid
            explosion.Width = Width + 200;
            explosion.Height = Height + 100;

            // Center explosion on asteroid
            explosion.Left = x + (Width / 2) - (explosion.Width / 2);
            explosion.Top = y + (Height / 2) - (explosion.Height / 2);

            Controls.Add(explosion);
            explosions.Add(explosion);

            //enable timer
            tmrExplosion.Enabled = true;
        }
        private void SpawnAsteroids()
        {
            int maxAsteroids = 10;

            if (asteroids.Count < maxAsteroids && random.Next(0, 100) < 15)
            {
                int startX = random.Next(0, ClientSize.Width - 50);
                int size = 50;
                double speed = baseAsteroidSpeed + random.Next(0, 5);
                Asteroid newAsteroid = new Asteroid(startX, size, speed);
                asteroids.Add(newAsteroid);
                Controls.Add(newAsteroid);
            }
        }

        private void SetInstructions()
        {
            lblInsText.Text = 
               
                "INSTRUCTIONS:\n\n" +
"- Avoid falling asteroids and survive as long as possible.\n" +
"- Every 10 seconds, asteroids will fall faster, increasing the level.\n" +
"- Your score increases over time—aim for a high score!\n" +
"- Catch shining stars to double your score (2x multiplier).\n" +
"- A rare red heart may appear for 3 seconds—grab it to\n gain an extra life!\n" +
"- Your spaceship can wrap around the screen horizontally.\n\n" +
"Press 'Backspace' to return to the menu.";
        }
        private void SetControls()
        {
            lblConText.Text = "CONTROLS:\n\n" +
"- Arrow keys (↑, ↓, ←, →): Move your spaceship.\n" +
"- Press 'P' to pause the game.\n" +
"- Press 'Esc' to exit the game.\n\n" +

"Master these controls and become a Galaxy Guardian!\n" +
"Press 'Backspace' to return to the menu.";
        }

        private void SpawnStars()
        {
            if (stars.Count == 0 && random.Next(0, 1000) < 5)
            {
                int startX = random.Next(0, ClientSize.Width - 30);
                int size = 30;
                double speed = random.Next(3, 8);

                //create star in memory
                Star newStar = new Star(startX, size, speed);


                stars.Add(newStar);
                Controls.Add(newStar);
            }
        }


        private void MoveStars()
        {
            for (int i = stars.Count - 1; i >= 0; i--)
            {
                Star star = stars[i];
                star.MoveTick();

                // Check for collision with spaceship
                if (star.Bounds.IntersectsWith(picSpaceship.Bounds))
                {
                    score *= 2; // Double the score
                    lblScore.Text = $"Score: {score}";

                    // Remove the star
                    Controls.Remove(star);
                    stars.RemoveAt(i);


                    // Remove asteroids that are off the screen
                    if (star.Top > ClientSize.Height)
                    {
                        Controls.Remove(star);
                        stars.Remove(star);
                    }


                }
            }
        }

        private void tmrExplosion_Tick(object sender, EventArgs e)
        {
            if (explosions.Count > 0)
            {
                Controls.Remove(explosions[0]); // Remove from form
                explosions[0].Visible = false; // Hide instead of disposing
                explosions.Remove(explosions[0]); // Remove from the list
            }

            if (explosions.Count == 0)
            {
                //stop timer if no explosions left
                tmrExplosion.Enabled = false;
            }
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            // Update the level timer
            levelTimer--;
            lblTimer.Text = $"{levelTimer}";

            if (levelTimer <= 0)
            {
                IncreaseLevel();
            }
        }
        private void SpawnHeart()
        {
            if (hearts.Count == 0 && random.Next(0, 3000) < 5) // Extremely rare chance
            {
                int startX = random.Next(0, ClientSize.Width - 30);
                int size = 30;
                double speed = 2; // Slow speed

                Heart newHeart = new Heart(startX, size, speed);
                hearts.Add(newHeart);
                Controls.Add(newHeart);
                
                //enable heart timer
                tmrHeart.Enabled = true;    
            }
        }

        private void MoveHearts()
        {
            for (int i = hearts.Count - 1; i >= 0; i--)
            {
                Heart heart = hearts[i];
                heart.MoveTick();

                if (heart.Bounds.IntersectsWith(picSpaceship.Bounds))
                {
                    lives++; // Add one life
                    lblLives.Text = $"Lives: {lives}";

                    Controls.Remove(heart);
                    hearts.Remove(heart);
                    
                    //disable timer since heart is collected
                    tmrHeart.Enabled= false;
                    break;
                }
            }
        }

        private void tmrHeart_Tick(object sender, EventArgs e)
        {
            if (hearts.Count > 0)
            {
                Controls.Remove(hearts[0]); // Remove from form
                hearts[0].Visible = false;  // Hide instead of disposing
                hearts.Remove(hearts[0]);   // Remove from the list
            }

            if (hearts.Count == 0)
            {
                // Stop the timer if no hearts left
                tmrHeart.Enabled = false;
            }
        }

        
    }
}
             
          
        
        
    
