namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino U class. U tetromino is a 3*3 matrix
    /// </summary>
    internal class UTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public UTetrominoExtra(Deck deck) : base(deck, 3) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for T shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
             '0' '3' '6'
             'U' '4' 'U'
             'U' 'U' 'U'
            */

            Blocks[1].Status = BlockStatus.LightSkyBlue;
            Blocks[2].Status = BlockStatus.LightSkyBlue;
            Blocks[5].Status = BlockStatus.LightSkyBlue;
            Blocks[7].Status = BlockStatus.LightSkyBlue;
            Blocks[8].Status = BlockStatus.LightSkyBlue;
        }

        #endregion

    }
}
