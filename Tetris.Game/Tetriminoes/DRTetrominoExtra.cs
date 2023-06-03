namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino DReverse class. DReverse tetromino is a 3*3 matrix
    /// </summary>
    internal class DRTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public DRTetrominoExtra(Deck deck) : base(deck, 3) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for PReverse shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /* 
             '0' 'D' 'D'
             '1' 'D' '7'
             'D' 'D' '8'
            */

            Blocks[2].Status = BlockStatus.PaleVioletRed;
            Blocks[3].Status = BlockStatus.PaleVioletRed;
            Blocks[4].Status = BlockStatus.PaleVioletRed;
            Blocks[5].Status = BlockStatus.PaleVioletRed;
            Blocks[6].Status = BlockStatus.PaleVioletRed;
        }

        #endregion

    }
}
