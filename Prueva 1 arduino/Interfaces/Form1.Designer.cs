namespace Prueva_1_arduino
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBarConnection = new System.Windows.Forms.ProgressBar();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.velocidad = new System.Windows.Forms.Label();
            this.Puerto = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBVerTramaJson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBVerTrama = new System.Windows.Forms.TextBox();
            this.LbDatosRecibidos = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBEnvTrama = new System.Windows.Forms.TextBox();
            this.BtOff = new System.Windows.Forms.Button();
            this.BtOn = new System.Windows.Forms.Button();
            this.ImgLed = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLed)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.datosRecividos);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBarConnection);
            this.groupBox2.Controls.Add(this.buttonClose);
            this.groupBox2.Controls.Add(this.buttonOpen);
            this.groupBox2.Controls.Add(this.comboBoxBaudRate);
            this.groupBox2.Controls.Add(this.comboBoxComPort);
            this.groupBox2.Controls.Add(this.velocidad);
            this.groupBox2.Controls.Add(this.Puerto);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 217);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "conexion";
            // 
            // progressBarConnection
            // 
            this.progressBarConnection.Location = new System.Drawing.Point(19, 171);
            this.progressBarConnection.Name = "progressBarConnection";
            this.progressBarConnection.Size = new System.Drawing.Size(236, 23);
            this.progressBarConnection.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(154, 121);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Desconectar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(29, 121);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Conectar";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "11600"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(124, 61);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 3;
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(124, 31);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPort.TabIndex = 2;
            // 
            // velocidad
            // 
            this.velocidad.AutoSize = true;
            this.velocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocidad.Location = new System.Drawing.Point(26, 61);
            this.velocidad.Name = "velocidad";
            this.velocidad.Size = new System.Drawing.Size(78, 16);
            this.velocidad.TabIndex = 1;
            this.velocidad.Text = "Velocidad";
            // 
            // Puerto
            // 
            this.Puerto.AutoSize = true;
            this.Puerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puerto.Location = new System.Drawing.Point(26, 31);
            this.Puerto.Name = "Puerto";
            this.Puerto.Size = new System.Drawing.Size(52, 16);
            this.Puerto.TabIndex = 0;
            this.Puerto.Text = "Puerto";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(22, 19);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Analog";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(513, 194);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(558, 19);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Maximum = 1024;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(153, 150);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 8;
            this.circularProgressBar1.Text = "100";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.circularProgressBar1.Value = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBVerTramaJson);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Controls.Add(this.circularProgressBar1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBVerTrama);
            this.groupBox1.Controls.Add(this.LbDatosRecibidos);
            this.groupBox1.Location = new System.Drawing.Point(15, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 329);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // TBVerTramaJson
            // 
            this.TBVerTramaJson.Location = new System.Drawing.Point(123, 286);
            this.TBVerTramaJson.Name = "TBVerTramaJson";
            this.TBVerTramaJson.Size = new System.Drawing.Size(112, 20);
            this.TBVerTramaJson.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Deserializar Json";
            // 
            // TBVerTrama
            // 
            this.TBVerTrama.Location = new System.Drawing.Point(123, 248);
            this.TBVerTrama.Name = "TBVerTrama";
            this.TBVerTrama.Size = new System.Drawing.Size(325, 20);
            this.TBVerTrama.TabIndex = 13;
            // 
            // LbDatosRecibidos
            // 
            this.LbDatosRecibidos.AutoSize = true;
            this.LbDatosRecibidos.Location = new System.Drawing.Point(19, 248);
            this.LbDatosRecibidos.Name = "LbDatosRecibidos";
            this.LbDatosRecibidos.Size = new System.Drawing.Size(88, 13);
            this.LbDatosRecibidos.TabIndex = 12;
            this.LbDatosRecibidos.Text = "Recibido Arduino";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TBEnvTrama);
            this.groupBox3.Controls.Add(this.BtOff);
            this.groupBox3.Controls.Add(this.BtOn);
            this.groupBox3.Controls.Add(this.ImgLed);
            this.groupBox3.Location = new System.Drawing.Point(295, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 284);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enviado Arduino";
            // 
            // TBEnvTrama
            // 
            this.TBEnvTrama.Location = new System.Drawing.Point(111, 197);
            this.TBEnvTrama.Name = "TBEnvTrama";
            this.TBEnvTrama.Size = new System.Drawing.Size(325, 20);
            this.TBEnvTrama.TabIndex = 14;
            // 
            // BtOff
            // 
            this.BtOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtOff.Location = new System.Drawing.Point(155, 31);
            this.BtOff.Name = "BtOff";
            this.BtOff.Size = new System.Drawing.Size(100, 100);
            this.BtOff.TabIndex = 7;
            this.BtOff.Text = "OFF";
            this.BtOff.UseVisualStyleBackColor = true;
            this.BtOff.Click += new System.EventHandler(this.BtOff_Click);
            // 
            // BtOn
            // 
            this.BtOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtOn.Location = new System.Drawing.Point(20, 31);
            this.BtOn.Name = "BtOn";
            this.BtOn.Size = new System.Drawing.Size(100, 100);
            this.BtOn.TabIndex = 6;
            this.BtOn.Text = "ON";
            this.BtOn.UseVisualStyleBackColor = true;
            this.BtOn.Click += new System.EventHandler(this.BtOn_Click);
            // 
            // ImgLed
            // 
            this.ImgLed.Image = global::Prueva_1_arduino.Properties.Resources.led_on_icon_138424;
            this.ImgLed.Location = new System.Drawing.Point(281, 19);
            this.ImgLed.Name = "ImgLed";
            this.ImgLed.Size = new System.Drawing.Size(150, 150);
            this.ImgLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgLed.TabIndex = 0;
            this.ImgLed.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(780, 643);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label velocidad;
        private System.Windows.Forms.Label Puerto;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ProgressBar progressBarConnection;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBVerTramaJson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBVerTrama;
        private System.Windows.Forms.Label LbDatosRecibidos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox ImgLed;
        private System.Windows.Forms.Button BtOff;
        private System.Windows.Forms.Button BtOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBEnvTrama;
    }
}

