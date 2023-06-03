namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino T class. T tetromino is a 3*3 matrix
    /// </summary>
    internal class TTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public TTetrominoExtra(Deck deck) : base(deck, 3) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for T shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
             'T' 'T' 'T'
             '1' 'T' '7'
             '2' 'T' '8'
            */

            Blocks[0].Status = BlockStatus.MediumAquamarine;
            Blocks[3].Status = BlockStatus.MediumAquamarine;
            Blocks[4].Status = BlockStatus.MediumAquamarine;
            Blocks[5].Status = BlockStatus.MediumAquamarine;
            Blocks[6].Status = BlockStatus.MediumAquamarine;
        }

        #endregion

    }
}
