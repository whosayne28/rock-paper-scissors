using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{

    /// <summary>
    /// Represents main application window.
    /// </summary>
    public partial class MainWindow : Form
    {

        /// <summary>
        /// Stores current game stage.
        /// </summary>
        private GameStage Stage;

        /// <summary>
        /// Stores human move.
        /// </summary>
        private MoveVariation HumanMove;

        /// <summary>
        /// Stores random numbers generator.
        /// </summary>
        private Random Random;

        /// <summary>
        /// Stores human scores.
        /// </summary>
        private int HumanScores;

        /// <summary>
        /// Stores computer scores.
        /// </summary>
        private int ComputerScores;

        /// <summary>
        /// Creates main application window.
        /// </summary>
        public MainWindow()
        {
            // Initialize Windows form
            InitializeComponent();
            // Set game stage
            this.Stage = GameStage.BeforeStart;
            // Create random numbers source
            this.Random = new Random();
            // Set scores to `0`
            this.HumanScores = 0;
            this.ComputerScores = 0;
        }

        /// <summary>
        /// Main application window calls this method when user clicks `Start` button.
        /// </summary>
        /// <param name="sender">Object that caused this event.</param>
        /// <param name="e">Event related data.</param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            switch(this.Stage)
            {
                case GameStage.BeforeStart:
                case GameStage.Finished:
                    this.StartGame();
                    break;
                case GameStage.HumanMove:
                    this.PerformHumanMove();
                    break;
                case GameStage.ComputerMove:
                default:
                    throw new Exception(Properties.Resources.StartButtonInvalidFormState);
            }
        }

        /// <summary>
        /// Performs human move.
        /// </summary>
        private void PerformHumanMove()
        {
            if (this.HumanMove == MoveVariation.Unknown)
                MessageBox.Show(Properties.Resources.BadHumanMove, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.HumanChoise.Cursor = Cursors.Default;
                this.Stage = GameStage.ComputerMove;
                this.PerformComputerMove();
            }
        }

        /// <summary>
        /// Performs computer move.
        /// </summary>
        private void PerformComputerMove()
        {
            var computerMove = this.GetRandomMove();
            this.DrawComputerMove(computerMove);
            if (computerMove == this.HumanMove)
                MessageBox.Show(Properties.Resources.ResultDraw, Properties.Resources.GameOver, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (this.IsHumanVictory(computerMove))
            {
                MessageBox.Show(Properties.Resources.ResultHumanVictory, Properties.Resources.GameOver, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ++this.HumanScores;
                this.HumanScoresField.Text = String.Format(Properties.Resources.YourScoresFormat, this.HumanScores);
            }
            else
            {
                MessageBox.Show(Properties.Resources.ResultComputerVictory, Properties.Resources.GameOver, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ++this.ComputerScores;
                this.ComputerScoresField.Text = String.Format(Properties.Resources.ComputerScoresFormat, this.ComputerScores);
            }
            this.Stage = GameStage.Finished;
            this.StartButton.Text = Properties.Resources.PlayAgain;
            this.MessageText.Text = Properties.Resources.PressPlayAgain;
        }

        private bool IsHumanVictory(MoveVariation computerMove)
        {
            if (this.HumanMove == MoveVariation.Rock && computerMove == MoveVariation.Scissors)
                return true;
            else if (this.HumanMove == MoveVariation.Scissors && computerMove == MoveVariation.Rock)
                return false;
            else
                return (int)this.HumanMove > (int)computerMove;
        }

        /// <summary>
        /// Draws computer move.
        /// </summary>
        /// <param name="computerMove"></param>
        private void DrawComputerMove(MoveVariation computerMove)
        {
            switch (computerMove)
            {
                case MoveVariation.Rock:
                    this.ComputerChoice.Image = Properties.Resources.RightRock;
                    break;
                case MoveVariation.Paper:
                    this.ComputerChoice.Image = Properties.Resources.RightPaper;
                    break;
                case MoveVariation.Scissors:
                    this.ComputerChoice.Image = Properties.Resources.RightScissors;
                    break;
                default:
                    throw new Exception(Properties.Resources.InvalidComputerMove);
            }
        }

        /// <summary>
        /// Starts new game.
        /// </summary>
        private void StartGame()
        {
            this.MessageText.Text = Properties.Resources.SelectImageText;
            this.StartButton.Text = Properties.Resources.MoveButtonText;
            this.HumanChoise.Cursor = Cursors.Hand;
            this.HumanChoise.Image = Properties.Resources.Unknown;
            this.HumanMove = MoveVariation.Unknown;
            this.ComputerChoice.Image = Properties.Resources.Unknown;
            this.Stage = GameStage.HumanMove;
        }

        /// <summary>
        /// This object calls this method when user clicks 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HumanChoise_Click(object sender, EventArgs e)
        {
            switch (this.Stage)
            {
                case GameStage.HumanMove:
                    {
                        int currentMove = (int)this.HumanMove;
                        ++currentMove;
                        if (currentMove >= (int)MoveVariation.Unknown)
                            currentMove = (int)MoveVariation.Rock;
                        this.HumanMove = (MoveVariation)currentMove;
                        this.DrawHumanMove();
                    }
                    break;
                case GameStage.BeforeStart:
                case GameStage.Finished:
                case GameStage.ComputerMove:
                default:
                    break;
            }
        }

        /// <summary>
        /// Draws human move.
        /// </summary>
        private void DrawHumanMove()
        {
            switch(this.HumanMove)
            {
                case MoveVariation.Rock:
                    this.HumanChoise.Image = Properties.Resources.LeftRock;
                    break;
                case MoveVariation.Paper:
                    this.HumanChoise.Image = Properties.Resources.LeftPaper;
                    break;
                case MoveVariation.Scissors:
                    this.HumanChoise.Image = Properties.Resources.LeftScissors;
                    break;
                default:
                    throw new Exception(Properties.Resources.InvalidHumanMove);
            }
        }

        /// <summary>
        /// Gets random move.
        /// </summary>
        /// <returns>Random move.</returns>
        private MoveVariation GetRandomMove()
        {
            return (MoveVariation)this.Random.Next(0, 3);
        }
    }
}
