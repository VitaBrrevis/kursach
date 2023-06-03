namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino P class. P tetromino is a 3*3 matrix
    /// </summary>
    internal class PTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public PTetrominoExtra(Deck deck) : base(deck, 3) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for P shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
             '0' 'P' 'P'
             'P' 'P' '7'
             '2' 'P' '8'
            */

            Blocks[1].Status = BlockStatus.Tan;
            Blocks[3].Status = BlockStatus.Tan;
            Blocks[4].Status = BlockStatus.Tan;
            Blocks[5].Status = BlockStatus.Tan;
            Blocks[6].Status = BlockStatus.Tan;
        }

        #endregion

    }
}
