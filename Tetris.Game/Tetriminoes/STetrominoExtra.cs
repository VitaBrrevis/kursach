namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino S class. S tetromino is a 3*3 matrix
    /// </summary>
    internal class STetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public STetrominoExtra(Deck deck) : base(deck, 3) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for T shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
             '0' '3' 'S'
             '1' 'S' 'S'
             'S' 'S' '8'
            */

            Blocks[2].Status = BlockStatus.MediumPurple;
            Blocks[4].Status = BlockStatus.MediumPurple;
            Blocks[5].Status = BlockStatus.MediumPurple;
            Blocks[6].Status = BlockStatus.MediumPurple;
            Blocks[7].Status = BlockStatus.MediumPurple;
      
        }

        #endregion

    }
}
