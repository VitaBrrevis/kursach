namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino Z class. Z tetromino is a 4*4 matrix 
    /// </summary>
    internal class ZTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public ZTetrominoExtra(Deck deck) : base(deck, 4) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for L shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
              '0' 'L' '8' '12'
              '1' 'Z' '9' '13'
              'Z' 'Z' '10' '14'
              'Z' '7' '11'  '15'
            */
            Blocks[2].Status = BlockStatus.PaleGreen;
            Blocks[3].Status = BlockStatus.PaleGreen;
            Blocks[4].Status = BlockStatus.PaleGreen;
            Blocks[5].Status = BlockStatus.PaleGreen;
            Blocks[6].Status = BlockStatus.PaleGreen;
        
        }

        #endregion

    }
}
