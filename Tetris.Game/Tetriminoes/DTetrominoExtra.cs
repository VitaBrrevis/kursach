namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino D class. d tetromino is a 3*3 matrix
    /// </summary>
    internal class DTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public DTetrominoExtra(Deck deck) : base(deck, 3) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for PReverse shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
             'D' 'D' '6'
             '1' 'D' '7'
             '2' 'D' 'D'
            */

            Blocks[0].Status = BlockStatus.Magenta;
            Blocks[3].Status = BlockStatus.Magenta;
            Blocks[4].Status = BlockStatus.Magenta;
            Blocks[5].Status = BlockStatus.Magenta;
            Blocks[8].Status = BlockStatus.Magenta;
        }

        #endregion

    }
}
