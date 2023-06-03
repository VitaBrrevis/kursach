using System;
using System.Collections.Generic;
using System.Linq;
using Tetris.Game.Results;
using Tetris.Game.Tetriminoes;

namespace Tetris.Game
{

    /// <summary>
    /// This class handels tetromino related operations
    /// </summary>
    internal class TetrominoHandler
    {

        #region Private Variables

        /// <summary>
        /// Game current tetromino
        /// </summary>
        private Tetromino current;
        /// <summary>
        /// Level2 score
        /// </summary>
        private int NextLvl = 10000;
        /// <summary>
        /// Game next tetrominoes
        /// </summary>
        private Queue<Tetromino> next;

        /// <summary>
        /// Game deck
        /// </summary>
        private readonly Deck deck;

        /// <summary>
        /// Ghost blocks of the game
        /// </summary>
        private Block[] ghostBlocks;

        /// <summary>
        /// Indicates whether hold is possible
        /// </summary>
        private bool holdIsPossible;

        /// <summary>
        /// The held tetromino
        /// </summary>
        private Tetromino held;

        /// <summary>
        /// tetromino generator based on 7 bag algorithm
        /// </summary>
        private readonly Tetrominos7BagRandomizer tetrominos7Bag;
        private readonly Tetrominos18BagRandomizer tetrominos18Bag;

        /// <summary>
        /// number of tetrominoes in queue for preview box
        /// </summary>
        private readonly int nextTetrominoesQueueLenght = 1;
     

        #endregion

        #region Private Methods

        /// <summary>
        /// Generates a new tetromino
        /// </summary>
        private Tetromino GenerateNewTetromino(string Difficulty)
        {
            if ( Difficulty == "Easy")
            {

                return tetrominos7Bag.GetNewTetromino();
            }
            else
            {
                
                return tetrominos18Bag.GetNewTetromino();
            }
        }

        /// <summary>
        /// Calculates the ghost block for current tetromino
        /// </summary>

        private void CalculateGhostBlock(ChangeResult moveResult)
        {
            if (moveResult == null || !GhostBlocksActiveStatus) return;
            var changedGhostBlocks = new List<Block>();
            foreach (var ghostBlock in ghostBlocks)
            {
                changedGhostBlocks.Add(new Block(ghostBlock, BlockStatus.Hidden));
            }
            ghostBlocks = deck.GetGhostBlocks(current.VisibleBlocks);
            changedGhostBlocks.AddRange(ghostBlocks);
            moveResult.GhostBlocks = changedGhostBlocks.ToArray();
        }

        /// <summary>
        /// Sets the last move value in the result
        /// </summary>

        private void SetLastMove(ChangeResult moveResult)
        {
            if (moveResult == null) return;

            moveResult.LastMove = !current.CanMoveDown();
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Creates a new instance of the class
        /// </summary>

        public TetrominoHandler(Deck deck)
        {
            this.deck = deck;
           
            tetrominos7Bag = new Tetrominos7BagRandomizer(deck);
            tetrominos18Bag = new Tetrominos18BagRandomizer(deck);

            next = new Queue<Tetromino>(nextTetrominoesQueueLenght);
            holdIsPossible = true;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Indicates whether ghost blocks are active
        /// </summary>
        public bool GhostBlocksActiveStatus { get; private set; } = true;

        #endregion

        #region Public Methods

        /// <summary>
        /// Initizes the tetromino handler. This is called once at the beginning of every game
        /// </summary>

        public TetrominoInitializationResult Initialize(ScoreManagement scoreManagement, string Difficulty)
        {
            current = GenerateNewTetromino(Difficulty);
            for (var i = 0; i < nextTetrominoesQueueLenght; i++)
            {
                next.Enqueue(GenerateNewTetromino(Difficulty));
            }
            ghostBlocks = deck.GetGhostBlocks(current.VisibleBlocks);

            return new TetrominoInitializationResult
            {
                ChangedBlocks = current.VisibleBlocks,
                NextTetrominoes = next.Select(s => s.BaseBlocks).ToList(),
                GhostBlocks = ghostBlocks
            };
        }

        /// <summary>
        /// Moves the current tetromino to right
        /// </summary>

        public ChangeResult MoveRight()
        {
            var moveResult = current.MoveRight();
            SetLastMove(moveResult);
            CalculateGhostBlock(moveResult);
            return moveResult;
        }

        /// <summary>
        /// Moves the current tetromino to down
        /// </summary>

        public MoveDownResult MoveDown(string Difficulty)
        {
            var moveDownResult = current.MoveDown();

            if (moveDownResult.GameOver || moveDownResult.ChangedBlocks != null)
            {
                SetLastMove(moveDownResult);
                return moveDownResult;
            }

            current = next.Dequeue();
            next.Enqueue(GenerateNewTetromino(Difficulty));

            moveDownResult.ChangedBlocks = current.VisibleBlocks;

            moveDownResult.NextTetrominoes = next.Select(s => s.BaseBlocks).ToList();
            CalculateGhostBlock(moveDownResult);
            holdIsPossible = true;
            SetLastMove(moveDownResult);
            return moveDownResult;
        }

        /// <summary>
        /// Moves the current tetromino to left
        /// </summary>

        public ChangeResult MoveLeft()
        {
            var moveResult = current.MoveLeft();
            SetLastMove(moveResult);
            CalculateGhostBlock(moveResult);
            return moveResult;
        }

        /// <summary>
        /// Rotates the current tetromino
        /// </summary>

        public ChangeResult[] Rotate()
        {
            var rotateResult = current.Rotate();
            if (rotateResult.Length != 0)
            {
                CalculateGhostBlock(rotateResult.Last());
                SetLastMove(rotateResult.Last());
            }
            return rotateResult;
        }

        /// <summary>
        /// Activates the ghost blocks
        /// </summary>

        public ChangeResult ActiveGhostBlocks()
        {
            GhostBlocksActiveStatus = true;
            ghostBlocks = deck.GetGhostBlocks(current.VisibleBlocks);
            return new ChangeResult { ChangedBlocks = ghostBlocks };
        }

        /// <summary>
        /// Deactivates the ghost blocks
        /// </summary>

        public ChangeResult DeactiveGhostBlocks()
        {
            GhostBlocksActiveStatus = false;
            var hiddenGhostBlocks = new List<Block>();
            foreach (var item in ghostBlocks)
            {
                hiddenGhostBlocks.Add(new Block(item, BlockStatus.Hidden));
            }
            return new ChangeResult { ChangedBlocks = hiddenGhostBlocks.ToArray() };
        }

        /// <summary>
        /// Holds the current tetromino and replaces the current tetromino with the held tetromino
        /// </summary>

        public HoldResult Hold(ScoreManagement scoreManager)
        {
            if (!holdIsPossible)
            {
                return null;
            }

            var changedBlocks = new List<Block>();

            foreach (var item in current.VisibleBlocks)
            {
                changedBlocks.Add(new Block(item, BlockStatus.Hidden));
            }

            var holdResult = new HoldResult();

            if (held == null)
            {
                held = current;
                current = next.Dequeue();

                next.Enqueue(held);
             
                holdResult.NextTetrominoes = next.Select(s => s.BaseBlocks).ToList();
            }
            else
            {
                var tempTetro = held;
                held = current;
                current = tempTetro;
            }

            held.ResetToTopMiddle();

            foreach (var item in current.VisibleBlocks)
            {
                changedBlocks.Add(new Block(item));
            }

            holdResult.HoldBlocks = held.BaseBlocks;
            holdResult.ChangedBlocks = changedBlocks.ToArray();
            CalculateGhostBlock(holdResult);
            SetLastMove(holdResult);
            holdIsPossible = false;


            held = null;
            return holdResult;
        }


        #endregion

    }
}
