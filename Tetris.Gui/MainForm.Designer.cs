namespace Tetris.Gui
{
    partial class MainFrom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gameDeckPicBox = new System.Windows.Forms.PictureBox();
            nextTetrominoPicBox = new System.Windows.Forms.PictureBox();
            scoreGrp = new System.Windows.Forms.GroupBox();
            levelCaptionLbl = new System.Windows.Forms.Label();
            levelLbl = new System.Windows.Forms.Label();
            scoreCaptionLbl = new System.Windows.Forms.Label();
            linesCaptionLbl = new System.Windows.Forms.Label();
            scoreLbl = new System.Windows.Forms.Label();
            linesLbl = new System.Windows.Forms.Label();
            nextLbl = new System.Windows.Forms.Label();
            shortcutsGrp = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            holdTetrominoLbl = new System.Windows.Forms.Label();
            exitGameLbl = new System.Windows.Forms.Label();
            restartGameLbl = new System.Windows.Forms.Label();
            resumeGameLbl = new System.Windows.Forms.Label();
            pauseGameLbl = new System.Windows.Forms.Label();
            ghostOnOffLbl = new System.Windows.Forms.Label();
            hardDropLbl = new System.Windows.Forms.Label();
            moveDownLbl = new System.Windows.Forms.Label();
            holdKeyLbl = new System.Windows.Forms.Label();
            escapeKeyLbl = new System.Windows.Forms.Label();
            enterKeyLbl = new System.Windows.Forms.Label();
            rKeyLbl = new System.Windows.Forms.Label();
            moveLeftLbl = new System.Windows.Forms.Label();
            gKeyLbl = new System.Windows.Forms.Label();
            pKeyLbl = new System.Windows.Forms.Label();
            spaceKeyLbl = new System.Windows.Forms.Label();
            downArrowKeyLbl = new System.Windows.Forms.Label();
            leftArrowKeyLbl = new System.Windows.Forms.Label();
            moveRightLbl = new System.Windows.Forms.Label();
            rotateLbl = new System.Windows.Forms.Label();
            rightArrowKeyLbl = new System.Windows.Forms.Label();
            upArrowKeyLbl = new System.Windows.Forms.Label();
            headerPicBox = new System.Windows.Forms.PictureBox();
            holdTetrominoPicBox = new System.Windows.Forms.PictureBox();
            holdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)gameDeckPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextTetrominoPicBox).BeginInit();
            scoreGrp.SuspendLayout();
            shortcutsGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)headerPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)holdTetrominoPicBox).BeginInit();
            SuspendLayout();
            // 
            // gameDeckPicBox
            // 
            gameDeckPicBox.Location = new System.Drawing.Point(55, 135);
            gameDeckPicBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gameDeckPicBox.Name = "gameDeckPicBox";
            gameDeckPicBox.Size = new System.Drawing.Size(378, 416);
            gameDeckPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            gameDeckPicBox.TabIndex = 0;
            gameDeckPicBox.TabStop = false;
            // 
            // nextTetrominoPicBox
            // 
            nextTetrominoPicBox.Location = new System.Drawing.Point(520, 135);
            nextTetrominoPicBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nextTetrominoPicBox.Name = "nextTetrominoPicBox";
            nextTetrominoPicBox.Size = new System.Drawing.Size(273, 240);
            nextTetrominoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            nextTetrominoPicBox.TabIndex = 0;
            nextTetrominoPicBox.TabStop = false;
            // 
            // scoreGrp
            // 
            scoreGrp.Controls.Add(levelCaptionLbl);
            scoreGrp.Controls.Add(levelLbl);
            scoreGrp.Controls.Add(scoreCaptionLbl);
            scoreGrp.Controls.Add(linesCaptionLbl);
            scoreGrp.Controls.Add(scoreLbl);
            scoreGrp.Controls.Add(linesLbl);
            scoreGrp.Location = new System.Drawing.Point(513, 488);
            scoreGrp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            scoreGrp.Name = "scoreGrp";
            scoreGrp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            scoreGrp.Size = new System.Drawing.Size(272, 147);
            scoreGrp.TabIndex = 1;
            scoreGrp.TabStop = false;
            // 
            // levelCaptionLbl
            // 
            levelCaptionLbl.AutoSize = true;
            levelCaptionLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            levelCaptionLbl.Location = new System.Drawing.Point(24, 100);
            levelCaptionLbl.Name = "levelCaptionLbl";
            levelCaptionLbl.Size = new System.Drawing.Size(58, 20);
            levelCaptionLbl.TabIndex = 0;
            levelCaptionLbl.Text = "♡Level:";
            // 
            // levelLbl
            // 
            levelLbl.AutoSize = true;
            levelLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            levelLbl.Location = new System.Drawing.Point(135, 100);
            levelLbl.Name = "levelLbl";
            levelLbl.Size = new System.Drawing.Size(17, 20);
            levelLbl.TabIndex = 0;
            levelLbl.Text = "0";
            // 
            // scoreCaptionLbl
            // 
            scoreCaptionLbl.AutoSize = true;
            scoreCaptionLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            scoreCaptionLbl.Location = new System.Drawing.Point(24, 67);
            scoreCaptionLbl.Name = "scoreCaptionLbl";
            scoreCaptionLbl.Size = new System.Drawing.Size(61, 20);
            scoreCaptionLbl.TabIndex = 0;
            scoreCaptionLbl.Text = "♡Score:";
            // 
            // linesCaptionLbl
            // 
            linesCaptionLbl.AutoSize = true;
            linesCaptionLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            linesCaptionLbl.Location = new System.Drawing.Point(24, 33);
            linesCaptionLbl.Name = "linesCaptionLbl";
            linesCaptionLbl.Size = new System.Drawing.Size(57, 20);
            linesCaptionLbl.TabIndex = 0;
            linesCaptionLbl.Text = "♡Lines:";
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            scoreLbl.Location = new System.Drawing.Point(135, 67);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new System.Drawing.Size(17, 20);
            scoreLbl.TabIndex = 0;
            scoreLbl.Text = "0";
            // 
            // linesLbl
            // 
            linesLbl.AutoSize = true;
            linesLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            linesLbl.Location = new System.Drawing.Point(135, 33);
            linesLbl.Name = "linesLbl";
            linesLbl.Size = new System.Drawing.Size(17, 20);
            linesLbl.TabIndex = 0;
            linesLbl.Text = "0";
            // 
            // nextLbl
            // 
            nextLbl.AutoSize = true;
            nextLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            nextLbl.Location = new System.Drawing.Point(481, 284);
            nextLbl.Name = "nextLbl";
            nextLbl.Size = new System.Drawing.Size(42, 20);
            nextLbl.TabIndex = 0;
            nextLbl.Text = "Next";
            // 
            // shortcutsGrp
            // 
            shortcutsGrp.Controls.Add(label1);
            shortcutsGrp.Controls.Add(label2);
            shortcutsGrp.Controls.Add(holdTetrominoLbl);
            shortcutsGrp.Controls.Add(exitGameLbl);
            shortcutsGrp.Controls.Add(restartGameLbl);
            shortcutsGrp.Controls.Add(resumeGameLbl);
            shortcutsGrp.Controls.Add(pauseGameLbl);
            shortcutsGrp.Controls.Add(ghostOnOffLbl);
            shortcutsGrp.Controls.Add(hardDropLbl);
            shortcutsGrp.Controls.Add(moveDownLbl);
            shortcutsGrp.Controls.Add(holdKeyLbl);
            shortcutsGrp.Controls.Add(escapeKeyLbl);
            shortcutsGrp.Controls.Add(enterKeyLbl);
            shortcutsGrp.Controls.Add(rKeyLbl);
            shortcutsGrp.Controls.Add(moveLeftLbl);
            shortcutsGrp.Controls.Add(gKeyLbl);
            shortcutsGrp.Controls.Add(pKeyLbl);
            shortcutsGrp.Controls.Add(spaceKeyLbl);
            shortcutsGrp.Controls.Add(downArrowKeyLbl);
            shortcutsGrp.Controls.Add(leftArrowKeyLbl);
            shortcutsGrp.Controls.Add(moveRightLbl);
            shortcutsGrp.Controls.Add(rotateLbl);
            shortcutsGrp.Controls.Add(rightArrowKeyLbl);
            shortcutsGrp.Controls.Add(upArrowKeyLbl);
            shortcutsGrp.Location = new System.Drawing.Point(869, 135);
            shortcutsGrp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            shortcutsGrp.Name = "shortcutsGrp";
            shortcutsGrp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            shortcutsGrp.Size = new System.Drawing.Size(272, 440);
            shortcutsGrp.TabIndex = 1;
            shortcutsGrp.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(15, 396);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 20);
            label1.TabIndex = 1;
            label1.Text = "♡Difficulty:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(135, 396);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "C Key";
            // 
            // holdTetrominoLbl
            // 
            holdTetrominoLbl.AutoSize = true;
            holdTetrominoLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            holdTetrominoLbl.Location = new System.Drawing.Point(15, 365);
            holdTetrominoLbl.Name = "holdTetrominoLbl";
            holdTetrominoLbl.Size = new System.Drawing.Size(56, 20);
            holdTetrominoLbl.TabIndex = 0;
            holdTetrominoLbl.Text = "♡Hold:";
            // 
            // exitGameLbl
            // 
            exitGameLbl.AutoSize = true;
            exitGameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            exitGameLbl.Location = new System.Drawing.Point(15, 333);
            exitGameLbl.Name = "exitGameLbl";
            exitGameLbl.Size = new System.Drawing.Size(91, 20);
            exitGameLbl.TabIndex = 0;
            exitGameLbl.Text = "♡Exit Game:";
            // 
            // restartGameLbl
            // 
            restartGameLbl.AutoSize = true;
            restartGameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            restartGameLbl.Location = new System.Drawing.Point(15, 300);
            restartGameLbl.Name = "restartGameLbl";
            restartGameLbl.Size = new System.Drawing.Size(113, 20);
            restartGameLbl.TabIndex = 0;
            restartGameLbl.Text = "♡Restart Game:";
            // 
            // resumeGameLbl
            // 
            resumeGameLbl.AutoSize = true;
            resumeGameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            resumeGameLbl.Location = new System.Drawing.Point(15, 267);
            resumeGameLbl.Name = "resumeGameLbl";
            resumeGameLbl.Size = new System.Drawing.Size(119, 20);
            resumeGameLbl.TabIndex = 0;
            resumeGameLbl.Text = "♡Resume Game:";
            // 
            // pauseGameLbl
            // 
            pauseGameLbl.AutoSize = true;
            pauseGameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            pauseGameLbl.Location = new System.Drawing.Point(15, 233);
            pauseGameLbl.Name = "pauseGameLbl";
            pauseGameLbl.Size = new System.Drawing.Size(106, 20);
            pauseGameLbl.TabIndex = 0;
            pauseGameLbl.Text = "♡Pause Game:";
            // 
            // ghostOnOffLbl
            // 
            ghostOnOffLbl.AutoSize = true;
            ghostOnOffLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ghostOnOffLbl.Location = new System.Drawing.Point(15, 200);
            ghostOnOffLbl.Name = "ghostOnOffLbl";
            ghostOnOffLbl.Size = new System.Drawing.Size(114, 20);
            ghostOnOffLbl.TabIndex = 0;
            ghostOnOffLbl.Text = "♡Ghost On/Off:";
            // 
            // hardDropLbl
            // 
            hardDropLbl.AutoSize = true;
            hardDropLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            hardDropLbl.Location = new System.Drawing.Point(15, 167);
            hardDropLbl.Name = "hardDropLbl";
            hardDropLbl.Size = new System.Drawing.Size(96, 20);
            hardDropLbl.TabIndex = 0;
            hardDropLbl.Text = "♡Hard Drop:";
            // 
            // moveDownLbl
            // 
            moveDownLbl.AutoSize = true;
            moveDownLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            moveDownLbl.Location = new System.Drawing.Point(15, 133);
            moveDownLbl.Name = "moveDownLbl";
            moveDownLbl.Size = new System.Drawing.Size(106, 20);
            moveDownLbl.TabIndex = 0;
            moveDownLbl.Text = "♡Move Down:";
            // 
            // holdKeyLbl
            // 
            holdKeyLbl.AutoSize = true;
            holdKeyLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            holdKeyLbl.Location = new System.Drawing.Point(135, 365);
            holdKeyLbl.Name = "holdKeyLbl";
            holdKeyLbl.Size = new System.Drawing.Size(49, 20);
            holdKeyLbl.TabIndex = 0;
            holdKeyLbl.Text = "H Key";
            // 
            // escapeKeyLbl
            // 
            escapeKeyLbl.AutoSize = true;
            escapeKeyLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            escapeKeyLbl.Location = new System.Drawing.Point(135, 333);
            escapeKeyLbl.Name = "escapeKeyLbl";
            escapeKeyLbl.Size = new System.Drawing.Size(84, 20);
            escapeKeyLbl.TabIndex = 0;
            escapeKeyLbl.Text = "Escape Key";
            // 
            // enterKeyLbl
            // 
            enterKeyLbl.AutoSize = true;
            enterKeyLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            enterKeyLbl.Location = new System.Drawing.Point(135, 300);
            enterKeyLbl.Name = "enterKeyLbl";
            enterKeyLbl.Size = new System.Drawing.Size(74, 20);
            enterKeyLbl.TabIndex = 0;
            enterKeyLbl.Text = "Enter Key";
            // 
            // rKeyLbl
            // 
            rKeyLbl.AutoSize = true;
            rKeyLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rKeyLbl.Location = new System.Drawing.Point(135, 267);
            rKeyLbl.Name = "rKeyLbl";
            rKeyLbl.Size = new System.Drawing.Size(47, 20);
            rKeyLbl.TabIndex = 0;
            rKeyLbl.Text = "R Key";
            // 
            // moveLeftLbl
            // 
            moveLeftLbl.AutoSize = true;
            moveLeftLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            moveLeftLbl.Location = new System.Drawing.Point(15, 100);
            moveLeftLbl.Name = "moveLeftLbl";
            moveLeftLbl.Size = new System.Drawing.Size(91, 20);
            moveLeftLbl.TabIndex = 0;
            moveLeftLbl.Text = "♡Move Left:";
            // 
            // gKeyLbl
            // 
            gKeyLbl.AutoSize = true;
            gKeyLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gKeyLbl.Location = new System.Drawing.Point(135, 200);
            gKeyLbl.Name = "gKeyLbl";
            gKeyLbl.Size = new System.Drawing.Size(48, 20);
            gKeyLbl.TabIndex = 0;
            gKeyLbl.Text = "G Key";
            // 
            // pKeyLbl
            // 
            pKeyLbl.AutoSize = true;
            pKeyLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            pKeyLbl.Location = new System.Drawing.Point(135, 233);
            pKeyLbl.Name = "pKeyLbl";
            pKeyLbl.Size = new System.Drawing.Size(47, 20);
            pKeyLbl.TabIndex = 0;
            pKeyLbl.Text = "P Key";
            // 
            // spaceKeyLbl
            // 
            spaceKeyLbl.AutoSize = true;
            spaceKeyLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            spaceKeyLbl.Location = new System.Drawing.Point(135, 167);
            spaceKeyLbl.Name = "spaceKeyLbl";
            spaceKeyLbl.Size = new System.Drawing.Size(78, 20);
            spaceKeyLbl.TabIndex = 0;
            spaceKeyLbl.Text = "Space Key";
            // 
            // downArrowKeyLbl
            // 
            downArrowKeyLbl.AutoSize = true;
            downArrowKeyLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            downArrowKeyLbl.Location = new System.Drawing.Point(135, 133);
            downArrowKeyLbl.Name = "downArrowKeyLbl";
            downArrowKeyLbl.Size = new System.Drawing.Size(124, 20);
            downArrowKeyLbl.TabIndex = 0;
            downArrowKeyLbl.Text = "Down Arrow Key";
            // 
            // leftArrowKeyLbl
            // 
            leftArrowKeyLbl.AutoSize = true;
            leftArrowKeyLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            leftArrowKeyLbl.Location = new System.Drawing.Point(135, 100);
            leftArrowKeyLbl.Name = "leftArrowKeyLbl";
            leftArrowKeyLbl.Size = new System.Drawing.Size(109, 20);
            leftArrowKeyLbl.TabIndex = 0;
            leftArrowKeyLbl.Text = "Left Arrow Key";
            // 
            // moveRightLbl
            // 
            moveRightLbl.AutoSize = true;
            moveRightLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            moveRightLbl.Location = new System.Drawing.Point(15, 67);
            moveRightLbl.Name = "moveRightLbl";
            moveRightLbl.Size = new System.Drawing.Size(102, 20);
            moveRightLbl.TabIndex = 0;
            moveRightLbl.Text = "♡Move Right:";
            // 
            // rotateLbl
            // 
            rotateLbl.AutoSize = true;
            rotateLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rotateLbl.Location = new System.Drawing.Point(15, 33);
            rotateLbl.Name = "rotateLbl";
            rotateLbl.Size = new System.Drawing.Size(67, 20);
            rotateLbl.TabIndex = 0;
            rotateLbl.Text = "♡Rotate:";
            // 
            // rightArrowKeyLbl
            // 
            rightArrowKeyLbl.AutoSize = true;
            rightArrowKeyLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rightArrowKeyLbl.Location = new System.Drawing.Point(135, 67);
            rightArrowKeyLbl.Name = "rightArrowKeyLbl";
            rightArrowKeyLbl.Size = new System.Drawing.Size(120, 20);
            rightArrowKeyLbl.TabIndex = 0;
            rightArrowKeyLbl.Text = "Right Arrow Key";
            // 
            // upArrowKeyLbl
            // 
            upArrowKeyLbl.AutoSize = true;
            upArrowKeyLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            upArrowKeyLbl.Location = new System.Drawing.Point(135, 33);
            upArrowKeyLbl.Name = "upArrowKeyLbl";
            upArrowKeyLbl.Size = new System.Drawing.Size(104, 20);
            upArrowKeyLbl.TabIndex = 0;
            upArrowKeyLbl.Text = "Up Arrow Key";
            // 
            // headerPicBox
            // 
            headerPicBox.Location = new System.Drawing.Point(55, 55);
            headerPicBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            headerPicBox.Name = "headerPicBox";
            headerPicBox.Size = new System.Drawing.Size(378, 50);
            headerPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            headerPicBox.TabIndex = 2;
            headerPicBox.TabStop = false;
            // 
            // holdTetrominoPicBox
            // 
            holdTetrominoPicBox.Location = new System.Drawing.Point(845, 603);
            holdTetrominoPicBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            holdTetrominoPicBox.Name = "holdTetrominoPicBox";
            holdTetrominoPicBox.Size = new System.Drawing.Size(273, 240);
            holdTetrominoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            holdTetrominoPicBox.TabIndex = 0;
            holdTetrominoPicBox.TabStop = false;
            // 
            // holdLbl
            // 
            holdLbl.AutoSize = true;
            holdLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            holdLbl.Location = new System.Drawing.Point(570, 669);
            holdLbl.Name = "holdLbl";
            holdLbl.Size = new System.Drawing.Size(42, 20);
            holdLbl.TabIndex = 0;
            holdLbl.Text = "Hold";
            // 
            // MainFrom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1618, 945);
            Controls.Add(holdLbl);
            Controls.Add(headerPicBox);
            Controls.Add(shortcutsGrp);
            Controls.Add(scoreGrp);
            Controls.Add(holdTetrominoPicBox);
            Controls.Add(nextTetrominoPicBox);
            Controls.Add(gameDeckPicBox);
            Controls.Add(nextLbl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainFrom";
            Text = "Tetris";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Activated += MainFrom_Activated;
            Deactivate += MainFrom_Deactivate;
            FormClosing += MainFrom_FormClosing;
            Load += MainFrom_Load;
            KeyDown += MainFrom_KeyDown;
            KeyUp += MainFrom_KeyUp;
            Resize += MainFrom_Resize;
            ((System.ComponentModel.ISupportInitialize)gameDeckPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextTetrominoPicBox).EndInit();
            scoreGrp.ResumeLayout(false);
            scoreGrp.PerformLayout();
            shortcutsGrp.ResumeLayout(false);
            shortcutsGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)headerPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)holdTetrominoPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox gameDeckPicBox;
        private System.Windows.Forms.PictureBox nextTetrominoPicBox;
        private System.Windows.Forms.GroupBox scoreGrp;
        private System.Windows.Forms.Label linesLbl;
        private System.Windows.Forms.Label levelCaptionLbl;
        private System.Windows.Forms.Label levelLbl;
        private System.Windows.Forms.Label scoreCaptionLbl;
        private System.Windows.Forms.Label linesCaptionLbl;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label nextLbl;
        private System.Windows.Forms.GroupBox shortcutsGrp;
        private System.Windows.Forms.Label moveLeftLbl;
        private System.Windows.Forms.Label leftArrowKeyLbl;
        private System.Windows.Forms.Label moveRightLbl;
        private System.Windows.Forms.Label rotateLbl;
        private System.Windows.Forms.Label rightArrowKeyLbl;
        private System.Windows.Forms.Label upArrowKeyLbl;
        private System.Windows.Forms.Label moveDownLbl;
        private System.Windows.Forms.Label downArrowKeyLbl;
        private System.Windows.Forms.Label hardDropLbl;
        private System.Windows.Forms.Label spaceKeyLbl;
        private System.Windows.Forms.Label resumeGameLbl;
        private System.Windows.Forms.Label pauseGameLbl;
        private System.Windows.Forms.Label rKeyLbl;
        private System.Windows.Forms.Label pKeyLbl;
        private System.Windows.Forms.Label restartGameLbl;
        private System.Windows.Forms.Label enterKeyLbl;
        private System.Windows.Forms.Label exitGameLbl;
        private System.Windows.Forms.Label escapeKeyLbl;
        private System.Windows.Forms.Label ghostOnOffLbl;
        private System.Windows.Forms.Label gKeyLbl;
        private System.Windows.Forms.PictureBox headerPicBox;
        private System.Windows.Forms.PictureBox holdTetrominoPicBox;
        private System.Windows.Forms.Label holdLbl;
        private System.Windows.Forms.Label holdTetrominoLbl;
        private System.Windows.Forms.Label holdKeyLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

