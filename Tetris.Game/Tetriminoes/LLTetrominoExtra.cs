namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino LL class. LL tetromino is a 3*3 matrix
    /// </summary>
    internal class LLTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public LLTetrominoExtra(Deck deck) : base(deck, 3) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for T shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
             '0' '3' 'L'
             '1' '4' 'L'
             'L' 'L' 'L'
            */

            Blocks[2].Status = BlockStatus.SteelBlue;
            Blocks[5].Status = BlockStatus.SteelBlue;
            Blocks[6].Status = BlockStatus.SteelBlue;
            Blocks[7].Status = BlockStatus.SteelBlue;
            Blocks[8].Status = BlockStatus.SteelBlue;
        }

        #endregion

    }
}
