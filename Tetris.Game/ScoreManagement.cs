using System.Collections.Generic;

namespace Tetris.Game
{

    /// <summary>
    /// This class is responsible for management of scores and lines in tetris game
    /// </summary>
    internal class ScoreManagement
    {

        #region Private Constants

        private const int firstLevelLinesCount = 20;
        private const int levelsLinesIncreaseAmount = 5;
        private const int hardDropScorePlus = 100;

        #endregion

        #region Private Variables

        private int currentLevelLines;
        private int currentLevelLineTop = firstLevelLinesCount;
        private readonly Dictionary<int, int> linesScores = new Dictionary<int, int>() { { 1, 100 }, { 2, 300 }, { 3, 700 }, { 4, 1500 } };

        #endregion

        #region Private Methods

        /// <summary>
        /// Checks for level upgrad after line vanish opration
        /// </summary>
     
        private Level CheckForLevelUpgrade(int lines, Level level, int score)
        {
            currentLevelLines += lines;
            //score += linesScores[lines] * level;
            if (score >= 10000)
            {
                return ((Level)(level + 1));
            }
            else if (level != Level.One && currentLevelLines >= currentLevelLineTop)
            {
                currentLevelLines = 0;
                currentLevelLineTop += levelsLinesIncreaseAmount;
                return ((Level)(level + 1));
            }
            return ((Level)level);
        }


        #endregion

        #region Public Properties

        /// <summary>
        /// Game score
        /// </summary>
        public int Score { get; private set; }

        /// <summary>
        /// Game vanished lines
        /// </summary>
        public int Lines { get; private set; }

        #endregion

        #region Public Methods
        public ScoreManagement()
        {
            Score = 0; // Устанавливаем начальное значение Score равным 0
        }

        /// <summary>
        /// Updates game score after line vanish operation
        /// </summary>

        public Level UpdateScores(int lines, Level level, bool hardDrop)
        {
            int lineScore = linesScores[lines] * (int)level;


            if (hardDrop)
            {
                lineScore += hardDropScorePlus;
            }
            Score += lineScore * (int)level;
            Lines += lines;
            var result = CheckForLevelUpgrade(lines, level, Score);
            return result;
        }

        #endregion

    }
}
