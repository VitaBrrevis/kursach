using System;
using System.Collections.Generic;
using Tetris.Game.Tetriminoes;

namespace Tetris.Game
{

    /// <summary>
    /// This class is responsible for tetrominos randomization based on 18 bag algorithm
    /// </summary>
    internal class Tetrominos18BagRandomizer
    {


        #region Private Variables

        /// <summary>
        /// Current bag tetrominoes
        /// </summary>
        private readonly List<Tetromino> tetrominoesBag = new List<Tetromino>(18);

        /// <summary>
        /// Random generator for selecting tetromino from bag
        /// </summary>
        private readonly Random randomGenerator = new Random();

        /// <summary>
        /// Game deck
        /// </summary>
        private readonly Deck deck;

        #endregion

        #region Private Methods

        /// <summary>
        /// Fills the bag with all 18 tetrominoes
        /// </summary>
        private void FillBag()
        {
            tetrominoesBag.Add(new DRTetrominoExtra(deck));
            tetrominoesBag.Add(new DTetrominoExtra(deck));
            tetrominoesBag.Add(new ITetrominoExtra(deck));
            tetrominoesBag.Add(new JTetrominoExtra(deck));
            tetrominoesBag.Add(new KTetrominoExtra(deck));
            tetrominoesBag.Add(new LLTetrominoExtra(deck));
            tetrominoesBag.Add(new PRTetrominoExtra(deck));
            tetrominoesBag.Add(new RTetrominoExtra(deck));
            tetrominoesBag.Add(new QRTetrominoExtra(deck));
            tetrominoesBag.Add(new QTetrominoExtra(deck));
            tetrominoesBag.Add(new RRTetrominoExtra(deck));
            tetrominoesBag.Add(new RTetrominoExtra(deck));
            tetrominoesBag.Add(new STetrominoExtra(deck));
            tetrominoesBag.Add(new TTetrominoExtra(deck));
            tetrominoesBag.Add(new UTetrominoExtra(deck));
            tetrominoesBag.Add(new ZRTetrominoExtra(deck));
            tetrominoesBag.Add(new ZTetrominoExtra(deck));
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Creates a new instance of Tetrominos18BagRandomizer class 
        /// </summary>
        public Tetrominos18BagRandomizer(Deck deck)
        {
            this.deck = deck;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Picks a random tetromino from the bag, if bag is empty, fills the bag.
        /// </summary>

        public Tetromino GetNewTetromino()
        {
            if (tetrominoesBag.Count == 0)
            {
                FillBag();
            }
            var number = randomGenerator.Next(tetrominoesBag.Count);
            var tetromino = tetrominoesBag[number];
            tetrominoesBag.RemoveAt(number);
            return tetromino;
        }

        #endregion

    }
}