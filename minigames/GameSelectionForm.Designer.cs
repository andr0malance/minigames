namespace minigames
{
    partial class GameSelectionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSnake = new System.Windows.Forms.Button();
            this.btnTanks = new System.Windows.Forms.Button();
            this.btnRacing = new System.Windows.Forms.Button();
            this.btnArkanoid = new System.Windows.Forms.Button();
            this.btnTetris = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSnake
            // 
            this.btnSnake.Font = new System.Drawing.Font("Press Start 2P", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSnake.Location = new System.Drawing.Point(87, 84);
            this.btnSnake.Name = "btnSnake";
            this.btnSnake.Size = new System.Drawing.Size(200, 40);
            this.btnSnake.TabIndex = 1;
            this.btnSnake.Text = "Змейка";
            this.btnSnake.Click += new System.EventHandler(this.btnSnake_Click);
            // 
            // btnTanks
            // 
            this.btnTanks.Font = new System.Drawing.Font("Press Start 2P", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTanks.Location = new System.Drawing.Point(87, 130);
            this.btnTanks.Name = "btnTanks";
            this.btnTanks.Size = new System.Drawing.Size(200, 40);
            this.btnTanks.TabIndex = 2;
            this.btnTanks.Text = "Танчики";
            this.btnTanks.Click += new System.EventHandler(this.btnTanks_Click);
            // 
            // btnRacing
            // 
            this.btnRacing.Font = new System.Drawing.Font("Press Start 2P", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRacing.Location = new System.Drawing.Point(87, 176);
            this.btnRacing.Name = "btnRacing";
            this.btnRacing.Size = new System.Drawing.Size(200, 40);
            this.btnRacing.TabIndex = 3;
            this.btnRacing.Text = "Гонки";
            this.btnRacing.Click += new System.EventHandler(this.btnRacing_Click);
            // 
            // btnArkanoid
            // 
            this.btnArkanoid.Font = new System.Drawing.Font("Press Start 2P", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnArkanoid.Location = new System.Drawing.Point(87, 222);
            this.btnArkanoid.Name = "btnArkanoid";
            this.btnArkanoid.Size = new System.Drawing.Size(200, 40);
            this.btnArkanoid.TabIndex = 4;
            this.btnArkanoid.Text = "Арканоид";
            this.btnArkanoid.Click += new System.EventHandler(this.btnArkanoid_Click);
            // 
            // btnTetris
            // 
            this.btnTetris.Font = new System.Drawing.Font("Press Start 2P", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTetris.Location = new System.Drawing.Point(87, 268);
            this.btnTetris.Name = "btnTetris";
            this.btnTetris.Size = new System.Drawing.Size(200, 40);
            this.btnTetris.TabIndex = 5;
            this.btnTetris.Text = "Тетрис";
            this.btnTetris.Click += new System.EventHandler(this.btnTetris_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Press Start 2P", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(41, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Выберите игру";
            // 
            // GameSelectionForm
            // 
            this.ClientSize = new System.Drawing.Size(370, 327);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSnake);
            this.Controls.Add(this.btnTanks);
            this.Controls.Add(this.btnRacing);
            this.Controls.Add(this.btnArkanoid);
            this.Controls.Add(this.btnTetris);
            this.Name = "GameSelectionForm";
            this.Text = "Мини-игры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnSnake;
        private System.Windows.Forms.Button btnTanks;
        private System.Windows.Forms.Button btnRacing;
        private System.Windows.Forms.Button btnArkanoid;
        private System.Windows.Forms.Button btnTetris;
        private System.Windows.Forms.Label lblTitle;
    }
}