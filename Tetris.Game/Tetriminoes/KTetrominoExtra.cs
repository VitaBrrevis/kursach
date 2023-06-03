namespace Tetris.Game.Tetriminoes
{

    /// <summary>
    /// Tetromino T class. T tetromino is a 3*3 matrix
    /// </summary>
    internal class KTetrominoExtra : Tetromino
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the tetromino
        /// </summary>
        /// <param name="deck">Deck which tetromino belongs to</param>
        public KTetrominoExtra(Deck deck) : base(deck, 3) { }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Specifies tetromino visible blocks for K shape
        /// </summary>
        protected override void SpecifyVisibleBlocks()
        {

            /*  
             '0' 'K' '6'
             'K' 'K' 'K'
             '2' 'K' '8'
            */

            Blocks[1].Status = BlockStatus.MediumOrchid;
            Blocks[3].Status = BlockStatus.MediumOrchid;
            Blocks[4].Status = BlockStatus.MediumOrchid;
            Blocks[5].Status = BlockStatus.MediumOrchid;
            Blocks[7].Status = BlockStatus.MediumOrchid;
            
        }

        #endregion

    }
}
