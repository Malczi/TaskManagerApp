using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        CheckListsEntities db = new CheckListsEntities();
        public Form1()
        {
            InitializeComponent();
            lblLoginAs.Text = "Witaj "+Environment.UserName+"!";
            showBasicData();
            cbNewTaskWorkersData();
            cbNewTaskPriorityData();
            cbNewTaskCategoryData();
            cbsearchingWorkersData();
            cbsearchingPriorityData();
        }

        private void clearNewTaskTextBox()
        {
            tbNewTaskDescription.Clear();            
        }

        private void defaultValueAfterAddNewTask()
        {
            clearNewTaskTextBox();
            cbNewTaskWorker.SelectedItem = null;
            cbNewTaskWorker.Text = "--Wybierz--";
            cbNewTaskPriority.SelectedItem = null;
            cbNewTaskPriority.Text = "--Wybierz--";
            cbNewTaskCategory.SelectedItem = null;
            cbNewTaskCategory.Text = "--Wybierz--";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void clearLabelSelectedTask()
        {
            lblTaskNumber.Text = "Numer zadania:";
            lblDateOfTask.Text = "Data zlecenia:";
            lblTaskFrom.Text = "Zlecający:";
        }

        private void cbNewTaskWorkersData()
        {
            cbNewTaskWorker.DataSource = this.db.tbl_Workers.ToList();
            cbNewTaskWorker.ValueMember = "IdWorkers";
            cbNewTaskWorker.DisplayMember = "LoginStoart";
            cbNewTaskWorker.SelectedItem = null;
            cbNewTaskWorker.Text = "--Wybierz--";
        }

        private void cbNewTaskPriorityData()
        {
            cbNewTaskPriority.DataSource = this.db.tbl_TaskPriority.ToList();
            cbNewTaskPriority.ValueMember = "IdTaskPriority";
            cbNewTaskPriority.DisplayMember = "PriorityName";
            cbNewTaskPriority.SelectedItem = null;
            cbNewTaskPriority.Text = "--Wybierz--";
        }

        private void cbNewTaskCategoryData()
        {
            cbNewTaskCategory.DataSource = this.db.tbl_TaskCategories.ToList();
            cbNewTaskCategory.ValueMember = "IdCategory";
            cbNewTaskCategory.DisplayMember = "CategoryName";
            cbNewTaskCategory.SelectedItem = null;
            cbNewTaskCategory.Text = "--Wybierz--";
        }

        private void showBasicData() 
        {
            dgvTasks.DataSource = this.db.kwe_Tasks.ToList(); 
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.Columns[1].Visible = false;
            this.dgvTasks.Columns[4].Visible = false;
            this.dgvTasks.Columns[9].Visible = false;
            this.dgvTasks.Columns[11].Visible = false;
            this.dgvTasks.Columns[0].HeaderText = "Numer zlecenia";
            this.dgvTasks.Columns[0].Width = 80;
            this.dgvTasks.Columns[2].HeaderText = "Kategoria";
            this.dgvTasks.Columns[2].Width = 80;
            this.dgvTasks.Columns[3].HeaderText = "Zadanie";
            this.dgvTasks.Columns[3].Width = 400;
            this.dgvTasks.Columns[5].HeaderText = "Zlecający";
            this.dgvTasks.Columns[5].Width = 80;
            this.dgvTasks.Columns[6].HeaderText = "Data zlecenia";
            this.dgvTasks.Columns[6].Width = 90;
            this.dgvTasks.Columns[7].HeaderText = "Data wdrożenia";
            this.dgvTasks.Columns[7].Width = 90;
            this.dgvTasks.Columns[8].HeaderText = "Status zlecenia";
            this.dgvTasks.Columns[8].Width = 80;
            this.dgvTasks.Columns[10].HeaderText = "Priorytet zlecenia";
            this.dgvTasks.Columns[10].Width = 80;
            clearLabelSelectedTask();
        }

        private void showAddedData()
        {
            dgvTasks.DataSource = this.db.kwe_Tasks.Where(a=>a.IdTaskStatus==1).ToList();
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.Columns[1].Visible = false;
            this.dgvTasks.Columns[4].Visible = false;
            this.dgvTasks.Columns[9].Visible = false;
            this.dgvTasks.Columns[11].Visible = false;
            this.dgvTasks.Columns[0].HeaderText = "Numer zlecenia";
            this.dgvTasks.Columns[0].Width = 80;
            this.dgvTasks.Columns[2].HeaderText = "Kategoria";
            this.dgvTasks.Columns[2].Width = 80;
            this.dgvTasks.Columns[3].HeaderText = "Zadanie";
            this.dgvTasks.Columns[3].Width = 400;
            this.dgvTasks.Columns[5].HeaderText = "Zlecający";
            this.dgvTasks.Columns[5].Width = 80;
            this.dgvTasks.Columns[6].HeaderText = "Data zlecenia";
            this.dgvTasks.Columns[6].Width = 90;
            this.dgvTasks.Columns[7].HeaderText = "Data wdrożenia";
            this.dgvTasks.Columns[7].Width = 90;
            this.dgvTasks.Columns[8].HeaderText = "Status zlecenia";
            this.dgvTasks.Columns[8].Width = 80;
            this.dgvTasks.Columns[10].HeaderText = "Priorytet zlecenia";
            this.dgvTasks.Columns[10].Width = 80;
            clearLabelSelectedTask();
        }

        private void showInProgressData()
        {
            dgvTasks.DataSource = this.db.kwe_Tasks.Where(a => a.IdTaskStatus == 2).ToList();
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.Columns[1].Visible = false;
            this.dgvTasks.Columns[4].Visible = false;
            this.dgvTasks.Columns[9].Visible = false;
            this.dgvTasks.Columns[11].Visible = false;
            this.dgvTasks.Columns[0].HeaderText = "Numer zlecenia";
            this.dgvTasks.Columns[0].Width = 80;
            this.dgvTasks.Columns[2].HeaderText = "Kategoria";
            this.dgvTasks.Columns[2].Width = 80;
            this.dgvTasks.Columns[3].HeaderText = "Zadanie";
            this.dgvTasks.Columns[3].Width = 400;
            this.dgvTasks.Columns[5].HeaderText = "Zlecający";
            this.dgvTasks.Columns[5].Width = 80;
            this.dgvTasks.Columns[6].HeaderText = "Data zlecenia";
            this.dgvTasks.Columns[6].Width = 90;
            this.dgvTasks.Columns[7].HeaderText = "Data wdrożenia";
            this.dgvTasks.Columns[7].Width = 90;
            this.dgvTasks.Columns[8].HeaderText = "Status zlecenia";
            this.dgvTasks.Columns[8].Width = 80;
            this.dgvTasks.Columns[10].HeaderText = "Priorytet zlecenia";
            this.dgvTasks.Columns[10].Width = 80;
            clearLabelSelectedTask();
        }

        private void showTestingData()
        {
            dgvTasks.DataSource = this.db.kwe_Tasks.Where(a => a.IdTaskStatus == 3).ToList();
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.Columns[1].Visible = false;
            this.dgvTasks.Columns[4].Visible = false;
            this.dgvTasks.Columns[9].Visible = false;
            this.dgvTasks.Columns[11].Visible = false;
            this.dgvTasks.Columns[0].HeaderText = "Numer zlecenia";
            this.dgvTasks.Columns[0].Width = 80;
            this.dgvTasks.Columns[2].HeaderText = "Kategoria";
            this.dgvTasks.Columns[2].Width = 80;
            this.dgvTasks.Columns[3].HeaderText = "Zadanie";
            this.dgvTasks.Columns[3].Width = 400;
            this.dgvTasks.Columns[5].HeaderText = "Zlecający";
            this.dgvTasks.Columns[5].Width = 80;
            this.dgvTasks.Columns[6].HeaderText = "Data zlecenia";
            this.dgvTasks.Columns[6].Width = 90;
            this.dgvTasks.Columns[7].HeaderText = "Data wdrożenia";
            this.dgvTasks.Columns[7].Width = 90;
            this.dgvTasks.Columns[8].HeaderText = "Status zlecenia";
            this.dgvTasks.Columns[8].Width = 80;
            this.dgvTasks.Columns[10].HeaderText = "Priorytet zlecenia";
            this.dgvTasks.Columns[10].Width = 80;
            clearLabelSelectedTask();
        }

        private void showConfirmedData()
        {
            dgvTasks.DataSource = this.db.kwe_Tasks.Where(a => a.IdTaskStatus == 4).ToList();
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.Columns[1].Visible = false;
            this.dgvTasks.Columns[4].Visible = false;
            this.dgvTasks.Columns[9].Visible = false;
            this.dgvTasks.Columns[11].Visible = false;
            this.dgvTasks.Columns[0].HeaderText = "Numer zlecenia";
            this.dgvTasks.Columns[0].Width = 80;
            this.dgvTasks.Columns[2].HeaderText = "Kategoria";
            this.dgvTasks.Columns[2].Width = 80;
            this.dgvTasks.Columns[3].HeaderText = "Zadanie";
            this.dgvTasks.Columns[3].Width = 400;
            this.dgvTasks.Columns[5].HeaderText = "Zlecający";
            this.dgvTasks.Columns[5].Width = 80;
            this.dgvTasks.Columns[6].HeaderText = "Data zlecenia";
            this.dgvTasks.Columns[6].Width = 90;
            this.dgvTasks.Columns[7].HeaderText = "Data wdrożenia";
            this.dgvTasks.Columns[7].Width = 90;
            this.dgvTasks.Columns[8].HeaderText = "Status zlecenia";
            this.dgvTasks.Columns[8].Width = 80;
            this.dgvTasks.Columns[10].HeaderText = "Priorytet zlecenia";
            this.dgvTasks.Columns[10].Width = 80;
            clearLabelSelectedTask();
        }

        private void brnMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdded_Click(object sender, EventArgs e)
        {
            showAddedData();
            clearActiveTask();
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            showInProgressData();
            clearActiveTask();
        }

        private void btnTesting_Click(object sender, EventArgs e)
        {
            showTestingData();
            clearActiveTask();
        }

        private void btnConfirmed_Click(object sender, EventArgs e)
        {
            showConfirmedData();
            clearActiveTask();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            showBasicData();
            clearActiveTask();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNewTaskDescription.Text))

            {
                MessageBox.Show("Uzupełnij treść zlecenia!");
            }
            else
            {
                int selectedWorkersInt = int.Parse(cbNewTaskWorker.SelectedValue.ToString());
                int selectedCategoryInt = int.Parse(cbNewTaskCategory.SelectedValue.ToString());
                int selectedPriorityInt = int.Parse(cbNewTaskPriority.SelectedValue.ToString());
                tbl_Tasks newTask = new tbl_Tasks();
                newTask.TaskName = tbNewTaskDescription.Text;
                newTask.IdWorkers = selectedWorkersInt;
                newTask.IdCategory = selectedCategoryInt;
                newTask.IdTaskPriority = selectedPriorityInt;
                newTask.StartTime = DateTime.Now;
                newTask.IdStatus = 1;
                this.db.tbl_Tasks.Add(newTask);
                this.db.SaveChanges();
                MessageBox.Show("Dodano nowe zlecenie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showBasicData();
                defaultValueAfterAddNewTask();
                clearLabelSelectedTask();
            }
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbSelectedTaskDescription.Text = this.dgvTasks.CurrentRow.Cells[3].Value.ToString();
            int selectedCategoryInt = int.Parse(this.dgvTasks.CurrentRow.Cells[1].Value.ToString());
            int selectedPriorityInt = int.Parse(this.dgvTasks.CurrentRow.Cells[11].Value.ToString());
            int selectetStatusInt = int.Parse(this.dgvTasks.CurrentRow.Cells[9].Value.ToString());
            cbSelectedTaskCategory.DataSource = this.db.tbl_TaskCategories.ToList();
            cbSelectedTaskCategory.ValueMember = "IdCategory";
            cbSelectedTaskCategory.DisplayMember = "CategoryName";
            cbSelectedTaskCategory.SelectedValue = selectedCategoryInt;
            cbSelectedTaskPriority.DataSource = this.db.tbl_TaskPriority.ToList();
            cbSelectedTaskPriority.ValueMember = "IdTaskPriority";
            cbSelectedTaskPriority.DisplayMember = "PriorityName";
            cbSelectedTaskPriority.SelectedValue = selectedPriorityInt;
            cbSelectedStatus.DataSource = this.db.tbl_TaskStatus.ToList();
            cbSelectedStatus.ValueMember = "IdTaskStatus";
            cbSelectedStatus.DisplayMember = "StatusName";
            cbSelectedStatus.SelectedValue = selectetStatusInt;
            lblTaskNumber.Text = "Numer zadania: "+ this.dgvTasks.CurrentRow.Cells[0].Value.ToString();
            lblDateOfTask.Text = "Data zlecenia: " + this.dgvTasks.CurrentRow.Cells[6].Value.ToString();
            lblTaskFrom.Text = "Zlecający: "+ this.dgvTasks.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnPushChanges_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSelectedTaskDescription.Text))

            {
                MessageBox.Show("Uzupełnij treść zlecenia!");
            }
            else
            {
                int currentTaskId = int.Parse(dgvTasks.CurrentRow.Cells[0].Value.ToString());
                string newTaskText = tbSelectedTaskDescription.Text;
                int newPriorityId = int.Parse(cbSelectedTaskPriority.SelectedValue.ToString());
                int newCategoryId = int.Parse(cbSelectedTaskCategory.SelectedValue.ToString());
                int newStatusId = int.Parse(cbSelectedStatus.SelectedValue.ToString());
                tbl_Tasks result = db.tbl_Tasks.SingleOrDefault(b => b.IdTask == currentTaskId);
                if (result != null)
                {
                    result.TaskName = newTaskText;
                    result.IdTaskPriority = newPriorityId;
                    result.IdCategory = newCategoryId;
                    result.IdStatus = newStatusId;
                    if (newStatusId == 4)
                    {
                        result.EndTime = DateTime.Now;
                    }
                    else
                    {
                        result.EndTime = null;
                    }
                    db.SaveChanges();
                }
                MessageBox.Show("Poprawnie zaktualizowano.");
                clearActiveTask();
                showBasicData();
                clearLabelSelectedTask();

            }
        }

        private void clearActiveTask()
        {
            tbSelectedTaskDescription.Clear();
            cbSelectedStatus.SelectedItem = null;
            cbSelectedTaskCategory.SelectedItem = null;
            cbSelectedTaskPriority.SelectedItem = null;

        }

        private void btnDelTask_Click(object sender, EventArgs e)
        {
            int selectedRowINT = int.Parse(this.dgvTasks.CurrentRow.Cells[0].Value.ToString());
            tbl_Tasks selectedTask = db.tbl_Tasks.Single(a => a.IdTask == selectedRowINT);
            if (selectedRowINT != 0)
            {
                DialogResult result = MessageBox.Show($"Czy chcesz usunąć zlecenie numer: {selectedTask.IdTask}?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        this.db.tbl_Tasks.Remove(selectedTask);
                        this.db.SaveChanges();
                        MessageBox.Show("Zlecenie zostało usunięte!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showBasicData();
                        clearActiveTask();
                        clearLabelSelectedTask();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie można usunąć zlecenia", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void cbsearchingWorkersData()
        {
            cbSearchingWorker.DataSource = this.db.tbl_Workers.ToList();
            cbSearchingWorker.ValueMember = "IdWorkers";
            cbSearchingWorker.DisplayMember = "LoginStoart";
            cbSearchingWorker.SelectedItem = null;
            cbSearchingWorker.Text = "--Wybierz--";
        }

        private void cbsearchingPriorityData()
        {
            cbSearchingPriority.DataSource = this.db.tbl_TaskPriority.ToList();
            cbSearchingPriority.ValueMember = "IdTaskPriority";
            cbSearchingPriority.DisplayMember = "PriorityName";
            cbSearchingPriority.SelectedItem = null;
            cbSearchingPriority.Text = "--Wybierz--";
        }

        private void searchWorkers()
        {
            try
            {
                string searchWorkersString = this.cbSearchingWorker.GetItemText(this.cbSearchingWorker.SelectedItem);
                List<kwe_Tasks> searchWorkersName = db.kwe_Tasks.Where(a => a.LoginStoart == searchWorkersString).ToList();
                if (searchWorkersName.Count() > 0)
                {
                    this.dgvTasks.DataSource = searchWorkersName;
                    cbSearchingWorker.SelectedItem = null;
                    cbSearchingWorker.Text = "--Wybierz--";
                }
                else
                {
                    MessageBox.Show($"Wyszukiwany zadanie dla pracownika: {searchWorkersString} nie istnieje");
                }
            }
            catch (Exception)
            {
                cbSearchingWorker.SelectedItem = null;
                cbSearchingWorker.Text = "--Wybierz--";
                MessageBox.Show("Błędny login!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchData()
        {
            try
            {
                string searchPriorityString = this.cbSearchingPriority.GetItemText(this.cbSearchingPriority.SelectedItem);
                string searchWorkersString = this.cbSearchingWorker.GetItemText(this.cbSearchingWorker.SelectedItem);
                List<kwe_Tasks> searchPriorityName = db.kwe_Tasks.Where(a => a.PriorityName == searchPriorityString && a.LoginStoart == searchWorkersString ).ToList();
                if (searchPriorityName.Count() > 0)
                {
                    this.dgvTasks.DataSource = searchPriorityName;
                    cbSearchingPriority.SelectedItem = null;
                    cbSearchingPriority.Text = "--Wybierz--";
                    cbSearchingWorker.SelectedItem = null;
                    cbSearchingWorker.Text = "--Wybierz--";
                }
                else
                {
                    MessageBox.Show($"Wyszukiwany zadanie dla: {searchWorkersString} o prioriytecie {searchPriorityString} nie istnieje");
                }
            }
            catch (Exception)
            {
                cbSearchingWorker.SelectedItem = null;
                cbSearchingWorker.Text = "--Wybierz--";
                cbSearchingPriority.SelectedItem = null;
                cbSearchingPriority.Text = "--Wybierz--";
                MessageBox.Show("Błędne dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchPriority()
        {
            try
            {
                string searchPriorityString = this.cbSearchingPriority.GetItemText(this.cbSearchingPriority.SelectedItem);
                List<kwe_Tasks> searchPriorityName = db.kwe_Tasks.Where(a => a.PriorityName == searchPriorityString).ToList();
                if (searchPriorityName.Count() > 0)
                {
                    this.dgvTasks.DataSource = searchPriorityName;
                    cbSearchingPriority.SelectedItem = null;
                    cbSearchingPriority.Text = "--Wybierz--";
                    cbSearchingWorker.SelectedItem = null;
                    cbSearchingWorker.Text = "--Wybierz--";
                }
                else
                {
                    MessageBox.Show($"Wyszukiwany priorytet: {searchPriorityString} nie istnieje");
                }
            }
            catch (Exception)
            {
                cbSearchingWorker.SelectedItem = null;
                cbSearchingWorker.Text = "--Wybierz--";
                cbSearchingPriority.SelectedItem = null;
                cbSearchingPriority.Text = "--Wybierz--";
                MessageBox.Show("Błędne dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (cbSearchingWorker.Text != "--Wybierz--" && cbSearchingPriority.Text != "--Wybierz--")
                choose = "Double";
            if (cbSearchingPriority.Text != "--Wybierz--" && cbSearchingWorker.Text == "--Wybierz--")
                choose = "Priority";
            if (cbSearchingWorker.Text != "--Wybierz--" && cbSearchingPriority.Text == "--Wybierz--")
                choose = "Workers";
            switch (choose)
            {
                case "Double":
                    searchData();
                    break;
                case "Workers":
                    searchWorkers(); 
                    break;
                case "Priority":
                    searchPriority();
                    break;
                default:
                    wrongData();
                    break;
            }
        }

        private void wrongData()
        {
            MessageBox.Show("Wybierz dane wyszukiwania!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showBasicData();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormOprions formOprions = new FormOprions(db);
            formOprions.FormClosing += FormOprions_FormClosing;
            formOprions.ShowDialog();
        }

        private void FormOprions_FormClosing(object sender, FormClosingEventArgs e)
        {
            cbNewTaskWorkersData();
            cbNewTaskCategoryData();
        }
    }
}
