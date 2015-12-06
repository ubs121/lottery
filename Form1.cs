using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace lottery {
	public class Form1 : Form {
		double xspeed,yspeed,newyspeed,startingypos;
		double newxpos,newypos,oldxpos,oldypos;
		double newx,oldx,newy,oldy;
		int xmouse,ymouse;
		double acc; // acceleration
		double t;
		public static int ground = 500;		
		bool collisiony;
		bool dragging = false;
		bool trace = true;

		Ballinstance b1 = new Ballinstance();
		

		private System.Timers.Timer timer;
		private PictureBox ball;
		private MainMenu mainMenu1;
		private MenuItem menuItem1;
		private MenuItem menuItem11;
		private MenuItem menuItem12;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label n0;
		private System.Windows.Forms.Label n1;
		private System.Windows.Forms.Label n2;
		private System.Windows.Forms.Label n3;
		private System.Windows.Forms.Label n4;
		private System.Windows.Forms.Label n5;
		private System.Windows.Forms.Label n6;
		private System.Windows.Forms.Label n7;
		private System.Windows.Forms.Label n8;
		private System.Windows.Forms.Label n9;
		
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PictureBox pic0;
		private System.Windows.Forms.PictureBox pic1;
		private System.Windows.Forms.PictureBox pic2;
		private System.Windows.Forms.PictureBox pic3;
		private System.Windows.Forms.PictureBox pic4;
		private System.Windows.Forms.PictureBox pic5;
		private System.Windows.Forms.PictureBox pic6;
		private System.Windows.Forms.PictureBox pic7;
		private System.ComponentModel.IContainer components;

		private Label[] labels;
		private PictureBox[] boxes;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		//private DateTime startTime;
		int whichBox = 7;

		public Form1() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			labels = new Label[] {n0, n1, n2, n3, n4, n5, n6, n7, n8, n9};
			boxes = new PictureBox[] {pic0, pic1,pic2,pic3,pic4,pic5,pic6,pic7};
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.timer = new System.Timers.Timer();
			this.ball = new System.Windows.Forms.PictureBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.pic0 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pic1 = new System.Windows.Forms.PictureBox();
			this.pic2 = new System.Windows.Forms.PictureBox();
			this.pic3 = new System.Windows.Forms.PictureBox();
			this.pic4 = new System.Windows.Forms.PictureBox();
			this.pic5 = new System.Windows.Forms.PictureBox();
			this.pic6 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.n0 = new System.Windows.Forms.Label();
			this.n1 = new System.Windows.Forms.Label();
			this.n2 = new System.Windows.Forms.Label();
			this.n3 = new System.Windows.Forms.Label();
			this.n4 = new System.Windows.Forms.Label();
			this.n5 = new System.Windows.Forms.Label();
			this.n6 = new System.Windows.Forms.Label();
			this.n7 = new System.Windows.Forms.Label();
			this.n8 = new System.Windows.Forms.Label();
			this.n9 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.label14 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pic7 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 10;
			this.timer.SynchronizingObject = this;
			this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
			// 
			// ball
			// 
			this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
			this.ball.Location = new System.Drawing.Point(520, 80);
			this.ball.Name = "ball";
			this.ball.Size = new System.Drawing.Size(56, 56);
			this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ball.TabIndex = 0;
			this.ball.TabStop = false;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3,
																					  this.menuItem2,
																					  this.menuItem12,
																					  this.menuItem11});
			this.menuItem1.Text = "&Лотто";
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 2;
			this.menuItem12.Text = "-";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 3;
			this.menuItem11.Text = "&Гарах";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// pic0
			// 
			this.pic0.Image = ((System.Drawing.Image)(resources.GetObject("pic0.Image")));
			this.pic0.Location = new System.Drawing.Point(32, 8);
			this.pic0.Name = "pic0";
			this.pic0.Size = new System.Drawing.Size(70, 70);
			this.pic0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic0.TabIndex = 1;
			this.pic0.TabStop = false;
			this.pic0.Tag = "0";
			this.pic0.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.BackColor = System.Drawing.Color.Red;
			this.panel1.Location = new System.Drawing.Point(632, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(8, 608);
			this.panel1.TabIndex = 2;
			// 
			// pic1
			// 
			this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
			this.pic1.Location = new System.Drawing.Point(104, 8);
			this.pic1.Name = "pic1";
			this.pic1.Size = new System.Drawing.Size(70, 70);
			this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic1.TabIndex = 3;
			this.pic1.TabStop = false;
			this.pic1.Tag = "1";
			this.pic1.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// pic2
			// 
			this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
			this.pic2.Location = new System.Drawing.Point(176, 8);
			this.pic2.Name = "pic2";
			this.pic2.Size = new System.Drawing.Size(70, 70);
			this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic2.TabIndex = 4;
			this.pic2.TabStop = false;
			this.pic2.Tag = "2";
			this.pic2.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// pic3
			// 
			this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
			this.pic3.Location = new System.Drawing.Point(248, 8);
			this.pic3.Name = "pic3";
			this.pic3.Size = new System.Drawing.Size(70, 70);
			this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic3.TabIndex = 5;
			this.pic3.TabStop = false;
			this.pic3.Tag = "3";
			this.pic3.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// pic4
			// 
			this.pic4.Image = ((System.Drawing.Image)(resources.GetObject("pic4.Image")));
			this.pic4.Location = new System.Drawing.Point(320, 8);
			this.pic4.Name = "pic4";
			this.pic4.Size = new System.Drawing.Size(70, 70);
			this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic4.TabIndex = 6;
			this.pic4.TabStop = false;
			this.pic4.Tag = "4";
			this.pic4.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// pic5
			// 
			this.pic5.Image = ((System.Drawing.Image)(resources.GetObject("pic5.Image")));
			this.pic5.Location = new System.Drawing.Point(392, 8);
			this.pic5.Name = "pic5";
			this.pic5.Size = new System.Drawing.Size(70, 70);
			this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic5.TabIndex = 7;
			this.pic5.TabStop = false;
			this.pic5.Tag = "5";
			this.pic5.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// pic6
			// 
			this.pic6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic6.Image = ((System.Drawing.Image)(resources.GetObject("pic6.Image")));
			this.pic6.Location = new System.Drawing.Point(464, 8);
			this.pic6.Name = "pic6";
			this.pic6.Size = new System.Drawing.Size(70, 70);
			this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic6.TabIndex = 8;
			this.pic6.TabStop = false;
			this.pic6.Tag = "6";
			this.pic6.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(648, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 24);
			this.label2.TabIndex = 11;
			this.label2.Text = "1,000₮ ярианы эрх ";
			// 
			// n0
			// 
			this.n0.BackColor = System.Drawing.Color.White;
			this.n0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.n0.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.n0.ForeColor = System.Drawing.Color.Red;
			this.n0.Location = new System.Drawing.Point(32, 560);
			this.n0.Name = "n0";
			this.n0.Size = new System.Drawing.Size(56, 56);
			this.n0.TabIndex = 13;
			this.n0.Text = "0";
			this.n0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// n1
			// 
			this.n1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.n1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.n1.ForeColor = System.Drawing.Color.Red;
			this.n1.Location = new System.Drawing.Point(88, 560);
			this.n1.Name = "n1";
			this.n1.Size = new System.Drawing.Size(56, 56);
			this.n1.TabIndex = 14;
			this.n1.Text = "1";
			this.n1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// n2
			// 
			this.n2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.n2.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.n2.ForeColor = System.Drawing.Color.Red;
			this.n2.Location = new System.Drawing.Point(144, 560);
			this.n2.Name = "n2";
			this.n2.Size = new System.Drawing.Size(56, 56);
			this.n2.TabIndex = 15;
			this.n2.Text = "2";
			this.n2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// n3
			// 
			this.n3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.n3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.n3.ForeColor = System.Drawing.Color.Red;
			this.n3.Location = new System.Drawing.Point(200, 560);
			this.n3.Name = "n3";
			this.n3.Size = new System.Drawing.Size(56, 56);
			this.n3.TabIndex = 16;
			this.n3.Text = "3";
			this.n3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// n4
			// 
			this.n4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.n4.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.n4.ForeColor = System.Drawing.Color.Red;
			this.n4.ImageList = this.imageList1;
			this.n4.Location = new System.Drawing.Point(256, 560);
			this.n4.Name = "n4";
			this.n4.Size = new System.Drawing.Size(56, 56);
			this.n4.TabIndex = 17;
			this.n4.Text = "4";
			this.n4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// n5
			// 
			this.n5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.n5.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.n5.ForeColor = System.Drawing.Color.Red;
			this.n5.Location = new System.Drawing.Point(312, 560);
			this.n5.Name = "n5";
			this.n5.Size = new System.Drawing.Size(56, 56);
			this.n5.TabIndex = 18;
			this.n5.Text = "5";
			this.n5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// n6
			// 
			this.n6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.n6.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.n6.ForeColor = System.Drawing.Color.Red;
			this.n6.Location = new System.Drawing.Point(368, 560);
			this.n6.Name = "n6";
			this.n6.Size = new System.Drawing.Size(56, 56);
			this.n6.TabIndex = 19;
			this.n6.Text = "6";
			this.n6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// n7
			// 
			this.n7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.n7.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.n7.ForeColor = System.Drawing.Color.Red;
			this.n7.Location = new System.Drawing.Point(424, 560);
			this.n7.Name = "n7";
			this.n7.Size = new System.Drawing.Size(56, 56);
			this.n7.TabIndex = 20;
			this.n7.Text = "7";
			this.n7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// n8
			// 
			this.n8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.n8.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.n8.ForeColor = System.Drawing.Color.Red;
			this.n8.Location = new System.Drawing.Point(480, 560);
			this.n8.Name = "n8";
			this.n8.Size = new System.Drawing.Size(56, 56);
			this.n8.TabIndex = 21;
			this.n8.Text = "8";
			this.n8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// n9
			// 
			this.n9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.n9.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.n9.ForeColor = System.Drawing.Color.Red;
			this.n9.Location = new System.Drawing.Point(536, 560);
			this.n9.Name = "n9";
			this.n9.Size = new System.Drawing.Size(56, 56);
			this.n9.TabIndex = 22;
			this.n9.Text = "9";
			this.n9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(648, 96);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(184, 32);
			this.label13.TabIndex = 23;
			this.label13.Text = "********";
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(648, 8);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(184, 48);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox9.TabIndex = 24;
			this.pictureBox9.TabStop = false;
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem8});
			this.menuItem2.Text = "Жагсаалтад нэмэх";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(648, 544);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(184, 48);
			this.label14.TabIndex = 25;
			this.label14.Text = "Нийт 100,000 азтан";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(70, 70);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pic7
			// 
			this.pic7.BackColor = System.Drawing.Color.White;
			this.pic7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic7.Image = ((System.Drawing.Image)(resources.GetObject("pic7.Image")));
			this.pic7.Location = new System.Drawing.Point(536, 8);
			this.pic7.Name = "pic7";
			this.pic7.Size = new System.Drawing.Size(70, 70);
			this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic7.TabIndex = 9;
			this.pic7.TabStop = false;
			this.pic7.Tag = "7";
			this.pic7.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(648, 168);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 32);
			this.label1.TabIndex = 27;
			this.label1.Text = "********";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(648, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 24);
			this.label3.TabIndex = 26;
			this.label3.Text = "10,000₮ ярианы эрх ";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(648, 232);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(184, 32);
			this.label4.TabIndex = 29;
			this.label4.Text = "********";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Lime;
			this.label5.Location = new System.Drawing.Point(648, 208);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(176, 24);
			this.label5.TabIndex = 28;
			this.label5.Text = "100,000₮ ярианы эрх ";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(648, 304);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(184, 32);
			this.label6.TabIndex = 31;
			this.label6.Text = "********";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(648, 280);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(176, 24);
			this.label7.TabIndex = 30;
			this.label7.Text = "1,000,000₮ ярианы эрх ";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(648, 360);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(176, 24);
			this.label8.TabIndex = 32;
			this.label8.Text = "Бээжингийн Олимп";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(656, 392);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(168, 144);
			this.textBox1.TabIndex = 33;
			this.textBox1.Text = "";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "Шинээр эхлэх";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "1,000T";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "10,000T";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 2;
			this.menuItem6.Text = "100,000T";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 3;
			this.menuItem7.Text = "1,000,000T";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 4;
			this.menuItem8.Text = "Бээжин тасалбар";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(840, 629);
			this.ControlBox = false;
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.n9);
			this.Controls.Add(this.n8);
			this.Controls.Add(this.n7);
			this.Controls.Add(this.n6);
			this.Controls.Add(this.n5);
			this.Controls.Add(this.n4);
			this.Controls.Add(this.n3);
			this.Controls.Add(this.n2);
			this.Controls.Add(this.n1);
			this.Controls.Add(this.n0);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pic6);
			this.Controls.Add(this.pic5);
			this.Controls.Add(this.pic4);
			this.Controls.Add(this.pic3);
			this.Controls.Add(this.pic2);
			this.Controls.Add(this.pic1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pic0);
			this.Controls.Add(this.ball);
			this.Controls.Add(this.pic7);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "МобиЛотто";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new Form1());
		}

		private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
			b1.play(ref xspeed,ref yspeed,ref newyspeed,ref startingypos,ref newxpos,ref newypos,ref oldxpos,ref oldypos,ref newx,ref oldx,ref newy,ref oldy,ref acc,ref t,ref xmouse,ref ymouse,ref dragging,ref trace,ref collisiony);
			
			ball.Left = (int)newxpos;
			ball.Top = (int)(Form1.ground - newypos);

			if (ball.Top >= Form1.ground && timer1.Enabled) {
				//boxes[whichBox].Image = imageList1.Images[CheckFall()];
			}
		}
		
		private int CheckFall() {
			int x = (ball.Left + ball.Width) / 2;
			int n = 0;
			//int y = (ball.Right + ball.Height) / 2;
			int i = 0;
			while (x < labels[i].Left + labels[i].Width) {
				n = Convert.ToInt32(labels[i].Text);
				i++;
			}
			return numbers[i];
		}
		private void Form1_Load(object sender, System.EventArgs e) {
			t = 0;
			acc = 10;
		}

		private void menuItem11_Click(object sender, System.EventArgs e) {
			Application.Exit();
		}

		private void menuNewWinner_Click(object sender, System.EventArgs e) {
		
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e) {
			// Pick a ball randomly
			// Random rnd = new Random(DateTime.Now.Second);
			// Choice = rnd.Next(1,numberofballs);	
			dragging = true;
			if (e.X > 580)
				newxpos = 580;
			else
				newxpos  = e.X;
			newypos  = this.Height - e.Y - ball.Height - 55;
			xmouse = e.X;
			ymouse = e.Y;
		}


		private void Form1_MouseUp(object sender, MouseEventArgs e) {
			if (dragging)
				timer1.Enabled = false;

			dragging = false;
		}


		
		private void Form1_MouseMove(object sender, MouseEventArgs e) {	
			xmouse = e.X;
			ymouse = e.Y;
			if (dragging) {
				timer1.Enabled = true;
				newxpos  = e.X;
				newypos  = this.Height - e.Y - ball.Height - 55;
			}
		}

		private void pictureBox_Click(object sender, System.EventArgs e) {
			whichBox = Convert.ToInt32(((PictureBox)sender).Tag);
			((PictureBox)sender).Image = imageList1.Images[10];
		}

		private int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};		
		
		private void ShakeBottom() {			
			Random rand = new Random();			
			for (int j = 0; j<50; j++) {
				// take 2 random index
				int i1 = rand.Next(10);
				int i2 = rand.Next(10);
				int temp = numbers[i1];
				numbers[i1] = numbers[i2];
				numbers[i2] = temp;
				for (int l=0; l < 10; l++)
					labels[l].Text = numbers[l].ToString();
			}				
		}

		private void timer1_Tick(object sender, System.EventArgs e) {
			ShakeBottom();
			/*
			TimeSpan diff = DateTime.Now.Subtract(startTime);
			if (diff.Seconds > 3)
				timer1.Enabled = false;*/
		}
	}

	public class Ballinstance {
		int xpos,ypos;
		
		public Ballinstance() {
		}

		public void play(ref double xspeed,ref double yspeed,ref double newyspeed,ref double startingypos,ref double newxpos,ref double newypos,ref double oldxpos,ref double oldypos,ref double newx,ref double oldx,ref double newy,ref double oldy,ref double acc,ref double t,ref int xmouse,ref int ymouse,ref bool dragging,ref bool trace,ref bool collisiony) {
			xpos = (int)newxpos;
			ypos = (int)newypos;
		
			// This code will be visited 50 times per second while dragging
			if (dragging) {
				// Grip the center of the ball when dragging
				xpos = xmouse;
				ypos = ymouse;

				// While dragging the starting y-axis position of the ball is ball.Top
				startingypos = Form1.ground - ypos;

				// Calculate the x and y speed based on the mouse movement within 20 msec
				// speed = distance/time  ->  time = 20 millisecond
				// the speed is the change in the displacement with respect to time which
				// is already running (the code is within the timer), so we don't have to divide 
				// by time.
				newx = xpos;
				newy = Form1.ground  - ypos;
				xspeed = (newx - oldx)/1;
				yspeed = (newy - oldy)/1;
				oldx = newx;
				oldy = newy;

				// The time -while dragging- will not start yet
				t = 0;	
			} 
			else {
				// This code will be visited 50 times per second while not dragging
				// The ball position is where it's last dragged
				oldxpos = xpos;
				// X-axis motion
				if(xpos < 580 && 0 < xpos) {
					newxpos = oldxpos + xspeed;
				} 
				else {
					// Here the ball will hits the wall
					// Ball xspeed will decrease every time it hits the wall
					// Minus sign: to change the ball direction when it collides with the wall
					xspeed *= -0.9;	// Wall resistance	
					newxpos = oldxpos + xspeed;
				}
		
				// Y-axis motion
				if(0 < newypos || collisiony) {				 
					newyspeed = yspeed - (acc*t);
					newypos = startingypos + ((yspeed*t)- 0.5*acc*(t*t));
					collisiony = false;
				} 
				else {
					// Here the ball will hits the ground
					// Initialize the ball variables again
					startingypos = -1;	
					// Here set startingypos=-1 not 0, because if 0 newypos will be 0 every time the ball 
					// Hits the ground so no bouncing will happens to the ball, evaluate to the 
					// eguation below for newypos when t = 0
					t = 0;
					// Ball yspeed will decrease every time it hits the ground
					// 0.75 is the elasticity coefficient - assumption
					// The initial speed(yspeed) is 0.75 of the final speed(newyspeed)
					yspeed = newyspeed * -0.75;
					newypos = startingypos + ((yspeed*t)- 0.5*acc*(t*t));
					collisiony = true;
				}
				// Always
				// Ball xspeed will always decrease, even if it didn't hit the wall
				xspeed *= 0.99;	// Air resistance

				if(xspeed > -0.5 && xspeed < 0) {
					xspeed = 0;
					// MessageBox.Show("Stopped!");
				}
				
				#region Explination of xspeed condition above
				// This condition is to stop the ball when it heading to the left, you can notice that removeing
				// this condition will make the ball never stop while its heading to the left until it will
				// hit the left wall, to know why, run the simulation under the debuging mode and watch
				// the value of newxpos
				// newxpos = oldxpos + xspeed
				// when 0 < xspeed < 1 (the ball heading right), ball.left = (int)newxpos, the casting 
				// forces the ball left position value to be the same as its previous value, because oldxpos and newxpos are equals, and hence the ball will stop.
				// but when -1 < xspeed < 0 (the ball heading left), ball.left = (int)newxpos, the casting
				// here will not work correctly, because the value of oldxpos(which is integer value see line 185) will always 
				// be decremented by the xspeed, this will force the newxpos also to be always decremented by xspeed and hence
				// ball.left will always decremented by 1 (int) casting, and hence the ball will never stop.
				#endregion

				// Update the ball position
				xpos = (int)newxpos;
				ypos = (int)(Form1.ground - newypos);
				// Increase the time
				t += 0.3;
			}
		}

	}
}
