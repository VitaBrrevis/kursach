namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino QReverse class. QReverse tetromino is a 4*4 matrix 
    /// </summary>
    internal class QRTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public QRTetrominoExtra(Deck deck) : base(deck, 4) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for L shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
              '0' 'Q' '8' '12'
              '1' 'Q' 'Q' '13'
              '2' 'Q' '10' '14'
              '3' 'Q' '11'  '15'
            */

           
            Blocks[4].Status = BlockStatus.MediumVioletRed;
            Blocks[5].Status = BlockStatus.MediumVioletRed;
            Blocks[6].Status = BlockStatus.MediumVioletRed;
            Blocks[7].Status = BlockStatus.MediumVioletRed;
            Blocks[9].Status = BlockStatus.MediumVioletRed;

        }

        #endregion

    }
}
