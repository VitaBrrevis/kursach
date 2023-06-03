namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino PReverse class. PReverse tetromino is a 3*3 matrix
    /// </summary>
    internal class PRTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public PRTetrominoExtra(Deck deck) : base(deck, 3) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for PReverse shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
             'P' 'P' '6'
             '1' 'P' 'P'
             '2' 'P' '8'
            */

            Blocks[0].Status = BlockStatus.Tan;
            Blocks[3].Status = BlockStatus.Tan;
            Blocks[4].Status = BlockStatus.Tan;
            Blocks[5].Status = BlockStatus.Tan;
            Blocks[7].Status = BlockStatus.Tan;
        }

        #endregion

    }
}
