using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class FormOprions : Form
    {
        CheckListsEntities db;
        public FormOprions(CheckListsEntities db)
        {
            InitializeComponent();
            this.db = db;
            cbWorkerToDelData();
            cbCategoryToDelData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbWorkerToDelData()
        {
            cbWorkerToDel.DataSource = this.db.tbl_Workers.ToList();
            cbWorkerToDel.ValueMember = "IdWorkers";
            cbWorkerToDel.DisplayMember = "LoginStoart";
            cbWorkerToDel.SelectedItem = null;
            cbWorkerToDel.Text = "--Wybierz--";
        }

        private void cbCategoryToDelData()
        {
            cbCategoryToDel.DataSource = this.db.tbl_TaskCategories.ToList();
            cbCategoryToDel.ValueMember = "IdCategory";
            cbCategoryToDel.DisplayMember = "CategoryName";
            cbCategoryToDel.SelectedItem = null;
            cbCategoryToDel.Text = "--Wybierz--";
        }

        private void clearNewWorkerTb()
        {
            tbNewNameWorker.Clear();
            tbNewSurnameWorker.Clear();
        }

        private void clearNewCategoryTb()
        {
            tbNewTaskCategory.Clear();
        }

        private void brnMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int selectedWorkerInt = int.Parse(cbWorkerToDel.SelectedValue.ToString());
            tbl_Workers selectedWorkder = db.tbl_Workers.Single(a => a.IdWorkers == selectedWorkerInt);
            if (selectedWorkerInt != 0)
            {
                DialogResult result = MessageBox.Show($"Czy chcesz usunąć pracownika: {selectedWorkder.LoginStoart}?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        this.db.tbl_Workers.Remove(selectedWorkder);
                        this.db.SaveChanges();
                        cbWorkerToDelData();
                        MessageBox.Show("Pracownik został usunięty!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie można usunąć pracownika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else 
                {
                    cbWorkerToDel.SelectedItem = null;
                    cbWorkerToDel.Text = "--Wybierz--";
                }
            }
        }

        private void btnDelCategory_Click(object sender, EventArgs e)
        {
            int selectedCategoryInt = int.Parse(cbCategoryToDel.SelectedValue.ToString());
            tbl_TaskCategories selectedCategory = db.tbl_TaskCategories.Single(a => a.IdCategory == selectedCategoryInt);
            if (selectedCategoryInt != 0)
            {
                DialogResult result = MessageBox.Show($"Czy chcesz usunąć kategorię: {selectedCategory.CategoryName}?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        this.db.tbl_TaskCategories.Remove(selectedCategory);
                        this.db.SaveChanges();
                        cbCategoryToDelData();
                        MessageBox.Show("Kategoria została usunięta!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie można usunąć lategorii", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    cbCategoryToDel.SelectedItem = null;
                    cbCategoryToDel.Text = "--Wybierz--";
                }
            }
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNewNameWorker.Text) || String.IsNullOrEmpty(tbNewSurnameWorker.Text))

            {
                MessageBox.Show("Uzupełnij brakujące dane!");
            }
            else
            {
                tbl_Workers newWorker = new tbl_Workers();
                newWorker.Imię = tbNewNameWorker.Text;
                newWorker.Nazwisko = tbNewSurnameWorker.Text;
                newWorker.LoginStoart = tbNewNameWorker.Text.Substring(0, 1).ToLower() +(tbNewSurnameWorker.Text).ToLower();
                this.db.tbl_Workers.Add(newWorker);
                this.db.SaveChanges();
                MessageBox.Show("Dodano nowego pracownika!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearNewWorkerTb();
                cbWorkerToDelData();
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNewTaskCategory.Text))

            {
                MessageBox.Show("Uzupełnij brakujące dane!");
            }
            else
            {
                tbl_TaskCategories newCategory = new tbl_TaskCategories();
                newCategory.CategoryName = tbNewTaskCategory.Text;
                this.db.tbl_TaskCategories.Add(newCategory);
                this.db.SaveChanges();
                MessageBox.Show("Dodano nową kategorię", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearNewCategoryTb();
                cbCategoryToDelData();
            }
        }
    }
}
