namespace pryMammanoSP2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblGenTick = new Label();
            lblFecha = new Label();
            lblNumTick = new Label();
            lblTicket = new Label();
            dtpFecha = new DateTimePicker();
            txtNumTick = new TextBox();
            cbTicket = new ComboBox();
            btnReg = new Button();
            lstTicket = new ListBox();
            SuspendLayout();
            // 
            // lblGenTick
            // 
            lblGenTick.AutoSize = true;
            lblGenTick.Font = new Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenTick.Location = new Point(76, 25);
            lblGenTick.Name = "lblGenTick";
            lblGenTick.Size = new Size(297, 28);
            lblGenTick.TabIndex = 0;
            lblGenTick.Text = "GENERADOR DE TICKETS";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Mongolian Baiti", 11.25F);
            lblFecha.ForeColor = SystemColors.ControlLight;
            lblFecha.Location = new Point(66, 82);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 16);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // lblNumTick
            // 
            lblNumTick.AutoSize = true;
            lblNumTick.BackColor = Color.Transparent;
            lblNumTick.Font = new Font("Mongolian Baiti", 11.25F);
            lblNumTick.ForeColor = SystemColors.ControlLight;
            lblNumTick.Location = new Point(24, 121);
            lblNumTick.Name = "lblNumTick";
            lblNumTick.Size = new Size(120, 16);
            lblNumTick.TabIndex = 2;
            lblNumTick.Text = "Numero de Ticket";
            // 
            // lblTicket
            // 
            lblTicket.AutoSize = true;
            lblTicket.BackColor = Color.Transparent;
            lblTicket.Font = new Font("Mongolian Baiti", 11.25F);
            lblTicket.ForeColor = SystemColors.ControlLight;
            lblTicket.Location = new Point(64, 162);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(46, 16);
            lblTicket.TabIndex = 3;
            lblTicket.Text = "Ticket";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(151, 77);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 4;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // txtNumTick
            // 
            txtNumTick.Enabled = false;
            txtNumTick.Location = new Point(151, 116);
            txtNumTick.Name = "txtNumTick";
            txtNumTick.Size = new Size(148, 23);
            txtNumTick.TabIndex = 5;
            txtNumTick.TextChanged += txtNumTick_TextChanged;
            // 
            // cbTicket
            // 
            cbTicket.Enabled = false;
            cbTicket.FormattingEnabled = true;
            cbTicket.Location = new Point(151, 155);
            cbTicket.Name = "cbTicket";
            cbTicket.Size = new Size(111, 23);
            cbTicket.TabIndex = 6;
            cbTicket.SelectedIndexChanged += cbTicket_SelectedIndexChanged;
            // 
            // btnReg
            // 
            btnReg.Enabled = false;
            btnReg.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReg.Location = new Point(151, 198);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(111, 46);
            btnReg.TabIndex = 7;
            btnReg.Text = "REGISTRAR";
            btnReg.UseVisualStyleBackColor = true;
            // 
            // lstTicket
            // 
            lstTicket.FormattingEnabled = true;
            lstTicket.Location = new Point(12, 297);
            lstTicket.Name = "lstTicket";
            lstTicket.Size = new Size(424, 124);
            lstTicket.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(448, 433);
            Controls.Add(lstTicket);
            Controls.Add(btnReg);
            Controls.Add(cbTicket);
            Controls.Add(txtNumTick);
            Controls.Add(dtpFecha);
            Controls.Add(lblTicket);
            Controls.Add(lblNumTick);
            Controls.Add(lblFecha);
            Controls.Add(lblGenTick);
            Name = "Form1";
            Text = "Ticket Generator 3000";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGenTick;
        private Label lblFecha;
        private Label lblNumTick;
        private Label lblTicket;
        private DateTimePicker dtpFecha;
        private TextBox txtNumTick;
        private ComboBox cbTicket;
        private Button btnReg;
        private ListBox lstTicket;
    }
}
