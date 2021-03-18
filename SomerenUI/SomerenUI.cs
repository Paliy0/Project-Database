using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        DrinkService drinkService;
        LecturerService lecturerService;
        RoomService roomService;
        StudentService studentService;

        List<Drink> drinkList;

        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            if (panelName == "Dashboard")
            {
                // hide all other panels
                pnlStudents.Hide();
                pnlLecturers.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlLecturers.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();

                // show students
                pnlStudents.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    studentService = new StudentService();
                    List<Student> studentList = studentService.GetStudents();

                    // clear the listiew before filling it again
                    listViewStudents.Items.Clear();
                    listViewStudents.View = View.Details;



                    foreach (Student student in studentList)
                    {
                        ListViewItem li = new ListViewItem(student.Number.ToString()); //first column
                        li.SubItems.Add(student.Name);
                        li.SubItems.Add(student.LastName);
                        li.SubItems.Add(student.BirthDate.ToString("dd/MM/yyyy"));
                        listViewStudents.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
            else if (panelName == "Lecturers") //Lecturer Panel
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();

                // show Lecturers
                pnlLecturers.Show();
                try
                {
                    // fill the students listview within the students panel with a list of students
                    lecturerService = new LecturerService();
                    List<Teacher> teacherList = lecturerService.GetTeachers();

                    // clear the listview before filling it again
                    listViewLecturers.Items.Clear();
                    listViewLecturers.View = View.Details;


                    foreach (Teacher teacher in teacherList)
                    {
                        ListViewItem li = new ListViewItem(teacher.Number.ToString()); //first column
                        li.SubItems.Add(teacher.Name);
                        li.SubItems.Add(teacher.LastName);
                        li.SubItems.Add(teacher.Supervisor);
                        listViewLecturers.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
                }
            }
            else if (panelName == "Rooms")
                //Room Panel
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlLecturers.Hide();
                pnlStudents.Hide();
                pnlDrinks.Hide();

                pnlRooms.Show();
                try
                {
                    roomService = new RoomService();
                    List<Room> roomList = roomService.GetRooms();


                    listViewRooms.Items.Clear();
                    listViewRooms.View = View.Details;

                    foreach (Room room in roomList)
                    {
                        ListViewItem li = new ListViewItem(room.Number.ToString()); //first column
                        li.SubItems.Add(room.Capacity.ToString());
                        li.SubItems.Add(room.Type.ToString());
                        listViewRooms.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
                }
            }
            else if (panelName == "Drinks") //Room Panel
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlLecturers.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();

                pnlDrinks.Show();
                try
                {
                    drinkService = new DrinkService();
                    drinkList = drinkService.GetDrinks();


                    listViewDrinks.Items.Clear();
                    listViewDrinks.View = View.Details;

                    foreach (Drink drink in drinkList)
                    {
                        ListViewItem li = new ListViewItem(drink.ID.ToString()); //first column
                        li.SubItems.Add(drink.Name);
                        li.SubItems.Add(drink.Token.ToString());
                        li.SubItems.Add(drink.Stock.ToString());

                        if (drink.Stock >= 10)
                        {
                            li.SubItems.Add("✔️");
                        }
                        else
                        {
                            li.SubItems.Add("⚠️");

                        }
                        listViewDrinks.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
                }
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Lecturers");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks");
        }

        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            /*
            if (listViewDrinks.SelectedItems.Count > 0)
            {
                Drink drink = (Drink)listViewDrinks.SelectedItems[0].Tag;
                drinkService.DeleteDrink(drink);
            }
            */
        }
    }
}
