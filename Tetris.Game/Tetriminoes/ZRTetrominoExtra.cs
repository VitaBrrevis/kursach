namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino ZReverse class. ZReverse tetromino is a 4*4 matrix 
    /// </summary>
    internal class ZRTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public ZRTetrominoExtra(Deck deck) : base(deck, 4) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for L shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
              '0' 'Z' '8' '12'
              '1' 'Z' '9' '13'
              '2' 'Z' 'Z' '14'
              '3' '7' 'Z' '15'
            */
           
            Blocks[4].Status = BlockStatus.PaleGreen;
            Blocks[5].Status = BlockStatus.PaleGreen;
            Blocks[6].Status = BlockStatus.PaleGreen;
            Blocks[10].Status = BlockStatus.PaleGreen;
            Blocks[11].Status = BlockStatus.PaleGreen;

        }

        #endregion

    }
}
