using System;
using System.Data;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
using System.ComponentModel;

namespace Elevator
{

    public partial class Form1 : Form
    {
        // The delegates for the animation
        public delegate void Animation(PictureBox source, PictureBox picture, PictureBox box);
        public delegate void Animation2(PictureBox source, PictureBox picture, PictureBox box, PictureBox pictureBox);


        public Animation up = new Animation(Animation_up);
        public Animation down = new Animation(Animation_Down);
        public Animation2 opening = new Animation2(Animation_Open);
        public Animation2 closing = new Animation2(Animation_Close);
        private bool control_panel_btn_paint_7;
        private bool control_panel_btn_paint_6;
        private bool picture6cliked = false;
        private bool picture7cliked = false;
        public static SpeechSynthesizer synth = new SpeechSynthesizer();
        private bool dbinsert_lv1;
        private bool dbinsert_lv0;

        public Form1()
        {
            InitializeComponent();
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.Elevator' table. You can move, or remove it, as needed.
            this.elevatorTableAdapter2.Fill(this.databaseDataSet1.Elevator);


        }





        private static void Voice_ClosingDoors()
        {
            synth.SpeakAsync("Closing Doors!");

        }
        private static void Voice_OpeningDoors()
        {
            synth.SpeakAsync("Opening Doors");
        }

        private static void VoiceGoingUp()
        {
            synth.SpeakAsync("Going Up!");
        }

        private static void VoiceGoingDown()
        {
           
            synth.SpeakAsync("Going down!");
            
        }




        private void PictureBox6_Click(object sender, EventArgs e) //Image click to go to Floor 0
        {
            picture6cliked = true;
            dbinsert_lv0 = true;

            if (pictureBox1.Location.Y == pictureBox4.Location.Y)
            {
                VoiceGoingDown();
            }

            bgw.RunWorkerAsync();
            Refresh();



        }


        private void pictureBox7_Click(object sender, EventArgs e) //Image click to go to Floor 1
        {
            picture7cliked = true;
            dbinsert_lv1 = true;
            if (pictureBox1.Location.Y == RightDoorlv0.Location.Y)
            {
                VoiceGoingUp();
            }
            bgw.RunWorkerAsync();

            Refresh();

        }


        public void button1_Click(object sender, EventArgs e)
        {
            dbinsert_lv1 = true;
            button1.BackColor = Color.Red;
            bgw.RunWorkerAsync();
            
        }





        private void button2_Click(object sender, EventArgs e)
        {
            dbinsert_lv0 = true;
            button2.BackColor = Color.Red;
            bgw.RunWorkerAsync();

        }


        private void timer1_Tick(object sender, EventArgs e) // timer for elevator going up
        {
            if (pictureBox1.Location.Y != pictureBox4.Location.Y) // if the elevator position Y is not at the right door position Y the code will run if the statement is no longer "not true" the elevator will stop moving
            {

                up(pictureBox1, leftdoor, rightdoor); // the delegate for the animation


                lv1sign.Visible = false;
                pictureBox14.Visible = true;
                blankpanelcontrol.Visible = true;
                blanklv1.Visible = true;
                pictureBox11.Visible = true;
                pictureBox11.BringToFront();
                blanksigncp.Visible = true;
                arrowupcp.Visible = true;
                arrowupcp.BringToFront();


            }

            if (pictureBox1.Location.Y == pictureBox4.Location.Y)
            {

                OpenDoorLv1.Enabled = true;
                picture7cliked = false;
                lv1sign.Visible = true;
                GoingUp.Enabled = false;
                pictureBox14.Visible = false;
                blankpanelcontrol.Visible = false;
                blanklv1.Visible = false;
                pictureBox11.Visible = false;
                blanksigncp.Visible = false;
                arrowupcp.Visible = false;
                arrowupcp.SendToBack();
                Voice_OpeningDoors();
                Refresh();

            }



        }


        private void timer2_Tick(object sender, EventArgs e) // timer for elevator going down to lv 0
        {
            if (pictureBox1.Location.Y != RightDoorlv0.Location.Y)
            {
                down(pictureBox1, leftdoor, rightdoor); // the animation using delegate


                pictureBox13.Visible = true;
                pictureBox13.BringToFront();
                blanklv1.Visible = true;
                blankpanelcontrol.Visible = true;
                pictureBox8.Visible = true;
                pictureBox8.BringToFront();
                blanksigncp.Visible = true;
                arrowdowncp.Visible = true;
                arrowdowncp.BringToFront();
                lv0sign.Visible = false;


            }
            // Hiding a image if it interacts with the elevator so that it wont show on top of the elevator when descending
            if (pictureBox8.Bounds.IntersectsWith(pictureBox1.Bounds))
            { pictureBox8.Visible = false; }

            if (pictureBox1.Location.Y == RightDoorlv0.Location.Y)
            {

                OpenDoorLv0.Enabled = true;
                picture6cliked = false;
                lv0sign.Visible = true;
                GoingDown.Enabled = false;
                pictureBox13.Visible = false;
                blanklv1.Visible = false;
                blankpanelcontrol.Visible = false;
                pictureBox8.Visible = false;
                blanksigncp.Visible = false;
                arrowdowncp.Visible = false;
                arrowdowncp.SendToBack();
                Voice_OpeningDoors();
                Refresh();
                

            }




        }

        private void timer1_Tick_1(object sender, EventArgs e) // A constant check so that there wont be any glices when the elevator is moving up or down and a periodic check 

        {

            //Coordonating the ups and downs
               if (button1.BackColor == Color.Red && GoingDown.Enabled == false)    { GoingUp.Enabled = true; }

               if (button2.BackColor == Color.Red && GoingUp.Enabled == false)     { GoingDown.Enabled = true; }

              if (control_panel_btn_paint_6 == true && GoingUp.Enabled == false)   { GoingDown.Enabled = true;}

               if (control_panel_btn_paint_7 == true && GoingDown.Enabled == false)  { GoingUp.Enabled = true;} 

            //No moving when doors are open
               if (pictureBox3.Left != 209 && pictureBox4.Left != 312)      { GoingDown.Enabled = false; }
              
               if (LeftDoorlv0.Left != 209 && RightDoorlv0.Left != 312)     { GoingUp.Enabled = false; }
            
        
              
               // Statement to enable the display windows to the corespunding floor
               if (pictureBox1.Location.Y == RightDoorlv0.Location.Y)
               {
                   ElectricPanelLv0G.Visible = true;
                   ElectricalPanelLv0F1.Visible = true;
                   lv0sign.Visible = true;
               }
               else
               {
                   ElectricPanelLv0G.Visible = false;
                   ElectricalPanelLv0F1.Visible = false;
                   lv0sign.Visible = false;

               }


            if (pictureBox1.Location.Y == pictureBox4.Location.Y)
               {
                   ElectricalPanelLv1F1.Visible = true;
                   ElectricalPanelLv1F0.Visible = true;
                   lv1sign.Visible = true;
               }
               else
               {
                   ElectricalPanelLv1F1.Visible = false;
                   ElectricalPanelLv1F0.Visible = false;
                   lv1sign.Visible = false;

               }

           }





           private void OpenDoorLv0_Tick(object sender, EventArgs e)
           {

               if (LeftDoorlv0.Left != 120)
               {
                   button2.BackColor = Color.White;
                   opening(LeftDoorlv0, RightDoorlv0, leftdoor, rightdoor);

                   Timer.Enabled = true;
               }
               else { OpenDoorLv0.Enabled = false; }
           }


           private void OpenDoorLv1_Tick(object sender, EventArgs e)
           {


               if (pictureBox3.Left != 120)
               {
                   button1.BackColor = Color.White;
                   opening(pictureBox3, pictureBox4, leftdoor, rightdoor);
                   Timer.Enabled = true;

               }
               else { OpenDoorLv1.Enabled = false; }

           }


           private void timer3_Tick(object sender, EventArgs e) // timer for closing doors lv 1
           {

               if (pictureBox3.Left != 209)
               {
                   button1.BackColor = Color.White;
                   closing(pictureBox3, pictureBox4, leftdoor, rightdoor);


               }
               else { CloseDoorsLv1.Enabled = false; }
           }


           private void timer4_Tick(object sender, EventArgs e) // timer for closing doors lv 0
           {
               if (LeftDoorlv0.Left != 209)
               {

                   button2.BackColor = Color.White;
                   closing(LeftDoorlv0, RightDoorlv0, leftdoor, rightdoor);


               }
               else { CloseDoorsLv0.Enabled = false; }
           }

           //Coordonating the timer for closing of the doors
           private void Timer_Tick(object sender, EventArgs e)
           {
               Voice_ClosingDoors();
               if (OpenDoorLv1.Enabled == false)
               { CloseDoorsLv1.Enabled = true; }

               if (OpenDoorLv0.Enabled == false)
               {
                   CloseDoorsLv0.Enabled = true;

               }
               Timer.Enabled = false;

           }



           private void Log_Click(object sender, EventArgs e)
           {
               DataSet.Visible = true;
               this.Size = new Size(1372, 750); // making the form bigger 

               
               string connetionString = null;
               OleDbConnection connection;
               OleDbDataAdapter oledbAdapter;
               connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Dany\source\repos\Elevator\Elevator\Database.mdb";
               
               try
               {
                   connection = new OleDbConnection(connetionString);
                   connection.Open();

                   OleDbCommand command = new OleDbCommand();
                   command.Connection = connection;
                   command.CommandText = "Select * from Elevator";
                   DataTable data = new DataTable();
                   data.Clear();
                   oledbAdapter = new OleDbDataAdapter(command);
                   oledbAdapter.Fill(data);
                   DataSet.DataSource = data;
                   connection.Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.ToString());
               }
           }



           // The Paint Events for the red Border
           private void PictureBox7_Paint(object sender, PaintEventArgs e)
           {

               if (picture7cliked == true)
               {
                ControlPaint.DrawBorder(e.Graphics, pictureBox7.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
                control_panel_btn_paint_7 = true;
               }
               else
               {
                ControlPaint.DrawBorder(e.Graphics, pictureBox7.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
                control_panel_btn_paint_7 = false;
                }
            }


           private void pictureBox6_Paint(object sender, PaintEventArgs e)
           {

               if (picture6cliked == true)
               {
                ControlPaint.DrawBorder(e.Graphics, pictureBox6.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
                control_panel_btn_paint_6 = true;

                }
                else
                {
                ControlPaint.DrawBorder(e.Graphics, pictureBox6.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
                control_panel_btn_paint_6 = false;
                }
            }



        

        public static void Animation_up(PictureBox A, PictureBox B, PictureBox C)
           {
               A.Location = new Point(A.Location.X + 0, A.Location.Y - 2);
               B.Location = new Point(B.Location.X + 0, B.Location.Y - 2);
               C.Location = new Point(C.Location.X + 0, C.Location.Y - 2);
           }


           public static void Animation_Down(PictureBox A, PictureBox B, PictureBox C)
           {
               A.Location = new Point(A.Location.X + 0, A.Location.Y + 2);
               B.Location = new Point(B.Location.X + 0, B.Location.Y + 2);
               C.Location = new Point(C.Location.X + 0, C.Location.Y + 2);

           }

           public static void Animation_Open(PictureBox A, PictureBox B, PictureBox C, PictureBox D)
           {
               A.Location = new Point(A.Location.X - 1, A.Location.Y + 0);
               B.Location = new Point(B.Location.X + 1, B.Location.Y + 0);
               C.Location = new Point(C.Location.X - 1, C.Location.Y + 0);
               D.Location = new Point(D.Location.X + 1, D.Location.Y + 0);

           }

           public static void Animation_Close(PictureBox A, PictureBox B, PictureBox C, PictureBox D)
           {
               A.Location = new Point(A.Location.X + 1, A.Location.Y + 0);
               B.Location = new Point(B.Location.X - 1, B.Location.Y + 0);
               C.Location = new Point(C.Location.X + 1, C.Location.Y + 0);
               D.Location = new Point(D.Location.X - 1, D.Location.Y + 0);
           }



           // The control panel opening and closing buttons
           private void CloseDoors_Click(object sender, EventArgs e)
           {


               if (pictureBox1.Location.Y == RightDoorlv0.Location.Y && OpenDoorLv0.Enabled == false || OpenDoorLv0.Enabled == false)
               {
                   if (LeftDoorlv0.Left != 209 || pictureBox3.Left != 209)
                   {
                       Voice_ClosingDoors();
                   }
                   CloseDoorsLv0.Enabled = true;
               }
               else
               {
                   if (LeftDoorlv0.Left != 209 || pictureBox3.Left != 209)
                   {
                       Voice_ClosingDoors();
                   }
                   CloseDoorsLv1.Enabled = true;
               }

           }

           private void OpenDoors_Click(object sender, EventArgs e)
           {
               if (GoingUp.Enabled == false && GoingDown.Enabled == false)
               {
                   if (pictureBox1.Bounds.IntersectsWith(RightDoorlv0.Bounds) == true && CloseDoorsLv0.Enabled == false)
                   {
                       Voice_OpeningDoors();
                       OpenDoorLv0.Enabled = true;
                   }
                   if (pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds) == true && CloseDoorsLv1.Enabled == false)
                   {
                       Voice_OpeningDoors();

                       OpenDoorLv1.Enabled = true;
                   }
               }
           }


        // Using the background worker to complete the transaction to the database
        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            currentDate.ToString("d/m/yyyy");
            string connetionString = null;
            OleDbConnection connection;
            connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Dany\source\repos\Elevator\Elevator\Database.mdb";
            if (dbinsert_lv1 == true)
            {
                try
                {
                    connection = new OleDbConnection(connetionString);
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.CommandText = "insert into Elevator( Request, Floor, [Date and time]) values( 'Request at floor 1', '1', @data)";
                    command.Parameters.AddWithValue("@data", currentDate);
                    command.Connection = connection;

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                dbinsert_lv1 = false;

            }

            if (dbinsert_lv0 == true)
            {

                try
                {
                    connection = new OleDbConnection(connetionString);
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into Elevator( Request, Floor, [Date and time]) values( 'Request at floor 0', '0', @data)";
                    command.Parameters.AddWithValue("@data", currentDate);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                 dbinsert_lv0 = false;


            }

        }
    }
   }




