namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino RReverse class. Rreverse tetromino is a 3*3 matrix
    /// </summary>
    internal class RRTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public RRTetrominoExtra(Deck deck) : base(deck, 3) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for P shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
             '0' 'R' 'R'
             '1' 'R' 'R'
             '2' 'R' '8'
            */

            
            Blocks[3].Status = BlockStatus.DarkSeaGreen;
            Blocks[4].Status = BlockStatus.DarkSeaGreen;
            Blocks[5].Status = BlockStatus.DarkSeaGreen;
            Blocks[6].Status = BlockStatus.DarkSeaGreen;
            Blocks[7].Status = BlockStatus.DarkSeaGreen;

        }

        #endregion

    }
}
