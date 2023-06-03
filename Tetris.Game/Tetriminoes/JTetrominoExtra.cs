namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino J class. J tetromino is a 4*4 matrix 
    /// </summary>
    internal class JTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public JTetrominoExtra(Deck deck) : base(deck, 4) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for L shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
              '0' 'J' '8' '12'
              '1' 'J' '9' '13'
              '2' 'J' '10' '14' 
              'J' 'J' '11' '15'
            */

            Blocks[3].Status = BlockStatus.DarkKhaki;
            Blocks[4].Status = BlockStatus.DarkKhaki;
            Blocks[5].Status = BlockStatus.DarkKhaki;
            Blocks[6].Status = BlockStatus.DarkKhaki;
            Blocks[7].Status = BlockStatus.DarkKhaki;
          
        }

        #endregion

    }
}
