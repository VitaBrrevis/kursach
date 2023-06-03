namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino R class. R tetromino is a 3*3 matrix
    /// </summary>
    internal class RTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public RTetrominoExtra(Deck deck) : base(deck, 3) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for P shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
             'R' 'R' '6'
             'R' 'R' '7'
             '2' 'R' '8'
            */

            Blocks[0].Status = BlockStatus.DarkSeaGreen;
            Blocks[1].Status = BlockStatus.DarkSeaGreen;
            Blocks[3].Status = BlockStatus.DarkSeaGreen;
            Blocks[4].Status = BlockStatus.DarkSeaGreen;
            Blocks[5].Status = BlockStatus.DarkSeaGreen;
          
        }

        #endregion

    }
}
