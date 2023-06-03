namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino L class. L tetromino is a 4*4 matrix 
    /// </summary>
    internal class LTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public LTetrominoExtra(Deck deck) : base(deck, 4) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for L shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
              '0' 'L' '8' '12'
              '1' 'L' '9' '13'
              '2' 'L' '10' '14'
              '3' 'L' 'L'  '15'
            */

            Blocks[4].Status = BlockStatus.DarkKhaki;
            Blocks[5].Status = BlockStatus.DarkKhaki;
            Blocks[6].Status = BlockStatus.DarkKhaki;
            Blocks[7].Status = BlockStatus.DarkKhaki;
            Blocks[11].Status = BlockStatus.DarkKhaki;
        }

        #endregion

    }
}
