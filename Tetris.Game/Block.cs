namespace Tetris.Game
{

    /// <summary>
    /// Block class is for storing deck cell's data
    /// </summary>
    public class Block
    {

        #region Ctor

        /// <summary>
        /// Creates a new instance of the block with the default values of an existing block
        /// </summary>
        public Block(Block block)
        {
            X = block.X;
            Y = block.Y;
            Status = block.Status;
        }

        /// <summary>
        /// Creates a new instance of the block with the default values of an existing block and a new status
        /// </summary>

        public Block(Block block , BlockStatus status)
        {
            X = block.X;
            Y = block.Y;
            Status = status;
        }

        /// <summary>
        /// Creates a new instance of the block with default hidden status
        /// </summary>
        /// <param name="x">X postion of the block</param>
        /// <param name="y">Y postion of the block</param>
        public Block(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Creates a new instance of the block
        /// </summary>
        /// <param name="x">X postion of the block</param>
        /// <param name="y">X postion of the block</param>
        /// <param name="status">Status of the block</param>
        public Block(int x, int y, BlockStatus status)
        {
            X = x;
            Y = y;
            Status = status;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// X postion of the block in deck
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y position of the block in deck
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Status of the block in deck
        /// </summary>
        public BlockStatus Status { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Moves the block to right in deck
        /// </summary>
        public void MoveRight()
        {
            X++;
        }

        /// <summary>
        /// Moves the block to left in deck
        /// </summary>
        public void MoveLeft()
        {
            X--;
        }

        /// <summary>
        /// Moves the block to down in deck
        /// </summary>
        public void MoveDown()
        {
            Y++;
        }

        #endregion

    }
}
