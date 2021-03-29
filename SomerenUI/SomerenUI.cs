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
        OrderService orderService;
        ActivityService activityService;

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
                pnlCashRegister.Hide();
                pnlReport.Hide();
                pnlSupervisors.Hide();
                pnlActivities.Hide();

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
                pnlCashRegister.Hide();
                pnlReport.Hide();
                pnlSupervisors.Hide();
                pnlActivities.Hide();

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
                pnlCashRegister.Hide();
                pnlReport.Hide();
                pnlSupervisors.Hide();
                pnlActivities.Hide();

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
                pnlCashRegister.Hide();
                pnlReport.Hide();
                pnlSupervisors.Hide();
                pnlActivities.Hide();

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
                pnlCashRegister.Hide();
                pnlReport.Hide();
                pnlSupervisors.Hide();
                pnlActivities.Hide();

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
            else if (panelName == "Cash Register")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlLecturers.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();
                pnlReport.Hide();
                pnlSupervisors.Hide();
                pnlActivities.Hide();


                pnlCashRegister.Show();
                try
                {
                    drinkService = new DrinkService();
                    drinkList = drinkService.GetDrinks();


                    listViewDrinks2.Items.Clear();
                    listViewDrinks2.View = View.Details;

                    foreach (Drink drink in drinkList)
                    {
                        ListViewItem li = new ListViewItem(drink.ID.ToString()); //first column
                        li.SubItems.Add(drink.Name);
                        li.SubItems.Add(drink.Token.ToString());
                        li.SubItems.Add(drink.Stock.ToString());
                        li.Tag = drink;

                        if (drink.Stock >= 10)
                        {
                            li.SubItems.Add("✔️");
                        }
                        else
                        {
                            li.SubItems.Add("⚠️");

                        }
                        listViewDrinks2.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
                }

                try
                {
                    // fill the students listview within the students panel with a list of students
                    studentService = new StudentService();
                    List<Student> studentList = studentService.GetStudents();

                    // clear the listiew before filling it again
                    listViewStudents2.Items.Clear();
                    listViewStudents2.View = View.Details;



                    foreach (Student student in studentList)
                    {
                        ListViewItem li = new ListViewItem(student.Number.ToString()); //first column
                        li.SubItems.Add(student.Name);
                        li.SubItems.Add(student.LastName);
                        li.SubItems.Add(student.BirthDate.ToString("dd/MM/yyyy"));
                        li.Tag = student;
                        listViewStudents2.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }

            }
            else if (panelName == "Report")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlLecturers.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();
                pnlCashRegister.Hide();
                pnlSupervisors.Hide();
                pnlActivities.Hide();

                pnlReport.Show();
                listViewReport.Items.Clear();
                listViewReport.View = View.Details;
            }
            else if (panelName == "Activities")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlLecturers.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();
                pnlCashRegister.Hide();
                pnlReport.Hide();

                // show activities
                pnlActivities.Show();

                try
                {

                    ActivityService activityService = new ActivityService();
                    List<Activity> ActivityList = activityService.GetActivities();

                    // clear the listiew before filling it again
                    listViewActivities.Items.Clear();
                    listViewActivities.View = View.Details;



                    foreach (Activity activities in ActivityList)
                    {
                        ListViewItem li = new ListViewItem(activities.ID.ToString()); //first column
                        li.SubItems.Add(activities.Description);
                        li.SubItems.Add(activities.StartDate.ToString("dd/MM/yyyy"));
                        li.SubItems.Add(activities.EndDate.ToString("dd/MM/yyyy"));
                        listViewActivities.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Activities: " + e.Message);
                }
            }
            else if (panelName == "Supervisors")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlLecturers.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();
                pnlCashRegister.Hide();
                pnlReport.Hide();
                pnlActivities.Hide();

                pnlSupervisors.Show();

                //display activities
                try
                {
                    ActivityService activityService = new ActivityService();
                    List<Activity> ActivityList = activityService.GetActivities();

                    // clear the listiew before filling it again
                    listViewSupervisors.Items.Clear();
                    listViewSupervisors.View = View.Details;

                    foreach (Activity activities in ActivityList)
                    {
                        ListViewItem li = new ListViewItem(activities.ID.ToString()); //first column
                        li.SubItems.Add(activities.Description);
                        li.SubItems.Add(activities.StartDate.ToString("dd/MM/yyyy"));
                        li.SubItems.Add(activities.EndDate.ToString("dd/MM/yyyy"));
                        li.Tag = activities;
                        listViewSupervisors.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Activities: " + e.Message);
                }

                //display supervisors
                try
                {
                    SupervisorService supervisorService = new SupervisorService();
                    List<Supervisor> SupervisorList = supervisorService.GetSupervisors();

                    // clear the listiew before filling it again
                    listViewSupervisors2.Items.Clear();
                    listViewSupervisors2.View = View.Details;

                    foreach (Supervisor supervisor in SupervisorList)
                    {
                        ListViewItem li = new ListViewItem(supervisor.ActivityId.ToString()); //first column
                        li.SubItems.Add(supervisor.TeacherID.ToString());
                        li.SubItems.Add(supervisor.FirstName);
                        li.SubItems.Add(supervisor.LastName);
                        li.Tag = supervisor;
                        listViewSupervisors2.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Supervisors: " + e.Message);
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

        private void drinkSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks");
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Cash Register");
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Report");
        }

        private void supervisorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Supervisors");
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = (Student)listViewStudents2.SelectedItems[0].Tag;

                orderService = new OrderService();

                foreach (ListViewItem item in listViewDrinks2.SelectedItems)
                {
                    orderService.CreateOrder((Drink)item.Tag, student);
                }

                MessageBox.Show("Purchase successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong with the purchase: " + ex.Message);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (CheckDates())
            {
                try
                {
                    orderService = new OrderService();
                    Order order = new Order();

                    lblReport.Text = $"Sales: {order.Sold}, Turnover: {orderService.Turnover}, Number of Customers: {orderService}";
                    /*
                    orderService = new OrderService();
                    List<Order> orderList = orderService.CreateReport();

                    foreach (Order order in orderList)
                    {
                        ListViewItem li = new ListViewItem(order.Sold.ToString());
                        li.SubItems.Add(orderService.Turnover.ToString());
                        li.SubItems.Add(order.NrOfStudents.ToString());
                        li.Tag = order;
                        listViewReport.Items.Add(li);
                    }
                    */
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + ex.Message);
                }
            }
        }

        public bool CheckDates()
        {
            DateTime startDate = datePickerStart.Value;
            DateTime endDate = datePickerEnd.Value;

            if (endDate >= startDate)
            {
                if (endDate.Date <= DateTime.Now.Date)
                {
                    lblResult.Text = DateTime.Now.Date.ToString();
                }
                else
                {
                    lblResult.Text = "Please Choose an end date before the current date";
                    return false;
                }
            }
            else
            {
                lblResult.Text = "Please choose an end date after the start date";
                return false;
            }
            return true;
        }

        private void btnChangeActivity_Click(object sender, EventArgs e)
        {
            if (listViewActivities.SelectedItems.Count > 0)
                return;

            Activity activities = (Activity)listViewActivities.SelectedItems[0].Tag;

            activities.Description = txtDescription.Text;
            activities.StartDate = DateTime.Parse(txtStart.Text);
            activities.EndDate = DateTime.Parse(txtEnd.Text);

            activityService.ChangeActivity(activities);

            List<Activity> ActivityList = activityService.GetActivities();
        }

        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewActivities.SelectedItems.Count >= 0)
            {
                Activity activities = (Activity)listViewActivities.SelectedItems[0].Tag;

                txtDescription.Text = activities.Description;
                txtStart.Text = activities.StartDate.ToString();
                txtEnd.Text = activities.EndDate.ToString();
            }

        }

        private void btnDeleteActivity_Click(object sender, EventArgs e)
        {
            if (listViewActivities.SelectedItems.Count > 0)
            {
                Activity activities = (Activity)listViewActivities.SelectedItems[0].Tag;

                activityService.DeleteActivity(activities);

                List<Activity> ActivityList = activityService.GetActivities();
            }

        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            Activity activities = new Activity();

            activities.Description = txtDescription.Text;
            activities.StartDate = DateTime.Parse(txtStart.Text);
            activities.EndDate = DateTime.Parse(txtEnd.Text);

            activityService.AddActivity(activities);
        }

        private void btnDeleteSupervisor_Click(object sender, EventArgs e)
        {
            Supervisor supervisor = (Supervisor)listViewSupervisors2.SelectedItems[0].Tag;
            Activity activity = (Activity)listViewSupervisors.SelectedItems[0].Tag;

            if (listViewSupervisors.SelectedItems.Count > 0 && listViewSupervisors2.SelectedItems.Count > 0)
            {
                ActivityService activityService = new ActivityService();
                SupervisorService supervisorService = new SupervisorService();

                DialogResult confirmDelete = MessageBox.Show($"Are you sure you want to remove {supervisor.FirstName} {supervisor.LastName} from {activity.Description}?", $"Removing {supervisor.FirstName} {supervisor.LastName}", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    supervisorService.RemoveSupervisor(supervisor, activity);
                }
            }
        }
    }
}
